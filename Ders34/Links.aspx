<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Links.aspx.cs" Inherits="Links" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" BackColor="#FFFFCC" BorderColor="#CC3300" ForeColor="Blue" PostBackUrl="~/Default.aspx" Text="AnaSayfa" />
    
    </div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="59px" ImageUrl="~/Penguins.jpg" PostBackUrl="~/Default.aspx" Width="88px" />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Ana Sayfa</asp:LinkButton>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" Target="_blank">Ana Sayfa</asp:HyperLink>
    </form>
</body>
</html>
