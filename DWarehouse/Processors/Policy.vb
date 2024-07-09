Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.Processors

#Region " POLICY "

    Public Class POLICY

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0


        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI..DWarehouse.POLICY"
            MyBase.Name = "POLICY"

            Me.[CLM].Add("POLICY", New JHLI.DWarehouse.CLM.POLICY)
            Me.[CLM].Add("TRAILER", New JHLI.DWarehouse.CLM.Trailer)
            Me.[CLM].Add("HEADER", New JHLI.DWarehouse.CLM.Header)

            NotificationSeconds = 1

        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.POLICY(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class




#End Region

End Namespace