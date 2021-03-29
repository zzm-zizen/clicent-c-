
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace socket编程_TCP协议_客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建Socket
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //2.发起建立连接请求
            IPAddress ipaddress = IPAddress.Parse("192.168.146.1");
            EndPoint point = new IPEndPoint(ipaddress, 8000);
            tcpClient.Connect(point);//通过IP和端口号，定位一个要连接到的服务器端

            //4.向服务器端发送消息
            byte [] id = new byte[11];
            id=Console.ReadLine()；
            tcpClient.Send(id);//把字符串转为字节数组 发送到服务器端

            Console.ReadKey();
        }
    }
}