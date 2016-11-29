using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //面向对象复习:
            Son son = new Son("陈随心", 1000m, "AB");
            son.PlayGames();
            son.Information();
            Console.WriteLine("----------");
            Daughter daughter = new Daughter("陈诗音", 200m, "O");
            daughter.Dance();
            daughter.Information();
            Console.ReadKey();
        }
    }
}
