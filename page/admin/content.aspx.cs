using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_content : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        int pid = Convert.ToInt32(Request.QueryString["id"].ToString());
        SqlCommand cmd = new SqlCommand("select * from posts where pID = @pid",conn);
        cmd.Parameters.AddWithValue("@pid", pid);
        SqlDataReader reader = cmd.ExecuteReader();
        string str = "";
        if (reader.Read())
        {
             str = str + "<div class='panel panel-default'><div class='panel-heading text-center h3'>" + reader.GetValue(0).ToString() + "</div><div class='panel-body'>" + reader.GetValue(1).ToString() + "</div></div>";
        }
        this.tiezi.InnerHtml = str;
        conn.Close();
    }

    protected void del_Click(object sender, EventArgs e)
    {
        conn.Open();
        int pid = Convert.ToInt32(Request.QueryString["id"].ToString());
        int fid = Convert.ToInt32(Request.QueryString["fid"].ToString());
        SqlCommand del = new SqlCommand("delete  from posts where pID = @pid", conn);
        del.Parameters.AddWithValue("@pid", pid);
        Response.Write(pid);
        Response.Write(fid);
        if (del.ExecuteNonQuery() != 0)
        {
            if (fid == 5)
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除成功');window.location.href='./notice.aspx';</script>");
            }
            else
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除成功');window.location.href='./post.aspx';</script>");
            }
        }
    }
}