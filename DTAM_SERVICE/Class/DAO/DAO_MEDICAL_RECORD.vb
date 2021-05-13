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

    Public Class TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_REPLACE_NAME_DRUG

        Private _Details As New List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG)
        Public Property Details() As List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_REPLACE_NAME_DRUG
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_REPLACE_NAME_DRUGs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_REPLACE_NAME_DRUGs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_MEDIINFOR_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_REPLACE_NAME_DRUGs Where p.ACTIVE = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_REPLACE_NAME_DRUGs Where p.ACTIVE = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

    End Class
    Public Class TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_HISTORY_ALLERGIC

        Private _Details As New List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC)
        Public Property Details() As List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_HISTORY_ALLERGIC
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_HISTORY_ALLERGICs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_HISTORY_ALLERGICs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_MEDIINFOR_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_HISTORY_ALLERGICs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_HISTORY_ALLERGICs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

    End Class
    Public Class TB_MEDICAL_RECORDS_CHANGE_NAME
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_CHANGE_NAME

        Private _Details As New List(Of MEDICAL_RECORDS_CHANGE_NAME)
        Public Property Details() As List(Of MEDICAL_RECORDS_CHANGE_NAME)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_CHANGE_NAME))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_CHANGE_NAME
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_CHANGE_NAMEs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_CHANGE_NAMEs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_MEDIINFOR_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_CHANGE_NAMEs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_CHANGE_NAMEs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

    End Class
    Public Class TB_MEDICAL_RECORDS_MEDIAFILE
        Inherits MAINCONTEXT2
        Public fields As New MEDICAL_RECORDS_MEDIAFILE

        Private _Details As New List(Of MEDICAL_RECORDS_MEDIAFILE)
        Public Property Details() As List(Of MEDICAL_RECORDS_MEDIAFILE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MEDICAL_RECORDS_MEDIAFILE))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MEDICAL_RECORDS_MEDIAFILE
        End Sub
        Public Sub insert()
            dbmedi.MEDICAL_RECORDS_MEDIAFILEs.InsertOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub
        Public Sub update()
            dbmedi.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmedi.MEDICAL_RECORDS_MEDIAFILEs.DeleteOnSubmit(fields)
            dbmedi.SubmitChanges()
        End Sub

        Public Sub GETDATA_MEDIINFOR_BY_FK_INFOR(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_MEDIAFILEs Where p.ACTIVE = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmedi.MEDICAL_RECORDS_MEDIAFILEs Where p.ACTIVE = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

    End Class
End Namespace