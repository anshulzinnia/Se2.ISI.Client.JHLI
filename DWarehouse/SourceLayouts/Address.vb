Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " ADDRESS "

    Public Class ADDRESS
        Inherits SourceDef

#Region " FEILD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            AS_ADDRESS_ID
            SOURCE
            AS_NAME_ID
            AS_ADDRESS_TYPE
            AS_ADDRESS1
            AS_ADDRESS2
            AS_ADDRESS3
            AS_CITY
            AS_STATE_CODE
            AS_ZIP
            AS_ZIP_SUFFIX
            AS_CTRY_CODE
            AS_EFF_STRT_DATE
            AS_EFF_END_DATE
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS_ID() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.AS_ADDRESS_ID))
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property
        Public ReadOnly Property AS_NAME_ID() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.AS_NAME_ID))
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS_TYPE() As String
            Get
                Return Values(FieldList.AS_ADDRESS_TYPE)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS1() As String
            Get
                Return Values(FieldList.AS_ADDRESS1)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS2() As String
            Get
                Return Values(FieldList.AS_ADDRESS2)
            End Get
        End Property
        Public ReadOnly Property AS_ADDRESS3() As String
            Get
                Return Values(FieldList.AS_ADDRESS3)
            End Get
        End Property
        Public ReadOnly Property AS_CITY() As String
            Get
                Return Values(FieldList.AS_CITY)
            End Get
        End Property
        Public ReadOnly Property AS_STATE_CODE() As String
            Get
                Return Values(FieldList.AS_STATE_CODE)
            End Get
        End Property
        Public ReadOnly Property AS_ZIP() As String
            Get
                Return Values(FieldList.AS_ZIP)
            End Get
        End Property
        Public ReadOnly Property AS_ZIP_SUFFIX() As String
            Get
                Return Values(FieldList.AS_ZIP_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property AS_CTRY_CODE() As String
            Get
                Return Values(FieldList.AS_CTRY_CODE)
            End Get
        End Property
        Public ReadOnly Property AS_EFF_STRT_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.AS_EFF_STRT_DATE))
            End Get
        End Property
        Public ReadOnly Property AS_EFF_END_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.AS_EFF_END_DATE))
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