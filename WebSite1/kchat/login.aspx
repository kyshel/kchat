<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="kchat_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="220px" Style="z-index: 100; left: 265px;
        position: absolute; top: 197px" Width="900px">
        <table style="width: 682px; height: 108px; z-index: 100; left: 5px; position: absolute; top: 2px;">
            <tr>
                <td colspan="2">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;kchat<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 37px">
                    name:</td>
                <td style="width: 481px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
            ErrorMessage="name is empty!"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 37px">
                    password:</td>
                <td style="width: 481px">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="password is empty!"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <a href="register.aspx">regist a new account</a>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Image ID="Image1" runat="server" Height="521px" ImageUrl="f/win7_1360x7681.jpg"
        Width="1120px" /></div>
    </form>
</body>
</html>
