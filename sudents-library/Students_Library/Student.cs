using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Library
{
    [Serializable]
    public abstract class Student
    {
        protected static string[] fn = { "Провков", "Николаев", "Андреев", "Андреева", "Петров", "Иванов", "Петрова", "Иванова", "Пермяков", "Пермякова" };
        protected static string[] nm = { "Виктор", "Дмитрий", "Александр", "Евгений", "Сергей"};
        protected static string[] ng = { "Ольга", "Екатерина", "Анна", "Юлия", "Яна", "Ксения" };
        protected static string[] g = { "АСУ", "АТ", "РИС", "АТПП", "ЭС", "ИН" , "ЭВТ"};
        protected static Random rnd = new Random();
        
        static int count_of_students = 0;

        string name;
        int age;
        const string faculty = "ЭТФ";
        string group;
        int kurs;
        string stud_bilet;
        string type_study;
        int col_dolg;

        public Student() 
        {
            name = "";
            age = 0;
            group = "";
            kurs = 0;
            col_dolg = 0;
            stud_bilet = "";
            count_of_students++;
        }

        public Student(string name, int age, string group, int kurs, int col_dolg, string otdelenie) 
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.kurs = kurs;
            this.col_dolg = col_dolg;
            type_study = otdelenie;
            count_of_students++;
            Stud_bilet();
        }
        public string Name // свойства для доступа к полю Name(имя)
        {
            get
            {
                if (name != "") return name;
                else
                {
                    return "Имя отсутствует";
                }
            }
            set
            {
                if (value != "") name = value;
                else throw new MyException("Поле 'Имя' не может быть пустым!");
            }
        }
        public int Age // свойства для доступа к полю Age(возраст)
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 100) throw new MyException("Возможно введёно неверное значение возраста!");
                else age = value;
            }
        }
        public string Faculty // свойства для доступа к полю Faculty(факультет)
        {
            get
            {
                return faculty;
            }
        }
        public string Group // свойства   для доступа к полю Group(группа)
        {
            get
            {
                if (group == "") return "Группа отсутствует";
                else return group;
            }
            set
            {
                if (value == "") throw new MyException("Поле 'Группа' не может быть пустым!");
                else group = value;
            }
        }
        public int Kurs // свойства для доступа к полю Kurs(курс)
        {
            get
            {
                if (kurs == 0) return 0;
                else return kurs;
            }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new MyException("Неверный курс!");
                    kurs = 0;
                }
                else kurs = value;
            }
        }
        public int Col_Dolg // свойство для доступа к полю col_dolg(кол-во долгов)
        {
            get
            {
                return col_dolg;
            }
            set
            {
                if (value < 0) throw new MyException("Некорректное значение!");
                else col_dolg = value;
            }
        }
        public string Type_Study // свойство для доступа к полю type_study(отделение)
        {
            get { return type_study; }
            set
            {
                if (type_study == "") throw new MyException("Поле 'Отделение' не может быть пустым!");
                type_study = value;
            }
        }
        protected static string Auto_Name(string first_name) // метод для автоматического создания имени
        {
            string Name = "";
            if (first_name[first_name.Length-1] == 'а') Name = ng[rnd.Next(0, 5)];
            else Name = nm[rnd.Next(0, 4)];
            return first_name + " " + Name;
        }
        public string Stud_Bilet // свойство для доступа к полю stud_bilet(студенческий билет)
        {
            get { return stud_bilet; }
            protected set { stud_bilet = value; }
        }
        public virtual void Stud_bilet() // генерация студенческого билета
        {
            string s;
            if (count_of_students < 10) s = "000";
            else if (count_of_students >= 10 && count_of_students < 100) s = "00";
            else if (count_of_students >= 100 && count_of_students < 1000) s = "0";
            else s = "";
            stud_bilet = "" + group + "-" + s + count_of_students;
        }
        public virtual new string ToString() // виртуальный метод формирования строки для вывода информации на экран
        {
            string s = "--------------------";
            s += "\nИмя: "; s += Name;
            s += "\nВозраст: "; s += Age;
            s += "\nФакультет: "; s += Faculty;
            s += "\nГруппа: "; s += Group;
            s += "\nКурс: "; s += Kurs;
            s += "\nНомер студ. билета: "; s += Stud_Bilet;
            s += "\nКол-во долгов: "; s += col_dolg;
            return s;
        }
    }
}
