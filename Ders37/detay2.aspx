<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detay2.aspx.cs" Inherits="detay2" MasterPageFile="~/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Session varsa içerik burada gösteriliyor. Diğer kısımlar masterpage&#39;de mevcut buradan düzenlenemiyor.</p>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Koala.jpg" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

