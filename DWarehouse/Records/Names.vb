Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " NAMES "

    <Serializable()>
    Public Class NAMES
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            NAM_NM_ID
            NAM_SOURCE
            NAM_FST_NAME
            NAM_LST_NAME
            NAM_MID_NAME
            NAM_LG_NAME
            NAM_TAX_ID
            NAM_DOB
            NAM_GENDER
            NAM_DOD
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("NAM_NM_ID", 0, FieldType.Number, "0", "NA_NAME_ID"))
            Fields.Add(New FieldDef("NAM_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("NAM_FST_NAME", "NA_FST"))
            Fields.Add(New FieldDef("NAM_LST_NAME", "NA_LST"))
            Fields.Add(New FieldDef("NAM_MID_NAME", "NA_MID"))
            Fields.Add(New FieldDef("NAM_LG_NAME", "LG_NAME"))
            Fields.Add(New FieldDef("NAM_TAX_ID", "NA_TAX_ID"))
            Fields.Add(New FieldDef("NAM_DOB", #1/1/1900#, FieldType.Date, DateFmt, "NA_DOB"))
            Fields.Add(New FieldDef("NAM_GENDER", "NA_SEX"))
            Fields.Add(New FieldDef("NAM_DOD", #12/31/2999#, FieldType.Date, DateFmt, "NA_DOD"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property NAM_NM_ID() As FieldDef
            Get
                Return Fields(FieldList.NAM_NM_ID)
            End Get
        End Property
        Public ReadOnly Property NAM_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.NAM_SOURCE)
            End Get
        End Property
        Public ReadOnly Property NAM_FST_NAME() As FieldDef
            Get
                Return Fields(FieldList.NAM_FST_NAME)
            End Get
        End Property
        Public ReadOnly Property NAM_LST_NAME() As FieldDef
            Get
                Return Fields(FieldList.NAM_LST_NAME)
            End Get
        End Property
        Public ReadOnly Property NAM_MID_NAME() As FieldDef
            Get
                Return Fields(FieldList.NAM_MID_NAME)
            End Get
        End Property
        Public ReadOnly Property NAM_LG_NAME() As FieldDef
            Get
                Return Fields(FieldList.NAM_LG_NAME)
            End Get
        End Property
        Public ReadOnly Property NAM_TAX_ID() As FieldDef
            Get
                Return Fields(FieldList.NAM_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property NAM_DOB() As FieldDef
            Get
                Return Fields(FieldList.NAM_DOB)
            End Get
        End Property
        Public ReadOnly Property NAM_GENDER() As FieldDef
            Get
                Return Fields(FieldList.NAM_GENDER)
            End Get
        End Property
        Public ReadOnly Property NAM_DOD() As FieldDef
            Get
                Return Fields(FieldList.NAM_DOD)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace