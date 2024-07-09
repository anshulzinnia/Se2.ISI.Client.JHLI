Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " DPVALUES "

    <Serializable()>
    Public Class DPVALUES
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        ''' <summary>
        ''' RJM 2020-04-06: SIINTDWH-368: added two new fields DP_ROP_CMNCMNT_YEAR, DP_VITALITY_BEN_CHRG
        ''' </summary>
        Private Shadows Enum FieldList
            DP_CONT
            DP_POL_NUM
            DP_SOURCE
            DP_VALUATION_DATE
            DP_ACCT_VAL
            DP_NET_CV
            DP_DB
            DP_CYTD_PREM
            DP_PYTD_PREM
            DP_ITD_PREM
            DP_CYTD_WITH
            DP_PYTD_WITH
            DP_ITD_WITH
            DP_LOAN_BALANCE
            DP_LOAN_INT
            DP_AVAILABLE_LOAN_AMT
            DP_INTEREST_LOAN_AMT
            DP_ROP_CMNCMNT_YEAR
            DP_VITALITY_BEN_CHRG
        End Enum


        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("DP_CONT", "CONT"))
            Fields.Add(New FieldDef("DP_POL_NUM", "POL_NUM"))
            Fields.Add(New FieldDef("DP_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("DP_VALUATION_DATE", #1/1/1900#, FieldType.Date, DateFmt, "F:GET_CYCLE_DATE"))
            Fields.Add(New FieldDef("DP_ACCT_VAL", 0, FieldType.Number, "0.00", "ACCT_VAL"))
            Fields.Add(New FieldDef("DP_NET_CV", 0, FieldType.Number, "0.00", "NET_CV"))
            Fields.Add(New FieldDef("DP_DB", 0, FieldType.Number, "0.00", "DB_AMT"))
            Fields.Add(New FieldDef("DP_CYTD_PREM", 0, FieldType.Number, "0.00", "CYTD_PREM"))
            Fields.Add(New FieldDef("DP_PYTD_PREM", 0, FieldType.Number, "0.00", "PYTD_PREM"))
            Fields.Add(New FieldDef("DP_ITD_PREM", 0, FieldType.Number, "0.00", "ITD_PREM"))
            Fields.Add(New FieldDef("DP_CYTD_WITH", 0, FieldType.Number, "0.00", "CYTD_WITHD"))
            Fields.Add(New FieldDef("DP_PYTD_WITH", 0, FieldType.Number, "0.00", "PYTD_WITHD"))
            Fields.Add(New FieldDef("DP_ITD_WITH", 0, FieldType.Number, "0.00", "ITD_WITHD"))
            Fields.Add(New FieldDef("DP_LOAN_BALANCE", 0, FieldType.Number, "0.00", "OUTSTANDING_LOAN_BAL"))
            Fields.Add(New FieldDef("DP_LOAN_INT", 0, FieldType.Number, "0.00", "LOAN_INT_RATE"))
            Fields.Add(New FieldDef("DP_AVAILABLE_LOAN_AMT", 0, FieldType.Number, "0.00", "AVAIL_LOAN_AMT"))
            Fields.Add(New FieldDef("DP_INTEREST_LOAN_AMT", 0, FieldType.Number, "0.00", "LOAN_INTEREST_BAL"))
            Fields.Add(New FieldDef("DP_ROP_CMNCMNT_YEAR", "F:GET_DP_ROP_CMNCMNT_YEAR"))
            Fields.Add(New FieldDef("DP_VITALITY_BEN_CHRG", 0.00, FieldType.Number, "0.00", "F:GET_DP_VITALITY_BEN_CHRG"))

        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property DP_CONT() As FieldDef
            Get
                Return Fields(FieldList.DP_CONT)

            End Get
        End Property
        Public ReadOnly Property DP_POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.DP_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property DP_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.DP_SOURCE)
            End Get
        End Property
        Public ReadOnly Property DP_VALUATION_DATE() As FieldDef
            Get
                Return Fields(FieldList.DP_VALUATION_DATE)
            End Get
        End Property
        Public ReadOnly Property DP_ACCT_VAL() As FieldDef
            Get
                Return Fields(FieldList.DP_ACCT_VAL)
            End Get
        End Property
        Public ReadOnly Property DP_NET_CV() As FieldDef
            Get
                Return Fields(FieldList.DP_NET_CV)
            End Get
        End Property
        Public ReadOnly Property DP_DB() As FieldDef
            Get
                Return Fields(FieldList.DP_DB)
            End Get
        End Property
        Public ReadOnly Property DP_CYTD_PREM() As FieldDef
            Get
                Return Fields(FieldList.DP_CYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property DP_PYTD_PREM() As FieldDef
            Get
                Return Fields(FieldList.DP_PYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property DP_ITD_PREM() As FieldDef
            Get
                Return Fields(FieldList.DP_ITD_PREM)
            End Get
        End Property
        Public ReadOnly Property DP_CYTD_WITH() As FieldDef
            Get
                Return Fields(FieldList.DP_CYTD_WITH)
            End Get
        End Property
        Public ReadOnly Property DP_PYTD_WITH() As FieldDef
            Get
                Return Fields(FieldList.DP_PYTD_WITH)
            End Get
        End Property
        Public ReadOnly Property DP_ITD_WITH() As FieldDef
            Get
                Return Fields(FieldList.DP_ITD_WITH)
            End Get
        End Property
        Public ReadOnly Property DP_LOAN_BALANCE() As FieldDef
            Get
                Return Fields(FieldList.DP_LOAN_BALANCE)
            End Get
        End Property
        Public ReadOnly Property DP_LOAN_INT() As FieldDef
            Get
                Return Fields(FieldList.DP_LOAN_INT)
            End Get
        End Property
        Public ReadOnly Property DP_AVAILABLE_LOAN_AMT() As FieldDef
            Get
                Return Fields(FieldList.DP_AVAILABLE_LOAN_AMT)
            End Get
        End Property
        Public ReadOnly Property DP_INTEREST_LOAN_AMT() As FieldDef
            Get
                Return Fields(FieldList.DP_INTEREST_LOAN_AMT)
            End Get
        End Property

        Public ReadOnly Property DP_ROP_CMNCMNT_YEAR() As FieldDef
            Get
                Return Fields(FieldList.DP_ROP_CMNCMNT_YEAR)
            End Get
        End Property

        Public ReadOnly Property DP_VITALITY_BEN_CHRG() As FieldDef
            Get
                Return Fields(FieldList.DP_VITALITY_BEN_CHRG)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace