<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Admin.aspx.vb" Inherits="SoftMediaHub.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <p>
        Product info</p>
    <p style="margin-left: 40px">
        Product name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Product Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ProductPrice" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 40px">
        Quantity On Hand:&nbsp;
        <asp:TextBox ID="QuantityOnHand" runat="server"></asp:TextBox>
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product description
    <asp:TextBox ID="ProductDescription" runat="server"></asp:TextBox>
    <br />
    <p>
        <br />
        <asp:Button ID="Add" runat="server" Text="Add" />
        <asp:Button ID="Edit" runat="server" Text="Edit" />
        <asp:Button ID="Delete" runat="server" Text="Delete" />
    </p>
    <p>
    </p>
</asp:Content>
