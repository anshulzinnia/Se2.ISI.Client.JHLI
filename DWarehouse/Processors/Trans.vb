Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.Processors

#Region " TRANS "

    Public Class TRANS

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0
        Public Sub New()

            MyBase.New()
            MyBase.InterfaceKey = "JHLI..DWarehouse.TRANS"
            MyBase.Name = "TRANS"

            Me.[CLM].Add("TRANS", New JHLI.DWarehouse.CLM.TRANS)
            Me.[CLM].Add("TRAILER", New JHLI.DWarehouse.CLM.Trailer)
            Me.[CLM].Add("HEADER", New JHLI.DWarehouse.CLM.Header)

            NotificationSeconds = 1

        End Sub
        Public Overrides Function InitDataSource() As Boolean

            Try
                Me.DataSource = New DataSource.TRANS(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region

End Namespace