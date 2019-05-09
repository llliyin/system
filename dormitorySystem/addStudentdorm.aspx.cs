using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace dormitorySystem
{
    public partial class addDormitoryNem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=dormitory;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(str);

            myConnection.Open();
            int schoolNum = int.Parse(TextBox1.Text);
            int dormitoryNum = int.Parse(TextBox5.Text);

            string sqlstr = "insert into dormemberInfo values( " + schoolNum + " ,'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "'," + dormitoryNum + ")";

            SqlCommand com = new SqlCommand(sqlstr, myConnection);

            com.ExecuteNonQuery();
        }
    }
}