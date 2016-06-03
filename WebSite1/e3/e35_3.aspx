<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e35_3.aspx.cs" Inherits="e3_e35_3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Register<br />
        <br />
        <table>
            <tr>
                <td style="width: 16px; height: 21px">
                    <span style="color: #ff0000">*</span></td>
                <td style="width: 100px; height: 21px">
                    <span style="color: #ff0000"></span>Name:</td>
                <td style="width: 100px; height: 21px">
                    <asp:TextBox ID="TextBox1" runat="server" TabIndex="1"></asp:TextBox></td>
                <td style="width: 236px; height: 21px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="Name require"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 16px; height: 26px">
                    <span style="color: #ff0000">*</span></td>
                <td style="width: 100px; height: 26px">
                    Password:</td>
                <td style="width: 100px; height: 26px">
                    <asp:TextBox ID="TextBox2" runat="server" TabIndex="2"></asp:TextBox></td>
                <td style="width: 236px; height: 26px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                        ErrorMessage="Password require"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 16px; height: 26px">
                </td>
                <td style="width: 100px; height: 26px">
                    Birth:</td>
                <td style="width: 100px; height: 26px">
                    <asp:TextBox ID="TextBox3" runat="server" TabIndex="3" ToolTip="Format Example:1995-01-01"></asp:TextBox></td>
                <td style="width: 236px; height: 26px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3"
                        ErrorMessage="Format error, example:1995-01-01" ValidationExpression="[0-9]{4}-[0-9]{2}-[0-9]{2}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 16px">
                </td>
                <td style="width: 100px">
                    Phone:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server" TabIndex="4"></asp:TextBox></td>
                <td style="width: 236px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4"
                        ErrorMessage="Should be eleven number" ValidationExpression="^[\d]{11}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 16px">
                </td>
                <td style="width: 100px">
                    E-mail:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server" TabIndex="5"></asp:TextBox></td>
                <td style="width: 236px">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox5"
                        ErrorMessage="Format error" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Height="108px" Width="184px"></asp:Label></div>
    </form>
</body>
</html>
