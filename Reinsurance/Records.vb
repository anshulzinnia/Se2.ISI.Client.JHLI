Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.Reinsurance.Records

    '***************************

#Region " DTL "

    Public Class DTL
        Inherits RecordDef

        Protected Const DateFmt As String = "yyyyMMdd"

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Fixed)
            Type = RecordType.DET
            Length = 650
            Terminator = vbCrLf
        End Sub

#End Region

#Region " PROPERTIES "


#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

    '***************************
#Region " TAI "

    Public Class TAI
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList

            TAIX_CO
            TAIX_PLC
            TAIX_POLICY
            TAIX_COV
            TAIX_STATUS
            TAIX_ISSUE_DATE
            TAIX_PAID_TO_DATE
            TAIX_TERMINATION_DATE
            TAIX_ISSUE_TYPE
            TAIX_PLAN
            TAIX_PRODUCT_CD
            TAIX_PRODUCT_CD_1
            TAIX_PRODUCT_CD_2
            TAIX_ADMIN_REINS_SW
            TAIX_STATE_ISS
            TAIX_STATE_RES
            TAIX_UW_METHOD
            TAIX_PAR
            TAIX_DB_OPTION
            TAIX_FACE_LTC
            TAIX_BEN_MORT
            TAIX_FACE_LTC_2
            TAIX_BEN_MORT_2
            TAIX_FACE_LTC_3
            TAIX_BEN_MORT_3
            TAIX_ULT_FACE_LTC
            TAIX_JOINT_TYPE
            TAIX_NO_OF_INS
            TAIX_JOINT_AGE
            TAIX_PREM_TO_BE_WAIVED
            TAIX_SPEC_PREM
            TAIX_SPEC_PREM_TYPE
            TAIX_DIVIDEND
            TAIX_OLD_POL
            TAIX_ADMIN_CD
            TAIX_POL_FEE
            TAIX_GROUP_ID
            TAIX_LOCATION_CD
            TAIX_CURRENCY_CD
            TAIX_VALUES_DATE
            TAIX_BENEFIT_LTC
            TAIX_CASH_VALUE
            TAIX_NEXT_CASH_VALUE
            TAIX_PREM_1
            TAIX_PREM_2
            TAIX_PREM_3
            TAIX_SEARCH_PLAN
            TAIX_GPB_VERSION_CD
            TAIX_PUA_AMT
            TAIX_PUA_CASH_VALUE
            TAIX_OLD_CO
            TAIX_OLD_COV
            TAIX_NUM_PLAN_CD
            TAIX_AB_STATUS_CD
            TAIX_ENHANCE_BEN_RDR_IND
            TAIX_CONTRACT_DELIVERY_DATE
            TAIX_LTCA_LMAX_IND
            TAIX_MAO_IND
            TAIX_COUNTRY_RISK_CD
            TAIX_CHANNEL_CD
            TAIX_GL_PROD_CD
            TAIX_ENLG_IND
            TAIX_RPT_LN_CD
            TAIX_COLI_IND
            TAIX_REINS_SW
            TAIX_SPLIT_COVERAGE
            TAIX_PAM_COINS_CO
            TAIX_PAM_GL_PROD_CD
            TAIX_PAM_POSTING_CO
            TAIX_LPB_STATUS
            TAIX_SUSPEND_CD
            TAIX_TA_AMT
            TAIX_FIRST_DEATH_DATE
            TAIX_UW_COUNTRY
            TAIX_HNW_IND
            TAIX_MAX_NAR
            TAIX_HER_STATUS_1
            TAIX_HER_STATUS_2
            FILLER_1
            TAIX_CLIENT_ID_1
            TAIX_LAST_NAME_1
            TAIX_FIRST_NAME_1
            TAIX_MID_INIT_1
            TAIX_PRICING_SEX_1
            TAIX_SEX_1
            TAIX_DOB_1
            TAIX_INS_STATUS_1
            TAIX_AGE_1
            TAIX_CLASS_1
            TAIX_MORT_1
            TAIX_MORT_DUR_1
            TAIX_PERM_FLX_1
            TAIX_PERM_DUR_1
            TAIX_TEMP_FLX_1
            TAIX_TEMP_DUR_1
            TAIX_CLIENT_ID_2
            TAIX_LAST_NAME_2
            TAIX_FIRST_NAME_2
            TAIX_MID_INIT_2
            TAIX_PRICING_SEX_2
            TAIX_SEX_2
            TAIX_DOB_2
            TAIX_INS_STATUS_2
            TAIX_AGE_2
            TAIX_CLASS_2
            TAIX_MORT_2
            TAIX_MORT_DUR_2
            TAIX_PERM_FLX_2
            TAIX_PERM_DUR_2
            TAIX_TEMP_FLX_2
            TAIX_TEMP_DUR_2
            FILLER_2


        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("TAIX_CO", 1, 3, Pad.Right, " "c, "", "S:019"))
            Fields.Add(New FieldDef("TAIX_PLC", 4, 5, Pad.Right, " "c, "", "S:00115"))
            Fields.Add(New FieldDef("TAIX_POLICY", 9, 15, Pad.Left, "0"c, "", "V:CN_CONT"))
            Fields.Add(New FieldDef("TAIX_COV", 24, 3, Pad.Left, "0"c, "", "V:RD_CVG_ID"))
            Fields.Add(New FieldDef("TAIX_STATUS", 27, 3, Pad.Right, " "c, "", "F:GET_STATUS"))
            Fields.Add(New FieldDef("TAIX_ISSUE_DATE", 30, 8, Pad.Left, " "c, #01/01/1900#, DateFmt, FieldType.Date, "V:CN_ISSUE_DATE"))
            Fields.Add(New FieldDef("TAIX_PAID_TO_DATE", 38, 8, Pad.Left, " "c, #01/01/1900#, DateFmt, FieldType.Date, "V:CN_NEXT_ACTIVITY_DATE"))
            Fields.Add(New FieldDef("TAIX_TERMINATION_DATE", 46, 8, Pad.Left, " "c, #01/01/1900#, DateFmt, FieldType.Date, "F:GET_TERM_TRANS_DATE"))
            Fields.Add(New FieldDef("TAIX_ISSUE_TYPE", 54, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_PLAN", 55, 8, Pad.Right, " "c, "", "V:RD_EXT_REF_TEXT"))
            Fields.Add(New FieldDef("TAIX_PRODUCT_CD", 63, 1, Pad.Right, " "c, "", "S:T"))
            Fields.Add(New FieldDef("TAIX_PRODUCT_CD_1", 64, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_PRODUCT_CD_2", 65, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_ADMIN_REINS_SW", 66, 1, Pad.Right, " "c, "", "S:A"))
            Fields.Add(New FieldDef("TAIX_STATE_ISS", 67, 2, Pad.Right, " "c, "", "V:CN_ISSUE_STATE"))
            Fields.Add(New FieldDef("TAIX_STATE_RES", 69, 2, Pad.Right, " "c, "", "F:GET_RESIDENT_STATE"))
            Fields.Add(New FieldDef("TAIX_UW_METHOD", 71, 1, Pad.Right, " "c, "", "S:S"))
            Fields.Add(New FieldDef("TAIX_PAR", 72, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_DB_OPTION", 73, 1, Pad.Right, " "c, "", "S:L"))
            Fields.Add(New FieldDef("TAIX_FACE_LTC", 74, 9, Pad.Right, " "c, "", "F:GET_RD_FACE_AMT_BC"))
            Fields.Add(New FieldDef("TAIX_BEN_MORT", 83, 5, Pad.Right, " "c, "", "S:01000"))
            Fields.Add(New FieldDef("TAIX_FACE_LTC_2", 88, 9, Pad.Right, " "c, "", "F:GET_RD_FACE_AMT_ADB"))
            Fields.Add(New FieldDef("TAIX_BEN_MORT_2", 97, 5, Pad.Right, " "c, "", "S:01000"))
            Fields.Add(New FieldDef("TAIX_FACE_LTC_3", 102, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_BEN_MORT_3", 111, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_ULT_FACE_LTC", 116, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_JOINT_TYPE", 125, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_NO_OF_INS", 126, 2, Pad.Left, "0"c, "", "S:01"))
            Fields.Add(New FieldDef("TAIX_JOINT_AGE", 128, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_PREM_TO_BE_WAIVED", 130, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_SPEC_PREM", 139, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_SPEC_PREM_TYPE", 148, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_DIVIDEND", 149, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_OLD_POL", 158, 20, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_ADMIN_CD", 178, 2, Pad.Right, " "c, "", "S:SE"))
            Fields.Add(New FieldDef("TAIX_POL_FEE", 180, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_GROUP_ID", 185, 15, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_LOCATION_CD", 200, 10, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_CURRENCY_CD", 210, 3, Pad.Right, " "c, "", "S:USD"))
            Fields.Add(New FieldDef("TAIX_VALUES_DATE", 213, 6, Pad.Right, " "c, "", "F:GET_VALUES_DATE"))
            Fields.Add(New FieldDef("TAIX_BENEFIT_LTC", 219, 9, Pad.Right, " "c, "", "F:GET_RD_FACE_AMT_BC"))
            Fields.Add(New FieldDef("TAIX_CASH_VALUE", 228, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_NEXT_CASH_VALUE", 237, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_PREM_1", 246, 9, Pad.Right, " "c, "", "F:GET_RD_PREM_BC"))
            Fields.Add(New FieldDef("TAIX_PREM_2", 255, 9, Pad.Right, " "c, "", "F:GET_RD_PREM_ADB"))
            Fields.Add(New FieldDef("TAIX_PREM_3", 264, 9, Pad.Right, " "c, "", "F:GET_RD_RATING_WAIVER_AMT"))
            Fields.Add(New FieldDef("TAIX_SEARCH_PLAN", 273, 8, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_GPB_VERSION_CD", 281, 5, Pad.Right, " "c, "", "S:00001"))
            Fields.Add(New FieldDef("TAIX_PUA_AMT", 286, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_PUA_CASH_VALUE", 295, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_OLD_CO", 304, 3, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_OLD_COV", 307, 3, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_NUM_PLAN_CD", 310, 9, Pad.Right, " "c, "", "F:GET_NUM_PLAN_CODE"))        '"S:000000000"
            Fields.Add(New FieldDef("TAIX_AB_STATUS_CD", 319, 1, Pad.Right, " "c, "", "F:GET_AB_STATUS_CD"))
            Fields.Add(New FieldDef("TAIX_ENHANCE_BEN_RDR_IND", 320, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_CONTRACT_DELIVERY_DATE", 321, 8, Pad.Left, " "c, #01/01/1900#, DateFmt, FieldType.Date, "V:CN_ISSUE_DATE"))
            Fields.Add(New FieldDef("TAIX_LTCA_LMAX_IND", 329, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_MAO_IND", 330, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_COUNTRY_RISK_CD", 331, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_CHANNEL_CD", 332, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_GL_PROD_CD", 333, 5, Pad.Right, " "c, "", "F:GET_GL_PROD_CD"))
            Fields.Add(New FieldDef("TAIX_ENLG_IND", 338, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_RPT_LN_CD", 339, 5, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_COLI_IND", 344, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_REINS_SW", 345, 1, Pad.Right, " "c, "", "S:1"))
            Fields.Add(New FieldDef("TAIX_SPLIT_COVERAGE", 346, 1, Pad.Right, " "c, "", "S:N"))
            Fields.Add(New FieldDef("TAIX_PAM_COINS_CO", 347, 3, Pad.Right, " "c, "", "S:000"))
            Fields.Add(New FieldDef("TAIX_PAM_GL_PROD_CD", 350, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_PAM_POSTING_CO", 355, 3, Pad.Right, " "c, "", "S:000"))
            Fields.Add(New FieldDef("TAIX_LPB_STATUS", 358, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_SUSPEND_CD", 359, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_TA_AMT", 360, 9, Pad.Right, " "c, "", "S:000000000"))
            Fields.Add(New FieldDef("TAIX_FIRST_DEATH_DATE", 369, 8, Pad.Left, " "c, "", "S:00000000"))
            Fields.Add(New FieldDef("TAIX_UW_COUNTRY", 377, 6, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_HNW_IND", 383, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_MAX_NAR", 384, 7, Pad.Right, " "c, "", "S:0000000"))
            Fields.Add(New FieldDef("TAIX_HER_STATUS_1", 391, 1, Pad.Right, " "c, "", "F:GET_HER_STATUS_1"))
            Fields.Add(New FieldDef("TAIX_HER_STATUS_2", 392, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("FILLER_1", 393, 54, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_CLIENT_ID_1", 447, 24, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_LAST_NAME_1", 471, 20, Pad.Right, " "c, "", "F:GET_LAST_NAME"))
            Fields.Add(New FieldDef("TAIX_FIRST_NAME_1", 491, 15, Pad.Right, " "c, "", "V:NA_FST"))
            Fields.Add(New FieldDef("TAIX_MID_INIT_1", 506, 1, Pad.Right, " "c, "", "V:NA_MID"))
            Fields.Add(New FieldDef("TAIX_PRICING_SEX_1", 507, 1, Pad.Right, " "c, "", "V:NA_SEX"))
            Fields.Add(New FieldDef("TAIX_SEX_1", 508, 1, Pad.Right, " "c, "", "V:NA_SEX"))
            Fields.Add(New FieldDef("TAIX_DOB_1", 509, 8, Pad.Left, " "c, #01/01/1900#, DateFmt, FieldType.Date, "V:NA_DOB"))
            Fields.Add(New FieldDef("TAIX_INS_STATUS_1", 517, 1, Pad.Right, " "c, "", "F:GET_INS_STATUS"))
            Fields.Add(New FieldDef("TAIX_AGE_1", 518, 2, Pad.Right, " "c, "", "V:CN_AGE_PRIM"))
            Fields.Add(New FieldDef("TAIX_CLASS_1", 520, 2, Pad.Right, " "c, "", "F:GET_CLASS_1"))
            Fields.Add(New FieldDef("TAIX_MORT_1", 522, 5, Pad.Right, " "c, "", "S:01000"))
            Fields.Add(New FieldDef("TAIX_MORT_DUR_1", 527, 2, Pad.Right, " "c, "", "S:99"))
            Fields.Add(New FieldDef("TAIX_PERM_FLX_1", 529, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_PERM_DUR_1", 534, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_TEMP_FLX_1", 536, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_TEMP_DUR_1", 541, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_CLIENT_ID_2", 543, 24, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_LAST_NAME_2", 567, 20, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_FIRST_NAME_2", 587, 15, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_MID_INIT_2", 602, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_PRICING_SEX_2", 603, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_SEX_2", 604, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_DOB_2", 605, 8, Pad.Left, " "c, "", "S:00000000"))
            Fields.Add(New FieldDef("TAIX_INS_STATUS_2", 613, 1, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_AGE_2", 614, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_CLASS_2", 616, 2, Pad.Right, " "c, "", "S:"))
            Fields.Add(New FieldDef("TAIX_MORT_2", 618, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_MORT_DUR_2", 623, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_PERM_FLX_2", 625, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_PERM_DUR_2", 630, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("TAIX_TEMP_FLX_2", 632, 5, Pad.Right, " "c, "", "S:00000"))
            Fields.Add(New FieldDef("TAIX_TEMP_DUR_2", 637, 2, Pad.Right, " "c, "", "S:00"))
            Fields.Add(New FieldDef("FILLER_2", 639, 11, Pad.Right, " "c, "", "S:"))

        End Sub

#End Region

#Region " PROPERTIES "

        Public ReadOnly Property TAIX_CO() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CO)
            End Get
        End Property
        Public ReadOnly Property TAIX_PLC() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PLC)
            End Get
        End Property

        Public ReadOnly Property TAIX_POLICY() As FieldDef
            Get
                Return Fields(FieldList.TAIX_POLICY)
            End Get
        End Property

        Public ReadOnly Property TAIX_COV() As FieldDef
            Get
                Return Fields(FieldList.TAIX_COV)
            End Get
        End Property

        Public ReadOnly Property TAIX_STATUS() As FieldDef
            Get
                Return Fields(FieldList.TAIX_STATUS)
            End Get
        End Property

        Public ReadOnly Property TAIX_ISSUE_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ISSUE_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_PAID_TO_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PAID_TO_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_TERMINATION_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TERMINATION_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_ISSUE_TYPE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ISSUE_TYPE)
            End Get
        End Property

        Public ReadOnly Property TAIX_PLAN() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PLAN)
            End Get
        End Property

        Public ReadOnly Property TAIX_PRODUCT_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PRODUCT_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_PRODUCT_CD_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PRODUCT_CD_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_PRODUCT_CD_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PRODUCT_CD_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_ADMIN_REINS_SW() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ADMIN_REINS_SW)
            End Get
        End Property

        Public ReadOnly Property TAIX_STATE_ISS() As FieldDef
            Get
                Return Fields(FieldList.TAIX_STATE_ISS)
            End Get
        End Property

        Public ReadOnly Property TAIX_STATE_RES() As FieldDef
            Get
                Return Fields(FieldList.TAIX_STATE_RES)
            End Get
        End Property

        Public ReadOnly Property TAIX_UW_METHOD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_UW_METHOD)
            End Get
        End Property

        Public ReadOnly Property TAIX_PAR() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PAR)
            End Get
        End Property

        Public ReadOnly Property TAIX_DB_OPTION() As FieldDef
            Get
                Return Fields(FieldList.TAIX_DB_OPTION)
            End Get
        End Property

        Public ReadOnly Property TAIX_FACE_LTC() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FACE_LTC)
            End Get
        End Property

        Public ReadOnly Property TAIX_BEN_MORT() As FieldDef
            Get
                Return Fields(FieldList.TAIX_BEN_MORT)
            End Get
        End Property

        Public ReadOnly Property TAIX_FACE_LTC_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FACE_LTC_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_BEN_MORT_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_BEN_MORT_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_FACE_LTC_3() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FACE_LTC_3)
            End Get
        End Property

        Public ReadOnly Property TAIX_BEN_MORT_3() As FieldDef
            Get
                Return Fields(FieldList.TAIX_BEN_MORT_3)
            End Get
        End Property

        Public ReadOnly Property TAIX_ULT_FACE_LTC() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ULT_FACE_LTC)
            End Get
        End Property

        Public ReadOnly Property TAIX_JOINT_TYPE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_JOINT_TYPE)
            End Get
        End Property

        Public ReadOnly Property TAIX_NO_OF_INS() As FieldDef
            Get
                Return Fields(FieldList.TAIX_NO_OF_INS)
            End Get
        End Property

        Public ReadOnly Property TAIX_JOINT_AGE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_JOINT_AGE)
            End Get
        End Property

        Public ReadOnly Property TAIX_PREM_TO_BE_WAIVED() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PREM_TO_BE_WAIVED)
            End Get
        End Property

        Public ReadOnly Property TAIX_SPEC_PREM() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SPEC_PREM)
            End Get
        End Property

        Public ReadOnly Property TAIX_SPEC_PREM_TYPE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SPEC_PREM_TYPE)
            End Get
        End Property

        Public ReadOnly Property TAIX_DIVIDEND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_DIVIDEND)
            End Get
        End Property

        Public ReadOnly Property TAIX_OLD_POL() As FieldDef
            Get
                Return Fields(FieldList.TAIX_OLD_POL)
            End Get
        End Property

        Public ReadOnly Property TAIX_ADMIN_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ADMIN_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_POL_FEE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_POL_FEE)
            End Get
        End Property

        Public ReadOnly Property TAIX_GROUP_ID() As FieldDef
            Get
                Return Fields(FieldList.TAIX_GROUP_ID)
            End Get
        End Property

        Public ReadOnly Property TAIX_LOCATION_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_LOCATION_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_CURRENCY_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CURRENCY_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_VALUES_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_VALUES_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_BENEFIT_LTC() As FieldDef
            Get
                Return Fields(FieldList.TAIX_BENEFIT_LTC)
            End Get
        End Property

        Public ReadOnly Property TAIX_CASH_VALUE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CASH_VALUE)
            End Get
        End Property

        Public ReadOnly Property TAIX_NEXT_CASH_VALUE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_NEXT_CASH_VALUE)
            End Get
        End Property

        Public ReadOnly Property TAIX_PREM_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PREM_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_PREM_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PREM_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_PREM_3() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PREM_3)
            End Get
        End Property

        Public ReadOnly Property TAIX_SEARCH_PLAN() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SEARCH_PLAN)
            End Get
        End Property

        Public ReadOnly Property TAIX_GPB_VERSION_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_GPB_VERSION_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_PUA_AMT() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PUA_AMT)
            End Get
        End Property
        Public ReadOnly Property TAIX_PUA_CASH_VALUE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PUA_CASH_VALUE)
            End Get
        End Property

        Public ReadOnly Property TAIX_OLD_CO() As FieldDef
            Get
                Return Fields(FieldList.TAIX_OLD_CO)
            End Get
        End Property

        Public ReadOnly Property TAIX_OLD_COV() As FieldDef
            Get
                Return Fields(FieldList.TAIX_OLD_COV)
            End Get
        End Property

        Public ReadOnly Property TAIX_NUM_PLAN_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_NUM_PLAN_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_AB_STATUS_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_AB_STATUS_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_ENHANCE_BEN_RDR_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ENHANCE_BEN_RDR_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_CONTRACT_DELIVERY_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CONTRACT_DELIVERY_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_LTCA_LMAX_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_LTCA_LMAX_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_MAO_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MAO_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_COUNTRY_RISK_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_COUNTRY_RISK_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_CHANNEL_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CHANNEL_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_GL_PROD_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_GL_PROD_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_ENLG_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_ENLG_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_RPT_LN_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_RPT_LN_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_COLI_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_COLI_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_REINS_SW() As FieldDef
            Get
                Return Fields(FieldList.TAIX_REINS_SW)
            End Get
        End Property

        Public ReadOnly Property TAIX_SPLIT_COVERAGE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SPLIT_COVERAGE)
            End Get
        End Property

        Public ReadOnly Property TAIX_PAM_COINS_CO() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PAM_COINS_CO)
            End Get
        End Property

        Public ReadOnly Property TAIX_PAM_GL_PROD_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PAM_GL_PROD_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_PAM_POSTING_CO() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PAM_POSTING_CO)
            End Get
        End Property

        Public ReadOnly Property TAIX_LPB_STATUS() As FieldDef
            Get
                Return Fields(FieldList.TAIX_LPB_STATUS)
            End Get
        End Property

        Public ReadOnly Property TAIX_SUSPEND_CD() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SUSPEND_CD)
            End Get
        End Property

        Public ReadOnly Property TAIX_TA_AMT() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TA_AMT)
            End Get
        End Property

        Public ReadOnly Property TAIX_FIRST_DEATH_DATE() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FIRST_DEATH_DATE)
            End Get
        End Property

        Public ReadOnly Property TAIX_UW_COUNTRY() As FieldDef
            Get
                Return Fields(FieldList.TAIX_UW_COUNTRY)
            End Get
        End Property

        Public ReadOnly Property TAIX_HNW_IND() As FieldDef
            Get
                Return Fields(FieldList.TAIX_HNW_IND)
            End Get
        End Property

        Public ReadOnly Property TAIX_MAX_NAR() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MAX_NAR)
            End Get
        End Property

        Public ReadOnly Property TAIX_HER_STATUS_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_HER_STATUS_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_HER_STATUS_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_HER_STATUS_2)
            End Get
        End Property

        Public ReadOnly Property FILLER_1() As FieldDef
            Get
                Return Fields(FieldList.FILLER_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_CLIENT_ID_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CLIENT_ID_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_LAST_NAME_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_LAST_NAME_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_FIRST_NAME_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FIRST_NAME_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_MID_INIT_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MID_INIT_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_PRICING_SEX_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PRICING_SEX_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_SEX_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SEX_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_DOB_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_DOB_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_INS_STATUS_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_INS_STATUS_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_AGE_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_AGE_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_CLASS_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CLASS_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_MORT_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MORT_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_MORT_DUR_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MORT_DUR_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_PERM_FLX_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PERM_FLX_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_PERM_DUR_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PERM_DUR_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_TEMP_FLX_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TEMP_FLX_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_TEMP_DUR_1() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TEMP_DUR_1)
            End Get
        End Property

        Public ReadOnly Property TAIX_CLIENT_ID_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CLIENT_ID_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_LAST_NAME_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_LAST_NAME_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_FIRST_NAME_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_FIRST_NAME_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_MID_INIT_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MID_INIT_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_PRICING_SEX_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PRICING_SEX_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_SEX_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_SEX_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_DOB_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_DOB_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_INS_STATUS_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_INS_STATUS_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_AGE_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_AGE_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_CLASS_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_CLASS_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_MORT_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MORT_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_MORT_DUR_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_MORT_DUR_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_PERM_FLX_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PERM_FLX_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_PERM_DUR_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_PERM_DUR_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_TEMP_FLX_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TEMP_FLX_2)
            End Get
        End Property

        Public ReadOnly Property TAIX_TEMP_DUR_2() As FieldDef
            Get
                Return Fields(FieldList.TAIX_TEMP_DUR_2)
            End Get
        End Property

        Public ReadOnly Property FILLER_2() As FieldDef
            Get
                Return Fields(FieldList.FILLER_2)
            End Get
        End Property

#End Region

#Region " METHODS "
#End Region

    End Class

#End Region

End Namespace
