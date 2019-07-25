using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Library
{
    [Serializable]
    public class JournalEntry
    {
        public string OtdelName { get; set; }     // Название отдела
        public string StudentName { get; set; }     // ФИО
        public string StudBilet { get; set; }       // Студенческий билет
        public string Action { get; set; }          // Действие

        public JournalEntry(string otdelname, string stdname, string action, string studbilet)
        {
            OtdelName = otdelname;
            StudentName = stdname;
            StudBilet = studbilet;
            Action = action;
        }

        public override string ToString()
        {
            string on = "\nОтделение: " + OtdelName + ".";
            string sb = "\nСтуд.Билет: " + StudBilet + ".";
            string stn = "\nФИО: " + StudentName + ".";
            string act = "\nДействие: " + Action + ".";
            return on + sb + stn + act;
        }

    }
}
