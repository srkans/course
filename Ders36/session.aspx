<%@ Page Language="C#" AutoEventWireup="true" CodeFile="session.aspx.cs" Inherits="session" %>

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
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yaz" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Oku" />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Oturumu Kapat</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
