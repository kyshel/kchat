<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e35_2.aspx.cs" Inherits="e3_e35_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Please input two number:<br />
        num1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        num2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" Width="52px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" Width="55px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" Width="64px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" Width="44px" /><br />
        <asp:Label ID="Label1" runat="server" Height="45px" Width="216px"></asp:Label></div>
    </form>
</body>
</html>
