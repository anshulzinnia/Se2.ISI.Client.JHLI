Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.Processors

#Region " CLAIMS_BENEFICIARY "

    Public Class CLAIMS_BENEFICIARY

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI..DWarehouse.CLAIMS_BENEFICIARY"
            MyBase.Name = "CLAIMS_BENEFICIARY"

            Me.[CLM].Add("CLAIMS_BENEFICIARY", New JHLI.DWarehouse.CLM.CLAIMS_BENEFICIARY)
            Me.[CLM].Add("TRAILER", New JHLI.DWarehouse.CLM.Trailer)
            Me.[CLM].Add("HEADER", New JHLI.DWarehouse.CLM.Header)

            NotificationSeconds = 1

        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.CLAIMS_BENEFICIARY(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region

End Namespace


