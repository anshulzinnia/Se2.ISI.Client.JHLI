Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.Processors

#Region " PHONE "

    Public Class PHONE

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI..DWarehouse.PHONE"
            MyBase.Name = "PHONE"

            Me.[CLM].Add("PHONE", New JHLI.DWarehouse.CLM.PHONE)
            Me.[CLM].Add("TRAILER", New JHLI.DWarehouse.CLM.Trailer)
            Me.[CLM].Add("HEADER", New JHLI.DWarehouse.CLM.Header)

            NotificationSeconds = 1

        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.PHONE(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region

End Namespace