using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_notice : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from posts where fID=5 order by pID desc",conn);
        SqlDataReader reader = cmd.ExecuteReader();

        string str = ""; 

      
        while (reader.Read())
        {
             str = str + "<div class='panel panel-default'><div class='panel-heading'><a href='./content.aspx?id=" + reader.GetValue(5)+ "&fid=5'>" + reader.GetValue(0).ToString() + "</a></div></div>";
        }
            
        if (str == "")
            str = "<div class='panel panel-default'><div class='panel-heading'>暂无内容</div></div>";
        reader.Close();

        this.tiezi.InnerHtml = str;
    }
    protected void write_Click(object sender, EventArgs e)
    {
        Response.Redirect("./addnotice.aspx");
    }
}