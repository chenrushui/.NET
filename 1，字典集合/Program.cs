using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_字典集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList集合：
            //元素的增删改查，遍历,集合长度：1)Add()、AddRange()，Remove()

            //创建集合
            ArrayList list = new ArrayList();
            //添加单个元素
            list.Add(1);
            list.Add(true);
            list.Add("陈如水");
            list.Add('男');
            list.Add(1.2);
            list.Add(1.2m);
            //添加多个元素
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            list.AddRange(list);
            //删除指定的元素
            list.Remove("陈如水");
            //清空集合
            //list.Clear();

            //获取集合中的每一个元素
            for (int i = 0; i < list.Count; i++)
            {
                //我们将一个对象输出到控制台，默认打印的是这个对象所在类的命名空间(项目名称)
                Console.WriteLine(list[i]);
            }

            //练习1：求一个集合中元素的最大值、最小值、平均值、求和
            //把每一个元素强转成int类型 因为Object类型是int类型的父类，所以可以强转
            ArrayList listCast = new ArrayList();
            listCast.AddRange(new int[] { 1, 3, 56, 78, 9, 0, 3, 4, 5, 7, 8, 9 });
            int sum = 0;
            int max = (int)listCast[0];
            int min = (int)listCast[0];
            for (int i = 0; i < listCast.Count; i++)
            {
                //求最大值
                if (max < (int)listCast[i])
                {
                    max = (int)listCast[i];
                }
                //求最小值
                if (min > (int)listCast[i])
                {
                    min = (int)listCast[i];
                }
                //求和
                sum += (int)listCast[i];
            }
            Console.WriteLine("这个集合的最大值是{0}，最小值是{1}，平均值是{2}，和是{3}", max, min, sum / listCast.Count, sum);

            //练习2：写一个长度为10的集合，要求里面的元素不重复
            ArrayList listCast2 = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                //首先产生一个随机数
                int number = r.Next(0, 10);
                if (listCast2.Contains(number))
                {
                    //要求集合里面的元素不重复
                    i--;
                }
                else
                {
                    listCast2.Add(number);
                }
            }
            for (int i = 0; i < listCast2.Count; i++)
            {
                Console.WriteLine(listCast2[i]);
            }
            Console.ReadKey();

        }
    }
}
