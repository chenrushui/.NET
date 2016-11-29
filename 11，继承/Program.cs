using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student("陈如水", 22, '男', 1);
            s.Talk();
            Console.WriteLine(s.ToString());
            Console.ReadKey();

            //多态的学习：让一个对象表现出多种状态(多种类型)
            //实现多态的两种方法：虚方法，抽象类。
            //抽象类理论：abstract，抽象方法不允许有方法体


        }
    }
}
