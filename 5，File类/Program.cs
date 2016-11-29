using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File类：文件操作的类
            //静态类，对文件的常见操作:创建、删除、复制，经常配合Path一起使用

            //1)在指定的路径下创建文件，但是如果指定的路径下已经存储此文件，就不会创建了
            File.Create(@"C:\Users\Tuhuadmin\Desktop\a.txt");
            Console.WriteLine("创建成功！");

            //2)删除指定路径下的文件
            File.Delete(@"C:\Users\Tuhuadmin\Desktop\a.txt");
            Console.WriteLine("删除成功!");

            //3)复制一个文件到指定路径下(文件名必须，相同)
            File.Copy(@"C:\Users\Tuhuadmin\Desktop\a.txt", @"C:\Users\Tuhuadmin\Desktop\付生项目\a.txt");
            Console.WriteLine("复制成功!");
            Console.ReadKey();






        }
    }
}
