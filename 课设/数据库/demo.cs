using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetDBTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //含参数sql示例代码
        private void Button1_Click(object sender, EventArgs e) {
            DBHelper helper = new DBHelper();
            String sql = "INSERT INTO user(id,name,pwd) VALUE(@id,@name,@pwd);";
            MySqlParameter[] prams = { new MySqlParameter("@id", 4) ,
                                               new MySqlParameter("@name","王五2"),
                                               new MySqlParameter("@pwd","abcd")};
            int res = helper.RunNonQuerySQL(sql, prams);
            Console.WriteLine(res);
        }

        //无参数sql示例代码
        private void testNonParam(){
            DBHelper helper=new DBHelper();
            String sql="SELECT * FROM user";
            MySqlDataReader dr=helper.RunQuerySQL(sql);
            while(dr.Read()){
                Console.WriteLine(dr.GetInt32("id")+dr.GetString("name")+dr.GetString("pwd"));
            }
        }

        
    }
}
