using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMArray;

namespace IndexatorsDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int elements;
            int index;

            MArray mArray = new MArray();

            Console.WriteLine("Введите кол-во элементов:");

            int.TryParse(Console.ReadLine(),out size);

            mArray.Array = new int[size];

            Console.WriteLine("Введите элементы массива");

            for (int i = 0;i < size;i++)
            {
                int.TryParse(Console.ReadLine(), out elements);
                mArray[i] = elements;
            }

            Console.WriteLine("Элементы");

            for (int i = 0;i < size;i++)
            {
                Console.Write(mArray[i] + " ");
            }

            Console.WriteLine("\nВведите индекс");

            int.TryParse(Console.ReadLine(), out index);
            
            Console.WriteLine(mArray.ReturnToIndex(index));

            Console.ReadLine();
        }
    }
}
