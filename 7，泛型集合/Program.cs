using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {

            //泛型集合:对存入集合中元素的类型进行限定(集合中存储的是对象)
            //装箱和拆箱

            //创建泛型集合
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(list);
            //1)泛型集合可以转化成数组
            int[] number = list.ToArray();
            //2)把数组转换成集合
            list = number.ToList<int>();

            //遍历集合
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //清空集合中的对象
            list.Clear();

            //装箱和拆箱，前提条件:两种数据类型是否存在继承关系
            //装箱：把值类型转化成引用类型
            //拆箱：把引用类型转化成值类型

            int a = 10;
            Object obj = a;
            int b = (int)obj;

            //泛型集合的练习
            //1)将一个数组中的奇数放到一个数组中，偶数放到一个数组中,最终把两个集合被合并成一个集合左边是奇数，右边是偶数.
            int[] num = { 2, 3, 4, 5, 6, 7, 8, 9, 9, 5, 3, 2, 2, 43, 45, 5, 6, 76, 7, 54, 4, 2, 2, 4, 4 };
            //首先建立两个集合，一个存储偶数，一个存储奇数
            List<int> jiShu = new List<int>();
            List<int> ouShu = new List<int>();
            foreach (var item in num)
            {
                if (item % 2 == 0)
                {
                    ouShu.Add(item);
                }
                else
                {
                    jiShu.Add(item);
                }
            }
            List<int> totalNumber = new List<int>();
            totalNumber.AddRange(jiShu);
            totalNumber.AddRange(ouShu);
            //遍历输出结果
            foreach (var item in totalNumber)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            //2)统计welcome to china中每个字符出现的次数
            string str = "welcome to china";
            //字符---出现次数，一定要使用键值对集合
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                //str[i]表示每个字符
                if (str[i] == ' ')
                {
                    //不统计空格
                    continue;
                }

                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }

            //遍历字典集合
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + "..." + item.Value);
            }
            Console.ReadKey();
        }
    }
}
