using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_signup : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = username.Text.ToString().Trim();
        string b = password.Text.ToString().Trim();
        int sex = Convert.ToInt16(who.SelectedItem.Value.ToString());
        string birth = birthday.Text;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText =  "select uID from users where uUsername= @name";
        cmd.Parameters.AddWithValue("@name", a);
        cmd.Parameters.AddWithValue("@psw", b);
        
        cmd.Connection = conn;
        conn.Open();
        int i = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        if (i == 0)
        {
            SqlCommand ins = new SqlCommand();
            ins.CommandType = CommandType.Text;
            ins.CommandText = "insert into users(uUsername,uPassword,uSex,uBirthday) values(@name,@psw,@sex,@birth)";
            ins.Parameters.AddWithValue("@name", a);
            ins.Parameters.AddWithValue("@psw", b);
            ins.Parameters.AddWithValue("@sex", sex);
            ins.Parameters.AddWithValue("@birth",birth);
            ins.Connection = conn;
            conn.Open();
            int m = 0;
            m = ins.ExecuteNonQuery();
            conn.Close();
            if (m != 0)
            { ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('注册成功，请登录');window.location.href='./login.aspx'; </script>"); }
           
    }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('注册失败，已存在该用户,请登录');window.location.href='./login.aspx';</script>");
            username.Text = "";
        }
 }
}
