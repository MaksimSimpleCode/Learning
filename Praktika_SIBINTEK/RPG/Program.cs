using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Hero
    {
        private int hp =100;
        private int xp=0;
        private string name;
        private int damage=30;
        private int level = 0;
        private int HP_Boss = 100;

        public Hero (string name)
        {
            this.name = name;
            Console.WriteLine("Привет " + name + "!");
        }

        public int HpBoss
        {
            get{ return HP_Boss;}
            set{ HP_Boss = value;}
        }
        public void StatInfo()
        {
            Console.WriteLine(name+"Это ваши характеристики на данный момент: ");
            Console.WriteLine("Здоровье: "+hp);
            Console.WriteLine("Опыт: "+xp);
            Console.WriteLine("Урон: "+damage);
            Console.WriteLine("Уровень: "+level);
        }

        public void Test()
        {
            xp += 20;
            if (xp > 100)
            {
                level += 1;
                Console.WriteLine("Вы достигли уровня " + level);
            }
                
            StatInfo();
            Console.WriteLine("Здоровье босса: "+HP_Boss);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Назовите имя своего героя: ");
            Hero hero = new Hero(Console.ReadLine());
            hero.StatInfo();
            Console.WriteLine("Тестовый бой начинается, для окончания введи stop");
            while(Console.ReadLine()!="stop")
            {

                if (Console.ReadKey().Key == ConsoleKey.X)
                    Console.Clear();
                hero.HpBoss-damage
                hero.Test();
                
                
            }

        }
    }
}
