<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e35_4.aspx.cs" Inherits="e3_e35_4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Height="30px" Text="Label" Width="378px"></asp:Label>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="option" Text="A.2" /><br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="option" Text="B.0" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Button"
            Width="127px" /></div>
    </form>
</body>
</html>
