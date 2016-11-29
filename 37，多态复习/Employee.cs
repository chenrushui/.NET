using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_多态复习
{
    //员工类,员工类需要创建对象
    class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点上班打卡");
        }

    }
}
