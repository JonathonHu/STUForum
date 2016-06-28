﻿<%@ Page Title="" Language="C#" MasterPageFile="~/page/user/MasterPage.master" AutoEventWireup="true" CodeFile="content.aspx.cs" Inherits="page_user_content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<nav class="navbar navbar-default ">
	<div class="container-fluid ">
		<a class="navbar-brand " href="./homepage.aspx">首页</a>
		<ul class="nav navbar-nav">
			<li><a href="./exam.aspx">考试相关</a></li>
			<li><a href="./club.aspx">七彩社团</a></li>
			<li><a href="./study.aspx">学习交流</a></li>
			<li><a href="./touristy.aspx">一起去旅行</a></li>
            <li><a href="./myPage.aspx">我的主页</a></li>
		</ul>
	</div>
</nav> 	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div>
<div style="margin-bottom:10px;">
    <asp:Button runat="server" ID="write" class=" col-lg-offset-10 btn btn-default btn-sm" 
          Text="赞" onclick="write_Click"/>
    <asp:Button runat="server" ID="fave" class="btn btn-default btn-sm" 
          Text="收藏" onclick="fave_Click" />
<asp:Button runat="server" ID="reply" class="btn btn-default btn-sm" 
          Text="回复" onclick="reply_Click" />
<div id="tiezi" runat="server"></div>
</asp:Content>

