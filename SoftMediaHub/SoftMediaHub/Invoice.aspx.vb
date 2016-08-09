Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient

Public Class Invoice
    Inherits System.Web.UI.Page
    Private leftMargin, rightMargin, topMargin, bottomMargin, InvoiceWidth, InvoiceHeight, lenInvTitle As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lenInvTitle = 2
    End Sub
    Private Sub prnDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        leftMargin = Convert.ToInt32(e.MarginBounds.Left) ' leftMargin, rightMargin, ... Declared before
        rightMargin = Convert.ToInt32(e.MarginBounds.Right)
        topMargin = Convert.ToInt32(e.MarginBounds.Top)
        bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
        InvoiceWidth = Convert.ToInt32(e.MarginBounds.Width)
        InvoiceHeight = Convert.ToInt32(e.MarginBounds.Height)
        ' Draw Invoice Head
        SetInvoiceHead(e.Graphics)
    End Sub
    Private Sub SetInvoiceHead(ByVal g As Graphics)
        'Invoice title:
        Dim InvTitle As String = "International Food Company"
        'Title Font:
        Dim InvTitleFont As Font = New Font("Arial", 24, FontStyle.Regular)
        'Title Color:
        Dim HeadBrush As SolidBrush = New SolidBrush(Color.Blue)
        'Title Height:
        Dim InvTitleHeight As Integer = Convert.ToInt32(InvTitleFont.GetHeight(g))
        'Title Length:
        Dim lenInvTitle As Integer = Convert.ToInt32(g.MeasureString(InvTitle, InvTitleFont).Width)
        'Coordinate:
        Dim CurrentX As Integer = leftMargin +
        (InvoiceWidth - lenInvTitle) / 2 'to set the title in center 
        Dim CurrentY As Integer = topMargin + InvTitleHeight
        'draw the title:
        g.DrawString(InvTitle, InvTitleFont, HeadBrush, CurrentX, CurrentY)
    End Sub
End Class