using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]  //Указываем у того класса который хотим сереализовать
    public class Group
    {
        [NonSerialized] //Если мы не хотим чтобы что то сериализовывалось. Относится к полям и свойствам. 
        private Random rnd = new Random(DateTime.Now.Millisecond);
        public int Number { get; set; }
        public string Name { get; set; }

        public Group() 
        {
            Number = rnd.Next(1, 10);
            Name = "Группа " + rnd;
        }
        public Group(int number, string name)
        {
            //Проверка данных 
            Number = number;
            Name = name;

        }
        public override string ToString()
        {
            return Name;
        }

    }
}
