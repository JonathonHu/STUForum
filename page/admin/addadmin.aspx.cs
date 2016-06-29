using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_addadmin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        SqlCommand sel = new SqlCommand("select count(*) from admin where aUsername = @username", conn);
        sel.Parameters.AddWithValue("@username", username.Text);

        SqlCommand add = new SqlCommand("insert into admin(aUsername,aPassword) values(@username,@password)", conn);
        add.Parameters.AddWithValue("@username", username.Text);
        add.Parameters.AddWithValue("@password", password.Text);
        conn.Open();
        if (Convert.ToInt32(sel.ExecuteScalar().ToString()) == 0)
        {

            if (Convert.ToInt32(add.ExecuteNonQuery().ToString()) != 0)
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('注册成功');window.location.href='./admin.aspx'; </script>");
            }
            else
            { ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('注册失败');window.location.href='./admin.aspx'; </script>"); conn.Close(); }
        }
        else
        {
            conn.Close();
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('已存在该用户');window.location.href='./admin.aspx'; </script>");
        }

    }
    protected void reset_Click(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
    }
}