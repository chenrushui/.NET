using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_抽象类练习
{
    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("使用mp3读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("使用mp3写入数据");
        }

        public void PlayMusic() {
            Console.WriteLine("mp3可以播放音乐");
        }

    }
}
