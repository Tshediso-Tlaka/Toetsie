<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="transaction.aspx.vb" Inherits="SoftMediaHub.transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        width: 220px;
    }
    .auto-style4 {
        width: 188px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:GridView id="GridView1" EnableSortingAndPagingCallbacks="True" 
      PageSize="5" GridLines="None" ForeColor="#333333" 
      DataSourceID="SqlDataSource1" DataKeyNames="CategoryID" 
      CellPadding="4" AutoGenerateColumns="False" 
      AllowSorting="True" AllowPaging="True" 
      runat="server">
        
   <FOOTERSTYLE ForeColor="White" Font-Bold="True" 
              BackColor="#5D7B9D" />
        <COLUMNS>
            <asp:BoundField SortExpression="CategoryName" 
                     HeaderText="CategoryName" 
                     DataField="CategoryName">
                <ITEMSTYLE Width="150px" />
            </asp:BoundField>
            <asp:BoundField SortExpression="Description" 
                    HeaderText="Description" 
                    DataField="Description">
                <ITEMSTYLE Width="250px" />
            </asp:BoundField>
            <asp:HyperLinkField Text="Edit" 
                    DataNavigateUrlFormatString="Default2.aspx?CID={0}" 
                    DataNavigateUrlFields="CategoryID">
                <ITEMSTYLE Width="50px" />
            </asp:HyperLinkField>
        </COLUMNS>
    <ROWSTYLE ForeColor="#333333" BackColor="#F7F6F3" />
    <EDITROWSTYLE BackColor="#999999" />
    <SELECTEDROWSTYLE ForeColor="#333333" 
                Font-Bold="True" BackColor="#E2DED6" />
    <PAGERSTYLE ForeColor="White" BackColor="#284775" 
                HorizontalAlign="Left" />
    <HEADERSTYLE ForeColor="White" Font-Bold="True" 
                BackColor="#5D7B9D" HorizontalAlign="Left" />
    <ALTERNATINGROWSTYLE ForeColor="#284775" BackColor="White" />
</asp:GridView>
<table class="auto-style1">
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button1" runat="server" style="margin-bottom: 0px" Text="Invoice" Width="160px" />
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Button ID="Button2" runat="server" Text="Proceed" Width="158px" />
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txtdiscription" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style4">
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<asp:SqlDataSource id="SqlDataSource1" runat="server" 
       SelectCommand="SELECT [CategoryID], [CategoryName], 
       [Description] FROM [Categories]" 
       ConnectionString="<%$ConnectionStrings:NorthwindConnectionString %>">
</asp:SqlDataSource>
   <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
        SelectCommand="SELECT [CategoryID], [CategoryName], 
           [Description] FROM [Categories] WHERE ([CategoryID] = @CategoryID)" 
        InsertCommand="INSERT INTO Categories (CategoryName, Description) 
                       VALUES (@CategoryName, @Description)" 
        UpdateCommand="UPDATE [Categories] SET 
           [CategoryName]= @CategoryName, [Description] = @Description 
           WHERE ([CategoryID] = @CategoryID)" 
       DataSourceMode="DataReader" 
       OnInserted="SqlDataSource1_Inserted" 
       OnInserting="SqlDataSource1_Inserting" 
       OnUpdated="SqlDataSource1_Updated" 
       OnUpdating="SqlDataSource1_Updating">
    <SelectParameters>
        <asp:QueryStringParameter Name="CategoryID" 
            QueryStringField="CID" Type="Int32" />
    </SelectParameters>
    <UpdateParameters>
        <asp:ControlParameter Name="CategoryName" 
            ControlID="txtName" />
        <asp:ControlParameter Name="Description" 
            ControlID="txtDesription" />
        <asp:QueryStringParameter Name="CategoryID" 
            QueryStringField="CID" 
            Type="Int32" />
    </UpdateParameters>
    <InsertParameters>
        <asp:ControlParameter Name="CategoryName" 
             ControlID="txtName" />
        <asp:ControlParameter Name="Description" 
            ControlID="txtDesription" />
    </InsertParameters>
</asp:SqlDataSource>
    Thank you for shopping with SoftMedia
</asp:Content>
