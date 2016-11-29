using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_面向对象基础
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过对象的属性进行赋值和取值。
            //可以把属性理解为内部类，直接可以点出来，里面包含两个方法

            //创建对象
            Person p1 = new Person();
            //给属性设置值
            p1.Age = 12;
            p1.Name = "陈如水";
            p1.Gender = '男';
            //打印设置的值
            Console.WriteLine(p1.ToString());
            //调用静态方法
            Person.CHLLS();
            //调用非静态方法
            p1.PlayGames();

            //通过有参数构造函数创建对象
            Person p2 = new Person("陈诗音", 21, '女');
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p2.Age + p2.Name + p2.Gender);

            //显示票价
            Ticket ti = new Ticket(90);
            ti.ShowTicket();

            //命名空间其实就是项目名称，如果不导入命名空间，就不能使用其中的类
            List<int> list= new List<int>();


            Console.ReadKey();


        }
    }
}
