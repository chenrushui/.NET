using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _28_多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            //多线程:一个进程是由多个线程组成的。Thread
            //单线程带来的问题:在windows中每运行一个程序，windows操作系统就会分配一个线程来执行这个程序。
            //一个线程只处理一件事。单线程容易造成应用程序假死。

            //使用多线程的目的:多线程只是为了让应用程序同时处理多个事情，提高程序的执行效率。
            //进程和线程的关系:一般来说，一个进程包含多个线程。
            //线程的分类:前台线程和后台线程
            //在.net下，不允许跨线程访问，如果想要跨线访问，如何处理?
            //如何让线程执行带参数的方法
            //创建后台线程并使用的三行标准代码:
            //如果线程执行的方法有参数，这个参数必须是object类型；另外参数必须在Start()方法中进行传递.
                    

            //创建一个线程去执行这个方法，传入方法的方法名。
            //创建一个线程对象，执行这个Test方法
            Thread th = new Thread(Test);
            //如何将一个线程设置成后台线程?
            th.IsBackground = true;
            //标记这个线程已经准备就绪了，可以随时被cpu执行(cpu是随机执行的)
            th.Start();


            //让线程挂起一段时间(让当前线程停止运行一段时间)
            Thread.Sleep(1000);

            //经常会爆出一个错误:线程间操作无效
            //在.net下是不允许跨线程访问的(一个线程访问另一个线程的资源)

            //如何解决这个错误呢? 取消跨线程访问检查，即可。

            //前台线程:所有的前台线程都关闭了，程序才结束。
            //后台线程:只要所有的前台线程关闭了，后台线程自动结束。

            if (th != null)
            {
                //终止线程的执行//终止线程后就不能被重新Start().因为此时线程已经不存在了,无法被重新启动。
                th.Abort();
            }
        }

        private static void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
