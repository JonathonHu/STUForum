<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="content.aspx.cs" Inherits="page_admin_content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li><a href="./notice.aspx">公告管理</a></li>
 	                <li><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div style="margin-bottom:10px;" class="col-lg-10">
    
    <asp:Button runat="server" ID="del" class=" col-lg-offset-10 btn btn-default btn-sm" 
          Text="删除" onclick="del_Click" />
          <!--这里两个按钮暂时不实现-->
          <!--
                <asp:Button runat="server" ID="fave" class="btn btn-default btn-sm"  Text="收藏" />
                <asp:Button runat="server" ID="reply" class="btn btn-default btn-sm" Text="回复" />-->
          </div>
<div id="tiezi" runat="server" class=" col-lg-10"></div>
</asp:Content>

