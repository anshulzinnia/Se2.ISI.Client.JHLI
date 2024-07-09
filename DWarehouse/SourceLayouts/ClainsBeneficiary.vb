Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " CLAIMS_BENEFICIARY "

    Public Class CLAIMS_BENEFICIARY
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            CB_CLAIM_ID
            CB_PAYOUT_ID
            CB_NAME_ID
            CB_PAYOUT_AMT
            CB_STATUTORY_INT_AMT
            CB_BEN_PAYOUT_PRIOR_AMT
            CB_STATE_RATE_PCT
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CB_CLAIM_ID() As String
            Get
                Return Values(FieldList.CB_CLAIM_ID)
            End Get
        End Property

        Public ReadOnly Property CB_PAYOUT_ID() As Int32
            Get
                Return Int32.Parse(Values(FieldList.CB_PAYOUT_ID))
            End Get
        End Property

        Public ReadOnly Property CB_NAME_ID() As Int32
            Get
                Return Int32.Parse(Values(FieldList.CB_NAME_ID))
            End Get
        End Property

        Public ReadOnly Property CB_PAYOUT_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CB_PAYOUT_AMT))
            End Get
        End Property

        Public ReadOnly Property CB_STATUTORY_INT_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CB_STATUTORY_INT_AMT))
            End Get
        End Property

        Public ReadOnly Property CB_BEN_PAYOUT_PRIOR_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CB_BEN_PAYOUT_PRIOR_AMT))
            End Get
        End Property

        Public ReadOnly Property CB_STATE_RATE_PCT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CB_STATE_RATE_PCT))
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
