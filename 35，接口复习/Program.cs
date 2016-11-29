using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_接口复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口复习:接口存在的意义就是实现多态

            IFlyable iFlyable = new Bird();
            iFlyable.Fly();
            iFlyable = new Plane();
            iFlyable.Fly();
            Console.ReadKey();


        }
    }
}
