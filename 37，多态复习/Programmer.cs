using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_多态复习
{
    class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序员不打卡！");
        }
    }
}
