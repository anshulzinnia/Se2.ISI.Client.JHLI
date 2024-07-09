Imports System.IO
Imports Se2.ISI.Base.Processing
'Imports Se2.ISI.Base.Utility.Logging

Namespace Se2.ISI.Client.JHLI.Reinsurance.Processors

#Region " TAI "

    Public Class TAI

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI..Reinsurance.TAI"
            MyBase.Name = "TAI"

            Me.[CLM].Add("TAI", New JHLI.Reinsurance.CLM.TAI)

            NotificationSeconds = 1

            Me.DataLoader = New JHLI.Reinsurance.DataLoader.TAI
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.TAI(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region

End Namespace
