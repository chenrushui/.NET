using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //高效的StringBuilder类的使用:

            //当大量进行字符串操作的时候，比如很多次字符串的拼接操作。
            //String对象是不可变的，每次使用string类的方法时，都要在内存中创建一个新的字符串对象，这就需要为该对象分配内存空间。在需要对字符串执行重复修改的情况下，与创建新的string对象相关的系统开销可能非常大。如果要修改字符串而不是创建新的对象，则可以使用StringBuilder
            //将StringBuilder转化成string，使用ToString().
            //常用方法:
            //StringBuilder sb = new StringBuilder()
            //sb.Append()// 追加字符串；
            //sb.ToString()//转化成string；
            //sb.Insert()
            //sb.Replace()

            //面试的时候经常问:
            //1)字符串具备不可变性，每次调用string类的方法，都会在内存中开辟空间，创建对象。
            //2)如果对字符串进行大量重复的操作，就会造成系统开销非常大(特别是字符串的读取和写入)
            //3)StringBuilder类可以在不创建新的字符串的情况下，进行字符串的修改。

            StringBuilder sb = new StringBuilder();
            //追加字符串
            sb.Append("陈诗音");
            sb.Append("陈诗乐");
            sb.Append("陈如水");
            //在指定的索引处进行插入(字符的索引)
            sb.Insert(1, "张慧");
            //进行替换操作
            sb.Replace("张慧","晴耕雨读");
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
