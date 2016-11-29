using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_抽象类练习
{
    //u盘类
    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("使用u盘进行读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("使用U盘进行写入数据");
        }

    }
}
