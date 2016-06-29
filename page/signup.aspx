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

<p class="text-center h1" style="margin-top:30px;">注册</p>
<div class="form-group col-lg-6 col-lg-offset-3" >
    <asp:TextBox runat="server" ID="username" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="账号"/>
    <asp:TextBox runat="server" ID="password" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="密码"/>
    <asp:TextBox runat="server" ID="stuNum" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="学号"/>
    <asp:TextBox runat="server" ID="name" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="姓名"/>
    <asp:TextBox runat="server" ID="sex" type="text" style="margin-top:5px;" class="form-control input-lg col-lg-6 "  placeholder="性别"/>
    <asp:TextBox runat="server" ID="university" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="学院"/>
    <asp:TextBox runat="server" ID="birthday" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="生日（如：19900101）"/> 
    <asp:Button runat="server" ID="Button1"  
        style="margin-top:5px; margin-left:150px;" class=" btn btn-default btn-lg col-lg-offset-1" 
      Text="提交" onclick="Button1_Click"/>
      <asp:Button runat="server" ID="Button2"  style="margin-top:5px;" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="重置" onclick="Button2_Click"/>
  </div>
  </div>
    </form>
</body>
</html>