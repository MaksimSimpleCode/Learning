using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_AND_Reflection
{
    // [Geo(10,20)]    //Используем наш атрибут, теперь по сути к любому экземпляру класс "фото", будут прилагаться наши метаданные
    class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }
        public Photo (string name)
        {
            //Проверка

            Name = name;
        }
    }
}
