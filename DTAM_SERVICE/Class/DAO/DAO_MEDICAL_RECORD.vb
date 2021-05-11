Namespace DAO_MASTER

    Public MustInherit Class MAINCONTEXT2
        Public dbmedi As New Linq_MEDICAL_RECORDDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class

    Public Class TB_MEDICAL_RECORDS_VALIDATE
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_VALIDATE

        Private _Details As New List(Of MEDICAL_RECORDS_VALIDATE)
        Public Property Details() As List(Of MEDICAL_RECORDS_VALIDATE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_VALIDATE))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_VALIDATE
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_VALIDATEs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_VALIDATEs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmedi.MEDICAL_RECORDS_VALIDATEs Where p.ACTIVEFACT = True Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_VALIDATEs Where p.ACTIVEFACT = True And p.FK_IDA_INFOR = IDA And p.FK_IDA_INFOR <> 0 Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_VALIDATEs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub


    End Class

    Public Class TB_MEDICAL_RECORDS_INFORMATION
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_INFORMATION

        Private _Details As New List(Of MEDICAL_RECORDS_INFORMATION)
        Public Property Details() As List(Of MEDICAL_RECORDS_INFORMATION)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_INFORMATION))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_INFORMATION
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_INFORMATIONs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_INFORMATIONs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_MEDIINFOR_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_INFORMATIONs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_INFORMATIONs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

    End Class
End Namespace