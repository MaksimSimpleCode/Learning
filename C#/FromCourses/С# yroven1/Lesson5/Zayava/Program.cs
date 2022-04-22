using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Напишем программу "создание заявления по шаблону".
//Разработаем простой шаблон документа, куда вместо меняющегося текста вставим теги.
//Смотри файл shablon.txt
namespace Zayava
{
    class Program
    {
        //Создадим структуру, связывуюзую некоторый тег со строкой
        struct Element
        {
            public string tag;
            public string str;

            //Создадим конструктор для того, чтобы проще было заполнить массив
            public Element(string tag, string newString)
            {
                this.tag = tag;
                str = newString;
            }
        }
        static void Main(string[] args)
        {
            //Считаем текст из файла
            string s = File.ReadAllText("shablon.txt");
            //Заполним массив элементов, сопоставив тегам соответсвующий текс
            Element[] e = new Element[8]
            {
                new Element("name1","ООО Дружба"),
                new Element("name2","Иванову И.И."),
                new Element("name3","менеджера по продажам"),
                new Element("name4","Сидорова А.А"),
                new Element("name5","Сидоров А.А"),
                new Element("data1","01.06.16"),
                new Element("data2","14.06.16"),
                new Element("data3","20.04.16"),

            };
            //Пробежимся по массиву и поменяем  все вхождения тегов на текст
            foreach (var el in e)
            {
                Regex reg = new Regex("<" + el.tag + ">");
                s = reg.Replace(s, el.str);
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
