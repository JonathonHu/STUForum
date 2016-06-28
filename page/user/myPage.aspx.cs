using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_myPage : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand selfave = new SqlCommand("select faverite.pID,pContent from faverite,posts where faverite.uID = @uid and faverite.pID=posts.pID", conn);
        selfave.Parameters.AddWithValue("@uid", Convert.ToInt32(Session["user"].ToString()));

        SqlDataReader reader = selfave.ExecuteReader();
        string str = "";
        string c = "";
        int pid = 0;
        while (reader.Read())
        {
            /*c = selcon.ExecuteScalar().ToString();*/
            pid = Convert.ToInt32(reader.GetValue(0).ToString());
            c = reader.GetValue(1).ToString();
            str = str + "<div class='panel panel-default'><div class='panel-heading'><a href='content.aspx?id=" + pid + "'>" + c + "</a></div></div>";
        }

        conn.Close();
        this.tiezi.InnerHtml = str;
    }
}