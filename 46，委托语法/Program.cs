using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_委托语法
{
    //委托写在项目的命名空间下，声明一个委托指向一个函数（签名必须和方法相同）
    public delegate void DelSayHello(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //委托:
            //为什么要使用委托？
            //委托概念
            //匿名函数
            //练习：使用委托求数组的最大值
            //练习：使用委托求任意数组的最大值
            //泛型委托
            //多播委托
            //lamda表达式
            //使用委托来实现窗体传值

            //三个需求:
            //将数组中的每个元素都转化成大写，
            //将数组中的每个元素都转化成小写，
            //将数组中的每个元素的两边都加上双引号。

            string[] names = { "adsJIhioh", "hiHIOHniH", "jSADAjU", "HBUVByigfv" };
            //全部转化成大写,并打印输出结果
            //ToUpper(names);
            //全部转化成大写
            //ToLower(names);
            //字符串的两侧全部都要添加引号
            ToAddRemark(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //传递一件事情过来，传递一个方法过来，
            //把方法作为参数传递，方法的类型就是委托类型，其实传递的是方法名
            //声明一个委托，指向一个函数(声明一个委托类型)
            //委托里面装的就是其中的一个方法,委托是指向函数的。
            //我们可以把一个函数赋值给委托，前提是函数的签名和委托的签名必须是一样的。
            //函数可以赋值给一个委托

            //委托的调用形式:
            //DelSayHello del = new DelSayHello(SayHiEnglish);
            //把方法名赋值给委托类型
            //DelSayHello del = SayHiChinese;
            //del("张三");

            //委托的标准用法是什么?
            //声明一个委托，指向这三个函数。
            //方法调用，把函数赋值给委托类型。


            Test("陈如水", SayHiChinese);
            Console.ReadKey();
        }

        public static void Test(string name, DelSayHello del)
        {
            //调用委托
            del(name);
        }
        
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃饭了吗" + name);
        }

        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("how are you?" + name);
        }
        
        private static void ProcessStr(string[] names)
        {
            //引用类型，不用返回值，直接操作数组对象本身
            ToUpper(names);
            ToLower(names);
            ToAddRemark(names);
        }

        private static void ToAddRemark(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                //使用转移字符
                names[i] = "\"" + names[i] + "\"";
            }

        }

        private static void ToLower(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToLower();
            }
        }

        //转化成大写
        private static void ToUpper(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToUpper();
            }

        }
    }
}
