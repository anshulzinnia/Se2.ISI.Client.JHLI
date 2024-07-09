Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " CLAIMS_BENEFICIARY "


    Public Class CLAIMS_BENEFICIARY
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            CLM_BEN_CLAIM_ID
            CLM_SOURCE
            CLM_BEN_PAYOUT_ID
            CLM_BEN_NAME_ID
            CLM_BEN_PAYOUT_AMT
            CLM_BEN_STAT_INT_AMT
            CLM_BEN_PAYOUT_PRIOR_AMT
            CLM_BEN_STAT_INT_RATE
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef) From {
                New FieldDef("CLM_BEN_CLAIM_ID", "CB_CLAIM_ID"),
                New FieldDef("CLM_SOURCE", "S:Se2"),
                New FieldDef("CLM_BEN_PAYOUT_ID", "CB_PAYOUT_ID"),
                New FieldDef("CLM_BEN_NAME_ID", "CB_NAME_ID"),
                New FieldDef("CLM_BEN_PAYTOUT_AMT", 0, FieldType.Number, "0.00", "CB_PAYOUT_AMT"),
                New FieldDef("CLM_BEN_STAT_INT_AMT", 0, FieldType.Number, "0.00", "CB_STATUTORY_INT_AMT"),
                New FieldDef("CLM_BEN_PAYOUT_PRIOR_AMT", 0, FieldType.Number, "0.00", "CB_BEN_PAYOUT_PRIOR_AMT"),
                New FieldDef("CLM_BEN_STAT_INT_RATE", 0, FieldType.Number, "0.00", "CB_STATE_RATE_PCT")
            }
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property CLM_BEN_CLAIM_ID() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_CLAIM_ID)
            End Get
        End Property
        Public ReadOnly Property CLM_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.CLM_SOURCE)
            End Get
        End Property

        Public ReadOnly Property CLM_BEN_PAYOUT_ID() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_PAYOUT_ID)
            End Get
        End Property

        Public ReadOnly Property CLM_BEN_NAME_ID() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_NAME_ID)
            End Get
        End Property

        Public ReadOnly Property CLM_BEN_PAYOUT_AMT() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_PAYOUT_AMT)
            End Get
        End Property

        Public ReadOnly Property CLM_BEN_STAT_INT_AMT() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_STAT_INT_AMT)
            End Get
        End Property

        Public ReadOnly Property CLM_BEN_PAYOUT_PRIOR_AMT() As FieldDef
            Get
                Return Fields(FieldList.CLM_BEN_PAYOUT_PRIOR_AMT)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace

