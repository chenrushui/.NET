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
            //切割字符串 Split()
            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("是的！");
            }
            else
            {
                Console.WriteLine("不是！");
            }
            string s1 = "C#";
            string s2 = "c#";
            //忽略大小写进行比较  StringComparison枚举类
            if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase))
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
