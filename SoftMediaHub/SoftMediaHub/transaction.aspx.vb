Imports System.Data
Imports System.Data.SqlClient
Public Class transaction
    Inherits System.Web.UI.Page
    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private commandstring As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
        commandstring = "Select * From [shoppingcart]"

        command = New SqlCommand(commandstring)
        command.CommandType = CommandType.Text
        command.Connection = connection

        command.Connection.Open()
        command.ExecuteNonQuery()
        reader = command.ExecuteReader(CommandBehavior.CloseConnection)

        Label1.Text = "<table border=1><tr><td width=500px><h2>" & "INVOICE" & "<h2></td></tr></table>"
        Label2.Text = "<table border=1><tr><td width=500px><b>" & "SoftMediaHub" & "</br>" & "Tel:(011) 452 7895" & "</br>" & "Fax: (011) 452 7795" & "</br>" & "Email: softmedia@info.com" & "</br>" & "</br>" & "Invoice No: VN012" & "</br>" & "Date: 14-10-2015" & "</br>" & "</b></td></tr></table>"
        Label3.Text = "<table border=1><tr>" & "<tr><td width=150px>" & "Product Number" & "</td>" & "<td width=200px>" & "Product Name" & "</td>" & "<td width=150px>" & "Price" & "</td>" & "<td width=200px>" & "Description" & "</td>" & "<td width=150px>" & "Quantity" & "</td></tr>"
        If reader.HasRows Then
            Do While reader.Read
                Label2.Text &= "<tr><td>" & reader("ProductID") & "</td><td>" & reader("Product_Name") & "</td>" & "<td>" & reader("Price") & "</td>" & "<td>" & reader("Description") & "</td>" & "<td>" & "1" & "</td></tr>"
            Loop
        End If
        Label2.Text &= "</table>"
        Label3.Text = "<table border=1><tr><td width=150px><b><u>" & "TOTAL AMOUNT:" & "</u></b></td><td>" & " " & "</td></tr>" & "<tr><td width=150px>" & "Delivery Fee:" & "</td><td>" & "Free around Jahannesburg" & "</td></tr></table>"

        command.Connection.Close()
        command.Dispose()
        connection.Dispose()
    End Sub

End Class