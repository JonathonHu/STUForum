<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="page_admin_admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li class="active"><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li><a href="./notice.aspx">公告管理</a></li>
 	                <li><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../exit.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" Width="660px" style="margin-top:30px">
        <Columns>
            <asp:BoundField DataField="aUsername" HeaderText="用户名" 
                SortExpression="aUsername" />
            <asp:BoundField DataField="aPassword" HeaderText="密码" 
                SortExpression="aPassword" />
            <asp:BoundField DataField="aID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="aID" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=HOBSON;Initial Catalog=STUBBS;Integrated Security=True;Pooling=False" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [admin]">
    </asp:SqlDataSource>



<div style="margin-top:15px">
 <p><asp:Button runat="server" class=" btn btn-success  btn-lg" type="button" 
            ID="submit" Text="添加管理员" onclick="submit_Click"/>
  <asp:Button runat="server" class="btn btn-default btn-lg" type="button" 
            ID="reset"  Text="删除管理员" onclick="reset_Click"/></p>
</div>
 
</asp:Content>

