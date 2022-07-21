using System;


namespace Attribute_AND_Reflection
{
    // Реализуем Класс- Атрибут
    [AttributeUsage(AttributeTargets.Property)] //эТИМ АТРИБУТОМ ПО СУТИ НАД АТРИБУТОМ, МЫ МОЖЕМ ОПРЕДЕЛИТЬ К ЧЕМУ БУДЕТ ПРИМЕНИМ НАШ АРТИБУТ
    class GeoAttribute : System.Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute () { }

        public GeoAttribute(int x, int y)
        {
            //Проверка входных данных
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}
