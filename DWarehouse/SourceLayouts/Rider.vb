Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.SourceLayouts

#Region " RIDER "

    Public Class RIDER
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "
        ''' <summary>
        ''' RJM 2020-01-17 SIINTDHW-317: added four new fields RD_PRIM_PERM_FLATX, RD_PRIM_PERM_FLATEX_RATE, RD_PRIM_PERM_FLATEX_PERD, RD_PRIM_TBL_RATING
        ''' </summary>
        Public Shadows Enum FieldList
            REC_TYPE
            RD_CONT
            RD_POL_NUM
            RD_CVG_ID
            RD_STATE
            RD_TYPE_ID
            RD_DESC
            RD_DATE
            RD_TERM_DATE
            RD_CLM_DATE
            RD_STATUS
            RD_AGE_PRIM
            RD_SEX_PRIM
            RD_RT_CLASS_PRIM
            RD_RT_CLASS_JT
            RD_TBL_RATING_PRIM
            RD_TBL_RATING_JT
            RD_FLATEX_PRIM
            RD_FLATEX_JT
            RD_FLATEX_YEARS_PRIM
            RD_FLATEX_YEARS_JT
            RD_PREMIUM
            RD_PREMIUM_MODE
            RD_AGE_JT
            RD_SEX_JT
            RD_FACE_AMT
            RD_NAME_ID_PRIM
            RD_ORIG_FACE
            RD_RATE_CLASS_TYPE_CODE
            RD_PRIM_PERM_FLATX
            RD_PRIM_PERM_FLATEX_RATE
            RD_PRIM_PERM_FLATEX_PERD
            RD_TABLE_RATING
        End Enum
#End Region

#Region " PUBLIC PROPERTIES "


        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property RD_POL_NUM() As String
            Get
                Return Values(FieldList.RD_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property RD_CVG_ID() As String
            Get
                Return Values(FieldList.RD_CVG_ID)
            End Get
        End Property
        Public ReadOnly Property RD_CONT() As String
            Get
                Return Values(FieldList.RD_CONT)
            End Get
        End Property
        Public ReadOnly Property RD_STATE() As String
            Get
                Return Values(FieldList.RD_STATE)
            End Get
        End Property
        Public ReadOnly Property RD_TYPE_ID() As String
            Get
                Return Values(FieldList.RD_TYPE_ID)
            End Get
        End Property
        Public ReadOnly Property RD_DESC() As String
            Get
                Return Values(FieldList.RD_DESC)
            End Get
        End Property
        Public ReadOnly Property RD_DATE() As Date
            Get
                Return Convert.ToDateTime(Values(FieldList.RD_DATE))
            End Get
        End Property
        Public ReadOnly Property RD_TERM_DATE() As Date
            Get
                Return Convert.ToDateTime(Values(FieldList.RD_TERM_DATE))
            End Get
        End Property
        Public ReadOnly Property RD_CLM_DATE() As Date
            Get
                Return Convert.ToDateTime(Values(FieldList.RD_CLM_DATE))
            End Get
        End Property
        Public ReadOnly Property RD_STATUS() As String
            Get
                Return Values(FieldList.RD_STATUS)
            End Get
        End Property
        Public ReadOnly Property RD_AGE_PRIM() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RD_AGE_PRIM))
            End Get
        End Property
        Public ReadOnly Property RD_SEX_PRIM() As String
            Get
                Return Values(FieldList.RD_SEX_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_RT_CLASS_PRIM() As String
            Get
                Return Values(FieldList.RD_RT_CLASS_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_RT_CLASS_JT() As String
            Get
                Return Values(FieldList.RD_RT_CLASS_JT)
            End Get
        End Property
        Public ReadOnly Property RD_TBL_RATING_PRIM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_TBL_RATING_PRIM))
            End Get
        End Property
        Public ReadOnly Property RD_TBL_RATING_JT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_TBL_RATING_JT))
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_PRIM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_FLATEX_PRIM))
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_YEARS_PRIM() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RD_FLATEX_YEARS_PRIM))
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_YEARS_JT() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RD_FLATEX_YEARS_JT))
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_JT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_FLATEX_JT))
            End Get
        End Property
        Public ReadOnly Property RD_PREMIUM() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_PREMIUM))
            End Get
        End Property
        Public ReadOnly Property RD_PREMIUM_MODE() As String
            Get
                Return Values(FieldList.RD_PREMIUM_MODE)
            End Get
        End Property
        Public ReadOnly Property RD_AGE_JT() As Integer
            Get
                Return Convert.ToInt32(Values(FieldList.RD_AGE_JT))
            End Get
        End Property
        Public ReadOnly Property RD_SEX_JT() As String
            Get
                Return Values(FieldList.RD_SEX_JT)
            End Get
        End Property
        Public ReadOnly Property RD_FACE_AMT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_FACE_AMT))
            End Get
        End Property
        Public ReadOnly Property RD_NAME_ID_PRIM() As String
            Get
                Return Values(FieldList.RD_NAME_ID_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_ORIG_FACE() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.RD_ORIG_FACE))
            End Get
        End Property
        Public ReadOnly Property RD_RATE_CLASS_TYPE_CODE() As String
            Get
                Return Values(FieldList.RD_RATE_CLASS_TYPE_CODE)
            End Get
        End Property

        Public ReadOnly Property RD_PRIM_PERM_FLATX() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.RD_PRIM_PERM_FLATX))
            End Get
        End Property

        Public ReadOnly Property RD_PRIM_PERM_FLATEX_RATE() As Decimal
            Get
                Return Decimal.Parse(Values(FieldList.RD_PRIM_PERM_FLATEX_RATE))
            End Get
        End Property

        Public ReadOnly Property RD_PRIM_PERM_FLATEX_PERD() As Integer
            Get
                Return Integer.Parse(Values(FieldList.RD_PRIM_PERM_FLATEX_PERD))
            End Get
        End Property

        Public ReadOnly Property RD_TABLE_RATING() As String
            Get
                Return Values(FieldList.RD_TABLE_RATING)
            End Get
        End Property


#End Region

#Region " CONSTRUCTORS "
        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
#End Region

    End Class

#End Region

End Namespace