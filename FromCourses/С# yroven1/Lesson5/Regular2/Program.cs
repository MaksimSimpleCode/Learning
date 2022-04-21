﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[26];
            int i, k, cA;
            char c;
            cA = (int)('a');//Сохраним код буквы 'a'
            // в  С# при создании массива он автоматически заполняется нуляем.Здесь это сделано, чтобы лишнмй раз подчеркнуть, что частотный массив должен быть полностью заполнен 0
            for (i = 0; i < 26; i++) count[i] = 0;
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();
            s = s + '.';// По условию задачи, строка ДОЛЖНА заканчиваться точкой и добовлять ее нет необходимости. Но мы добавим точку, чтобы можно было ее самим не вводить.
            i = 0;
            do
            {
                c = s[i];//Сохраним текущий символ
                k = (int)c;//Получим код символа
                //если символ - маленькая буква
                if (c >= 'a' && c <= 'z')
                    count[k - cA]++;
                //Увеличим частоту вхождения этой буквы в частотном массиве
                i++;
            }
            while (c != '.');//Повторяем цикл, пока не встретим .
            //выводим частотный массив на экран
            //В массиве под номером 0- сколько раз встретилась 'а'
            //Под номером 1 - сколько раз встретилась 'b' и тд
            for (i = 0; i < 26; i++)
                if (count[i] > 0)
                    //если символ встретился хотя бы раз
                    Console.WriteLine("{0}{1}",(char)(cA+i),count[i]);
        }
    }
}
