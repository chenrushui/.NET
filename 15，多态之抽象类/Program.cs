using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_多态之抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //绝对路径和相对路径
            //绝对路径相对于本电脑而言，能够直接在这个电脑中找到此文件
            //相对路径相对于应用程序而言，在开发中尽量使用相对路径。

            //装箱、拆箱
            //装箱就是将值类型转化成引用类型
            //拆箱就是讲引用类型转化成值类型
            //看两种类型是否发生了装箱或者拆箱，就要看这两种类型是否存在继承关系
            //尽量避免发现拆装箱，因为会影响性能。

            //将创建文件流对象的过程写在using代码块中，会自动帮助我们释放文件流所在用的资源。

            //使用抽象类实现多态 
            //1)当父类中的方法不知道如何去实现的时候，可以考虑将父类写成抽象类，将方法写成抽象方法.
            //抽象方法是不允许有方法体的，使用关键字abstract进行标识。没有方法体和空实现是不一样的。
            //抽象类和接口不能创建对象
            //抽象类中可以写非抽象的成员，子类不需要实现。但是父类不能调用，子类可以继承调用。

            //如何通过抽象类实现多态呢?
            //1)父类为抽象类,存在抽象方法。存在继承关系。
            //2)父类里的抽象函数被子类重写了。

            //抽象类和虚方法的区别是什么?
            //一个父类里面有实现，一个父类里面没有实现；

            //属性的本质是两个方法

            Animal animal1 = new Dog();
            animal1.Bark();
            Animal animal2 = new Cat();
            animal2.Bark();

            //使用多态求矩形的面积和周长以及圆形的面积和周长
            Shape shape1 = new Square(5,6);//new Circle(5);
            double area = shape1.GetArea();
            double para = shape1.GetParameter();
            Console.WriteLine(area + "---------------"+para);
           
            Console.ReadKey();







        }
    }
}
