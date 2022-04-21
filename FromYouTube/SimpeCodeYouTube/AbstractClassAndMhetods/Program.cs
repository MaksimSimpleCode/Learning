using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndMhetods       //Обстрактный класс и методы
{
    /*
     * Полиморфизм
     * 
     * абстрактный класс
     * 
     * абстрактный метод
     * 
     * абстрактное свойство 
     */

    abstract class Weapon       //Создаем абстрактный клас и абстрактный метод
    {
        public abstract void Fire();    //В абстрактном методе не может быть реализации
        
        public abstract int Damage { get; } //Абстрактное свойсвто

        public void Info()
        {
            Console.WriteLine(GetType().Name+" Damage: "+Damage);
        }
    }
        
    class Gun : Weapon      //Так как Gun наследник абстрактного класса Weapon, он обязан реализовать в себе абстрактные методы базового класса
    {
        public override void Fire() //Ключевое слово override работает как с virtual так и с abstract
        {
            Console.WriteLine("Обычное оружие");
        }

        public override int Damage { get { return 5; } }
    }

    class LaserGun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Лазерное оружие");
        }

        public override int Damage => 10; 
    }

    class Player    //Класс игрока 
    {
        public void Fire(Weapon weapon) //Метод который позволяет стрелять игроку из любого оружия
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon) 
        {
            weapon.Info();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun gun = new Gun();
            LaserGun laserGun = new LaserGun();
            
            player.Fire(laserGun);      //Огонь
            player.CheckInfo(laserGun);     //Метод Получения информации

            Weapon[] inventory = { new Gun(), new LaserGun() }; //Делаем инвентарь 
            foreach (var ithem in inventory)    //и стреляем из всех орудий
            {
                player.Fire(ithem);
                player.CheckInfo(ithem);
            } 

        }
    }
}
