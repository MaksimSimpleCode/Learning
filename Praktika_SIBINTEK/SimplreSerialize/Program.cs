using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Xml.Serialization;

namespace SimplreSerialize
{   //Сериализация объектов в 3 разных форматах: Binary, Soap, XML

    [Serializable]
    public class Radio
    {
        public bool hasTweeters;
        public bool hasSubWoofers;
        public double[] stationPresets;
        [NonSerialized]
        public string radioID = "XF-552RR6";
    }

    [Serializable]
    public class Car
    {
        public Radio theRadio = new Radio();
        public bool isHatchBack;
    }

    
    public class JamesBondCar :Car
    {
        public JamesBondCar (bool skyWorthy, bool seaWorthy)
        {
            canFly = skyWorthy;
            canSubmerge = seaWorthy;
        }

        // XmlSerializer требует стандартного конструктора!
        public JamesBondCar() { }

        public bool canFly;
        public bool canSubmerge;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");
            // Создать объект JamesBondCar и установить состояние.
            JamesBondCar jbc = new JamesBondCar();
            jbc.canFly = true;
            jbc.canSubmerge = false;
            jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.theRadio.hasTweeters = true;

            #region Загрузка данных
                //Сохранить объект JamesBondCar в указанном файле в двоичном формате.
            // SaveAsBinaryFormat(jbc, "CarData.dat");

                //Загрузить объект JamesBondCar из двоичного файла
            //LoadFromBinaryFile("CarData.dat");


                //Сохранить объект JamesBondCar в файл CarData.soap в формате soap
           // SaveAsSoapFormat(jbc, "CarData.soap");

                //Загрузить  объект JamesBondCar из CarData.soap в формате soap
          //LoadFromSoapFile("CarData.soap");


            //SaveAsXmlFormat(jbc, "CarData.xml");

            LoadXmlFile("CarData.xml");
            #endregion

            Console.ReadKey();
        }

        #region BinafyFornatter
        static void SaveAsBinaryFormat(object objGraph, string fileName)   //Метод для сохранения объекта
        {
            //Сохранить граф объектов в файл CarData.tat в двоичном виде
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Сохранение Car в двоичном формате!");
        }

        static void LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            // Прочитать объект JamesBondCar из двоичного файла.
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk =(JamesBondCar)binFormat.Deserialize(fStream);
                Console.WriteLine("Can this car fly ? : {0}", carFromDisk.canFly);
            }
        }
        #endregion

        #region SoapFormatter
        static void SaveAsSoapFormat(object objGraph, string fileName)   //Метод для сохранения объекта
        {
            //Сохранить граф объектов в файл CarData.soap в формате soap
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Сохранение Car в формате soap!");
        }

        static void LoadFromSoapFile(string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();
            // Прочитать объект JamesBondCar из CarData.soap в формате soap.
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)soapFormat.Deserialize(fStream);
                Console.WriteLine("Can this car fly ? : {0}", carFromDisk.canFly);
            }
        }
        #endregion

        #region XmlFormatter
        static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            // Сохранить объект в файле CarData.xml в формате XML.
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            using (Stream fStream = new FileStream(fileName,FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in XML format!");
        }

        static void LoadXmlFile(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            // Прочитать объект JamesBondCar из CarData.xml в формате xml
            using (Stream fStream = File.OpenRead(fileName))
            {
                JamesBondCar carFromDisk = (JamesBondCar)xmlFormat.Deserialize(fStream);
                Console.WriteLine("Can this car fly ? : {0}", carFromDisk.canFly);
            }
        }
        #endregion
    }

}
