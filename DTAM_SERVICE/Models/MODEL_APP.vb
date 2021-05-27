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
    Private _MAS_PATIENTGROUPRANK As New MAS_PATIENTGROUPRANK
    Public Property MAS_PATIENTGROUPRANK() As MAS_PATIENTGROUPRANK
        Get
            Return _MAS_PATIENTGROUPRANK
        End Get
        Set(ByVal value As MAS_PATIENTGROUPRANK)
            _MAS_PATIENTGROUPRANK = value
        End Set
    End Property
    Private _List_MAS_PATIENTGROUPRANK As New List(Of MAS_PATIENTGROUPRANK)
    Public Property List_MAS_PATIENTGROUPRANK() As List(Of MAS_PATIENTGROUPRANK)
        Get
            Return _List_MAS_PATIENTGROUPRANK
        End Get
        Set(ByVal value As List(Of MAS_PATIENTGROUPRANK))
            _List_MAS_PATIENTGROUPRANK = value
        End Set
    End Property
    Private _MAS_PRENAME As New MAS_PRENAME
    Public Property MAS_PRENAME() As MAS_PRENAME
        Get
            Return _MAS_PRENAME
        End Get
        Set(ByVal value As MAS_PRENAME)
            _MAS_PRENAME = value
        End Set
    End Property
    Private _List_MAS_PRENAME As New List(Of MAS_PRENAME)
    Public Property List_MAS_PRENAME() As List(Of MAS_PRENAME)
        Get
            Return _List_MAS_PRENAME
        End Get
        Set(ByVal value As List(Of MAS_PRENAME))
            _List_MAS_PRENAME = value
        End Set
    End Property
    Private _MAS_SEX As New MAS_SEX
    Public Property MAS_SEX() As MAS_SEX
        Get
            Return _MAS_SEX
        End Get
        Set(ByVal value As MAS_SEX)
            _MAS_SEX = value
        End Set
    End Property
    Private _List_MAS_SEX As New List(Of MAS_SEX)
    Public Property List_MAS_SEX() As List(Of MAS_SEX)
        Get
            Return _List_MAS_SEX
        End Get
        Set(ByVal value As List(Of MAS_SEX))
            _List_MAS_SEX = value
        End Set
    End Property
    Private _MAS_PATIENTGROUP As New MAS_PATIENTGROUP
    Public Property MAS_PATIENTGROUP() As MAS_PATIENTGROUP
        Get
            Return _MAS_PATIENTGROUP
        End Get
        Set(ByVal value As MAS_PATIENTGROUP)
            _MAS_PATIENTGROUP = value
        End Set
    End Property
    Private _List_MAS_PATIENTGROUP As New List(Of MAS_PATIENTGROUP)
    Public Property List_MAS_PATIENTGROUP() As List(Of MAS_PATIENTGROUP)
        Get
            Return _List_MAS_PATIENTGROUP
        End Get
        Set(ByVal value As List(Of MAS_PATIENTGROUP))
            _List_MAS_PATIENTGROUP = value
        End Set
    End Property
    Private _MAS_CHINESEYEAR As New MAS_CHINESEYEAR
    Public Property MAS_CHINESEYEAR() As MAS_CHINESEYEAR
        Get
            Return _MAS_CHINESEYEAR
        End Get
        Set(ByVal value As MAS_CHINESEYEAR)
            _MAS_CHINESEYEAR = value
        End Set
    End Property
    Private _List_MAS_CHINESEYEAR As New List(Of MAS_CHINESEYEAR)
    Public Property List_MAS_CHINESEYEAR() As List(Of MAS_CHINESEYEAR)
        Get
            Return _List_MAS_CHINESEYEAR
        End Get
        Set(ByVal value As List(Of MAS_CHINESEYEAR))
            _List_MAS_CHINESEYEAR = value
        End Set
    End Property
    Private _MAS_ABOGROUP As New MAS_ABOGROUP
    Public Property MAS_ABOGROUP() As MAS_ABOGROUP
        Get
            Return _MAS_ABOGROUP
        End Get
        Set(ByVal value As MAS_ABOGROUP)
            _MAS_ABOGROUP = value
        End Set
    End Property
    Private _List_MAS_ABOGROUP As New List(Of MAS_ABOGROUP)
    Public Property List_MAS_ABOGROUP() As List(Of MAS_ABOGROUP)
        Get
            Return _List_MAS_ABOGROUP
        End Get
        Set(ByVal value As List(Of MAS_ABOGROUP))
            _List_MAS_ABOGROUP = value
        End Set
    End Property
    Private _MAS_RHGROUP As New MAS_RHGROUP
    Public Property MAS_RHGROUP() As MAS_RHGROUP
        Get
            Return _MAS_RHGROUP
        End Get
        Set(ByVal value As MAS_RHGROUP)
            _MAS_RHGROUP = value
        End Set
    End Property
    Private _List_MAS_RHGROUP As New List(Of MAS_RHGROUP)
    Public Property List_MAS_RHGROUP() As List(Of MAS_RHGROUP)
        Get
            Return _List_MAS_RHGROUP
        End Get
        Set(ByVal value As List(Of MAS_RHGROUP))
            _List_MAS_RHGROUP = value
        End Set
    End Property
    Private _MAS_ELEMENTAL As New MAS_ELEMENTAL
    Public Property MAS_ELEMENTAL() As MAS_ELEMENTAL
        Get
            Return _MAS_ELEMENTAL
        End Get
        Set(ByVal value As MAS_ELEMENTAL)
            _MAS_ELEMENTAL = value
        End Set
    End Property
    Private _List_MAS_ELEMENTAL As New List(Of MAS_ELEMENTAL)
    Public Property List_MAS_ELEMENTAL() As List(Of MAS_ELEMENTAL)
        Get
            Return _List_MAS_ELEMENTAL
        End Get
        Set(ByVal value As List(Of MAS_ELEMENTAL))
            _List_MAS_ELEMENTAL = value
        End Set
    End Property
    Private _MAS_RACE As New MAS_RACE
    Public Property MAS_RACE() As MAS_RACE
        Get
            Return _MAS_RACE
        End Get
        Set(ByVal value As MAS_RACE)
            _MAS_RACE = value
        End Set
    End Property
    Private _List_MAS_RACE As New List(Of MAS_RACE)
    Public Property List_MAS_RACE() As List(Of MAS_RACE)
        Get
            Return _List_MAS_RACE
        End Get
        Set(ByVal value As List(Of MAS_RACE))
            _List_MAS_RACE = value
        End Set
    End Property
    Private _MAS_RELIGION As New MAS_RELIGION
    Public Property MAS_RELIGION() As MAS_RELIGION
        Get
            Return _MAS_RELIGION
        End Get
        Set(ByVal value As MAS_RELIGION)
            _MAS_RELIGION = value
        End Set
    End Property
    Private _List_MAS_RELIGION As New List(Of MAS_RELIGION)
    Public Property List_MAS_RELIGION() As List(Of MAS_RELIGION)
        Get
            Return _List_MAS_RELIGION
        End Get
        Set(ByVal value As List(Of MAS_RELIGION))
            _List_MAS_RELIGION = value
        End Set
    End Property
    Private _MAS_OCCUPATION As New MAS_OCCUPATION
    Public Property MAS_OCCUPATION() As MAS_OCCUPATION
        Get
            Return _MAS_OCCUPATION
        End Get
        Set(ByVal value As MAS_OCCUPATION)
            _MAS_OCCUPATION = value
        End Set
    End Property
    Private _List_MAS_OCCUPATION As New List(Of MAS_OCCUPATION)
    Public Property List_MAS_OCCUPATION() As List(Of MAS_OCCUPATION)
        Get
            Return _List_MAS_OCCUPATION
        End Get
        Set(ByVal value As List(Of MAS_OCCUPATION))
            _List_MAS_OCCUPATION = value
        End Set
    End Property
    Private _MAS_EDUCATIONLEVEL As New MAS_EDUCATIONLEVEL
    Public Property MAS_EDUCATIONLEVEL() As MAS_EDUCATIONLEVEL
        Get
            Return _MAS_EDUCATIONLEVEL
        End Get
        Set(ByVal value As MAS_EDUCATIONLEVEL)
            _MAS_EDUCATIONLEVEL = value
        End Set
    End Property
    Private _List_MAS_EDUCATIONLEVEL As New List(Of MAS_EDUCATIONLEVEL)
    Public Property List_MAS_EDUCATIONLEVEL() As List(Of MAS_EDUCATIONLEVEL)
        Get
            Return _List_MAS_EDUCATIONLEVEL
        End Get
        Set(ByVal value As List(Of MAS_EDUCATIONLEVEL))
            _List_MAS_EDUCATIONLEVEL = value
        End Set
    End Property
    Private _MAS_VSTATUS As New MAS_VSTATUS
    Public Property MAS_VSTATUS() As MAS_VSTATUS
        Get
            Return _MAS_VSTATUS
        End Get
        Set(ByVal value As MAS_VSTATUS)
            _MAS_VSTATUS = value
        End Set
    End Property
    Private _List_MAS_VSTATUS As New List(Of MAS_VSTATUS)
    Public Property List_MAS_VSTATUS() As List(Of MAS_VSTATUS)
        Get
            Return _List_MAS_VSTATUS
        End Get
        Set(ByVal value As List(Of MAS_VSTATUS))
            _List_MAS_VSTATUS = value
        End Set
    End Property
    Private _MAS_STATUS As New MAS_STATUS
    Public Property MAS_STATUS() As MAS_STATUS
        Get
            Return _MAS_STATUS
        End Get
        Set(ByVal value As MAS_STATUS)
            _MAS_STATUS = value
        End Set
    End Property
    Private _List_MAS_STATUS As New List(Of MAS_STATUS)
    Public Property List_MAS_STATUS() As List(Of MAS_STATUS)
        Get
            Return _List_MAS_STATUS
        End Get
        Set(ByVal value As List(Of MAS_STATUS))
            _List_MAS_STATUS = value
        End Set
    End Property
    Private _MAS_RELATIONSHIP As New MAS_RELATIONSHIP
    Public Property MAS_RELATIONSHIP() As MAS_RELATIONSHIP
        Get
            Return _MAS_RELATIONSHIP
        End Get
        Set(ByVal value As MAS_RELATIONSHIP)
            _MAS_RELATIONSHIP = value
        End Set
    End Property
    Private _List_MAS_RELATIONSHIP As New List(Of MAS_RELATIONSHIP)
    Public Property List_MAS_RELATIONSHIP() As List(Of MAS_RELATIONSHIP)
        Get
            Return _List_MAS_RELATIONSHIP
        End Get
        Set(ByVal value As List(Of MAS_RELATIONSHIP))
            _List_MAS_RELATIONSHIP = value
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
    Private _List_MEDICAL_RECORDS_INFORMATION As New List(Of MEDICAL_RECORDS_INFORMATION)
    Public Property List_MEDICAL_RECORDS_INFORMATION() As List(Of MEDICAL_RECORDS_INFORMATION)
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
    Private _List_MEDICAL_RECORDS_HISTORY_ALLERGIC As New List(Of MEDICAL_RECORDS_HISTORY_ALLERGIC)
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
    Private _List_MEDICAL_RECORDS_REPLACE_NAME_DRUG As New List(Of MEDICAL_RECORDS_REPLACE_NAME_DRUG)
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
    Private _List_MEDICAL_RECORDS_CHANGE_NAME As New List(Of MEDICAL_RECORDS_CHANGE_NAME)
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
    Private _List_MEDICAL_RECORDS_MEDIAFILE As New List(Of MEDICAL_RECORDS_MEDIAFILE)
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
