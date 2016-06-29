<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="notice.aspx.cs" Inherits="page_admin_notice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li class="active"><a href="./notice.aspx">公告管理</a></li>
 	                <li><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../exit.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div style="margin-bottom:10px;" class="col-lg-10">
    <asp:Button runat="server" ID="write" class="col-lg-offset-10  btn btn-default btn-md" 
          Text="发布公告" onclick="write_Click"/>
  </div>
<div runat="server" id="tiezi" class=" col-lg-10"></div>
</asp:Content>

