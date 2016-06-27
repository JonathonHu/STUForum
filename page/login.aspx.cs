using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_login : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = username.Text.ToString().Trim();
        string b = password.Text.ToString().Trim();
        string sel = who.SelectedItem.Value.ToString();
        SqlCommand cmd = new SqlCommand();
        switch (sel)
        {
            case "admin": cmd.CommandText = "select aID from admin where aUsername= @name and aPassword = @psw "; break;
            case "user": cmd.CommandText = "select uID from users where uUsername= @name and uPassword = @psw"; break;
        }
        cmd.Parameters.AddWithValue("@name", a);
        cmd.Parameters.AddWithValue("@psw", b);
        cmd.Connection = conn;
        conn.Open();
        int i = 0;
        i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i!=0)
        {
            Session["user"] = a;
            switch (sel)
            {
                case "admin": Response.Redirect("./admin/homepage.aspx"); break;
                case "user": Response.Redirect("./student/homepage.aspx"); break;
                
            }
            
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('登录失败，账号或密码错误');</script>");
            password.Text = "";
        }
    }

    protected void reset_Click(object sender, EventArgs e)
    {
        Response.Redirect("./signup.aspx");
    }
}