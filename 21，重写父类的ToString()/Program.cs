using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_重写父类的ToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            //重写父类的ToString()方法

            //如果不重写ToString方法,直接打印，打印的是类的命名控件
            Person p=  new Person();
            Console.WriteLine(p.ToString());//_21_重写父类的ToString__

            //ToString()是object的虚方法,所以的变量和对象都可以调用。
            
            Student s= new Student();
            Console.WriteLine(s.ToString());

            Console.ReadKey();
        }
    }

    public class Person {

    }

    public class Student {
        public override string ToString()
        {

            //return base.ToString();
            return "重写父类的ToString()方法";
        }
    }

}
