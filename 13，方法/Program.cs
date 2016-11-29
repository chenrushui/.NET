using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法: 定义、参数、返回值

            //变量作用域:只能在方法内部使用，不能跨越方法.
            int a = 3;
            test(a);
            //值仍然没变，3
            Console.WriteLine("a的值为{0}", a);

            //练习一：方法的返回值，请输入您的年龄，你刚刚的年龄是?
            Console.WriteLine("请输入您的年龄:");
            int age = GetAge();
            Console.WriteLine("您刚刚输入的年龄是{0}", age);

            //练习二：让用户输入一个数字，判断是不是闰年?
            Console.WriteLine("请输入一个年份:");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b = IsYear(year);
            if (b)
            {
                Console.WriteLine("您输入的年份是闰年");
            }
            else
            {
                Console.WriteLine("您输入的年份不是闰年");
            }

            //练习三：让用户输入两个数，计算他们的平均值?
            Add();

            //练习四：求两个数的最大值
            int max = Max(22, 23);
            Console.WriteLine("两个数中的最大的是{0}", max);

            //练习五：out关键字的使用,用于向外传出值
            int number;
            int result = TestOut(out number);
            Console.WriteLine("number={0},result={1}", number, result);

            //练习六：判断一个数是否是为质数?
            IsZhiShu();

            //练习七：把数组中的每一个元素连接起来，之间用|分割
            string[] content = { "陈如水", "陈诗音", "陈诗乐", "陈随心" };
            string output = ConStr(content);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        private static string ConStr(string[] content)
        {
            return string.Join("|",content);
        }
        private static string ConString(string[] content)
        {
            //使用for循环实现
            string result="";
            for (int i = 0; i < content.Length; i++)
            {
                if (i== content.Length-1)
                {
                    result += content[i];
                }
                else
                {
                    result += content[i]+"|";
                }
            }
            return result;    
        }

        private static void IsZhiShu()
        {
            //判断一个数是否是质数?
            string input = "";
            int number = 0;
            bool result;
            do
            {
                Console.WriteLine("请输入一个正整数：");
                input = Console.ReadLine();
                if (input == "q")
                {
                    Console.WriteLine("应用程序结束");
                    //跳出循环
                    break;
                }
                try
                {
                    number = int.Parse(input);
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine("{0}不是质数", number);
                        }
                        else
                        {
                            Console.WriteLine("{0}是质数",, number);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("对不起，您的输入有误，请重新输入");
                    continue;
                }
            } while (true);
        }

        private static int TestOut(out int number)
        {
            number = 20;
            return number - 1;
        }

        private static int Max(int v1, int v2)
        {
            if (v1 > v2)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }

        private static void Add()
        {
            Console.WriteLine(" 请输入数字a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" 请输入数字b");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("这两个数的平均值为{0}", sum / 2);
        }

        private static bool IsYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetAge()
        {
            int age = 0;
            do
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    return age;
                }
                catch (Exception)
                {

                    Console.WriteLine("对不起，您的输入有误!");
                }
            } while (true);


        }

        private static void test(int a)
        {
            a = a + 1;
        }
    }
}
