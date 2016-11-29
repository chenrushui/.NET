using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_多态复习
{
    class Program
    {
        static void Main(string[] args)
        {

            //实现多态的时候，一般都是声明父类
            Employee e = new Employee();
            e.DaKa();
            e = new Manager();
            e.DaKa();
            e = new Programmer();
            e.DaKa();
            Console.ReadKey();


        }
    }
}
