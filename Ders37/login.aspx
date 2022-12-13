<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }
        .auto-style2 {
            width: 226px;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                        <br />
                        <asp:View ID="View1" runat="server">
                            <table class="auto-style3">
                                <tr>
                                    <td>Kullanıcı</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox1" runat="server" Width="205px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Şifre</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server" Width="205px" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" ForeColor="#990033"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </asp:View>
                        <br />
                        <asp:View ID="View2" runat="server">
                            <table class="auto-style3">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="LinkButton1" runat="server">Oturumu Kapat</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:View>
                    </asp:MultiView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>