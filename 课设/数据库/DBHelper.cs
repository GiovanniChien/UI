using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDBTest {
    class DBHelper {

        //！！！！！！！
        /**
         * @database:数据库名
         * @user:用户名,一般root
         * @password:密码
         */
        private static String ConnStr = "server=127.0.0.1;port=3306;database=dotnettest;user=root;password=root;SslMode=none;";
        private MySqlConnection conn = null;
        
        public DBHelper()
        {
            conn = new MySqlConnection(ConnStr);
            conn.Open();
        }
        
        //无参查找
        public MySqlDataReader RunQuerySQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = null;
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dr;
        }

        //有参查找，详见demo.cs
        public MySqlDataReader RunQuerySQL(String sql,MySqlParameter[] prams)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = null;
            try
            {
                foreach (MySqlParameter pram in prams)
                {
                    cmd.Parameters.Add(pram);
                }
                dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dr;
        }

        //无参增删改
        public int RunNonQuerySQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int res = 0;
            try
            {
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return res;
        }

        //有参增删改
        public int RunNonQuerySQL(String sql,MySqlParameter[] prams)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int res = 0;
            try
            {
                foreach (MySqlParameter pram in prams)
                {
                    cmd.Parameters.Add(pram);
                }
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return res;
        }

        ~DBHelper()
        {
            conn.Close();
        }

    }
}
