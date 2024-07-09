Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " ROLES "

    <Serializable()>
    Public Class ROLES
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            ROL_CONT
            ROL_POL_NUM
            ROL_SOURCE
            ROL_CODE
            ROL_TYPE
            ROL_SUB_TYPE
            ROL_NM_ID
            ROL_EFF_DATE
            ROL_END_DATE
            ROL_PCT
            ROL_EMAIL
            ROL_ADDR_ID
            ROL_PREF_COMMUNICATION
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("ROL_CONT", "RO_CONT"))
            Fields.Add(New FieldDef("ROL_POL_NUM", "RO_POL_NUM"))
            Fields.Add(New FieldDef("ROL_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("ROL_CODE", "RO_ROLE_ID"))
            Fields.Add(New FieldDef("ROL_TYPE", "RO_ROLE_DESC"))
            Fields.Add(New FieldDef("ROL_SUB_TYPE", "RO_OPT_DESC"))
            Fields.Add(New FieldDef("ROL_NM_ID", "RO_NAME_ID"))
            Fields.Add(New FieldDef("ROL_EFF_DATE", #1/1/1900#, FieldType.Date, DateFmt, "RO_EFF_DATE"))
            Fields.Add(New FieldDef("ROL_END_DATE", #1/1/1900#, FieldType.Date, DateFmt, "RO_END_DATE"))
            Fields.Add(New FieldDef("ROL_PCT", 0, FieldType.Number, "0.00", "RO_PERCENT_SPLIT"))
            Fields.Add(New FieldDef("ROL_EMAIL", "RO_EMAIL"))
            Fields.Add(New FieldDef("ROL_ADDR_ID", 0, FieldType.Number, "0", "RO_ADDRESS_ID"))
            Fields.Add(New FieldDef("ROL_PREF_COMMUNICATION", "RO_PREF_COMM_TYPE"))

        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property ROL_CONT() As FieldDef
            Get
                Return Fields(FieldList.ROL_CONT)
            End Get
        End Property
        Public ReadOnly Property ROL_POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.ROL_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property ROL_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.ROL_SOURCE)
            End Get
        End Property
        Public ReadOnly Property ROL_CODE() As FieldDef
            Get
                Return Fields(FieldList.ROL_CODE)
            End Get
        End Property
        Public ReadOnly Property ROL_TYPE() As FieldDef
            Get
                Return Fields(FieldList.ROL_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_SUB_TYPE() As FieldDef
            Get
                Return Fields(FieldList.ROL_SUB_TYPE)
            End Get
        End Property
        Public ReadOnly Property ROL_NM_ID() As FieldDef
            Get
                Return Fields(FieldList.ROL_NM_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_EFF_DATE() As FieldDef
            Get
                Return Fields(FieldList.ROL_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property ROL_END_DATE() As FieldDef
            Get
                Return Fields(FieldList.ROL_END_DATE)
            End Get
        End Property
        Public ReadOnly Property ROL_PCT() As FieldDef
            Get
                Return Fields(FieldList.ROL_PCT)
            End Get
        End Property
        Public ReadOnly Property ROL_ADDR_ID() As FieldDef
            Get
                Return Fields(FieldList.ROL_ADDR_ID)
            End Get
        End Property
        Public ReadOnly Property ROL_PREF_COMMUNICATION() As FieldDef
            Get
                Return Fields(FieldList.ROL_PREF_COMMUNICATION)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace