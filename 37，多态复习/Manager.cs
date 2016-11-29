using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_多态复习
{
    class Manager:Employee
    {
        //重写父类中的方法
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }


    }
}
