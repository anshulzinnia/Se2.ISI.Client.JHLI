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

#Region " POLICY "

    Public Class POLICY
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.POLICY

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.POLICY
            Se2Source = New SourceLayouts.POLICY
            MyBase.Se2Source = Me.Se2Source

        End Sub


#Region " POPULATION FUNCTIONS "

        Public Function GET_MEC_INDICATOR(ByVal value As Se2Args) As Object
            If Se2Source.MEC_INDICATOR = #1/1/1900# Then
                Return #12/31/2999#
            Else
                Return Se2Source.MEC_INDICATOR
            End If
        End Function


#End Region

    End Class

#End Region

End Namespace