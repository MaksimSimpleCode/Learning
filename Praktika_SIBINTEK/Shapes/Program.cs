using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    //Абстрактный базовый класс иерархии
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set;}
        //Вынудить все дочерние классы определять способ своей визуализации метода.
        public abstract void Draw();
        

    }

    // Класс Circle не переопределяет метод Draw()
    class Circle:Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    // Класс Hexagon  переопределяет метод Draw()
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            // Создать массив совместимых c Shape объектов.
            Shape[] myShapes = {new Hexagon(), new Circle (), new Hexagon("Mick" ) ,
            new Circle("Beth"), new Hexagon("Linda" )};
            // Пройти в цикле по всем элементам и взаимодействовать
            //с полиморфным интерфейсом,
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();
        }
    }
}
