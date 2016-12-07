using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_lamda表达式
{

    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);


    class Program
    {
        static void Main(string[] args)
        {
            //lamda表达式 项目中使用的好多
            //goes to  =>滚向


            //使用匿名函数实现
            DelOne del = delegate ()
            {
                Console.WriteLine("匿名函数的使用");
            };

            //使用lamda表达式实现:表示方法参数，表示方法体
            DelOne del1 = () => { };
            DelTwo del2 = (string name) => { };
            DelThree del3 = (string name) => { return name; };

            //匿名函数的调用和执行
            del();
            del1();
            del2("陈如水");
            del3("陈如水");

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.RemoveAll(n => n > 4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
