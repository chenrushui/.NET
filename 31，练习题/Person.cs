using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_练习题
{
    class Person
    {
        //三个属性
        public string Name
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("hello world！");
        }
    }
}
