Imports System.IO
Imports Se2.ISI.Base.Objects
Imports Se2.ISI.Base.Utility
Imports Se2.ISI.Base.Exception
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Messaging
Imports Se2.ISI.Client.JHLI.DWarehouse.Processors

Namespace Se2.ISI.Client.JHLI.DWarehouse

    Public Class Controller
        Inherits BaseController

        Private curProcessor As IProcessor
        Private Results As New List(Of Result)
        Public Event ControllerFinished(ByVal e As List(Of Result))
        Private messageIDList As Dictionary(Of String, Integer)
        Private _MsgItem As MessageItem = Nothing

        Public Sub New()

            MyBase.New()
            Processors.Add(New ProcessorNV("ADDRESS", New Processors.ADDRESS))
            Processors.Add(New ProcessorNV("NAMES", New Processors.NAMES))
            Processors.Add(New ProcessorNV("PHONE", New Processors.PHONE))
            Processors.Add(New ProcessorNV("POLICY", New Processors.POLICY))
            Processors.Add(New ProcessorNV("ROLES", New Processors.ROLES))
            Processors.Add(New ProcessorNV("RIDER", New Processors.RIDER))
            Processors.Add(New ProcessorNV("TRANS", New Processors.TRANS))
            Processors.Add(New ProcessorNV("DPVALUES", New Processors.DPVALUES))
            Processors.Add(New ProcessorNV("DISB", New Processors.DISB))
            Processors.Add(New ProcessorNV("CLAIMS", New Processors.CLAIMS))
            Processors.Add(New ProcessorNV("CLAIMS_BENEFICIARY", New Processors.CLAIMS_BENEFICIARY))

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
                            'se2Ex = validateExecution(NVProcessor)
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
        'Private Function validateExecution(nvprocessor As Se2.ISI.Base.Processing.ProcessorNV) As se2Exception

        '    Dim se2Ex As se2Exception
        '    se2Ex = Nothing

        '    Dim _Hdr_count As Decimal = 0
        '    Dim _File_Count As Decimal = 0
        '    Dim _hdr_Value As Decimal = 0
        '    Dim _file_Value As Decimal = 0

        '    _Hdr_count = Convert.ToInt64(nvprocessor.Value.Args.Accumulators("PS_COUNT"))
        '    _File_Count = nvprocessor.Value.Args.ProcessedRecords
        '    _hdr_Value = Math.Round(Convert.ToDecimal(nvprocessor.Value.Args.Accumulators("PS_DEBITS")), 2)
        '    _file_Value = Math.Round(Convert.ToDecimal(nvprocessor.Value.Args.Accumulators("DEBITS")), 2)

        '    If nvprocessor.Value.Name = "DETAIL" Then
        '        If Math.Abs(Math.Round((Convert.ToDouble(nvprocessor.Value.Args.Accumulators("CREDITS"))), 2)) <> Math.Round(Convert.ToDouble(nvprocessor.Value.Args.Accumulators("DEBITS")), 2) Then
        '            _MsgItem = New MessageItem() With {.Key = "CD_OUTOFBALANCE",
        '                           .Message = "Credits and Debits do not match.",
        '                           .Value = "CREDITS~DEBITS" + "~",
        '                           .Detail = Math.Round((Convert.ToDouble(nvprocessor.Value.Args.Accumulators("CREDITS"))), 2).ToString + "~" + Math.Round(Convert.ToDouble(nvprocessor.Value.Args.Accumulators("DEBITS")), 2).ToString + "~"}
        '            nvprocessor.Value.ProcessorMessages("CLM_GLSM").AddEntry("CD_OUTOFBALANCE", _MsgItem)
        '        End If

        '        ' Reserve accounts balance check
        '        If Math.Abs(Math.Round((Convert.ToDouble(nvprocessor.Value.Args.Accumulators("RESERVE_CREDITS"))), 2)) <>
        '            Math.Round(Convert.ToDouble(nvprocessor.Value.Args.Accumulators("RESERVE_DEBITS")), 2) Then
        '            _MsgItem = New MessageItem() With {.Key = "RESERVE_CD_OUTOFBALANCE",
        '                                           .Message = "Reserve Credits and Reserve Debits do not match.",
        '                                           .Value = "RESERVE_CREDITS~RESERVE_DEBITS" + "~",
        '                                           .Detail = Math.Round((Convert.ToDouble(nvprocessor.Value.Args.Accumulators("RESERVE_CREDITS"))), 2).ToString + "~" +
        '                                           Math.Round(Convert.ToDouble(nvprocessor.Value.Args.Accumulators("RESERVE_DEBITS")), 2).ToString + "~"}
        '            nvprocessor.Value.ProcessorMessages("CLM_GLSM").AddEntry("RESERVE_CD_OUTOFBALANCE", _MsgItem)
        '        End If

        '    End If

        '    '' any other errors? 
        '    If nvprocessor.Value.ProcessorMessages("CLM_GLSM").Count > 0 Then
        '        nvprocessor.Value.ProcessorMessages("CLM_GLSM").Instance = nvprocessor.Value.Instance
        '        messageIDList = nvprocessor.Value.ProcessorMessages("CLM_GLSM").Persist(nvprocessor.Value.Instance)
        '        Try
        '            Dim msgDM As MessageDM = New MessageDM()
        '            msgDM.SendMessage(nvprocessor.Value.ProcessorMessages("CLM_GLSM"), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
        '        Catch ex As Exception
        '            se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
        '            se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
        '        End Try

        '        If nvprocessor.Value.Name = "DETAIL" Then
        '            ' this determines if file is held or sent DEL_GL_FILE_HOLD_REQUIRED
        '            If MyBase.Args.DataListingSet.Contains("JHLI_GL_FILE_HOLD_REQUIRED", "TRUE") Then
        '                se2Ex = New se2Exception(New System.Exception("GL Summary processing has been held for review."))
        '                se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
        '            ElseIf MyBase.Args.DataListingSet.Contains("JHLI_GL_FILE_HOLD_REQUIRED", "FALSE") Then
        '                ' Dont hold - do nothing 
        '            Else
        '                ' Value has not been set, hooked up correctly or any other value, safest is to HOLD
        '                se2Ex = New se2Exception(New System.Exception("GL Summary processing has been held for review. (No HOLD record was found or was invalid)"))
        '            End If
        '        End If

        '    End If

        '    '' new controls start 
        '    If _Hdr_count <> _File_Count Then
        '        _MsgItem = New MessageItem() With {.Key = "HDR_COMPARE",
        '                           .Message = "Header Count and File Count do not match.",
        '                           .Value = "Header Count~File Count" + "~",
        '                           .Detail = _Hdr_count.ToString + "~" + _File_Count.ToString + "~"}
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").AddEntry("HDR_COMPARE", _MsgItem)
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Instance = nvprocessor.Value.Instance
        '        messageIDList = nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Persist(nvprocessor.Value.Instance)
        '        Try
        '            Dim msgDM As MessageDM = New MessageDM()
        '            msgDM.SendMessage(nvprocessor.Value.ProcessorMessages("CLM_PRELOAD"), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
        '        Catch ex As Exception
        '            se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
        '            se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
        '        End Try

        '        se2Ex = New se2Exception(New System.Exception("GL Summary processing has failed."))
        '        se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT

        '    ElseIf _hdr_Value <> _file_Value Then
        '        _MsgItem = New MessageItem() With {.Key = "HDR_COMPARE",
        '                           .Message = "Header Debits and File Debits do not match.",
        '                           .Value = "Header Debits~File Debits" + "~",
        '                           .Detail = _hdr_Value.ToString + "~" + _file_Value.ToString + "~"}
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").AddEntry("HDR_COMPARE", _MsgItem)
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Instance = nvprocessor.Value.Instance
        '        messageIDList = nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Persist(nvprocessor.Value.Instance)
        '        Try
        '            Dim msgDM As MessageDM = New MessageDM()
        '            msgDM.SendMessage(nvprocessor.Value.ProcessorMessages("CLM_PRELOAD"), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
        '        Catch ex As Exception
        '            se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
        '            se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
        '        End Try

        '        se2Ex = New se2Exception(New System.Exception("GL Summary processing has failed."))
        '        se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT

        '    Else

        '        '' new controls end 


        '        '' everything worked out well but we still want to send a email with the total values 
        '        _MsgItem = New MessageItem() With {.Key = "HDR_COMPLETE",
        '                                   .Message = "Header File Controls agree.",
        '                                   .Value = "Header Count~File Count~Header Debits~File Debits" + "~",
        '                                   .Detail = _Hdr_count.ToString + "~" + _File_Count.ToString + "~" + _hdr_Value.ToString + "~" + _file_Value.ToString + "~"}
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").AddEntry("HDR_COMPLETE", _MsgItem)
        '        nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Instance = nvprocessor.Value.Instance
        '        messageIDList = nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Persist(nvprocessor.Value.Instance)
        '        If nvprocessor.Name = "DETAIL" Then
        '            nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Subject = nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").MessageOrigin + ": JHLI GL Controls for cycle date: " + nvprocessor.Value.Args.cmdLnArgs.CYCLEDATE.ToShortDateString
        '        Else
        '            nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").Subject = nvprocessor.Value.ProcessorMessages("CLM_PRELOAD").MessageOrigin + ": DIV GL Controls for cycle date: " + nvprocessor.Value.Args.cmdLnArgs.CYCLEDATE.ToShortDateString
        '        End If

        '        Try
        '            Dim msgDM As MessageDM = New MessageDM()
        '            msgDM.SendMessage(nvprocessor.Value.ProcessorMessages("CLM_PRELOAD"), CType(nvprocessor.Value, BaseProcessor).InterfaceKey)
        '        Catch ex As Exception
        '            se2Ex = New se2Exception(New System.Exception("Sending error message failed."))
        '            se2Ex.Activity = EXCEPTION_ACTIVITY.QUIT
        '        End Try
        '    End If
        '    Return se2Ex

        'End Function
    End Class

End Namespace
