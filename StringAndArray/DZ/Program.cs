using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static public void The_first_job()
        {
            int count = 0;           
            ConsoleKey key;

            Console.WriteLine("Введите все что хотите(чтобы закончить нажмите .):");

            do
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Spacebar) count++;
                else if (key == ConsoleKey.Enter) Console.WriteLine();
            }
            while (key != ConsoleKey.OemPeriod);

            Console.WriteLine();
            Console.WriteLine($"Пробелов ведено {count}");
        }
        static public void The_second_job()
        {
            int six_digit_number;
            int three_digit_number_1, three_digit_number_2;
            int number_one, number_two;
            int ten = 10;
            int hundred = 100;
            int thousand = 1000;

            Console.WriteLine("Введите шестизначное число");

            int.TryParse(Console.ReadLine(),out six_digit_number);

            if (six_digit_number > 99999 && six_digit_number < 1000000)
            {
                three_digit_number_1 = six_digit_number / thousand;

                three_digit_number_2 = six_digit_number - three_digit_number_1 * thousand;

                number_one = (three_digit_number_1 / hundred) + ((three_digit_number_1 % hundred) / ten) + (three_digit_number_1 % ten);

                number_two = (three_digit_number_2 / hundred) + ((three_digit_number_2 % hundred) / ten) + (three_digit_number_2 % ten);

                if (number_one == number_two) Console.WriteLine("Билет счастливый");
                else Console.WriteLine("Билет не счастливый");
            }
            else
            {
                Console.WriteLine("Вы ввели не шестизначное число");
            }

            Console.ReadLine();
        }
        static public void The_third_job()
        {
            int key;
            char symbol;

            Console.WriteLine("Введите символ верхнего или нижнего регистра");

            key = Console.Read();

            if((key | 0x20) == key) symbol = (char)(key & 0xffdf);

            else symbol = (char)(key | 0x20);

            Console.WriteLine(symbol);
        }
        static public void The_fourth_job()
        {
            int min, max;

            Console.WriteLine("Введите минимальное значение");

            int.TryParse(Console.ReadLine(),out min);

            Console.WriteLine("Введите максимальное значение");

            int.TryParse(Console.ReadLine(), out max);

            for (;min <= max;min++)
            {
                for (int i =0;i < min;i++)
                {
                    Console.Write($"{min} ");
                }
                Console.WriteLine();
            }
        }
        static public void The_fifth_job()
        {
            string number;

            Console.WriteLine("Введите любое число");

            number = Console.ReadLine();

            number = new string(number.Reverse().ToArray());

            Console.WriteLine(number);
        }


        static void Main(string[] args)
        {
            //The_first_job();
            //The_second_job();
            //The_third_job();
            //The_fourth_job();
            The_fifth_job();

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
