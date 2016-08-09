Imports System.Data
Imports System.Data.SqlClient
Public Class Shoppingcart
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private commandstring As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") Is Nothing Then
            Label1.Text = "Login first to use shopping cart"
        End If

        If Not Page.IsPostBack Then

            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
            commandstring = "Select * From [shoppingcart]"

            command = New SqlCommand(commandstring)
            command.CommandType = CommandType.Text
            command.Connection = connection

            command.Connection.Open()
            command.ExecuteNonQuery()
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            Label2.Text = "<table border=5><tr><td width=873px><b>" & "Products you have added:" & "</b></td></tr></table>"
            Label2.Text = "<table border=5><tr>" & "<tr><td width=100px>" & "ProductID" & "</td>" & "<td width=200px>" & "Product_Name" & "</td>" & "<td width=150px>" & "Price" & "</td>" & "<td width=200px>" & "Description" & "</td></tr>"
            If reader.HasRows Then
                Do While reader.Read
                    Label2.Text &= "<tr><td>" & reader("Id") & "</td><td>" & reader("prodname") & "</td>" & "<td>" & reader("price") & "</td>" & "<td>" & reader("proddescription") & "</td></tr>"
                Loop
            End If
            Label2.Text &= "</table>"
            command.Connection.Close()
            command.Dispose()
            connection.Dispose()
        End If

    End Sub

End Class