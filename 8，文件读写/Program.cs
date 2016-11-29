using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_文件读写
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream类的使用:文件流类，用于操作字节,通过字节数组的形式写入与读取，都要使用到编解码类Encoding 
            //使用这个类读取数据 Read() ，写入数据 

            //StreamReader，StreamWriter：用于操作字符，EndOfStream属性用于判断是否读取到文件的末尾。
            //FileMode文件模式类:针对文件做什么操作,FileMode.Append() 追加内容，追加到文件的末尾。
            //FileAccess:文件读写权限类
            //先读取到内存中，在写入到指定的位置
            //配合using关键字的使用


            //Encoding编解码类

            //文件操作：1)关闭流,fs.Close().2)释放资源,fs.Dispose()
            //将创建文件流对象的代码写在using(){}代码块中，系统能够帮我们自动释放资源

            //文件读写步骤:
            //1)创建FileStream对象，设置文件模式和文件权限
            //2)通过Encoding类，字节数组<---->字符串的相互转化
            //3)调用Read()或者Writer()方法进行读写操作
            //4)关闭流，释放资源；如果创建流的代码在using(){}代码块中，则这一步省略。

            //练习一：读取文件中的内容并在控制台显示
            //参数:要操作的文件路径，设置文件模式
            FileStream fs = new FileStream(@"C:\Users\Tuhuadmin\Desktop\a.txt", FileMode.Open);
            //创建字节数组
            byte[] buffer = new byte[1024 * 1024 * 5];
            //进行读取操作(每次读取5M)，获取读取的长度
            int b = fs.Read(buffer, 0, buffer.Length);
            //将字节数组中的每一个元素按照指定的编码方式解码成字符串;第一个要解码字符的索引，解码多少了字符啊
            string str = Encoding.Default.GetString(buffer, 0, b);
            //关闭流
            fs.Close();
            //释放资源
            fs.Dispose();
            Console.WriteLine(str);

            //练习二：向文件中写入数据
            using (FileStream fsWrite = new FileStream(@"C:\Users\Tuhuadmin\Desktop\a.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string content = "碧云天，黄叶地，秋色连波，波上寒烟翠！";
                //将字符串转化成字节数组
                byte[] bufferWrite = Encoding.Default.GetBytes(content);
                fsWrite.Write(bufferWrite, 0, bufferWrite.Length);
            }
            Console.WriteLine("写入成功！");

            //练习三：使用FileStream实现多媒体文件的复制，将多媒体文件中的数据读取出来在写入到指定的位置
            string source = @"C:\Users\Tuhuadmin\Desktop\触发器.avi";
            string target = @"C:\Users\Tuhuadmin\Desktop\付生项目\触发器.avi";
            CopyFile(source, target);
            Console.WriteLine("复制成功!");

            //练习四：使用StreamReader与StreamWriter类实现文本文件的读写
            ReadTextFile();
            WriteTextFile();

            Console.ReadKey();


        }

        private static void WriteTextFile()
        {
            using (StreamWriter sWriter=new StreamWriter(@"C:\Users\Tuhuadmin\Desktop\a.txt",true,Encoding.UTF8))
            {
                sWriter.Write("念去去千里烟波，暮霭沉沉楚天阔");
            }
        }

        private static void ReadTextFile()
        {
            using (StreamReader sReader = new StreamReader(@"C:\Users\Tuhuadmin\Desktop\a.txt",Encoding.Default))
            {
                //是否读取到文件的末尾
                while (!sReader.EndOfStream)
                {
                    Console.WriteLine(sReader.ReadLine());
                }
            }

        }

        private static void CopyFile(string source, string target)
        {
            using (FileStream fsReader = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWriter = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //读取的时候需要使用字节数组
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        //length表示实际读取到的字节数
                        int length = fsReader.Read(buffer, 0, buffer.Length);
                        //如果读取到的数据为0，说明已经读取完毕，字节跳出循环
                        if (length == 0)
                        {
                            break;
                        }
                        //把文件写入到指定的位子(首选从磁盘读取到内存中，然后从内存写入到指定的磁盘位置上)
                        fsWriter.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
