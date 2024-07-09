Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " PHONE "

    Public Class PHONE
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            PH_PHONE_ID
            SOURCE
            PH_NAME_ID
            PH_PHONE_TYPE
            PH_CTRY_CODE
            PH_AREA_CODE
            PH_EXC
            PH_SUFFIX
            PH_EXT
            PH_EFF_STRT_DATE
            PH_EFF_END_DATE

        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property PH_PHONE_ID() As String
            Get
                Return Values(FieldList.PH_PHONE_ID)
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property
        Public ReadOnly Property PH_NAME_ID() As String
            Get
                Return Values(FieldList.PH_NAME_ID)
            End Get
        End Property
        Public ReadOnly Property PH_PHONE_TYPE() As String
            Get
                Return Values(FieldList.PH_PHONE_TYPE)
            End Get
        End Property
        Public ReadOnly Property PH_CTRY_CODE() As String
            Get
                Return Values(FieldList.PH_CTRY_CODE)
            End Get
        End Property
        Public ReadOnly Property PH_AREA_CODE() As String
            Get
                Return Values(FieldList.PH_AREA_CODE)
            End Get
        End Property
        Public ReadOnly Property PH_EXC() As String
            Get
                Return Values(FieldList.PH_EXC)
            End Get
        End Property
        Public ReadOnly Property PH_SUFFIX() As String
            Get
                Return Values(FieldList.PH_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property PH_EXT() As String
            Get
                Return Values(FieldList.PH_EXT)
            End Get
        End Property
        Public ReadOnly Property PH_EFF_STRT_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.PH_EFF_STRT_DATE))
            End Get
        End Property
        Public ReadOnly Property PH_EFF_END_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.PH_EFF_END_DATE))
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