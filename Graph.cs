using System;
using System.Collections.Generic;
using System.Text;

namespace kortej
{

    class Graph
    {
        private List<(string First, string Second, int Distance)> cities;
        private List<string> citiesNames;

        public Graph(List<(string First, string Second, int Distance)> cities)
        {
            citiesNames = new List<string>();
            this.cities = cities;

            foreach (var (First, Second, Distance) in cities)
            {
                if (!citiesNames.Contains(First))
                {
                    citiesNames.Add(First);
                }
                if(!citiesNames.Contains(Second))
                {
                    citiesNames.Add(Second);
                }
            }
        }
        public string[] GetNamesCities()
        {
            return citiesNames.ToArray();
        }
        public int FindMin()
        {
            int min = Int32.MaxValue;
            foreach (var (First, Second, Distance) in cities)
            {
                if (Distance < min)
                {
                    min = Distance;
                }
            }
            return min;
        }
        public int FindMax()
        {
            int max = Int32.MinValue;
            foreach (var (First, Second, Distance) in cities)
            {
                if (Distance > max)
                {
                    max = Distance;
                }
            }
            return max;
        }
        public int Sum()
        {
            int sum = 0;
            foreach (var (First, Second, Distance) in cities)
            {
                sum += Distance;
            }
            sum /= 2;
            return sum;
        }
    }
}
