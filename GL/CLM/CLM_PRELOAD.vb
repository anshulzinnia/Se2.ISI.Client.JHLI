Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.GL.CLM

#Region " PRELOADCLM "

    Public Class PRELOAD
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.PRE_LOAD

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.PRELOAD
            Se2Source = New SourceLayouts.PRE_LOAD
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "
        Public Function BASICS(ByVal value As Se2Args) As Object

            value.Accumulators.AddToValue("PS_COUNT", Se2Source.HS_COUNT)
            value.Accumulators.AddToValue("PS_DEBITS", Se2Source.HS_DEBITS)
            '  value.Accumulators.AddToValue("PS_CREDITS", Se2Source.HS_CREDITS)
            Me.Result.Status = False
            Return ""

        End Function
#End Region

    End Class

#End Region

End Namespace


