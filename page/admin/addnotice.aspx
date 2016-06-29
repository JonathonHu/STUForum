<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="addnotice.aspx.cs" Inherits="page_admin_addnotice" %>

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
  <div class="form-group">
 	<asp:TextBox ID="topic" runat="server" type="text" class="form-control " placeholder="请输入标题"/>
    <asp:TextBox ID="content" runat="server" class="form-control" TextMode="MultiLine" Wrap="true" AutoPostBack="false"  Columns="50" Rows="15" style="margin-top:6px;" placeholder="请输入正文" />

  </div>
    <div class="row form-group form-inline">
    <p class="col-lg-offset-10">
  <asp:Button runat="server" class="form-control btn btn-success" type="button" 
            ID="submit" Text="发布" onclick="submit_Click"/>
  <asp:Button runat="server" class="form-control btn btn-default" type="button" 
            ID="reset"  Text="重置"/>
	</p>
  </div>
</asp:Content>

