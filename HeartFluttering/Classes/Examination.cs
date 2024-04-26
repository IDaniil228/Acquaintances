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
        public static bool CheckNumber(string number)
        {
            foreach (char letter in letters)
            {
                if (!Char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckCity(string city)
        {

        }
    }
}
