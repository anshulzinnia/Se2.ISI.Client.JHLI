Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " DTL "


    Public Class DTL
        Inherits RecordDef

        Protected Const DateFmt As String = "yyyyMMdd"

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            FieldPrefix = """"
            FieldSuffix = """"
            Delimiter = ","c
            Terminator = vbCrLf
        End Sub


#End Region

#Region " PROPERTIES "

#End Region

#Region " METHODS "

#End Region

    End Class

#End Region

#Region " HEADER "

    <Serializable()>
    Public Class COLUMNHEADERS
        Inherits RecordDef


        Private Shadows Enum FieldList
            ColumnHeaders
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.HDR
            FieldPrefix = """"
            FieldSuffix = """"
            Delimiter = ","c
            Terminator = vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("ColumnHeaders", "F:GetColumnHeaders"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property ColumnHeaders() As FieldDef
            Get
                Return Fields(FieldList.ColumnHeaders)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region


    End Class

#End Region

#Region " TRAILER "

    <Serializable()>
    Public Class TRAILER
        Inherits RecordDef


        Private Shadows Enum FieldList
            TRAILERID
            RECCOUNT
            CYCLEDATE
            RUNDATE
            RUNTIME
        End Enum


#Region " CONSTRUCTORS "

        Public Sub New()

            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.TRL
            Delimiter = ","c
            FieldPrefix = """"
            FieldSuffix = """"
            Length = -999
            Terminator = vbCrLf
            Initialize()

        End Sub

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("TRAILER_ID", "S:TRAILER"))
            Fields.Add(New FieldDef("REC_COUNT", "F:GET_RECORD_COUNT"))
            Fields.Add(New FieldDef("CYCLE_DATE", "F:GET_CYCLE_DATE"))
            Fields.Add(New FieldDef("RUN_DATE", "F:GET_RUN_DATE"))
            Fields.Add(New FieldDef("RUN_TIME", "F:GET_RUN_TIME"))
        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property TRAILERID() As FieldDef
            Get
                Return Fields(FieldList.TRAILERID)
            End Get
        End Property
        Public ReadOnly Property RECCOUNT() As FieldDef
            Get
                Return Fields(FieldList.RECCOUNT)
            End Get
        End Property
        Public ReadOnly Property CYCLEDATE() As FieldDef
            Get
                Return Fields(FieldList.CYCLEDATE)
            End Get
        End Property
        Public ReadOnly Property RUNDATE() As FieldDef
            Get
                Return Fields(FieldList.RUNDATE)
            End Get
        End Property
        Public ReadOnly Property RUNTIME() As FieldDef
            Get
                Return Fields(FieldList.RUNTIME)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region


    End Class

#End Region

End Namespace