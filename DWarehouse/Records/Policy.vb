Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " POLICY "

    <Serializable()>
    Public Class POLICY
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        ''' <summary>
        ''' RJM 08/12/2020: SIINTDWH-394: Added two fields CONT_SS_IDENTIFIER, CONT_SS_VARIATION
        ''' </summary>
        Private Shadows Enum FieldList
            CONT_CONT
            CONT_POL_NUM
            CONT_COMPANY
            CONT_SOURCE
            CONT_PLAN
            CONT_PRODUCT
            CONT_PRODUCT_TYPE
            CONT_QUAL_IND
            CONT_QUAL_PLAN_TYPE
            CONT_STATUS
            CONT_ISSUE_DATE
            CONT_MAT_DATE
            CONT_TERM_DATE
            CONT_ISSUE_STATE
            CONT_PREM_PAID_DATE
            CONT_PREM_AMOUNT
            CONT_DB_DESC
            CONT_PRIM_DOD
            CONT_PRIM_DOB
            CONT_PRIM_ISSUE_AGE
            CONT_ANN_PREM
            CONT_FEE_AMT
            CONT_INITIAL_PREM
            CONT_DEF_PAYMENT
            CONT_NOTIFICATION_DATE
            CONT_IGO_DATE
            CONT_POD_DATE
            CONT_UNEARNED_PREM
            CONT_EAPP_CHANNEL
            CONT_CAUSE_OF_DEATH
            CONT_COST_BASIS
            CONT_MEC_INDICATOR
            CONT_PAYMENT_TYPE
            CONT_PREM_DURATION
            CONT_PAID_TO_DATE
            CONT_REP_PAYROLL_ID         '' RJM 2018-12-03 Added per SIINTDWH-249: mapped to RO_PAYROLL_ID
            CONT_RPLC_INDICATOR         '' RJM 2020-01-22 Added per SIINTDWH-360: mapped to CN_RPLCMNT_IND
            CONT_SS_IDENTIFIER
            CONT_SS_VARIATION

        End Enum


        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("CONT_CONT", "CN_CONT"))
            Fields.Add(New FieldDef("CONT_POL_NUM", "CN_POL_NUM"))
            Fields.Add(New FieldDef("CONT_COMPANY", "CN_COMPANY_NAME"))
            Fields.Add(New FieldDef("CONT_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("CONT_PLAN", "CN_PLN_CODE"))
            Fields.Add(New FieldDef("CONT_PRODUCT", "CN_PRD_DESC"))
            Fields.Add(New FieldDef("CONT_PRODUCT_TYPE", "CN_PLN_TYPE"))
            Fields.Add(New FieldDef("CONT_QUAL_IND", "CN_QUALIFIED"))
            Fields.Add(New FieldDef("CONT_QUAL_PLAN_TYPE", "CN_QUAL_DESC"))
            Fields.Add(New FieldDef("CONT_STATUS", "CN_STATUS"))
            Fields.Add(New FieldDef("CONT_ISSUE_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_ISSUE_DATE"))
            Fields.Add(New FieldDef("CONT_MAT_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_MAT_DATE"))
            Fields.Add(New FieldDef("CONT_TERM_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_TERM_DATE"))
            Fields.Add(New FieldDef("CONT_ISSUE_STATE", "CN_ISSUE_STATE"))
            Fields.Add(New FieldDef("CONT_PREM_PAID_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CN_LAST_PREM_PAY_DATE"))
            Fields.Add(New FieldDef("CONT_PREM_AMOUNT", 0, FieldType.Number, "0.00", "CN_LAST_PREM_AMT"))
            Fields.Add(New FieldDef("CONT_DB_DESC", "CN_DB_DESC"))
            Fields.Add(New FieldDef("CONT_PRIM_DOD", #1/1/1900#, FieldType.Date, DateFmt, "NA_DOD"))
            Fields.Add(New FieldDef("CONT_PRIM_DOB", #1/1/1900#, FieldType.Date, DateFmt, "NA_DOB"))
            Fields.Add(New FieldDef("CONT_PRIM_ISSUE_AGE", "PRIM_ISSUE_AGE"))
            Fields.Add(New FieldDef("CONT_ANN_PREM", 0, FieldType.Number, "0.00", "ANN_PREM"))
            Fields.Add(New FieldDef("CONT_FEE_AMT", 0, FieldType.Number, "0.00", "FEE_AMT"))
            Fields.Add(New FieldDef("CONT_INITIAL_PREM", 0, FieldType.Number, "0.00", "INIT_PREM"))
            Fields.Add(New FieldDef("CONT_DEF_PAYMENT", #1/1/1900#, FieldType.Date, DateFmt, "DEF_PAYMENT_DATE"))
            Fields.Add(New FieldDef("CONT_NOTIFICATION_DATE", #1/1/1900#, FieldType.Date, DateFmt, "DTH_NOTIFICATION_DATE"))
            Fields.Add(New FieldDef("CONT_IGO_DATE", #1/1/1900#, FieldType.Date, DateFmt, "IGO_DATE"))
            Fields.Add(New FieldDef("CONT_POD_DATE", #1/1/1900#, FieldType.Date, DateFmt, "POD_DATE"))
            Fields.Add(New FieldDef("CONT_UNEARNED_PREM", 0, FieldType.Number, "0.00", "S:0"))
            Fields.Add(New FieldDef("CONT_EAPP_CHANNEL", "EAPP_CHANNEL"))
            Fields.Add(New FieldDef("CONT_CAUSE_OF_DEATH", "CAUSE_OF_DEATH"))
            Fields.Add(New FieldDef("CONT_COST_BASIS", 0, FieldType.Number, "0.00", "COST_BASIS"))
            Fields.Add(New FieldDef("CONT_MEC_INDICATOR", #1/1/1900#, FieldType.Date, DateFmt, "F:GET_MEC_INDICATOR"))
            Fields.Add(New FieldDef("CONT_PAYMENT_TYPE", "PAYMENT_TYPE"))
            Fields.Add(New FieldDef("CONT_PREM_DURATION", 0, FieldType.Number, "0", "PREM_DURATION"))
            Fields.Add(New FieldDef("CONT_PAID_TO_DATE", #1/1/1900#, FieldType.Date, DateFmt, "PAID_TO_DATE"))
            Fields.Add(New FieldDef("CONT_REP_PAYROLL_ID", "RO_PAYROLL_ID"))
            Fields.Add(New FieldDef("CONT_RPLC_INDICATOR", "CN_RPLCMNT_IND"))
            Fields.Add(New FieldDef("CONT_SS_IDENTIFIER", "RO_WHOLESALER"))
            Fields.Add(New FieldDef("CONT_SS_VARIATION", "RO_HIERARCY_INFO"))
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property CONT_CONT() As FieldDef
            Get
                Return Fields(FieldList.CONT_CONT)

            End Get
        End Property
        Public ReadOnly Property CONT_POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.CONT_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CONT_COMPANY() As FieldDef
            Get
                Return Fields(FieldList.CONT_COMPANY)
            End Get
        End Property
        Public ReadOnly Property CONT_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.CONT_SOURCE)
            End Get
        End Property
        Public ReadOnly Property CONT_PLAN() As FieldDef
            Get
                Return Fields(FieldList.CONT_PLAN)
            End Get
        End Property
        Public ReadOnly Property CONT_PRODUCT() As FieldDef
            Get
                Return Fields(FieldList.CONT_PRODUCT)
            End Get
        End Property
        Public ReadOnly Property CONT_PRODUCT_TYPE() As FieldDef
            Get
                Return Fields(FieldList.CONT_PRODUCT_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT_QUAL_IND() As FieldDef
            Get
                Return Fields(FieldList.CONT_QUAL_IND)
            End Get
        End Property
        Public ReadOnly Property CONT_QUAL_PLAN_TYPE() As FieldDef
            Get
                Return Fields(FieldList.CONT_QUAL_PLAN_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT_ISSUE_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_MAT_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_MAT_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_STATUS() As FieldDef
            Get
                Return Fields(FieldList.CONT_STATUS)
            End Get
        End Property
        Public ReadOnly Property CONT_TERM_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_TERM_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_ISSUE_STATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property CONT_PREM_PAID_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_PREM_PAID_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_PREM_AMOUNT() As FieldDef
            Get
                Return Fields(FieldList.CONT_PREM_AMOUNT)
            End Get
        End Property
        Public ReadOnly Property CONT_DB_DESC() As FieldDef
            Get
                Return Fields(FieldList.CONT_DB_DESC)
            End Get
        End Property
        Public ReadOnly Property CONT_PRIM_DOD() As FieldDef
            Get
                Return Fields(FieldList.CONT_PRIM_DOD)
            End Get
        End Property
        Public ReadOnly Property CONT_PRIM_DOB() As FieldDef
            Get
                Return Fields(FieldList.CONT_PRIM_DOB)
            End Get
        End Property
        Public ReadOnly Property CONT_PRIM_ISSUE_AGE() As FieldDef
            Get
                Return Fields(FieldList.CONT_PRIM_ISSUE_AGE)
            End Get
        End Property
        Public ReadOnly Property CONT_DEF_PAYMENT() As FieldDef
            Get
                Return Fields(FieldList.CONT_DEF_PAYMENT)
            End Get
        End Property
        Public ReadOnly Property CONT_NOTIFICATION_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_NOTIFICATION_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_IGO_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_IGO_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_POD_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_POD_DATE)
            End Get
        End Property
        Public ReadOnly Property CONT_UNEARNED_PREM() As FieldDef
            Get
                Return Fields(FieldList.CONT_UNEARNED_PREM)
            End Get
        End Property
        Public ReadOnly Property CONT_EAPP_CHANNEL() As FieldDef
            Get
                Return Fields(FieldList.CONT_EAPP_CHANNEL)
            End Get
        End Property
        Public ReadOnly Property CONT_CAUSE_OF_DEATH() As FieldDef
            Get
                Return Fields(FieldList.CONT_CAUSE_OF_DEATH)
            End Get
        End Property
        Public ReadOnly Property CONT_COST_BASIS() As FieldDef
            Get
                Return Fields(FieldList.CONT_COST_BASIS)
            End Get
        End Property
        Public ReadOnly Property CONT_MEC_INDICATOR() As FieldDef
            Get
                Return Fields(FieldList.CONT_MEC_INDICATOR)
            End Get
        End Property
        Public ReadOnly Property CONT_PAYMENT_TYPE() As FieldDef
            Get
                Return Fields(FieldList.CONT_PAYMENT_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT_PREM_DURATION() As FieldDef
            Get
                Return Fields(FieldList.CONT_PREM_DURATION)
            End Get
        End Property
        Public ReadOnly Property CONT_PAID_TO_DATE() As FieldDef
            Get
                Return Fields(FieldList.CONT_PAID_TO_DATE)
            End Get
        End Property

        Public ReadOnly Property CONT_RPLC_INDICATOR() As FieldDef
            Get
                Return Fields(FieldList.CONT_RPLC_INDICATOR)
            End Get
        End Property

        Public ReadOnly Property CONT_SS_IDENTIFIER() As FieldDef
            Get
                Return Fields(FieldList.CONT_SS_IDENTIFIER)
            End Get
        End Property

        Public ReadOnly Property CONT_SS_VARIATION() As FieldDef
            Get
                Return Fields(FieldList.CONT_SS_VARIATION)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace