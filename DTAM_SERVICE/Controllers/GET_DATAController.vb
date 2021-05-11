Imports System.Web.Mvc

Namespace Controllers
    Public Class GET_DATAController
        Inherits Controller

        ' GET: GET_DATA
        'Function Index() As ActionResult
        '    Return View()
        'End Function

        Public Function SET_FULL_MODEL() As JsonResult
            Dim MODEL As MODEL_APP = New MODEL_APP()
            'Dim jss As JavaScriptSerializer = New JavaScriptSerializer()
            'Dim json_model = Json(MODEL, JsonRequestBehavior.AllowGet)
            'json_model.MaxJsonLength = Integer.MaxValue
            'Return json_model
            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace