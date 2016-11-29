using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            //Test5();
            //Test6();
            //Test7();
            //Test8();
            //Test9();
            //Test10();
            //Test11();
            //Test12();
            //Test13();
            //Test14();
            //Test15();
            //Test16();
            //Test17();
            Test18();

        }

        private static void Test18()
        {
            //面向对象练习题
        }

        private static void Test17()
        {
            //字符串翻转输出(练习字符串的常见操作)
            string[] str = { "a", "b", "c", "d", "e", "f", "g" };
            for (int i = 0; i < str.Length/2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length-i - 1];
                str[str.Length -i- 1] = temp;
            }
            foreach (var item in str)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }

        private static void Test16()
        {
            //用于存储用户输入的用户名
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("请输入用户的名称,输入q退出");
                string input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                else
                {
                    list.Add(input);
                }
            }
            Console.WriteLine("你输入的用户名以此是:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }

        private static void Test15()
        {
            //字符串练习:去掉两端空格
            string str = " faaf ka k k   ka  ";
            str = str.Trim();
            string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Join(" ", array);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static void Test14()
        {
            string str = "asdfeghjklbreszxsfeeaeasdses";
            int index = str.IndexOf("e");
            int i = 1;
            Console.WriteLine("第一次出现E的位置是{0}", index);
            while (index != -1)
            {
                i++;
                index = str.IndexOf("e", index + 1);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine("第{0}次出现E的位置是{1}", i, index);
            }
            Console.ReadKey();
        }

        private static void Test13()
        {
            int[] number = new int[30];
            Random r = new Random();
            //通过循环给数组赋值
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = r.Next(0, 101);
            }
            //求数组的平均值
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            //保留两位有效数子
            double avg = sum / number.Length;
            avg = Convert.ToDouble(avg.ToString("0.00"));
            Console.WriteLine("平均数为{0}", avg);
            Console.ReadKey();

        }

        private static void Test12()
        {
            //对数组进行升序排列
            //Array.Sort(传递一个数组进来);
            //对数组进行降序拍列
            //Array.Reverse();

            //使用冒泡排序法(前后进行比较)，进行升序排列数组
            int[] num = { 10, 2, 3, 4, 5, 6, 7, 8, 9, 33, 221, 11 };
            //（为什么要减一，用于和后面的交换）
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = 0; j < num.Length - 1 - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadKey();
        }

        private static void Test11()
        {
            int[] number = { 1, 3, 4, 56, 6, 7, 8, 8, 990, 0, 76, 5, 4, 3, 3, 2 };
            double d = GetAvg(number);
            //这种做法会四舍五入
            //Console.WriteLine("{0:0.00}", d);
            //通过字符转进行转化,不用四舍五入
            d = Convert.ToDouble(d.ToString("0:00"));
            Console.WriteLine(d);
            Console.ReadKey();
        }

        private static double GetAvg(int[] number)
        {
            double d = 0;
            for (int i = 0; i < number.Length; i++)
            {
                d += number[i];
            }
            //现在不确定它有几位小数
            return d / number.Length;
        }

        private static void Test10()
        {
            //请输出最长的字符串,其实是比较字符串的长度
            string[] name = { "111", "ewww", "ewewqefw", "fdfdfgd" };
            string str = GtLonggest(name);
            Console.WriteLine("长度最长的字符串为{0}", str);
            Console.ReadKey();
        }

        private static string GtLonggest(string[] name)
        {
            string max = name[0];
            for (int i = 0; i < name.Length; i++)
            {
                if (max.Length < name[i].Length)
                {
                    max = name[i];
                }

            }
            return max;
        }

        private static void Test9()
        {
            //求所有基数的和
            int sum = 0;
            for (int i = 0; i < 101; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        private static void Test8()
        {
            Console.WriteLine("请输入一个数:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个数:");
            int second = int.Parse(Console.ReadLine());
            int max = GetMax(first, second);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        private static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
            //使用三元运算符实现
            //return first > second ? first : second;

            //如何获取数组中的最大值
            //把数组中的第一个元素设置为最大值，然后进行比较

            //可变参数必须是形参中最后一个参数。
        }

        private static void Test7()
        {
            //字符串练习题,可以直接输出字符串的长度。
            Console.WriteLine("请输入一个字符串：");
            string input = Console.ReadLine();
            //Console.WriteLine(input.Length);
            Char[] chs = input.ToArray();
            Console.WriteLine(chs.Length);
            Console.ReadKey();
        }

        private static void Test6()
        {
            //交换变量的值，不使用中间变量
            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine(n1 + "--------------" + n2);
            Console.ReadKey();
        }

        private static void Test5()
        {
            //字符串练习题
            Console.WriteLine("请输入一个字符串");
            string intput = Console.ReadLine();
            string sub = intput.Substring(0, 1);
            string low = sub.ToLower();
            Console.WriteLine(low + intput.Substring(1));
            Console.ReadKey();
        }

        private static void Test4()
        {
            //随机数和数组的练习
            int[] array = new int[50];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
            }
            Console.WriteLine("请输入一个数字:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 50; i++)
            {
                Console.Write(array[i] + "\t");
                if ((i + 1) % number == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        private static void Test3()
        {
            //输出久久乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void Test2()
        {
            //使用switch进行定制判断，核心是如何把区间转化成定值
            Console.WriteLine("请输入你的考试成绩:");
            int score = Convert.ToInt32(Console.ReadLine());
            string level = null;
            switch (score / 10)
            {
                case 9: level = "优"; break;
                case 8: level = "良"; break;
                case 7: level = "中"; break;
                case 6: level = "差"; break;
                default: level = "不及格"; break;
            }

            Console.WriteLine("你的成绩等级为{0}", level);
            Console.ReadKey();
        }

        private static void Test1()
        {
            //使用if-else结构进行区间判断
            Console.WriteLine("请输入您的考试成绩:");
            string input = Console.ReadLine();
            int score = int.Parse(input);
            string lever = null;
            if (score >= 90)
            {
                lever = "优";
            }
            else if (score >= 80)
            {
                lever = "良好";
            }
            else if (score >= 70)
            {
                lever = "良";
            }
            else if (score >= 60)
            {
                lever = "差";
            }
            else
            {
                lever = "不及格";
            }
            Console.WriteLine("你的成绩等级为{0}", lever);
            Console.ReadKey();
        }
    }
}
