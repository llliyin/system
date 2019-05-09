using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace dormitorySystem
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=.;Initial Catalog=dormitory;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(str);

            myConnection.Open();

            string select = "select * from dormemberInfo";
            SqlCommand myCommand = new SqlCommand(select, myConnection);
            SqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            Response.Write("<table border=1 cellspacing=0 cellpadding=2>");
            Response.Write("<tr bgcolor=yellow>");
            for (int i = 0; i < myReader.FieldCount; i++)
            {
                Response.Write("<td>" + myReader.GetName(i) + "</td>");
            }
            Response.Write("</tr>");
            while (myReader.Read())
            {
                Response.Write("<tr>");
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    Response.Write("<td>" + myReader[i].ToString() + "</td>");
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");
            myConnection.Close();
        }
    } 
}