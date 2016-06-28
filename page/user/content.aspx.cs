using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_content : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

        int pid = Convert.ToInt32(Request.QueryString["id"]);
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from posts where pID=@ID", conn);
        cmd.Parameters.AddWithValue("@ID", pid);
        SqlDataReader reader = cmd.ExecuteReader();
        int uid = 0;
        SqlCommand sel = new SqlCommand("select uUsername from users where uID=@UID", conn);
        string t = "";
        string c = "";
        string w = "";
        reader.Read();
        t = reader.GetString(0);
        c = reader.GetString(1);
        uid = Convert.ToInt32(reader.GetValue(3).ToString());
        reader.Close();
        sel.Parameters.AddWithValue("@UID", uid);
        w = sel.ExecuteScalar().ToString();

        Session["pid"] = pid;

        //以下是回复的加载代码

        SqlCommand rep = new SqlCommand("select * from reply where pID = @pid", conn);
        rep.Parameters.AddWithValue("@pid", pid);
        SqlDataReader rReader = rep.ExecuteReader();
        string reply = "";
        
        while (rReader.Read())
        {
            
                reply = reply + "\n<p><i>" + rReader.GetValue(1).ToString() + "</i></p>\n<p class='text-info'>" + rReader.GetValue(4).ToString() + "</p><br>";
        }
        if (reply == "")
            reply = "暂无回复";


        conn.Close();

        string str = "<div class='panel panel-default'><div class='panel-heading text-center h3'>" + t + "\t\t<small>" + w + "</small></div><div class='panel-body'>" + c + "</div></div><br/><div class='panel panel-default'><div class='panel-heading text-center h3'>以下是回复</div><div class='panel-body text-left'>" + reply + "</div></div>";


        this.tiezi.InnerHtml = str;

        conn.Open();
        SqlCommand num = new SqlCommand("select pOK from posts where pID=@pid", conn);
        num.Parameters.AddWithValue("@pid", pid);
        int i = Convert.ToInt32(num.ExecuteScalar().ToString());
        conn.Close();
        write.Text = "赞 " + i;

        //pid:文章ID，session["user"]:个人IDuid


        //收藏按钮
        int fs = 0;
        SqlCommand selfav = new SqlCommand("select count(*) from faverite where pID = @pid and uID=@uid", conn);
        selfav.Parameters.AddWithValue("@pid", pid);
        selfav.Parameters.AddWithValue("@uid", uid);
        conn.Open();
        fs = Convert.ToInt32(selfav.ExecuteScalar());
        conn.Close();
        if (fs != 0)
            fave.Text = "已收藏";
    }

    protected void reply_Click(object sender, EventArgs e)
    {
        Response.Redirect("./reply.aspx");
    }

    protected void write_Click(object sender, EventArgs e)
    {
        int pid = Convert.ToInt32(Request.QueryString["id"]);
        conn.Open();
        SqlCommand up = new SqlCommand("update posts set pOK=pOK+1 where pID = @pid", conn);
        up.Parameters.AddWithValue("@pid",pid);
        up.ExecuteNonQuery();
        conn.Close();
    }
    protected void fave_Click(object sender, EventArgs e)
    {
        int pid = Convert.ToInt32(Request.QueryString["id"]);
        int uid = Convert.ToInt32(Session["user"].ToString());

        SqlCommand save = new SqlCommand("insert into faverite(pID,uID) values(@pid,@uid)", conn);
        save.Parameters.AddWithValue("@pid",pid);
        save.Parameters.AddWithValue("@uid",uid);

        SqlCommand sel = new SqlCommand("select count(*) from faverite where pID = @pid and uID=@uid", conn);
        sel.Parameters.AddWithValue("@pid", pid);
        sel.Parameters.AddWithValue("@uid", uid);

        SqlCommand del = new SqlCommand("delete from faverite where pID = @pid and uID=@uid", conn);
        del.Parameters.AddWithValue("@pid", pid);
        del.Parameters.AddWithValue("@uid", uid);
        
        conn.Open();
        int i=0;
        conn.Close();
        Response.Write(i);
        conn.Open();
       i = Convert.ToInt32(sel.ExecuteScalar());
        Response.Write(uid);
        Response.Write(pid);
        conn.Close();
        if (i != 0)
        {
            conn.Open();
            del.ExecuteNonQuery();
            conn.Close();
            fave.Text = "收藏";
        }
        else
        {
            conn.Open();
            save.ExecuteNonQuery();
            conn.Close();
            fave.Text = "已收藏";
        }
    }
}