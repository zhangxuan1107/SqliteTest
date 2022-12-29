using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZxSqlite
{
    /// <summary>
    /// https://www.cnblogs.com/luxiaoxun/p/3784729.html
    /// </summary>
    public class SQLiteDal
    {
        //数据库连接
        private static SQLiteConnection sDbConnection = new SQLiteConnection("Data Source=eol.db;Version=3;");

        #region 初始化

        public static bool Init()
        {
            try
            {
                sDbConnection.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        #endregion

        #region 查询

        public static List<T> Query<T>()
        {
            var list = new List<T>();


            return list;
        }

        #endregion

        #region 新增

        public static bool Add<T>(T t)
        {
            string sql = "insert into student (Sname, Age) values ('Me', 3000)";
            using (SQLiteCommand command = new SQLiteCommand(sql, sDbConnection))
            {
                command.ExecuteNonQuery();
            };
            return true;
        }


        #endregion

        #region 修改

        public static bool Edit()
        {
            return true;
        }

        #endregion
    }
}
