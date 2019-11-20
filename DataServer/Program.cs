using Data.Base.Implement;
using Data.DB;
using Data.Models;
using Data.Tool;
using Data.Tool.Common;
using Data.Tool.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaveP2Server p2Server = new WeaveP2Server(WeaveDataTypeEnum.Json);
            p2Server.weaveUpdateSocketListEvent += P2Server_weaveUpdateSocketListEvent;
            p2Server.weaveDeleteSocketListEvent += P2Server_weaveDeleteSocketListEvent;
            p2Server.waveReceiveEvent += P2Server_waveReceiveEvent;
            p2Server.weaveReceiveBitEvent += P2Server_weaveReceiveBitEvent;
            string msg = "";
            p2Server.Start(CommonTool.Port,out msg);
            Console.WriteLine(msg);
            Console.ReadLine();
        }

        private static void P2Server_weaveReceiveBitEvent(byte command, byte[] data, System.Net.Sockets.Socket soc)
        {
            //接收客户端发来的消息
        }

        private static void P2Server_waveReceiveEvent(byte command, string data, System.Net.Sockets.Socket soc)
        {
            //接收客户端发来的消息
        }

        private static void P2Server_weaveDeleteSocketListEvent(System.Net.Sockets.Socket soc)
        {
            string Info = "【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "】" + soc.RemoteEndPoint + " " + "退出成功";
            Console.WriteLine(Info);
        }

        private static void P2Server_weaveUpdateSocketListEvent(System.Net.Sockets.Socket soc)
        {
            string Info = "【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "】" + soc.RemoteEndPoint + " " + "登录成功";
            Console.WriteLine(Info);
        }
    }
}
