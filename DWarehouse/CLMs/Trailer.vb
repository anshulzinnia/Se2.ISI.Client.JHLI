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

#Region " TRAILER "

    Public Class Trailer
        Inherits BaseLogic

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TRAILER
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GET_RECORD_COUNT(ByVal value As Se2Args) As Object


            Return value.ProcessedRecords

        End Function
        Public Function GET_CYCLE_DATE(ByVal value As Se2Args) As Object


            Return value.cmdLnArgs.CYCLEDATE.ToString("yyyyMMdd")

        End Function
        Public Function GET_RUN_DATE(ByVal value As Se2Args) As Object


            Return Now.ToString("yyyyMMdd")

        End Function
        Public Function GET_RUN_TIME(ByVal value As Se2Args) As Object


            Return Now.ToString("HHHHmmss")

        End Function

#End Region

    End Class

#End Region

End Namespace