using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_部分类和密封类
{
    class Program
    {
        static void Main(string[] args)
        {
            //部分类:主要是用于协作开发。
            //1)在同一个命名空间下，是否可以写两个名称相同的类，不能；在同一个类下也不能定义重复的方法(除了重载)
            //2)partial表示部分类，这样两个类就可以重名。这两个部分类就共同构成了Person类。
            //3)两个类共享对方的成员，无论是私有还是公有，部分类本质上就是一个类。这样一个类，分成几部分，写在不同的地方。
            //4)在两个部分类中不能够有相同的方法。

            //密封类：
            //怎么标记一个类是密封类?在class前面添加sealed,用于标记一个类是密封类
            //密封类最主要的特征是:密封类不能被继承，就相当于java中的最终类。但是密封类能够继承别的类。


        }


    }

    public sealed class Student
    {
    }
    public class English//:Student
    {
    }

    public partial class Person
    {
    }

    public partial class Person
    {
    }
}
