<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bank.aspx.cs" Inherits="bank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="verify" OnClick="Button1_Click" /><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="logout" /><br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="deposit" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="fetch" />
        <asp:Button ID="Button4" runat="server" Text="query" /><br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></div>
    </form>
</body>
</html>
