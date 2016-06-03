<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e35.aspx.cs" Inherits="e3_e35" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;money convert program<br />
        <hr />
    
    </div>
        Please choose convert type:<br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="type" 
            Text="RMB 2 USD" /><br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="type" Text="USD 2 RMB" /><br />
        Please input money:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" /><br />
        Convert Result:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
