<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chat.aspx.cs" Inherits="kchat_chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Simple Chat&nbsp; Room<br />
        <asp:Label ID="Label1" runat="server" Height="207px" Width="491px"></asp:Label><br />
        <br />
        &nbsp;<asp:Label ID="Label2" runat="server" Width="485px" Height="40px"></asp:Label><br />
        <br />
        Please speak:
        <asp:TextBox ID="TextBox1" runat="server" Width="498px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" /><br />
        <br />
        ----------------------------------------------------------------------------------------<br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ClearApplication" /><br />
        <br />
        <asp:Label ID="Label3" runat="server" Height="39px" Width="495px"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="logout" /></div>
    </form>
</body>
</html>
