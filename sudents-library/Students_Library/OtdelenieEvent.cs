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
    public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);

    [Serializable]
    public class OtdelenieEvent: Otdelenie
    {
        public event CollectionHandler CollectionCountChanged;      // Событие на изменение количества
        public event CollectionHandler CollectionObjectChanged;     // Событие на изменение объекта

        public OtdelenieEvent():base() { }

        public OtdelenieEvent(string name):base(name) { }

        protected OtdelenieEvent(SerializationInfo info, StreamingContext context): base(info, context) { }


        public void OnCollectionCountChanged(object source, CollectionHandlerEventArgs e)// метод для вызова события на изменение кол-ва элементов
        {
            if (CollectionCountChanged != null)
            {
                CollectionCountChanged(source, e);
            }
        }
        public void OnCollectionObjectChanged(object source, CollectionHandlerEventArgs e) // метод для вызова события на изменение элемента
        {
            if (CollectionObjectChanged != null)
            {
                CollectionObjectChanged(source, e);
            }
        }

        public new Student this[string key] // индексатор
        {
            get
            {
                return base[key];
            }
            set
            {
                if (base.ContainsKey(key))
                {
                    this.Name = TryGetValue(key).Type_Study;
                    OnCollectionObjectChanged(this, new CollectionHandlerEventArgs(this.Name, TryGetValue(key).Name, TryGetValue(key).Stud_Bilet, "Изменение записи в базе"));
                    base[key] = value;
                }
                else {
                    throw new MyException("Запрашиваемого элемента не существует в базе.");
                }
            }
        }

        public override void Add(Student student) // переопределенный метод добавления с вызовом события
        {
            this.Name = student.Type_Study;
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, student.Name, student.Stud_Bilet, "Добавление в отдел"));
            base.Add(student);
        }

        public override void Remove(string key)// переопределенный метод удаления с вызовом события
        {
            this.Name = TryGetValue(key).Type_Study;
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, TryGetValue(key).Name, TryGetValue(key).Stud_Bilet, "Удаление из отдела"));
            base.Remove(key);
        }
    }
}
