using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page_admin_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        Response.Redirect("./addadmin.aspx");
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        Response.Redirect("./deladmin.aspx");
    }
}