Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uName As String = txtUsername.Text
        Dim uPassword As String = Secrecy.HashPassword(txtPassword.Text)


        Dim Connection As SqlConnection
        Dim Command As SqlCommand
        Dim Reader As SqlDataReader

        Connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\SoftMediaDatabase.mdf;Integrated Security=True")

        Dim CommandString As String = "SELECT * FROM [Table]"


        Command = New SqlCommand(CommandString, Connection)
        Command.Parameters.AddWithValue("@Username", uName)
        Command.Parameters.AddWithValue("@Password", uPassword)

        Command.CommandType = CommandType.Text
        Command.Connection = Connection
        Command.Connection.Open()
        Command.ExecuteNonQuery()
        Reader = Command.ExecuteReader

        If Reader.HasRows Then
            While Reader.Read
                If Not uName = Reader("Username") Then
                    MsgBox("Username/Password is incorrect")
                ElseIf Not uPassword = Reader("Password") Then
                    MsgBox("Username/Password is incorrect")

                End If
            End While
            Response.Redirect("RegistrationPage.aspx")

            While Reader.Read
                'Create Session Variables
                Session.Add("uTitle", Reader("Title"))
                Session.Add("uSurname", Reader("Surname"))

            End While

        End If

        Command.Connection.Close()
        Command.Dispose()
        Connection.Dispose()

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("RegistrationPage.aspx")
    End Sub
End Class