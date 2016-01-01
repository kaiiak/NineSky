using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NineSky_desktop
{
    class netConnection
    {
        private static byte[] result = new byte[1024];
        Socket clientSocket;
        public netConnection()
        {
            //服务器IP地址
            IPAddress ip = IPAddress.Parse(config.Default.netAdress);
            //服务器端口号
            int myPort = Int32.Parse(config.Default.controlPort);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(ip, myPort)); //配置服务器IP与端口
        }

        public void sendMessage(string m)
        {
            try
            {
                clientSocket.Send(Encoding.ASCII.GetBytes(m));
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        public string receiveMessage()
        {
            int receiveLength = clientSocket.Receive(result);
            return Encoding.ASCII.GetString(result,0,receiveLength);
        }
    }
}
