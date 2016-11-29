using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory:用于操作文件夹(目录)的；静态类，里面全都是静态方法

            //1)创建文件夹：指定文件夹的名字
            DirectoryInfo info = Directory.CreateDirectory(@"C:\Users\Tuhuadmin\Desktop\a");
            Console.WriteLine("创建成功!");

            //2)删除文件夹：删除指定路径的文件夹；必须是空的文件夹才行，如果有内容就不能删除。
            Directory.Delete(@"C:\Users\Tuhuadmin\Desktop\a");
            //如果有内容，强制删除就添加bool值
            Directory.Delete(@"C:\Users\Tuhuadmin\Desktop\a", true);

            //3)剪贴文件夹:此时源文件夹已经不存在了。
            Directory.Move(@"C:\Users\Tuhuadmin\Desktop\a", @"C:");
            Console.WriteLine("剪贴成功!");

            //4)获取指定文件夹下，所有文件的全路径,包括文件的扩展名
            string[] str = Directory.GetFiles(@"C:\Users\Tuhuadmin\Desktop\C#资料");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            //5)获取指定文件夹下，所有指定文件后缀名的文件
            string[] str1 = Directory.GetFiles(@"C:\Users\Tuhuadmin\Desktop\C#资料", "*.sql");
            foreach (var item in str1)
            {
                Console.WriteLine(item);
            }

            //6)获取指定文件夹下，所有文件夹的路径
            string[] str2 = Directory.GetDirectories(@"C:\Users\Tuhuadmin\Desktop\photoStateListener");
            foreach (var item in str2)
            {
                Console.WriteLine(item);
            }

            //7)判断目录是否存在
            if (Directory.Exists(@"C:\Users\Tuhuadmin\Desktop\photoStateListener"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadKey();

        }
    }
}
