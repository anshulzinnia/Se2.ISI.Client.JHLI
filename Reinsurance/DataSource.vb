Imports System.Data.SqlClient
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Data

Namespace Se2.ISI.Client.JHLI.Reinsurance.DataSource

#Region " JH_DATA BASE "

    Public MustInherit Class JH_DATA
        Inherits Base.Data.DataSource

        Public cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "


        Protected Sub New(ByVal Args As Se2CmdArgs)

            cmdArgs = Args

            Source = IDataSource.SourceType.MSSql

            SetParameters()

        End Sub

#End Region


        Public Overrides Sub SetParameters()

            Dim currCycleDate As Date
            Dim GroupID As String
            Dim Cmpy As String

            currCycleDate = cmdArgs.CYCLEDATE

            GroupID = "191"
            Cmpy = "JH"

            Parms = New List(Of IDataParameter)
            Parms.Add(New SqlClient.SqlParameter("@cycledate", currCycleDate))
            Parms.Add(New SqlClient.SqlParameter("@groupid", GroupID))
            Parms.Add(New SqlClient.SqlParameter("@cmpy", Cmpy))

        End Sub


    End Class

#End Region

#Region " TAI "

    Public Class TAI
        Inherits JH_DATA

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)

            MyBase.New(Args)
            ProcName = "[dbo].[JHLI_REINSURANCE_TAI]"

        End Sub

#End Region

    End Class

#End Region

End Namespace