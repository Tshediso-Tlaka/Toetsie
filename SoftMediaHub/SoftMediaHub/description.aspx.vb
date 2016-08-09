Imports System.Data
Imports System.Data.SqlClient
Public Class description
    Inherits System.Web.UI.Page
    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private commandstring As String
    Private Prod_ID As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("password") Is Nothing Then
            addtocart.Visible = False

        End If

        If Not Page.IsPostBack Then
            Try
                Prod_ID = Request.QueryString("id").ToString()
                connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|SoftMediaDatabase.mdf;Integrated Security=True")
                commandstring = "Select * From [Music] where Id=" & Prod_ID & ";"

                command = New SqlCommand(commandstring)

                command.CommandType = CommandType.Text

                command.Connection = connection

                command.Connection.Open()

                command.ExecuteNonQuery()

                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Label1.Text = "<table border=5><tr><td width=100px>" & "ProductID" & "</td>" & "<td width=200px>" & "Product_Name" & "</td>" & "<td width=150px>" & "Price" & "</td>" & "<td width=150px>" & "</td>" & "<td width=200px>" & "Description" & "</td></tr>"
                If reader.HasRows Then
                    Do While reader.Read
                        Label1.Text &= "<tr><td>" & reader("id") & "</td>" & "<td>" & reader("name") & "</td>" & "<td>" & reader("Price") & "</td>" & "<td>" & reader("sundry") & "</td>" & "<td>" & reader("description") & "</td></tr>"
                    Loop
                End If
                Label1.Text &= "</table>"
                command.Connection.Close()
                command.Dispose()
                connection.Dispose()
            Catch ex As Exception

            End Try

        End If


    End Sub

End Class