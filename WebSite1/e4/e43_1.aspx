<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e43_1.aspx.cs" Inherits="e4_e43_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        pass:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" /><br />

    </div>
    </form>
</body>
</html>
