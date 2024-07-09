Imports System.IO
Imports Se2.ISI.Base.Objects
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Se2.ISI.Client.JHLI.GL.Processors

Namespace Se2.ISI.Client.JHLI.GL

    Public Class Controller
        Inherits BaseController

        Private curProcessor As IProcessor
        Private Results As New List(Of Result)
        Public Event ControllerFinished(ByVal e As List(Of Result))
        Private messageIDList As Dictionary(Of String, Integer)
        Private _MsgItem As MessageItem = Nothing

        Public Sub New()

            MyBase.New()

            Processors.Add(New ProcessorNV("TRANS", New Processors.TRANS))
            Processors.Add(New ProcessorNV("GL_ADH", New Processors.GL_ADH))

        End Sub

        Public Overrides Function Process() As List(Of Result)

            Dim Processor As String

            If IsNothing(Args.cmdLnArgs.PROCESSOR) Then
                Processor = String.Empty
            Else
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
            se2Ex = Nothing

            For Each NVProcessor As ProcessorNV In Processors
                Try

                    If (DirectCast(NVProcessor.Value, BaseProcessor).Name.ToUpper = Args.cmdLnArgs.PROCESSOR.ToUpper) Then
                        NVProcessor.Value.Args = Me.Args
                        NVProcessor.Value.InitDataSource()
                        Results.Add(NVProcessor.Value.Process)

                        If NVProcessor.Value.Args.ProcessedRecords > 0 Then
                            se2Ex = validateExecution(NVProcessor)
                        End If
                        If Not (se2Ex Is Nothing) Then
                            Throw se2Ex
                        End If
                    End If
                Catch ex As Exception
                    If TypeOf ex Is se2Exception Then
                        se2Ex = DirectCast(ex, se2Exception)
                    Else
                        se2Ex = New se2Exception(ex)
                    End If
                    If Results.Count > 0 Then   ' Added 11/24/14 SRH
                        Results(0).Status = False 'add this to fail file
                    End If
                    se2Ex.Controller = Me.GetType.FullName
                    se2Ex.Processor = NVProcessor.Value.GetType.FullName
                    se2Ex.InterfaceKey = CType(NVProcessor.Value, BaseProcessor).InterfaceKey
                    se2Ex.SeverityLevel = EXCEPTION_SEVERITY.HIGH
                    se2ExceptionHandler.HandleExceptionPublishing(se2Ex)

                    '	Dim exDM As ExceptionDM = New ExceptionDM 'add this to get message on failed file
                    '	exDM.SendException(se2Ex.ExceptionID)  'add this to get message on failed file

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

                    If NVProcessor.Value.Args.ProcessedRecords > 0 Then
                        se2Ex = validateExecution(NVProcessor)
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
        Private Function validateExecution(nvprocessor As Se2.ISI.Base.Processing.ProcessorNV) As se2Exception

            Dim se2Ex As se2Exception
            se2Ex = Nothing

            Dim _Hdr_count As Long = 0
            Dim _File_Count As Long = 0
            Dim _hdr_Value As Decimal = 0
            Dim _file_Value As Decimal = 0
            Dim _type As String

            Dim _processor As String
            Dim _fileName As String = ""

            If nvprocessor.Name = "TRANS" Then
                _processor = "CLM_TRANS"
            Else
                _processor = "CLM_GL_ADH"
            End If

            If nvprocessor.Name = "TRANS" Then
                _fileName = "GL"
            Else
                _fileName = "GL ADH"
            End If

            If nvprocessor.Value.ProcessorMessages(_processor).Count > 0 Then
                _type = "Errors"
                _MsgItem = New MessageItem() With {.Key = "TOTAL_ERROR_COUNT",
                                   .Message = "Count",
                                    .Value = "COUNT~",
                                   .Detail = nvprocessor.Value.Args.Accumulators("TOTAL_ERRORS").ToString + "~"}
                nvprocessor.Value.ProcessorMessages(_processor).AddEntry("TOTAL_ERRORS", _MsgItem)
                se2Ex = New se2Exception(New System.Exception("GL Summary processing has failed."))
                se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
            Else
                _type = "Controls"
            End If

            _Hdr_count = Convert.ToInt64(nvprocessor.Value.Args.Accumulators("PS_COUNT"))
            _File_Count = nvprocessor.Value.Args.ProcessedRecords
            _hdr_Value = Math.Round(Convert.ToDecimal(nvprocessor.Value.Args.Accumulators("PS_DEBITS")), 2)
            _file_Value = Math.Round(Convert.ToDecimal(nvprocessor.Value.Args.Accumulators("DEBITS")), 2)

            '' new controls start 
            If _Hdr_count <> _File_Count Then
                _MsgItem = New MessageItem() With {.Key = "HDR_COMPARE",
                                   .Message = "Header Count and File Count do not match.",
                                   .Value = "Header Count~File Count" + "~",
                                   .Detail = _Hdr_count.ToString + "~" + _File_Count.ToString + "~"}
                nvprocessor.Value.ProcessorMessages(_processor).AddEntry("HDR_COMPARE", _MsgItem)
                nvprocessor.Value.ProcessorMessages(_processor).Instance = nvprocessor.Value.Instance
                messageIDList = nvprocessor.Value.ProcessorMessages(_processor).Persist(nvprocessor.Value.Instance)
                nvprocessor.Value.ProcessorMessages(_processor).Subject = nvprocessor.Value.ProcessorMessages(_processor).MessageOrigin + ": JHLI " + _fileName + " " + _type + " for cycle date: " + nvprocessor.Value.Args.cmdLnArgs.CYCLEDATE.ToShortDateString


                Try
                    Dim msgDM As MessageDM = New MessageDM()
                    msgDM.SendMessage(nvprocessor.Value.ProcessorMessages(_processor), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
                Catch ex As Exception
                    se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
                    se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
                End Try

                se2Ex = New se2Exception(New System.Exception("GL Summary processing has failed."))
                se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT

            ElseIf _hdr_Value <> _file_Value Then
                _MsgItem = New MessageItem() With {.Key = "HDR_COMPARE",
                                   .Message = "Header Debits and File Debits do not match.",
                                   .Value = "Header Debits~File Debits" + "~",
                                   .Detail = _hdr_Value.ToString("N") + "~" + _file_Value.ToString("N") + "~"}
                nvprocessor.Value.ProcessorMessages(_processor).AddEntry("HDR_COMPARE", _MsgItem)
                nvprocessor.Value.ProcessorMessages(_processor).Instance = nvprocessor.Value.Instance

                messageIDList = nvprocessor.Value.ProcessorMessages(_processor).Persist(nvprocessor.Value.Instance)
                nvprocessor.Value.ProcessorMessages(_processor).Subject = nvprocessor.Value.ProcessorMessages(_processor).MessageOrigin + ": JHLI " + _fileName + " " + _type + " for cycle date: " + nvprocessor.Value.Args.cmdLnArgs.CYCLEDATE.ToShortDateString
                Try
                    Dim msgDM As MessageDM = New MessageDM()
                    msgDM.SendMessage(nvprocessor.Value.ProcessorMessages(_processor), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
                Catch ex As Exception
                    se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
                    se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
                End Try

                se2Ex = New se2Exception(New System.Exception("GL Summary processing has failed."))
                se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT

            Else

                '' new controls end 


                '' everything worked out well but we still want to send a email with the total values 
                _MsgItem = New MessageItem() With {.Key = "HDR_COMPLETE",
                                           .Message = "Header File Controls agree.",
                                           .Value = "Header Count~File Count~Header Debits~File Debits" + "~",
                                           .Detail = _Hdr_count.ToString + "~" + _File_Count.ToString + "~" + _hdr_Value.ToString("N") + "~" + _file_Value.ToString("N") + "~"}
                nvprocessor.Value.ProcessorMessages(_processor).AddEntry("HDR_COMPLETE", _MsgItem)
                nvprocessor.Value.ProcessorMessages(_processor).Instance = nvprocessor.Value.Instance
                messageIDList = nvprocessor.Value.ProcessorMessages(_processor).Persist(nvprocessor.Value.Instance)
                nvprocessor.Value.ProcessorMessages(_processor).Subject = nvprocessor.Value.ProcessorMessages(_processor).MessageOrigin + ": JHLI " + _fileName + " " + _type + " for cycle date: " + nvprocessor.Value.Args.cmdLnArgs.CYCLEDATE.ToShortDateString
                Try
                    Dim msgDM As MessageDM = New MessageDM()
                    msgDM.SendMessage(nvprocessor.Value.ProcessorMessages(_processor), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
                Catch ex As Exception
                    se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
                    se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
                End Try
            End If
            Return se2Ex

        End Function
    End Class

End Namespace
