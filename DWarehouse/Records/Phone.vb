Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " PHONE "


    Public Class PHONE
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            PHN_PHONE_ID
            PHN_SOURCE
            PHN_NM_ID
            PHN_TYPE_DESC
            PHN_CNTRY
            PHN_AREA_CODE
            PHN_EXCHANGE
            PHN_SUFFIX
            PHN_EXTENSION
            PHN_EFF_DATE
            PHN_END_DATE
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("PHN_PHONE_ID", "PH_PHONE_ID"))
            Fields.Add(New FieldDef("PHN_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("PHN_NM_ID", "PH_NAME_ID"))
            Fields.Add(New FieldDef("PHN_TYPE_DESC", "PH_PHONE_TYPE"))
            Fields.Add(New FieldDef("PHN_CNTRY", "PH_CTRY_CODE"))
            Fields.Add(New FieldDef("PHN_AREA_CODE", "PH_AREA_CODE"))
            Fields.Add(New FieldDef("PHN_EXCHANGE", "PH_EXC"))
            Fields.Add(New FieldDef("PHN_SUFFIX", "PH_SUFFIX"))
            Fields.Add(New FieldDef("PHN_EXTENSION", "PH_EXT"))
            Fields.Add(New FieldDef("PHN_EFF_DATE", #1/1/1900#, FieldType.Date, DateFmt, "PH_EFF_STRT_DATE"))
            Fields.Add(New FieldDef("PHN_END_DATE", #1/1/1900#, FieldType.Date, DateFmt, "PH_EFF_END_DATE"))


        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property PHN_PHONE_ID() As FieldDef
            Get
                Return Fields(FieldList.PHN_PHONE_ID)
            End Get
        End Property
        Public ReadOnly Property PHN_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.PHN_SOURCE)
            End Get
        End Property
        Public ReadOnly Property PHN_NM_ID() As FieldDef
            Get
                Return Fields(FieldList.PHN_NM_ID)
            End Get
        End Property
        Public ReadOnly Property PHN_TYPE_DESC() As FieldDef
            Get
                Return Fields(FieldList.PHN_TYPE_DESC)
            End Get
        End Property
        Public ReadOnly Property PHN_CNTRY() As FieldDef
            Get
                Return Fields(FieldList.PHN_CNTRY)
            End Get
        End Property
        Public ReadOnly Property PHN_AREA_CODE() As FieldDef
            Get
                Return Fields(FieldList.PHN_AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property PHN_EXCHANGE() As FieldDef
            Get
                Return Fields(FieldList.PHN_EXCHANGE)
            End Get
        End Property
        Public ReadOnly Property PHN_SUFFIX() As FieldDef
            Get
                Return Fields(FieldList.PHN_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property PHN_EXTENSION() As FieldDef
            Get
                Return Fields(FieldList.PHN_EXTENSION)
            End Get
        End Property
        Public ReadOnly Property PHN_EFF_DATE() As FieldDef
            Get
                Return Fields(FieldList.PHN_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property PHN_END_DATE() As FieldDef
            Get
                Return Fields(FieldList.PHN_END_DATE)
            End Get
        End Property






#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace