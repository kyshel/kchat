<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="kchat_register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body >
    <form id="form1" runat="server">
    <div>
    <asp:Image ID="Image1" runat="server" ImageUrl="f/win7_1360x7681.jpg" />
    <table style="width: 743px;
        height: 200px; text-align: left; left: 323px; position: relative; top: -562px;" >
        <tr>
            <td colspan="2" style="text-align: left">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; kchat
                registe<br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 17px">
        name:</td>
            <td style="width: 397px">
        <asp:TextBox ID="TextBox1" runat="server" Width="115px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="name must set"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 17px">
        password:</td>
            <td style="width: 397px">
        <asp:TextBox ID="TextBox2" runat="server" Width="114px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="password must set"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="width: 17px">
        sex:</td>
            <td style="width: 397px">
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" Text="Å®" /><asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Text="ÄÐ" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="registe" /></td>
        </tr>
        <tr>
            <td colspan="2" style="height: 33px">
        <a href="login.aspx">back to login</a>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
