using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArray
{
    partial class Car
    {
        private int _numberOfWheels;
        private double _maxSpeed;
        private bool _transferBox;       
        private string _typeEngine;
        private string _number;
        private string _color;
        private static int _numberOfSeats;
        private static string _brand;

        public Car()
        {
            SetNumberOfWheels(4);
            SetMaxSpeed(70);
            SetTransferBox(true);
            SetTypeEngine("gasoline");
        }

        public Car(int wheels, double speed,bool box, string engine)
        {
            SetNumberOfWheels(wheels);
            SetMaxSpeed(speed);
            SetTransferBox(box);
            SetTypeEngine(engine);
        }

        public Car(int wheels, double speed)
        {
            SetNumberOfWheels(wheels);
            SetMaxSpeed(speed);            
        }

        static Car()
        {
            _numberOfSeats = 4;
            _brand = "audi";
        }

        public int GetColor()
        {
            return _numberOfWheels;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public int GetNumberOfWheels()
        {
            return _numberOfWheels;
        }

        public void SetNumberOfWheels(int numberOfWheels)
        {
            _numberOfWheels = numberOfWheels;
        }

        public double GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public void SetMaxSpeed(double maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        public bool GetTransferBox()
        {
            return _transferBox;
        }

        public void SetTransferBox(bool transferBox)
        {
            _transferBox = transferBox;
        }

        public int GetNumberOfSeats()
        {
            return _numberOfSeats;
        }

        static public void SetNumberOfSeats(int numberOfSeats)
        {
            _numberOfSeats = numberOfSeats;
        }

        public string GetTypeEngine()
        {
            return _typeEngine;
        }

        public void SetTypeEngine(string typeEngine)
        {
            _typeEngine = typeEngine;
        }

        public string GetNumber()
        {
            return _number;
        }

        public void SetNumber(string number)
        {
            _number = number;
        }

        public bool ImproveCar(ref int money)
        {
            if (money >= (int)_maxSpeed * 40)
            {
                money -= (int)_maxSpeed * 40;

                _maxSpeed += 10;               

                return true;
            }
            return false;
        }


    }
}
