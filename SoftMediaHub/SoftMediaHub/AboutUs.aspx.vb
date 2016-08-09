Imports System.Data
Imports System.Data.SqlClient

Public Class AboutUs
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Display As String = ""

        Display = "<p>this is info about us fq;lh;firh;grothano;tn</p>"


        AboutUs.InnerHtml = Display

    End Sub

End Class