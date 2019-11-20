using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data.Tool.Common
{
    public static class CommonTool
    {
        /// <summary>
        /// 服务端端口号
        /// </summary>
        public static int Port
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString());
            }
        }
        /// <summary>
        /// 服务端IP
        /// </summary>
        public static string IP
        {
            get
            {
                return ConfigurationManager.AppSettings["IP"].ToString();
            }
        }
        /// <summary>
        /// 白天时间
        /// </summary>
        public static int Day
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["Day"].ToString());
            }
        }
        /// <summary>
        /// 晚上时间
        /// </summary>
        public static int Night
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["Night"].ToString());
            }
        }
        /// <summary>
        /// 间隔几秒
        /// </summary>
        public static int Seconds
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["Seconds"].ToString());
            }
        }
    }
}
