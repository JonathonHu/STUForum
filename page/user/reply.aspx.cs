using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_reply : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into reply(rDate,pID,uID,rContent) values(@rdate,@pid,@uid,@content)", conn);
        cmd.Parameters.AddWithValue("@rdate", DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@pid",Convert.ToInt32( (Session["pid"].ToString())));
        cmd.Parameters.AddWithValue("@uid",Convert.ToInt32( (Session["user"].ToString())));
        cmd.Parameters.AddWithValue("@content", content.Text);
        int i = 0;
        int uid = Convert.ToInt32( (Session["pid"].ToString()));
        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        if (i != 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('回复成功');window.location.href='./content.aspx?id="+uid+"';</script>");
        }
        else
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('回复失败');</script>");
    }
}