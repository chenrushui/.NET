using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_多态之虚方法
{
    class Person
    {
        private string _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public  virtual void SayHello()
        {
            Console.WriteLine("我是人类!");
        }
    }
}
