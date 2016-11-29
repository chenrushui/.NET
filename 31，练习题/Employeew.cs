using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_练习题
{
    class Employeew : Person
    {
        public double Salary
        {
            get;
            set;
        }

        public override void SayHi()
        {
            Console.WriteLine("具体的方法");
        }
    }
}
