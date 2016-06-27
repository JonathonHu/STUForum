using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_study : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from posts where fID=1 order by pID desc";
        cmd.Connection = conn;
        SqlDataReader reader = cmd.ExecuteReader();
        int i = 0;
        int m = 0;
        string str = "<form name='form1' action='form_action.aspx' method='get'>";
        string t = "";
        string c = "";
        string w = "";
        SqlCommand sel = new SqlCommand("select uUsername from users where uID = @ID",conn); 
        while (i < 10)
        {
            int[] ids = new int[10];
            if (reader.Read())
            {
                t = reader.GetString(0);
                c = reader.GetString(1);
                sel.Parameters.AddWithValue("@ID", reader.GetString(3));
                w = sel.ExecuteScalar().ToString();
                ids[m] =Convert.ToInt16(reader.GetString(3).ToString());
                str = str + "<div class='panel panel-default'><div class='panel-heading'><a name ='pID' value='"+ids[m]+"' href='javascript:form1.submit();'>" + t + "</a></div></div>";
            }
            else
            {
                break;
            }
            i++;
            m++;
            str =str+ "</form>";
        }
        if (t=="")
            str = "<div class='panel panel-default'><div class='panel-heading'>暂无内容</div></div>";


        this.tiezi.InnerHtml = str;
    }
}