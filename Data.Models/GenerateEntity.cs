using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Data.Models
{
    public class GenerateEntity
    {
        static void Main(string[] args)
        {
            new GenerateEntity().GenerateModel();
            Console.ReadLine();
        }
        static SqlSugar.SqlSugarClient GetDB(string dbname)
        {
            string connStr = ConfigurationManager.AppSettings[dbname].ToString();
            return new SqlSugar.SqlSugarClient(new SqlSugar.ConnectionConfig()
            {
                DbType = SqlSugar.DbType.SqlServer,
                ConnectionString = connStr,
                IsAutoCloseConnection = true,
                InitKeyType = SqlSugar.InitKeyType.Attribute
            });
        }
        public void GenerateModel()
        {
            var Db =  GetDB("YBJDB");
            string url = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug\","");
            string[] tableArr = new string[] { "Area", "Bank" };
            Db.DbFirst.Where(tableArr).CreateClassFile(url, "Data.Models"); 
        }
    }
}
