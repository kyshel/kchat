<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chat.aspx.cs" Inherits="kchat_chat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Simple Chat&nbsp; Room<br />
<<<<<<< HEAD
        <asp:Label ID="Label1" runat="server" Height="4px" Width="218px" Visible="False"></asp:Label><br />
    <br />
    <iframe id="Iframe1" src="talk.aspx" style="width:586px;height:231px;"></iframe>
    <br />
    
        <br />
        &nbsp;<asp:Label ID="Label2" runat="server" Width="584px" Height="15px"></asp:Label><br />
=======
        <asp:Label ID="Label1" runat="server" Height="130px" Width="492px"></asp:Label><br />
        <br />
        &nbsp;<asp:Label ID="Label2" runat="server" Width="494px" Height="16px"></asp:Label><br />
>>>>>>> ae312f6bb2b6cba83d4a0a750ef6c91be45042c9
        <br />
        Please speak:
        <asp:TextBox ID="TextBox1" runat="server" Width="498px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" /><br />
<<<<<<< HEAD
    Or upload file:<asp:FileUpload ID="FileUpload1" runat="server" />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="upload" />
    <asp:Label ID="Label5" runat="server" Height="8px" Text="Label" Width="144px"></asp:Label>
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><br />
=======
>>>>>>> ae312f6bb2b6cba83d4a0a750ef6c91be45042c9
        <br />
        <asp:Label ID="Label3" runat="server" Height="39px" Width="495px"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="logout" /><br />
        <br />
        <asp:Label ID="Label4" runat="server" Height="31px" Width="513px"></asp:Label><br />
<<<<<<< HEAD
    <br />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Admin panel" /><br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ClearApplication" /></div>
=======
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ClearApplication" /><br />
        

    </div>
>>>>>>> ae312f6bb2b6cba83d4a0a750ef6c91be45042c9
    </form>
</body>
</html>
