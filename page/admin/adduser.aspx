<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="adduser.aspx.cs" Inherits="page_admin_adduser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./admin.aspx">管理员账号管理</a></li>
 	                <li><a href="./notice.aspx">公告管理</a></li>
 	                <li  class="active"><a href="./user.aspx">用户管理</a></li>
                    <li><a href="./post.aspx">贴子管理</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div class="form-group col-lg-6 col-lg-offset-1" >
    <asp:TextBox runat="server" ID="username" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="账号"/>
    <asp:TextBox runat="server" ID="password" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="密码"/>
    <asp:TextBox runat="server" ID="stuNum" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="学号"/>
    <asp:TextBox runat="server" ID="name" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="姓名"/>
    <asp:TextBox runat="server" ID="sex" type="text" style="margin-top:5px;" class="form-control input-lg col-lg-6 "  placeholder="性别"/>
    <asp:TextBox runat="server" ID="university" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="学院"/>
    <asp:TextBox runat="server" ID="birthday" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="生日（如：19900101）"/>
    
    <asp:Button runat="server" ID="submit"  
        style="margin-top:5px; margin-left:150px;" class=" btn btn-default btn-lg col-lg-offset-1" 
      Text="提交" onclick="submit_Click"/>
      <asp:Button runat="server" ID="reset"  style="margin-top:5px;" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="重置" onclick="reset_Click"/>
  </div>
</asp:Content>

