using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach遍历集合
            //for循环与foreach循环的效率问题：如果循环次数比较多，foreach循环的效率比较高。

            //Stopwatch类,用于事件执行时间监听，两个方法和一个属性

            int[] sum = { 2, 34, 5, 7, 9, 5, 34, 2, 6, 7, 89, 9, 0, 5, 4, 3, 2, 2, 12 };


            Stopwatch watch= new Stopwatch();
            watch.Start();
            //使用普通for循环
            //for (int i = 0; i < sum.Length; i++)
            //{
            //    Console.WriteLine(sum[i]);
            //}

            //使用增强for循环
            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }

            watch.Stop();
            //打印这个事件的执行时间
            Console.WriteLine(watch.Elapsed);
        }
    }
}
