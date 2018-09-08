using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchHomeWork
{
    class Program
    {
        static public void TheDivisionOfTwoNumbers()
        {
            int firstNumber;
            int secondNumber;
            double answer;

            Console.WriteLine("Введите первое число");

            int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Введите второе число");

            int.TryParse(Console.ReadLine(), out secondNumber);
            
            try
            {
            answer = firstNumber / secondNumber;
            }

            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine(divideByZeroException);
            }

            catch (ArgumentNullException argumentException)
            {
                Console.WriteLine(argumentException);
            }
        }

        static public void IndexForArray()
        {
            Random random = new Random();

            int index;
            int size = 10;

            int[] mas = new int[size];

            for (int i = 0; i < size; i++) 
            {
                mas[i] = random.Next() % 10;
            }

            Console.WriteLine("Введите индекс массива к которому вы хотите обратиться(от 0 - 9)");

            int.TryParse(Console.ReadLine(),out index);

            try
            {
                Console.WriteLine($"mas[{index}] = { SearchByIndex(mas, index)};"); 
            }

            catch (IndexOutOfRangeException indexOutOfRangeException)
            {
                Console.WriteLine(indexOutOfRangeException);
            }
            
        }

        static public int SearchByIndex(int[] array,int index)
        {
            return array[index];
        }


        static void Main(string[] args)
        {
            //TheDivisionOfTwoNumbers();
            IndexForArray();



            Console.ReadLine();
        }
    }
}
