using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_多态之虚方法
{
    class Chinese : Person
    {

        public Chinese(string name) : base(name)
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }
}
