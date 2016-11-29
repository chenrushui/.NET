using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dictionary集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary：字典集合
            //集合的创建，添加元素，遍历
            //KeyValuePair类的使用，两个属性的使用
            //dic.ContainsKey(str[i]) 是否包含对应的键

            //创建字典集合，指定泛型类型
            Dictionary<int, string> dic = new Dictionary<int, string>();
            //向集合中添加元素
            dic.Add(1, "陈如水");
            dic.Add(2, "陈诗音");
            dic.Add(3, "陈诗悦");
            //通过键替换集合中对应的值
            dic[1] = "陈梦青";

            //方式一：遍历字典结合
            foreach (var item in dic.Keys)
            {
                //通过索引器的方式进行访问集合中的元素
                Console.WriteLine(dic[item]);
            }

            //方式二：遍历字典结合，使用KeyValuePair类，这个类是怎么用的？
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine(item.Key+"......"+ item.Value);
            }
            Console.ReadKey();










        }
    }
}
