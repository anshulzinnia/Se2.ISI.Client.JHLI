Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports Se2.ISI.Base.Xlat
Imports Se2.ISI.Base.Messaging


Namespace Se2.ISI.Client.JHLI.GL.CLM

#Region " HEADER "

    Public Class HEADER
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.GL_ADH

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.HEADER
            Se2Source = New SourceLayouts.GL_ADH
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function CYCLE_DATE(ByVal value As Se2Args) As Object
            Return value.cmdLnArgs.CYCLEDATE.ToString("MM/dd/yyyy")
        End Function
        Public Function TOTAL_RECORDS(ByVal value As Se2Args) As Object
            Return value.ProcessedRecords
        End Function
        Public Function TOTAL_DEBITS(ByVal value As Se2Args) As Object
            Return Convert.ToDouble(value.Accumulators("DEBITS")).ToString("0.00")
        End Function
        Public Function TOTAL_CREDITS(ByVal value As Se2Args) As Object
            Return Convert.ToDouble(value.Accumulators("ABS_CREDITS")).ToString("0.00")
        End Function
#End Region

    End Class

#End Region
#Region " GL_ADH "

    Public Class GL_ADH
        Inherits BaseLogic
        Private _MsgItem As MessageItem = Nothing
        Private _xlatHelper As XlatHelper
        Private xlat As XlatObj
        Private _xlatMktSeg As String
        Public Shadows Property Se2Source As SourceLayouts.GL_ADH

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.GL_ADH
            Se2Source = New SourceLayouts.GL_ADH
            MyBase.Se2Source = Me.Se2Source
            _xlatHelper = New XlatHelper("JHLI.GL")
        End Sub


#Region " POPULATION FUNCTIONS "
        Public Function COMPANY(ByVal value As Se2Args) As Object 'USED TO BE LEGAL_ENITTY
            Dim _a As String = String.Empty

            'uses 34 to 80
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.GL_BUSINESS_UNIT)
                .InboundKeyType = "BUSINESS_AREA"
                .XlatReturnField = "LEGAL_ENTITY"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "LEGAL_ENTITY translation missing for retreiving BUS_UNIT: " + Se2Source.GL_ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "LEGAL_ENTITY Code did not map properly retrieving BUS_UNIT.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If

            Return _a
        End Function
        Public Function ACCOUNT(ByVal value As Se2Args) As Object
            Dim _a As String = String.Empty

            'uses 4 to 93
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.GL_ACCOUNT)
                .InboundKeyType = "ACCOUNT_CODE"
                .XlatReturnField = "ACCOUNT_CODE"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "ACCOUNT CODE translation missing for retreiving ACCOUNT: " + Se2Source.GL_ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "ACCOUNT Code did not map properlY.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If

            Return _a
        End Function

        Public Function SUBACCOUNT(ByVal value As Se2Args) As Object
            Dim _a As String = String.Empty

            'uses 4 to 93
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.GL_ACCOUNT)
                .InboundKeyType = "ACCOUNT_CODE"
                .XlatReturnField = "SUBACCOUNT"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "ACCOUNT CODE translation missing for retreiving SUBACCOUNT: " + Se2Source.GL_ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "ACCOUNT Code did not map properly retrieving SUBACCOUNT.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If

            Return _a

        End Function
        Public Function AMOUNT(ByVal value As Se2Args) As Object
            Dim abs_amount As Decimal = Math.Round(Math.Abs(Se2Source.GL_AMOUNT), 2)

            If Se2Source.GL_AMOUNT > 0 Then
                value.Accumulators.AddToValue("DEBITS", Se2Source.GL_AMOUNT)
            Else
                value.Accumulators.AddToValue("CREDITS", Se2Source.GL_AMOUNT)
                value.Accumulators.AddToValue("ABS_CREDITS", abs_amount)
            End If

            value.Accumulators.AddToValue("COUNT", 1)
            Return Se2Source.GL_AMOUNT
        End Function

        Public Function ISSUE_DATE(ByVal value As Se2Args) As Object
            Dim _retval As String
            If Se2Source.CN_ISSUE_DATE.ToString("MMddyyyy") = "12312999" Then
                _retval = ""
            Else
                _retval = Se2Source.CN_ISSUE_DATE.ToString("MM/dd/yyyy")
            End If
            Return _retval
        End Function
        Public Function JRNL_DATE(ByVal value As Se2Args) As Object
            Return Se2Source.GL_JRNL_DATE.ToString("MM/dd/yyyy")
        End Function

        Public Function PRODUCT(ByVal value As Se2Args) As Object

            Dim _a As String = String.Empty

            If Se2Source.GL_PRODUCT <> "" Then

                'uses 3 to 3
                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.GL_PRODUCT)
                    .InboundKeyType = "PRODUCT_CODE"
                    .XlatReturnField = "PRODUCT_CODE"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "PRODUCT CODE translation missing: " + Se2Source.GL_PRODUCT
                    If addError(value, _b) Then
                        'error logging 
                        _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "PRODUCT Code did not map properly.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                        MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                    End If

                End If
            Else
                'uses 48 to 3
                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.GL_ACCOUNT.ToString & "a")
                    .InboundKeyType = "ACCOUNT"
                    .XlatReturnField = "PRODUCT_CODE"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "PRODUCT CODE translation missing FOR BLANK PRODUCT  this ACCOUNT" + Se2Source.GL_ACCOUNT
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

        Public Function STATE(ByVal value As Se2Args) As Object
            Dim _state As String = ""

            If Se2Source.OWNER_STATE <> "" Then
                _state = Se2Source.OWNER_STATE
            Else
                _state = Se2Source.GL_CLASS_FLD
            End If

            'uses 4 to 93
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.GL_ACCOUNT)
                .InboundKeyType = "ACCOUNT_CODE"
                .XlatReturnField = "STATE_REQ"
            End With

            Dim _a As String = _xlatHelper.getXlatValue(xlat).Trim

            'uses 26 to 94
            xlat = New XlatObj()
            With xlat
                .addKey(_state)
                .InboundKeyType = "STATE_CODE"
                .XlatReturnField = "RESIDENT"
            End With

            Dim _c As String = _xlatHelper.getXlatValue(xlat).Trim

            If _c = String.Empty And _a = "Y" Then
                Dim _b As String = "ERR_XLAT_STATE_" + _state + "for " + Se2Source.GL_ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                        {.Key = xlat.XlatReturnField + " - " + Se2Source.GL_ACCOUNT + "|" + Se2Source.GL_PRODUCT + "|" + _xlatMktSeg,
                         .Message = "Account translation missing.",
                         .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry("State Code Validation", _MsgItem)
                End If
            End If

            Return _c

        End Function

        Public Function OWNER_ZIP(ByVal value As Se2Args) As Object
            Dim _zip As String = ""

            If Se2Source.OWNER_STATE = "" Then
                Return ""
            End If

            If Se2Source.OWNER_ZIP_SUFFIX <> "" Then
                _zip = Se2Source.OWNER_ZIP + "-" + Se2Source.OWNER_ZIP_SUFFIX
            Else
                _zip = Se2Source.OWNER_ZIP
            End If
            Return _zip
        End Function

        Public Function ISSUE_STATE(ByVal value As Se2Args) As Object

            'uses 26 to 94
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.CN_ISSUE_STATE)
                .InboundKeyType = "STATE_CODE"
                .XlatReturnField = "RESIDENT"
            End With

            Dim _c As String = _xlatHelper.getXlatValue(xlat).Trim

            Return _c

        End Function

        Public Function QUAL_IND(ByVal value As Se2Args) As Object
            Dim _retval As String = ""
            If Se2Source.GL_OPR_UNIT = "0" Or Se2Source.GL_OPR_UNIT = "" Then
                _retval = "N"
            Else
                _retval = "Y"
            End If
            Return _retval
        End Function

        Public Function COSTCENTER(ByVal value As Se2Args) As Object

            Dim _a As String = String.Empty

            If Se2Source.GL_ACCOUNT = "718003" Then
                'uses 4 to 97
                xlat = New XlatObj()
                With xlat
                    .addKey(Se2Source.GL_ACCOUNT.ToString & "c")
                    .InboundKeyType = "ACCOUNT_CODE"
                    .XlatReturnField = "COST_CENTER"
                End With

                _a = _xlatHelper.getXlatValue(xlat).Trim

                If _a = String.Empty Then
                    Dim _b As String = "ACCOUNT CODE translation missing for retreiving ACCOUNT: " + Se2Source.GL_ACCOUNT
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

        Public Function ORIG_TERRITORY(ByVal value As Se2Args) As Object
            'function used to be legal entity 
            Dim _a As String = String.Empty

            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.GL_BUSINESS_UNIT)
                .XlatReturnField = "LEGAL_ENTITY"
            End With

            _a = _xlatHelper.getXlatValue(xlat).Trim

            If _a = String.Empty Then
                Dim _b As String = "LEGAL_ENTITY translation missing for retreiving BUS_UNIT: " + Se2Source.GL_ACCOUNT
                If addError(value, _b) Then
                    'error logging 
                    _MsgItem = New MessageItem() With
                            {.Key = xlat.XlatReturnField, .Message = "LEGAL_ENTITY Code did not map properly retrieving BUS_UNIT.",
                             .Value = String.Join("~", Se2Source.Fields) + "~", .Detail = Se2Source.Record + "~"}
                    MyBase.CLMMessages.AddEntry(xlat.XlatReturnField, _MsgItem)
                End If

            End If

            Return _a

        End Function

        Public Function REPORT(ByVal value As Se2Args) As Object
            Dim _a As String = String.Empty
            If value.DataListingSet.Contains("SUSPENSE", Se2Source.GL_ACCOUNT) Then
                Return Se2Source.GL_JRNL_DATE.ToString("MM/dd/yyyy")
            End If
            Return _a
        End Function
        Public Function CONTRACT(ByVal value As Se2Args) As Object
            Dim _a As String = "000000000000"
            If Se2Source.GL_CONTRACT IsNot String.Empty Then
                _a = Left(_a, 4) & Right(Se2Source.GL_CONTRACT, 8)
            End If
            Return "T" & _a
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


