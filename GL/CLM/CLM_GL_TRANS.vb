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
Imports System.Text

Namespace Se2.ISI.Client.JHLI.GL.CLM

#Region " TRANS "

    Public Class TRANS
        Inherits BaseLogic
        Private _MsgItem As MessageItem = Nothing
        Private _xlatHelper As XlatHelper
        Private xlat As XlatObj
        Private _xlatMktSeg As String
        Public Shadows Property Se2Source As SourceLayouts.DETAIL

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.DETAIL
            Se2Source = New SourceLayouts.DETAIL
            MyBase.Se2Source = Me.Se2Source
            _xlatHelper = New XlatHelper("JHLI.GL")

        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function PRODUCT(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty
            If Se2Source.ACCOUNT = "299038" Then
                Dim iii As Int16 = 0
            End If

            If Se2Source.PRODUCT <> "" Then  ' BEC as per MG email Fri 3/2/2018 12:19 PM

                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.PRODUCT)
                    .XlatReturnField = "PRODUCT_CODE"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "PRODUCT CODE translation missing: " + Se2Source.PRODUCT
                    If addError(value, _b) Then
                        'error logging 
                        _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "PRODUCT Code did not map properly.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                        MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                    End If

                End If
            Else ' BEC as per MG email Fri 3/2/2018 12:19 PM
                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.ACCOUNT.ToString & "a")
                    .XlatReturnField = "PRODUCT_CODE"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "PRODUCT CODE translation missing FOR BLANK PRODUCT  this ACCOUNT" + Se2Source.ACCOUNT
                    If value.Accumulators.ContainsKey(_b) Then
                        Return ""
                    End If
                    If addError(value, _b) Then
                        'error logging 
                        _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "PRODUCT Code did not map properly.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                        MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                    End If

                End If
            End If

            Return _a

        End Function
        Public Function ACCOUNT(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty
            ' If Se2Source.PRODUCT <> "" Then


            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.ACCOUNT)
                .XlatReturnField = "ACCOUNT_CODE"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "ACCOUNT CODE translation missing for retreiving ACCOUNT: " + Se2Source.ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "ACCOUNT Code did not map properlY.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If
            '  End If

            Return _a

        End Function

        Public Function COSTCENTER(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty
            If Se2Source.ACCOUNT = "718003" Then

                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.ACCOUNT.ToString & "c")
                    .XlatReturnField = "COST_CENTER"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "ACCOUNT CODE translation missing for retreiving ACCOUNT: " + Se2Source.ACCOUNT
                    If addError(value, _b) Then
                        'error logging 
                        _MsgItem = New MessageItem() With
                                {.Key = xlat.XlatReturnField, .Message = "ACCOUNT Code did not map properlY.",
                                 .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                        MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                    End If

                End If

            End If

            Return _a

        End Function

        Public Function REPORT(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty

            If value.DataListingSet.Contains("SUSPENSE", Se2Source.ACCOUNT) Then
                Return Se2Source.JRNL_DATE.ToString("yyMMdd") 'Now.ToString("yyMMdd")
            End If

            Return _a

        End Function

        Public Function SUBACCOUNT(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty
            ' If Se2Source.PRODUCT <> "" Then


            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.ACCOUNT)
                .XlatReturnField = "SUBACCOUNT"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "ACCOUNT CODE translation missing for retreiving SUBACCOUNT: " + Se2Source.ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "ACCOUNT Code did not map properly retrieving SUBACCOUNT.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If
            '  End If

            Return _a

        End Function
        Public Function LEGAL_ENITTY(ByVal value As Se2Args) As Object

            '' this is done once at the beginning and is used thru-out
            Dim _a As String = String.Empty
            ' If Se2Source.PRODUCT <> "" Then


            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.BUS_UNIT)
                .XlatReturnField = "LEGAL_ENTITY"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "LEGAL_ENTITY translation missing for retreiving BUS_UNIT: " + Se2Source.ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "LEGAL_ENTITY Code did not map properly retrieving BUS_UNIT.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If
            '  End If

            Return _a

        End Function

        Public Function STATE(ByVal value As Se2Args) As Object

            If Se2Source.ACCOUNT = "204043" Then
                Dim iii As Int16 = 0
            End If

            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.ACCOUNT)
                .XlatReturnField = "STATE_REQ"
            End With

            Dim _a As String = _xlatHelper.getXlatValue(xlat).Trim

            'If _a = String.Empty Then
            '    xlat = New XlatObj()
            '    With xlat
            '        .addKey(Se2Source.ACCOUNT)
            '        '.addKey(Se2Source.PRODUCT)
            '        .addKey(_xlatMktSeg)
            '        .XlatReturnField = "STATE_REQ"
            '    End With

            '    _a = _xlatHelper.getXlatValue(xlat).Trim
            'End If



            'If _a = String.Empty Then
            '    Dim _b As String = "ERR_XLAT_STATE_" + Se2Source.ACCOUNT + Se2Source.PRODUCT + _xlatMktSeg
            '    If addError(value, _b) Then
            '        'error logging 
            '        _MsgItem = New MessageItem() With
            '            {.Key = xlat.XlatReturnField + " - " + Se2Source.ACCOUNT + "|" + Se2Source.PRODUCT + "|" + _xlatMktSeg,
            '             .Message = "Account translation missing.",
            '             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
            '        MyBase.CLMMessages.AddEntry("State Code Validation", _MsgItem)
            '    End If
            'End If

            '              If value.DataListingSet.Contains("Valid State Code list", Se2Source.STATE) Then

            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.STATE)
                .XlatReturnField = "RESIDENT"
            End With

            Dim _c As String = _xlatHelper.getXlatValue(xlat).Trim

            If _c = String.Empty And _a = "Y" Then
                Dim _b As String = "ERR_XLAT_STATE_" + Se2Source.STATE + "for " + Se2Source.ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                        {.Key = xlat.XlatReturnField + " - " + Se2Source.ACCOUNT + "|" + Se2Source.PRODUCT + "|" + _xlatMktSeg,
                         .Message = "Account translation missing.",
                         .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry("State Code Validation", _MsgItem)
                End If
            End If
            'Else
            '    Dim _b As String = "ERR_STATE_" + Se2Source.ACCOUNT
            '    If addError(value, _b) Then
            '        'error logging 
            '        _MsgItem = New MessageItem() With
            '            {.Key = xlat.XlatReturnField + " - " + Se2Source.ACCOUNT + "|" + Se2Source.PRODUCT + "|" + _xlatMktSeg,
            '             .Message = "Invalid state code.",
            '             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
            '        MyBase.CLMMessages.AddEntry("State Code Validation", _MsgItem)
            '    End If


            Return _c

        End Function
        Public Function JRNL_DATE(ByVal value As Se2Args) As Object

            Return Se2Source.JRNL_DATE.ToString("yyyMMdd")

        End Function
        Public Function BATCH_DATE(ByVal value As Se2Args) As Object

            Return Se2Source.CYCLE_DATE.ToString("yyyMMdd")

        End Function
        Public Function CONTRACT(ByVal value As Se2Args) As Object
            Dim _a As String = "000000000000"
            If Se2Source.CONTRACT IsNot String.Empty Then
                _a = Left(_a, 4) & Right(Se2Source.CONTRACT, 8)
            End If
            Return "T" & _a
        End Function
        Public Function AMOUNT(ByVal value As Se2Args) As Object
            If Se2Source.AMOUNT > 0 Then
                value.Accumulators.AddToValue("DEBITS", Se2Source.AMOUNT)
            Else
                value.Accumulators.AddToValue("CREDITS", Se2Source.AMOUNT)
            End If
            value.Accumulators.AddToValue("COUNT", 1)
            Return Se2Source.AMOUNT

        End Function
#End Region
#Region " Generic Functions "

        Public Function addError(ByVal value As Se2Args, msg As String) As Boolean

            value.Accumulators.AddToValue(msg, 1)
            value.Accumulators.AddToValue("TOTAL_ERRORS", 1)
            Dim _value As Long = Convert.ToInt64(value.Accumulators(msg))

            If _value < 2 Then Return True

            Return False

        End Function

#End Region
    End Class

#End Region

End Namespace


