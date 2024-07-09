Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " DISB "

    Public Class DISB
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            DB_DISB_DET_CNTR
            DB_CONT
            DB_DIST_CODE
            DB_TXN_NUM
            DB_PROC_DATE
            DB_DISB_ALLOC_PCNT
            DB_TAXABLE_FLG
            DB_GROSS_AMT
            DB_NET_AMT
            DB_NAME_ID
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "
        Public ReadOnly Property Rec_Type() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property

        Public ReadOnly Property DB_DISB_DET_CNTR() As Integer
            Get
                Return Integer.Parse(Values(FieldList.DB_DISB_DET_CNTR))
            End Get
        End Property

        Public ReadOnly Property DB_CONT() As String
            Get
                Return Values(FieldList.DB_CONT)
            End Get
        End Property
        Public ReadOnly Property DB_DIST_CODE() As String
            Get
                Return Values(FieldList.DB_DIST_CODE)
            End Get
        End Property

        Public ReadOnly Property DB_TXN_NUM() As Integer
            Get
                Return Integer.Parse(Values(FieldList.DB_TXN_NUM))
            End Get
        End Property

        Public ReadOnly Property DB_PROC_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.DB_PROC_DATE))
            End Get
        End Property

        Public ReadOnly Property DB_DISB_ALLOC_PCNT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.DB_DISB_ALLOC_PCNT))
            End Get
        End Property

        Public ReadOnly Property DB_TAXABLE_FLG() As Integer
            Get
                Return Integer.Parse(Values(FieldList.DB_TAXABLE_FLG))
            End Get
        End Property

        Public ReadOnly Property DB_GROSS_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.DB_GROSS_AMT))
            End Get
        End Property

        Public ReadOnly Property DB_NET_AMT() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.DB_NET_AMT))
            End Get
        End Property

        Public ReadOnly Property DB_NAME_ID() As Integer
            Get
                Return Integer.Parse(Values(FieldList.DB_NAME_ID))
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