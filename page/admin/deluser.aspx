<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="deluser.aspx.cs" Inherits="page_admin_deluser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li><a href="./notice.aspx">公告管理</a></li>
 	                <li  class="active"><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div class="form-group col-lg-5 form-search">
    <asp:TextBox runat="server" ID="stunum" type="text" class=" input-medium   input-lg col-lg-6 "  placeholder="请输入要删除的学号"/>
   <asp:Button runat="server" ID="submit" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="删除" onclick="submit_Click" />
  </div>
</asp:Content>

