<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="kchat_register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        register<br />
        name:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator><br />
        password:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator><br />
        sex:<br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Text="ÄÐ" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" Text="Å®" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="×¢²á" /></div>
    </form>
</body>
</html>
