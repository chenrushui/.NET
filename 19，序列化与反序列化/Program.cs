using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _19_序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化与反序列化:学完某个知识，一定要知道它是做什么的，要不然就相当于没学。
            //作用是:在网络中传输数据(在网络中传输的都是二进制数据)
            //序列化:将对象转化成二进制
            //反序列化:将二进制转化成对象

            //1)如何将一个类标记为可以序列化[serializable],只有被serializable标记的类，创建出来的对象才能被序列化。
            //2)序列化类：通过文件流把对象写入到指定的文件中 BinaryFormatter
            //3)bf.Serialize(fStream, p);//被序列化的对象  传入一个对象和文件流  Deserialize()
            //把对象序列化存储到文件中，将文件中的内容读取出来反序列化对象

            //Person p=  new Person();
            //p.Name = "张三";
            //p.Age = 12;
            //p.Gender = '男';
            //要将p这个对象序列化，传输给对方的电脑
            //如何将一个类标记为可以序列化[serializable],只有被serializable标记的类，创建出来的对象才能被序列化。
            //using (FileStream fStream=new FileStream(@"C:\Users\Tuhuadmin\Desktop\a.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite))
            //{

            //    //序列化类：通过文件流把对象写入到指定的文件中
            //    //创建序列化类对象,调用序列化的方法。FileStream继承自Stream
            //    BinaryFormatter bf = new BinaryFormatter(); 
            //    bf.Serialize(fStream, p);//被序列化的对象
            //}
            //Console.WriteLine("序列化成功!");

            //反序列化：接收对方发送过来的二进制，反序列化对象
            Person p;
            using (FileStream fStream=new FileStream(@"C:\Users\Tuhuadmin\Desktop\a.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite))
            {
                BinaryFormatter bm = new BinaryFormatter();
                p=(Person)bm.Deserialize(fStream);
            }
            Console.WriteLine(p.Name+ "---" + p.Age+ "---" + p.Gender);
            Console.ReadKey();

        }
    }
}
