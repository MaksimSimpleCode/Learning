using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoinDemo
{
    // Этот класс связывает наименование вида транспорта,
    // например поезда, с общей классификацией транспорта:
    // наземного, морского, воздушного или речного.
    class Transport
    {
        public string Name { get; set; }
        public string How { get; set; }
        public Transport(string n, string h)
        {
            Name = n;
            How = h;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Массив классификации видов транспорта.
            string[] travelTypes = {
                "Воздушный",
                "Морской",
                "Наземный",
                "Речной",
            };
            // Массив видов транспорта.
            Transport[] transports = {
                new Transport("велосипед", "Наземный"),
                new Transport("аэростат", "Воздушный"),
                new Transport("лодка", "Речной"),
                new Transport("самолет", "Воздушный"),
                new Transport("каноэ", "Речной"),
                new Transport("биплан", "Воздушный"),
                new Transport("автомашина", "Наземный"),
                new Transport("судно", "Морской"),
                new Transport("поезд", "Наземный")
            };
            // Сформировать запрос, в котором групповое
            // объединение используется для составления списка
            // видов транспорта по соответствующим категориям.
            var byHow = from how in travelTypes
                        join trans in transports
                        on how equals trans.How
                        into lst
                        select new { How = how, Tlist = lst };
            // Выполнить запрос и вывести его результаты.
            foreach (var t in byHow)
            {
                Console.WriteLine("К категории <{0} транспорт> относится:", t.How);
                foreach (var m in t.Tlist)
                    Console.WriteLine(" " + m.Name);
                Console.WriteLine();
            }
        }
    }
}
