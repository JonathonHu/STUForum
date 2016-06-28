using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;
public partial class page_user_filedownload : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=hobson; Initial Catalog=STUBBS;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Request.QueryString["id"].ToString());
        Response.Write(i);
        SqlCommand sel = new SqlCommand("select name from FilePath where fileID = @id",conn);
        sel.Parameters.AddWithValue("@id", i);
        conn.Open();
        string name = sel.ExecuteScalar().ToString();
        string filePath = @"C:/STUforum/STUForum/page/fileupload/" + name;

        FileInfo file = new FileInfo(filePath);



        Response.Clear();

        Response.ClearHeaders();

        Response.ClearContent();

        Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);

        Response.AddHeader("Content-Length", file.Length.ToString());

        Response.ContentType = "text/plain";

        Response.Flush();

        Response.TransmitFile(file.FullName);

        Response.End();
        Response.Redirect("./share.aspx");
    }
}