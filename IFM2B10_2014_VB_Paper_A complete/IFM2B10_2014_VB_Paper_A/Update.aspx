<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MySiteMaster.Master" CodeBehind="Update.aspx.vb" Inherits="IFM2B10_2014_VB_Paper_A.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table>
        <tr>
            <td>
               <asp:Label ID="lblMake" runat="server" Text="Make"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblModel" runat="server" Text="Model"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblYear" runat="server" Text="Year"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblMileage" runat="server" Text="Mileage"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblShortDescription" runat="server" Text="Short Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtShortDescription" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblFullDescription" runat="server" Text="Full Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFullDescription" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
               <asp:Label ID="lblImageLocation" runat="server" Text="Image Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtImage" runat="server"></asp:TextBox>
            </td>
        </tr>

        
        <tr>
            <td>
               <asp:Label ID="lblAvailable" runat="server" Text="isAvailable"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAvailable" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
            </td>
        </tr>
    </table>
</asp:Content>
