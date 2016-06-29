<%@ Page Title="" Language="C#" MasterPageFile="~/page/user/MasterPage.master" AutoEventWireup="true" CodeFile="myPage.aspx.cs" Inherits="page_user_myPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<nav class="navbar navbar-default ">
	<div class="container-fluid ">
		<a class="navbar-brand " href="./homepage.aspx">首页</a>
		<ul class="nav navbar-nav">
			<li><a href="./exam.aspx">考试相关</a></li>
			<li><a href="./club.aspx">七彩社团</a></li>
			<li><a href="./study.aspx">学习交流</a></li>
			<li><a href="./touristy.aspx">一起去旅行</a></li>
            <li class="active"><a href="./myPage.aspx">我的主页</a></li>
            <li><a href="./share.aspx">文件分享</a></li>
            <li><a href="../login.aspx">退出</a></li>
		</ul>
	</div>
</nav> 		
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<p class="h1 text-center text-info">我的收藏</p>
<div id = "tiezi" runat="server"></div>
</asp:Content>

