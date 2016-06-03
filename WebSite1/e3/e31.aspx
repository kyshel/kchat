<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e31.aspx.cs" Inherits="e31" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Please click buttons below:<br />
        <asp:Button ID="Button1" runat="server" OnCommand="Button1_Command"
            Text="First" CommandArgument="first" />&nbsp;<asp:Button ID="Button2" runat="server" OnCommand="Button2_Command"
                Text="Second" CommandArgument="second" /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
    </form>
</body>
</html>
