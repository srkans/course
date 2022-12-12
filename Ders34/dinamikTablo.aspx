<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dinamikTablo.aspx.cs" Inherits="dinamikTablo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Satır :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Sütun :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Olustur" />
    
    </div>
    </form>
</body>
</html>
