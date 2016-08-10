Imports System.Data
Imports System.Data.SqlClient

Public Class LogIn
    Inherits System.Web.UI.Page
    Private username As String
    Private password As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        username = txtUserName.Text
        password = Secrecy.HashPassword(txtpassword.Text)

        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
        command = New SqlCommand("SELECT * FROM [RentalManager] WHERE Username = '" & username & "' and Password = '" & password & "'  ")
        command.CommandType = CommandType.Text
        command.Connection = connection
        command.Connection.Open()
        reader = command.ExecuteReader

        If reader.HasRows Then
            Do While reader.Read
                Session.Add("title", reader("Title"))
                Session.Add("firstName", reader("FirstName"))
                Session.Add("surname", reader("Surname"))
                Session.Add("email", reader("Email"))
            Loop
            Response.Redirect("CarCatalog.aspx")
        Else
            lblMessage.Visible = True
            lblMessage.Text = "Incorrect password and password"
        End If

        command.Connection.Close()
        command.Dispose()
        reader = Nothing
    End Sub

    Protected Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        username = Nothing
        password = Nothing

        Response.Redirect("CarCatalog.aspx")
    End Sub
End Class