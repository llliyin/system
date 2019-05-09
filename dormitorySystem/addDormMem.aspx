<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addDormMem.aspx.cs" Inherits="dormitorySystem.addDormMem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        添加寝室成员信息<br />
        <br />
        寝室号：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        寝室类型：<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--请选择--</asp:ListItem>
            <asp:ListItem Value="4">四人寝</asp:ListItem>
            <asp:ListItem Value="6">六人寝</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        姓名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        &nbsp;<br />
        专业：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />
        <br />
        <br />
        <br />
    
    </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
