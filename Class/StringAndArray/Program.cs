using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArray
{
    class Program
    {
        static public void Menu_select(Car[] car, int index)
        {
            if (index >= 0 && index <= 4) {
                Console.WriteLine($"Цвет {car[index].GetColor()}");
                Console.WriteLine($"Кол-во колес {car[index].GetNumberOfWheels()}");
                Console.WriteLine($"Макс. скорость {car[index].GetMaxSpeed()}");
                Console.WriteLine($"Сидячих мест {car[index].GetNumberOfSeats()}");
                Console.WriteLine($"Тип топлива {car[index].GetTypeEngine()}");
                Console.WriteLine("Коробка передач " + (car[index].GetTransferBox() ? "Механическая" : "Ручная"));
            }
            else { Console.WriteLine("index выставлен неверно"); }
        }

        static public void Menu_ReSet(Car[] car, int index, ref int money)
        {
            int buff = index;
            if (index >= 0 && index <= 4)
            {
                Console.WriteLine("1)Цвет");
                Console.WriteLine("2)Кол-во колес");
                Console.WriteLine("3)Каробку");
                Console.WriteLine("4)Тип топлива");

                int.TryParse(Console.ReadLine(), out index);

                if (index == 1)
                {
                    Console.WriteLine("Введите цвет");
                    string colorName = Console.ReadLine();
                    car[buff].SetColor(colorName);
                    money -= 1000;
                }
                else if (index == 2)
                {
                    Console.WriteLine("Введите кол-во колес");
                    int.TryParse(Console.ReadLine(),out index);
                    car[buff].SetNumberOfWheels(index);
                    money -= 1000;
                }
                else if (index == 3)
                {
                    Console.WriteLine("1 - Механическая : 2 - Ручная");
                    int.TryParse(Console.ReadLine(), out index);
                    car[buff].SetTransferBox(index == 1 ? true : index == 2 ? false : car[buff].GetTransferBox());
                    money -= 1000;
                }
                else if (index == 4)
                {
                    Console.WriteLine("Тип топлива");
                    string typeEngine = Console.ReadLine();
                    car[buff].SetTypeEngine(typeEngine);
                    money -= 1000;
                }
            }
            else { Console.WriteLine("index выставлен неверно"); }
        }

        static public void Sale_Car(Car[] car, ref int money)
        {
            int chance_of_purchase_bar1 = 0, chance_of_purchase_bar2 = 0, chance_of_purchase_bar3 = 0, chance_of_purchase_bar4 = 0, chance_of_purchase_bar5 = 0;
            int chance_of_purchase = 0;
            int preference;
            int max;
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
            System.Random random = new Random();

            for (int person = 0; person < 100; person++)
            {
                for (int i = 0; i < 5;i++)
                {
                    preference = random.Next() % 5;

                    if (preference == 0) chance_of_purchase += car[i].GetNumberOfSeats() == 2 && car[i].GetMaxSpeed() <= 100 ? 35 : 5;
                    else if (preference == 1) chance_of_purchase += car[i].GetNumberOfSeats() <= 6 && car[i].GetMaxSpeed() <= 60 ? 40 : 5;
                    else if (preference == 2) chance_of_purchase += car[i].GetNumberOfSeats() == 4 && car[i].GetMaxSpeed() <= 80 ? 15 : 5;
                    else if (preference == 3) chance_of_purchase += car[i].GetNumberOfWheels() == 8 && car[i].GetMaxSpeed() <= 332 ? 84 : 5;
                    else if (preference == 4) chance_of_purchase += car[i].GetMaxSpeed() < 400 ? 4 : -10;

                    if (i == 0)      chance_of_purchase_bar1 = chance_of_purchase;
                    else if (i == 1) chance_of_purchase_bar2 = chance_of_purchase;
                    else if (i == 2) chance_of_purchase_bar3 = chance_of_purchase;
                    else if (i == 3) chance_of_purchase_bar4 = chance_of_purchase;
                    else if (i == 4) chance_of_purchase_bar5 = chance_of_purchase;

                    chance_of_purchase = 0;
                }

                max = chance_of_purchase_bar1;

                chance_of_purchase_bar1 += (int)car[0].GetMaxSpeed() / 7;
                chance_of_purchase_bar2 += (int)car[1].GetMaxSpeed() / 7;
                chance_of_purchase_bar3 += (int)car[2].GetMaxSpeed() / 7;
                chance_of_purchase_bar4 += (int)car[3].GetMaxSpeed() / 7;
                chance_of_purchase_bar5 += (int)car[4].GetMaxSpeed() / 7;

                for (int i = 0;i < 5;i++)
                {
                    if (max < chance_of_purchase_bar1 && i == 0) max = chance_of_purchase_bar1;
                    if (max < chance_of_purchase_bar2 && i == 1) max = chance_of_purchase_bar2;
                    if (max < chance_of_purchase_bar3 && i == 2) max = chance_of_purchase_bar3;
                    if (max < chance_of_purchase_bar4 && i == 3) max = chance_of_purchase_bar4;
                    if (max < chance_of_purchase_bar5 && i == 4) max = chance_of_purchase_bar5;
                }

                if (max == chance_of_purchase_bar1)
                {
                    if (chance_of_purchase_bar1 >= random.Next() % 100)
                    {
                        money += (int)car[0].GetMaxSpeed() / 5;
                        count1++;
                    }                        
                }

                else if (max == chance_of_purchase_bar2)
                {
                    if (chance_of_purchase_bar2 >= random.Next() % 100)
                    {
                        money += (int)car[1].GetMaxSpeed() / 5;
                        count2++;
                    }
                }

                else if (max == chance_of_purchase_bar3)
                {
                    if (chance_of_purchase_bar3 >= random.Next() % 100)
                    {
                        money += (int)car[2].GetMaxSpeed() / 5;
                        count3++;
                    }
                }

                else if (max == chance_of_purchase_bar4)
                {
                    if (chance_of_purchase_bar4 >= random.Next() % 100)
                    {
                        money += (int)car[3].GetMaxSpeed() / 5;
                        count4++;
                    }
                }

                else if (max == chance_of_purchase_bar5)
                {
                    if (chance_of_purchase_bar5 >= random.Next() % 100)
                    {
                        money += (int)car[4].GetMaxSpeed() / 5;
                        count5++;
                    }
                }

                chance_of_purchase_bar5 = chance_of_purchase_bar4 = chance_of_purchase_bar3 = chance_of_purchase_bar2 = chance_of_purchase_bar1 = 0;

            }

            Console.WriteLine($"Car1: {count1}%");
            Console.WriteLine($"Car2: {count2}%");
            Console.WriteLine($"Car3: {count3}%");
            Console.WriteLine($"Car4: {count4}%");
            Console.WriteLine($"Car5: {count5}%");

        }

        static void Main(string[] args)
        {
            int money = 10000;
            int choise;
            int size = 5, day = 0;
            Car[] car = new Car[size];

            for (int i = 0;i < size;i++)
            {
                car[i] = new Car();
            }

            while (true)
            {
                Console.WriteLine($"Денег: {money}  День:{day}");
                Console.WriteLine("1)Посмотреть характеристики ");
                Console.WriteLine("2)Поменять определенные характеристики за 1000 ? <- валюта");
                Console.WriteLine("3)Улучшить");
                Console.WriteLine("4)Заняться торговлей машин )");
                Console.WriteLine("0)exit");

                int.TryParse(Console.ReadLine(),out choise);

                if (choise == 1)
                {
                    Console.WriteLine("Выберите машину ");
                    int.TryParse(Console.ReadLine(), out choise);
                    Menu_select(car,choise - 1);
                }
                else if (choise == 2)
                {
                    Console.WriteLine("Выберите машину ");
                    int.TryParse(Console.ReadLine(), out choise);
                    Menu_ReSet(car, choise - 1,ref money);
                }
                else if (choise == 3)
                {
                    Console.WriteLine("Выберите машину ");
                    int.TryParse(Console.ReadLine(), out choise);
                    bool turnOut = car[choise - 1].ImproveCar(ref money);
                    Console.WriteLine(turnOut?"модернизация прошла успешно": "Нужно больше золота");
                }
                else if (choise == 4)
                {
                    Sale_Car(car,ref money);
                    day++;
                }
                else if (choise == 0)
                {
                    car[0].end();
                    break;
                }

            }            
        }
    }
}
