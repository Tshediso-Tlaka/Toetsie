Imports System.Data
Imports System.Data.SqlClient

Public Class Registration
    Inherits System.Web.UI.Page
    Private t As String
    Private FN As String
    Private Surname As String
    Private email As String
    Private username As String
    Private password As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSummit_Click(sender As Object, e As EventArgs) Handles btnSummit.Click
        t = ddlTitle.SelectedValue
        FN = txtFN.Text
        Surname = txtSurname.Text
        email = txtEmail.Text
        username = txtUsername.Text
        password = Secrecy.HashPassword(txtPassword.Text)


        If (password.Equals(Secrecy.HashPassword(txtConfirm.Text))) Then
            Dim connection As SqlConnection
            Dim command As SqlCommand

            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
            command = New SqlCommand("INSERT INTO [RentalManager] VALUES('" & t & "', '" & FN & "', '" & Surname & "','" & email & "', '" & username & "','" & password & "'  )")
            command.CommandType = CommandType.Text
            command.Connection = connection
            command.Connection.Open()
            command.ExecuteNonQuery()

            Response.Redirect("LogIn.aspx")
            command.Connection.Close()
            command.Dispose()
        Else
            lblMessage.Visible = True
            lblMessage.Text = "Password do not match"
        End If

    End Sub
End Class