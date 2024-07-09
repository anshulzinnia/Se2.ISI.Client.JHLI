Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " ADDRESS "

    Public Class ADDRESS
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            ADDR_ADDR_ID
            ADDR_SOURCE
            ADDR_NM_ID
            ADDR_TYPE_DESC
            ADDR_LINE1
            ADDR_lINE2
            ADDR_LINE3
            ADDR_CITY
            ADDR_STATE
            ADDR_ZIP
            ADDR_ZIP_EXT
            ADDR_COUNTRY
            ADDR_EFF_DATE
            ADDR_END_DATE
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("ADDR_ADDR_ID", 0, FieldType.Number, "0", "AS_ADDRESS_ID"))
            Fields.Add(New FieldDef("ADDR_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("ADDR_NM_ID", "AS_NAME_ID"))
            Fields.Add(New FieldDef("ADDR_TYPE_DESC", "AS_ADDRESS_TYPE"))
            Fields.Add(New FieldDef("ADDR_LINE1", "AS_ADDRESS1"))
            Fields.Add(New FieldDef("ADDR_LINE2", "AS_ADDRESS2"))
            Fields.Add(New FieldDef("ADDR_LINE3", "AS_ADDRESS3"))
            Fields.Add(New FieldDef("ADDR_CITY", "AS_CITY"))
            Fields.Add(New FieldDef("ADDR_STATE", "AS_STATE_CODE"))
            Fields.Add(New FieldDef("ADDR_ZIP", "AS_ZIP"))
            Fields.Add(New FieldDef("ADDR_ZIP_EXT", "AS_ZIP_SUFFIX"))
            Fields.Add(New FieldDef("ADDR_COUNTRY", "AS_CTRY_CODE"))
            Fields.Add(New FieldDef("ADDR_EFF_DATE", #1/1/1900#, FieldType.Date, DateFmt, "AS_EFF_STRT_DATE"))
            Fields.Add(New FieldDef("ADDR_END_DATE", #1/1/1900#, FieldType.Date, DateFmt, "AS_EFF_END_DATE"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property ADDR_ADDR_ID() As FieldDef
            Get
                Return Fields(FieldList.ADDR_ADDR_ID)
            End Get
        End Property
        Public ReadOnly Property ADDR_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.ADDR_SOURCE)
            End Get
        End Property
        Public ReadOnly Property ADDR_NM_ID() As FieldDef
            Get
                Return Fields(FieldList.ADDR_NM_ID)
            End Get
        End Property
        Public ReadOnly Property ADDR_TYPE_DESC() As FieldDef
            Get
                Return Fields(FieldList.ADDR_TYPE_DESC)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE1() As FieldDef
            Get
                Return Fields(FieldList.ADDR_LINE1)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE2() As FieldDef
            Get
                Return Fields(FieldList.ADDR_lINE2)
            End Get
        End Property
        Public ReadOnly Property ADDR_LINE3() As FieldDef
            Get
                Return Fields(FieldList.ADDR_LINE3)
            End Get
        End Property
        Public ReadOnly Property ADDR_CITY() As FieldDef
            Get
                Return Fields(FieldList.ADDR_CITY)
            End Get
        End Property
        Public ReadOnly Property ADDR_STATE() As FieldDef
            Get
                Return Fields(FieldList.ADDR_STATE)
            End Get
        End Property
        Public ReadOnly Property ADDR_ZIP() As FieldDef
            Get
                Return Fields(FieldList.ADDR_ZIP)
            End Get
        End Property
        Public ReadOnly Property ADDR_ZIP_EXT() As FieldDef
            Get
                Return Fields(FieldList.ADDR_ZIP_EXT)
            End Get
        End Property
        Public ReadOnly Property ADDR_EFF_DATE() As FieldDef
            Get
                Return Fields(FieldList.ADDR_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property ADDR_END_DATE() As FieldDef
            Get
                Return Fields(FieldList.ADDR_END_DATE)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace