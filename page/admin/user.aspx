﻿<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="page_admin_user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li><a href="./notice.aspx">公告管理</a></li>
 	                <li  class="active"><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../exit.aspx">退出</a></li>
                </ul>
	        </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="stuNum" DataSourceID="SqlDataSource2" Width="800px" 
        style="margin-top:30px">
        <Columns>
            <asp:BoundField DataField="uID" HeaderText="用户ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="uID" />
            <asp:BoundField DataField="uUsername" HeaderText="用户名" 
                SortExpression="uUsername" />
            <asp:BoundField DataField="uPassword" HeaderText="密码" 
                SortExpression="uPassword" />
            <asp:BoundField DataField="uSex" HeaderText="性别" SortExpression="uSex" />
            <asp:BoundField DataField="uBirthday" HeaderText="uBirthday" 
                SortExpression="uBirthday" />
            <asp:BoundField DataField="stuNum" HeaderText="学号" ReadOnly="True" 
                SortExpression="stuNum" />
            <asp:BoundField DataField="name" HeaderText="姓名" SortExpression="name" />
            <asp:BoundField DataField="university" HeaderText="university" 
                SortExpression="university" />
            <asp:BoundField DataField="uState" HeaderText="审核状态（1为通过，0为待审核，-1为不通过）" 
                SortExpression="uState" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="Data Source=HOBSON;Initial Catalog=STUBBS;Integrated Security=True;Pooling=False" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [users]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=HOBSON;Initial Catalog=STUBBS;Integrated Security=True;Pooling=False" 
        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [users]">
    </asp:SqlDataSource>

    <div style="margin-top:15px">
 <p><asp:Button runat="server" class=" btn btn-success  btn-lg" type="button" 
            ID="submit" Text="添加用户" onclick="submit_Click"/>
  <asp:Button runat="server" class="btn btn-default btn-lg" type="button" 
            ID="reset"  Text="删除用户" onclick="reset_Click"/></p>
</div>

<div class="form-group col-lg-5 form-search">
    <asp:TextBox runat="server" ID="userid" type="text" class=" input-medium   input-lg col-lg-7 " style="margin-top:60px" placeholder="请输入要更改状态的用户ID"/>
    <asp:TextBox runat="server" ID="state" type="text" class=" input-medium   input-lg col-lg-7 " style="margin-top:15px"  placeholder="请输入要更改成的状态"/>
   <asp:Button runat="server" ID="change" style="margin-top:60px" class="btn btn-default btn-lg  col-lg-offset-1" 
      Text="确定" onclick="change_Click"/>
  </div>
</asp:Content>

