using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartFluttering.Classes
{
    public static class Examination
    {
        public static bool CheckLatter(string letters)
        {
            foreach(char letter in letters)
            {
                if (!Char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckNumber(string numbers)
        {
            foreach (char number in numbers)
            {
                if (!Char.IsLetter(number))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckCity(string cities)
        {
            AllCities Allcities = new AllCities();
            if (!Allcities.getCities().Contains(cities.ToLower()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
