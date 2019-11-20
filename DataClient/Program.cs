using Data.Base.Core;
using Data.Tool;
using Data.Tool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClient
{
    class Program
    {
        static P2Pclient p2Pclient = new P2Pclient(DataType.json);
        static void Main(string[] args)
        {
            p2Pclient.Timeoutevent += P2Pclient_Timeoutevent;
            p2Pclient.Timeoutobjevent += P2Pclient_Timeoutobjevent;
            p2Pclient.ReceiveServerEvent += P2Pclient_ReceiveServerEvent;
            p2Pclient.ReceiveServerEventbit += P2Pclient_ReceiveServerEventbit;
            bool istrue = p2Pclient.Start(CommonTool.IP, CommonTool.Port, 10, false);
            if (istrue)
            {
                Console.WriteLine("连接成功,开始传输数据......");
            }
            else
            {
                Console.WriteLine("连接失败，请检查网络情况");
            }
        }

        private static void P2Pclient_ReceiveServerEventbit(byte command, byte[] data)
        {
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(data).ToString());
        }

        private static void P2Pclient_ReceiveServerEvent(byte command, string text)
        {
            Console.WriteLine(text);
        }

        private static void P2Pclient_Timeoutobjevent(P2Pclient p2pobj)
        {
            //断线重连
            p2Pclient.Restart(false);
        }

        private static void P2Pclient_Timeoutevent()
        {
            //断线重连
            p2Pclient.Restart(false);
        }
    }
}
