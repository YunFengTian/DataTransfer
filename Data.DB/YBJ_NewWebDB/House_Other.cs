using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Data.DB
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("House_Other")]
    public partial class House_Other
    {
           public House_Other(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string HouseID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HouseNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string wgf {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? sf {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? yg {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string LandType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string HouseTax {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string PayType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Housedoc {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Memo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string RentPayType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Rentyj {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Rentzdzq {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Rentzczq {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Wttype {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? WtID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string MoveTo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string s1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string s2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string s3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string s4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string OwnerTel3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string OwnerTel4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string OwnerTel5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? orderTotal {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? orderKc {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? orderDk {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? orderClick {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string Ltime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? Lcount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? LcountPC {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? DkCount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isHot {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Wardrobe {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Chair {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? TV {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? icebox {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? washer {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Airconditioning {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Waterheater {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Microwave {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Broadband {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? Naturalgas {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public bool? IsFcPic {get;set;}

           /// <summary>
           /// Desc:
           /// Default:space((0))
           /// Nullable:True
           /// </summary>           
           public string CZType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? thRate {get;set;}

    }
}
