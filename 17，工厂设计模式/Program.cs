using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式:针对某个特定问题的解决方案
            //23种设计模式
            //什么是简单工厂设计模式(父类里面会装子类的对象)
            //生产电脑的工厂：各种类型的电脑，父类屏蔽了所有子类的差异。
            //简单工厂模式的核心是:根据用户的输入创建子类对象，赋值给父类(其中使用了抽象类来实现多态)
            Console.WriteLine("请输入您想要的笔记本电脑:");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.Provide();
            Console.ReadKey();
        }

        public static NoteBook GetNoteBook(string brand)
        {
            //根据用户输入的品牌去创建笔记本对象
            NoteBook noteBook = null;
            //对brand进行多条件的定值判断
            switch (brand)
            {
                case "鸿基": noteBook = new Acer(); break;
                case "联想": noteBook = new Lenovo(); break;
                case "戴尔": noteBook = new Dell(); break;
            }
            //父类里面装的是子类对象
            return noteBook;
        }
    }
}
