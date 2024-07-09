Imports Se2.ISI.Base.Data
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.DataSource

#Region " RIDER "

    Public Class RIDER
        Inherits JHL_DATA

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            MyBase.New(Args)

            ProcName = "[dbo].[JHLI_DWarehouse_RIDER]"

        End Sub
#End Region

    End Class
#End Region

End Namespace