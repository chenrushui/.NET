using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_进程类
{
    class Program
    {
        static void Main(string[] args)
        {

            //进程类：每一个应用程序都是一个进程。不是静态类，可以创建对象。Process类的使用
            
            //进程类的作用:
            //1)获取系统中正在运行的所有应用程序
            //2)通过进程打开应用程序
            //3)通过进程打开指定的文件

            //1)获取所有正在运行的进程(正在运行的应用程序)
            Process[] p = Process.GetProcesses();
            foreach (var item in p)
            {
                //2)杀死所有的进程
                //item.Kill();
                //Console.WriteLine(item);
            }

            //3)通过进程打开一些应用程序:
            //打开计算机
            Process.Start("calc");
            Process.Start("mspaint");
            Process.Start("notepad");

            //4)通过进程打开指定的文件
            //创建进程打开实例
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Tuhuadmin\Desktop\C#资料");
            //创建进程对象
            Process process = new Process();
            //打开实例
            process.StartInfo = psi;
            process.Start();




            Console.ReadKey();





        }
    }
}
