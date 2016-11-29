using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_工厂设计模式
{
    class Dell : NoteBook
    {
        public override void Provide()
        {
            Console.WriteLine("生产戴尔笔记本");
        }
    }
}
