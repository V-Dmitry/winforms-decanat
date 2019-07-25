using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students_Library;

namespace Kursovik
{
    public partial class EditForm : Form
    {
        Student st; // объект для хранения изменяемого объекта
        public EditForm()
        {
            InitializeComponent();
        }

        public void Edit(Form1 f, string key) // изменение объекта
        {
            f = Owner as Form1;
            for(int i = 0; i < 2;i++)
            {
                ICollection<string> keys = f.dekanat[i].Keys;
                foreach(string key1 in keys)
                {
                    if(f.dekanat[i][key1].Stud_Bilet == key)
                    {
                        st = f.dekanat[i][key];
                    }
                }
            }
            nameBox.Text = st.Name;
            ageBox.Text = Convert.ToString(st.Age);
            GroupBox.Text = st.Group;
            OtdelBox.Text = st.Type_Study;
            KursBox.Text = Convert.ToString(st.Kurs);
            dolgBox.Text = Convert.ToString(st.Col_Dolg);
        }

        public void Save_Edit() // сохранение изменений
        {
            try
            {
                st.Name = (string)nameBox.Text;
                st.Age = Convert.ToInt32(ageBox.Text);
                st.Group = (string)GroupBox.Text;
                st.Type_Study = (string)OtdelBox.Text;
                st.Kurs = Convert.ToInt32(KursBox.Text);
                st.Col_Dolg = Convert.ToInt32(dolgBox.Text);
                Form1 f = this.Owner as Form1;
                for (int i = 0; i < 2; i++)
                {
                    ICollection<string> keys = f.dekanat[i].Keys;
                    foreach (string key in keys)
                    {
                        if (f.dekanat[i][key].Stud_Bilet == st.Stud_Bilet)
                        {
                            ((OtdelenieEvent)f.dekanat[i])[key] = st;
                            break;
                        }

                    }
                }
                f.CreateTable();
                MessageBox.Show("Изменения успешно сохранены");
                f.TextJournal();
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save_Edit();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)// проверка на ввод цифр в поле Имя
        {
            string mas = nameBox.Text;
            foreach (char q in mas)
                if (q >= '0' && q <= '9') nameBox.Clear();
        } 

        private void ageBox_TextChanged(object sender, EventArgs e)// проверка на ввод букв в поле Возраст
        {
            try
            {
                Convert.ToInt32(ageBox.Text);
            }
            catch
            {
                ageBox.Clear();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
