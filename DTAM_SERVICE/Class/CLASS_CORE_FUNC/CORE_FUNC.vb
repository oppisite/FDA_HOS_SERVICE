Public Class CORE_FUNC

    Public Sub UpdateRegis(ByVal idInfor As Integer, ByVal fName As String, ByVal lName As String, ByVal idCard As String)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_REGISTER
        dao.GETDATA_MEDIREGIS_BY_FK_INFOR(idInfor)
        For Each itemRegis In dao.Details
            Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_REGISTER
            dao2.GETDATA_BY_IDA(itemRegis.IDA)
            dao2.fields.REGISTRATION_NAME = fName & " "c & lName
            dao2.fields.REGISTRATION_IDCARD = idCard
            dao2.fields.UPDATE_DATE = DateTime.Now
            'dao2.fields.UPDATE_USER = Session("userName").ToString()
            'dao2.fields.GUID_UPDATE = Session("guid").ToString()
            dao.update()
        Next
    End Sub
    Function INSERT_INFOR_ADD(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        Dim Up_IN As String
        If MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA = 0 Then

            Dim ynow As String = DateTime.Now.ToString("yyyy")   ' get ปี ปัจจุบัน
            Dim yint As Integer = Convert.ToInt32(ynow)
            Dim ystr As String = ""
            If (yint < 2500) Then ' check  ว่า เป็น คศ ไหม ถ้าเป็น ทำให้เป็น พศ โดย บวก 543

                yint = yint + 543
                ystr = yint.ToString()
                ynow = yint.ToString()

            Else
                ystr = yint.ToString()
            End If
            ynow = ynow.Substring(2, 2)

            Dim number As Integer = 0
            Dim hnSuc As String = ""
            Dim prescript As String = ""
            Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
            dao2.GETDATA_MEDIINFOR_BY_TYPE_HOSPTIAL(MODEL_APP.MEDICAL_RECORDS_INFORMATION.TYPE_HOSPTIAL, ystr)
            If dao2.datas IsNot Nothing Then

                Dim hosID As String = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TYPE_HOSPTIAL.ToString()
                Dim yearr As String = ynow
                number = dao2.datas + 1
                Dim s As String = number.ToString().PadLeft(6, "0")
                ' hnSuc = yearr + '-' + hosID + yearr + s;
                hnSuc = hosID + yearr + s
                prescript = String.Format("{0}-{1}{2}{3}", yearr, hosID, yearr, s)
            Else

                Dim hosID As String = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TYPE_HOSPTIAL.ToString()
                Dim yearr As String = ynow
                number = 1
                Dim s As String = number.ToString().PadLeft(6, "0")
                hnSuc = hosID + yearr + s
                prescript = String.Format("{0}-{1}{2}{3}", yearr, hosID, yearr, s)
            End If
            'If (.MEDICAL_RECORDS_INFORMATION.IDA == 0) Then ' ถ้ามี  ไอดี แสดงว่า มาจากการแก้ไข 

            MODEL_APP.MEDICAL_RECORDS_INFORMATION.DOCUMENT_NUMBER = prescript  ' ชื่อ folder ที่เก็บเอกสาร โดยใช้ hn ในการตั้งชื่อ
            'End If
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.FULLNAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FIRST_NAME + " " + MODEL_APP.MEDICAL_RECORDS_INFORMATION.LAST_NAME

            ystr = ystr.Substring(0, 2)
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.HN = ""
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.HNYEAR = ystr + ynow
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.HNNUMBER = Convert.ToInt32(number)
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.CREATE_DATE = DateTime.Now
            MODEL_APP.MEDICAL_RECORDS_INFORMATION.ACTIVEFACT = True
            'MODEL_APP.MEDICAL_RECORDS_INFORMATION.CREATE_USER = Session["userName"].ToString()
            ' MODEL_APP.MEDICAL_RECORDS_INFORMATION.GUID_CREATE = Session["guid"].ToString()
            ' MODEL_APP.MEDICAL_RECORDS_INFORMATION.USER_SERVICEUNIT = Convert.ToInt32(Session["userServiceUnit"].ToString())
            dao.fields = MODEL_APP.MEDICAL_RECORDS_INFORMATION
            dao.insert()
            Up_IN = 1
        Else
            dao.GETDATA_BY_IDA(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA)
            dao.fields.TITLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TITLE
            dao.fields.FIRST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FIRST_NAME
            dao.fields.LAST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.LAST_NAME
            dao.fields.IDENTIFICATION_CARD = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDENTIFICATION_CARD
            dao.fields.FULLNAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FIRST_NAME + " " + MODEL_APP.MEDICAL_RECORDS_INFORMATION.LAST_NAME
            dao.fields.TYPE_PATIENT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TYPE_PATIENT
            dao.fields.TYPE_HOSPTIAL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TYPE_HOSPTIAL
            dao.fields.HN = MODEL_APP.MEDICAL_RECORDS_INFORMATION.HN
            dao.fields.ALIEN = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ALIEN
            dao.fields.PASSPORT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PASSPORT
            dao.fields.VIP = MODEL_APP.MEDICAL_RECORDS_INFORMATION.VIP
            dao.fields.VIP_CATEGORY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.VIP_CATEGORY
            dao.fields.IDENTIFICATION_EXPIRED = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDENTIFICATION_EXPIRED
            dao.fields.IDENTIFICATION_OUT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDENTIFICATION_OUT
            dao.fields.SEX = MODEL_APP.MEDICAL_RECORDS_INFORMATION.SEX
            dao.fields.TWINS = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TWINS
            dao.fields.PATIENT_GROUP = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PATIENT_GROUP
            dao.fields.COUNT_DOC_PATIENT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.COUNT_DOC_PATIENT
            dao.fields.BIRTHDAY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.BIRTHDAY
            dao.fields.BIRTHDAY_THAI = MODEL_APP.MEDICAL_RECORDS_INFORMATION.BIRTHDAY_THAI
            dao.fields.BLOOD_TYPE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.BLOOD_TYPE
            dao.fields.RH = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RH
            dao.fields.STATUSOFLIFE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.STATUSOFLIFE
            dao.fields.DIE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.DIE
            dao.fields.ELEMENTAL_MAIN = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ELEMENTAL_MAIN
            dao.fields.ELEMENTAL_MINOR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ELEMENTAL_MINOR
            dao.fields.NATIONNALITY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.NATIONNALITY
            dao.fields.RACE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RACE
            dao.fields.RELIGION = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RELIGION
            dao.fields.CAREER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CAREER
            dao.fields.COMMUNITY_STATUS = MODEL_APP.MEDICAL_RECORDS_INFORMATION.COMMUNITY_STATUS
            dao.fields.TEL_PATIENT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TEL_PATIENT
            dao.fields.EMAIL_PATIENT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.EMAIL_PATIENT
            dao.fields.EDUCATION = MODEL_APP.MEDICAL_RECORDS_INFORMATION.EDUCATION
            dao.fields.WORKPLACE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.WORKPLACE
            dao.fields.DUTY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.DUTY
            dao.fields.RESERVE_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RESERVE_NAME
            dao.fields.RESERVE_TEL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RESERVE_TEL
            dao.fields.RESERVE_RERATIONSHIP = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RESERVE_RERATIONSHIP
            dao.fields.RESERVE_ADDRESS = MODEL_APP.MEDICAL_RECORDS_INFORMATION.RESERVE_ADDRESS
            dao.fields.ADDRESS_TYPE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ADDRESS_TYPE
            dao.fields.ADDRESS_TYPE_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ADDRESS_TYPE_NAME
            dao.fields.HOUSE_NO = MODEL_APP.MEDICAL_RECORDS_INFORMATION.HOUSE_NO
            dao.fields.SOI = MODEL_APP.MEDICAL_RECORDS_INFORMATION.SOI
            dao.fields.MOO = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MOO
            dao.fields.STREET = MODEL_APP.MEDICAL_RECORDS_INFORMATION.STREET
            dao.fields.DISTRICT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.DISTRICT
            dao.fields.DISTRICT_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.DISTRICT_NAME
            dao.fields.AMPHUR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.AMPHUR
            dao.fields.AMPHUR_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.AMPHUR_NAME
            dao.fields.PROVINCE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PROVINCE
            dao.fields.PROVINCE_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PROVINCE_NAME
            dao.fields.COUNTY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.COUNTY
            dao.fields.COUNTY_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.COUNTY_NAME
            dao.fields.ADDRESS_STYLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ADDRESS_STYLE
            dao.fields.ADDRESS_STYLE_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ADDRESS_STYLE_NAME
            dao.fields.ZIPCODE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ZIPCODE
            dao.fields.TEL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.TEL
            dao.fields.PHONE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PHONE
            dao.fields.EMAIL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.EMAIL
            dao.fields.CONTACT_ADDRESS_TYPE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_ADDRESS_TYPE
            dao.fields.CONTACT_HOUSE_NO = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_HOUSE_NO
            dao.fields.CONTACT_SOI = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_SOI
            dao.fields.CONTACT_MOO = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_MOO
            dao.fields.CONTACT_STREET = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_STREET
            dao.fields.CONTACT_DISTRICT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_DISTRICT
            dao.fields.CONTACT_DISTRICT_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_DISTRICT_NAME
            dao.fields.CONTACT_AMPHUR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_AMPHUR
            dao.fields.CONTACT_AMPHUR_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_AMPHUR_NAME
            dao.fields.CONTACT_PROVINCE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_PROVINCE
            dao.fields.CONTACT_PROVINCE_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_PROVINCE_NAME
            dao.fields.CONTACT_COUNTY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_COUNTY
            dao.fields.CONTACT_COUNTY_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_COUNTY_NAME
            dao.fields.CONTACT_ADDRESS_STYLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_ADDRESS_STYLE
            dao.fields.CONTACT_ZIPCODE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_ZIPCODE
            dao.fields.CONTACT_TEL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_TEL
            dao.fields.CONTACT_PHONE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_PHONE
            dao.fields.CONTACT_MAIL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONTACT_MAIL
            dao.fields.STATUS_ADDRESS = MODEL_APP.MEDICAL_RECORDS_INFORMATION.STATUS_ADDRESS
            dao.fields.MARRY_STATUS = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_STATUS
            dao.fields.MARRY_TITLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_TITLE
            dao.fields.MARRY_FIRST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_FIRST_NAME
            dao.fields.MARRY_LAST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_LAST_NAME
            dao.fields.MARRY_CAREER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_CAREER
            dao.fields.MARRY_IDENTIFICATION_CARD = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_IDENTIFICATION_CARD
            dao.fields.MARRY_NATIONALITY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MARRY_NATIONALITY
            dao.fields.FATHER_TITLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_TITLE
            dao.fields.FATHER_FIRST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_FIRST_NAME
            dao.fields.FATHER_LAST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_LAST_NAME
            dao.fields.FATHER_CAREER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_CAREER
            dao.fields.FATHER_IDENTIFICATION_CARD = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_IDENTIFICATION_CARD
            dao.fields.FATHER_NATIONALITY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_NATIONALITY
            dao.fields.MATHER_TITLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_TITLE
            dao.fields.MATHER_FIRST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_FIRST_NAME
            dao.fields.MATHER_LAST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_LAST_NAME
            dao.fields.MATHER_CAREER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_CAREER
            dao.fields.MATHER_IDENTIFICATION_CARD = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_IDENTIFICATION_CARD
            dao.fields.MATHER_NATIONALITY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MATHER_NATIONALITY
            dao.fields.OTHER_TITLE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_TITLE
            dao.fields.OTHER_FIRST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_FIRST_NAME
            dao.fields.OTHER_LAST_NAME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_LAST_NAME
            dao.fields.OTHER_CAREER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_CAREER
            dao.fields.OTHER_IDENTIFICATION_CARD = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_IDENTIFICATION_CARD
            dao.fields.OTHER_NATIONALITY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_NATIONALITY
            dao.fields.OTHER_PHONEHOME = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_PHONEHOME
            dao.fields.OTHER_PHONE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_PHONE
            dao.fields.WARNING_MESSAGE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.WARNING_MESSAGE
            dao.fields.FATHER_CONGENITIAL_DISORDER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FATHER_CONGENITIAL_DISORDER
            dao.fields.MOTHER_CONGENITIAL_DISORDER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MOTHER_CONGENITIAL_DISORDER
            dao.fields.OTHER_RELATIONSHIP = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OTHER_RELATIONSHIP
            dao.fields.ACTIVEFACT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.ACTIVEFACT
            dao.fields.DOCUMENT_NUMBER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.DOCUMENT_NUMBER
            dao.fields.OFFCIAL_NUMBER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.OFFCIAL_NUMBER
            dao.fields.PATH_FILE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.PATH_FILE
            dao.fields.HNYEAR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.HNYEAR
            dao.fields.HNNUMBER = MODEL_APP.MEDICAL_RECORDS_INFORMATION.HNNUMBER
            dao.fields.MINUTE_BIRTH = MODEL_APP.MEDICAL_RECORDS_INFORMATION.MINUTE_BIRTH
            dao.fields.HOUR_BIRTH = MODEL_APP.MEDICAL_RECORDS_INFORMATION.HOUR_BIRTH
            dao.fields.FIRST_NAME_EN = MODEL_APP.MEDICAL_RECORDS_INFORMATION.FIRST_NAME_EN
            dao.fields.LAST_NAME_EN = MODEL_APP.MEDICAL_RECORDS_INFORMATION.LAST_NAME_EN
            dao.fields.AGE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.AGE
            dao.fields.USER_SERVICEUNIT = MODEL_APP.MEDICAL_RECORDS_INFORMATION.USER_SERVICEUNIT
            dao.fields.USER_INVENTORY = MODEL_APP.MEDICAL_RECORDS_INFORMATION.USER_INVENTORY
            dao.fields.CONGENITALDISEASE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONGENITALDISEASE
            dao.fields.CONGENITALDISEASE_DETAIL = MODEL_APP.MEDICAL_RECORDS_INFORMATION.CONGENITALDISEASE_DETAIL
            dao.fields.REMARK = MODEL_APP.MEDICAL_RECORDS_INFORMATION.REMARK

            dao.fields.UPDATE_DATE = MODEL_APP.MEDICAL_RECORDS_INFORMATION.UPDATE_DATE
            'MODEL_APP.MEDICAL_RECORDS_INFORMATION.UPDATE_USER = Session["userName"].ToString();
            'MODEL_APP.MEDICAL_RECORDS_INFORMATION.GUID_UPDATE = Session["guid"].ToString();
            ' UpdateRegis(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA, MODEL_APP.MEDICAL_RECORDS_INFORMATION.FIRST_NAME, MODEL_APP.MEDICAL_RECORDS_INFORMATION.LAST_NAME, MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDENTIFICATION_CARD);
            dao.update()
            Up_IN = 2
        End If
        MODEL_APP.MEDICAL_RECORDS_INFORMATION = dao.fields
        INSERT_REPL_NAME_ADD(MODEL_APP)
        INSERT_MEDIHIST_ALLERGIC_ADD(MODEL_APP)
        INSERT_MEDICAL_ADDRESS(MODEL_APP, Up_IN)
        INSERT_MEDICHAN_NAME_ADD(MODEL_APP)
        Return MODEL_APP
    End Function
    Sub INSERT_REPL_NAME_ADD(ByVal MODEL_APP As MODEL_APP)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
        dao.GETDATA_BY_FK(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA)
        For Each item In dao.Details
            Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
            dao2.GETDATA_BY_IDA_ACTIVE(item.IDA)
            dao2.fields.ACTIVE = False
            dao2.fields.UPDATE_DATE = DateTime.Now
            'dao2.fields.UPDATE_USER = ""
            'dao2.fields.GUID_UPDATE = ""
            dao2.update()
        Next
        For Each item In MODEL_APP.List_MEDICAL_RECORDS_REPLACE_NAME_DRUG
            If item.IDA <> 0 Then
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
                dao2.GETDATA_BY_IDA(item.IDA)
                dao2.fields.R_TITLE = item.R_TITLE
                dao2.fields.R_FIRST_NAME = item.R_FIRST_NAME
                dao2.fields.R_LAST_NAME = item.R_LAST_NAME
                dao2.fields.R_RERATION = item.R_RERATION
                dao2.fields.R_TITLE_NAME = item.R_TITLE_NAME
                dao2.fields.R_RERATION_NAME = item.R_RERATION_NAME
                dao2.fields.USER_SERVICEUNIT = item.USER_SERVICEUNIT
                dao2.fields.USER_INVENTORY = item.USER_INVENTORY
                dao2.fields.ACTIVE = True
                dao2.fields.UPDATE_DATE = DateTime.Now
                dao2.fields.GUID_UPDATE = item.GUID_UPDATE
                dao2.fields.UPDATE_USER = item.UPDATE_USER
                dao2.update()
            Else
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
                item.CREATE_DATE = DateTime.Now
                item.FK_IDA_INFOR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA
                item.ACTIVE = True
                'item.CREATE_USER = ""
                'item.GUID_CREATE = ""
                dao2.fields = item
                dao2.insert()
            End If
        Next
    End Sub
    Sub INSERT_MEDIHIST_ALLERGIC_ADD(ByVal MODEL_APP As MODEL_APP)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
        dao.GETDATA_MEDIHIST_BY_FK(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA)
        For Each item In dao.Details
            Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
            dao2.GETDATA_BY_IDA_ACTIVE(item.IDA)
            dao2.fields.ACTIVEFACT = False
            dao2.fields.UPDATE_DATE = DateTime.Now
            'dao2.fields.UPDATE_USER = ""
            'dao2.fields.GUID_UPDATE = ""
            dao2.update()
        Next
        For Each item In MODEL_APP.List_MEDICAL_RECORDS_HISTORY_ALLERGIC
            If item.IDA <> 0 Then
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
                dao2.GETDATA_BY_IDA(item.IDA)
                dao2.fields.ALLERGIC = item.ALLERGIC
                dao2.fields.NAME_DRUG = item.NAME_DRUG
                dao2.fields.NOTE = item.NOTE
                dao2.fields.CONGENITALDISEASE = item.CONGENITALDISEASE
                dao2.fields.CONGENITALDISEASE_DETAIL = item.CONGENITALDISEASE_DETAIL
                dao2.fields.DETAIL_ALLERGIC = item.DETAIL_ALLERGIC
                dao2.fields.USER_SERVICEUNIT = item.USER_SERVICEUNIT
                dao2.fields.USER_INVENTORY = item.USER_INVENTORY
                dao2.fields.ACTIVEFACT = True
                dao2.fields.UPDATE_DATE = DateTime.Now
                dao2.fields.UPDATE_USER = item.UPDATE_USER
                dao2.fields.GUID_UPDATE = item.GUID_UPDATE
                dao2.update()
            Else
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
                item.CREATE_DATE = DateTime.Now
                item.FK_IDA_INFOR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA
                item.ACTIVEFACT = True
                'item.CREATE_USER = ""
                'item.GUID_CREATE = ""
                dao2.fields = item
                dao2.insert()
            End If
        Next
    End Sub
    Sub INSERT_MEDICHAN_NAME_ADD(ByVal MODEL_APP As MODEL_APP)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_CHANGE_NAME
        dao.GETDATA_MEDICHAGE_BY_FK_INFOR(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA)
        For Each item In dao.Details
            Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_CHANGE_NAME
            dao2.GETDATA_BY_IDA_ACTIVE(item.IDA)
            dao2.fields.ACTIVEFACT = False
            dao2.fields.UPDATE_DATE = DateTime.Now
            'dao2.fields.UPDATE_USER = ""
            'dao2.fields.GUID_UPDATE = ""
            dao2.update()
        Next
        For Each item In MODEL_APP.List_MEDICAL_RECORDS_CHANGE_NAME
            If item.IDA <> 0 Then
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_CHANGE_NAME
                dao2.GETDATA_BY_IDA(item.IDA)
                dao2.fields.C_CHANGEDATE_NAME = item.C_CHANGEDATE_NAME
                dao2.fields.C_NAME_OLD = item.C_NAME_OLD
                dao2.fields.C_TITLE = item.C_TITLE
                dao2.fields.C_FIRST_NAME = item.C_FIRST_NAME
                dao2.fields.C_LAST_NAME = item.C_LAST_NAME
                dao2.fields.C_OFFICER_CHANGE_NAME = item.C_OFFICER_CHANGE_NAME
                dao2.fields.C_NAME_PRESENT = item.C_NAME_PRESENT
                dao2.fields.C_TITLE_NAME = item.C_TITLE_NAME
                dao2.fields.USER_SERVICEUNIT = item.USER_SERVICEUNIT
                dao2.fields.USER_INVENTORY = item.USER_INVENTORY
                dao2.fields.ACTIVEFACT = True
                dao2.fields.UPDATE_DATE = DateTime.Now
                'dao2.fields.GUID_UPDATE = ""
                'dao2.fields.UPDATE_USER = ""
                dao2.update()
            Else
                Dim dao2 As New DAO_MASTER.TB_MEDICAL_RECORDS_CHANGE_NAME
                item.CREATE_DATE = DateTime.Now
                item.FK_IDA_INFOR = MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA
                item.ACTIVEFACT = True
                'item.CREATE_USER = ""
                'item.GUID_CREATE = ""
                dao2.fields = item
                dao2.insert()
            End If
            EDIT_NAME_REGIS(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA, item.C_FIRST_NAME, item.C_LAST_NAME)
            EDIT_NAME_INFOR(MODEL_APP.MEDICAL_RECORDS_INFORMATION.IDA, item.C_FIRST_NAME, item.C_LAST_NAME)
        Next


    End Sub

    Sub EDIT_NAME_REGIS(ByVal IDA As Integer, ByVal fname As String, ByVal lname As String)
        Dim dao_regis As New DAO_MASTER.TB_MEDICAL_RECORDS_REGISTER
        dao_regis.GETDATA_MEDIREGIS_BY_FK_INFOR(IDA)
        For Each item In dao_regis.Details()
            Dim dao_regis2 As New DAO_MASTER.TB_MEDICAL_RECORDS_REGISTER
            dao_regis2.GETDATA_BY_IDA(item.IDA)
            dao_regis2.fields.REGISTRATION_NAME = fname + " " + lname
            dao_regis2.fields.UPDATE_DATE = DateTime.Now
            dao_regis2.fields.ACTIVE = True
            '.UPDATE_USER = Session["userName"].ToString();
            '.GUID_UPDATE = Session["guid"].ToString();                   
            dao_regis2.update()
        Next
    End Sub
    Sub EDIT_NAME_INFOR(ByVal IDA As Integer, ByVal fname As String, ByVal lname As String)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        dao.GETDATA_BY_IDA(IDA)
        dao.fields.FULLNAME = fname + " " + lname
        dao.fields.FIRST_NAME = fname
        dao.fields.LAST_NAME = lname
        dao.update()
    End Sub

    Function GET_DATA_MAS_HEAL(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_HEAL
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_AMPHUR(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_AMPHUR
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim ID_PROVINCE = MODEL_APP.IDA
        dao.FILTER_BY_PROVINCE(ID_PROVINCE)
        Return dao.Details
    End Function

    Function GET_DATA_MAS_DISTRICT(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_DISTRICT
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA_AMPHUR = MODEL_APP.IDA
        dao.FILTER_BY_AMPHUR(IDA_AMPHUR)
        Return dao.Details
    End Function

    Function GET_DATA_MAS_PROVINCE(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_PROVINCE
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_ORGANIZATION(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_ORGANIZATION_FACTORY(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_FACTORY()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_ORGANIZATION_VENDER(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_VENDER()
        Return dao.Details
    End Function

    Function GET_DATA_SERCH_MAS_ORGANIZATION_HOS(ByVal SERCHWORD As String) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        'Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        'Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim SERCH = SERCHWORD
        dao.GETDATA_SERCH_HOSPITAL(SERCH)
        Return dao.Details
    End Function

    Function GET_DATA_MAS_ORGANIZATION_HOS(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_HOSPITAL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_ORGANIZATION_BYIDA(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
        Dim IDA = MODEL_APP.IDA
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_BYIDA(IDA)
        Return dao.fields
    End Function

    Function GET_DATA_MAS_NATION(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_NATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_MC(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_MC
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_MC_MCPAYERNAME(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_MC_MCPAYERNAME
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_TYPEADDRESS(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_TYPEADDRESS
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_COUNTRY(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_COUNTRY
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MAS_HOUSETYPE(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_HOUSETYPE
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_MEDI_VALIDATE_BY_IDA(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_VALIDATE
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_BY_FK_INFOR(IDA)
        Return dao.Details
    End Function

    Function GET_DATA_MEDI_INFOR_BY_IDA(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_BY_IDA(IDA)
        Return dao.fields
    End Function
    Function GET_DATA_MEDI_INFOR_ALL() As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        dao.GETDATA_ALL()
        Return dao.Details()
    End Function
    Function GET_DATA_MEDI_ALLERGIC_BY_FK(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_HISTORY_ALLERGIC
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_MEDIHIST_BY_FK(IDA)
        Return dao.Details
    End Function

    Function GET_DATA_MEDIREPL_NAME_BY_FK(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_REPLACE_NAME_DRUG
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_BY_FK(IDA)
        Return dao.Details
    End Function

    Function GET_DATA_MEDICHAG_NAME_BY_FK(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_CHANGE_NAME
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        'Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        'Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_MEDICHAGE_BY_FK_INFOR(IDA)
        Return dao.Details
    End Function

    Function GET_DATA_WAREHOUSE_SUBMAIN(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_PATIENTGROUPRANK(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_PATIENTGROUPRANK
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_SEX(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_SEX
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_PATIENTGROUP(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_PATIENTGROUP
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_CHINESEYEAR(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_CHINESEYEAR
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_ABOGROUP(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ABOGROUP
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_RHGROUP(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_RHGROUP
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_ELEMENTAL(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_ELEMENTAL
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_RACE(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_RACE
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_RELIGION(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_RELIGION
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_OCCUPATION(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_OCCUPATION
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_EDUCATIONLEVEL(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_EDUCATIONLEVEL
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_VSTATUS(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_VSTATUS
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_STATUS(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_STATUS
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_PRENAME(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_PRENAME
        dao.GETDATA_ALL()
        Return dao.Details
    End Function
    Function GET_DATA_MAS_RELATIONSHIP(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_RELATIONSHIP
        dao.GETDATA_ALL()
        Return dao.Details
    End Function

    Function GET_DATA_WAREHOUSE_SUBMAIN_BYIDA(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
        dao.GETDATA_BYIDA(IDA)
        Return dao.fields
    End Function

    Public Sub DELETE_MAS_WAREHOUSE_SUBMAIN(ByVal MODEL As MODEL_APP)
        Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
        dao.GETDATA_BYIDA(MODEL.IDA)
        dao.fields.ACTIVEFACT = False
        dao.fields.UPDATE_USER = MODEL.MAS_WAREHOUSE_SUBMAIN.UPDATE_USER
        dao.update()
    End Sub

    Public Sub INSERT_MAS_WAREHOUSE_SUBMAIN(ByVal MODEL As MODEL_APP)
        If MODEL.IDA = 0 Then
            Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
            dao.fields.HOSPITALMAIN_CODE = MODEL.MAS_WAREHOUSE_SUBMAIN.HOSPITALMAIN_CODE
            dao.fields.HOSPITALMAIN_NEME = MODEL.MAS_WAREHOUSE_SUBMAIN.HOSPITALMAIN_NEME
            dao.fields.HOUSE_NO = MODEL.MAS_WAREHOUSE_SUBMAIN.HOUSE_NO
            dao.fields.SOI = MODEL.MAS_WAREHOUSE_SUBMAIN.SOI
            dao.fields.STREET = MODEL.MAS_WAREHOUSE_SUBMAIN.STREET
            dao.fields.DISTRICT = MODEL.MAS_WAREHOUSE_SUBMAIN.DISTRICT
            dao.fields.AMPHUR = MODEL.MAS_WAREHOUSE_SUBMAIN.AMPHUR
            dao.fields.PROVINCE = MODEL.MAS_WAREHOUSE_SUBMAIN.PROVINCE
            dao.fields.COUNTY = MODEL.MAS_WAREHOUSE_SUBMAIN.COUNTY
            dao.fields.ADDRESS_STYLE = MODEL.MAS_WAREHOUSE_SUBMAIN.ADDRESS_STYLE
            dao.fields.ZIPCODE = MODEL.MAS_WAREHOUSE_SUBMAIN.ZIPCODE
            dao.fields.TEL = MODEL.MAS_WAREHOUSE_SUBMAIN.TEL
            dao.fields.PHONE = MODEL.MAS_WAREHOUSE_SUBMAIN.PHONE
            dao.fields.EMAIL = MODEL.MAS_WAREHOUSE_SUBMAIN.EMAIL
            dao.fields.NOTE = MODEL.MAS_WAREHOUSE_SUBMAIN.NOTE
            dao.fields.CREATE_USER = MODEL.MAS_WAREHOUSE_SUBMAIN.UPDATE_USER
            dao.fields.CREATE_DATE = DateTime.Now
            dao.fields.ACTIVEFACT = True
            dao.insert()
        Else
            Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
            dao.GETDATA_BYIDA(MODEL.IDA)
            dao.fields.HOSPITALMAIN_CODE = MODEL.MAS_WAREHOUSE_SUBMAIN.HOSPITALMAIN_CODE
            dao.fields.HOSPITALMAIN_NEME = MODEL.MAS_WAREHOUSE_SUBMAIN.HOSPITALMAIN_NEME
            dao.fields.HOUSE_NO = MODEL.MAS_WAREHOUSE_SUBMAIN.HOUSE_NO
            dao.fields.SOI = MODEL.MAS_WAREHOUSE_SUBMAIN.SOI
            dao.fields.STREET = MODEL.MAS_WAREHOUSE_SUBMAIN.STREET
            dao.fields.DISTRICT = MODEL.MAS_WAREHOUSE_SUBMAIN.DISTRICT
            dao.fields.AMPHUR = MODEL.MAS_WAREHOUSE_SUBMAIN.AMPHUR
            dao.fields.PROVINCE = MODEL.MAS_WAREHOUSE_SUBMAIN.PROVINCE
            dao.fields.COUNTY = MODEL.MAS_WAREHOUSE_SUBMAIN.COUNTY
            dao.fields.ADDRESS_STYLE = MODEL.MAS_WAREHOUSE_SUBMAIN.ADDRESS_STYLE
            dao.fields.ZIPCODE = MODEL.MAS_WAREHOUSE_SUBMAIN.ZIPCODE
            dao.fields.TEL = MODEL.MAS_WAREHOUSE_SUBMAIN.TEL
            dao.fields.PHONE = MODEL.MAS_WAREHOUSE_SUBMAIN.PHONE
            dao.fields.EMAIL = MODEL.MAS_WAREHOUSE_SUBMAIN.EMAIL
            dao.fields.NOTE = MODEL.MAS_WAREHOUSE_SUBMAIN.NOTE
            dao.fields.UPDATE_USER = MODEL.MAS_WAREHOUSE_SUBMAIN.UPDATE_USER
            dao.fields.UPDATE_DATE = DateTime.Now
            dao.fields.ACTIVEFACT = True
            dao.update()
        End If
    End Sub

    Public Sub INSERT_MAS_ORGANIZATION_VENDER(ByVal MODEL As MODEL_APP)
        If MODEL.IDA = 0 Then
            Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
            dao.fields.ORGANIZATION_ZIPCODE = MODEL.MAS_ORGANIZATION.ORGANIZATION_ZIPCODE
            dao.fields.ORGANIZATION_ORGANIZATIONNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ORGANIZATIONNAME
            dao.fields.ORGANIZATION_ENNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ENNAME
            dao.fields.ORGANIZATION_ADDRESS1 = MODEL.MAS_ORGANIZATION.ORGANIZATION_ADDRESS1
            dao.fields.MAS_NATION_ID = MODEL.MAS_ORGANIZATION.MAS_NATION_ID
            dao.fields.MAS_NATION_NAME = MODEL.MAS_ORGANIZATION.MAS_NATION_NAME
            dao.fields.MAS_PROVINCE_CODE = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_CODE
            dao.fields.MAS_PROVINCE_NAME = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_NAME
            dao.fields.MAS_AMPHUR_ID = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_ID
            dao.fields.MAS_AMPHUR_NAME = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_NAME
            dao.fields.MAS_DISTRICT_ID = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_ID
            dao.fields.MAS_DISTRICT_NAME = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_NAME
            dao.fields.POST_NAME = MODEL.MAS_ORGANIZATION.POST_NAME
            dao.fields.ORGANIZATION_PHONE = MODEL.MAS_ORGANIZATION.ORGANIZATION_PHONE
            dao.fields.ORGANIZATION_FAX = MODEL.MAS_ORGANIZATION.ORGANIZATION_FAX
            dao.fields.ORGANIZATION_WEBSITE = MODEL.MAS_ORGANIZATION.ORGANIZATION_WEBSITE
            dao.fields.ORGANIZATION_CONTACTNOTE = MODEL.MAS_ORGANIZATION.ORGANIZATION_CONTACTNOTE
            dao.fields.REMARK = MODEL.MAS_ORGANIZATION.REMARK
            dao.fields.ISUSE = MODEL.MAS_ORGANIZATION.ISUSE
            dao.fields.CREATE_DATE = DateTime.Now
            dao.fields.CREATE_USER = MODEL.MAS_ORGANIZATION.UPDATE_USER
            dao.fields.ORGANIZATION_ISVENDORXTYPE = 1
            dao.insert()
        Else
            Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
            dao.GETDATA_BYIDA(MODEL.IDA)
            dao.fields.ORGANIZATION_ZIPCODE = MODEL.MAS_ORGANIZATION.ORGANIZATION_ZIPCODE
            dao.fields.ORGANIZATION_ORGANIZATIONNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ORGANIZATIONNAME
            dao.fields.ORGANIZATION_ENNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ENNAME
            dao.fields.ORGANIZATION_ADDRESS1 = MODEL.MAS_ORGANIZATION.ORGANIZATION_ADDRESS1
            dao.fields.MAS_NATION_ID = MODEL.MAS_ORGANIZATION.MAS_NATION_ID
            dao.fields.MAS_NATION_NAME = MODEL.MAS_ORGANIZATION.MAS_NATION_NAME
            dao.fields.MAS_PROVINCE_CODE = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_CODE
            dao.fields.MAS_PROVINCE_NAME = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_NAME
            dao.fields.MAS_AMPHUR_ID = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_ID
            dao.fields.MAS_AMPHUR_NAME = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_NAME
            dao.fields.MAS_DISTRICT_ID = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_ID
            dao.fields.MAS_DISTRICT_NAME = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_NAME
            dao.fields.POST_NAME = MODEL.MAS_ORGANIZATION.POST_NAME
            dao.fields.ORGANIZATION_PHONE = MODEL.MAS_ORGANIZATION.ORGANIZATION_PHONE
            dao.fields.ORGANIZATION_FAX = MODEL.MAS_ORGANIZATION.ORGANIZATION_FAX
            dao.fields.ORGANIZATION_WEBSITE = MODEL.MAS_ORGANIZATION.ORGANIZATION_WEBSITE
            dao.fields.ORGANIZATION_CONTACTNOTE = MODEL.MAS_ORGANIZATION.ORGANIZATION_CONTACTNOTE
            dao.fields.REMARK = MODEL.MAS_ORGANIZATION.REMARK
            dao.fields.ISUSE = MODEL.MAS_ORGANIZATION.ISUSE
            dao.fields.UPDATE_DATE = DateTime.Now
            dao.fields.UPDATE_USER = MODEL.MAS_ORGANIZATION.UPDATE_USER
            dao.fields.ORGANIZATION_ISVENDORXTYPE = 1
            dao.update()
        End If
    End Sub


    Public Sub INSERT_MAS_ORGANIZATION(ByVal MODEL As MODEL_APP)
        If MODEL.IDA = 0 Then
            Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
            dao.fields.ORGANIZATION_ZIPCODE = MODEL.MAS_ORGANIZATION.ORGANIZATION_ZIPCODE
            dao.fields.ORGANIZATION_ORGANIZATIONNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ORGANIZATIONNAME
            dao.fields.ORGANIZATION_ENNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ENNAME
            dao.fields.ORGANIZATION_ADDRESS1 = MODEL.MAS_ORGANIZATION.ORGANIZATION_ADDRESS1
            dao.fields.MAS_NATION_ID = MODEL.MAS_ORGANIZATION.MAS_NATION_ID
            dao.fields.MAS_NATION_NAME = MODEL.MAS_ORGANIZATION.MAS_NATION_NAME
            dao.fields.MAS_PROVINCE_CODE = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_CODE
            dao.fields.MAS_PROVINCE_NAME = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_NAME
            dao.fields.MAS_AMPHUR_ID = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_ID
            dao.fields.MAS_AMPHUR_NAME = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_NAME
            dao.fields.MAS_DISTRICT_ID = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_ID
            dao.fields.MAS_DISTRICT_NAME = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_NAME
            dao.fields.POST_NAME = MODEL.MAS_ORGANIZATION.POST_NAME
            dao.fields.ORGANIZATION_PHONE = MODEL.MAS_ORGANIZATION.ORGANIZATION_PHONE
            dao.fields.ORGANIZATION_FAX = MODEL.MAS_ORGANIZATION.ORGANIZATION_FAX
            dao.fields.ORGANIZATION_WEBSITE = MODEL.MAS_ORGANIZATION.ORGANIZATION_WEBSITE
            dao.fields.ORGANIZATION_CONTACTNOTE = MODEL.MAS_ORGANIZATION.ORGANIZATION_CONTACTNOTE
            dao.fields.REMARK = MODEL.MAS_ORGANIZATION.REMARK
            dao.fields.ISUSE = MODEL.MAS_ORGANIZATION.ISUSE
            dao.fields.CREATE_DATE = DateTime.Now
            dao.fields.CREATE_USER = MODEL.USER
            dao.fields.ORGANIZATIONO_ISMANUFACTUREXTYPE = 1
            dao.insert()
        Else
            Dim dao As New DAO_MASTER.TB_MAS_ORGANIZATION
            dao.GETDATA_BYIDA(MODEL.IDA)
            dao.fields.ORGANIZATION_ZIPCODE = MODEL.MAS_ORGANIZATION.ORGANIZATION_ZIPCODE
            dao.fields.ORGANIZATION_ORGANIZATIONNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ORGANIZATIONNAME
            dao.fields.ORGANIZATION_ENNAME = MODEL.MAS_ORGANIZATION.ORGANIZATION_ENNAME
            dao.fields.ORGANIZATION_ADDRESS1 = MODEL.MAS_ORGANIZATION.ORGANIZATION_ADDRESS1
            dao.fields.MAS_NATION_ID = MODEL.MAS_ORGANIZATION.MAS_NATION_ID
            dao.fields.MAS_NATION_NAME = MODEL.MAS_ORGANIZATION.MAS_NATION_NAME
            dao.fields.MAS_PROVINCE_CODE = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_CODE
            dao.fields.MAS_PROVINCE_NAME = MODEL.MAS_ORGANIZATION.MAS_PROVINCE_NAME
            dao.fields.MAS_AMPHUR_ID = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_ID
            dao.fields.MAS_AMPHUR_NAME = MODEL.MAS_ORGANIZATION.MAS_AMPHUR_NAME
            dao.fields.MAS_DISTRICT_ID = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_ID
            dao.fields.MAS_DISTRICT_NAME = MODEL.MAS_ORGANIZATION.MAS_DISTRICT_NAME
            dao.fields.POST_NAME = MODEL.MAS_ORGANIZATION.POST_NAME
            dao.fields.ORGANIZATION_PHONE = MODEL.MAS_ORGANIZATION.ORGANIZATION_PHONE
            dao.fields.ORGANIZATION_FAX = MODEL.MAS_ORGANIZATION.ORGANIZATION_FAX
            dao.fields.ORGANIZATION_WEBSITE = MODEL.MAS_ORGANIZATION.ORGANIZATION_WEBSITE
            dao.fields.ORGANIZATION_CONTACTNOTE = MODEL.MAS_ORGANIZATION.ORGANIZATION_CONTACTNOTE
            dao.fields.REMARK = MODEL.MAS_ORGANIZATION.REMARK
            dao.fields.ISUSE = MODEL.MAS_ORGANIZATION.ISUSE
            dao.fields.UPDATE_DATE = DateTime.Now
            dao.fields.UPDATE_USER = MODEL.USER
            dao.fields.ORGANIZATIONO_ISMANUFACTUREXTYPE = 1
            dao.update()
        End If
    End Sub

    Public Sub INSERT_MEDICAL_CLAIM(ByVal MODEL As MODEL_APP)

        For Each item In MODEL.List_MEDICAL_RECORDS_VALIDATE
            If item.IDA = 0 Then
                Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_VALIDATE
                dao.fields.FK_IDA_INFOR = item.FK_IDA_INFOR
                dao.fields.TREATMENT_TYPE = item.TREATMENT_TYPE
                dao.fields.LICENSE_NUMBER = item.LICENSE_NUMBER
                dao.fields.PAYMENT = item.PAYMENT
                dao.fields.PAYMENT_DES = item.PAYMENT_DES
                dao.fields.PAYMENT_NAME = item.PAYMENT_NAME
                dao.fields.PAYMENT_NAME_DES = item.PAYMENT_NAME_DES
                dao.fields.COMPLETE_DOC = item.COMPLETE_DOC
                dao.fields.DATE_ISSUE = item.DATE_ISSUE
                dao.fields.EXPIRE_DATE = item.EXPIRE_DATE
                dao.fields.HOSPITAL_MAIN = item.HOSPITAL_MAIN
                dao.fields.HOSPITAL_MAIN_DES = item.HOSPITAL_MAIN_DES
                dao.fields.HOSPITAL_RESERVE = item.HOSPITAL_RESERVE
                dao.fields.HOSPITAL_RESERVE_DES = item.HOSPITAL_RESERVE_DES
                dao.fields.MAX_AMOUNT = item.MAX_AMOUNT
                dao.fields.AMOUNT_SPENT = item.AMOUNT_SPENT
                dao.fields.DESCRIPTION = item.DESCRIPTION
                dao.fields.NOT_ACTIVE = item.NOT_ACTIVE
                dao.fields.VALIDATE_MAIN = item.VALIDATE_MAIN
                dao.fields.VALIDATE_SECONDARY = item.VALIDATE_SECONDARY
                dao.fields.CREATE_DATE = Date.Now
                dao.fields.CREATE_USER = MODEL.USER
                dao.fields.ACTIVEFACT = True
                dao.insert()


            Else
                Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_VALIDATE
                dao.GETDATA_BY_IDA(item.IDA)
                dao.fields.FK_IDA_INFOR = item.FK_IDA_INFOR
                dao.fields.TREATMENT_TYPE = item.TREATMENT_TYPE
                dao.fields.LICENSE_NUMBER = item.LICENSE_NUMBER
                dao.fields.PAYMENT = item.PAYMENT
                dao.fields.PAYMENT_DES = item.PAYMENT_DES
                dao.fields.PAYMENT_NAME = item.PAYMENT_NAME
                dao.fields.PAYMENT_NAME_DES = item.PAYMENT_NAME_DES
                dao.fields.COMPLETE_DOC = item.COMPLETE_DOC
                dao.fields.DATE_ISSUE = item.DATE_ISSUE
                dao.fields.EXPIRE_DATE = item.EXPIRE_DATE
                dao.fields.HOSPITAL_MAIN = item.HOSPITAL_MAIN
                dao.fields.HOSPITAL_MAIN_DES = item.HOSPITAL_MAIN_DES
                dao.fields.HOSPITAL_RESERVE = item.HOSPITAL_RESERVE
                dao.fields.HOSPITAL_RESERVE_DES = item.HOSPITAL_RESERVE_DES
                dao.fields.MAX_AMOUNT = item.MAX_AMOUNT
                dao.fields.AMOUNT_SPENT = item.AMOUNT_SPENT
                dao.fields.DESCRIPTION = item.DESCRIPTION
                dao.fields.NOT_ACTIVE = item.NOT_ACTIVE
                dao.fields.VALIDATE_MAIN = item.VALIDATE_MAIN
                dao.fields.VALIDATE_SECONDARY = item.VALIDATE_SECONDARY
                dao.fields.UPDATE_DATE = Date.Now
                dao.fields.UPDATE_USER = MODEL.USER
                dao.fields.ACTIVEFACT = True
                dao.update()
            End If

        Next
    End Sub

    Public Sub INSERT_MEDICAL_ADDRESS(ByVal MODEL As MODEL_APP, ByVal chk As String)
        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        Dim IDA_INFOR As Integer = MODEL.MEDICAL_RECORDS_INFORMATION.IDA
        If (IDA_INFOR <> 0) Then
            dao.GETDATA_BY_IDA(IDA_INFOR)
            dao.fields.ADDRESS_TYPE = MODEL.MEDICAL_RECORDS_INFORMATION.ADDRESS_TYPE
            dao.fields.ADDRESS_TYPE_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.ADDRESS_TYPE_NAME
            dao.fields.HOUSE_NO = MODEL.MEDICAL_RECORDS_INFORMATION.HOUSE_NO
            dao.fields.SOI = MODEL.MEDICAL_RECORDS_INFORMATION.SOI
            dao.fields.MOO = MODEL.MEDICAL_RECORDS_INFORMATION.MOO
            dao.fields.STREET = MODEL.MEDICAL_RECORDS_INFORMATION.STREET
            dao.fields.DISTRICT = MODEL.MEDICAL_RECORDS_INFORMATION.DISTRICT
            dao.fields.DISTRICT_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.DISTRICT_NAME
            dao.fields.AMPHUR = MODEL.MEDICAL_RECORDS_INFORMATION.AMPHUR
            dao.fields.AMPHUR_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.AMPHUR_NAME
            dao.fields.PROVINCE = MODEL.MEDICAL_RECORDS_INFORMATION.PROVINCE
            dao.fields.PROVINCE_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.PROVINCE_NAME
            dao.fields.COUNTY = MODEL.MEDICAL_RECORDS_INFORMATION.COUNTY
            dao.fields.COUNTY_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.COUNTY_NAME
            dao.fields.ADDRESS_STYLE = MODEL.MEDICAL_RECORDS_INFORMATION.ADDRESS_STYLE
            dao.fields.ADDRESS_STYLE_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.ADDRESS_STYLE_NAME
            dao.fields.ZIPCODE = MODEL.MEDICAL_RECORDS_INFORMATION.ZIPCODE
            dao.fields.TEL = MODEL.MEDICAL_RECORDS_INFORMATION.TEL
            dao.fields.PHONE = MODEL.MEDICAL_RECORDS_INFORMATION.PHONE
            dao.fields.EMAIL = MODEL.MEDICAL_RECORDS_INFORMATION.EMAIL
            dao.fields.CONTACT_ADDRESS_TYPE = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_ADDRESS_TYPE
            dao.fields.CONTACT_HOUSE_NO = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_HOUSE_NO
            dao.fields.CONTACT_SOI = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_SOI
            dao.fields.CONTACT_MOO = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_MOO
            dao.fields.CONTACT_STREET = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_STREET
            dao.fields.CONTACT_DISTRICT_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_DISTRICT_NAME
            dao.fields.CONTACT_AMPHUR_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_AMPHUR_NAME
            dao.fields.CONTACT_PROVINCE_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_PROVINCE_NAME
            dao.fields.CONTACT_COUNTY_NAME = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_COUNTY_NAME
            dao.fields.CONTACT_ADDRESS_STYLE = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_ADDRESS_STYLE
            dao.fields.CONTACT_ZIPCODE = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_ZIPCODE
            dao.fields.CONTACT_TEL = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_TEL
            dao.fields.CONTACT_PHONE = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_PHONE
            dao.fields.CONTACT_MAIL = MODEL.MEDICAL_RECORDS_INFORMATION.CONTACT_MAIL
            If chk = 2 Then
                dao.fields.UPDATE_DATE = Date.Now
                dao.fields.UPDATE_USER = MODEL.USER
            End If
            dao.fields.ACTIVEFACT = True
            dao.update()
        End If


        'For Each item In MODEL.MEDICAL_RECORDS_INFORMATION
        '    If item.IDA = 0 Then
        '        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_INFORMATION
        '        dao.fields.FK_IDA_INFOR = item.FK_IDA_INFOR
        '        dao.fields.TREATMENT_TYPE = item.TREATMENT_TYPE
        '        dao.fields.LICENSE_NUMBER = item.LICENSE_NUMBER
        '        dao.fields.PAYMENT = item.PAYMENT
        '        dao.fields.PAYMENT_DES = item.PAYMENT_DES
        '        dao.fields.PAYMENT_NAME = item.PAYMENT_NAME
        '        dao.fields.PAYMENT_NAME_DES = item.PAYMENT_NAME_DES
        '        dao.fields.COMPLETE_DOC = item.COMPLETE_DOC
        '        dao.fields.DATE_ISSUE = item.DATE_ISSUE
        '        dao.fields.EXPIRE_DATE = item.EXPIRE_DATE
        '        dao.fields.HOSPITAL_MAIN = item.HOSPITAL_MAIN
        '        dao.fields.HOSPITAL_MAIN_DES = item.HOSPITAL_MAIN_DES
        '        dao.fields.HOSPITAL_RESERVE = item.HOSPITAL_RESERVE
        '        dao.fields.HOSPITAL_RESERVE_DES = item.HOSPITAL_RESERVE_DES
        '        dao.fields.MAX_AMOUNT = item.MAX_AMOUNT
        '        dao.fields.AMOUNT_SPENT = item.AMOUNT_SPENT
        '        dao.fields.DESCRIPTION = item.DESCRIPTION
        '        dao.fields.NOT_ACTIVE = item.NOT_ACTIVE
        '        dao.fields.VALIDATE_MAIN = item.VALIDATE_MAIN
        '        dao.fields.VALIDATE_SECONDARY = item.VALIDATE_SECONDARY
        '        dao.fields.CREATE_DATE = Date.Now
        '        dao.fields.CREATE_USER = MODEL.USER
        '        dao.fields.ACTIVEFACT = True
        '        dao.insert()
        '    Else
        '        Dim dao As New DAO_MASTER.TB_MEDICAL_RECORDS_VALIDATE
        '        dao.GETDATA_BY_IDA(item.IDA)
        '        dao.fields.FK_IDA_INFOR = item.FK_IDA_INFOR
        '        dao.fields.TREATMENT_TYPE = item.TREATMENT_TYPE
        '        dao.fields.LICENSE_NUMBER = item.LICENSE_NUMBER
        '        dao.fields.PAYMENT = item.PAYMENT
        '        dao.fields.PAYMENT_DES = item.PAYMENT_DES
        '        dao.fields.PAYMENT_NAME = item.PAYMENT_NAME
        '        dao.fields.PAYMENT_NAME_DES = item.PAYMENT_NAME_DES
        '        dao.fields.COMPLETE_DOC = item.COMPLETE_DOC
        '        dao.fields.DATE_ISSUE = item.DATE_ISSUE
        '        dao.fields.EXPIRE_DATE = item.EXPIRE_DATE
        '        dao.fields.HOSPITAL_MAIN = item.HOSPITAL_MAIN
        '        dao.fields.HOSPITAL_MAIN_DES = item.HOSPITAL_MAIN_DES
        '        dao.fields.HOSPITAL_RESERVE = item.HOSPITAL_RESERVE
        '        dao.fields.HOSPITAL_RESERVE_DES = item.HOSPITAL_RESERVE_DES
        '        dao.fields.MAX_AMOUNT = item.MAX_AMOUNT
        '        dao.fields.AMOUNT_SPENT = item.AMOUNT_SPENT
        '        dao.fields.DESCRIPTION = item.DESCRIPTION
        '        dao.fields.NOT_ACTIVE = item.NOT_ACTIVE
        '        dao.fields.VALIDATE_MAIN = item.VALIDATE_MAIN
        '        dao.fields.VALIDATE_SECONDARY = item.VALIDATE_SECONDARY
        '        dao.fields.UPDATE_DATE = Date.Now
        '        dao.fields.UPDATE_USER = MODEL.USER
        '        dao.fields.ACTIVEFACT = True
        '        dao.update()
        '    End If

        'Next
    End Sub

    Function GET_MAS_HELPDOC(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_HELPDOC
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim GUID = MODEL_APP.GUID
        dao.GETDATA_BY_GUID(GUID)
        Return dao.Details
    End Function

    Public Sub BEFORE_INSERT_MAS_HELPDOC(ByVal MODEL_APP As MODEL_APP)
        Dim dao As New DAO_MASTER.TB_MAS_HELPDOC
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim GUID = MODEL_APP.GUID
        dao.GETDATA_BY_GUID(GUID)
        For Each item In dao.Details
            item.ACTIVEFACT = False
            dao.update()
        Next
    End Sub
    Public Sub INSERT_MAS_HELPDOC(ByVal MODEL As MODEL_APP)

        For Each item In MODEL.List_MAS_HELPDOC
            If item.IDA = 0 Then
                Dim dao As New DAO_MASTER.TB_MAS_HELPDOC
                dao.fields.GUID = item.GUID
                dao.fields.KEY_WORD = item.KEY_WORD
                dao.fields.PASSAGE = item.PASSAGE
                dao.fields.CREATE_DATE = Date.Now
                dao.fields.CREATE_USER = MODEL.USER
                dao.fields.ACTIVEFACT = True
                dao.insert()
            Else
                Dim dao As New DAO_MASTER.TB_MAS_HELPDOC
                dao.GETDATA_BY_IDA(item.IDA)
                dao.fields.GUID = item.GUID
                dao.fields.KEY_WORD = item.KEY_WORD
                dao.fields.PASSAGE = item.PASSAGE
                dao.fields.UPDATE_DATE = Date.Now
                dao.fields.UPDATE_USER = MODEL.USER
                dao.fields.ACTIVEFACT = True
                dao.update()
            End If

        Next
    End Sub

End Class
