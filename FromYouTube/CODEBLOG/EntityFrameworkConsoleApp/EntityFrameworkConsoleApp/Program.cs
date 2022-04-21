using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MyDbContext())  //подключение
            {
                var group = new Group() //добовляем новую группу
                {
                    Name = "Рамштайн",
                    Year = 1994
                };

                var group2 = new Group() //добовляем новую группу
                {
                    Name = "Линкенпарк",
                    Year = 1994
                };
                context.Groups.Add(group);  //Добавляем групу в список *Данные еще не в БД
                context.Groups.Add(group2);
                context.SaveChanges();  //Сохраняем контекст, данные улетают в БД

                var songs = new List<Song>()
                {
                    new Song{Name = "In the End", GroupId =group2.Id},
                    new Song {Name = "Numb", GroupId= group2.Id},
                    new Song {Name = "Mutter", GroupId =group.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();
               
               
                foreach(var song in songs)
                    Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group.Name}");

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
                Console.ReadLine();
            }
        }
    }
}
