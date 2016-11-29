using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_字符串方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串常用的方法练习:

            //练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
            //把字符串转化成字节数组ToCharArray()；把字符串当做字符数组，通过索引器获取指定位置上的字符
            string input = "abcdefg";
            char[] chs = input.ToCharArray();
            string temp = "";
            for (int i = 0; i < chs.Length; i++)
            {
                chs[i] = input[chs.Length - i - 1];
                temp += chs[i];
            }
            Console.WriteLine(temp);

            //练习二：从邮箱中提取出用户名和域名
            //Substring() 第二个参数表示截取的长度
            string email = "2586622608@qq.com";
            int index = email.IndexOf("@");
            string name = email.Substring(0, index);
            string yuMing = email.Substring(index + 1);
            Console.WriteLine(name + "..." + yuMing);

            //练习三:将英语单词反序输出
            //把字符串按某个字符分割成字符串数组，将字符串数组按照指定的分割方式拼接成字符串
            string english = "Hello c shape Helle world";
            string t = "";
            string[] content = english.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < content.Length / 2; i++)
            {
                t = content[i];
                //对应位置上的元素互换
                content[i] = content[content.Length - 1 - i];
                content[content.Length - 1 - i] = t;
            }
            //将字符串数组按照指定的分隔符进行连接
            string str = string.Join(" ", content);
            Console.WriteLine(str);

            //练习四:字符串的不可变性，旧的内存空间并没有被销毁，只是开辟了新的空间进行存储
            string strName = "陈如水";
            strName = "君应怜";
            Console.WriteLine(strName);

            //练习五:把字符串分割成字符数组,需要创建一个字符数组,字符串切割选项
            string strTime = "2016-08-19";
            string[] resultTime = strTime.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in resultTime)
            {
                Console.WriteLine(item);
            }

            //练习六:字符串的替换方法，判断是否包含子串
            string replaceStr = "金三胖就是金正恩";
            if (replaceStr.Contains("金三胖"))
            {
                replaceStr = replaceStr.Replace("金三胖", "***");
            }
            Console.WriteLine(replaceStr);

            //练习七:字符串的截取方法
            string substringStr = "待我君临天下，许你四海为家!";
            //如果只给一个参数，就要截取到最后；如果给定两个参数，那么第二个参数就是截取的长度
            substringStr = substringStr.Substring(1);
            Console.WriteLine(substringStr);

            //练习八:判断字符串是否是以开头和结尾,以及判断某个字符出现的位置
            string Str1 = "守望江湖!";
            bool isStartsWith = Str1.StartsWith("守");
            bool isEndsWith = Str1.EndsWith("湖");
            int index1 = Str1.IndexOf("江");
            Console.WriteLine(isStartsWith + "..." + isEndsWith + "..." + index1);

            //练习九:判断字符最后一次出现的位置以及字符串是否为空
            string path = @"C:\Users\Tuhuadmin\Desktop\20160106\陈如水.avi";
            int lastIndex = path.LastIndexOf("\\");
            bool nullOrEmpty = string.IsNullOrEmpty(path);
            Console.ReadKey();
        }
    }
}
