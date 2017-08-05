Imports WebApp.Inquiries
Imports WebApp.SqlConn
Public Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim data As DataTable
        data = executeQuery("select top 1000 * from HumanResources.Employee", getConnection("Server = DESKTOP-1GH0JHK\WEBDEV; Database =  AdventureWorks2014; UID = sa; pwd = localadmin"))
    End Sub

    Private Sub getLostItemData()
    End Sub

End Class