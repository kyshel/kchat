<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="kchat_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;kchat<br />
        name£º<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator><br />
        password £º<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <a href="register.aspx">regist a new account</a>
        </div>
    </form>
</body>
</html>
