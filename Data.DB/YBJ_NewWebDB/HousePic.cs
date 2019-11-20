using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Data.DB
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("HousePic")]
    public partial class HousePic
    {
           public HousePic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string HousePicID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HouseID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HouseNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? Postion {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? HavePic {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string PicName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string SKupdTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string URL {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? EmplID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EmplName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PicType {get;set;}

    }
}
