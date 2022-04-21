using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Введите любое число. Чтобы спровоцировать ошибку, введите символ или букву");
                int a = int.Parse(Console.ReadLine());  //Если введем букву, отработает универсальный перехватчик, так как самостоятельно к этой ошибке -
                // перехватчик мы не делали.

                int[] myArray = new int[] { 1, 2, 3, 4, 5 };
                for (int i = 0; i < myArray.Length+1; i++)  //намеренная ошибка +1
                {
                    Console.WriteLine(myArray[i]);
                }
                Console.WriteLine("Массив выведен, теперь попробуем поделить его эллементы на 2 и на 0");
                for (int i = 0; i < myArray.Length+1; i++)  //намеренная ошибка +1
                {
                    Console.WriteLine("Делим " + myArray[i]+" на 2: "+(double)myArray[i] / 2);

                }
                Console.WriteLine("А теперь попробуем поделить на 0");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Делим " + myArray[i] + " на 0: " + myArray[i] / 0);  //намеренная ошибка деление на 0

                }
            }
            catch (IndexOutOfRangeException)    //Можно закомментировать так как есть универсальный обработчик
            {
                Console.WriteLine("Вы вышли за пределы массива");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! На 0 делить нельзя!");
            }
            catch (Exception ex)    //универсальный перехватчик исключений
            {
                Console.WriteLine(ex.Message);  //С помощью свойства Message мы выведем заложенное сообщение об ошибке. Для этого закоментируй наш обработчик
            }
            catch   //Тоже универсальный перехватчик исключений
            {
                Console.WriteLine("Произошла какая-то ошибка!");
            }
            
            finally
            {
                Console.WriteLine("Этот блок кода выполняется независимо от того члучилась ошибка или нет");
            }
            
        }
    }
}
