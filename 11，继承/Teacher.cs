using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_继承
{
    /// <summary>
    /// Teacher继承自Person类，继承标识是:
    /// </summary>
    class Teacher : Person
    {
        private double _salary;

        public Teacher()
        {

        }
        public Teacher(string name,int age,char gender,double salary):base(name,age,gender)
        {
            //父类里面没有这行赋值代码，所以需要在子类的构造函数中写
            this.Salary = salary;
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public void Teach()
        {
            Console.WriteLine("老师会教书!");
        }



    }
}
