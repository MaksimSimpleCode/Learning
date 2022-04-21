using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriveInfoApp
{

    /* Пространство имен System. 10 содержит класс по имени Drivelnfo. 
     * Подобно Directory. GetLogicalDrives () статический метод Drivelnfo. GetDrives () 
     * позволяет выяснить имена устройств на машине. 
     * Однако в отличие от Directory. GetLogicalDrives () метод Drivelnfo. GetDrives () 
     * предоставляет множество дополнительных деталей 
     * (например, тип устройства, доступное свободное пространство иметка тома).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Drivelnfo ******\n");
            //Получить информацию обо всех устройствах
            DriveInfo[] myDrivers = DriveInfo.GetDrives();

            //Вывести сведения об устройствах
            foreach(DriveInfo d in myDrivers)
            {
                Console.WriteLine("Name: {0}", d.Name); //Имя
                Console.WriteLine("Type {0}", d.DriveType); //Тип

                //Проверить, смонтировано ли устройство 
                if (d.IsReady)
                {
                    Console.WriteLine("Свободное место: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Формат устройства: {0}", d.DriveFormat);
                    Console.WriteLine("Метка тома: {0}", d.VolumeLabel);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
