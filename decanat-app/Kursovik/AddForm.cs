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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public void Add(Student st)
        { 
                st.Name = (string)nameBox.Text;
                st.Age = Convert.ToInt32(ageBox.Text);
                st.Group = (string)GroupBox.Text;
                st.Kurs = Convert.ToInt32(KursBox.Text);
                st.Stud_bilet();
                st.Col_Dolg = Convert.ToInt32(DolgBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Student st = null;
            Form1 f = this.Owner as Form1;
            if (((string)OtdelBox.Text) == "Дистанционное отделение") st = new Student_Distancionniy();
            if (((string)OtdelBox.Text) == "Заочное отделение") st = new Student_Zaochniy();
            if (((string)OtdelBox.Text) == "Дневное отделение") st = new Student_Dnevnoy();
            try
            {
                Add(st);
                if ((string)OtdelBox.Text == "Дневное отделение") ((OtdelenieEvent)f.dekanat[0]).Add(st);
                else ((OtdelenieEvent)f.dekanat[1]).Add(st);
                f.CreateTable();
                MessageBox.Show("Студент добавлен.\n" + st.ToString());
                f.TextJournal();
                Close();
            }
            catch
            {
                MessageBox.Show("Неверное значение одного из полей!");
            }
        }

        private void ageBox_TextChanged(object sender, EventArgs e) // проверка на ввод букв в поле Возраст
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

        private void nameBox_TextChanged(object sender, EventArgs e) // проверка на ввод цифр в поле Имя
        {
            string mas = nameBox.Text;
            foreach (char q in mas)
                if (q >= '0' && q <= '9') nameBox.Clear();
        }
    }
}
