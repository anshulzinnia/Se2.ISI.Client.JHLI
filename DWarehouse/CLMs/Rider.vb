Imports Se2.ISI.Base
'Imports Se2.ISI.Base.Lookup
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Xlat
Imports Se2.ISI.Base.Messaging

Imports System.Configuration
Imports System.Reflection

Namespace Se2.ISI.Client.JHLI.DWarehouse.CLM

#Region " RIDER "

    Public Class RIDER
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.RIDER

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.RIDERS
            Se2Source = New SourceLayouts.RIDER
            MyBase.Se2Source = Me.Se2Source

        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GET_TABLE_RATING(ByVal values As Se2Args) As String
            Dim RetVal As String = ""

            Select Case Se2Source.RD_TABLE_RATING.ToUpper
                Case "STANDARD"
                    RetVal = "1.00"
                Case "TABLE A"
                    RetVal = "1.25"
                Case "TABLE B"
                    RetVal = "1.50"
                Case "TABLE C"
                    RetVal = "1.75"
                Case "TABLE D"
                    RetVal = "2.00"
                Case "TABLE E"
                    RetVal = "2.25"
                Case "TABLE F"
                    RetVal = "2.50"
                Case "TABLE G"
                    RetVal = "2.75"
                Case "TABLE H"
                    RetVal = "3.00"
                Case "TABLE I"
                    RetVal = "3.25"
                Case "TABLE J"
                    RetVal = "3.50"
                Case "TABLE K"
                    RetVal = "3.75"
                Case "TABLE L"
                    RetVal = "4.00"
                Case "TABLE M"
                    RetVal = "4.25"
                Case "TABLE N"
                    RetVal = "4.50"
                Case "TABLE O"
                    RetVal = "4.75"
                Case "TABLE P"
                    RetVal = "5.00"
                Case Else
                    RetVal = "1.00"
            End Select

            Return RetVal
        End Function

#End Region

    End Class

#End Region

End Namespace