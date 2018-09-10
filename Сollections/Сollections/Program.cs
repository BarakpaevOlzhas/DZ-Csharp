using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СollectionsAll;

namespace Сollections
{
    class Program
    {
        static void Main(string[] args)
        {
            mArray<int> mas = new mArray<int>(5);

            Console.WriteLine(mas.Size);
            Console.WriteLine(mas.RealSize);
            Console.WriteLine(mas.Mas);

            mas.Add(10000);

            Console.WriteLine(mas.Size);
            Console.WriteLine(mas.RealSize);
            Console.WriteLine(mas.Mas);

            mas.Remove(10000);

            Console.WriteLine(mas.Size);
            Console.WriteLine(mas.RealSize);
            Console.WriteLine(mas.Mas);

            Console.WriteLine(mas.IndexOf(10000));

            Console.ReadLine();


        }
    }
}
