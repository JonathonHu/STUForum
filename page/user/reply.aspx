<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reply.aspx.cs" Inherits="page_user_reply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>回帖</title>
    <link rel="stylesheet" href="../../css/bootstrap.min.css">
</head>

<body>
    <form id="form1" runat="server">
   <div class="container">

<nav class="navbar navbar-default " role="navigation">
	<div class="container-fluid navbar-left">
		<a class="navbar-brand navbar-left" href="./homepage.aspx">首页</a>
		<ul class="nav navbar-nav navbar-left">
			<li ><a href="./exam.aspx">考试相关</a></li>
			<li ><a href="./club.aspx">社团活动</a></li>
			<li ><a href="./study.aspx">学习交流</a></li>
			<li ><a href="./touristy.aspx">一起去旅行</a></li>
            <li><a href="./myPage.aspx">我的主页</a></li>
            <li><a href="./share.aspx">文件分享</a></li>
		</ul>
	</div>
</nav> 	

 <div class="form-group">
    <asp:TextBox ID="content" runat="server" class="form-control" TextMode="MultiLine" Wrap="true" AutoPostBack="false"  Columns="50" Rows="15" style="margin-top:6px;" placeholder="请输入回复" />
  </div>
    <div class="row form-group form-inline col-lg-offset-10">
  <asp:Button runat="server" class="form-control btn btn-success" type="button" 
            ID="submit" Text="提交" onclick="submit_Click"/>
  <asp:Button runat="server" class="form-control btn btn-default" type="button" 
            ID="reset"  Text="重置"/>
  </div>
    </form>
</body>
</html>
