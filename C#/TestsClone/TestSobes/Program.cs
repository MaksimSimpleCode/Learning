using System;

namespace TestSobes
{
    class Program
    {
        static void Main(string[] args)
        {
            var location1 = new Location();
            var car1 = new Car("Lada", location1);
            car1.ToString();


            //Car car2=car1.Clone(car1);

            //car2.Model = "Ferrari";
            //car2.Location.Country = "Italy";
            //car2.Location.City = "...";

            //car2.ToString();
            //car1.ToString();

            var car2 = car1.Clone() as Car;     //Или же var car=(Car)car1.Clone();
            car2.ToString();

            Console.WriteLine(car1.Location == car2.Location);
        }
    }

    public class Car:ICloneable
    {
        public string Model { get; set; }
        public Location Location { get; set; }

        public Car(string model, Location location)
        {
            Model = model;
            Location = location;
        }

        public override string ToString()
        {
            Console.WriteLine($"Модель: {Model}\nСтрана: {Location.Country}\nГород: {Location.City}\n");
            return base.ToString();
        }

        //Не глубокое копирование
        //public object Clone()
        //{
        //    //Позволяет сократить код и не писать примитивные типы (Model)
        //    return MemberwiseClone();
        //}

        //Глубокое копирование
        public object Clone()
        {
            return new Car(Model, new Location());
        }
    }


    public class Location
    {
        public string Country { get; set; } = "Russia";
        public string City { get; set; } = "Moscow";

        public Location()
        {

        }

    }

}
