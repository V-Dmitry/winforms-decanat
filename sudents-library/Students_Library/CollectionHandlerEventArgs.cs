using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Library
{
    public class CollectionHandlerEventArgs: System.EventArgs
    {
        public string OtdelName { get; set; } // название отделения
        public string StudBilet { get; set; } // номер студенческого билета
        public string StudentName { get; set; } // ФИО студента
        public string Action { get; set; } // действие, выполненное над объектом

        public CollectionHandlerEventArgs(string otdel_name, string student_name, string stud_bilet, string action)
        {
            OtdelName = otdel_name;
            StudentName = student_name;
            StudBilet = stud_bilet;
            Action = action;
        }

        public override string ToString()
        {
            string sn = "Отделение: " + OtdelName + "; ";
            string bn = "ФИО: " + StudentName + "; ";
            string act = "Действие: " + Action + ".";
            return sn + bn + act;
        }
    }
}
