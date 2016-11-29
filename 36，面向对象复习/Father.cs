using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_面向对象复习
{
    class Father
    {
        private string _lastName;
        private decimal _property;
        private string _bloodType;

        public Father(string lastName, decimal property, string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }

        //凡是和外界有联系的，全部都是用属性
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public decimal Property
        {
            get { return _property; }
            set { _property = value; }
        }
        public string BloodType
        {
            get { return _bloodType; }
            set { _bloodType = value; }
        }

        public override string ToString()
        {
            return this.LastName + this.Property + this.BloodType;
        }

        public void Information()
        {
            Console.WriteLine("我叫{0},我的工资是{1},我的血型是{2}", this.LastName, this.Property, this.BloodType);
        }
    }
}
