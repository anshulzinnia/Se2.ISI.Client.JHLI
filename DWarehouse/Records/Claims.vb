Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " CLAIMS "


    Public Class CLAIMS
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub
        ''' <summary>
        ''' RJM 2019-10-11: SIINTDWH-303: CMWR-8521: added new fields CL_BNFT_AMT
        ''' </summary>
        Private Shadows Enum FieldList
            CL_CLAIM_ID
            CL_CONT
            CL_SOURCE
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

        ''' <summary>
        ''' Field name change from CL_CERT_RCVD_DATE to CL_CERTIFICATION_DATE
        ''' </summary>
        Private Sub Initialize()
            Fields = New List(Of FieldDef) From {
                New FieldDef("CLM_CLAIM_ID", "CL_CLAIM_ID"),
                New FieldDef("CLM_CONT", "CL_CONT"),
                New FieldDef("CLM_SOURCE", "S:Se2"),
                New FieldDef("CLM_CLAIM_CODE", "CL_CLAIM_CODE"),
                New FieldDef("CLM_DEATH_BENEFIT", 0, FieldType.Number, "0.00", "CL_DEATH_BENEFIT"),
                New FieldDef("CLM_RIDER_BENEFIT", 0, FieldType.Number, "0.00", "CL_RIDER_CLAIM_BENEFIT"),
                New FieldDef("CLM_PREMIUM_REFUND", 0, FieldType.Number, "0.00", "CL_PREMIUM_REFUND"),
                New FieldDef("CLM_PREMIUM_PAST_DUE", 0, FieldType.Number, "0.00", "CL_PREMIUM_PAST_DUE"),
                New FieldDef("CLM_AD_HOC_AMOUNT", 0, FieldType.Number, "0.00", "CL_AD_HOC_AMOUNT"),
                New FieldDef("CLM_ASSIGNEE_AMOUNT", 0, FieldType.Number, "0.00", "CL_ASSIGNEE_AMOUNT"),
                New FieldDef("CLM_CLAIM_STATUS", "CL_CLAIM_STATUS"),
                New FieldDef("CLM_CERT_RCVD_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CL_CERTIFICATION_DATE"),
                New FieldDef("CLM_DEATH_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CL_DEATH_DATE"),
                New FieldDef("CLM_DEATH_REASON", "CL_DEATH_REASON"),
                New FieldDef("CLM_DISABILITY_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CL_DISABILITY_DATE"),
                New FieldDef("CLM_REPORTED_DATE", #1/1/1900#, FieldType.Date, DateFmt, "CL_REPORTED_DATE"),
                New FieldDef("CLM_NET_INT_AMT", 0, FieldType.Number, "0.00", "CL_BNFT_AMT")
            }
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property CL_CLAIM_ID() As FieldDef
            Get
                Return Fields(FieldList.CL_CLAIM_ID)
            End Get
        End Property
        Public ReadOnly Property CL_CONT() As FieldDef
            Get
                Return Fields(FieldList.CL_CONT)
            End Get
        End Property
        Public ReadOnly Property CL_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.CL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property CL_CLAIM_CODE() As FieldDef
            Get
                Return Fields(FieldList.CL_CLAIM_CODE)
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_BENEFIT() As FieldDef
            Get
                Return Fields(FieldList.CL_DEATH_BENEFIT)
            End Get
        End Property
        Public ReadOnly Property CL_RIDER_CLAIM_BENEFIT() As FieldDef
            Get
                Return Fields(FieldList.CL_RIDER_CLAIM_BENEFIT)
            End Get
        End Property
        Public ReadOnly Property CL_PREMIUM_REFUND() As FieldDef
            Get
                Return Fields(FieldList.CL_PREMIUM_REFUND)
            End Get
        End Property
        Public ReadOnly Property CL_PREMIUM_PAST_DUE() As FieldDef
            Get
                Return Fields(FieldList.CL_PREMIUM_PAST_DUE)
            End Get
        End Property
        Public ReadOnly Property CL_AD_HOC_AMOUNT() As FieldDef
            Get
                Return Fields(FieldList.CL_AD_HOC_AMOUNT)
            End Get
        End Property
        Public ReadOnly Property CL_ASSIGNEE_AMOUT() As FieldDef
            Get
                Return Fields(FieldList.CL_ASSIGNEE_AMOUNT)
            End Get
        End Property
        Public ReadOnly Property CL_CLAIM_STATUS() As FieldDef
            Get
                Return Fields(FieldList.CL_CLAIM_STATUS)
            End Get
        End Property
        Public ReadOnly Property CL_CERT_RCVD_DATE() As FieldDef
            Get
                Return Fields(FieldList.CL_CERTIFICATION_DATE)
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_DATE() As FieldDef
            Get
                Return Fields(FieldList.CL_DEATH_DATE)
            End Get
        End Property
        Public ReadOnly Property CL_DEATH_REASON() As FieldDef
            Get
                Return Fields(FieldList.CL_DEATH_REASON)
            End Get
        End Property
        Public ReadOnly Property CL_DISABILITY_DATE() As FieldDef
            Get
                Return Fields(FieldList.CL_DISABILITY_DATE)
            End Get
        End Property
        Public ReadOnly Property CL_REPORTED_DATE() As FieldDef
            Get
                Return Fields(FieldList.CL_REPORTED_DATE)
            End Get
        End Property

        Public ReadOnly Property CL_BNFT_AMT() As FieldDef
            Get
                Return Fields(FieldList.CL_BNFT_AMT)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace
