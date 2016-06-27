<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="page_signup" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>用户注册</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">


  <div class="container-fluid">
    <asp:Image runat="server" ID = "head" ImageUrl="~/image/bbs.png" Width="100%" height="80px"/>
    
  </div>

<p class="text-center h1" style="margin-top:80px;">注册</p>
<div class="form-group col-lg-5">
    <asp:TextBox ID="username" runat="server" class="form-control input-lg col-lg-offset-9" style="margin-top:15px;" placeholder="请输入账号"></asp:TextBox>
    <asp:TextBox ID="password" runat="server" class="form-control input-lg col-lg-offset-9" style="margin-top:15px;" placeholder="请输入密码"></asp:TextBox>
    <asp:TextBox ID="birthday" runat="server" class="form-control input-lg col-lg-offset-9" style="margin-top:15px;" placeholder="请输入生日,格式：19950101"></asp:TextBox>
    <asp:DropDownList runat="server" ID="who"  class="form-control input-lg col-lg-offset-9" style="width:100px; margin-top:15px;">
        <asp:ListItem Value="1">男</asp:ListItem>
        <asp:ListItem Value="0">女</asp:ListItem>
    </asp:DropDownList>
  </div>
  <div>
    <asp:Button runat="server" ID="submit" class="btn btn-default btn-lg" 
          style="margin-top:200px;" Text="确认" onclick="submit_Click"/>
    <asp:Button runat="server" ID="reset" class="btn btn-default btn-lg" 
          style="margin-top:200px;" Text="重置"/>
  </div>
  </div>
    </form>
</body>
</html>