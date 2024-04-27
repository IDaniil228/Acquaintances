using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HeartFluttering.Classes
{
    public static class Examination
    {
        public static bool CheckLetter(string letters)
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
            if (!numbers.StartsWith("+7") && !numbers.StartsWith("8"))
            {
                return false;
            }
            if ((numbers.StartsWith("+7") && numbers.Length == 12) || (numbers.StartsWith("8") && numbers.Length == 11))
            {
                if (Char.IsNumber(numbers[0]) || numbers[0] == '+')
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (!Char.IsNumber(numbers[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }            
            return false;

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
