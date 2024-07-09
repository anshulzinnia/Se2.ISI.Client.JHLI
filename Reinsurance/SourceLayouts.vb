Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.Reinsurance.SourceLayouts

#Region " TAI "

    Public Class TAI
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        Public Shadows Enum FieldList

            REC_TYPE
            CN_CONT
            CN_POL_NUM
            CN_STATUS
            CN_ISSUE_DATE
            CN_NEXT_ACTIVITY_DATE
            CN_TERM_DATE
            CN_ISSUE_STATE
            CN_RESIDENT_STATE
            CN_LAST_MAV_DATE
            CN_AGE_PRIM
            RD_CVG_ID
            RD_EXT_REF_TEXT
            RD_FACE_AMT_BC
            RD_FACE_AMT_ADB
            RD_ANN_PREM_AMT_BC
            RD_PREM_ADB
            RD_RATING_WAIVER_AMT
            RD_PRIM_RATE_CODE
            RD_RIDER_TYPE_ID
            NA_LST
            NA_FST
            NA_MID
            NA_SUFFIX
            NA_SEX
            NA_DOB
            CN_DEATH_DATE
            CN_LST_TXN_DATE
            ABR_FLAG
            RD_RIDER_STATUS
            AS_CTRY_CODE
            'CN_GRACE_PRD_END_DT 'VG RAHR-4139
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "

        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_CONT() As String
            Get
                Return Values(FieldList.CN_CONT)
            End Get
        End Property
        Public ReadOnly Property CN_POL_NUM() As String
            Get
                Return Values(FieldList.CN_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CN_STATUS() As String
            Get
                Return Values(FieldList.CN_STATUS)
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_ISSUE_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_NEXT_ACTIVITY_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_NEXT_ACTIVITY_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_TERM_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_TERM_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_STATE() As String
            Get
                Return Values(FieldList.CN_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property CN_RESIDENT_STATE() As String
            Get
                Return Values(FieldList.CN_RESIDENT_STATE)
            End Get
        End Property
        Public ReadOnly Property CN_LAST_MAV_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_LAST_MAV_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_AGE_PRIM() As Integer
            Get
                Return CInt(Values(FieldList.CN_AGE_PRIM))
            End Get
        End Property

        Public ReadOnly Property RD_CVG_ID() As String
            Get
                Return Values(FieldList.RD_CVG_ID)
            End Get
        End Property
        Public ReadOnly Property RD_EXT_REF_TEXT() As String
            Get
                Return Values(FieldList.RD_EXT_REF_TEXT)
            End Get
        End Property
        Public ReadOnly Property RD_FACE_AMT_BC() As Decimal
            Get
                Return CDec(Values(FieldList.RD_FACE_AMT_BC))
            End Get
        End Property

        Public ReadOnly Property RD_FACE_AMT_ADB() As Decimal
            Get
                Return CDec(Values(FieldList.RD_FACE_AMT_ADB))
            End Get
        End Property

        Public ReadOnly Property RD_ANN_PREM_AMT_BC() As Decimal
            Get
                Return CDec(Values(FieldList.RD_ANN_PREM_AMT_BC))
            End Get
        End Property
        Public ReadOnly Property RD_PREM_ADB() As Decimal
            Get
                Return CDec(Values(FieldList.RD_PREM_ADB))
            End Get
        End Property
        Public ReadOnly Property RD_RATING_WAIVER_AMT() As Decimal
            Get
                Return CDec(Values(FieldList.RD_RATING_WAIVER_AMT))
            End Get
        End Property
        Public ReadOnly Property RD_PRIM_RATE_CODE() As String
            Get
                Return Values(FieldList.RD_PRIM_RATE_CODE)
            End Get
        End Property
        Public ReadOnly Property RD_RIDER_TYPE_ID() As String
            Get
                Return Values(FieldList.RD_RIDER_TYPE_ID)
            End Get
        End Property
        Public ReadOnly Property NA_LST() As String
            Get
                Return Values(FieldList.NA_LST)
            End Get
        End Property
        Public ReadOnly Property NA_FST() As String
            Get
                Return Values(FieldList.NA_FST)
            End Get
        End Property
        Public ReadOnly Property NA_MID() As String
            Get
                Return Values(FieldList.NA_MID)
            End Get
        End Property
        Public ReadOnly Property NA_SUFFIX() As String
            Get
                Return Values(FieldList.NA_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property NA_SEX() As String
            Get
                Return Values(FieldList.NA_SEX)
            End Get
        End Property
        Public ReadOnly Property NA_DOB() As Date
            Get
                Return CDate(Values(FieldList.NA_DOB))
            End Get
        End Property
        Public ReadOnly Property CN_DEATH_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_DEATH_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_LST_TXN_DATE() As Date
            Get
                Return CDate(Values(FieldList.CN_LST_TXN_DATE))
            End Get
        End Property
        Public ReadOnly Property ABR_FLAG() As Boolean
            Get
                Return CBool(Values(FieldList.ABR_FLAG))
            End Get
        End Property
        Public ReadOnly Property RD_RIDER_STATUS() As String
            Get
                Return Values(FieldList.RD_RIDER_STATUS)
            End Get
        End Property
        Public ReadOnly Property AS_CTRY_CODE() As String
            Get
                Return Values(FieldList.AS_CTRY_CODE)
            End Get
        End Property
        ''VG RAHR-4139
        'Public ReadOnly Property CN_GRACE_PRD_END_DT() As Date
        '    Get
        '        Return CDate(Values(FieldList.CN_GRACE_PRD_END_DT))
        '    End Get
        'End Property
        ''End
#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class

#End Region

End Namespace