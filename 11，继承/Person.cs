using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_继承
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }
        public char Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }

        public Person()
        {

        }

        public Person(string name, int age, char gender)
        {
            //创建子类时,父类里面已经写过赋值代码，子类就不用再写了！
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void Life() {
            Console.WriteLine("热爱生活，有所期待!");
        }
        public void Talk() {
            Console.WriteLine("人类会说话");
        }
    }
}
