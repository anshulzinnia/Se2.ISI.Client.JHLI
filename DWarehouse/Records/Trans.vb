Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " TRANS "


    Public Class TRANS
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            TXN_TXN
            TXN_CONT
            TXN_POL_NUM
            TXN_SOURCE
            TXN_CODE
            TXN_NAME
            TXN_DESC
            TXN_EFF_DATE
            TXN_POSTED_DATE
            TXN_SYSTEM_DATE
            TXN_REVERSAL_DATE
            TXN_TRAN_AMT
            TXN_PRIOR_TXN
            ' RJM 2019-04-09 SIINTDWH-277 add two new fields:
            TXN_VITL_TRX_VL
            TXN_VITL_REF_AMT
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("TXN_TXN", "TX_TXN_NUM"))
            Fields.Add(New FieldDef("TXN_CONT", "TX_CONT"))
            Fields.Add(New FieldDef("TXN_POL_NUM", "TX_POL_NUM"))
            Fields.Add(New FieldDef("TXN_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("TXN_CODE", "TX_TXN_TYPE"))
            Fields.Add(New FieldDef("TXN_NAME", "TX_PRD_TXN_DESC"))
            Fields.Add(New FieldDef("TXN_DESC", "TX_TXN_TYPE_DESC"))
            Fields.Add(New FieldDef("TXN_EFF_DATE", #1/1/1900#, FieldType.Date, DateFmt, "TX_TXN_DATE"))
            Fields.Add(New FieldDef("TXN_POSTED_DATE", #1/1/1900#, FieldType.Date, DateFmt, "TX_PRCS_DATE"))
            Fields.Add(New FieldDef("TXN_SYSTEM_DATE", #1/1/1900#, FieldType.Date, DateFmt, "TX_SYS_DATE"))
            Fields.Add(New FieldDef("TXN_REVERSAL_DATE", #1/1/1900#, FieldType.Date, DateFmt, "TX_UNDO_DATE"))
            Fields.Add(New FieldDef("TXN_TRAN_AMT", 0, FieldType.Number, "0.00", "TX_TXN_AMT"))
            Fields.Add(New FieldDef("TXN_PRIOR_TXN", "TX_OLD_TXN_NUM"))

            Fields.Add(New FieldDef("TXN_VITL_TRX_VL", "F:GET_VITL_TRX_VL"))
            Fields.Add(New FieldDef("TXN_VITL_REF_AMT", 0, FieldType.Number, "0.00", "F:GET_LFT_VTLTY_REFUND"))        '' RJM SIINTDWH-277 was TX_LFT_VTLTY_REFUND, changed to use CLM

        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property TXN_TXN() As FieldDef
            Get
                Return Fields(FieldList.TXN_TXN)
            End Get
        End Property
        Public ReadOnly Property TXN_CONT() As FieldDef
            Get
                Return Fields(FieldList.TXN_CONT)
            End Get
        End Property
        Public ReadOnly Property TXN_POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.TXN_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property TXN_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.TXN_SOURCE)
            End Get
        End Property
        Public ReadOnly Property TXN_CODE() As FieldDef
            Get
                Return Fields(FieldList.TXN_CODE)
            End Get
        End Property
        Public ReadOnly Property TXN_NAME() As FieldDef
            Get
                Return Fields(FieldList.TXN_NAME)
            End Get
        End Property
        Public ReadOnly Property TXN_DESC() As FieldDef
            Get
                Return Fields(FieldList.TXN_DESC)
            End Get
        End Property
        Public ReadOnly Property TXN_EFF_DATE() As FieldDef
            Get
                Return Fields(FieldList.TXN_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_POSTED_DATE() As FieldDef
            Get
                Return Fields(FieldList.TXN_POSTED_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_SYSTEM_DATE() As FieldDef
            Get
                Return Fields(FieldList.TXN_SYSTEM_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_REVERSAL_DATE() As FieldDef
            Get
                Return Fields(FieldList.TXN_REVERSAL_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_TRAN_AMT() As FieldDef
            Get
                Return Fields(FieldList.TXN_TRAN_AMT)
            End Get
        End Property
        Public ReadOnly Property TXN_PRIOR_TXN() As FieldDef
            Get
                Return Fields(FieldList.TXN_PRIOR_TXN)
            End Get
        End Property

        Public ReadOnly Property TXN_VITL_TRX_VL() As FieldDef
            Get
                Return Fields(FieldList.TXN_VITL_TRX_VL)
            End Get
        End Property

        Public ReadOnly Property TXN_VITL_REF_AMT() As FieldDef
            Get
                Return Fields(FieldList.TXN_VITL_REF_AMT)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace