using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_多态之虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态之虚方法
            //多态：1)子类可以赋值给父类。2)父类可以强转为子类。

            //多态：让一个对象能够表现出多种状态(屏蔽了子类之间的差异性)。

            //实现多太的三种方式:虚方法、抽象类、接口)
            //如何用虚方法实现多态呢?1)实现多态首先要存在继承关系。2)将父类的方法(同名方法)标记为虚方法，使用关键字virtual，意义是这个父类的函数可以被子类重写。3)在子类的方法上添加override，重写父类的方法。
            //原理是什么? 父类中装的是谁的对象，就调用谁的方法(因为父类中的方法被子类重写了)

            //因为是父类的形态(表现出来的是父类类型)，所以是调用的父类中的方法。如果想要调用子类的方法，就强转成子类对象

            //Person[] per = new Person[6];


            //作用是:调用子类的方法
            //1)存在继承关系，方法同名；
            //2)使用virtual将父类中的方法标记为虚方法；
            //3)使用override标记子类中的方法；

            //注意事项:
            //父类中如果有方法需要让子类重写，则可以将此方法标记为虚方法；虚方法在父类中必须有实现；虚方法子类可以重写也可以不重写。

            //抽象类的子类中重写父类中的方法：override，实现父类中的抽象方法。
            
            //空实现与方法体，方法签名相同是指方法的参数和返回值类型都相同

            //抽象类不可以创建对象，静态类不可以创建对象

            //接口存在的意义只是为了实现多态

            //学会质疑，一定要多问为什么，不能不求甚解(会，就要给别人讲出来)


            Chinese chinese = new Chinese("陈如水");
            Janpanese janpanese = new Janpanese("松下");
            Amerial ameria = new Amerial("科比");

            Person[] per = { chinese, janpanese, ameria };
            //1、这样调用的全是父类的SayHello方法，因为表现为父类的形态
            for (int i = 0; i < per.Length; i++)
            {
                per[i].SayHello();
            }

            //2、如何调用子类的方法呢？ 进行强制类型转换
            for (int i = 0; i < per.Length; i++)
            {
                if (per[i] is Chinese)
                {
                    ((Chinese)per[i]).SayHello();
                }
                else if (per[i] is Janpanese)
                {

                    ((Janpanese)per[i]).SayHello();
                }
                else
                {
                    ((Amerial)per[i]).SayHello();
                }
            }

            //3、上面这种写法特别麻烦，如何简单的实现呢
            //1)要想实现多态，必须存在继承关系；
            //2)在父类的同名方法上添加virtual关键字；
            //3)在子类的同名方法上添加override关键字；
            for (int i = 0; i < per.Length; i++)
            {
                //让一个对象表现为多种状态
                per[i].SayHello();
            }
            Console.ReadKey();


        }
    }
}
