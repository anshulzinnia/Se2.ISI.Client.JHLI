Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " NAMES "

    Public Class NAMES
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList
            REC_TYPE
            NA_NAME_ID
            SOURCE
            NA_NAME_TYPE
            NA_FST
            NA_LST
            NA_MID
            LG_NAME
            NA_TAX_ID
            NA_DOB
            NA_SEX
            NA_DOD
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property NA_NAME_ID() As Int32
            Get
                Return Convert.ToInt32(Values(FieldList.NA_NAME_ID))
            End Get
        End Property
        Public ReadOnly Property SOURCE() As String
            Get
                Return Values(FieldList.SOURCE)
            End Get
        End Property
        Public ReadOnly Property NA_NAME_TYPE() As String
            Get
                Return Values(FieldList.NA_NAME_TYPE)
            End Get
        End Property
        Public ReadOnly Property NA_FST() As String
            Get
                Return Values(FieldList.NA_FST)
            End Get
        End Property
        Public ReadOnly Property NA_LST() As String
            Get
                Return Values(FieldList.NA_LST)
            End Get
        End Property
        Public ReadOnly Property NA_MID() As String
            Get
                Return Values(FieldList.NA_MID)
            End Get
        End Property
        Public ReadOnly Property LG_NAME() As String
            Get
                Return Values(FieldList.LG_NAME)
            End Get
        End Property
        Public ReadOnly Property NA_TAX_ID() As String
            Get
                Return Values(FieldList.NA_TAX_ID)
            End Get
        End Property
        Public ReadOnly Property NA_DOB() As Date
            Get
                Return Date.Parse(Values(FieldList.NA_DOB))
            End Get
        End Property
        Public ReadOnly Property NA_SEX() As String
            Get
                Return Values(FieldList.NA_SEX)
            End Get
        End Property
        Public ReadOnly Property NA_DOD() As Date
            Get
                Return Date.Parse(Values(FieldList.NA_DOD))
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