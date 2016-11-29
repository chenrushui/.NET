using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_文件编解码
{
    class Program
    {
        static void Main(string[] args)
        {
            //核心内容:文件编码和File操作类(字符串与字节数组的转化)

            //文件编解码:针对文本文件的操作
            //1)文本文件有不同的存储方式，将字符串以什么样的形式保存为二进制文件，这就是编码问题。
            //2)如果出现乱码现象，就是编解码有问题。
            //3)什么是文本文件，用记事本能够打来的文件, .doc结尾的不是。
            //4)编解码为类Encoding
            //5)乱码产生的原因:你保存这个文件的编码格式与打开这个文件的编码格式不一致。

            //1)将字符串转化成字节数组
            //File类里面的方法:WriteAllBytes() ReadAllBytes()  ReadAllLines() ReadAllText() AppendAllText()
            string str = "碧云天，黄叶地，秋色连波，波上寒烟翠，山映斜阳天接水，芳草无情，更在斜阳外。";
            byte[] buffer = Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\Tuhuadmin\Desktop\a.txt", buffer);
            Console.WriteLine("写入成功!");

            //2)将字节数组转化成字符串
            byte[] b = File.ReadAllBytes(@"C:\Users\Tuhuadmin\Desktop\a.txt");
            string str1 = Encoding.Default.GetString(b);
            Console.WriteLine(str1);

            //3)打开一个文件,按照指定的编码格式读取文件的所有行，然后关闭文件(以行的形式读取)(需要指定编码格式)
            string[] str2 = File.ReadAllLines(@"C:\Users\Tuhuadmin\Desktop\a.txt", Encoding.Default);
            foreach (var item in str2)
            {
                //每次读取一行，打印每一行的数据
                Console.WriteLine(item);
            }

            //4)读取所有的文本
            string content = File.ReadAllText(@"C:\Users\Tuhuadmin\Desktop\a.txt", Encoding.Default);
            Console.WriteLine(content);

            //5)向一个文件中追加内容
            string add = "待我君临天下，许你四海为家";
            File.AppendAllText(@"C:\Users\Tuhuadmin\Desktop\a.txt",add,Encoding.Default);
            Console.ReadKey();






        }
    }
}
