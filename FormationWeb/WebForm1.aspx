<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormationWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="359px">
    <table style="width: 100%; height: 176px;">
        <tr>
            <td style="width: 361px">
                <asp:TextBox ID="TextBox1" runat="server" Width="139px"></asp:TextBox>
            </td>
            <td style="width: 107px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 361px">
                <asp:TextBox ID="TextBox2" runat="server" Width="193px"></asp:TextBox>
            </td>
            <td style="width: 107px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 361px">&nbsp;</td>
            <td style="width: 107px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Panel>
</asp:Content>
