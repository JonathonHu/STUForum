using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_exam : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from posts where fID=2 order by pID desc";
        cmd.Connection = conn;
        SqlDataReader reader = cmd.ExecuteReader();
        int i = 0;
        string str = "";
        string t = "测试标题";
        string c = "测试正文";
        string w = "作者名字";
        SqlCommand sel = new SqlCommand("select uUsername from users where uID = @ID", conn);
        while (i < 10)
        {
            if (reader.Read())
            {
                t = reader.GetString(0);
                c = t = reader.GetString(1);
                sel.Parameters.AddWithValue("@ID", reader.GetString(3));
                w = sel.ExecuteScalar().ToString();
                str = str + "<div class='panel panel-default'><div class='panel-heading'>" + t + "</div><div class='panel-body'>" + c + "</div><div class='panel-footer'>" + w + "</div></div>";
            }
            else
            {
                break;
            }
            i++;
        }
        if (str == "")
            str = "<div class='panel panel-default'><div class='panel-heading'>暂无内容</div></div>";


        this.tiezi.InnerHtml = str;
    }
}