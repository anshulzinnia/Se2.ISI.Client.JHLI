Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " DPVALUES "

    Public Class DPVALUES
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        ''' <summary>
        ''' RJM 2020-04-06: SIINTDWH-368: added CN_PLN_CDE, CN_ISSUE_DATE and RO_RIDER_TYPE_ID for use in CLM logic
        ''' </summary>
        Public Shadows Enum FieldList
            REC_TYPE
            CONT
            POL_NUM
            ACCT_VAL
            NET_CV
            DB_AMT
            CYTD_PREM
            PYTD_PREM
            ITD_PREM
            CYTD_WITHD
            PYTD_WITHD
            ITD_WITHD
            OUTSTANDING_LOAN_BAL
            LOAN_INT_RATE
            AVAIL_LOAN_AMT
            LOAN_INTEREST_BAL
            CN_PLN_CODE
            CN_ISSUE_DATE
            RD_RIDER_TYPE_ID
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CONT() As String
            Get
                Return Values(FieldList.CONT)
            End Get
        End Property
        Public ReadOnly Property POL_NUM() As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.POL_NUM))
            End Get
        End Property
        Public ReadOnly Property ACCT_VAL() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.ACCT_VAL))
            End Get
        End Property
        Public ReadOnly Property NET_CV() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.NET_CV))
            End Get
        End Property
        Public ReadOnly Property DB_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DB_AMT))
            End Get
        End Property
        Public ReadOnly Property CYTD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CYTD_PREM))
            End Get
        End Property
        Public ReadOnly Property PYTD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PYTD_PREM))
            End Get
        End Property
        Public ReadOnly Property ITD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.ITD_PREM))
            End Get
        End Property
        Public ReadOnly Property CYTD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CYTD_WITHD))
            End Get
        End Property
        Public ReadOnly Property PYTD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.PYTD_WITHD))
            End Get
        End Property
        Public ReadOnly Property ITD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.ITD_WITHD))
            End Get
        End Property
        Public ReadOnly Property OUTSTANDING_LOAN_BAL() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.OUTSTANDING_LOAN_BAL))
            End Get
        End Property
        Public ReadOnly Property LOAN_INT_RATE() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.LOAN_INT_RATE))
            End Get
        End Property
        Public ReadOnly Property AVAIL_LOAN_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.AVAIL_LOAN_AMT))
            End Get
        End Property
        Public ReadOnly Property LOAN_INTEREST_BAL() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.LOAN_INTEREST_BAL))
            End Get
        End Property

        Public ReadOnly Property CN_PLN_CODE() As String
            Get
                Return Values(FieldList.CN_PLN_CODE)
            End Get
        End Property

        Public ReadOnly Property CN_ISSUE_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_ISSUE_DATE))
            End Get
        End Property

        Public ReadOnly Property RD_RIDER_TYPE_ID() As String
            Get
                Return Values(FieldList.RD_RIDER_TYPE_ID)
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