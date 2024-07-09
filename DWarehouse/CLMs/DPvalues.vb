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

#Region " DPVALUES "

    Public Class DPVALUES
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.DPVALUES

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.DPVALUES
            Se2Source = New SourceLayouts.DPVALUES
            MyBase.Se2Source = Me.Se2Source

        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function GET_CYCLE_DATE(ByVal value As Se2Args) As Object


            Return value.cmdLnArgs.CYCLEDATE.ToString("MM/dd/yyyy")

        End Function

        ''' <summary>
        ''' RJM 2020-04-06: SIINTDWH-368: Added
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        Public Function GET_DP_ROP_CMNCMNT_YEAR(ByVal value As Se2Args) As Object
            Dim RetVal As String

            Select Case Se2Source.RD_RIDER_TYPE_ID
                Case "ROP"
                    Select Case Se2Source.CN_PLN_CODE
                        Case "3318", "3323"
                            RetVal = DatePart(DateInterval.Year, DateAdd(DateInterval.Year, 3, Se2Source.CN_ISSUE_DATE)).ToString
                        Case "3319", "3324"
                            RetVal = DatePart(DateInterval.Year, DateAdd(DateInterval.Year, 4, Se2Source.CN_ISSUE_DATE)).ToString
                        Case Else
                            RetVal = ""
                    End Select
                Case Else
                    RetVal = ""
            End Select

            Return RetVal
        End Function

        Public Function GET_DP_VITALITY_BEN_CHRG(ByVal value As Se2Args) As Decimal
            Dim RetVal As Decimal

            Select Case Se2Source.RD_RIDER_TYPE_ID
                Case "ROP"
                    RetVal = CDec(1000.0)
                Case Else
                    RetVal = CDec(0.00)
            End Select

            Return RetVal

        End Function

#End Region

    End Class

#End Region

End Namespace