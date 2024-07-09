Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " DISB "


    Public Class DISB
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            DIS_DISB
            DIS_CONT
            DIS_SOURCE
            DIS_DISB_CODE
            DIS_TXN
            DIS_DATE
            DIS_ALLOC_PERC
            DIS_TAX_FLG
            DIS_GROSS_AMT
            DIS_NET_AMT
            DIS_NM_ID
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("DIS_DISB", "DB_DISB_DET_CNTR"))
            Fields.Add(New FieldDef("DIS_CONT", "DB_CONT"))
            Fields.Add(New FieldDef("DIS_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("DIS_DISB_CODE", "DB_DIST_CODE"))
            Fields.Add(New FieldDef("DIS_TXN", "DB_TXN_NUM"))
            Fields.Add(New FieldDef("DIS_DATE", #1/1/1900#, FieldType.Date, DateFmt, "DB_PROC_DATE"))
            Fields.Add(New FieldDef("DIS_ALLOC_PERC", 0, FieldType.Number, "0.00", "DB_DISB_ALLOC_PCNT"))
            Fields.Add(New FieldDef("DIS_TAX_FLG", "DB_TAXABLE_FLG"))
            Fields.Add(New FieldDef("DIS_GROSS_AMT", 0, FieldType.Number, "0.00", "DB_GROSS_AMT"))
            Fields.Add(New FieldDef("DIS_NET_AMT", 0, FieldType.Number, "0.00", "DB_NET_AMT"))
            Fields.Add(New FieldDef("DIS_NM_ID", "DB_NAME_ID"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property DIS_DISB() As FieldDef
            Get
                Return Fields(FieldList.DIS_DISB)
            End Get
        End Property
        Public ReadOnly Property DIS_CONT() As FieldDef
            Get
                Return Fields(FieldList.DIS_CONT)
            End Get
        End Property
        Public ReadOnly Property DIS_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.DIS_SOURCE)
            End Get
        End Property
        Public ReadOnly Property DIS_DISB_CODE As FieldDef
            Get
                Return Fields(FieldList.DIS_DISB_CODE)
            End Get
        End Property
        Public ReadOnly Property DIS_TXN() As FieldDef
            Get
                Return Fields(FieldList.DIS_TXN)
            End Get
        End Property
        Public ReadOnly Property DIS_DATE() As FieldDef
            Get
                Return Fields(FieldList.DIS_DATE)
            End Get
        End Property
        Public ReadOnly Property DIS_ALLOC_PCNT() As FieldDef
            Get
                Return Fields(FieldList.DIS_ALLOC_PERC)
            End Get
        End Property
        Public ReadOnly Property DIS_TAX_FLG() As FieldDef
            Get
                Return Fields(FieldList.DIS_TAX_FLG)
            End Get
        End Property
        Public ReadOnly Property DIS_GROSS_AMT() As FieldDef
            Get
                Return Fields(FieldList.DIS_GROSS_AMT)
            End Get
        End Property
        Public ReadOnly Property DIS_NET_AMT() As FieldDef
            Get
                Return Fields(FieldList.DIS_NET_AMT)
            End Get
        End Property
        Public ReadOnly Property DIS_NM_ID() As FieldDef
            Get
                Return Fields(FieldList.DIS_NM_ID)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace
