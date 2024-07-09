Imports Se2.ISI.Base.Data
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.DWarehouse.DataSource

#Region " JHL_DATA "

    Public MustInherit Class JHL_DATA
        Inherits Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)

            cmdArgs = Args
            Source = IDataSource.SourceType.MSSql
            SetParameters()

        End Sub

        Public Overrides Sub SetParameters()

            Dim currCycleDate As Date
            Dim GroupID As String
            Dim Cmpy As String

            currCycleDate = cmdArgs.CYCLEDATE

            GroupID = "191"

            Cmpy = "JHLI"

            Parms = New List(Of IDataParameter)
            Parms.Add(New SqlClient.SqlParameter("@cycledate", currCycleDate))
            Parms.Add(New SqlClient.SqlParameter("@groupid", GroupID))
            Parms.Add(New SqlClient.SqlParameter("@cmpy", Cmpy))

        End Sub

#End Region

    End Class

#End Region

End Namespace