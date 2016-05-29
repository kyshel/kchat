 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="e32.aspx.cs" Inherits="e3_e32" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        RadioButtonList show program<br />
        <hr />
    
    </div>
        Please choose the name of font, than submit<br />
        &nbsp;
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>TimesNewRoman</asp:ListItem>
            <asp:ListItem>Lishu</asp:ListItem>
            <asp:ListItem>Songti</asp:ListItem>
            <asp:ListItem>Fangzhengshuti</asp:ListItem>
            <asp:ListItem>huawenxingkai</asp:ListItem>
            <asp:ListItem>youyuan</asp:ListItem>
            <asp:ListItem>kaiti</asp:ListItem>
            <asp:ListItem>huawencaiyun</asp:ListItem>
        </asp:RadioButtonList><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" /><br />
        <br />
        &nbsp;<asp:Label ID="Label1" runat="server" Height="23px" Text="Effect show here"
            Width="120px"></asp:Label>
    </form>
</body>
</html>
