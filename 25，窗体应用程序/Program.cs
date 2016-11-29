using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_窗体应用程序
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //窗体应用程序是一种智能的客户端技术。学习Winform就是学习控件的使用。后台逻辑代码依然是C#。
            //Windows应用程序由哪些文件组成?
            //main函数是应用程序的入口.Application指当前应用程序。
            //展开"Form1.cs",designer是指设计器。resx是指窗体应用程序的资源文件。
            //其实每一个控件都是一个类，学习这个类的用法。初始化窗体与初始化控件。
            //dispose():清理所有正在使用的资源
            //选中控件----->右键单击属性，快捷键是是F4。
            //控件的属性和事件(注册事件，触发事件，在属性面板里面进行事件的注册；事件本质上就是一个方法，发生事件其实就是调用一个方法)。
            //Name与Text是有区别的(代表控件本身，表示控件上显示的文字)。
            //如何给控件设置右键菜单？让快捷菜单和控件进行绑定。
            //知道常用控件的常用属性即可。
            //MessageBox.Show("Hello World!");
            //在当前项目中添加新的窗体。
            //在main函数中创建的窗体对象我们称之为主窗体，当主窗体关闭后，整个应用程序就关闭了。
            //Random()类的使用，MD5类的使用
            //对单选控件进行分组才能选中一个。


            //Save();

            //ImageLunBo();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void ImageLunBo()
        {
            
        }

        private static void Save()
        {
            //记事本应用程序的保存功能:通过文件流把内容写入到指定的位置。
            using (FileStream fStream = new FileStream(@"C:\Users\Tuhuadmin\Desktop\a.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string content = "";//trim() 去掉字符串两端的空格
                //向一个文件中写入字节数组.打开即可以看到
                byte[] buffer = Encoding.Default.GetBytes(content);
                fStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
