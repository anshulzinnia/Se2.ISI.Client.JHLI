Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.Processors

#Region " DPVALUES "

    Public Class DPVALUES

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0


        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI..DWarehouse.DPVALUES"
            MyBase.Name = "DPVALUES"

            Me.[CLM].Add("DPVALUES", New JHLI.DWarehouse.CLM.DPVALUES)
            Me.[CLM].Add("TRAILER", New JHLI.DWarehouse.CLM.Trailer)
            Me.[CLM].Add("HEADER", New JHLI.DWarehouse.CLM.Header)

            NotificationSeconds = 1

        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.DPVALUES(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class




#End Region

End Namespace