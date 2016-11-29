using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //抽象类练习：
            //1)不用快捷键生成，自己重写子类中所有的实现，感觉手特别生。
            MobileDisk md = new MobileDisk();
            UDisk udisk = new UDisk();
            MP3 mp3 = new MP3();

            Computer cpu = new Computer();
            cpu.MS = udisk;//md;
            cpu.CPURead();
            cpu.CPUWrite();
            Console.ReadKey();
        }
    }
}
