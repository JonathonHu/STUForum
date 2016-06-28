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
            Response.Write(uid);
            Session["pid"] = pid;
            string str = "<div class='panel panel-default'><div class='panel-heading text-center h3'>" + t + "</div><div class='panel-body'>\t" + c + "</div><div class='panel-footer text-right'>" + w + "</div></div>";
            this.tiezi.InnerHtml = str;
            
   //pid:文章ID，session["user"]:个人IDuid
    }
}