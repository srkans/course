﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uploadFile.aspx.cs" Inherits="uploadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    
    </div>
    </form>
</body>
</html>
