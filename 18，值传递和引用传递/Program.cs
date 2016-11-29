using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型：int char double bool decimal enum struct
            //引用类型:string 自定义类 数组 object 集合 接口(6种)

            //值传递和引用传递
            //值类型在传递的时候，传递的是值本身(复制)。
            //引用类型在复制的时候，传递的是这个对象的地址

            //Person p1=  new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "李四";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p2.Name);
            //结果都是李四，因为两个对象指向同一块内存地址，两个变量里面存储的是内存的地址值(地址值指向某个堆存储空间)

            Person p1 = new Person();
            p1.Name = "张三";
            test(p1);
            Console.WriteLine(p1.Name);
            //结果都是李四，因为指向的都是同一块内存空间

            string s1 = "陈如水";
            string s2 = s1;
            s2 = "陈诗音";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //结果是陈如水、陈诗音，字符串具有不可变性，重新赋值就会开辟新的存储空间

            //ref关键字的作用:可以给 基本类型（比如整形） 加上ref，就按引用传递了。把值传递转变成引用传递。把栈的地址赋值了一份。
            //操作的是同一块栈内存。
            Console.ReadKey();
        }

        private static void test(Person pp)
        {

            Person p2 = pp;
            p2.Name = "李四";
        }
    }
}
