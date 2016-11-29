using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_面向对象复习
{
    class Daughter : Father
    {
        //能够一键生成子类的构造方法
        public Daughter(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {
        }

        public void Dance()
        {
            Console.WriteLine("女儿会跳舞!");
        }
    }
}
