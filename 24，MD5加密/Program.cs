using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _24_MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //MD5加密:把字符串转化成MD5值就是MD5加密。

            //1)密码在存入数据库的时候，一定要进行加密，不能是明文密码.
            //2)学习.NET就是学习里面类以及类中的方法如何去用.
            //3)MD5类的使用.
            //4)乱码现象，肯定是编码出现了问题.
            //5)结果需要为16进制值.
            //6)C#中ToString方法的特殊用法,其实就是转换格式的问题.


            string res = GetMD5("123");
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            //学习.NET就是学习里面类以及类中的方法如何去用
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //将字符串转换成字节数组
            byte[] b = Encoding.UTF8.GetBytes(str);
            byte[] bmd5 = md5.ComputeHash(b);
            //将字节数组转化成字符串,理论上有三种方式
            //1)直接将字节数组ToString()
            //2)将字节数组中的每个元素按照指定的编码格式解析成字符串
            //3)将字节数组中的每一个元素ToString()

            //string result = Encoding.UTF8.GetString(bmd5);
            string result = "";
            for (int i = 0; i < bmd5.Length; i++)
            {
                //把十进制字符串转化成16进制.ToString("X"); 参数为X。
                result += bmd5[i].ToString("X");
            }
            return result;
        }
    }
}
