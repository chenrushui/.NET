using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path类
            //静态类，类中全部是是静态成员,可以直接调用，其实是对字符串方法的封装

            //取消转义，需要在路径前面添加@符号
            string url = @"C:\Users\Tuhuadmin\Desktop\面向对象初级\老赵.avi";

            //1)获取文件名
            //通过字符串进行操作,从给定的索引处开始截取，一直截取到最后
            int index = url.LastIndexOf("\\");
            string fileNameStr = url.Substring(index + 1);
            Console.WriteLine(fileNameStr);

            //通过Path类来操作
            string fileName = Path.GetFileName(url);
            Console.WriteLine(fileName);

            //2)获取文件名，忽略扩展名
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(url);
            Console.WriteLine(fileNameWithoutExtension);

            //3)获取文件扩展名
            string fileExetensionName = Path.GetExtension(url);
            Console.WriteLine(fileExetensionName);

            //4)获取指定文件的目录信息,即当前文件在哪个文件夹下
            string fileDir = Path.GetDirectoryName(url);
            Console.WriteLine(fileDir);

            //5)获取指定文件的全路径
            string fileFullPath = Path.GetFullPath(url);
            Console.WriteLine(fileFullPath);

            //6)连接两个字符串拼接成一个字符串,其实是中间添加了一个\
            string str = Path.Combine(@"C: \Users\Tuhuadmin\Desktop", "魅力中国.avi");
            Console.WriteLine(str);
 
            Console.ReadKey();












        }
    }
}
