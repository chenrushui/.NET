using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_工厂设计模式
{
    class Lenovo : NoteBook
    {
        public override void Provide()
        {
            Console.WriteLine("生产联想笔记本!");
        }
    }
}
