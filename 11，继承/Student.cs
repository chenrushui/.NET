using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_继承
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student : Person
    {
        private int _id;

        public Student()
        {

        }
        //父类如果提供了有参数构造的函数，子类也必须提供
        public Student(string name,int age,char gender,int id) :base(name,age,gender)
        {
            this.Id = id;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void PalyGames() {
            Console.WriteLine("学生喜欢玩游戏!");
        }

        //如果子类和父类中有同名的方法，使用new关键字可以隐藏父类中的方法
        public new void Talk() {
            Console.WriteLine("学生爱说话！");
        }

        public override string ToString()
        {
            return this.Name+this.Age+this.Gender+this.Id;
        }

    }
}
