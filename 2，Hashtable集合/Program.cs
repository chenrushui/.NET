using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Hashtable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable集合的使用
            //特点:键值对集合，Keys属性，Values属性
            Hashtable map = new Hashtable();
            map.Add(1, "陈如水");
            map.Add(2, "陈诗音");
            map.Add(true, false);

            //在键值对集合中是根据键寻找值的
            for (int i = 0; i < map.Count; i++)
            {
                //第三个键值对输出不了，因为索引不是整数
                Console.WriteLine(map[i]);
            }

            //通过foreach循环进行遍历
            foreach (var item in map.Keys)
            {
                //item表示每一个键
                //var表示变量类型
                //item表示集合里面的每一项，表示一个键
                //collection表示待遍历的集合
                //ht.Keys 表示遍历集合中的键
                //ht.Values表示遍历集合中的值
                Console.WriteLine(map[item]);
            }

            //获取变量的类型
            int a = 10;
            Type t = a.GetType();
            //输出结果为int
            Console.WriteLine(t);

            //推断类型
            var b = 10;
            Type type = b.GetType();
            Console.WriteLine(type);
            Console.ReadKey();
        }

    }
}
