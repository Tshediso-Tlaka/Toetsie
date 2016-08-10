<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MySiteMaster.Master" CodeBehind="Registration.aspx.vb" Inherits="IFM2B10_2014_VB_Paper_A.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlTitle"  runat="server">
                    <asp:ListItem  Selected="True">Mr.</asp:ListItem>
                    <asp:ListItem  Selected="false">Mrs.</asp:ListItem>
                    <asp:ListItem  Selected="false">Miss.</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
            </td>
        </tr>
        

        <tr>
            <td>
                <asp:Label ID="lblSurname" runat="server" Text="Surname"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblConfirmPassword" runat="server" Text="Re-enter password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnSummit" runat="server" Text="Summit" />
            </td>
        </tr>
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
    </table>
  
</asp:Content>
