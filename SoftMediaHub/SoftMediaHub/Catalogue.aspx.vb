Imports System.Data
Imports System.Data.SqlClient
Public Class Catalogue
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        Try
            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\softmediadatabase.mdf;Integrated Security=True")
            Dim CommandString As String
            CommandString = "SELECT * FROM [Movies]"
            command = New SqlCommand(CommandString)
            command.CommandType = CommandType.Text
            command.Connection = connection
            command.Connection.Open()
            command.ExecuteNonQuery()
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim writing As String = ""
            If reader.HasRows Then
                While reader.Read
                    writing &= "<Table width=900><tr><ul><td> " & "<a href='description.aspx?Id=" & reader("movieId") & "'>" & "<img height=300 width=300 src=" & reader("Image") & " ></td>"
                    writing &= "<td>" & "<a href='description.aspx?Id=" & reader("movieId") & "'>" & "Product Name:" & " " & reader("movie_name") & " </li> <li>" & "Product Price:" & " R" & reader("price") & " </td><ul></tr></Table>"
                End While
                Place.Text = writing

            End If
            command.Connection.Close()
            command.Dispose()
            connection.Dispose()
        Catch EX As Exception
        End Try
    End Sub

End Class