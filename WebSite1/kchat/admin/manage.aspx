<%@ Page Language="C#" MasterPageFile="~/kchat/admin/MasterPage.master" AutoEventWireup="true" CodeFile="manage.aspx.cs" Inherits="kchat_admin_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
        AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
    <asp:BoundField DataField="user_id" HeaderText="user_id" InsertVisible="False" ReadOnly="True"
        SortExpression="user_id" />
    <asp:BoundField DataField="user_name" HeaderText="user_name" SortExpression="user_name" />
    <asp:BoundField DataField="user_password" HeaderText="user_password" SortExpression="user_password" />
    <asp:BoundField DataField="user_sex" HeaderText="user_sex" SortExpression="user_sex" />
    <asp:BoundField DataField="user_reg_time" HeaderText="user_reg_time" SortExpression="user_reg_time" />
    <asp:BoundField DataField="user_online" HeaderText="user_online" SortExpression="user_online" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kchatConnectionString %>"
        DeleteCommand="DELETE FROM [users] WHERE [user_id] = @user_id" InsertCommand="INSERT INTO [users] ([user_name], [user_password], [user_sex], [user_reg_time], [user_online]) VALUES (@user_name, @user_password, @user_sex, @user_reg_time, @user_online)"
        SelectCommand="SELECT * FROM [users]" UpdateCommand="UPDATE [users] SET [user_name] = @user_name, [user_password] = @user_password, [user_sex] = @user_sex, [user_reg_time] = @user_reg_time, [user_online] = @user_online WHERE [user_id] = @user_id">
        <DeleteParameters>
        <asp:Parameter Name="user_id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
        <asp:Parameter Name="user_name" Type="String" />
        <asp:Parameter Name="user_password" Type="String" />
        <asp:Parameter Name="user_sex" Type="String" />
        <asp:Parameter Name="user_reg_time" Type="String" />
        <asp:Parameter Name="user_online" Type="String" />
        <asp:Parameter Name="user_id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
    <asp:Parameter Name="user_name" Type="String" />
    <asp:Parameter Name="user_password" Type="String" />
    <asp:Parameter Name="user_sex" Type="String" />
    <asp:Parameter Name="user_reg_time" Type="String" />
    <asp:Parameter Name="user_online" Type="String" />
        </InsertParameters>
    </asp:SqlDataSource>
    <br />
    <br />
</asp:Content>

