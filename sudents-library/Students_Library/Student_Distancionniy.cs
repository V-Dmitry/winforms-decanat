using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Library
{
    [Serializable]
    public class Student_Distancionniy: Student
    {
        

        public Student_Distancionniy() : base() { Type_Study = "Дистанционное отделение"; }
        public Student_Distancionniy(string name, int age, string group, int kurs, int col_dolg) : base(name, age, group, kurs, col_dolg, "Дистанционное отделение") { }

        public override string ToString()
        {
            return base.ToString() + "\nОтделение: " + Type_Study + "\n--------------------";
        }
        public override void Stud_bilet()
        {
            base.Stud_bilet();
            Stud_Bilet = base.Stud_Bilet + "-" +Type_Study[0];
        }
        public static Student_Distancionniy Auto_Student()
        {
            return new Student_Distancionniy(Auto_Name(fn[rnd.Next(0, 9)]), rnd.Next(18, 24), g[rnd.Next(0, 6)], rnd.Next(1, 6), rnd.Next(0, 4));
        }
    }
}
