<%@ Page Title="" Language="C#" MasterPageFile="~/page/user/MasterPage.master" AutoEventWireup="true" CodeFile="homepage.aspx.cs" Inherits="page_user_homepage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="nav" Runat="Server">

<nav class="navbar navbar-default ">
	<div class="container-fluid ">
		<a class="navbar-brand " href="./homepage.aspx">首页</a>
		<ul class="nav navbar-nav">
			<li><a href="./exam.aspx">考试相关</a></li>
			<li><a href="./club.aspx">社团活动</a></li>
			<li><a href="./study.aspx">学习交流</a></li>
			<li><a href="./touristy.aspx">一起去旅行</a></li>
            <li><a href="./myPage.aspx">我的主页</a></li>
            <li><a href="./share.aspx">文件分享</a></li>
            <li><a href="../login.aspx">退出</a></li>
		</ul>
	</div>
</nav> 		
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="content" Runat="Server">
<p class="h1 text-center text-info">公告</p>
<div class="panel panel-default" style="margin:8px;">
    <div class="panel-heading"><asp:TextBox runat="server" ID="topic" Columns="50" style="border:none; background-color:Transparent;" Readonly class="col-lg-offset-2 text-center h3">测试标题</asp:TextBox></div>
    <div class="panel-body"><asp:TextBox runat="server" ID="content"  TextMode="MultiLine" Wrap="true" AutoPostBack="false"  Columns="180" Rows="5" style="border:none; background-color:Transparent;" Readonly class="text-justify" >这里是测试正文</asp:TextBox></div>
<div class="panel-footer"><asp:TextBox runat="server" ID="writer" style="border:none; background-color:Transparent;" Readonly class="text-right col-lg-offset-10">by:hobson</asp:TextBox></div>
</div>
</asp:Content>

