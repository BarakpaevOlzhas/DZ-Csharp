using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            int ten = 10;

            int max = 0;

            int indexMax = 0;

            int sum = 0;

            Random random = new Random();

            List<int> list = new List<int>();

            for (int i = 0;i < ten; i++)
            {
                Thread.Sleep(10);
                list.Add(random.Next(0,100));
            }

            for (int i = 0; i < ten; i++) 
            {
                if (max < list[i])
                {
                    max = list[i];
                    indexMax = i;
                }
            }

            Console.WriteLine($"index = {indexMax}; \n number = {max}");

            for (int i = 0; i < ten; i++) 
            {
                if (i % 2 == 0)
                {
                    sum += list[i];
                }
            }

            Console.WriteLine($"Сумма элементов на четных позичиях = {sum}");

            Console.ReadKey();
        }
    }
}
