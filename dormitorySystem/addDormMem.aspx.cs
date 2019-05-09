using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace dormitorySystem
{
    public partial class addDormMem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=dormitory;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(str);

            myConnection.Open();
            int dormNum = int.Parse(TextBox1.Text);


            string sqlstr = "insert into dormitoryNumbe values( " + dormNum + " ," + DropDownList1.SelectedValue + ",'" + TextBox2.Text + "','" + TextBox3.Text + "')";

            SqlCommand com = new SqlCommand(sqlstr, myConnection);
           
            com.ExecuteNonQuery();

            Label1.Text = "添加成功";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}