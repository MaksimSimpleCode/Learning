using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace ImageTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "ph1.jpg";
            string fileName2 = "ph2.jpg";
            PutImageBinaryInDb(fileName);
            PutImageBinaryInDb(fileName2);

            GetImageBinaryFromDb();

        }


        private static void PutImageBinaryInDb(string iFile)
        {
            // конвертация изображения в байты
            string path = @$"D:\Programming\Learning\C#\Db\ImageTests\ImageTests\Content\{iFile}";
            byte[] imageData = null;
            FileInfo fInfo = new FileInfo(path);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageData = br.ReadBytes((int)numBytes);

            // получение расширения файла изображения не забыв удалить точку перед расширением
            string iImageExtension = (Path.GetExtension(iFile)).Replace(".", "").ToLower();

            // запись изображения в БД
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-01; Initial Catalog=learningSQL; Trusted_Connection=True;")) // строка подключения к БД
            {
                string commandText = "INSERT INTO new_Photos (screen, screen_format) VALUES(@screen, @screen_format)"; // запрос на вставку
                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                command.Parameters.AddWithValue("@screen", (object)imageData); // записываем само изображение
                command.Parameters.AddWithValue("@screen_format", iImageExtension); // записываем расширение изображения
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        private static void GetImageBinaryFromDb()
        {
            
            // получаем данные их БД
            List<byte[]> iScreen = new List<byte[]>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            List<string> iScreen_format = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-01; Initial Catalog=learningSQL; Trusted_Connection=True;"))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [screen], [screen_format] FROM [new_Photos]"; // наша запись в БД под id=1, поэтому в запросе "WHERE [id] = 1"
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                byte[] iTrimByte = null;
                string iTrimText = null;
                while (sqlReader.Read()) // считываем и вносим в лист результаты
                {
                    iTrimByte = (byte[])sqlReader["screen"]; // читаем строки с изображениями
                    iScreen.Add(iTrimByte);
                    iTrimText = sqlReader["screen_format"].ToString().TrimStart().TrimEnd(); // читаем строки с форматом изображения
                    iScreen_format.Add(iTrimText);
                }
                sqlConnection.Close();
            }
            int index = 0;
            foreach (var screen in iScreen)
            {
                // конвертируем бинарные данные в изображение
                byte[] imageData = screen; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
                MemoryStream ms = new MemoryStream(imageData);
                Image newImage = Image.FromStream(ms);

                // сохраняем изоражение на диск
                string iImageExtension = iScreen_format[0]; // получаем расширение текущего изображения хранящееся в БД
                string iImageName = @$"D:\Programming\Learning\C#\Db\ImageTests\ImageTests\FromDb\{index}" + "." + iImageExtension; // задаём путь сохранения и имя нового изображения
                index++;
                if (iImageExtension == "png")
                {
                    newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (iImageExtension == "jpg" || iImageExtension == "jpeg")
                {
                    newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (iImageExtension == "gif")
                {
                    newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Gif);
                }
                // и т.д., можно все if заменить на одну строку "newImage.Save(iImageName)", насколько это правильно сказать не могу, но работает

            }


        }
    }
}
