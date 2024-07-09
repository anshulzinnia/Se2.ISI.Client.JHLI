Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.Records

#Region " PRELOAD "

    <Serializable()>
Public Class PRELOAD
    Inherits RecordDef

#Region " CONSTRUCTORS "

    Public Sub New()
        MyBase.New(PresentationFormat.Fixed)
        Terminator = vbCrLf
        Type = RecordType.DET
        Initialize()
    End Sub

    Private Shadows Enum FieldList
        REC_TYPE
    End Enum

    Private Sub Initialize()
        Fields = New List(Of FieldDef)
        Fields.Add(New FieldDef("REC_TYPE", 1, 4, Pad.Right, " "c, "", "F:BASICS"))
    End Sub

#End Region

#Region " PROPERTIES "

    Public ReadOnly Property REC_TYPE() As FieldDef
        Get
            Return Fields(FieldList.REC_TYPE)
        End Get
    End Property
#End Region


End Class

#End Region
End Namespace