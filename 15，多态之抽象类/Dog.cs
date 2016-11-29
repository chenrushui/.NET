using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_多态之抽象类
{
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗在叫！");
        }
    }
}
