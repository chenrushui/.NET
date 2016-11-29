using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_面向对象基础
{
    class Person
    {
        //定义私有字段,字段在默认情况下会有初始化值
        //私有修饰的只能在当前类的内部进行访问
        private string _name;
        private int _age;
        private char _gender;

        //创建空参数构造函数
        public Person()
        {

        }

        //创建有参数构造函数
        public Person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }

            //为字段设置值的时候，进行逻辑判断
            set
            {
                if (value > 120 || value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                else
                {
                    return _gender;
                }
            }
            set { _gender = value; }
        }

        //定义静态方法
        public static void CHLLS()
        {

            Console.WriteLine("守望江湖！");
        }

        //定义非静态方法(两种方法的调用方式不一样)   
        public void PlayGames()
        {
            Console.WriteLine("我们的未来是星辰大海");
            //this指代当前类的对象
            Console.WriteLine("你多大{0}，{1}", this.Age, this.Name);
        }

        public override string ToString()
        {
            //打印数据的值
            return this.Age + "..." + this.Name + "..." + this.Gender;
        }







    }
}
