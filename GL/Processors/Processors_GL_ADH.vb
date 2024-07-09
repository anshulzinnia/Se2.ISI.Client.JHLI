Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.GL.Processors

#Region " GL_ADH "
    Public Class GL_ADH
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "JHLI.GL"
            MyBase.Name = "GL_ADH"

            Me.[CLM].Add("HDR", New JHLI.GL.CLM.HEADER)
            Me.[CLM].Add("GL_ADH", New JHLI.GL.CLM.GL_ADH)
            Me.[CLM].Add("HEADER", New JHLI.GL.CLM.PRELOAD)

            NotificationSeconds = 1

            Me.DataLoader = New JHLI.GL.dataloader.GL_ADH
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.GL_ADH(Args.cmdLnArgs)
                Me.Args.DataListingSet = New Base.Lookup.DataListing(InterfaceKey)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region


End Namespace
