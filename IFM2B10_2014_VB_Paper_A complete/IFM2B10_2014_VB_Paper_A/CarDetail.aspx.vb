Imports System.Data
Imports System.Data.SqlClient

Public Class CarDetail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CarID As String = Request.QueryString("CarID").ToString() 'read url parameter

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
        command = New SqlCommand("SELECT * FROM [Car] WHERE CarID= @carID")
        command.Parameters.AddWithValue("@carID", CarID)
        command.CommandType = CommandType.Text
        command.Connection = connection
        command.Connection.Open()
        command.ExecuteNonQuery()
        reader = command.ExecuteReader()

        Dim display As String = ""

        If reader.HasRows Then
            display &= "<table>"
            Do While reader.Read
                display &= "<tr><td><img weight=200px height = 200px src= App_Media/" & reader("ImageLocation") & ">" & "</img></td></tr>" &
                           "<tr><td>Make :" & reader("Make") & "</td></tr>" &
                           "<tr><td>Model: " & reader("Model") & "</td></tr>" &
                           "<tr><td>Manufactured Year: " & reader("Year") & "</td></tr>" &
                           "<tr><td>Mileage: " & reader("Mileage") & "</td></tr>" &
                           "<tr><td>Short Description: " & reader("ShortDescription") & "</td></tr>" &
                           "<tr><td>Full Description: " & reader("FullDescription") & "</td></tr>" &
                           "<tr><td>Available: " & reader("isAvailable") & "</td></tr>"
            Loop
            display &= "</table>"
        End If

        Info.InnerHtml = display
        command.Connection.Close()
        command.Dispose()
        reader = Nothing

    End Sub

End Class