<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chat.aspx.cs" Inherits="kchat_chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="background-image: url(f/chat.jpg); width: 100%;">
    <form id="form1" runat="server">
    <div >
    <span style="font-size: 16pt"><strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        Simple Chat&nbsp; Room</strong></span><asp:Label ID="Label1" runat="server" Height="1px" Width="241px" Visible="False"></asp:Label><br />
    <table style="width: 914px; height: 394px">
        <tr>
            <td style="width: 474px; height: 185px">
    <iframe id="Iframe1" src="talk.aspx" style="width:755px;height:458px;"></iframe>
            </td>
            <td style="width: 100px; height: 185px">
        <asp:Label ID="Label4" runat="server" Height="454px" Width="224px" BorderStyle="Inset"></asp:Label></td>
        </tr>
    </table>
    <br />
        &nbsp;<asp:Label ID="Label2" runat="server" Width="584px" Height="15px"></asp:Label><br />
        <br />
        Please speak:
        <asp:TextBox ID="TextBox1" runat="server" Width="498px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" /><br />
    Or upload file:<asp:FileUpload ID="FileUpload1" runat="server" />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="upload" />
    <asp:Label ID="Label5" runat="server" Height="8px" Width="144px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Width="90px"></asp:Label><br />
        <br />
        <asp:Label ID="Label3" runat="server" Height="39px" Width="495px"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="logout" /><br />
    <br />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Admin panel" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ClearApplication" />
    <br />
    <br />
</div>
    </form>
</body>
</html>
