using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _44_XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML文档:可扩展标记语言，用于存储数据，将要显示或者存储的数据标记起来.
            //项目中右键单击--->添加新建项--->xml文档.
            //通过代码的形式对xml文档进行读取、写入、追加、修改文档,这是最常用的操作.
            //引用命名空间：using System.Xml.
            //区分元素和结点:(元素)标签和标签中的内容都是元素,每一个标签都是一个结点.
            //XML文档必须要有根节点,否则就会报错.
            //创建子节点，将子节点添加到根节点下面.
            //按照结点去操作xml文件,一定要注意当前结点应该添加到哪个子节点上。
            //InnerText可以设置标签里面要显示的文本.
            //如果标签里面出现了属性，该如何去写?
            //常用的类和属性:XmlDocument、XmlDeclaration、XmlElement、CreateElement()、AppendChild()、InnerText、Save()方法

            //显示所有文件按钮：bin----->debug----->Books.xml

            //案例:如何通过代码创建xml文件？
            //1)创建xml文档对象
            XmlDocument doc = new XmlDocument();
            //2)创建第一行描述信息，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //3)将第一行添加到doc文档中
            doc.AppendChild(dec);
            //4)创建根节点,XML文档必须要有根节点,否则就会报错
            XmlElement books = doc.CreateElement("Books");
            //5)将根节点添加到文档中
            doc.AppendChild(books);
            //6)给根节点books添加子节点
            XmlElement book1 = doc.CreateElement("book");
            //为某一个结点设置属性标签，以键值对的形式存在
            book1.SetAttribute("name","金瓶梅");
            books.AppendChild(book1);
            //7)给book1添加三个子节点
            //XmlElement name1 = doc.CreateElement("Name");
           // name1.InnerText = "金瓶梅";
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "真的很好看!";
            //book1.AppendChild(name1);
            book1.AppendChild(price1);
            book1.AppendChild(des1);
            //8)第二本书的结点
            XmlElement book2 = doc.CreateElement("book");
            books.AppendChild(book2);
            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "西游记";
            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "20";
            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "神话故事";
            book2.AppendChild(name2);
            book2.AppendChild(price2);
            book2.AppendChild(des2);
            //保存文档(在保存文档之前，必须创建根节点)
            doc.Save("Books.xml");
            Console.WriteLine("保存成功!");
            Console.ReadKey();
        }
    }
}
