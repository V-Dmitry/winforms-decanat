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
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }

        public void Del_Stud(Form1 f, int key, string name) // удаление элемента
        {
            string msg = "";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            msg = "Вы действительно хотите удалить студента из базы?";
            caption = "Подтверждение действия";
            if (f.dekanat == null) MessageBox.Show("Пусто");
            if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
            {
                int ok = -1;
                var keys = new List<string>(f.dekanat[key].Keys);
                foreach (string key1 in keys)
                {
                    if (f.dekanat[key][key1].Name == name) { ((OtdelenieEvent)f.dekanat[key]).Remove(key1); ok = 1; break; }
                }
                f.CreateTable();
                f.TextJournal();
                if (ok == -1) MessageBox.Show("Запрашиваемого студента не существует в базе");
                else MessageBox.Show("Студент удален из базы");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Form1 f = this.Owner as Form1;
            int key = -1;
            string otdel = "";
            string name = "";
            try
            {
                otdel = (string)OtdelBox.Text;
                name = (string)nameBox.Text;
                if (otdel == "Дневное отделение") key = 0;
                else key = 1;
            }
            catch
            {
                MessageBox.Show("Неверное значение одного из полей!");
            }
            if ((string)nameBox.Text == "" || (string)OtdelBox.Text == "") MessageBox.Show("Неверное значение одного из полей!");
            else
                try
                {
                    Del_Stud(f, key, name);
                }
                catch
                {
                    MessageBox.Show("Неверное значение!");
                }
        }

        private void nameBox_TextChanged(object sender, EventArgs e) // проверка на ввод цифр в поле Имя
        {
            string mas = nameBox.Text;
            foreach (char q in mas)
                if (q >= '0' && q <= '9') nameBox.Clear();
        }
    }
}
