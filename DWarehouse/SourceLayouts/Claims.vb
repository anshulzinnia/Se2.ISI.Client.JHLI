Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " CLAIMS "

    Public Class CLAIMS
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        ''' <summary>
        ''' RJM 2019-10-11: SIINTDWH-303: CMWR-8521: added new fields CL_BNFT_AMT 
        ''' </summary>
        Public Shadows Enum FieldList
            REC_TYPE
            CL_CLAIM_ID
            CL_CONT
            CL_CLAIM_CODE
            CL_DEATH_BENEFIT
            CL_RIDER_CLAIM_BENEFIT
            CL_PREMIUM_REFUND
            CL_PREMIUM_PAST_DUE
            CL_AD_HOC_AMOUNT
            CL_ASSIGNEE_AMOUNT
            CL_CLAIM_STATUS
            CL_CERTIFICATION_DATE
            CL_DEATH_DATE
            CL_DEATH_REASON
            CL_DISABILITY_DATE
            CL_REPORTED_DATE
            CL_BNFT_AMT
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property Rec_Type() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CL_CLAIM_ID() As String
            Get
                Return Values(FieldList.CL_CLAIM_ID)
            End Get
        End Property
        Public ReadOnly Property CL_CONT() As String
            Get
                Return Values(FieldList.CL_CONT)
            End Get
        End Property
        Public ReadOnly Property CL_CLAIM_CODE() As String
            Get
                Return Values(FieldList.CL_CLAIM_CODE)
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_BENEFIT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_DEATH_BENEFIT))
            End Get
        End Property
        Public ReadOnly Property CL_RIDER_CLAIM_BENEFIT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_RIDER_CLAIM_BENEFIT))
            End Get
        End Property
        Public ReadOnly Property CL_PREMIUM_REFUND() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_PREMIUM_REFUND))
            End Get
        End Property
        Public ReadOnly Property CL_PREMIUM_PAST_DUE() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_PREMIUM_PAST_DUE))
            End Get
        End Property
        Public ReadOnly Property CL_AD_HOC_AMOUNT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_AD_HOC_AMOUNT))
            End Get
        End Property
        Public ReadOnly Property CL_ASSIGNEE_AMOUNT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_ASSIGNEE_AMOUNT))
            End Get
        End Property
        Public ReadOnly Property CL_CLAIM_STATUS() As String
            Get
                Return Values(FieldList.CL_CLAIM_STATUS)
            End Get
        End Property
        Public ReadOnly Property CL_CERTIFICATION_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CL_CERTIFICATION_DATE))
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CL_DEATH_DATE))
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_REASON() As String
            Get
                Return Values(FieldList.CL_DEATH_REASON)
            End Get
        End Property
        Public ReadOnly Property CL_DISABILITY_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CL_DISABILITY_DATE))
            End Get
        End Property
        Public ReadOnly Property CL_REPORTED_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CL_REPORTED_DATE))
            End Get
        End Property

        Public ReadOnly Property CL_BNFT_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.CL_BNFT_AMT))
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