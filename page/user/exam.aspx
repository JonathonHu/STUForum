<%@ Page Title="" Language="C#" MasterPageFile="~/page/user/MasterPage.master" AutoEventWireup="true" CodeFile="exam.aspx.cs" Inherits="page_user_exam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<nav class="navbar navbar-default ">
	<div class="container-fluid ">
		<a class="navbar-brand " href="./homepage.aspx">首页</a>
		<ul class="nav navbar-nav">
			<li  class="active"><a href="./exam.aspx">考试相关</a></li>
			<li><a href="./club.aspx">七彩社团</a></li>
			<li><a href="./study.aspx">学习交流</a></li>
			<li><a href="./touristy.aspx">一起去旅行</a></li>
            <li><a href="./myPage.aspx">我的主页</a></li>
            <li><a href="./share.aspx">文件分享</a></li>
            <li><a href="../exit.aspx">退出</a></li>
		</ul>
	</div>
</nav> 	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div style="margin-bottom:10px;">
    <asp:Button runat="server" ID="write" class="col-lg-offset-11 btn btn-default btn-sm" 
          Text="发贴" onclick="write_Click"/>
  </div>
<div id = "tiezi" runat="server"></div>
</asp:Content>

