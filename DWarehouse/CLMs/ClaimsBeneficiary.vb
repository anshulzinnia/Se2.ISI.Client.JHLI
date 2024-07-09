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

#Region " CLAIMS_BENEFICIARY "

    Public Class CLAIMS_BENEFICIARY
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.CLAIMS_BENEFICIARY

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.CLAIMS_BENEFICIARY
            Se2Source = New SourceLayouts.CLAIMS_BENEFICIARY
            MyBase.Se2Source = Me.Se2Source

        End Sub

#Region " POPULATION FUNCTIONS "


#End Region

    End Class

#End Region

End Namespace


