using System;
using System.Collections.Generic;

namespace kortej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<(string, string, int)> cities = new List<(string, string, int)>
            {
                ("A", "B", 5),
                ("B", "A", 5),
                ("A", "D", 9),
                ("D", "A", 9),
                ("D", "C", 7),
                ("C", "D", 7),
                ("D", "E", 6),
                ("E", "D", 6),
                ("C", "E", 8),
                ("E", "C", 8),
                ("B", "E", 9),
                ("E", "B", 9),
            };
            Graph graph = new Graph(cities);

            foreach(var i in graph.GetNamesCities())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int min = graph.FindMin();
            Console.WriteLine("Min distance {0}", min);
            int max = graph.FindMax();
            Console.WriteLine("Max distance {0}", max);
            int sum = graph.Sum();
            Console.WriteLine("Sum all of distance {0}", sum);


        }
    }
}
