Public Class MODEL_APP

#Region "FIELD"
    Private _IDA As Integer = 0
    Public Property IDA() As Integer
        Get
            Return _IDA
        End Get
        Set(ByVal value As Integer)
            _IDA = value
        End Set
    End Property

    Private _GUID As String
    Public Property GUID() As String
        Get
            Return _GUID
        End Get
        Set(ByVal value As String)
            _GUID = value
        End Set
    End Property

    Private _USER As String
    Public Property USER() As String
        Get
            Return _USER
        End Get
        Set(ByVal value As String)
            _USER = value
        End Set
    End Property

    Private _EDIT_PLAN_IDA As Integer = 0
    Public Property EDIT_PLAN_IDA() As Integer
        Get
            Return _EDIT_PLAN_IDA
        End Get
        Set(ByVal value As Integer)
            _EDIT_PLAN_IDA = value
        End Set
    End Property

    Private _FK_IDA As Integer
    Public Property FK_IDA() As Integer
        Get
            Return _FK_IDA
        End Get
        Set(ByVal value As Integer)
            _FK_IDA = value
        End Set
    End Property

    Private _RESULT As String
    Public Property RESULT() As String
        Get
            Return _RESULT
        End Get
        Set(ByVal value As String)
            _RESULT = value
        End Set
    End Property

    Private _SERCHWORD As String
    Public Property SERCHWORD() As String
        Get
            Return _SERCHWORD
        End Get
        Set(ByVal value As String)
            _SERCHWORD = value
        End Set
    End Property

    Private _PATH_PDF As String
    Public Property PATH_PDF() As String
        Get
            Return _PATH_PDF
        End Get
        Set(ByVal value As String)
            _PATH_PDF = value
        End Set
    End Property

    Private _FUNC_RESULT As New Object
    Public Property FUNC_RESULT() As Object
        Get
            Return _FUNC_RESULT
        End Get
        Set(ByVal value As Object)
            _FUNC_RESULT = value
        End Set
    End Property


    Private _PROCESS_CODE As String
    Public Property PROCESS_CODE() As String
        Get
            Return _PROCESS_CODE
        End Get
        Set(ByVal value As String)
            _PROCESS_CODE = value
        End Set
    End Property

    Private _FUNC_CODE As String
    Public Property FUNC_CODE() As String
        Get
            Return _FUNC_CODE
        End Get
        Set(ByVal value As String)
            _FUNC_CODE = value
        End Set
    End Property

    Private _EVENT_ID As String
    Public Property EVENT_ID() As String
        Get
            Return _EVENT_ID
        End Get
        Set(ByVal value As String)
            _EVENT_ID = value
        End Set
    End Property

    Private _TR_ID As String = ""
    Public Property TR_ID() As String
        Get
            Return _TR_ID
        End Get
        Set(ByVal value As String)
            _TR_ID = value
        End Set
    End Property
    Private _CITIZEN_AUTHORIZE As String
    Public Property CITIZEN_AUTHORIZE() As String
        Get
            Return _CITIZEN_AUTHORIZE
        End Get
        Set(ByVal value As String)
            _CITIZEN_AUTHORIZE = value
        End Set
    End Property
    Private _CITIZEN_ID As String
    Public Property CITIZEN_ID() As String
        Get
            Return _CITIZEN_ID
        End Get
        Set(ByVal value As String)
            _CITIZEN_ID = value
        End Set
    End Property

    Private _PROCESS_ID As String
    Public Property PROCESS_ID() As String
        Get
            Return _PROCESS_ID
        End Get
        Set(ByVal value As String)
            _PROCESS_ID = value
        End Set
    End Property
    Private _NOTE As String
    Public Property NOTE() As String
        Get
            Return _NOTE
        End Get
        Set(ByVal value As String)
            _NOTE = value
        End Set
    End Property
    Private _MONTH As String
    Public Property MONTH() As String
        Get
            Return _MONTH
        End Get
        Set(ByVal value As String)
            _MONTH = value
        End Set
    End Property

    Private _YEAR As Integer = 0
    Public Property YEAR() As Integer
        Get
            Return _YEAR
        End Get
        Set(ByVal value As Integer)
            _YEAR = value
        End Set
    End Property

    Private _ROUND As Integer = 0
    Public Property ROUND() As Integer
        Get
            Return _ROUND
        End Get
        Set(ByVal value As Integer)
            _ROUND = value
        End Set
    End Property

    Private _CHK_APPV As Integer = 0
    Public Property CHK_APPV() As Integer
        Get
            Return _CHK_APPV
        End Get
        Set(ByVal value As Integer)
            _CHK_APPV = value
        End Set
    End Property

    Private _NEWCODE As String
    Public Property NEWCODE() As String
        Get
            Return _NEWCODE
        End Get
        Set(ByVal value As String)
            _NEWCODE = value
        End Set
    End Property

    Private _file As HttpPostedFileBase
    Public Property file() As HttpPostedFileBase
        Get
            Return _file
        End Get
        Set(ByVal value As HttpPostedFileBase)
            _file = value
        End Set
    End Property

    Private _para As String
    Public Property para() As String
        Get
            Return _para
        End Get
        Set(ByVal value As String)
            _para = value
        End Set
    End Property


    Private _SYSTEM_ID As String
    Public Property SYSTEM_ID() As String
        Get
            Return _SYSTEM_ID
        End Get
        Set(ByVal value As String)
            _SYSTEM_ID = value
        End Set
    End Property


    Private _STATUS_ID As String = "0"
    Public Property STATUS_ID() As String
        Get
            Return _STATUS_ID
        End Get
        Set(ByVal value As String)
            _STATUS_ID = value
        End Set
    End Property

    Private _path_result As String
    Public Property path_result() As String
        Get
            Return _path_result
        End Get
        Set(ByVal value As String)
            _path_result = value
        End Set
    End Property

    Private _FILE_NAME As String
    Public Property FILE_NAME() As String
        Get
            Return _FILE_NAME
        End Get
        Set(ByVal value As String)
            _FILE_NAME = value
        End Set
    End Property

    Private _ERR_ALERT As String
    Public Property ERR_ALERT() As String
        Get
            Return _ERR_ALERT
        End Get
        Set(ByVal value As String)
            _ERR_ALERT = value
        End Set
    End Property


#End Region

    Private _SET_PAGE_MAIN As Object
    Public Property SET_PAGE_MAIN() As Object
        Get
            Return _SET_PAGE_MAIN
        End Get
        Set(ByVal value As Object)
            _SET_PAGE_MAIN = value
        End Set
    End Property

    Private _SET_SUB_PAGE_MAIN As Object
    Public Property SET_SUB_PAGE_MAIN() As Object
        Get
            Return _SET_SUB_PAGE_MAIN
        End Get
        Set(ByVal value As Object)
            _SET_SUB_PAGE_MAIN = value
        End Set
    End Property

#Region "MASTER"

    Private _MAS_HELPDOC As New MAS_HELPDOC
    Public Property MAS_HELPDOC() As MAS_HELPDOC
        Get
            Return _MAS_HELPDOC
        End Get
        Set(ByVal value As MAS_HELPDOC)
            _MAS_HELPDOC = value
        End Set
    End Property

    Private _List_MAS_HELPDOC As New List(Of MAS_HELPDOC)
    Public Property List_MAS_HELPDOC() As List(Of MAS_HELPDOC)
        Get
            Return _List_MAS_HELPDOC
        End Get
        Set(ByVal value As List(Of MAS_HELPDOC))
            _List_MAS_HELPDOC = value
        End Set
    End Property

    Private _MAS_HELPDOCWORD As New MAS_HELPDOCWORD
    Public Property MAS_HELPDOCWORD() As MAS_HELPDOCWORD
        Get
            Return _MAS_HELPDOCWORD
        End Get
        Set(ByVal value As MAS_HELPDOCWORD)
            _MAS_HELPDOCWORD = value
        End Set
    End Property

    Private _List_MAS_HELPDOCWORD As New List(Of MAS_HELPDOCWORD)
    Public Property List_MAS_HELPDOCWORD() As List(Of MAS_HELPDOCWORD)
        Get
            Return _List_MAS_HELPDOCWORD
        End Get
        Set(ByVal value As List(Of MAS_HELPDOCWORD))
            _List_MAS_HELPDOCWORD = value
        End Set
    End Property
    Private _List_MAS_TYPEADDRESS As New List(Of MAS_TYPEADDRESS)
    Public Property List_MAS_TYPEADDRESS() As List(Of MAS_TYPEADDRESS)
        Get
            Return _List_MAS_TYPEADDRESS
        End Get
        Set(ByVal value As List(Of MAS_TYPEADDRESS))
            _List_MAS_TYPEADDRESS = value
        End Set
    End Property
    Private _List_MAS_HEAL As New List(Of MAS_HEAL)
    Public Property List_MAS_HEAL() As List(Of MAS_HEAL)
        Get
            Return _List_MAS_HEAL
        End Get
        Set(ByVal value As List(Of MAS_HEAL))
            _List_MAS_HEAL = value
        End Set
    End Property

    Private _List_MAS_NATION As New List(Of MAS_NATION)
    Public Property List_MAS_NATION() As List(Of MAS_NATION)
        Get
            Return _List_MAS_NATION
        End Get
        Set(ByVal value As List(Of MAS_NATION))
            _List_MAS_NATION = value
        End Set
    End Property

    Private _List_MAS_AMPHUR As New List(Of MAS_AMPHUR)
    Public Property List_MAS_AMPHUR() As List(Of MAS_AMPHUR)
        Get
            Return _List_MAS_AMPHUR
        End Get
        Set(ByVal value As List(Of MAS_AMPHUR))
            _List_MAS_AMPHUR = value
        End Set
    End Property

    Private _List_MAS_DISTRICT As New List(Of MAS_DISTRICT)
    Public Property List_MAS_DISTRICT() As List(Of MAS_DISTRICT)
        Get
            Return _List_MAS_DISTRICT
        End Get
        Set(ByVal value As List(Of MAS_DISTRICT))
            _List_MAS_DISTRICT = value
        End Set
    End Property

    Private _List_MAS_PROVINCE As New List(Of MAS_PROVINCE)
    Public Property List_MAS_PROVINCE() As List(Of MAS_PROVINCE)
        Get
            Return _List_MAS_PROVINCE
        End Get
        Set(ByVal value As List(Of MAS_PROVINCE))
            _List_MAS_PROVINCE = value
        End Set
    End Property

    Private _MAS_ORGANIZATION As New MAS_ORGANIZATION
    Public Property MAS_ORGANIZATION() As MAS_ORGANIZATION
        Get
            Return _MAS_ORGANIZATION
        End Get
        Set(ByVal value As MAS_ORGANIZATION)
            _MAS_ORGANIZATION = value
        End Set
    End Property
    Private _List_ORGANIZATION As New List(Of MAS_ORGANIZATION)
    Public Property List_ORGANIZATION() As List(Of MAS_ORGANIZATION)
        Get
            Return _List_ORGANIZATION
        End Get
        Set(ByVal value As List(Of MAS_ORGANIZATION))
            _List_ORGANIZATION = value
        End Set
    End Property


    Private _List_MAS_MC As New List(Of MAS_MC)
    Public Property List_MAS_MC() As List(Of MAS_MC)
        Get
            Return _List_MAS_MC
        End Get
        Set(ByVal value As List(Of MAS_MC))
            _List_MAS_MC = value
        End Set
    End Property

    Private _List_MAS_MC_MCPAYERNAME As New List(Of MAS_MC_MCPAYERNAME)
    Public Property List_MAS_MC_MCPAYERNAME() As List(Of MAS_MC_MCPAYERNAME)
        Get
            Return _List_MAS_MC_MCPAYERNAME
        End Get
        Set(ByVal value As List(Of MAS_MC_MCPAYERNAME))
            _List_MAS_MC_MCPAYERNAME = value
        End Set
    End Property

    Private _MAS_WAREHOUSE_SUBMAIN As New MAS_WAREHOUSE_SUBMAIN
    Public Property MAS_WAREHOUSE_SUBMAIN() As MAS_WAREHOUSE_SUBMAIN
        Get
            Return _MAS_WAREHOUSE_SUBMAIN
        End Get
        Set(ByVal value As MAS_WAREHOUSE_SUBMAIN)
            _MAS_WAREHOUSE_SUBMAIN = value
        End Set
    End Property

    Private _List_MAS_WAREHOUSE_SUBMAIN As New List(Of MAS_WAREHOUSE_SUBMAIN)
    Public Property List_MAS_WAREHOUSE_SUBMAIN() As List(Of MAS_WAREHOUSE_SUBMAIN)
        Get
            Return _List_MAS_WAREHOUSE_SUBMAIN
        End Get
        Set(ByVal value As List(Of MAS_WAREHOUSE_SUBMAIN))
            _List_MAS_WAREHOUSE_SUBMAIN = value
        End Set
    End Property

    Private _MAS_COUNTRY As New MAS_COUNTRY
    Public Property MAS_COUNTRY() As MAS_COUNTRY
        Get
            Return _MAS_COUNTRY
        End Get
        Set(ByVal value As MAS_COUNTRY)
            _MAS_COUNTRY = value
        End Set
    End Property
    Private _List_MAS_COUNTRY As New List(Of MAS_COUNTRY)
    Public Property List_MAS_COUNTRY() As List(Of MAS_COUNTRY)
        Get
            Return _List_MAS_COUNTRY
        End Get
        Set(ByVal value As List(Of MAS_COUNTRY))
            _List_MAS_COUNTRY = value
        End Set
    End Property
    Private _MAS_HOUSETYPE As New MAS_HOUSETYPE
    Public Property MAS_HOUSETYPE() As MAS_HOUSETYPE
        Get
            Return _MAS_HOUSETYPE
        End Get
        Set(ByVal value As MAS_HOUSETYPE)
            _MAS_HOUSETYPE = value
        End Set
    End Property
    Private _List_MAS_HOUSETYPE As New List(Of MAS_HOUSETYPE)
    Public Property List_MAS_HOUSETYPE() As List(Of MAS_HOUSETYPE)
        Get
            Return _List_MAS_HOUSETYPE
        End Get
        Set(ByVal value As List(Of MAS_HOUSETYPE))
            _List_MAS_HOUSETYPE = value
        End Set
    End Property
#End Region

#Region "MEDICAL_RECORD"

    Private _MEDICAL_RECORDS_INFORMATION As New MEDICAL_RECORDS_INFORMATION
    Public Property MEDICAL_RECORDS_INFORMATION() As MEDICAL_RECORDS_INFORMATION
        Get
            Return _MEDICAL_RECORDS_INFORMATION
        End Get
        Set(ByVal value As MEDICAL_RECORDS_INFORMATION)
            _MEDICAL_RECORDS_INFORMATION = value
        End Set
    End Property
    Private _List_MEDICAL_RECORDS_INFORMATION As List(Of MEDICAL_RECORDS_INFORMATION)
    Public Property NewProperty() As List(Of MEDICAL_RECORDS_INFORMATION)
        Get
            Return _List_MEDICAL_RECORDS_INFORMATION
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_INFORMATION))
            _List_MEDICAL_RECORDS_INFORMATION = value
        End Set
    End Property
    Private _MEDICAL_RECORDS_VALIDATE As New MEDICAL_RECORDS_VALIDATE
    Public Property MEDICAL_RECORDS_VALIDATE() As MEDICAL_RECORDS_VALIDATE
        Get
            Return _MEDICAL_RECORDS_VALIDATE
        End Get
        Set(ByVal value As MEDICAL_RECORDS_VALIDATE)
            _MEDICAL_RECORDS_VALIDATE = value
        End Set
    End Property

    Private _List_MEDICAL_RECORDS_VALIDATE As New List(Of MEDICAL_RECORDS_VALIDATE)
    Public Property List_MEDICAL_RECORDS_VALIDATE() As List(Of MEDICAL_RECORDS_VALIDATE)
        Get
            Return _List_MEDICAL_RECORDS_VALIDATE
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_VALIDATE))
            _List_MEDICAL_RECORDS_VALIDATE = value
        End Set
    End Property

    Private _MEDICAL_RECORDS_HISTORY_ALLERGIC As New MEDICAL_RECORDS_HISTORY_ALLERGIC
    Public Property MEDICAL_RECORDS_HISTORY_ALLERGIC() As MEDICAL_RECORDS_HISTORY_ALLERGIC
        Get
            Return _MEDICAL_RECORDS_HISTORY_ALLERGIC
        End Get
        Set(ByVal value As MEDICAL_RECORDS_HISTORY_ALLERGIC)
            _MEDICAL_RECORDS_HISTORY_ALLERGIC = value
        End Set
    End Property
    Private _List_MEDICAL_RECORDS_HISTORY_ALLERGIC As List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC)
    Public Property List_MEDICAL_RECORDS_HISTORY_ALLERGIC() As List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC)
        Get
            Return _List_MEDICAL_RECORDS_HISTORY_ALLERGIC
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC))
            _List_MEDICAL_RECORDS_HISTORY_ALLERGIC = value
        End Set
    End Property

    Private _MEDICAL_RECORDS_REPLACE_NAME_DRUG As New MEDICAL_RECORDS_REPLACE_NAME_DRUG
    Public Property MEDICAL_RECORDS_REPLACE_NAME_DRUG() As MEDICAL_RECORDS_REPLACE_NAME_DRUG
        Get
            Return _MEDICAL_RECORDS_REPLACE_NAME_DRUG
        End Get
        Set(ByVal value As MEDICAL_RECORDS_REPLACE_NAME_DRUG)
            _MEDICAL_RECORDS_REPLACE_NAME_DRUG = value
        End Set
    End Property
    Private _List_MEDICAL_RECORDS_REPLACE_NAME_DRUG As List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG)
    Public Property List_MEDICAL_RECORDS_REPLACE_NAME_DRUG() As List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG)
        Get
            Return _List_MEDICAL_RECORDS_REPLACE_NAME_DRUG
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG))
            _List_MEDICAL_RECORDS_REPLACE_NAME_DRUG = value
        End Set
    End Property

    Private _MEDICAL_RECORDS_CHANGE_NAME As New MEDICAL_RECORDS_CHANGE_NAME
    Public Property MEDICAL_RECORDS_CHANGE_NAME() As MEDICAL_RECORDS_CHANGE_NAME
        Get
            Return _MEDICAL_RECORDS_CHANGE_NAME
        End Get
        Set(ByVal value As MEDICAL_RECORDS_CHANGE_NAME)
            _MEDICAL_RECORDS_CHANGE_NAME = value
        End Set
    End Property
    Private _List_MEDICAL_RECORDS_CHANGE_NAME As List(Of MEDICAL_RECORDS_CHANGE_NAME)
    Public Property List_MEDICAL_RECORDS_CHANGE_NAME() As List(Of MEDICAL_RECORDS_CHANGE_NAME)
        Get
            Return _List_MEDICAL_RECORDS_CHANGE_NAME
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_CHANGE_NAME))
            _List_MEDICAL_RECORDS_CHANGE_NAME = value
        End Set
    End Property

    Private _MEDICAL_RECORDS_MEDIAFILE As New MEDICAL_RECORDS_MEDIAFILE
    Public Property MEDICAL_RECORDS_MEDIAFILE() As MEDICAL_RECORDS_MEDIAFILE
        Get
            Return _MEDICAL_RECORDS_MEDIAFILE
        End Get
        Set(ByVal value As MEDICAL_RECORDS_MEDIAFILE)
            _MEDICAL_RECORDS_MEDIAFILE = value
        End Set
    End Property
    Private _List_MEDICAL_RECORDS_MEDIAFILE As List(Of MEDICAL_RECORDS_MEDIAFILE)
    Public Property List_MEDICAL_RECORDS_MEDIAFILE() As List(Of MEDICAL_RECORDS_MEDIAFILE)
        Get
            Return _List_MEDICAL_RECORDS_MEDIAFILE
        End Get
        Set(ByVal value As List(Of MEDICAL_RECORDS_MEDIAFILE))
            _List_MEDICAL_RECORDS_MEDIAFILE = value
        End Set
    End Property

#End Region

End Class
