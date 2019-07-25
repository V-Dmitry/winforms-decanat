using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students_Library;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursovik
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        ////////******** ПОЛЯ СИСТЕМЫ ДЕКАНАТА ********\\\\\\\\

        #region Pole

        public Journal journal; // журнал для записи изменений
        public OtdelenieEvent Dnevnoe;  // коллекция студентов дневного отделения
        public OtdelenieEvent Zaochnoe_Distancionnoe; // коллекция студентов заочного и дистанционного отделений
        public Dictionary<int, Dictionary<string, Student>> dekanat; // деканат, коллекция отделений
        #endregion

        ////////******** ЗАГРУЗКА ФОРМЫ ********\\\\\\\\

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            New_File();
        }
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        ///////******** РАБОТА С ФАЙЛОМ(БАЗА) *********\\\\\\\\

        #region File
        public void New_File()
        {
            journal = new Journal();
            Zaochnoe_Distancionnoe = new OtdelenieEvent();
            Dnevnoe = new OtdelenieEvent();
            dekanat = new Dictionary<int, Dictionary<string, Student>>();
            dekanat.Add(0, Dnevnoe);
            dekanat.Add(1, Zaochnoe_Distancionnoe);
            ICollection<int> keys = dekanat.Keys;

            foreach (int key in keys)
            {
                ((OtdelenieEvent)dekanat[key]).CollectionCountChanged += new CollectionHandler(journal.CollectionCountChanged);
                ((OtdelenieEvent)dekanat[key]).CollectionObjectChanged += new CollectionHandler(journal.CollectionReferenceChanged);
            }
        }

        public void Save_File()
        {
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFile.FileName;
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dekanat);
                    fs.Close();
                    MessageBox.Show("База успешно сохранена.\nПуть: " + path, "Успех");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        public void Open_File()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string msg = "Сохранить данный файл?";
            string caption = "Подтверждение действия";
            if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
            {
                Save_File();
            }
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFile.FileName;
                    FileStream fs = new FileStream(fileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    dekanat = new Dictionary<int, Dictionary<string, Student>>();
                    dekanat = (Dictionary<int, Dictionary<string, Student>>)bf.Deserialize(fs);
                    ICollection<int> keys = dekanat.Keys;
                    foreach (int key in keys)
                    {
                        ((OtdelenieEvent)dekanat[key]).CollectionCountChanged += new CollectionHandler(journal.CollectionCountChanged);
                        ((OtdelenieEvent)dekanat[key]).CollectionObjectChanged += new CollectionHandler(journal.CollectionReferenceChanged);
                    }
                    fs.Close();
                    journal.Clear();
                    CreateTable();
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат файла. Возможно файл поврежден.");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_File();
        }

        private void новыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string msg = "Сохранить данный файл?";
            string caption = "Подтверждение действия";
            if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
            {
                Save_File();
            }
            JournalBook.Clear();
            Data.Rows.Clear();
            New_File();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_File();
        }

        #endregion

        ////////******** ДЕЙСТВИЯ НАД СТУДЕНТОМ ********\\\\\\\\

        #region Student
        public string GetCurrentKey()
        {
            try
            {
                string bilet = "";
                for (int i = 0; i < 2; i++)
                {
                    ICollection<string> keys = dekanat[i].Keys;
                    foreach (string key in keys)
                    {
                        if (dekanat[i][key].Stud_Bilet == (string)Data.CurrentRow.Cells[0].Value)
                        {
                            bilet = key;
                            break;
                        }

                    }
                }
                return bilet;
            }
            catch
            {
                MessageBox.Show("Ошибка");
                return null;
            }
        }

        public void Edit()
        {
            string bilet = "";
            if (Data.RowCount <= 1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                try
                {
                    bilet = GetCurrentKey();
                    EditForm ef = new EditForm();
                    ef.Owner = this;
                    ef.Edit(this, bilet);
                    ef.Show();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        public void Del_Stud()
        {
            try
            {
                string key = (string)Data.CurrentRow.Cells[0].Value;
                try
                {
                    if (key[key.Length - 1] == 'Д' || key[key.Length - 1] == 'З') ((OtdelenieEvent)dekanat[1]).Remove(key);
                    else ((OtdelenieEvent)dekanat[0]).Remove(key);
                    Data.Rows.RemoveAt(Data.CurrentRow.Index);
                    TextJournal();
                    MessageBox.Show("Студент удален из базы");
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить пустую строку!");
                }

            }
            catch
            {
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            }
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Owner = this;
            form.Show();
        }

        private void изменитьДанныеОСтудентеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Del_Stud();
        }

        private void удалитьИзБазыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.RowCount <= 1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                try
                {
                    DelForm df = new DelForm();
                    df.Owner = this;
                    df.Show();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void отчислитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.RowCount <=1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                DelDolgForm dg = new DelDolgForm();
                dg.Owner = this;
                dg.Show();
            }
            
        }
        #endregion

        ////////******** ПЕРЕВОД ИЗ ОТДЕЛЕНИЯ В ОТДЕЛЕНИЕ ********\\\\\\\\

        #region Otdel
        private void перевестиВДругоеОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bilet = "";
            if (Data.RowCount <= 1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                try
                {
                    bilet = GetCurrentKey();
                    Student st = dekanat[1][bilet];
                    Student_Dnevnoy std = new Student_Dnevnoy(st.Name, st.Age, st.Group, st.Kurs, st.Col_Dolg);
                    ((OtdelenieEvent)dekanat[1]).Remove(bilet);
                    ((OtdelenieEvent)dekanat[0]).Add(std);
                    CreateTable();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
                TextJournal();
            }
        }

        private void перевестиВЗаочноеОтдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bilet = "";
            if (Data.RowCount <= 1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                try
                {
                    Student st;
                    bilet = GetCurrentKey();
                    try
                    {
                        st = dekanat[0][bilet];
                        ((OtdelenieEvent)dekanat[0]).Remove(bilet);
                    }
                    catch
                    {
                        st = dekanat[1][bilet];
                        ((OtdelenieEvent)dekanat[1]).Remove(bilet);
                    }
                    Student_Zaochniy std = new Student_Zaochniy(st.Name, st.Age, st.Group, st.Kurs, st.Col_Dolg);
                    ((OtdelenieEvent)dekanat[1]).Add(std);
                    CreateTable();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            TextJournal();
            }
        }

        private void перевестиВДистанционноеОтдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bilet = "";
            if (Data.RowCount <= 1)
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
            {
                try
                {
                    Student st;
                    bilet = GetCurrentKey();
                    try
                    {
                        st = dekanat[0][bilet];
                        ((OtdelenieEvent)dekanat[0]).Remove(bilet);
                    }
                    catch
                    {
                        st = dekanat[1][bilet];
                        ((OtdelenieEvent)dekanat[1]).Remove(bilet);
                    }
                    Student_Distancionniy std = new Student_Distancionniy(st.Name, st.Age, st.Group, st.Kurs, st.Col_Dolg);
                    ((OtdelenieEvent)dekanat[1]).Add(std);
                    CreateTable();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            TextJournal();
            }
        }
        #endregion

        ////////******** ЗАПОЛНЕНИЕ И ГЕНЕРАЦИЯ ТАБЛИЦЫ ********\\\\\\\\

        #region Gen
        public void CreateTable()
        {
            Data.RowCount = 1;
            Data.RowCount += ((OtdelenieEvent)dekanat[0]).Length;
            Data.RowCount += ((OtdelenieEvent)dekanat[1]).Length;
            Data.ColumnCount = 8;
            var students = (dekanat.Select(x => x.Value.Select(y => y.Value)).Aggregate((l1, l2) => l1)).Union(dekanat.Select(x => x.Value.Select(y => y.Value)).Aggregate((l1, l2) => l2));
            int i = 0;
            foreach (Student st in students)
            {
                Data.Columns[0].Name = "Студ. билет";
                Data.Columns[1].Name = "Имя";
                Data.Columns[2].Name = "Возраст";
                Data.Columns[3].Name = "Факультет";
                Data.Columns[4].Name = "Группа";
                Data.Columns[5].Name = "Курс";
                Data.Columns[6].Name = "Отделение";
                Data.Columns[7].Name = "Кол-во долгов";
                Insert(i, st);
                i++;
            }
        }

        public void Insert(int i, Student st)
        {
            Data.Rows[i].Cells[0].Value = st.Stud_Bilet;
            Data.Rows[i].Cells[1].Value = st.Name;
            Data.Rows[i].Cells[2].Value = st.Age;
            Data.Rows[i].Cells[3].Value = st.Faculty;
            Data.Rows[i].Cells[4].Value = st.Group;
            Data.Rows[i].Cells[5].Value = st.Kurs;
            Data.Rows[i].Cells[6].Value = st.Type_Study;
            Data.Rows[i].Cells[7].Value = st.Col_Dolg;
        }

        public void Auto_Gen()
        {
            dekanat = new Dictionary<int, Dictionary<string, Student>>();
            Dnevnoe = Otdelenie.Auto_Dnevnoe(rnd.Next(10, 50));
            Zaochnoe_Distancionnoe = Otdelenie.Auto_Zaochnoe_Distancionnoe(rnd.Next(20, 40), rnd.Next(10, 30));
            dekanat[0] = Dnevnoe;
            dekanat[1] = Zaochnoe_Distancionnoe;
            ICollection<int> keys = dekanat.Keys;
            foreach (int key in keys)
            {
                ((OtdelenieEvent)dekanat[key]).CollectionCountChanged += new CollectionHandler(journal.CollectionCountChanged);
                ((OtdelenieEvent)dekanat[key]).CollectionObjectChanged += new CollectionHandler(journal.CollectionReferenceChanged);
            }
            CreateTable();
        }

        private void автоматическоеЗаполнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auto_Gen();
        }
        #endregion

        ////////******** РАБОТА С ТАБЛИЦЕЙ ********\\\\\\\\

        #region Tab
        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.Rows.Clear();
        }

        private void buttonNameSearch_Click(object sender, EventArgs e)
        {
            int ok = -1;
            string name = (string)nameSearchBox.Text;
            for (int i = 0; i < Data.RowCount; i++)
            {
                if ((String)Data[1, i].Value == name) { Data.Rows[i].Selected = true; Data.CurrentCell = Data.Rows[i].Cells[0]; ok = 1; }
            }
            if (ok == -1) MessageBox.Show("Элемента с таким именем не существует в списке!");
        }

        private void buttonBiletSearch_Click(object sender, EventArgs e)
        {
            int ok = -1;
            string bilet = (string)biletSearchBox.Text;
            for (int i = 0; i < Data.RowCount; i++)
            {
                if ((string)Data[0, i].Value == bilet) { Data.Rows[i].Selected = true; Data.CurrentCell = Data.Rows[i].Cells[0]; ok = 1; }
            }
            if (ok == -1) MessageBox.Show("Элемента с таким номером билета не существует в списке!");
        }

        private void заполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            string mas = nameSearchBox.Text;
            foreach (char q in mas)
                if (q >= '0' && q <= '9') nameSearchBox.Clear();
        }

        #endregion

        ////////******** РАБОТА С ЖУРНАЛОМ ********\\\\\\\\

        #region Journal
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalBook.Clear();
        }

        public void TextJournal()
        {
            JournalBook.Text = journal.ToString();
        }

        private void загрузитьЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFile.FileName;
                    FileStream fs = new FileStream(fileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    journal = new Journal();
                    journal = (Journal)bf.Deserialize(fs);
                    ICollection<int> keys = dekanat.Keys;
                    foreach (int key in keys)
                    {
                        ((OtdelenieEvent)dekanat[key]).CollectionCountChanged += new CollectionHandler(journal.CollectionCountChanged);
                        ((OtdelenieEvent)dekanat[key]).CollectionObjectChanged += new CollectionHandler(journal.CollectionReferenceChanged);
                    }
                    fs.Close();
                    CreateTable();
                    TextJournal();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void сохранитьЖурналсериализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFile.FileName;
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, journal);
                    fs.Close();
                    MessageBox.Show("Журнал успешно сохранен.\nПуть: " + path, "Успех");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }
        private void удалитьЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalBook.Clear();
            journal.Clear();
            MessageBox.Show("Журнал очищен.");
        }

        private void сохранитьЖурналToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFile.FileName;
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(DateTime.Today);
                    for(int i = 0;i< journal.Length;i++)
                        sw.WriteLine(journal[i]);
                    sw.Close();
                    fs.Close();
                    MessageBox.Show("Журнал успешно сохранен.\nПуть: " + path, "Успех");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        #endregion

        ////////******** ОТБОР В ТАБЛИЦЕ ********\\\\\\\\

        #region Otbor
        private void дневноеОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Rows.Clear();
                Data.RowCount = 1;
                Data.RowCount += ((OtdelenieEvent)dekanat[0]).Length;
                Data.ColumnCount = 8;
                int i = 0;
                ICollection<string> keys = ((OtdelenieEvent)dekanat[0]).Keys;
                foreach (string key in keys)
                {
                    Insert(i, ((OtdelenieEvent)dekanat[0])[key]);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            }
        }

        private void заочноеОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Rows.Clear();
                Data.RowCount = 1;
                Data.RowCount += ((OtdelenieEvent)dekanat[1]).Length;
                Data.ColumnCount = 8;
                int i = 0;
                ICollection<string> keys = ((OtdelenieEvent)dekanat[1]).Keys;
                foreach (string key in keys)
                {
                    if (((OtdelenieEvent)dekanat[1])[key] is Student_Zaochniy)
                    {
                        Insert(i, ((OtdelenieEvent)dekanat[1])[key]);
                        i++;
                    }
                }
            }
            catch
            {
                 MessageBox.Show("Таблица пуста. Действие не возможно!");
            }
        }

        private void дистанционноеОтделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Rows.Clear();
                Data.RowCount = 1; 
                Data.RowCount += ((OtdelenieEvent)dekanat[1]).Length;
                Data.ColumnCount = 8;
                int i = 0;
                ICollection<string> keys = ((OtdelenieEvent)dekanat[1]).Keys;
                foreach (string key in keys)
                {
                    if (((OtdelenieEvent)dekanat[1])[key] is Student_Distancionniy)
                    {
                        Insert(i, ((OtdelenieEvent)dekanat[1])[key]);
                        i++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Таблица пуста. Действие не возможно!");
            }
        }

        private void всеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Data.RowCount == 0) MessageBox.Show("Таблица пуста. Действие не возможно!");
            else
                CreateTable();
        }
        #endregion

        ////////******** ЗАВЕРШЕНИЕ РАБОТЫ ********\\\\\\\\

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string msg = "Сохранить файл перед выходом?";
            string caption = "Подтверждение действия";
            if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
            {
                Save_File();
            }
            Close();
        }
    }
}
