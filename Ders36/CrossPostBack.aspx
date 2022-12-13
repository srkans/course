<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossPostBack.aspx.cs" Inherits="CrossPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/detay2.aspx" Text="Button" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/detay2.aspx">LinkButton</asp:LinkButton>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/detay2.aspx">HyperLink</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
