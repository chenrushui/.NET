using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_集合复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //集合复习：增、删、改、查、遍历。
            //四个集合：ArrayList List<T> Hastable Dictionary<key,value>
            //单列集合:ArrayList非泛型集合---->List泛型集合
            //键值对集合：Hashtable---->Dictionary
            //最长用的是List<T>和Dictionary这两种集合，比较安全。
            //引用类型只有五种：数组 string 集合 自定义类 接口 object

            //一定要多记忆这些东西
            //dic.Values dic.Keys foreach KeyValuePair<int,string> JiShuTwo.ToArray()把集合转化成数组的方法

            //构造器 int.MinValue  int.MinValue

            List<int> list = new List<int>();
            //list.Add(1);
            //list.AddRange(1, 1);
            //list.Insert(1,1);
            //list.InsertRange(1, 1);
            //list.Remove();
            //list.RemoveAt();根据下标移除
            //list.RemoveRange();移除一定范围内的集合
            //list.Contains();是否包含

            //list.RemoveAll();委托

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "陈如水");
            dic.Add(2, "陈诗音");
            dic.Add(3, "陈诗悦");
            //修改键对应的值,会覆盖对应的值
            dic[3] = "张慧";
            //这集合的键属性和值属性：dic.Keys  
            foreach (var item in dic.Keys)
            {
                //遍历键的集合
                Console.WriteLine(item);
            }
            foreach (var item in dic.Values)
            {
                //遍历值的集合
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + "--------" + item.Value);
            }

            //练习1：用泛型集合实现奇偶数的分拣，基数在左边，偶数在右边 
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            List<int> JiShu = new List<int>();
            List<int> OuShu = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    OuShu.Add(nums[i]);
                }
                else
                {
                    JiShu.Add(nums[i]);
                }
            }
            //把偶数集合添加到奇数集合里面
            JiShu.AddRange(OuShu);
            foreach (var item in JiShu)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            //练习2：将数组中的奇数找出来，放到一个集合里面，最终把集合转化成数组
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> JiShuTwo = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    JiShuTwo.Add(numbers[i]);
                }
            }
            //如何把集合转化成数组？好像有直接转化的方法
            int[] newArray = JiShuTwo.ToArray();
            foreach (var item in newArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            //练习3：从一个整数的集合中取出最大值
            int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < numbers3.Length; i++)
            {
                if (numbers3[i] > max)
                {
                    max = numbers3[i];
                }
                if (numbers3[i] < min)
                {
                    min = numbers3[i];
                }
            }
            Console.WriteLine("最大值为{0}，最小值为{1}", max, min);

            //练习4：转化1一2二3三4四5五6六7七8八
            string str4 = "1一 2二 3三 4四 5五 6六 7七";
            Dictionary<char, char> dic4 = new Dictionary<char, char>();
            string[] strArray = str4.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strArray.Length; i++)
            {
                //strArray[i]表示数组中的每一项
                dic4.Add(strArray[i][0], strArray[i][1]);
            }
            Console.WriteLine("请输入阿拉伯数字:");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                //如果键里面包含用户输入的字符
                if (dic4.Keys.Contains(input[i]))
                {
                    Console.WriteLine(dic4[input[i]]);
                }
                else
                {
                    Console.WriteLine(input[i]);
                }
            }

            //练习4：把这两个集合中去除重复的元素合并到一起
            List<char> listOne = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' };
            List<char> listTwo = new List<char>() { 'v', 'n', 'm', 'd', 'r', 'f' };
            //遍历其中的一个集合，并把它添加到另外一个集合中
            for (int i = 0; i < listTwo.Count; i++)
            {
                if (!listOne.Contains(listTwo[i]))
                {
                    listOne.Add(listTwo[i]);
                }
            }
            foreach (var item in listOne)
            {
                Console.Write(item);
            }
           
            Console.ReadKey();
        }
    }
}
