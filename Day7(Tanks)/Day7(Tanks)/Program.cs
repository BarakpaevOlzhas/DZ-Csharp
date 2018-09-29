using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
using System.Threading;

namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            int five = 5;

            Tank[] tanksOne = new Tank[five];
            Tank[] tanksTwo = new Tank[five];

            for (int i = 0; i < five; i++) 
            {
                Thread.Sleep(10);

                tanksOne[i] = new Tank("Т-34");

                Thread.Sleep(10);

                tanksTwo[i] = new Tank("Pantera");
            }

            int pointTeamOne = 0;
            int pointTeamTwo = 0;

            for (int i = 0; i < five; i++)
            {
                int winner = 0;

                Console.Clear();
                
                Console.WriteLine(tanksOne[i].GetStats());

                Console.WriteLine();

                Console.WriteLine(tanksTwo[i].GetStats());

                winner = tanksOne[i] * tanksTwo[i];

                if (winner == 1)
                {
                    Console.WriteLine("T-34 Win");
                    pointTeamOne++;
                }

                else if (winner == 0)
                {
                    Console.WriteLine("Pantera Win");
                    pointTeamTwo++;
                }

                else if (winner == -1)
                {
                    Console.WriteLine("Ничья");
                }

                Console.ReadLine();
            }

            if (pointTeamOne > pointTeamTwo)
            {
                Console.WriteLine("Команда Т-34 победила");
            }

           else if (pointTeamOne < pointTeamTwo)
            {
                Console.WriteLine("Команда Pantera победила");
            }

            else
            {
                Console.WriteLine("Ничья");
            }


            Console.ReadKey();
        }
    }
}
