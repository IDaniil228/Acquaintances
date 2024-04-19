using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartFluttering
{
    internal class AllCities
    {
        public List<string> getCities()
        {
            List<string> cities = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("cities.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cities.Add(line.Trim()); // Добавляем каждый город из файла в коллекцию List
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            return cities;
        }
    }
}
