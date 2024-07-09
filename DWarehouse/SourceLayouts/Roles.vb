Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " ROLES "

    Public Class ROLES
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            RO_CONT
            RO_POL_NUM
            RO_ROLE_ID
            RO_ROLE_DESC
            RO_OPT_DESC
            RO_NAME_ID
            RO_EFF_DATE
            RO_END_DATE
            RO_PERCENT_SPLIT
            RO_EMAIL
            RO_ADDRESS_ID
            RO_PREF_COMM_TYPE
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property RO_POL_NUM() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RO_POL_NUM))
            End Get
        End Property
        Public ReadOnly Property RO_CONT() As String
            Get
                Return Values(FieldList.RO_CONT)
            End Get
        End Property
        Public ReadOnly Property RO_ROLE_ID() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RO_ROLE_ID))
            End Get
        End Property
        Public ReadOnly Property RO_ROLE_DESC() As String
            Get
                Return Values(FieldList.RO_ROLE_DESC)
            End Get
        End Property
        Public ReadOnly Property RO_OPT_DESC() As String
            Get
                Return Values(FieldList.RO_OPT_DESC)
            End Get
        End Property
        Public ReadOnly Property RO_NAME_ID() As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.RO_NAME_ID))
            End Get
        End Property
        Public ReadOnly Property RO_EFF_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.RO_EFF_DATE))
            End Get
        End Property
        Public ReadOnly Property RO_END_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.RO_END_DATE))
            End Get
        End Property
        Public ReadOnly Property RO_PERCENT_SPLIT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RO_PERCENT_SPLIT))
            End Get
        End Property
        Public ReadOnly Property RO_EMAIL() As String
            Get
                Return Values(FieldList.RO_EMAIL)
            End Get
        End Property
        Public ReadOnly Property RO_ADDRESS_ID() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RO_ADDRESS_ID))
            End Get
        End Property
        Public ReadOnly Property RO_PREF_COMM_TYPE() As String
            Get
                Return Values(FieldList.RO_PREF_COMM_TYPE)
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