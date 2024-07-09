Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " TRANS "

    Public Class TRANS
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            TX_TXN_NUM
            TX_CONT
            TX_POL_NUM
            SOURCE
            TX_TXN_TYPE
            TX_TXN_TYPE_DESC
            TX_PRD_TXN_DESC
            TX_TXN_DATE
            TX_PRCS_DATE
            TX_SYS_DATE
            TX_UNDO_DATE
            TX_TXN_AMT
            TX_OLD_TXN_NUM
            ' RJM 2019-04-09 SIINTDWH-277 added two fields
            TX_LFT_VTLTY_STATUS
            TX_LFT_VTLTY_REFUND
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property TX_TXN_NUM() As String
            Get
                Return Values(FieldList.TX_TXN_NUM)
            End Get
        End Property
        Public ReadOnly Property TX_CONT() As String
            Get
                Return Values(FieldList.TX_CONT)
            End Get
        End Property
        Public ReadOnly Property TX_POL_NUM() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.TX_POL_NUM))
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property

        Public ReadOnly Property TX_TXN_TYPE() As String
            Get
                Return Values(FieldList.TX_TXN_TYPE)
            End Get
        End Property
        Public ReadOnly Property TX_TXN_TYPE_DESC() As String
            Get
                Return Values(FieldList.TX_TXN_TYPE_DESC)
            End Get
        End Property
        Public ReadOnly Property TX_PRD_TXN_DESC() As String
            Get
                Return Values(FieldList.TX_PRD_TXN_DESC)
            End Get
        End Property
        Public ReadOnly Property TX_TXN_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.TX_TXN_DATE))
            End Get
        End Property
        Public ReadOnly Property TX_PRCS_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.TX_PRCS_DATE))
            End Get
        End Property
        Public ReadOnly Property TX_SYS_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.TX_SYS_DATE))
            End Get
        End Property
        Public ReadOnly Property TX_UNDO_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.TX_UNDO_DATE))
            End Get
        End Property
        Public ReadOnly Property TX_TXN_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.TX_TXN_AMT))
            End Get
        End Property

        Public ReadOnly Property TX_OLD_TXN_NUM() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.TX_OLD_TXN_NUM))
            End Get
        End Property

        Public ReadOnly Property TX_LFT_VTLTY_STATUS() As String
            Get
                Return Values(FieldList.TX_LFT_VTLTY_STATUS)
            End Get
        End Property

        Public ReadOnly Property TX_LFT_VTLTY_REFUND() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.TX_LFT_VTLTY_REFUND))
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