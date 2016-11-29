using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _30_Socket编程
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread th = new Thread(Listener);
            th.IsBackground = true;
            th.Start();


        }
        public static void Listener() {
            //Socket编程:
            //当点击开始的时候，在服务器端创建一个负责监听IP地址和端口的Socket
            Socket socketWatch = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, 2222);
            //进行监听
            socketWatch.Bind(point);
        }
    }
}
