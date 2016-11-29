using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_多态之接口理论
{
    class Program
    {
        static void Main(string[] args)
        {
            //接口:interface
            //接口就是一种规范、能力。(只有符合接口规范，才能完成通讯)
            //接口语法:定义规范，以I开头以able结尾 I...able
            //1)一个类实现接口，必须实现接口中的抽象方法。抽象方法可以有返回值。

            //接口中的成员不允许添加访问修饰符，默认就是public。
            //接口中所有的方法都必须是抽象方法，不能有方法体。
            //接口中不能包含字段，字段是用来存储数据的。
            //自动属性和普通属性的区别:自己手动写的是普通属性，还没有写过自动属性。这是自动属性Age{get；set；}既没有字段也没有方法体。
            //属性的本质是两个方法，用于保护字段的。
            //接口里的成员可以有方法、自动属性(因为自动属性没有方法体)、索引器，它们本质上都是方法。


            //什么时候需要接口?当类需要多继承的时候，就可以考虑使用接口实现
            //接口、静态类、抽象类不能被实例化。

            //面向对象编程--->面向接口编程（天气状况，只要实现接口就能拿到其中的数据）

            //显示实现接口：
            //为什么需要显示的实现接口?为了解决方法的重名问题(子类和接口中的方法重名问题)
            //什么是显示的实现接口?在方法名前加接口名。IFlyable.Fly(),用于标识此方法是哪个类中的。

            //类中的成员默认是private。接口中的访问修饰符默认是public。类的默认访问修饰符为internal。

            IFlyable iFlyabl = new Bird(); //new Person();
            iFlyabl.Fly();
            Console.ReadKey();


        }
    }
    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机！");
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞！");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }



}
