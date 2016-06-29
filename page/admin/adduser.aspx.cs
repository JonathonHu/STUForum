using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_adduser : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand ins = new SqlCommand("insert into users(uUsername,uPassword,uSex,uBirthday,stuNum,name,university) values(@username,@password,@usex,@birthday,@stunum,@name,@university)", conn);
        ins.Parameters.AddWithValue("@username",username.Text);
        ins.Parameters.AddWithValue("@password", password.Text);
        ins.Parameters.AddWithValue("@usex", sex.Text);
        ins.Parameters.AddWithValue("@birthday", birthday.Text);
        ins.Parameters.AddWithValue("@stunum", stuNum.Text);
        ins.Parameters.AddWithValue("@name", name.Text);
        ins.Parameters.AddWithValue("@university", university.Text);

        SqlCommand sel = new SqlCommand("select count(*) from users where uUsername=@username or stuNum=@stunum", conn);
        sel.Parameters.AddWithValue("@username", username.Text);
        sel.Parameters.AddWithValue("@stunum", stuNum.Text);

        if (Convert.ToInt32(sel.ExecuteScalar().ToString()) == 0)
        {
            if (ins.ExecuteNonQuery() != 0)
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加成功');window.location.href='./user.aspx'; </script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('添加失败');</script>");
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('学号或用户名已存在'); </script>");
        }
        
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
        sex.Text = "";
        birthday.Text = "";
        stuNum.Text = "";
        name.Text = "";
        university.Text = "";
    }
}