<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MySiteMaster.Master" CodeBehind="LogIn.aspx.vb" Inherits="IFM2B10_2014_VB_Paper_A.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
             </td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
               
        <tr>
            <td>
                <asp:Label ID="lblpassword" runat="server" Text="password"></asp:Label>
            </td>
            <td>
                 <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnLogIn" runat="server" Text="Log In" />
            </td>
            <td> 
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" />
            </td>
        </tr>

        <tr>
            <td>
             <asp:Label ID="lblMessage" runat="server" Text="message"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
