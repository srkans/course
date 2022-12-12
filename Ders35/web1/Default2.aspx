<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="KitapID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="338px" Width="1055px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="KitapID" HeaderText="KitapID" InsertVisible="False" ReadOnly="True" SortExpression="KitapID" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                <asp:BoundField DataField="KitapAdi" HeaderText="KitapAdi" SortExpression="KitapAdi" />
                <asp:BoundField DataField="SayfaSayisi" HeaderText="SayfaSayisi" SortExpression="SayfaSayisi" />
                <asp:BoundField DataField="OzetBilgi" HeaderText="OzetBilgi" SortExpression="OzetBilgi" />
                <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" SortExpression="Fiyat" />
                <asp:BoundField DataField="YazarID" HeaderText="YazarID" SortExpression="YazarID" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CalismaConnectionString %>" DeleteCommand="DELETE FROM [Kitaplar] WHERE [KitapID] = @KitapID" InsertCommand="INSERT INTO [Kitaplar] ([ISBN], [KitapAdi], [SayfaSayisi], [OzetBilgi],  [Fiyat], [YazarID]) VALUES (@ISBN, @KitapAdi, @SayfaSayisi, @OzetBilgi, @Fiyat,@YazarID)" SelectCommand="SELECT * FROM [Kitaplar]" UpdateCommand="UPDATE Kitaplar SET ISBN = @ISBN, KitapAdi = @KitapAdi, SayfaSayisi = @SayfaSayisi, OzetBilgi = @OzetBilgi, Fiyat = @Fiyat, YazarID = @YazarID WHERE (KitapID = @KitapID)">
            <DeleteParameters>
                <asp:Parameter Name="KitapID" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ISBN" />
                <asp:Parameter Name="KitapAdi" />
                <asp:Parameter Name="SayfaSayisi" />
                <asp:Parameter Name="OzetBilgi" />
                <asp:Parameter Name="Fiyat" />
                <asp:Parameter Name="YazarID" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ISBN" />
                <asp:Parameter Name="KitapAdi" />
                <asp:Parameter Name="SayfaSayisi" />
                <asp:Parameter Name="OzetBilgi" />
                <asp:Parameter Name="Fiyat" />
                <asp:Parameter Name="YazarID" />
                <asp:Parameter Name="KitapID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="KitapID" DataSourceID="SqlDataSource1" InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <tr style="background-color: #FFFFFF;color: #284775;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="KitapIDLabel" runat="server" Text='<%# Eval("KitapID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                    </td>
                    <td>
                        <asp:Label ID="KitapAdiLabel" runat="server" Text='<%# Eval("KitapAdi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SayfaSayisiLabel" runat="server" Text='<%# Eval("SayfaSayisi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OzetBilgiLabel" runat="server" Text='<%# Eval("OzetBilgi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FiyatLabel" runat="server" Text='<%# Eval("Fiyat") %>' />
                    </td>
                    <td>
                        <asp:Label ID="YazarIDLabel" runat="server" Text='<%# Eval("YazarID") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #999999;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:Label ID="KitapIDLabel1" runat="server" Text='<%# Eval("KitapID") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ISBNTextBox" runat="server" Text='<%# Bind("ISBN") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="KitapAdiTextBox" runat="server" Text='<%# Bind("KitapAdi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="SayfaSayisiTextBox" runat="server" Text='<%# Bind("SayfaSayisi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="OzetBilgiTextBox" runat="server" Text='<%# Bind("OzetBilgi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FiyatTextBox" runat="server" Text='<%# Bind("Fiyat") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="YazarIDTextBox" runat="server" Text='<%# Bind("YazarID") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="ISBNTextBox" runat="server" Text='<%# Bind("ISBN") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="KitapAdiTextBox" runat="server" Text='<%# Bind("KitapAdi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="SayfaSayisiTextBox" runat="server" Text='<%# Bind("SayfaSayisi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="OzetBilgiTextBox" runat="server" Text='<%# Bind("OzetBilgi") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="FiyatTextBox" runat="server" Text='<%# Bind("Fiyat") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="YazarIDTextBox" runat="server" Text='<%# Bind("YazarID") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #E0FFFF;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="KitapIDLabel" runat="server" Text='<%# Eval("KitapID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                    </td>
                    <td>
                        <asp:Label ID="KitapAdiLabel" runat="server" Text='<%# Eval("KitapAdi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SayfaSayisiLabel" runat="server" Text='<%# Eval("SayfaSayisi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OzetBilgiLabel" runat="server" Text='<%# Eval("OzetBilgi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FiyatLabel" runat="server" Text='<%# Eval("Fiyat") %>' />
                    </td>
                    <td>
                        <asp:Label ID="YazarIDLabel" runat="server" Text='<%# Eval("YazarID") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                    <th runat="server"></th>
                                    <th runat="server">KitapID</th>
                                    <th runat="server">ISBN</th>
                                    <th runat="server">KitapAdi</th>
                                    <th runat="server">SayfaSayisi</th>
                                    <th runat="server">OzetBilgi</th>
                                    <th runat="server">Fiyat</th>
                                    <th runat="server">YazarID</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="KitapIDLabel" runat="server" Text='<%# Eval("KitapID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ISBNLabel" runat="server" Text='<%# Eval("ISBN") %>' />
                    </td>
                    <td>
                        <asp:Label ID="KitapAdiLabel" runat="server" Text='<%# Eval("KitapAdi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="SayfaSayisiLabel" runat="server" Text='<%# Eval("SayfaSayisi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OzetBilgiLabel" runat="server" Text='<%# Eval("OzetBilgi") %>' />
                    </td>
                    <td>
                        <asp:Label ID="FiyatLabel" runat="server" Text='<%# Eval("Fiyat") %>' />
                    </td>
                    <td>
                        <asp:Label ID="YazarIDLabel" runat="server" Text='<%# Eval("YazarID") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
