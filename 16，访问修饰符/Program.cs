using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#中的访问修饰符：5个
            //1)public：公开的，公共的，只要添加引用，哪里都可以访问。
            //2)private:只能在当前类的内部进行访问，子类不能访问；类中成员的访问修饰符默认就是private。main函数的访问修饰符为private
            //3)protected：受保护的，只能在当前类的内部以及子类中访问
            //4)internal:类默认的访问修饰符，如果不手动添加public。只能在当前项目中进行访问。
            //5)protected internal:

            //internal与protect的访问权限带下无法比较，没有比较标准。
        


            //添加对另一个项目的引用(项目的引用结点)
            //但是有internal修饰的类，就算添加引用，也不能在其他项目中访问。
            //在同一个项目中public与internal的权限是一样的。
            //在同一个项目中，internal的权限要大于protected
            //能够修饰类的访问修饰符为public和internal
            //子类的访问权限不能高于父类的访问权限，比如父类为internal修饰，子类有public修饰，那么此时其他项目也可以访问父类中的内容。但是internal不让其他项目访问这样就就矛盾了。如果子类的访问权限大于父类的访问权限会暴露父类的成员。
            //可访问性不一致的问题
        }
    }
}
