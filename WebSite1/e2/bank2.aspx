<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bank2.aspx.cs" Inherits="e2_bank2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        1 means password verify
        <br />
        2 means deposit
        <br />
        3 means withdraw
        <br />
        4 means balance
        <br />
        5 means exit
        <br />
        <br />
        Please choose operation by number:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /><br />
        <asp:Label ID="Label1" runat="server" Height="67px" Width="215px"></asp:Label></div>
    </form>
</body>
</html>
