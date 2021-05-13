Public Class DAO_PAGE
    Public MustInherit Class MAINCONTEXT1
        Public dbpage As New Linq_SET_PAGEDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class

    Public Class TB_SET_PAGE_MAIN
        Inherits MAINCONTEXT1
        Public fields As New SET_PAGE_MAIN

        Private _Details As New List(Of SET_PAGE_MAIN)
        Public Property Details() As List(Of SET_PAGE_MAIN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_MAIN))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_MAIN
        End Sub
        Public Sub insert()
            dbpage.SET_PAGE_MAINs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.SET_PAGE_MAINs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL(ByVal type As Integer)
            datas = (From p In dbpage.SET_PAGE_MAINs Where p.TYPE_PEOPLE = type And p.ACTIVEFACT = 1 Select p Order By p.RID Ascending)
            'datas = (From p In dbpage.SET_PAGE_MAINs Where p.SYSTEM_ID = 1 And p.PROCESS_NAME = "LEAD" And p.ACTIVE_FACT = 1 Select p Order By p.PROCESS_ID, p.RID Ascending)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        'Public Sub GETDATA_BYIDA(ByVal IDA As String)
        '    datas = (From p In dbpage.SET_PAGE_MAINs Where p.ID = IDA And p.ACTIVE_FACT = True Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
    End Class

    Public Class TB_SET_PAGE_SUB_MAIN
        Inherits MAINCONTEXT1
        Public fields As New SET_PAGE_SUB_MAIN

        Private _Details As New List(Of SET_PAGE_SUB_MAIN)
        Public Property Details() As List(Of SET_PAGE_SUB_MAIN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of SET_PAGE_SUB_MAIN))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New SET_PAGE_SUB_MAIN
        End Sub
        Public Sub insert()
            dbpage.SET_PAGE_SUB_MAINs.InsertOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub
        Public Sub update()
            dbpage.SubmitChanges()
        End Sub
        Public Sub delete()
            dbpage.SET_PAGE_SUB_MAINs.DeleteOnSubmit(fields)
            dbpage.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL(ByVal type As Integer)
            datas = (From p In dbpage.SET_PAGE_SUB_MAINs Where p.FK_PAGE_MAIN = type And p.ACTIVEFACT = 1 Select p Order By p.RID Ascending)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        'Public Sub GETDATA_BYIDA(ByVal IDA As String)
        '    datas = (From p In dbpage.SET_PAGE_MAINs Where p.ID = IDA And p.ACTIVE_FACT = True Select p)
        '    For Each Me.fields In datas
        '    Next
        'End Sub
    End Class

End Class
