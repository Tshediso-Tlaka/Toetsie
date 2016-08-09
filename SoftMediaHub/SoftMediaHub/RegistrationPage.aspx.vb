Imports System.Data
Imports System.Data.SqlClient
Public Class RegistrationPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connection As SqlConnection
        Dim command As SqlCommand

        Dim commandstring As String

        Dim HashedPassword As String = Secrecy.HashPassword(txtRePassword.Text)
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|SoftMediaDatabase.mdf;Integrated Security=True")
        commandstring = "Insert Into [Table] values( '" & CStr(DropDownList1.SelectedValue) & "' ,'" & CStr(txtFirstName.Text) & "', '" & CStr(txtSurname.Text) & "','" & CStr(txtEmail.Text) & "','" & CStr(txtUsername.Text) & "', '" & CStr(HashedPassword) & "','" & "1" & "')"

        command = New SqlCommand(commandstring)
        command.CommandType = CommandType.Text
        command.Connection = connection

        command.Connection.Open()
        command.ExecuteNonQuery()


        command.Connection.Close()
        command.Dispose()
        connection.Dispose()
        Response.Redirect("login.aspx")
    End Sub
End Class