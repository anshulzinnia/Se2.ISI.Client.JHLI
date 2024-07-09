Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " MVALUES "

    Public Class MVALUES

        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList

            REC_TYPE
            DP_POL_NUM
            DP_CONT
            SOURCE
            VAL_DATE
            ACCT_TOTAL
            DP_SURRCHARG
            DP_NET_CV
            DP_DEATH_BENEFIT
            DP_MINIMUM_DB
            DP_RATCHET_DB
            DP_GMDB_ROLLUP
            DP_GMIB_RATCHET
            DP_GMIB_ROLLUP
            DP_GMIB_DATE
            DP_CYTD_PREM
            DP_PYTD_PREM
            DP_ITD_PREM
            CN_PREM
            DP_PYTD_PLANNED_PREM
            DP_INIT_PREM
            DP_CYTD_WITHD
            DP_PYTD_WITHD
            DP_ITD_WITHD
            NET_PUR_PAY
            DP_CYTD_CHG

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property DP_POL_NUM() As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.DP_POL_NUM))
            End Get
        End Property
        Public ReadOnly Property DP_CONT() As String
            Get
                Return Values(FieldList.DP_CONT)
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property
        Public ReadOnly Property VAL_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.VAL_DATE))
            End Get
        End Property
        Public ReadOnly Property ACCT_TOTAL() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.ACCT_TOTAL))
            End Get
        End Property
        Public ReadOnly Property DP_SURRCHARG() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_SURRCHARG))
            End Get
        End Property
        Public ReadOnly Property DP_NET_CV() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_NET_CV))
            End Get
        End Property
        Public ReadOnly Property DP_DEATH_BENEFIT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_DEATH_BENEFIT))
            End Get
        End Property
        Public ReadOnly Property DP_MINIMUM_DB() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_MINIMUM_DB))
            End Get
        End Property
        Public ReadOnly Property DP_RATCHET_DB() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_RATCHET_DB))
            End Get
        End Property
        Public ReadOnly Property DP_GMDB_ROLLUP() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_GMDB_ROLLUP))
            End Get
        End Property
        Public ReadOnly Property DP_GMIB_RATCHET() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_GMIB_RATCHET))
            End Get
        End Property
        Public ReadOnly Property DP_GMIB_ROLLUP() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_GMIB_ROLLUP))
            End Get
        End Property
        Public ReadOnly Property DP_GMIB_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.DP_GMIB_DATE))
            End Get
        End Property
        Public ReadOnly Property DP_CYTD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_CYTD_PREM))
            End Get
        End Property
        Public ReadOnly Property DP_PYTD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_PYTD_PREM))
            End Get
        End Property
        Public ReadOnly Property DP_ITD_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_ITD_PREM))
            End Get
        End Property
        Public ReadOnly Property CN_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.CN_PREM))
            End Get
        End Property
        Public ReadOnly Property DP_PYTD_PLANNED_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_PYTD_PLANNED_PREM))
            End Get
        End Property
        Public ReadOnly Property DP_INIT_PREM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_INIT_PREM))
            End Get
        End Property
        Public ReadOnly Property DP_CYTD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_CYTD_WITHD))
            End Get
        End Property
        Public ReadOnly Property DP_PYTD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_PYTD_WITHD))
            End Get
        End Property
        Public ReadOnly Property DP_ITD_WITHD() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_ITD_WITHD))
            End Get
        End Property
        Public ReadOnly Property NET_PUR_PAY() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.NET_PUR_PAY))
            End Get
        End Property
        Public ReadOnly Property DP_CYTD_CHG() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.DP_CYTD_CHG))
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