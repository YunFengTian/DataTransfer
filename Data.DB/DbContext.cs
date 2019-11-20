using Data.Tool.Common;
using Data.Tool.Enum;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.DB
{
    public class DbContext<T> where T:class,new()
    {
        public SqlSugarClient Db;
        public SimpleClient<T> CurrentDb { get { return new SimpleClient<T>(Db); } }
        public SimpleClient<APP_Reguser> APP_ReguserDb { get { return new SimpleClient<APP_Reguser>(Db); } }
        public DbContext(string dbname = "")
        {
            if (string.IsNullOrEmpty(dbname))
                dbname = DataBase.YBJDB.ToString();
            string connStr = ConfigurationManager.ConnectionStrings[dbname].ConnectionString;
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connStr,
                DbType = DbType.SqlServer,//指定数据库类型
                InitKeyType = InitKeyType.SystemTable,//从数据库获取主键
                IsAutoCloseConnection = true,//自动释放连接
            });
            //打印SQL语句
            Db.Aop.OnLogExecuted = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + Db.Utilities.SerializeObject(pars.ToDictionary(im => im.ParameterName, im => im.Value)));
                Console.WriteLine();
            };
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        public virtual List<T> List()
        {
            return CurrentDb.GetList();
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        public virtual List<T> List(Expression<Func<T,bool>> expression)
        {
            return CurrentDb.GetList(expression);
        }
        /// <summary>
        /// 删除
        /// </summary>
        public virtual bool Del(dynamic id)
        {
            return CurrentDb.Delete(id);
        }
        /// <summary>
        /// 修改
        /// </summary>
        public virtual bool Upd(T obj)
        {
            return CurrentDb.Update(obj);
        }
        /// <summary>
        /// 新增
        /// </summary>
        public virtual bool Add(T obj)
        {
            return CurrentDb.Insert(obj);
        }
        /// <summary>
        /// 批量新增
        /// </summary>
        public virtual bool Add(List<T> obj)
        {
            return CurrentDb.InsertRange(obj);
        }
        /// <summary>
        /// 根据主键获取单个
        /// </summary>
        public virtual T Single(dynamic id)
        {
            return CurrentDb.GetById(id);
        }
        /// <summary>
        /// 根据条件获取单个
        /// </summary>
        public virtual T Single(Expression<Func<T,bool>> exp)
        {
            return CurrentDb.GetSingle(exp);
        }
    }
}
