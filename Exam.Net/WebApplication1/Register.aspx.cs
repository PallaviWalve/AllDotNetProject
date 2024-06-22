using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Clark.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Success.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x = -1;
            SqlConnection conn = new SqlConnection("Data source=CDACLAB-78\\SQLEXPRESS;Database=Exam.Net;Integrated Security=True;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand("Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", TextBox2.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Usertype", (DropDownList1.Text));
            cmd.Parameters.AddWithValue("@status", -1);
            cmd.Parameters["@status"].Direction = ParameterDirection.Output;

            conn.Open();
            cmd.ExecuteNonQuery();
            x = (int)cmd.Parameters["@status"].Value;
            i = 1;
            conn.Close();
            if (i == 1)
            {
                Response.Write("<script> alert('login  successfully...!')</script>");
                Response.Redirect("Success.aspx");
            }
            else
            {
                Response.Write("<script> alert('Student login not successfully...!')</script>");
            }
        }
    }
    }
