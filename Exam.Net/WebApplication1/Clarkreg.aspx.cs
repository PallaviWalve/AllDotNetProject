using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Clarkreg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data source=CDACLAB-78\\SQLEXPRESS;Database=Exam.Net;Integrated Security=True;User Id=sa;password=123456");
            SqlCommand cmd = new SqlCommand("Registerstudent", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@address", TextBox7.Text);
            cmd.Parameters.AddWithValue("@adhar", TextBox2.Text);
            cmd.Parameters.AddWithValue("@course", TextBox3.Text);
            cmd.Parameters.AddWithValue("@yoa", TextBox4.Text);
            cmd.Parameters.AddWithValue("@username", TextBox5.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox6.Text);
            cmd.Parameters.AddWithValue("status", -1);
            cmd.Parameters["status"].Direction = System.Data.ParameterDirection.Output;
            conn.Open();
            cmd.ExecuteNonQuery();
            int retVal = (int)(cmd.Parameters["status"].Value);

            if (retVal == 1)
            {
                Response.Write("<script> alert('Student registered successfully...!')</script>");
            }
            else
            {
                Response.Write("<script> alert('Username already taken...!')</script>");
            }
            conn.Close();
            Response.Redirect("Register.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}