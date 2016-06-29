using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_addnotice : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into posts(pTitle,pContent,pDate,uID,fID) values(@title,@content,@date,@uid,5)",conn);
        cmd.Parameters.AddWithValue("@title",topic.Text);
        cmd.Parameters.AddWithValue("@content",content.Text);
        cmd.Parameters.AddWithValue("@date",DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@uid", Convert.ToInt32(Session["user"].ToString()));
        if (topic.Text.Trim() != "" && content.Text.Trim() != "")
        {
            if (cmd.ExecuteNonQuery() != 0)
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('发布成功');window.location.href='./notice.aspx';</script>");
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('发布失败，请完整填写');</script>");
        }
    }
}