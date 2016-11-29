
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_序列化与反序列化
{
    [Serializable]
    internal class Person
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
            get { return _age; }
            set { _age = value; }

        }

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }

        }


    }
}
