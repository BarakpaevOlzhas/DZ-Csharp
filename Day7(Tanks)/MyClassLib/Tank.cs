using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string Name { get; set; }

        public int LevelOfAmmunition { get; set; }

        public int LevelOfArmor { get; set; }

        public int LevelOfManeuverability { get; set; }

        public Tank(string name)
        {
            Random random = new Random();
            
            Name = name;

            LevelOfAmmunition = random.Next(0,100);

            LevelOfArmor = random.Next(0, 100);

            LevelOfManeuverability = random.Next(0, 100);
        }

        public string GetStats()
        {
            return $"Название {Name} \n Уровня боекомплекта танка: {LevelOfAmmunition} \n Уровня брони: {LevelOfArmor} \n Уровня маневренности: {LevelOfManeuverability}";
        }

        public static int operator *(Tank tankOne, Tank tankTwo)
        {
            int plusOne = 0;
            int plusTwo = 0;

            if (tankOne.LevelOfAmmunition > tankTwo.LevelOfAmmunition)
            {
                plusOne++;
            }

            else if (tankOne.LevelOfAmmunition < tankTwo.LevelOfAmmunition)
            {
                plusTwo++;
            }

            if (tankOne.LevelOfArmor > tankTwo.LevelOfArmor)
            {
                plusOne++;
            }

            else if (tankOne.LevelOfArmor < tankTwo.LevelOfArmor)
            {
                plusTwo++;
            }

            if (tankOne.LevelOfManeuverability > tankTwo.LevelOfManeuverability)
            {
                plusOne++;
            }

            else if (tankOne.LevelOfManeuverability < tankTwo.LevelOfManeuverability)
            {
                plusTwo++;
            }

            if (plusOne > plusTwo)
            {
                return 1;
            }

            else if (plusOne < plusTwo)
            {
                return 0;
            }

            return -1;
        }

    }
}
