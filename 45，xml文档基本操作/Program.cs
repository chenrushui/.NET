using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace _45_xml文档基本操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //用这种形式存储数据，用的不多，所以先忽略，学习其他的吧，记住几个常用的类就好了。
            //XmlDocument  XmlElement  XmlDeclaration  CreateElement()

            //追加xml文档
            XmlDocument doc = new XmlDocument();
            //如果文档存在
            if (File.Exists("Books.xml"))
            {
                //1)先加载xml文档到内存里面
                doc.Load("Books.xml");
                //2)获取文档的根节点
                XmlElement books = doc.DocumentElement;
            }
            else
            {
                //如果文档不存在
                //创建第一行，并添加文档中
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建根节点，并添加到文档中
                XmlElement Books = doc.CreateElement("Books");
                doc.AppendChild(Books);
            }
        }
    }
}
