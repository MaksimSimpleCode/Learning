using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [DataContract]  // Для сериализации в формате Json
    public class Student
    {
        [DataMember]    //Для сериализации в json нужно ставить над каждим полем которое хотим сериализовать
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Group Group { get; set; }
        public Student( string name, int age)
        {
            //Проверка входных параметров
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
