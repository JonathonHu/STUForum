using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_exit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (Session.Count != 0)
            {
                Session.Clear();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('退出成功');window.location.href='./login.aspx';</script>");
            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('退出成功');window.location.href='./login.aspx';</script>");
            }
        }
        else
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('退出成功');window.location.href='./login.aspx';</script>");


    }
}