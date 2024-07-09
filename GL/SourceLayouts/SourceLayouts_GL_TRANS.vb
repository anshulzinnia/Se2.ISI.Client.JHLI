Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.SourceLayouts

#Region " DETAIL "

    <Serializable()>
    Public Class DETAIL
        Inherits SourceDef

#Region " PRIVATE PROPERTIES "

#End Region

#Region " PRIVATE METHODS "

#End Region

#Region " FIELD ARRAY ENUM "

        Public Enum FieldList
            REC_TYPE
            BUS_UNIT
            CYCLE_DATE
            JRNL_DATE
            ACCOUNT
            JRNL_LN_REF
            PRODUCT
            FUND
            MKT_SEG
            STATE
            AMOUNT
            CONTRACT
            GL_ADMIN_TRAN_TYPE '-DESCRIPTION '
        End Enum

#End Region

#Region " PUBLIC PROPERTIES "

        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property BUS_UNIT() As String
            Get
                Return Values(FieldList.BUS_UNIT)
            End Get
        End Property
        Public ReadOnly Property CYCLE_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CYCLE_DATE))
            End Get
        End Property
        Public ReadOnly Property JRNL_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.JRNL_DATE))
            End Get
        End Property
        Public ReadOnly Property ACCOUNT() As String
            Get
                Return Values(FieldList.ACCOUNT)
            End Get
        End Property
        Public ReadOnly Property JRNL_LN_REF() As String
            Get
                Return Values(FieldList.JRNL_LN_REF)
            End Get
        End Property
        Public ReadOnly Property PRODUCT() As String
            Get
                Return Values(FieldList.PRODUCT)
            End Get
        End Property
        Public ReadOnly Property FUND() As String
            Get
                Return Values(FieldList.FUND)
            End Get
        End Property
        Public ReadOnly Property MKT_SEG() As String
            Get
                Return Values(FieldList.MKT_SEG)
            End Get
        End Property
        Public ReadOnly Property STATE() As String
            Get
                Return Values(FieldList.STATE)
            End Get
        End Property
        Public ReadOnly Property AMOUNT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.AMOUNT))
            End Get
        End Property
        Public ReadOnly Property CONTRACT() As String
            Get
                Return Values(FieldList.CONTRACT)
            End Get
        End Property

        Public ReadOnly Property GL_ADMIN_TRAN_TYPE() As String
            Get
                Return Values(FieldList.GL_ADMIN_TRAN_TYPE)
            End Get
        End Property

#End Region

#Region " OVERRIDES "

#End Region

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class

#End Region

End Namespace


