Imports System.IO
Imports Se2.ISI.Base.Processing
Imports System.Math

Namespace Se2.ISI.Client.JHLI.GL.Processors

#Region " CONTROL FILE "

    Public Class CtrlFile
        Public Property DestFolder As String
        Public Property DestFile As String
        Public Property SourceFile As String
        Public Property OutputFile As String
        Public Property CycleDate As Date
        Public Property TStamp As String
        Public Property FileSize As Double
        Public Property RowCount As Integer
        Public Property SumValue As String
        Public Property FileHash As String


        Public Sub New()
            FileSize = 0
            RowCount = 0
            SumValue = String.Empty
        End Sub

        Public Sub New(ByVal value As Se2Args)
            CycleDate = value.cmdLnArgs.CYCLEDATE
            DestFile = String.Empty
            SourceFile = String.Empty
            FileHash = String.Empty
            DestFolder = value.DestFolder
            TStamp = Now.ToString("MM/dd/yyyy HH:mm:ss")
            FileSize = value.BytesWritten
            RowCount = Convert.ToInt32(value.ProcessedRecords)
            DestFile = DestFolder & "\" & value.DestFile
            'DestFile = "PACT_SE2_RECON_MLY_201509.csv"
            'FileHash = getSHA256Hash(DestFile)  'Me.DestinationFile.Substring(0, Me.DestinationFile.LastIndexOf("."c)) & ".csv"

            DestFolder = value.DestFolder & "\" & CycleDate.ToString("yyyyMMdd")
            'Try
            '  SumValue = value.Accumulators("SumValue").ToString
            'Catch
            '  SumValue = String.Empty
            'End Try
        End Sub




    End Class

#End Region

#Region "  BASE "

    Public Class JHLBase

        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()

            NotificationSeconds = 1

        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.TRANS(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try

        End Function

        Protected Overrides Sub PostFileCloseHandler(ByRef e As ISIEventsArgs)
            CreateControlFile()
            MyBase.PostFileCloseHandler(e)
        End Sub

        Private Sub CreateControlFile()

            Dim ctlFileObj As New CtrlFile(Me.Args)
            Dim ctlPart As String = String.Empty
            Dim srcPart As String = String.Empty
            Dim ctlFileName As String = Me.DestinationFile.Substring(0, Me.DestinationFile.LastIndexOf("."c)) & ".ctl"
            Dim dataFileName As String = Me.DestinationFile.Substring(0, Me.DestinationFile.LastIndexOf("."c)) & ".csv"
            Dim writer As New StreamWriter(Me.DestFolder & "\" & ctlFileName, False)
            ' need to test records here and if zero create controls with zero values.  waiting for approval and ticket processorcount
            Dim rows As String = String.Empty ' = String.Format("{0:000000#}", Args.Accumulators("COUNT"))
            Dim absDebits As Decimal ' ' Math.Abs(Math.Round((Convert.ToDecimal(Args.Accumulators("DEBITS"))), 2))
            Dim absDebitsNumber As String = String.Empty ' = String.Format("{0:000000000000000000.00#}", absDebits)
            Dim absCredits As Decimal ' = Math.Abs(Math.Round((Convert.ToDecimal(Args.Accumulators("CREDITS"))), 2))
            Dim absCreditNumber As String = String.Empty ' String.Format("{0:000000000000000000.00#}", absCredits)

            'If you want to put contents into the file....
            Dim OutString As String = String.Empty
            If ctlFileObj.RowCount > 0 Then
                rows = String.Format("{0:000000#}", Args.Accumulators("COUNT"))
                absDebits = Math.Abs(Math.Round((Convert.ToDecimal(Args.Accumulators("DEBITS"))), 2))
                absDebitsNumber = String.Format("{0:000000000000000000.00#}", absDebits)
                absCredits = Math.Abs(Math.Round((Convert.ToDecimal(Args.Accumulators("CREDITS"))), 2))
                absCreditNumber = String.Format("{0:000000000000000000.00#}", absCredits)
            Else
                rows = String.Format("{0:000000#}", 0.00)
                absDebits = Math.Abs(Math.Round((Convert.ToDecimal(0.00)), 2))
                absDebitsNumber = String.Format("{0:000000000000000000.00#}", 0.00)
                absCredits = Math.Abs(Math.Round((Convert.ToDecimal(0.00)), 2))
                absCreditNumber = String.Format("{0:000000000000000000.00#}", 0.00)

            End If

            OutString = "Records: " & rows & " Debits: " & absDebitsNumber & " Credits: " & absCreditNumber.Trim
            writer.WriteLine(OutString)

            writer.Flush()
            writer.Close()
        End Sub
    End Class

#End Region

#Region " TRANS "

    Public Class TRANS

        Inherits JHLBase

        Private ErrorCount As Integer = 0
        Public Sub New()

            MyBase.New()
            MyBase.InterfaceKey = "JHLI.GL"
            MyBase.Name = "TRANS"

            Me.[CLM].Add("TRANS", New JHLI.GL.CLM.TRANS)
            Me.[CLM].Add("HEADER", New JHLI.GL.CLM.PRELOAD)
            ' Me.[CLM].Add("TRAILER", New JHLI.GL.CLM.Trailer)
            'Me.[CLM].Add("HEADER", New JHLI.GL.CLM.Header)

            NotificationSeconds = 1
            'Comment out to disable the DataLoader
            Me.DataLoader = New dataloader.DataLoader

        End Sub
        Public Overrides Function InitDataSource() As Boolean

            Try
                ' Me.InterfaceKey = "Generic.client"
                Me.DataSource = New DataSource.TRANS(Args.cmdLnArgs)
                Me.Args.DataListingSet = New Base.Lookup.DataListing(InterfaceKey)
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

#End Region



End Namespace
