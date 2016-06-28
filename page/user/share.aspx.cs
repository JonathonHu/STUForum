using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_share : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select * from FilePath",conn);
        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        string str = "";
        int fileid = 0;
        string filename = "";
        while (reader.Read())
        {
            filename = reader.GetValue(1).ToString();
            fileid = Convert.ToInt32(reader.GetValue(0).ToString());
            str = str + "<div class='panel panel-default'><div class='panel-heading'><a href='filedownload.aspx?id=" + fileid + "'>" + filename + "</a></div></div>";
        }
        this.tiezi.InnerHtml = str;
    }
    protected void write_Click(object sender, EventArgs e)
    {
        Response.Redirect("./upload.aspx");
    }
}