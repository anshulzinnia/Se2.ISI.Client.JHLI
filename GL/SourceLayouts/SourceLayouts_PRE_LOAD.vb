Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.SourceLayouts

#Region " PRE_LOAD "

    <Serializable()>
    Public Class PRE_LOAD
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "

        Public Enum FieldList
            REC_TYPE
            HS_CYCLEDATE
            HS_RUNDATE
            HS_CMPNY
            HS_SOURCE
            HS_VERSION
            HS_CONTENTS
            HS_REVISION
            HS_COUNT
            HS_DEBITS
        End Enum

#End Region


#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property HS_CYCLEDATE() As Date
            Get
                Return Date.Parse(Values(FieldList.HS_CYCLEDATE))
            End Get
        End Property
        Public ReadOnly Property HS_RUNDATE() As Date
            Get
                Return Date.Parse(Values(FieldList.HS_RUNDATE))
            End Get
        End Property
        Public ReadOnly Property HS_CMPNY() As String
            Get
                Return Values(FieldList.HS_CMPNY)
            End Get
        End Property
        Public ReadOnly Property HS_SOURCE() As String
            Get
                Return Values(FieldList.HS_SOURCE)
            End Get
        End Property
        Public ReadOnly Property HS_VERSION() As String
            Get
                Return Values(FieldList.HS_VERSION)
            End Get
        End Property
        Public ReadOnly Property HS_CONTENTS() As String
            Get
                Return Values(FieldList.HS_CONTENTS)
            End Get
        End Property
        Public ReadOnly Property HS_REVISION() As String
            Get
                Return (Values(FieldList.HS_REVISION))
            End Get
        End Property
        Public ReadOnly Property HS_COUNT() As String
            Get
                Return (Values(FieldList.HS_COUNT))
            End Get
        End Property
        Public ReadOnly Property HS_DEBITS() As String
            Get
                Return Values(FieldList.HS_DEBITS)
            End Get
        End Property
#End Region

    End Class
#End Region

End Namespace


