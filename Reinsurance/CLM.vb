Imports Se2.ISI.Base
Imports Se2.ISI.Base.Presentation
Imports Se2.ISI.Base.Processing
Imports System.Runtime.CompilerServices
Imports Se2.ISI.Base.Xlat

Namespace Se2.ISI.Client.JHLI.Reinsurance.CLM
    Module ExtensionMethods
        <Extension()>
        Public Function [In](Of T)(ByVal item As T, ByVal ParamArray range() As T) As Boolean
            Return range.Cast(Of T).Contains(item)
        End Function
    End Module

#Region " TAI "

    Public Class TAI
        Inherits BaseLogic
        Private _xlatHelper As XlatHelper
        Private xlat As XlatObj
        Private _xlatMktSeg As String
        Public Shadows Property Se2Source As SourceLayouts.TAI

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TAI
            Se2Source = New SourceLayouts.TAI
            _xlatHelper = New XlatHelper("JHLI..Reinsurance")
            MyBase.Se2Source = Me.Se2Source
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GET_STATUS(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            Select Case Se2Source.CN_STATUS
                Case "ACTIVE"
                    retval = "PMP"
                Case "DTH CLM APRV"
                    retval = "DTH"
                Case "DTH CLM PD"
                    retval = "DTH"
                Case "DTH CLM PEND"
                    retval = "DTH"
                Case "EXPIRED"
                    retval = "EXP"
                Case "LAPSE"
                    retval = "LAP"
                Case "LAPSE PEND"
                    retval = "PMP"
                Case "MATURED"
                    retval = "MAT"
                Case "SURRENDERED"
                    retval = "SUR"
                Case "CANNOTTKN"
                    retval = "NTO"
                Case "RESCISSION"
                    retval = "NTO"
                Case "UNEMPLOYED"
                    retval = "PMP"
                Case "SUSPND ACT"
                    retval = "PMP"
                    ''inc000005260253 - we created a new status in fast 
                Case "CNCLFRLK"
                    retval = "NTO"
                Case Else
                    retval = "UNK"
            End Select

            Return retval

        End Function
        Public Function GET_NUM_PLAN_CODE(ByVal value As Se2Args) As String

            If Se2Source.RD_RIDER_TYPE_ID = "ROP" Then
                Return "000000001"
            Else
                Return "000000000"
            End If

        End Function
        Public Function GET_TERM_TRANS_DATE(ByVal value As Se2Args) As Date
            Dim retval As Date

            'If the contract is terminated and has a terminated date, then populate with term date - otherwise populate with last material change date. If
            'no material change date - then use the cycle date of the file.
            'For DTH CLM PEND, Approved or Paid - populate the Date of Death in this field if it is available, otherwise populate the date the status of the policy was 
            'changed From active to pending death

            'If Se2Source.CN_STATUS.In("SURRENDERED", "LAPSE", "TERMINATED") And Se2Source.CN_GRACE_PRD_END_DT <> #12/31/2999# Then
            '    retval = Se2Source.CN_GRACE_PRD_END_DT 'VG RAHR-4139 Changed CN_TERM_DATE to CN_GRACE_PRD_END_DT and also added "LAPSE", "TERMINATED"
            If Se2Source.CN_STATUS.In("SURRENDERED") And Se2Source.CN_TERM_DATE <> #12/31/2999# Then
                retval = Se2Source.CN_TERM_DATE
            ElseIf Se2Source.CN_STATUS.In("DTH CLM PEND", "DTH CLM APRV", "DTH CLM PD") And Se2Source.CN_DEATH_DATE <> #12/31/2999# Then
                retval = Se2Source.CN_DEATH_DATE
            ElseIf Se2Source.CN_STATUS.In("RESCISSION", "CANNOTTKN") Then
                retval = Se2Source.CN_ISSUE_DATE
            Else
                If Se2Source.CN_LST_TXN_DATE <> #12/31/2999# Then
                    retval = Se2Source.CN_LST_TXN_DATE
                Else
                    retval = value.SourceHeader.CYCLE_DATE
                End If
            End If
            Return retval
        End Function
        Public Function GET_GL_PROD_CD(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            '11/8/19 SH - Changed from a Case statement to an XLAT. Use Eclipse to update going forward
            xlat = New XlatObj()
            With xlat
                .addKey(Se2Source.RD_EXT_REF_TEXT)
                .XlatReturnField = "TAI_GL_PROD_CD"
            End With

            retval = _xlatHelper.getXlatValue(xlat).Trim

            Return retval
        End Function

        Public Function GET_HER_STATUS_1(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            'If terminated return N, otherwise B
            If Se2Source.CN_STATUS.In("SURRENDERED", "DTH CLM APRV") Then
                retval = "N"
            Else
                retval = "B"
            End If

            Return retval
        End Function

        Public Function GET_INS_STATUS(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            If Se2Source.CN_DEATH_DATE = #12/31/2999# Then
                retval = "A"
            Else
                retval = "D"
            End If

            Return retval

        End Function

        Public Function GET_LAST_NAME(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            If Se2Source.NA_SUFFIX.In("JR", "SR", "DDS", "DVM", "ESQ", "MD", "PHD", "II", "III", "IV", "V", "VI", "VII", "VIII") Then
                retval = Se2Source.NA_LST + " " + Se2Source.NA_SUFFIX
            Else
                retval = Se2Source.NA_LST
            End If

            Return retval
        End Function
        Public Function GET_RESIDENT_STATE(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            If Se2Source.AS_CTRY_CODE = "USA" Then
                retval = Se2Source.CN_RESIDENT_STATE
            Else
                Select Case Se2Source.AS_CTRY_CODE
                    Case "AE"
                        retval = "UE"
                    Case "AL"
                        retval = "AB"
                    Case "AR"
                        retval = "AH"
                    Case "AS"
                        retval = "AK"
                    Case "AZ"
                        retval = "AJ"
                    Case "CA"
                        retval = "CE"
                    Case "CO"
                        retval = "CB"
                    Case "DE"
                        retval = "GG"
                    Case "GA"
                        retval = "GB"
                    Case "ID"
                        retval = "IB"
                    Case "IL"
                        retval = "IS"
                    Case "IN"
                        retval = "II"
                    Case "KY"
                        retval = "CS"
                    Case "LA"
                        retval = "LD"
                    Case "MA"
                        retval = "MF"
                    Case "MD"
                        retval = "MQ"
                    Case "MI"
                        retval = "MW"
                    Case "MN"
                        retval = "OG"
                    Case "MS"
                        retval = "RR"
                    Case "MT"
                        retval = "TA"
                    Case "NC"
                        retval = "NW"
                    Case "NE"
                        retval = "NB"
                    Case "NH"
                        retval = "VN"
                    Case "PA"
                        retval = "PP"
                    Case "SC"
                        retval = "SS"
                    Case "SD"
                        retval = "SU"
                    Case "TN"
                        retval = "TU"
                    Case "VA"
                        retval = "VS"

                    Case Else
                        retval = Se2Source.AS_CTRY_CODE
                End Select
            End If

            Return retval

        End Function

        'Public Function GET_ISSUE_AGE(ByVal value As Se2Args) As String
        '    Dim retval As String = String.Empty

        '    'Return 99 until we can pull the field from Fast/Core
        '    retval = "99"

        '    Return retval
        'End Function

        'Public Function FunctionSplitDecimal(ByVal number As Decimal, ByRef wholePart As Decimal,
        '         ByRef fractionalPart As Decimal)
        '    wholePart = Math.Truncate(number)
        '    fractionalPart = number - wholePart
        'End Function

        Public Function GET_RD_FACE_AMT_BC(ByVal value As Se2Args) As String
            Dim retval As String = "000000000"
            Dim RD_FACE_AMT_STR As String = CStr(Se2Source.RD_FACE_AMT_BC)
            Dim leftFace As Integer = 0
            'Dim rightFace As String

            If InStr(CStr(RD_FACE_AMT_STR), ".") <> 0 Then
                leftFace = CInt(Split(RD_FACE_AMT_STR, ".")(0))
                'rightFace = Split(RD_FACE_AMT_STR, ".")(1)

                retval = CStr(leftFace.ToString("000000000")) ' Removing cents from returned value
            End If

            Return retval
        End Function
        Public Function GET_RD_FACE_AMT_ADB(ByVal value As Se2Args) As String
            Dim retval As String = "000000000"
            Dim RD_FACE_AMT_STR As String = CStr(Se2Source.RD_FACE_AMT_ADB)
            Dim leftFace As Integer = 0
            Dim rightFace As String

            If InStr(CStr(RD_FACE_AMT_STR), ".") <> 0 Then
                leftFace = CInt(Split(RD_FACE_AMT_STR, ".")(0))
                rightFace = Split(RD_FACE_AMT_STR, ".")(1)

                retval = CStr(leftFace.ToString("0000000")) + Left(rightFace, 2)
            End If

            Return retval
        End Function
        Public Function GET_RD_PREM_BC(ByVal value As Se2Args) As String
            Dim retval As String = "000000000"
            Dim RD_PREM_BC_STR As String = CStr(Se2Source.RD_ANN_PREM_AMT_BC)
            Dim leftFace As Int32 = 0
            Dim rightFace As String

            If InStr(CStr(RD_PREM_BC_STR), ".") <> 0 Then
                leftFace = CInt(Split(RD_PREM_BC_STR, ".")(0))
                rightFace = Split(RD_PREM_BC_STR, ".")(1)

                retval = CStr(leftFace.ToString("0000000")) + Left(rightFace, 2)
            End If

            Return retval
        End Function

        Public Function GET_RD_PREM_ADB(ByVal value As Se2Args) As String
            Dim retval As String = "000000000"
            Dim RD_PREM_ADB_STR As String = CStr(Se2Source.RD_PREM_ADB)
            Dim leftFace As Integer = 0
            Dim rightFace As String

            If InStr(CStr(RD_PREM_ADB_STR), ".") <> 0 Then
                leftFace = CInt(Split(RD_PREM_ADB_STR, ".")(0))
                rightFace = Split(RD_PREM_ADB_STR, ".")(1)

                retval = CStr(leftFace.ToString("0000000")) + Left(rightFace, 2)
            End If

            Return retval
        End Function

        Public Function GET_RD_RATING_WAIVER_AMT(ByVal value As Se2Args) As String
            Dim retval As String = "000000000"
            Dim RD_RATING_WAIVER_AMT_STR As String = CStr(Se2Source.RD_RATING_WAIVER_AMT)
            Dim leftFace As Integer = 0
            Dim rightFace As String

            If InStr(CStr(RD_RATING_WAIVER_AMT_STR), ".") <> 0 Then
                leftFace = CInt(Split(RD_RATING_WAIVER_AMT_STR, ".")(0))
                rightFace = Split(RD_RATING_WAIVER_AMT_STR, ".")(1)

                retval = CStr(leftFace.ToString("0000000")) + Left(rightFace, 2)
            End If

            Return retval
        End Function

        Public Function GET_VALUES_DATE(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty
            Dim valdate As Date = Se2Source.CN_LAST_MAV_DATE
            Dim IssueDate As Date = Se2Source.CN_ISSUE_DATE
            Dim LastTransDate As Date = Se2Source.CN_LST_TXN_DATE

            'Values Date = Date of Last Anniversary or MAV but if that has not occurred set to Issue date, unless there is a Material Change Date
            If valdate = #12/31/2999# Then
                If LastTransDate <> #12/31/2999# Then
                    retval = CStr(Year(LastTransDate)) + CStr(Month(LastTransDate)).PadLeft(2, "0"c)
                Else
                    retval = CStr(Year(IssueDate)) + CStr(Month(IssueDate)).PadLeft(2, "0"c)
                End If
            Else
                retval = CStr(Year(valdate)) + CStr(Month(valdate)).PadLeft(2, "0"c)
            End If

            Return retval
        End Function

        Public Function GET_CLASS_1(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            Select Case Se2Source.RD_PRIM_RATE_CODE
                Case "STNDRD NTB"
                    retval = "SN"
                Case "STNDRD TBC"
                    retval = "SS"
                Case "PREFERED NTB", "PREFERED"
                    retval = "PN"
                Case "PREFERED TBC"
                    retval = "PS"
                Case "STNDRD NTBP"
                    retval = "EN"
                Case "SUPERPRF NTB"
                    retval = "LN"
                Case Else
                    retval = ""
            End Select

            Return retval
        End Function

        Public Function GET_AB_STATUS_CD(ByVal value As Se2Args) As String
            Dim retval As String = String.Empty

            If Se2Source.ABR_FLAG = False Then
                retval = "N"
            ElseIf Se2Source.ABR_FLAG = True And Se2Source.RD_RIDER_STATUS = "ACTIVE" Then
                retval = "Y"
            ElseIf Se2Source.ABR_FLAG = True And Se2Source.RD_RIDER_STATUS = "" Then '4/25/18 SH: This is incomplete. This is a day 2 item and currently we don't have a way to track these riders
                retval = "A"
            ElseIf Se2Source.ABR_FLAG = True And Se2Source.RD_RIDER_STATUS = "TERM" Then
                retval = "E"
            End If

            Return retval
        End Function
#End Region

    End Class

#End Region


End Namespace