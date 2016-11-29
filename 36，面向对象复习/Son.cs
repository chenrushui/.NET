using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_面向对象复习
{
    class Son : Father
    {
        public Son(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {
        }

        public void PlayGames()
        {
            Console.WriteLine("儿子喜欢玩游戏！");
        }
    }
}
