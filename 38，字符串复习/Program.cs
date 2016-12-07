using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_字符串复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //复习字符串的常用方法:不可变性；可以当做是字符数组，通过索引器进行遍历；
            //只读属性，不能通过索引去赋值，只能通过索引值读取值。
            //学习.net就是学习类的用法,多记忆常用的方法

            string str1 = "陈如水";
            str1 = "陈诗音";
            //string类的静态方法  str=“”；str=null；
            //ToCharArray()转化成字符数组
            //将字符数组转化成字符串 new string(chs)
            //比较两个字符串是否相同
            //Contains()是否包含子串？
            //最后一次出现时的位置LastIndexOf()
            //截取substring() 一个参数 两个参数不一样
            //切割字符串 Split()  new char[]{' '}  StringSplitOptions
            //把字符串以某种分隔符进行拼接  string str1=string.Join("!",names)
            //replace替换操作，把旧的字符替换成新的字符
            //Length 属性，可以获取字符串中字符的个数;Count可以拿到集合的长度。
            //创建字符串对象 str=new string(chs),//尽量少的去创建对象。
            //翻转方法的使用 :char[] chs = str2.Reverse().ToArray();Array.Reverse(chs1);

            //路径可以用来操作文件名，获取文件名等等，File用于操作文件内容的，按照行读取；


            //进行元素翻转
            string str2 = "abcdef";
            //直接调用方法进行翻转
            char[] chs = str2.Reverse().ToArray();
            string result = "";
            foreach (var item in chs)
            {
                result += item;
            }
            Console.WriteLine(result);

            //使用另外一种方法
            char[] chs1 = str2.ToCharArray();
            Array.Reverse(chs1);
            string s3 = new string(chs1);
            for (int i = 0; i < chs1.Length; i++)
            {
                Console.Write(chs1[i]);
            }

            Console.WriteLine("---------------");
            Console.WriteLine(s3);
            //使数组中的元素全部交换位置
            char[] chs3 = str2.ToCharArray();
            for (int i = 0; i < chs3.Length / 2; i++)
            {
                char temp = chs3[i];
                chs3[i] = chs3[chs3.Length - i - 1];
                chs3[chs3.Length - i - 1] = temp;
            }
            string str5 = new string(chs3);
            Console.WriteLine(str5);

            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("是的！  ");
            }
            else
            {
                Console.WriteLine("不是！");
            }
            string s1 = "C#";
            string s2 = "c#";
            //忽略大小写进行比较  StringComparison枚举类
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("相等");
            }
            else
            {
                Console.WriteLine("不相等");
            }

            Console.ReadKey();
        }
    }
}
