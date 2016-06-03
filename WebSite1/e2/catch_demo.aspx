<%@ Page Language="C#" AutoEventWireup="true" CodeFile="catch_demo.aspx.cs" Inherits="catch_demo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="检测两整数除法运算异常处理练习"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="left: -253px; position: relative; top: 38px"
            Text="请输入数：" Width="151px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Style="left: -183px; position: relative;
            top: 55px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="left: -542px;
            position: relative; top: 107px" Text="测试计算" />
        <asp:Label ID="Label3" runat="server" ForeColor="Black" Height="19px" Style="left: -480px;
            position: relative; top: 107px" Text="Label" Width="174px"></asp:Label>

    
    </div>
    </form>
</body>
</html>
