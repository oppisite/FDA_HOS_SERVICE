Imports System.Web.Mvc

Namespace Controllers
    Public Class GET_DATAController
        Inherits Controller

        ' GET: GET_DATA
        'Function Index() As ActionResult
        '    Return View()
        'End Function
        Public Function GET_DATA_SET_PAGE_MAIN(ByVal Type As Integer) As Object
            Dim dao As New DAO_PAGE.TB_SET_PAGE_MAIN
            dao.GETDATA_ALL(Type)
            Return dao.Details
        End Function

        Public Function GET_DATA_SET_PAGE_SUB_MAIN(ByVal Type As Integer) As Object
            Dim dao As New DAO_PAGE.TB_SET_PAGE_SUB_MAIN
            dao.GETDATA_ALL(Type)
            Return dao.Details
        End Function
        Public Function SET_FULL_MODEL() As JsonResult
            Dim MODEL As MODEL_APP = New MODEL_APP()
            Try



                'Dim jss As JavaScriptSerializer = New JavaScriptSerializer()
                'Dim json_model = Json(MODEL, JsonRequestBehavior.AllowGet)
                'json_model.MaxJsonLength = Integer.MaxValue
                'Return json_model
                Dim typepeple As Integer = 1
                MODEL.SET_PAGE_MAIN = GET_DATA_SET_PAGE_MAIN(typepeple)
                'MODEL.SET_SUB_PAGE_MAIN = GET_DATA_SET_PAGE_SUB_MAIN(typepeple)
            Catch ex As Exception
                MODEL.ERR_ALERT = ex.Message
            End Try
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace