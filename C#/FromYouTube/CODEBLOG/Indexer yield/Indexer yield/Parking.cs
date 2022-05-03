using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_yield
{
    class Parking :IEnumerable  //Необходимо наследовать этот интерфейс если мы хотим делать перебор коллекций объектов нашего класса
    {
        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this [string number] //Индексатор для нашего паркинга
        {
            get
            {
                var car = _cars.FirstOrDefault(c => c.Number == number);
                return car;
            }
        }

        public Car this[int position]   //перегрузка индексатора по номеру, так же с блоком set, мы можем устанавливать по [...]
        {
            get
            {
                if (position < _cars.Count)
                    return _cars[position];
                return null;
            }
            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
                    
            }
        }
        
        public int Count => _cars.Count;
        public string Name { get; set; }

        public int Add(Car car)
        {
            if(car == null)
            {
                throw new ArgumentException(nameof(car), "Car is null");
            }

            if(_cars.Count< MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count - 1;
            }

            return -1;
        }

        public void GoOut(string number)
        {
            if(string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is null or empty ");
            }

            var car = _cars.FirstOrDefault(c => c.Number == number);
            if(car != null)
            {
                _cars.Remove(car);
            }
        }

        public IEnumerator GetCars()
        {
            foreach(var car in _cars)
            {
                yield return car;
            }
        }
        public IEnumerator<Car> GetEnumerator() //* это вместе с нижним, нужно разобраться
        {
            return _cars.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() //Специальный класс для перебора коллекций
        {
            return _cars.GetEnumerator();   // Т.к мы используем уже готовую коллекцию, нам достаточно сделать вот так, иначе пришлось бы реализовывать
            //все в клссе ниже.
        }
    }

    public class ParkingEnumerator : IEnumerator    //реализуем еще такой класс от енумератора который собственно и производит перебор коллекции
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
