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
    public partial class DelDolgForm : Form
    {
        public DelDolgForm()
        {
            InitializeComponent();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Form1 f = Owner as Form1;

            int col_dolg = 0;
            try
            {
                int ch = 0;
                col_dolg = Int32.Parse(DelBox.Text);
                string msg = "";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                msg = "Вы действительно хотите отчислить студентов?";
                caption = "Подтверждение действия";
                if (f.dekanat == null) MessageBox.Show("Пусто");
                if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        var keys = new List<string>(((OtdelenieEvent)f.dekanat[i]).Keys);
                        foreach (string key in keys)
                        {
                            if (f.dekanat[i][key].Col_Dolg >= col_dolg) { ((OtdelenieEvent)f.dekanat[i]).Remove(key); ch++; }
                        }
                    }
                }
                f.CreateTable();
                f.TextJournal();
                if (ch != 0) MessageBox.Show("Должники удалены из базы");
                else MessageBox.Show("Данного количества долгов в списке нет");
            }
            catch
            {
                MessageBox.Show("Неверное значение!");
            }
        }

        private void DelBox_TextChanged(object sender, EventArgs e) // проверка на ввод цифр в поле Кол-во долгов
        {
            try
            {
                Convert.ToInt32(DelBox.Text);
            }
            catch
            {
                DelBox.Clear();
            }
        }
    }
}
