<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewState1.aspx.cs" Inherits="viewState1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AlbumID" DataSourceID="SqlDataSource1" Height="212px" Width="667px">
            <Columns>
                <asp:BoundField DataField="AlbumID" HeaderText="AlbumID" ReadOnly="True" SortExpression="AlbumID" />
                <asp:BoundField DataField="AlbumAdi" HeaderText="AlbumAdi" SortExpression="AlbumAdi" />
                <asp:BoundField DataField="Sanatci" HeaderText="Sanatci" SortExpression="Sanatci" />
                <asp:BoundField DataField="Tur" HeaderText="Tur" SortExpression="Tur" />
                <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" SortExpression="Fiyat" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CalismaaConnectionString %>" SelectCommand="SELECT * FROM [Album]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
