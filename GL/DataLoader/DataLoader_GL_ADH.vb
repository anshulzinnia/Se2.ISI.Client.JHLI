Imports Se2.ISI.Base.Data


Namespace Se2.ISI.Client.JHLI.GL.dataloader

#Region " GL_ADH "

    Public Class GL_ADH
        Inherits Se2.ISI.Base.Data.SqlLoader

        Private KeyInfo As New List(Of LoadKey)

        Public Sub New()
            MyBase.New()
            InitializeMe()

            'Change the folowing to true to enable data importation
            ' and false to skip the loading
            Me.ImportData = True
        End Sub


        Private Sub InitializeMe()

            Dim Key As New LoadKey
            Key.Record = New Se2.ISI.Client.JHLI.GL.Records.GL_ADH
            Key.Table = "JHLI_GL_ADH"
            Key.TruncateFirst = True
            Key.DropTableFirst = True
            Key.CreateTableFirst = True

            KeyInfo.Add(Key)

            LoadKeys = KeyInfo
        End Sub

    End Class

#End Region

End Namespace