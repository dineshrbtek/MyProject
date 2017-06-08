using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CreatWebForm
{
    public partial class WelcomeForm : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Registration where UserName=@UserName and Password=@Password", con);
            cmd.Parameters.AddWithValue("@UserName", txtusername.Text);
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
            sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            int i = cmd.ExecuteNonQuery();
            if(dt.Rows.Count>0)
            {
                lblstatus.Text = "<b style='color:green;'>Login Successfully!!</b>";
                Response.Redirect("MainForm.aspx");
            }
            else
            {
                lblstatus.Text = "<b style='color:red;'>Login Faild</b>";
                con.Close();
            }
        }
    }
}