using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_admin_deladmin : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        SqlCommand sel = new SqlCommand("select count(*) from admin where aUsername = @username", conn);
        sel.Parameters.AddWithValue("@username", username.Text);

        SqlCommand del = new SqlCommand("delete from  admin where aUsername = @username", conn);
        del.Parameters.AddWithValue("@username", username.Text);

        conn.Open();

        if (Convert.ToInt32(sel.ExecuteScalar().ToString()) != 0)
        {
            if (del.ExecuteNonQuery() != 0)
            {
                conn.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除成功');window.location.href='./admin.aspx'; </script>");
            }
            else
            { ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('删除失败');window.location.href='./admin.aspx'; </script>"); conn.Close(); }
        }
        else
        {
            conn.Close();
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('不存在该用户');window.location.href='./admin.aspx'; </script>"); }
    }
    protected void reset_Click(object sender, EventArgs e)
    {
        username.Text = "";
    }
}