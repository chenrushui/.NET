using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候用虚方法实现多态？(能够创建父类对象)
            //什么时候用抽象类实现多态？
            //什么时候用接口实现多态？(有共同的行为和能力)

            //练习：真的鸭子会游泳，木头鸭子不会游泳，橡皮鸭子会游泳。
            ISwimming iSwimming = new XpDuck();//new RealDuck();
            iSwimming.Swim();
            Console.ReadKey();

        }
    }

    public class RealDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀会游泳");
        }
    }
    public class MuDuck : RealDuck
    {

    }
    public class XpDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }
    public interface ISwimming {
        void Swim();
    }


}
