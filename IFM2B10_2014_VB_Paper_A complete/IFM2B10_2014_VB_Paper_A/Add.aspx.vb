Imports System.Data
Imports System.Data.SqlClient

Public Class Add
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim make As String = txtMake.Text
        Dim model As String = txtModel.Text
        Dim year As String = txtModel.Text
        Dim mileage As String = txtMileage.Text
        Dim sd As String = txtShortDescription.Text
        Dim fd As String = txtFullDescription.Text
        Dim img As String = "App_Media/noimage.jpg"
        Dim avai As String = txtAvailable.Text

        Dim connection As SqlConnection
        Dim command As SqlCommand

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
        command = New SqlCommand("INSERT INTO [Car] VALUES('" & make & "', '" & model & "','" & year & "', '" & mileage & "', '" & sd & "', '" & fd & "', '" & img & "', '" & avai & "'  )")
        command.CommandType = CommandType.Text
        command.Connection = connection
        command.Connection.Open()
        command.ExecuteNonQuery()

        Response.Redirect("CarCatalog.aspx")
        command.Connection.Close()
        command.Dispose()

    End Sub


    Protected Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

    End Sub
End Class