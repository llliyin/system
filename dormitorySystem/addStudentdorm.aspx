<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addStudentdorm.aspx.cs" Inherits="dormitorySystem.addDormitoryNem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
 
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        添加宿舍成员信息<br />
        <br />
        学号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        性别：<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <br />
        <br />
        专业：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        寝室号：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />
    </form>
      
       
</body>
</html>
