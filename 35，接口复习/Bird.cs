using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_接口复习
{
    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞!");
        }
    }
}
