using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_多态之抽象类
{
  public abstract class  Animal
    {
        //为什么需要抽象方法，因为根本不知道如何实现这个方法?
        public abstract void Bark(); 
    }
}
