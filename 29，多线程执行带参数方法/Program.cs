using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _29_多线程执行带参数方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //两个注意事项:
            //1)如果线程执行的方法带有参数，那么参数类型必输是object类型
            //2)参数必须在Start()方法中进行传递。
            Thread th = new Thread(Test);
            th.IsBackground = true;
            th.Start(123);
            Console.ReadKey();

        }
        public static void Test(Object obj)
        {
            int num = (int)obj;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PlayGames()
        {
            Random r = new Random();
            string str = r.Next(0, 9).ToString();
        }

        //Socket编程：socket就可以理解为程序间的电话机

    }
}
