Public Class LogOut
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsNothing(Session("firstName")) Then
            Session("Title") = Nothing
            Session("surname") = Nothing
            Session("email") = Nothing

            Response.Redirect("LogIn.aspx")
        End If
    End Sub

End Class