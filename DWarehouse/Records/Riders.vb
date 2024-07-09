Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " RIDERS "


    Public Class RIDERS
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        ''' <summary>
        ''' RJM 2020-01-17 SIINTDHW-317: added four new fields RD_PRIM_PERM_FLATX, RD_PRIM_PERM_FLATEX_RATE, RD_PRIM_PERM_FLATEX_PERD, RD_PRIM_TBL_RATING
        ''' </summary>
        Private Shadows Enum FieldList
            RD_CONT
            NAM_SOURCE
            RD_POL_NUM
            RD_COV_ID
            RD_STATE
            RD_TYPE_ID
            RD_DESC
            RD_DATE
            RD_TERM_DATE
            RD_START_DATE
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
            RD_FLATEX_PERM_AMT
            RD_FLATEX_TEMP_AMT
            RD_FLATEX_TEMP_DUR
            RD_TBL_RATING

        End Enum

        ''' <summary>
        ''' RJM 2020-01-17 SIINTDHW-317: added four new fields RD_PRIM_PERM_FLATX, RD_PRIM_PERM_FLATEX_RATE, RD_PRIM_PERM_FLATEX_PERD, RD_PRIM_TBL_RATING
        ''' </summary>
        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("RD_CONT", "RD_CONT"))
            Fields.Add(New FieldDef("NAM_SOURCE", "S:Se2"))
            Fields.Add(New FieldDef("RD_POL_NUM", "RD_POL_NUM"))
            Fields.Add(New FieldDef("RD_COV_ID", "RD_CVG_ID"))
            Fields.Add(New FieldDef("RD_STATE", "RD_STATE"))
            Fields.Add(New FieldDef("RD_TYPE_ID", "RD_TYPE_ID"))
            Fields.Add(New FieldDef("RD_DESC", "RD_DESC"))
            Fields.Add(New FieldDef("RD_DATE", #1/1/1900#, FieldType.Date, DateFmt, "RD_DATE"))
            Fields.Add(New FieldDef("RD_TERM_DATE", #1/1/1900#, FieldType.Date, DateFmt, "RD_TERM_DATE"))
            Fields.Add(New FieldDef("RD_START_DATE", #1/1/1900#, FieldType.Date, DateFmt, "RD_CLM_DATE"))
            Fields.Add(New FieldDef("RD_STATUS", "RD_STATUS"))
            Fields.Add(New FieldDef("RD_AGE_PRIM", "RD_AGE_PRIM"))
            Fields.Add(New FieldDef("RD_SEX_PRIM", "RD_SEX_PRIM"))
            Fields.Add(New FieldDef("RD_RT_CLASS_PRIM", "RD_RT_CLASS_PRIM"))
            Fields.Add(New FieldDef("RD_RT_CLASS_JT", "RD_RT_CLASS_JT"))
            Fields.Add(New FieldDef("RD_TBL_RATING_PRIM", 0, FieldType.Number, "0.00", "RD_TBL_RATING_PRIM"))
            Fields.Add(New FieldDef("RD_TBL_RATING_JT", 0, FieldType.Number, "0.00", "RD_TBL_RATING_JT"))
            Fields.Add(New FieldDef("RD_FLATEX_PRIM", 0, FieldType.Number, "0.00", "RD_FLATEX_PRIM"))
            Fields.Add(New FieldDef("RD_FLATEX_JT", 0, FieldType.Number, "0.00", "RD_FLATEX_JT"))
            Fields.Add(New FieldDef("RD_FLATEX_YEARS_PRIM", "RD_FLATEX_YEARS_PRIM"))
            Fields.Add(New FieldDef("RD_FLATEX_YEARS_JT", "RD_FLATEX_YEARS_JT"))
            Fields.Add(New FieldDef("RD_PREMIUM", 0, FieldType.Number, "0.00", "RD_PREMIUM"))
            Fields.Add(New FieldDef("RD_PREMIUM_MODE", "RD_PREMIUM_MODE"))
            Fields.Add(New FieldDef("RD_AGE_JT", "RD_AGE_JT"))
            Fields.Add(New FieldDef("RD_SEX_JT", "RD_SEX_JT"))
            Fields.Add(New FieldDef("RD_FACE_AMT", 0, FieldType.Number, "0.00", "RD_FACE_AMT"))
            Fields.Add(New FieldDef("RD_NAME_ID_PRIM", "RD_NAME_ID_PRIM"))
            Fields.Add(New FieldDef("RD_ORIG_FACE", 0, FieldType.Number, "0.00", "RD_ORIG_FACE"))
            Fields.Add(New FieldDef("RD_RATE_CLASS_TYPE_CODE", "RD_RATE_CLASS_TYPE_CODE"))
            Fields.Add(New FieldDef("RD_FLATEX_PERM_AMT", 0, FieldType.Number, "0.00", "RD_PRIM_PERM_FLATX"))
            Fields.Add(New FieldDef("RD_FLATEX_TEMP_AMT", 0, FieldType.Number, "0.00", "RD_PRIM_PERM_FLATEX_RATE"))
            Fields.Add(New FieldDef("RD_FLATEX_TEMP_DUR", 0, FieldType.Number, "0", "RD_PRIM_PERM_FLATEX_PERD"))
            Fields.Add(New FieldDef("RD_TBL_RATING", "F:GET_TABLE_RATING"))
        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property RD_CONT() As FieldDef
            Get
                Return Fields(FieldList.RD_CONT)
            End Get
        End Property
        Public ReadOnly Property NAM_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.NAM_SOURCE)
            End Get
        End Property
        Public ReadOnly Property RD_POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.RD_POL_NUM)
            End Get
        End Property
        Public ReadOnly Property RD_COV_ID() As FieldDef
            Get
                Return Fields(FieldList.RD_COV_ID)
            End Get
        End Property
        Public ReadOnly Property RD_STATE() As FieldDef
            Get
                Return Fields(FieldList.RD_STATE)
            End Get
        End Property
        Public ReadOnly Property RD_TYPE_ID() As FieldDef
            Get
                Return Fields(FieldList.RD_TYPE_ID)
            End Get
        End Property
        Public ReadOnly Property RD_DATE() As FieldDef
            Get
                Return Fields(FieldList.RD_DATE)
            End Get
        End Property
        Public ReadOnly Property RD_TERM_DATE() As FieldDef
            Get
                Return Fields(FieldList.RD_TERM_DATE)
            End Get
        End Property
        Public ReadOnly Property RD_START_DATE() As FieldDef
            Get
                Return Fields(FieldList.RD_START_DATE)
            End Get
        End Property
        Public ReadOnly Property RD_STATUS() As FieldDef
            Get
                Return Fields(FieldList.RD_STATUS)
            End Get
        End Property
        Public ReadOnly Property RD_AGE_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_AGE_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_RT_CLASS_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_RT_CLASS_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_RT_CLASS_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_RT_CLASS_JT)
            End Get
        End Property
        Public ReadOnly Property RD_DESC() As FieldDef
            Get
                Return Fields(FieldList.RD_DESC)
            End Get
        End Property
        Public ReadOnly Property RD_TBL_RATING_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_TBL_RATING_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_TBL_RATING_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_TBL_RATING_JT)
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_JT)
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_YEARS_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_YEARS_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_FLATEX_YEARS_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_YEARS_JT)
            End Get
        End Property
        Public ReadOnly Property RD_PREMIUM() As FieldDef
            Get
                Return Fields(FieldList.RD_PREMIUM)
            End Get
        End Property
        Public ReadOnly Property RD_PREMIUM_MODE() As FieldDef
            Get
                Return Fields(FieldList.RD_PREMIUM_MODE)
            End Get
        End Property
        Public ReadOnly Property RD_AGE_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_AGE_JT)
            End Get
        End Property
        Public ReadOnly Property RD_SEX_JT() As FieldDef
            Get
                Return Fields(FieldList.RD_SEX_JT)
            End Get
        End Property
        Public ReadOnly Property RD_FACE_AMT() As FieldDef
            Get
                Return Fields(FieldList.RD_FACE_AMT)
            End Get
        End Property
        Public ReadOnly Property RD_NAME_ID_PRIM() As FieldDef
            Get
                Return Fields(FieldList.RD_NAME_ID_PRIM)
            End Get
        End Property
        Public ReadOnly Property RD_ORIG_FACE() As FieldDef
            Get
                Return Fields(FieldList.RD_ORIG_FACE)
            End Get
        End Property
        Public ReadOnly Property RD_RATE_CLASS_TYPE_CODE() As FieldDef
            Get
                Return Fields(FieldList.RD_RATE_CLASS_TYPE_CODE)
            End Get
        End Property

        Public ReadOnly Property RD_FLATEX_PERM_AMT() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_PERM_AMT)
            End Get
        End Property

        Public ReadOnly Property RD_FLATEX_TEMP_AMT() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_TEMP_AMT)
            End Get
        End Property

        Public ReadOnly Property RD_FLATEX_TEMP_DUR() As FieldDef
            Get
                Return Fields(FieldList.RD_FLATEX_TEMP_DUR)
            End Get
        End Property

        Public ReadOnly Property RD_TBL_RATING() As FieldDef
            Get
                Return Fields(FieldList.RD_TBL_RATING)
            End Get
        End Property

#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace