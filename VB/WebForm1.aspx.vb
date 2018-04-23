Imports DevExpress.Data.ODataLinq
Imports ODataDemo
Imports System

Namespace Connect_to_OData_service
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim uri As New Uri("http://services.odata.org/V4/OData/OData.svc/")
            Dim container = New DemoService(uri)
            Dim source = New ODataServerModeSource With { _
                .KeyExpression = "ID", _
                .Query = container.Products _
            }
            BootstrapGridView1.DataSource = source
            BootstrapGridView1.DataBind()
        End Sub
    End Class
End Namespace