using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_03_28_Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> sportolok = new List<Sportolo>();
            foreach (var sor in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                sportolok.Add(new Sportolo(sor));
            }
            Console.WriteLine($"3.feladat: {sportolok.Count}");

            Console.ReadKey();
        }
    }
}
