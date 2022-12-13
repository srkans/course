<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uyeEkle.aspx.cs" Inherits="uyeEkle" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 24px;
        }
        .auto-style2 {
            margin-left: 27px;
        }
        .auto-style3 {
            margin-left: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Uye Adı<asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox>
    <br />
    Kullanıcı<asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox>
    <br />
    Şifre<asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style3"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ekle" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

