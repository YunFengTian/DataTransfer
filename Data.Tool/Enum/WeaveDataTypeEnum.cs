using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Tool
{
    /// <summary>
    /// 有Web,Json,Bytes,Http,udpBytes,jsonudp这几种类型
    /// </summary>
    public enum WeavePortTypeEnum { Web, Json, Bytes, Http, udpBytes, jsonudp }
    public enum DataType { json, bytes, custom };

    /// <summary>
    /// 有Json, Bytes 两种类型
    /// </summary>
    public enum WeaveDataTypeEnum { Json, Bytes, custom };

    /// <summary>
    /// 有ten=10, hundred=100, thousand=1000, ten_thousand=10000 三种
    /// </summary>
    public enum WeavePipelineTypeEnum { ten = 10, hundred = 100, thousand = 1000, ten_thousand = 10000 };
    public enum WeaveReceivesSpeedMode { high = 0, middle = 1, low = 10 };
}
