using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_writen : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            if (Session.Count == 0)
                Response.Redirect("../login.aspx");
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        string a = topic.Text.Trim();
        string b = content.Text.Trim();
        int i = Convert.ToInt32(Session["user"].ToString());
        if (a != "" && b != "")
        {
            SqlCommand store = new SqlCommand();
            store.Connection = conn;
            store.CommandType = CommandType.Text;
            string choose = list.SelectedValue;
            string flag = "no";
            switch (choose)
            {
                case "1":
                    store.CommandText = "insert into posts(pTitle,pContent,pDate,uID,fID) values(@title,@content,@pdate,@uid,'1')"; flag = "learn"; break;
                case "2":
                    store.CommandText = "insert into posts(pTitle,pContent,pDate,uID,fID) values(@title,@content,@pdate,@uid,'2')"; flag = "exam"; break;
                case "3":
                    store.CommandText = "insert into posts(pTitle,pContent,pDate,uID,fID) values(@title,@content,@pdate,@uid,'3')"; flag = "travel"; break;
                case "4":
                    store.CommandText = "insert into posts(pTitle,pContent,pDate,uID,fID) values(@title,@content,@pdate,@uid,'4')"; flag = "club"; break;
                default:
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('请选择版块');</script>");
                    flag = "no";
                    break;
            };
            if (flag != "no")
            {
                store.Parameters.AddWithValue("@title", a);
                store.Parameters.AddWithValue("@content", b);
                store.Parameters.AddWithValue("@pdate", DateTime.Now.ToString());
                store.Parameters.AddWithValue("@uid", i);
                conn.Open();
                store.ExecuteNonQuery();
                conn.Close();

            }

            switch (flag)
            {
                case "club":
                    {
                        Response.Redirect("./club.aspx");
                        break;
                    }
                case "exam":
                    {
                        Response.Redirect("./exam.aspx");
                        break;
                    }
                case "learn":
                    {
                        Response.Redirect("./study.aspx");
                        break;
                    }
                case "travel":
                    {
                        Response.Redirect("./touristy.aspx");
                        break;
                    }
                case "no":
                    {
                        break;
                    }
            }
        }

    }
}