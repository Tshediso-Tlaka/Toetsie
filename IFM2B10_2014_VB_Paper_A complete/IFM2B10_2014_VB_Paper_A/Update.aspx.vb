Imports System.Data
Imports System.Data.SqlClient

Public Class Update
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim carID As String = Request.QueryString("CarID").ToString

            Dim connection As SqlConnection
            Dim command As SqlCommand
            Dim reader As SqlDataReader

            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
            command = New SqlCommand("SELECT * FROM[Car] WHERE CarID =@carID")
            command.Parameters.AddWithValue("@carID", carID)
            command.CommandType = CommandType.Text
            command.Connection = connection
            command.Connection.Open()
            command.ExecuteNonQuery()
            reader = command.ExecuteReader

            If reader.HasRows Then
                Do While reader.Read
                    txtMake.Text = reader("Make")
                    txtModel.Text = reader("Model")
                    txtYear.Text = reader("Year")
                    txtMileage.Text = reader("Mileage")
                    txtShortDescription.Text = reader("ShortDescription")
                    txtFullDescription.Text = reader("FullDescription")
                    txtImage.Text = reader("ImageLocation")
                    txtAvailable.Text = reader("isAvailable")
                Loop
            End If
            command.Connection.Close()
            command.Dispose()
            reader = Nothing
        End If

    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim carID As String = Request.QueryString("CarID").ToString

        Dim make As String = txtMake.Text
        Dim Model As String = txtModel.Text
        Dim y As String = txtYear.Text
        Dim mil As String = txtMileage.Text
        Dim sd As String = txtShortDescription.Text
        Dim fd As String = txtFullDescription.Text
        Dim image As String = txtImage.Text
        Dim a As String = txtImage.Text

        Dim connection As SqlConnection
        Dim command As SqlCommand

        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\RentalWiseDB.mdf;Integrated Security=True")
        command = New SqlCommand("UPDATE [Car] SET Make='" & make & "', Model= '" & Model & "',Year= '" & y & "',Mileage= '" & mil & "' ,ShortDescription= '" & sd & "', FullDescription= '" & fd & "' , ImageLocation= '" & image & "' ,isAvailable= '" & a & "' WHERE CarID = carID")
        command.CommandType = CommandType.Text
        command.Connection = connection
        command.Connection.Open()
        command.ExecuteNonQuery()

        Response.Redirect("CarCatalog.aspx")
        command.Connection.Close()
        command.Dispose()

    End Sub
End Class