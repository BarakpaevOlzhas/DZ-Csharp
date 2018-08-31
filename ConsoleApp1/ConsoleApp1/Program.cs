using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigningSimpleApp
{
    class Program
    {
        private static void The_input_to_the_screen()
        {
            int first_number;
            int second_number;
            int third_number;

            Console.WriteLine("Введите первое число:");
            first_number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            second_number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            third_number = int.Parse(Console.ReadLine());

            Console.WriteLine(first_number + "  " + second_number + "  " + third_number);
        }
        private static void Entering_numbers_one_under_the_other()
        {
            Console.WriteLine(5 + "\n" + 10 + "\n" + 21);
        }
        private static void Search_meters()
        {
            int centimeters;
            int meters;
            int difference = 100;
            Console.WriteLine("Введите сантиметры: ");
            centimeters = int.Parse(Console.ReadLine());
            meters = centimeters / difference;

            Console.WriteLine("m = " + meters);
        }
        static private void Search_Week()
        {
            int Day = 234;
            int day_in_week = 7;
            int Week;
            Week = Day / day_in_week;
            Console.WriteLine("Week = " + Week);
        }
        private static void Two_numbers()
        {
            int dozens_of;
            int ten = 10;
            int units;
            int sum;
            int composition;
            Console.WriteLine("Введите двузначное число");
            int number = int.Parse(Console.ReadLine());

            dozens_of = number / ten;
            units = number % ten;
            sum = dozens_of + units;
            composition = dozens_of * units;

            Console.WriteLine("десятков " + dozens_of);
            Console.WriteLine("единиц " + units);
            Console.WriteLine("сумма " + sum);
            Console.WriteLine("произведение " + composition);
        }
        private static void True_or_false()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine("A = true");
            Console.WriteLine("B = false");
            Console.WriteLine("C = false\n");

            Console.WriteLine("A or B = " + (A || B));
            Console.WriteLine("A and B = " + (A && B));
            Console.WriteLine("B and C = " + (B || C));
        }
        private static void Circle_or_square()
        {
            double R;
            double S_circle;
            int S_square;
            double p = 3.14;
            int side;


            Console.WriteLine("Введите радиус: ");
            double.TryParse(Console.ReadLine(),out R);

            S_circle = p * R * R;

            Console.WriteLine("Введите сторону: ");
            int.TryParse(Console.ReadLine(),out side);

            S_square = side * side;


            Console.WriteLine("S_circle = " + S_circle);
            Console.WriteLine("S_square = " + S_square);
        }
        private static void The_density_of_the_body()
        {
            double m1, v1, p1;
            double m2, v2, p2;

            Console.WriteLine("Введите массу первого тела:");
            double.TryParse(Console.ReadLine(),out m1);

            Console.WriteLine("Введите объем первого тела:");
            double.TryParse(Console.ReadLine(), out v1);

            Console.WriteLine("Введите массу второго тела:");
            double.TryParse(Console.ReadLine(), out m2);

            Console.WriteLine("Введите объем второго тела:");
            double.TryParse(Console.ReadLine(), out v2);

            p1 = m1 / v1;
            p2 = m2 / v2;

            Console.WriteLine("Плотность первого объекта " + p1);
            Console.WriteLine("Плотность второго объекта " + p2);
            Console.WriteLine(p1 > p2? "Плотность первого объекта больше" : p1 < p2? "Плотность второго объекта больше" : "Плотность объектов равна");



        }
        private static void Amperage()
        {
            double i1, u1, r1;
            double i2, u2, r2;

            Console.WriteLine("Введите первое напряжение:");

            double.TryParse(Console.ReadLine(), out u1);

            Console.WriteLine("Введите первое сопротивление:");

            double.TryParse(Console.ReadLine(), out r1);

            Console.WriteLine("Введите второе напряжение:");

            double.TryParse(Console.ReadLine(), out u2);

            Console.WriteLine("Введите второе сопротивление:");

            double.TryParse(Console.ReadLine(), out r2);

            i1 = u1 / r1;
            i2 = u2 / r2;

            Console.WriteLine(i1 < i2 ? "По первому участку протекает меньший ток " + i1 : i1 > i2  ? "По второму участку протекает меньший ток " + i2 : "Они равны" );
        }
        private static void Cycles()
        {
            int choise = 0;

            Console.WriteLine("1)Вывод на экран числа от 20 до 35");
            Console.WriteLine("2)Квадрат всех чисел от 10 до задоного");
            Console.WriteLine("3)Третьи степени всех чисел от задоного до 50");
            Console.WriteLine("4)Вывод на экран числа в диапазоне");
            Console.WriteLine("выбор:");

            int.TryParse(Console.ReadLine(),out choise);

            switch (choise)
            {
                case 1:
                    for (int i = 20;i <= 35; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 2:
                    int max;

                    Console.WriteLine("Задайте максимальное число");

                    int.TryParse(Console.ReadLine(),out max);

                    for (int i = 10;i < max;i++)
                    {
                        Console.WriteLine(i * i);
                    }
                    break;

                case 3:
                    int min;

                    Console.WriteLine("Задайте минимальное число");

                    int.TryParse(Console.ReadLine(), out min);

                    for (int i = min; i < 50; i++)
                    {
                        Console.WriteLine(Math.Pow(i,3));
                    }
                    break;

                case 4:
                    Console.WriteLine("Задайте максимальное число");

                    int.TryParse(Console.ReadLine(), out max);

                    Console.WriteLine("Задайте минимальное число");

                    int.TryParse(Console.ReadLine(), out min);

                    for (int i = min; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }

                    break;
            }


        }

        static void Main(string[] args)
        {
            //The_input_to_the_screen();
            // entering_numbers_one_under_the_other();
            //Search_meters();
            //Search_Week();
            //two_numbers();
            //true_or_false();
            //circle_or_square();
            //The_density_of_the_body();
            //Amperage();
            Cycles();

            Console.ReadLine();
        }
    }
}

