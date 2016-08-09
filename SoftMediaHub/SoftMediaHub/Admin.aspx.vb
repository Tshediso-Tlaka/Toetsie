Imports System.Data
Imports System.Data.SqlClient
Public Class Admin
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private commandstring As String
    Private prod_ID As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Session("Email_Address") Is Nothing Then
        '    Response.Redirect("LogInPage.aspx")
        'End If

        If Not Page.IsPostBack Then
            Try
                connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
                commandstring = "Select * From [music]"

                command = New SqlCommand(commandstring)
                command.CommandType = CommandType.Text
                command.Connection = connection

                command.Connection.Open()
                command.ExecuteNonQuery()
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)

                command.Connection.Close()
                command.Dispose()
                connection.Dispose()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Protected Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click

        Try
            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
            commandstring = "Insert Into [Music] values('" & CStr(ProductName.Text) & "', '" & CStr(ProductPrice.Text) & "','" & CStr(QuantityOnHand.Text) & "','" & CStr(ProductDescription.Text) & "')"

            command = New SqlCommand(commandstring)
            command.CommandType = CommandType.Text
            command.Connection = connection

            command.Connection.Open()
            command.ExecuteNonQuery()
            reader = command.ExecuteReader(CommandBehavior.CloseConnection)

            command.Connection.Close()
            command.Dispose()
            connection.Dispose()
        Catch ex As Exception
        End Try

        Response.Redirect("Catalogue.aspx")
    End Sub

    Protected Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click

        prod_ID = Request.QueryString("ProductID").ToString()
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
        commandstring = "SELECT * FROM [Music] where ProductID =" & prod_ID & "; "

        command = New SqlCommand(commandstring)
        command.CommandType = CommandType.Text
        command.Connection = connection

        command.Connection.Open()
        command.ExecuteNonQuery()
        reader = command.ExecuteReader(CommandBehavior.CloseConnection)

        If reader.HasRows Then
            Do While reader.Read
                ProductName.Text = reader("Product_Name")
                ProductPrice.Text = reader("Price")
                QuantityOnHand.Text = reader("Quantity_On_Hand")
                ProductDescription.Text = reader("Description")
            Loop
        End If

        command.Connection.Close()
        command.Dispose()
        connection.Dispose()

    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        prod_ID = Request.QueryString("ProductID").ToString()
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|softmediadatabase.mdf;Integrated Security=True")
        commandstring = "DELETE From [Music] where ProductID=" & prod_ID & ";"

        command = New SqlCommand(commandstring)
        command.CommandType = CommandType.Text
        command.Connection = connection

        command.Connection.Open()
        command.ExecuteNonQuery()
        reader = command.ExecuteReader(CommandBehavior.CloseConnection)

        command.Connection.Close()
        command.Dispose()
        connection.Dispose()

    End Sub

End Class