using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace Students_Library
{
    [Serializable]
    public class Otdelenie: Dictionary<string, Student>
    {
        static Random rnd = new Random();

        public Otdelenie():base()
        {
            Name = "NoName";
        }
        public Otdelenie(string name):base()
        {  
            Name = name;
        }

        protected Otdelenie(SerializationInfo info, StreamingContext context): base(info, context) { } // конструктор для десериализации


        public string Name { get; set; }      // Название отделения


        public virtual void Add(Student student) // добавление в коллекцию
        {
            base.Add(student.Stud_Bilet, student);
        }
        public virtual new void Remove(string bilet) // удаление из коллекции
        {
            base.Remove(bilet);
        }
        public new void Clear() // очистка коллекции
        {
            base.Clear();
        }
        public int Length // свойство для получения кол-ва элементов в коллекции
        {
            get
            {
                return base.Count;
            }
        }
        public new Student this[string bilet] // индексатор
        {
            get
            {
                if (base.ContainsKey(bilet))
                {
                    return base[bilet];
                }
                else throw new MyException("Запрашиваемого элемента не существует!");
            }
            set
            {
                if (base.ContainsKey(bilet))
                {
                    base[bilet] = value;
                }
                else throw new MyException("Запрашиваемого элемента не существует!");
            }
        }
        public new ICollection<Student> Values // свойство для получения значений
        {        
            get
            {
                return base.Values;
            }
        }
        public new ICollection<string> Keys // свойство для получения ключей
        {               
            get
            {
                return base.Keys;
            }
        }
        public Student TryGetValue(string bilet) // получение значения через ключ
        {
            Student student;

            if (TryGetValue(bilet, out student))  return student;

            throw new MyException("Запрашиваемого элемента не существует!");

        }

        public static OtdelenieEvent Auto_Dnevnoe(int count_Dnevnoy) // генерация дневного отделения
        {
            OtdelenieEvent my = new OtdelenieEvent();
            
            for(int i = 0;i < count_Dnevnoy;i++)
            {
                Student_Dnevnoy std = Student_Dnevnoy.Auto_Student();
                my.Add(std);
            }
            return my;
        }

        public static OtdelenieEvent Auto_Zaochnoe_Distancionnoe(int count_Zaochniki, int count_Distanc)// генерация зочного и дистанционного отделений
        {
            OtdelenieEvent my = new OtdelenieEvent();

            for (int i = 0; i < count_Zaochniki; i++)
            {
                Student stz = Student_Zaochniy.Auto_Student();
                my.Add(stz);
            }
            for (int i = 0; i < count_Distanc; i++)
            {
                Student stD = Student_Distancionniy.Auto_Student();
                my.Add(stD);
            }

            return my;
        }
    }
}
