using System;

namespace ConsoleApp1
{
    class Program
    {
        enum DayOfWeek  //:byte (так можно поменять тип данных по умолчанию int)
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Firday,
            Saturday,
            Sunday
        }

        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }

        static DayOfWeek NextDay(DayOfWeek day)     //Метод для вывода следующего дня
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;
            return DayOfWeek.Monday;
        }
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            Console.WriteLine(dayOfWeek);   //Выводим день недели
            Console.WriteLine((int)dayOfWeek);  // Выводим значение дня недели

            Console.WriteLine("Текущий день недели: "+dayOfWeek+"\nЗавтра будет: "+NextDay(dayOfWeek));

            int value = 55;
            Console.WriteLine(Enum.IsDefined(typeof(DayOfWeek), value));    //проверяет есть ли в нашем enum такое число 


            var values = Enum.GetValues(typeof(Color)); //Собираем значения enum
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);

            switch (color)  //Нажимаем Tab, после вставляем переменную enum и нажимаем в любое место, switch сам построит все варианты.
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }
        }
    }
}
