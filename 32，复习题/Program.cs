using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_复习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //File、Path、Directory、stream(FileStream、StreamReader、StreamWriter)

            //File：使用File操作文件，使用File类读取和写入数据。
            //Directory：操作目录的类。

            //修改文件的扩展名，但是只是修改的字符串，并没有改变源文件
            string path = @"C:\Users\Tuhuadmin\Desktop\段子.txt";
            string result = Path.ChangeExtension(path, "jpg");
            Console.WriteLine(result);

            //获取文件夹的名字(此文件在哪个文件夹中)
            Console.WriteLine(Path.GetDirectoryName(path));

            //1)File类:创建  删除  剪贴  复制
            //File.Create(@"C: \Users\Tuhuadmin\Desktop\a.txt");
            Console.WriteLine("创建成功！");
            //File.Delete(@"C: \Users\Tuhuadmin\Desktop\a.txt");
            Console.WriteLine("删除成功！");
            //复制操作，源文件还在的
            //File.Copy(@"C:\Users\Tuhuadmin\Desktop\a.txt", @"C:\Users\b.txt");
            Console.WriteLine("复制成功！");
            //剪贴
            //File.Move(@"C:\Users\Tuhuadmin\Desktop\a.txt", @"C:\Users\Tuhuadmin\Desktop\C#资料\1.txt");
            Console.WriteLine("剪贴成功！");

            //2)使用File类读取数据,以字节数组的形式读取，行的形式读取，文本的形式全部读取完毕
            //File.ReadAllBytes() File.ReadAllLines(); File.ReadAllText();
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\Tuhuadmin\Desktop\段子.txt");
            //把读取到的字节数组转码成字符串
            //string content = Encoding.Default.GetString(buffer, 0, buffer.Length);
            //Console.WriteLine(content);

            //string[] str1 = File.ReadAllLines(@"C:\Users\Tuhuadmin\Desktop\段子.txt");
            //循环输出
            //foreach (var item in str1)
            //{
            //    Console.WriteLine(item);
            //}

            //string str = File.ReadAllText(@"C:\Users\Tuhuadmin\Desktop\段子.txt");
            //Console.WriteLine(str);

            //------------------------------------------------------------
            //向文件中写入字节数组(把一个字符串通过字节数组的形式写入到文件中)
            //string str3 = "东滩湿地公园,候鸟回家";
            //byte[] buffer1 = Encoding.Default.GetBytes(str3);
            //File.WriteAllBytes(@"C:\Users\Tuhuadmin\Desktop\b.txt", buffer1);
            //Console.WriteLine("写入OK");

            //File.WriteAllLines();  File.WriteAllText();  File.AppendAllText() 追加不覆盖

            //案例:工资加倍，然后保存到新文件
            //1)首先把文件读取出来，然后截取工资，乘以2，然后保存文文件
            //因为是按照行操作数据
            string[] content = File.ReadAllLines(@"C:\Users\Tuhuadmin\Desktop\工资文件.txt",Encoding.Default);
            //创建一个新的数组去存储数据
            string[] newStr1 = new string[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                int index = content[i].IndexOf("|");
                string salary = content[i].Substring(index+1);
                double d = double.Parse(salary) * 2;
                //生成新的字符串，并保存到字符串数组里面
                string newStr = content[i].Substring(0, index) + "|" + d;
                newStr1[i] = newStr;
            }
            //参数可以直接为字符串
            File.WriteAllLines(@"C:\Users\Tuhuadmin\Desktop\工资文件.txt", newStr1);
            Console.WriteLine("写入成功!");
            Console.ReadKey();
        }
    }
}
