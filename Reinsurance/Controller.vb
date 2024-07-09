Imports System.IO
Imports Se2.ISI.Base.Objects
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Client.JHLI.Reinsurance.Processors


Namespace Se2.ISI.Client.JHLI.Reinsurance

    Public Class Controller
        Inherits BaseController

        Private curProcessor As IProcessor

        Private Results As New List(Of Result)

        Public Event ControllerFinished(ByVal e As List(Of Result))


        Public Sub New()
            MyBase.New()
            Processors.Add(New ProcessorNV("TAI", New Processors.TAI))

        End Sub

        Public Overrides Function Process() As List(Of Result)

            Dim Processor As String = String.Empty

            If Not IsNothing(Args.cmdLnArgs.PROCESSOR) Then
                Processor = Args.cmdLnArgs.PROCESSOR
            End If



            If Processor = String.Empty Then
                Return ProcessAll()
            Else
                Return ProcessSingle(Processor)
            End If

        End Function

        Private Function ProcessSingle(ByVal Processor As String) As List(Of Result)

            Dim se2Ex As se2Exception


            For Each NVProcessor As ProcessorNV In Processors
                Try

                    If (DirectCast(NVProcessor.Value, BaseProcessor).Name.ToUpper = Processor.ToUpper) Then
                        NVProcessor.Value.Args = Me.Args
                        NVProcessor.Value.InitDataSource()
                        'If Not (NVProcessor.Value.DataLoader Is Nothing) Then
                        '	NVProcessor.Value.DataLoader.ImportData = Args.cmdLnArgs.FLAG.ToUpper.StartsWith("T")
                        'End If
                        Results.Add(NVProcessor.Value.Process)
                    End If


                Catch ex As Exception

                    If TypeOf ex Is se2Exception Then
                        se2Ex = DirectCast(ex, se2Exception)
                    Else
                        se2Ex = New se2Exception(ex)
                    End If
                    se2Ex.Controller = Me.GetType.FullName
                    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                    se2Ex.InterfaceKey = CType(NVProcessor.Value, BaseProcessor).InterfaceKey
                    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)
                End Try
            Next


            RaiseEvent ControllerFinished(Results)
            Return Results

        End Function

        Private Function ProcessAll() As List(Of Result)

            Dim se2Ex As se2Exception


            For Each NVProcessor As ProcessorNV In Processors
                Try

                    Me.Args.cmdLnArgs.PROCESSOR = NVProcessor.Value.Name
                    NVProcessor.Value.Args = Me.Args
                    NVProcessor.Value.InitDataSource()
                    'If Not (NVProcessor.Value.DataLoader Is Nothing) Then
                    '	NVProcessor.Value.DataLoader.ImportData = Args.cmdLnArgs.FLAG.ToUpper.StartsWith("T")
                    'End If
                    Results.Add(NVProcessor.Value.Process)


                Catch ex As Exception

                    If TypeOf ex Is se2Exception Then
                        se2Ex = DirectCast(ex, se2Exception)
                    Else
                        se2Ex = New se2Exception(ex)
                    End If
                    se2Ex.Controller = Me.GetType.FullName
                    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                    se2Ex.InterfaceKey = CType(NVProcessor.Value, BaseProcessor).InterfaceKey
                    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)
                End Try
            Next

            RaiseEvent ControllerFinished(Results)
            Return Results

        End Function

    End Class
End Namespace