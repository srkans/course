<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Sayı1 :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
        <p>
            Sayı2 :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Topla" />
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Istanbul</asp:ListItem>
                <asp:ListItem>Ankara</asp:ListItem>
                <asp:ListItem>Izmir</asp:ListItem>
                <asp:ListItem>Kahramanmaraş</asp:ListItem>
                <asp:ListItem>Bursa</asp:ListItem>
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
