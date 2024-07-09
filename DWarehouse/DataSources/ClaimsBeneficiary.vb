Imports Se2.ISI.Base.Data
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.DataSource

#Region " CLAIMS_BENEFICIARY "

    Public Class CLAIMS_BENEFICIARY
        Inherits JHL_DATA

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)
            MyBase.New(Args)

            ProcName = "[dbo].[JHLI_DWarehouse_CLAIMS_BENEFICIARY]"

        End Sub
#End Region

    End Class
#End Region

End Namespace


