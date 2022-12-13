<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gridView.aspx.cs" Inherits="gridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="UyeID" DataSourceID="SqlDataSource1" Height="330px" Width="801px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="UyeID" HeaderText="UyeID" InsertVisible="False" ReadOnly="True" SortExpression="UyeID" />
                <asp:BoundField DataField="UyeTipID" HeaderText="UyeTipID" SortExpression="UyeTipID" />
                <asp:BoundField DataField="UyeAdi" HeaderText="UyeAdi" SortExpression="UyeAdi" />
                <asp:BoundField DataField="Kullanici" HeaderText="Kullanici" SortExpression="Kullanici" />
                <asp:BoundField DataField="Sifre" HeaderText="Sifre" SortExpression="Sifre" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CalismaConnectionString %>" DeleteCommand="DELETE FROM [Uyeler] WHERE [UyeID] = @UyeID" InsertCommand="NSERT INTO [Uyeler] ([UyeAdi], [Kullanici], [Sifre]) VALUES (@UyeAdi, @Kullanici, @Sifre)" SelectCommand="SELECT * FROM [Uyeler]" UpdateCommand="UPDATE [Uyeler] SET [UyeAdi] = @UyeAdi, [Kullanici] = @Kullanici, [Sifre] = @Sifre WHERE [UyeID] = @UyeID">
            <DeleteParameters>
                <asp:Parameter Name="UyeID" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="UyeAdi" />
                <asp:Parameter Name="Kullanici" />
                <asp:Parameter Name="Sifre" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="UyeAdi" />
                <asp:Parameter Name="Kullanici" />
                <asp:Parameter Name="Sifre" />
                <asp:Parameter Name="UyeID" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
