using System;

class Program
{
    public static int Main()
    {
        int line;   //строка
        int column; //столбец
        char fill;  //заполнитель
        Console.Write("Введите количество строк    : ");
        line = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов : ");
        column = int.Parse(Console.ReadLine());
        Console.Write("Введите заполнитель         : ");
        fill = (char)Console.Read();
        Console.WriteLine();

        int i = 0;    //счетчик для внешнего цикла
        while (i < line)
        {
            i++;
            int j = 0;    //счетчик для внутреннего цикла
            while (j < column)
            {
                j++;
                Console.Write(fill);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
        return 0;
    }
}