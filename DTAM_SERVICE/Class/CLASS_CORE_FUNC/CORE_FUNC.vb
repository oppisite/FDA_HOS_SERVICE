Public Class CORE_FUNC
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
        dao.GETDATA_MEDIINFOR_BY_FK_INFOR(IDA)
        Return dao.fields
    End Function

    Function GET_DATA_WAREHOUSE_SUBMAIN(ByVal MODEL_APP As MODEL_APP) As Object
        Dim dao As New DAO_MASTER.TB_MAS_WAREHOUSE_SUBMAIN
        'Dim SYSTEM_ID = MODEL_APP.AUTHEN_INFORMATION.SYSTEM_PROD
        Dim PROCESS_ID = MODEL_APP.PROCESS_ID
        Dim STATUS_ID = MODEL_APP.STATUS_ID
        Dim IDA = MODEL_APP.IDA
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

    Public Sub INSERT_MEDICAL_ADDRESS(ByVal MODEL As MODEL_APP)
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
            dao.fields.UPDATE_DATE = Date.Now
            dao.fields.UPDATE_USER = MODEL.USER
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
