Imports Se2.ISI.Base.Data
Imports Se2.ISI.Base.Processing

Namespace Se2.ISI.Client.JHLI.GL.DataSource


#Region " GL_ADH "

    Public Class GL_ADH
        Inherits Se2.ISI.Base.Data.DataSource

        Private cmdArgs As Se2CmdArgs

#Region " CONSTRUCTORS "

        Public Sub New(ByVal Args As Se2CmdArgs)

            cmdArgs = Args

            Source = IDataSource.SourceType.MSSql
            Me.SourceContainsHeader = False
            ProcName = "[dbo].[JHLI_GL_ADH]"

            SetParameters()

        End Sub
#End Region

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
    End Class

#End Region

End Namespace