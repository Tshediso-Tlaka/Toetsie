<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="Login.aspx.vb" Inherits="SoftMediaHub.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 23px;
    }
        .auto-style3 {
            width: 334px;
        }
        .auto-style4 {
            height: 23px;
            width: 334px;
            text-align: right;
        }
        .auto-style5 {
            width: 334px;
            height: 26px;
            text-align: right;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 342px;
        }
        .auto-style8 {
            height: 23px;
            width: 342px;
        }
        .auto-style9 {
            height: 26px;
            width: 342px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4">Username:</td>
        <td class="auto-style8">
            <asp:TextBox ID="txtUsername" runat="server" Width="259px"></asp:TextBox>
        </td>
        <td class="auto-style2">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUsername" ErrorMessage="Please enter a username" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5">Password:</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="259px"></asp:TextBox>
        </td>
        <td class="auto-style6">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please enter a valid password" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style7">
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
            <asp:LinkButton ID="LinkButton1" runat="server">Register</asp:LinkButton>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
