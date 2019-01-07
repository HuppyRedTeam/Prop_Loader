using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Prop_Loader
{
    class Remote_Control
    {
        public Thread t;
        public Socket socket;

        public Remote_Control()
        {
            t = new Thread(new ThreadStart(Connect_Thread));
            t.Start();
        }

        public void Connect_Thread()
        {
            int port = 8099;
            IPAddress ip = IPAddress.Any;
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(ip, port);
            server.Bind(ipe);
            server.Listen(1);
            socket = server.Accept();
            socket.Send(Encoding.ASCII.GetBytes("[远程端]: 连接成功"));
        }

        public void SendC(string Commands)
        {
            socket.Send(Encoding.ASCII.GetBytes("[远程端]: " + Commands));
        }


        public Socket GetSocket()
        {
            return socket;
        }
    }
}
