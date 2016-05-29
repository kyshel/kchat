<%@ Page Language="C#" AutoEventWireup="true" CodeFile="e51.aspx.cs" Inherits="e5_e51" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" /><br />
        <asp:Label ID="Label1" runat="server" Height="71px" Text="Label" Width="211px"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kchatConnectionString %>" DeleteCommand="DELETE FROM [users] WHERE [user_id] = @user_id" InsertCommand="INSERT INTO [users] ([user_id], [user_name], [user_password_hash], [user_email]) VALUES (@user_id, @user_name, @user_password_hash, @user_email)" SelectCommand="SELECT [user_id], [user_name], [user_password_hash], [user_email] FROM [users]" UpdateCommand="UPDATE [users] SET [user_name] = @user_name, [user_password_hash] = @user_password_hash, [user_email] = @user_email WHERE [user_id] = @user_id">
            <DeleteParameters>
                <asp:Parameter Name="user_id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="user_name" Type="String" />
                <asp:Parameter Name="user_password_hash" Type="String" />
                <asp:Parameter Name="user_email" Type="String" />
                <asp:Parameter Name="user_id" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="user_id" Type="Int32" />
                <asp:Parameter Name="user_name" Type="String" />
                <asp:Parameter Name="user_password_hash" Type="String" />
                <asp:Parameter Name="user_email" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="user_id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="user_id" ReadOnly="True" SortExpression="user_id" />
                <asp:BoundField DataField="user_name" HeaderText="user_name" SortExpression="user_name" />
                <asp:BoundField DataField="user_password_hash" HeaderText="user_password_hash" SortExpression="user_password_hash" />
                <asp:BoundField DataField="user_email" HeaderText="user_email" SortExpression="user_email" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
