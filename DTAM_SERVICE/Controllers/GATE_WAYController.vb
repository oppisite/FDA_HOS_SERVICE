Imports System.Web.Mvc
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports System.IO
Imports System.Xml.Serialization
Imports System.Xml

Namespace Controllers
    Public Class GATE_WAYController
        Inherits Controller

        ' GET: GATE_WAY
        Function Index() As ActionResult
            Return View()
        End Function

        Function GATEWAY_EXCHANGE_FDA(ByVal test As String) As JsonResult

            'Return Json(CODE_CENTER(MODEL), JsonRequestBehavior.AllowGet)
            Return Json(test, JsonRequestBehavior.AllowGet)
        End Function


        Async Function GATEWAY_EXCHANGE(ByVal MODEL As String) As Threading.Tasks.Task(Of JsonResult)
            Dim MODEL_APP As New MODEL_APP
            'Dim MODEL_POST As String
            'If (MODEL Is Nothing) Then
            '    MODEL_POST = Request.QueryString("MODEL")
            'End If
            Try

                Dim jss As New JavaScriptSerializer

                'If (MODEL IsNot Nothing) Then
                '    MODEL_APP = jss.Deserialize(JSON_CONVERT_DATE(MODEL), GetType(MODEL_APP))
                'Else
                '    MODEL_APP = jss.Deserialize(JSON_CONVERT_DATE(MODEL_POST), GetType(MODEL_APP))
                'End If

                MODEL_APP = jss.Deserialize(JSON_CONVERT_DATE(MODEL), GetType(MODEL_APP))
                For Each s As String In Request.Files
                    Dim postedFile As HttpPostedFileBase = Request.Files(s)
                    Dim filename As String = postedFile.FileName
                    MODEL_APP.file = postedFile
                    'PATHs = "E:\LOG\" & Path.GetFileName(postedFile.FileName)
                    'postedFile.SaveAs(filename)
                Next
                Dim json_model = Json(CODE_CENTER(MODEL_APP), JsonRequestBehavior.AllowGet)
                json_model.MaxJsonLength = Integer.MaxValue
                Return json_model
                'Return Json(CODE_CENTER(MODEL_APP), JsonRequestBehavior.AllowGet)
                'Dim b As Byte = Request.Files
            Catch ex As Exception
                MODEL_APP.RESULT = "กรุณาลองใหม่อีกครั้ง"
                Dim json_model = Json(MODEL_APP, JsonRequestBehavior.AllowGet)
                json_model.MaxJsonLength = Integer.MaxValue
                Return json_model
                'Return Json(MODEL, JsonRequestBehavior.AllowGet)
            End Try
        End Function

        'Function GET_ORGANIZATION(ByVal Serchword As String) As Object
        '    Dim CORE_FUNC As New CORE_FUNC
        '    Dim MODEL_APP As New MODEL_APP
        '    CORE_FUNC.GET_DATA_SERCH_MAS_ORGANIZATION_HOS(Serchword)
        '    Try

        '    Catch ex As Exception
        '        MODEL_APP.RESULT = "กรุณาลองใหม่อีกครั้ง"
        '        Dim json_model = Json(MODEL_APP, JsonRequestBehavior.AllowGet)
        '        json_model.MaxJsonLength = Integer.MaxValue
        '        Return json_model

        '    End Try
        'End Function

        Private Function CODE_CENTER(ByVal MODEL_APP As MODEL_APP) As MODEL_APP
            Dim CORE_FUNC As New CORE_FUNC
            'Dim Hpost As New CLS_H_POST
            'Dim LEAD As New CLS_LEAD

            Dim groups As Integer = 0

            Try
                'INSERT_MODEL_LOG(MODEL_APP, "START_FUNC", groups, "")
                Dim ar As Array = MODEL_APP.FUNC_CODE.Split(",")
                For i = 0 To ar.Length - 1
                    Select Case ar(i)
            '''''''''''''''''''''''''''''''''''''''''''''''' GET_OUTPATIENT  ''''''''''''''''''''''''''''''''''''''''''''''
                        Case "FUNC-OUTPATIENT-001-1"
                            MODEL_APP.List_MAS_HELPDOC = CORE_FUNC.GET_MAS_HELPDOC(MODEL_APP)
                        Case "FUNC-OUTPATIENT-002-1"
                            CORE_FUNC.BEFORE_INSERT_MAS_HELPDOC(MODEL_APP)
                            CORE_FUNC.INSERT_MAS_HELPDOC(MODEL_APP)
            '''''''''''''''''''''''''''''''''''''''''''''' GET_INFORADD  ''''''''''''''''''''''''''''''''''''''''''''''

                        Case "FUNC-INFOR-001-3"
                            MODEL_APP.List_MAS_HEAL = CORE_FUNC.GET_DATA_MAS_HEAL(MODEL_APP)
                            'MODEL_APP.List_ORGANIZATION = CORE_FUNC.GET_DATA_MAS_ORGANIZATION_HOS(MODEL_APP)
                            MODEL_APP.List_MAS_MC = CORE_FUNC.GET_DATA_MAS_MC(MODEL_APP)
                            MODEL_APP.List_MAS_MC_MCPAYERNAME = CORE_FUNC.GET_DATA_MAS_MC_MCPAYERNAME(MODEL_APP)
                            MODEL_APP.List_MEDICAL_RECORDS_VALIDATE = CORE_FUNC.GET_DATA_MEDI_VALIDATE_BY_IDA(MODEL_APP)
                            MODEL_APP.List_MAS_TYPEADDRESS = CORE_FUNC.GET_DATA_MAS_TYPEADDRESS(MODEL_APP)
                            MODEL_APP.List_MAS_PROVINCE = CORE_FUNC.GET_DATA_MAS_PROVINCE(MODEL_APP)
                            'MODEL_APP.LIST_
                            MODEL_APP.MEDICAL_RECORDS_INFORMATION = CORE_FUNC.GET_DATA_MEDI_INFOR_BY_IDA(MODEL_APP)
                            MODEL_APP.List_MAS_COUNTRY = CORE_FUNC.GET_DATA_MAS_COUNTRY(MODEL_APP)
                            MODEL_APP.List_MAS_HOUSETYPE = CORE_FUNC.GET_DATA_MAS_HOUSETYPE(MODEL_APP)
                        Case "FUNC-INFOR-001-4"
                            MODEL_APP.List_MAS_AMPHUR = CORE_FUNC.GET_DATA_MAS_AMPHUR(MODEL_APP)
                        Case "FUNC-INFOR-001-5"
                            MODEL_APP.List_MAS_DISTRICT = CORE_FUNC.GET_DATA_MAS_DISTRICT(MODEL_APP)
                        Case "FUNC-INFOR-002-1"
                            CORE_FUNC.INSERT_MEDICAL_CLAIM(MODEL_APP)
                        Case "FUNC-INFOR-002-2"
                            CORE_FUNC.INSERT_MEDICAL_ADDRESS(MODEL_APP)
                        Case "FUNC-INFOR-003-1"
                            MODEL_APP.List_ORGANIZATION = CORE_FUNC.GET_DATA_SERCH_MAS_ORGANIZATION_HOS(MODEL_APP.SERCHWORD)
                            '''''''''''''''''''''''''''''''''''''''''''''''' GET_MANAGE_MASTER  ''''''''''''''''''''''''''''''''''''''''''''''
                        Case "FUNC-MANAGE-001-3"
                            MODEL_APP.List_ORGANIZATION = CORE_FUNC.GET_DATA_MAS_ORGANIZATION_FACTORY(MODEL_APP)
                            MODEL_APP.List_MAS_AMPHUR = CORE_FUNC.GET_DATA_MAS_AMPHUR(MODEL_APP)
                            MODEL_APP.List_MAS_DISTRICT = CORE_FUNC.GET_DATA_MAS_DISTRICT(MODEL_APP)
                            MODEL_APP.List_MAS_PROVINCE = CORE_FUNC.GET_DATA_MAS_PROVINCE(MODEL_APP)
                        Case "FUNC-MANAGE-001-4"
                            MODEL_APP.MAS_ORGANIZATION = CORE_FUNC.GET_DATA_MAS_ORGANIZATION_BYIDA(MODEL_APP)
                            MODEL_APP.List_MAS_AMPHUR = CORE_FUNC.GET_DATA_MAS_AMPHUR(MODEL_APP)
                            MODEL_APP.List_MAS_DISTRICT = CORE_FUNC.GET_DATA_MAS_DISTRICT(MODEL_APP)
                            MODEL_APP.List_MAS_PROVINCE = CORE_FUNC.GET_DATA_MAS_PROVINCE(MODEL_APP)
                            MODEL_APP.List_MAS_NATION = CORE_FUNC.GET_DATA_MAS_NATION(MODEL_APP)
                        Case "FUNC-MANAGE-001-5"
                            MODEL_APP.List_ORGANIZATION = CORE_FUNC.GET_DATA_MAS_ORGANIZATION_VENDER(MODEL_APP)
                            MODEL_APP.List_MAS_AMPHUR = CORE_FUNC.GET_DATA_MAS_AMPHUR(MODEL_APP)
                            MODEL_APP.List_MAS_DISTRICT = CORE_FUNC.GET_DATA_MAS_DISTRICT(MODEL_APP)
                            MODEL_APP.List_MAS_PROVINCE = CORE_FUNC.GET_DATA_MAS_PROVINCE(MODEL_APP)
                        Case "FUNC-MANAGE-001-6"
                            MODEL_APP.List_ORGANIZATION = CORE_FUNC.GET_DATA_MAS_ORGANIZATION_VENDER(MODEL_APP)
                            MODEL_APP.List_MAS_AMPHUR = CORE_FUNC.GET_DATA_MAS_AMPHUR(MODEL_APP)
                            MODEL_APP.List_MAS_DISTRICT = CORE_FUNC.GET_DATA_MAS_DISTRICT(MODEL_APP)
                            MODEL_APP.List_MAS_PROVINCE = CORE_FUNC.GET_DATA_MAS_PROVINCE(MODEL_APP)
                        Case "FUNC-MANAGE-001-7"
                            MODEL_APP.List_MAS_WAREHOUSE_SUBMAIN = CORE_FUNC.GET_DATA_WAREHOUSE_SUBMAIN(MODEL_APP)
                        Case "FUNC-MANAGE-001-8"
                            MODEL_APP.MAS_WAREHOUSE_SUBMAIN = CORE_FUNC.GET_DATA_WAREHOUSE_SUBMAIN_BYIDA(MODEL_APP)
                        Case "FUNC-MANAGE-002-1"
                            CORE_FUNC.INSERT_MAS_ORGANIZATION(MODEL_APP)
                        Case "FUNC-MANAGE-002-2"
                            CORE_FUNC.INSERT_MAS_ORGANIZATION_VENDER(MODEL_APP)
                        Case "FUNC-MANAGE-002-3"
                            CORE_FUNC.INSERT_MAS_WAREHOUSE_SUBMAIN(MODEL_APP)
                        Case "FUNC-MANAGE-002-4"
                            CORE_FUNC.DELETE_MAS_WAREHOUSE_SUBMAIN(MODEL_APP)
                            MODEL_APP.List_MAS_WAREHOUSE_SUBMAIN = CORE_FUNC.GET_DATA_WAREHOUSE_SUBMAIN(MODEL_APP)
                        Case Else
                            MODEL_APP.RESULT = "ไม่พบฟังก์ชัน"
                    End Select
                Next


                'INSERT_MODEL_LOG(MODEL_APP, "END_FUNC", groups, "")

                Return MODEL_APP
            Catch ex As Exception
                MODEL_APP.ERR_ALERT = ex.Message
                'INSERT_MODEL_LOG(MODEL_APP, "FAIL_FUNC", groups, ex.ToString)
            End Try
            Return MODEL_APP
        End Function

        Private Function JSON_CONVERT_DATE(ByVal json As String) As String

            Dim reg = New Regex(""".*?""")
            Dim matches = reg.Matches(json)

            Dim temp As String = ""
            For Each item In matches
                If temp = "" Then
                    temp = item.ToString()
                Else
                    temp = temp & "," & item.ToString()
                End If
            Next

            Dim tempd As String = ""

            For Each ddd As String In temp.Split(",")
                If ddd.Contains("Date(") Then
                    If tempd = "" Then
                        tempd = ddd
                    Else
                        tempd = tempd & "," & ddd
                    End If
                End If
            Next

            For Each Val As String In tempd.Split(",")
                Try
                    Dim reg2 = New Regex("\(.*?\)")
                    Dim matches2 = reg2.Matches(Val)
                    For Each item2 In matches2
                        'item2 = {({(1050035680333)})}
                        Dim datas As String = item2.ToString().Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "")
                        Dim timestamp As Double = datas
                        Dim dateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
                        dateTime = dateTime.AddMilliseconds(timestamp)
                        If dateTime.Year > 2500 Then
                            json = json.Replace(Val, """" & dateTime.AddYears(-543).ToShortDateString() & """")
                        Else
                            Try

                            Catch ex As Exception

                            End Try
                            json = json.Replace(Val, """" & dateTime.ToShortDateString() & """")
                        End If

                    Next
                Catch ex As Exception

                End Try
            Next

            matches = reg.Matches(json)

            temp = ""
            For Each item In matches
                If temp = "" Then
                    temp = item.ToString()
                Else
                    temp = temp & "," & item.ToString()
                End If
            Next

            Dim tempd2 As String = ""
            For Each ddd As String In temp.Split(",")

                If ddd.Contains("/") Then
                    Dim aa As Array = ddd.Split("/")
                    If tempd2 = "" Then

                        If aa.Length >= 2 Then
                            tempd2 = ddd
                        End If

                    Else
                        If aa.Length >= 2 Then
                            tempd2 = tempd2 & "," & ddd
                        End If
                    End If

                End If
            Next
            For Each Val As String In tempd2.Split(",")

                Try
                    'Val = Val.Replace("""", "")
                    Dim ar As Array = Val.Replace("""", "").Split("/")
                    Dim chk_date As String = ""
                    Dim ar2 As Array = ar(2).ToString.Split(" ")
                    If ar2(0) > 2500 Then
                        ar2(0) = CInt(ar2(0)) - 543
                        Try

                            chk_date = ar(1) & "/" & ar(0) & "/" & ar2(0) & " " & ar2(1)

                        Catch ex As Exception
                            Try
                                chk_date = ar(1) & "/" & ar(0) & "/" & ar2(0)
                            Catch ex2 As Exception
                                chk_date = Val
                            End Try

                        End Try

                    Else
                        Try
                            chk_date = ar(0) & "/" & ar(1) & "/" & ar2(0) & " " & ar2(1)
                        Catch ex As Exception
                            Try
                                chk_date = ar(0) & "/" & ar(1) & "/" & ar2(0)
                            Catch ex2 As Exception
                                chk_date = Val
                            End Try
                        End Try

                    End If
                    json = json.Replace(Val, """" & chk_date & """")
                Catch ex As Exception

                End Try

            Next


            Return json
        End Function


    End Class
End Namespace