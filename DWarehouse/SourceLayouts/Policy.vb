Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " POLICY "

    Public Class POLICY
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        ''' <summary>
        ''' RJM 08/12/2020: SIINTDWH-394: added two new fields RO_WHOLESALER, RO_HIERARCY_INFO
        ''' </summary>
        Public Shadows Enum FieldList
            REC_TYPE
            CN_CONT
            CN_POL_NUM
            CN_COMPANY_NAME
            SOURCE
            CN_PLN_CODE
            CN_PRD_DESC
            CN_PLN_TYPE
            CN_QUALIFIED
            CN_QUAL_DESC
            CN_STATUS
            CN_ISSUE_DATE
            CN_MAT_DATE
            CN_TERM_DATE
            CN_ISSUE_STATE
            CN_LAST_PREM_PAY_DATE
            CN_LAST_PREM_AMT
            CN_DB_DESC
            NA_DOD
            NA_DOB
            PRIM_ISSUE_AGE
            ANN_PREM
            FEE_AMT
            INIT_PREM
            DEF_PAYMENT_DATE
            DTH_NOTIFICATION_DATE
            IGO_DATE
            POD_DATE
            EAPP_CHANNEL
            CAUSE_OF_DEATH
            COST_BASIS
            MEC_INDICATOR
            PAYMENT_TYPE
            PREM_DURATION
            PAID_TO_DATE
            RO_PAYROLL_ID           '' RJM 2018-12-03: added per SIINTDWH-249
            CN_RPLCMNT_IND          '' RJM 2020-01-22: added per SIINTDWH-360
            RO_WHOLESALER
            RO_HIERARCY_INFO

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_POL_NUM() As String
            Get
                Return Values(FieldList.CN_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CN_CONT() As String
            Get
                Return Values(FieldList.CN_CONT)
            End Get
        End Property
        Public ReadOnly Property CN_COMPANY_NAME() As String
            Get
                Return Values(FieldList.CN_COMPANY_NAME)
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property
        Public ReadOnly Property CN_PLN_CODE() As String
            Get
                Return Values(FieldList.CN_PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property CN_PRD_DESC() As String
            Get
                Return Values(FieldList.CN_PRD_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_PLN_TYPE() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.CN_PLN_TYPE))
            End Get
        End Property
        Public ReadOnly Property CN_QUALIFIED() As String
            Get
                Return Values(FieldList.CN_QUALIFIED)
            End Get
        End Property
        Public ReadOnly Property CN_QUAL_DESC() As String
            Get
                Return Values(FieldList.CN_QUAL_DESC)
            End Get
        End Property
        Public ReadOnly Property CN_STATUS() As String
            Get
                Return Values(FieldList.CN_STATUS)
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_ISSUE_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_MAT_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_MAT_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_TERM_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_TERM_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_STATE() As String
            Get
                Return Values(FieldList.CN_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property CN_LAST_PREM_PAY_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_LAST_PREM_PAY_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_LAST_PREM_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_LAST_PREM_AMT))
            End Get
        End Property
        Public ReadOnly Property CN_DB_DESC() As String
            Get
                Return Values(FieldList.CN_DB_DESC)
            End Get
        End Property
        Public ReadOnly Property NA_DOD() As Date
            Get
                Return Date.Parse(Values(FieldList.NA_DOD))
            End Get
        End Property
        Public ReadOnly Property NA_DOB() As Date
            Get
                Return Date.Parse(Values(FieldList.NA_DOB))
            End Get
        End Property
        Public ReadOnly Property PRIM_ISSUE_AGE() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.PRIM_ISSUE_AGE))
            End Get
        End Property
        Public ReadOnly Property ANN_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.ANN_PREM))
            End Get
        End Property
        Public ReadOnly Property FEE_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.FEE_AMT))
            End Get
        End Property
        Public ReadOnly Property INIT_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.INIT_PREM))
            End Get
        End Property
        Public ReadOnly Property DEF_PAYMENT_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.DEF_PAYMENT_DATE))
            End Get
        End Property
        Public ReadOnly Property DTH_NOTIFICATION_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.DTH_NOTIFICATION_DATE))
            End Get
        End Property
        Public ReadOnly Property IGO_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.IGO_DATE))
            End Get
        End Property
        Public ReadOnly Property POD_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.POD_DATE))
            End Get
        End Property
        Public ReadOnly Property EAPP_CHANNEL() As String
            Get
                Return Values(FieldList.EAPP_CHANNEL)
            End Get
        End Property
        Public ReadOnly Property CAUSE_OF_DEATH() As String
            Get
                Return Values(FieldList.CAUSE_OF_DEATH)
            End Get
        End Property
        Public ReadOnly Property COST_BASIS() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.COST_BASIS))
            End Get
        End Property
        Public ReadOnly Property MEC_INDICATOR() As Date
            Get
                Return Date.Parse(Values(FieldList.MEC_INDICATOR))
            End Get
        End Property
        Public ReadOnly Property PAYMENT_TYPE() As String
            Get
                Return Values(FieldList.PAYMENT_TYPE)
            End Get
        End Property
        Public ReadOnly Property PREM_DURATION() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.PREM_DURATION))
            End Get
        End Property
        Public ReadOnly Property PAID_TO_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.PAID_TO_DATE))
            End Get
        End Property
        Public ReadOnly Property RO_PAYROLL_ID As String
            Get
                Return Values(FieldList.RO_PAYROLL_ID)
            End Get
        End Property

        Public ReadOnly Property CN_RPLCMNT_IND() As Integer
            Get
                Return Integer.Parse(Values(FieldList.CN_RPLCMNT_IND))
            End Get
        End Property

        Public ReadOnly Property RO_WHOLESALER() As String
            Get
                Return Values(FieldList.RO_WHOLESALER)
            End Get
        End Property

        Public ReadOnly Property RO_HIERARCY_INFO() As String
            Get
                Return Values(FieldList.RO_HIERARCY_INFO)
            End Get
        End Property

#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class

#End Region

End Namespace