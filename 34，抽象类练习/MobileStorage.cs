using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_抽象类练习
{
    //标记一个类是抽象类:
    abstract class MobileStorage
    {
        //提供两个抽象方法
        public abstract void Read();
        public abstract void Write();

    }
}
