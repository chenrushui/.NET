using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_静态和非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态和非静态的区别:
        }
    }

    public class Person
    {
        private static string _name;
        private int _age;
        //非静态方法
        public void M1()
        {
            //可以使用静态成员也可以使用非静态成员
        }
        public static void M2()
        {
            _name = "陈如水";
            //_age = 12;
        }

    }
    public static class Student
    {
        //不能在静态类中声明实例成员,因为创建时机不一样。
        //private string _name;

    }
}
