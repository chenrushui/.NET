using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_单例模式
{
    class Person
    {

        //这种形式没有考虑线程安全的问题



        private static Person mInstance;
        
        
        
        
        //将构造函数私有
        private Person()
        {

        }

        //提供一个静态方法，返回一个实例
        public static Person GetInstance()
        {
            //如果当前实例存在，就直接返回！
            if (mInstance == null)
            {
                mInstance = new Person();
            }
            //返回当前类的对象
            return mInstance;
        }
    }
}
