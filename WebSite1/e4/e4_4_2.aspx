<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e4_4_2.aspx.cs" Inherits="e4_e4_4_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        User register<br />
        name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        sex: &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" /></div>
    </form>
</body>
</html>
