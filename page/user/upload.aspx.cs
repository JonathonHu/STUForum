using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class page_user_upload : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submit_Click(object sender, EventArgs e)
    {
        SqlCommand ins = new SqlCommand("insert into FilePath(name) values(@savename)", conn);
        string savePath = @"C:/STUforum/STUForum/page/fileupload/";
        if (upload.HasFile)
        {
            string fileName = upload.FileName;
            savePath += fileName;
            ins.Parameters.AddWithValue("@savename", fileName);
            conn.Open();
            ins.ExecuteScalar();
            conn.Close();
            upload.SaveAs(savePath);
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('上传成功');window.location.href='./share.aspx';</script>");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/javascript'>alert('上传失败');</script>");
        }
    }
}