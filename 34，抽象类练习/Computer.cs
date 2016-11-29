using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_抽象类练习
{
    //电脑类
    class Computer
    {
        //在电脑类中拿到所有子类的父类，进行差异的屏蔽。
        public MobileStorage MS {
            get;
            set;
        }

        public void CPURead()
        {
            this.MS.Read();
        }

        public void CPUWrite()
        {
            this.MS.Write();
        }
    }
}
