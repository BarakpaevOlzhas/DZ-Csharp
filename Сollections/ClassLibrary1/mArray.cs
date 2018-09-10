using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СollectionsAll
{
    public class mArray<T>
    {
        public mArray(int capacity)
        {
            Size = 0;
            RealSize = capacity;
            mas = new T[capacity];
        }


        public int Size { get; set; }

        public int RealSize { get; set; }

        private T[] mas;

        public T[] Mas
        {
            set
            {                
                mas = value;
                RealSize = mas.Length;
            }
            get
            {
                return mas;
            }
        }

        public T this[int index]
        {
            get
            {
                return Mas[index];
            }
            set
            {
                Mas[index] = value;
            }
        }

        public void Add(T buf)
        {
            if (Size + 1 <= RealSize)
            {
                mas[Size + 1] = buf;
                Size++;
            }

            else
            {
                StretchMas(1);
                mas[Size] = buf;
                Size++;
            }            
        }

        public void StretchMas(int addSize )
        {
            T[] buf = new T[RealSize];

            for (int i = 0;i < RealSize; i++)
            {
                buf[i] = mas[i];
            }

            mas = new T[RealSize + addSize];

            for (int i = 0; i < RealSize; i++)
            {
                mas[i] = buf[i];
            }

            RealSize = RealSize + addSize;
        }  

        public void Remove(T variables)
        {
            bool pass = false;

            for (int i = 0; i < RealSize; i++)
            {
                if (!mas[i].Equals(variables))
                {
                    continue;
                }
                else
                {
                    pass = true;
                }
            }
            if (pass)
            {
                T[] buf = new T[RealSize - 1];

                int minusOne = 0;

                for (int i = 0; i < RealSize; i++)
                {
                    if (!mas[i].Equals(variables))
                    {
                        buf[i - minusOne] = mas[i];
                    }
                    else
                    {
                        minusOne++;
                    }
                }

                mas = new T[RealSize - 1];

                RealSize--;
                Size--;

                for (int i = 0; i < RealSize; i++)
                {
                    mas[i] = buf[i];
                }
                                
            }
        }

        public int IndexOf(T variables)
        {
            for (int i = 0;i < RealSize;i++)
            {
                if (!mas[i].Equals(variables))
                {
                return i;
                }
            }
            return -1;
        }

        public void Insert(T temp,int index)
        {
            if (index < RealSize)
            {
                mas[index] = temp;
                Size++;
            }
            else
            {
                StretchMas(1);
                mas[Size] = temp;
                Size++;
            }
        }

        public void Clear()
        {
            T buf = default(T);
            for (int i = 0;i < RealSize; i++)
            {
                mas[i] = buf;
            }
            Size = 0;
            RealSize = 0;
        }
    }
}
