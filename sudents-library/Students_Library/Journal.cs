using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Library
{
    [Serializable]
    public class Journal
    {

        List<JournalEntry> journal;  // Коллекция записей журнала

        public int Length { get { return journal.Count; } }     // Количество записей в журнале

        public Journal()
        {
            journal = new List<JournalEntry>();
        }

        public JournalEntry this[int index] //индексатор
        {
            get
            {
                if (index < 0 || index > (Length - 1))
                {
                    throw new MyException("Ошибка. Выход за пределы массива.");
                }
                else {
                    return journal[index];
                }
            }
        }

        public void CollectionCountChanged(object source, CollectionHandlerEventArgs e)// перехватчик события на изменение кол-ва элементов
        {
            JournalEntry je = new JournalEntry(e.OtdelName, e.StudentName, e.Action, e.StudBilet);
            journal.Add(je);
        }
        public void CollectionReferenceChanged(object source, CollectionHandlerEventArgs e)// перехватчик события на изменение элементов
        {
            JournalEntry je = new JournalEntry(e.OtdelName, e.StudentName, e.Action, e.StudBilet);
            journal.Add(je);
        }

        public override string ToString()
        {
            string str = "";
            int count = 1;
            foreach (var je in journal)
            {
                str += "Запись №" + Convert.ToString(count++) + ":" + je + "\r\n" + "\r\n";
            }
            return str;
        }
        public void Clear() // очистка журнала
        {
            journal.Clear();
        }
    }
}
