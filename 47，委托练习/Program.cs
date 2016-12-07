using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_委托练习
{
    //声明一个委托类型，必须和方法的签名一样
    //和字符串的声明一样
    public delegate string DelProString(string name);


    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "adsJIhioh", "hiHIOHniH", "jSADAjU", "HBUVByigfv" };

            //首先要有一个函数，里面的参数是委托类型
            //声明一个委托类型

            //匿名函数的使用:
            ProStr(names, delegate(string name) {
                return name.ToLower();
            });
            //注意事项:1)使用委托关键字代替 delegate，参数为方法的参数，return为方法的返回值
            //2)当方法执行一次时，可以考虑使用匿名函数

            //lamda表达式:goes to  =>滚向


            //调用委托方法
            ProStr(names, StrToUpper);
            
            //循环遍历数组
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();

        }


        //提供一个方法
        public static void ProStr(string[] name, DelProString del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }





        //提供三个方法:
        public static string StrToUpper(string name)
        {
            return name.ToUpper();
        }
        public static string StrToLower(string name)
        {
            return name.ToLower();
        }
        public static string StrToAdd(string name)
        {
            return "\"" + name + "\"";
        }



    }
}
