Namespace DAO_MASTER

    Public MustInherit Class MAINCONTEXT1
        Public dbmas As New Linq_MASTERDataContext
        Public dbmedi As New Linq_MEDICAL_RECORDDataContext

        Public datas

        Public Interface MAIN
            Sub insert()
            Sub delete()
            Sub update()
        End Interface
    End Class

    Public Class TB_MAS_WAREHOUSE_SUBMAIN
        Inherits MAINCONTEXT1
        Public fields As New MAS_WAREHOUSE_SUBMAIN

        Private _Details As New List(Of MAS_WAREHOUSE_SUBMAIN)
        Public Property Details() As List(Of MAS_WAREHOUSE_SUBMAIN)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_WAREHOUSE_SUBMAIN))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_WAREHOUSE_SUBMAIN
        End Sub
        Public Sub insert()
            dbmas.MAS_WAREHOUSE_SUBMAINs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_WAREHOUSE_SUBMAINs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_WAREHOUSE_SUBMAINs Where p.ACTIVEFACT = True Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BYIDA(ByVal IDA As String)
            datas = (From p In dbmas.MAS_WAREHOUSE_SUBMAINs Where p.ID = IDA And p.ACTIVEFACT = True Select p)
            For Each Me.fields In datas
            Next
        End Sub
    End Class

    Public Class TB_MAS_AMPHUR
        Inherits MAINCONTEXT1
        Public fields As New MAS_AMPHUR

        Private _Details As New List(Of MAS_AMPHUR)
        Public Property Details() As List(Of MAS_AMPHUR)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_AMPHUR))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_AMPHUR
        End Sub
        Public Sub insert()
            dbmas.MAS_AMPHURs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_AMPHURs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_AMPHURs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub FILTER_BY_PROVINCE(ByVal IDA As String)
            datas = (From a In dbmas.MAS_PROVINCEs
                     Join p In dbmas.MAS_AMPHURs On a.PROVINCE_CODE Equals p.PROVINCE_ID
                     Where a.ID = IDA
                     Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_MAS_DISTRICT
        Inherits MAINCONTEXT1
        Public fields As New MAS_DISTRICT

        Private _Details As New List(Of MAS_DISTRICT)
        Public Property Details() As List(Of MAS_DISTRICT)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_DISTRICT))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_DISTRICT
        End Sub
        Public Sub insert()
            dbmas.MAS_DISTRICTs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_DISTRICTs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_DISTRICTs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub FILTER_BY_AMPHUR(ByVal IDA As String)
            datas = (From a In dbmas.MAS_AMPHURs
                     Join p In dbmas.MAS_DISTRICTs On a.AMPHUR_CODE Equals p.AMPHUR_ID
                     Where a.ID = IDA
                     Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_MAS_PROVINCE
        Inherits MAINCONTEXT1
        Public fields As New MAS_PROVINCE

        Private _Details As New List(Of MAS_PROVINCE)
        Public Property Details() As List(Of MAS_PROVINCE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_PROVINCE))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_PROVINCE
        End Sub
        Public Sub insert()
            dbmas.MAS_PROVINCEs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_PROVINCEs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_PROVINCEs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_MAS_HEAL
        Inherits MAINCONTEXT1
        Public fields As New MAS_HEAL

        Private _Details As New List(Of MAS_HEAL)
        Public Property Details() As List(Of MAS_HEAL)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_HEAL))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_HEAL
        End Sub
        Public Sub insert()
            dbmas.MAS_HEALs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_HEALs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_HEALs Where p.ACTIVEFLAG = True Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class

    Public Class TB_MAS_ORGANIZATION
        Inherits MAINCONTEXT1
        Public fields As New MAS_ORGANIZATION

        Private _Details As New List(Of MAS_ORGANIZATION)
        Public Property Details() As List(Of MAS_ORGANIZATION)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_ORGANIZATION))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_ORGANIZATION
        End Sub
        Public Sub insert()
            dbmas.MAS_ORGANIZATIONs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_ORGANIZATIONs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_ORGANIZATIONs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BYIDA(ByVal IDA As String)
            datas = (From p In dbmas.MAS_ORGANIZATIONs Where p.ORGANIZATION_ID = IDA Select p)
            For Each Me.fields In datas
            Next
        End Sub

        Public Sub GETDATA_FACTORY()
            datas = (From p In dbmas.MAS_ORGANIZATIONs Where p.ORGANIZATIONO_ISMANUFACTUREXTYPE = 1 Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_VENDER()
            datas = (From p In dbmas.MAS_ORGANIZATIONs Where p.ORGANIZATION_ISVENDORXTYPE = 1 Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_HOSPITAL()
            datas = (From p In dbmas.MAS_ORGANIZATIONs Where p.ORGANIZATION_ISHOSPITAL = 1 Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_SERCH_HOSPITAL(ByVal SERCH As String)
            datas = (From p In dbmas.MAS_ORGANIZATIONs Where p.ORGANIZATION_ISHOSPITAL = 1 And p.ORGANIZATION_ORGANIZATIONNAME.ToLower.Contains(SERCH.ToLower) Select p).Take(200)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub
    End Class

    Public Class TB_MAS_MC
        Inherits MAINCONTEXT1
        Public fields As New MAS_MC

        Private _Details As New List(Of MAS_MC)
        Public Property Details() As List(Of MAS_MC)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_MC))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_MC
        End Sub
        Public Sub insert()
            dbmas.MAS_MCs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_MCs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_MCs Where p.ACTIVEFLAG = True Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class

    Public Class TB_MAS_MC_MCPAYERNAME
        Inherits MAINCONTEXT1
        Public fields As New MAS_MC_MCPAYERNAME

        Private _Details As New List(Of MAS_MC_MCPAYERNAME)
        Public Property Details() As List(Of MAS_MC_MCPAYERNAME)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_MC_MCPAYERNAME))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_MC_MCPAYERNAME
        End Sub
        Public Sub insert()
            dbmas.MAS_MC_MCPAYERNAMEs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_MC_MCPAYERNAMEs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_MC_MCPAYERNAMEs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class

    Public Class TB_MAS_TYPEADDRESS
        Inherits MAINCONTEXT1
        Public fields As New MAS_TYPEADDRESS

        Private _Details As New List(Of MAS_TYPEADDRESS)
        Public Property Details() As List(Of MAS_TYPEADDRESS)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_TYPEADDRESS))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_TYPEADDRESS
        End Sub
        Public Sub insert()
            dbmas.MAS_TYPEADDRESSes.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_TYPEADDRESSes.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_TYPEADDRESSes Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class

    Public Class TB_MAS_NATION
        Inherits MAINCONTEXT1
        Public fields As New MAS_NATION

        Private _Details As New List(Of MAS_NATION)
        Public Property Details() As List(Of MAS_NATION)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_NATION))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_NATION
        End Sub
        Public Sub insert()
            dbmas.MAS_NATIONs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_NATIONs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_NATIONs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class

    Public Class TB_MAS_COUNTRY
        Inherits MAINCONTEXT1
        Public fields As New MAS_COUNTRY

        Private _Details As New List(Of MAS_COUNTRY)
        Public Property Details() As List(Of MAS_COUNTRY)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_COUNTRY))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_COUNTRY
        End Sub
        Public Sub insert()
            dbmas.MAS_COUNTRies.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_COUNTRies.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_COUNTRies Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        'Public Sub FILTER_BY_AMPHUR(ByVal IDA As String)
        '    datas = (From a In dbmas.MAS_AMPHURs
        '             Join p In dbmas.MAS_DISTRICTs On a.AMPHUR_CODE Equals p.AMPHUR_ID
        '             Where a.ID = IDA
        '             Select p)
        '    For Each Me.fields In datas
        '        AddDetails()
        '    Next
        'End Sub
    End Class
    Public Class TB_MAS_HOUSETYPE
        Inherits MAINCONTEXT1
        Public fields As New MAS_HOUSETYPE

        Private _Details As New List(Of MAS_HOUSETYPE)
        Public Property Details() As List(Of MAS_HOUSETYPE)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_HOUSETYPE))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_HOUSETYPE
        End Sub
        Public Sub insert()
            dbmas.MAS_HOUSETYPEs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_HOUSETYPEs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_HOUSETYPEs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        'Public Sub FILTER_BY_AMPHUR(ByVal IDA As String)
        '    datas = (From a In dbmas.MAS_AMPHURs
        '             Join p In dbmas.MAS_DISTRICTs On a.AMPHUR_CODE Equals p.AMPHUR_ID
        '             Where a.ID = IDA
        '             Select p)
        '    For Each Me.fields In datas
        '        AddDetails()
        '    Next
        'End Sub
    End Class

    Public Class TB_MAS_HELPDOC
        Inherits MAINCONTEXT1
        Public fields As New MAS_HELPDOC

        Private _Details As New List(Of MAS_HELPDOC)
        Public Property Details() As List(Of MAS_HELPDOC)
            Get
                Return _Details
            End Get
            Set(ByVal value As List(Of MAS_HELPDOC))
                _Details = value
            End Set
        End Property

        Private Sub AddDetails()
            Details.Add(fields)
            fields = New MAS_HELPDOC
        End Sub
        Public Sub insert()
            dbmas.MAS_HELPDOCs.InsertOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub
        Public Sub update()
            dbmas.SubmitChanges()
        End Sub
        Public Sub delete()
            dbmas.MAS_HELPDOCs.DeleteOnSubmit(fields)
            dbmas.SubmitChanges()
        End Sub

        Public Sub GETDATA_ALL()
            datas = (From p In dbmas.MAS_HELPDOCs Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_IDA(ByVal IDA As Integer)
            datas = (From p In dbmas.MAS_HELPDOCs Where p.ACTIVEFACT = True And p.IDA = IDA Select p)
            For Each Me.fields In datas
                'AddDetails()
            Next
        End Sub

        Public Sub GETDATA_BY_GUID(ByVal GUID As String)
            datas = (From p In dbmas.MAS_HELPDOCs Where p.ACTIVEFACT = True And p.GUID = GUID Select p)
            For Each Me.fields In datas
                AddDetails()
            Next
        End Sub

    End Class
End Namespace
