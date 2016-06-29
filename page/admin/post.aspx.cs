using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_post : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("select * from posts where fID!=5 order by pID desc", conn);
        SqlDataReader reader = cmd.ExecuteReader();

        string str = "";
        string pid1 = "";
        string pid2 = "";
        string pid3 = "";
        string pid4 = "";

        while (reader.Read())
        {
            if (Convert.ToInt32(reader.GetValue(4).ToString()) == 1)
            { 
                pid1 = pid1 + "<div class='panel panel-default'><div class='panel-heading'><a href='./content.aspx?id=" + reader.GetValue(5) + "&fid=1'>" + reader.GetValue(0).ToString() + "</a></div></div>"; 
            }
            if (Convert.ToInt32(reader.GetValue(4).ToString()) == 2)
            {
                pid2 = pid2 + "<div class='panel panel-default'><div class='panel-heading'><a href='./content.aspx?id=" + reader.GetValue(5) + "&fid=2'>" + reader.GetValue(0).ToString() + "</a></div></div>"; 
            }
            if (Convert.ToInt32(reader.GetValue(4).ToString()) == 3)
            {
                pid3= pid3+ "<div class='panel panel-default'><div class='panel-heading'><a href='./content.aspx?id=" + reader.GetValue(5) + "&fid=3'>" + reader.GetValue(0).ToString() + "</a></div></div>";
            }
            if (Convert.ToInt32(reader.GetValue(4).ToString()) == 4)
            {
                pid4 = pid4 + "<div class='panel panel-default'><div class='panel-heading'><a href='./content.aspx?id=" + reader.GetValue(5) + "&fid=4'>" + reader.GetValue(0).ToString() + "</a></div></div>";
            }
        }
        str = pid1 + pid2 + pid3 + pid4;
        if (str == "")
            str = "<div class='panel panel-default'><div class='panel-heading'>暂无内容</div></div>";
      
        reader.Close();
        
        this.tiezi.InnerHtml = str;
    }
}