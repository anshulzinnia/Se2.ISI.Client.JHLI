Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.DWarehouse.Records

#Region " MVALUES "


    Public Class MVALUES
        Inherits DTL

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            MV_POLICY_NUMBER
            MV_VALUATION_DATE
            MV_BASE_CV
            MV_RIDER_CV
            MV_DB
            MV_NAR
            MV_FACE_AMT
            MV_FACE_PRIM
            MV_FACE_JT
            MV_FACE_OIR
            MV_FACE_TERM
            MV_FACE_CHILD
            MV_FACE_ADB
            MV_FACE_1YRTERM
            MV_CYTD_PREM
            MV_PYTD_PREM
            MV_TOTAL_PREM
            MV_ANN_PREM
            MV_ANN_POL_FEE
            MV_TARGET_PREM
            MV_PLANNED_MOD_PREM
            MV_INIT_PREM

        End Enum

        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("MV_POLICY_NUMBER", "MV_POLICY_NUMBER"))
            Fields.Add(New FieldDef("MV_VALUATION_DATE", #1/1/1900#, FieldType.Date, DateFmt, "MV_VALUATION_DATE"))
            Fields.Add(New FieldDef("MV_BASE_CV", "MV_BASE_CV"))
            Fields.Add(New FieldDef("MV_RIDER_CV", 0, FieldType.Number, "0.00", "MV_RIDER_CV"))
            Fields.Add(New FieldDef("MV_DB", 0, FieldType.Number, "0.00", "MV_DB"))
            Fields.Add(New FieldDef("MV_NAR", 0, FieldType.Number, "0.00", "MV_NAR"))
            Fields.Add(New FieldDef("MV_FACE_AMT", 0, FieldType.Number, "0.00", "MV_FACE_AMT"))
            Fields.Add(New FieldDef("MV_FACE_PRIM", 0, FieldType.Number, "0.00", "MV_FACE_PRIM"))
            Fields.Add(New FieldDef("MV_FACE_JT", 0, FieldType.Number, "0.00", "MV_FACE_JT"))
            Fields.Add(New FieldDef("MV_FACE_OIR", 0, FieldType.Number, "0.00", "MV_FACE_OIR"))
            Fields.Add(New FieldDef("MV_FACE_TERM", 0, FieldType.Number, "0.00", "MV_FACE_TERM"))
            Fields.Add(New FieldDef("MV_FACE_CHILD", 0, FieldType.Number, "0.00", "MV_FACE_CHILD"))
            Fields.Add(New FieldDef("MV_FACE_ADB", 0, FieldType.Number, "0.00", "MV_FACE_ADB"))
            Fields.Add(New FieldDef("MV_FACE_1YRTERM", 0, FieldType.Number, "0.00", "MV_FACE_1YRTERM"))
            Fields.Add(New FieldDef("MV_CYTD_PREM", 0, FieldType.Number, "0.00", "MV_CYTD_PREM"))
            Fields.Add(New FieldDef("MV_PYTD_PREM", 0, FieldType.Number, "0.00", "MV_PYTD_PREM"))
            Fields.Add(New FieldDef("MV_TOTAL_PREM", 0, FieldType.Number, "0.00", "MV_TOTAL_PREM"))
            Fields.Add(New FieldDef("MV_ANN_PREM", 0, FieldType.Number, "0.00", "MV_ANN_PREM"))
            Fields.Add(New FieldDef("MV_ANN_POL_FEE", 0, FieldType.Number, "0.00", "MV_ANN_POL_FEE"))
            Fields.Add(New FieldDef("MV_TARGET_PREM", 0, FieldType.Number, "0.00", "MV_TARGET_PREM"))
            Fields.Add(New FieldDef("MV_PLANNED_MOD_PREM", 0, FieldType.Number, "0.00", "v"))
            Fields.Add(New FieldDef("MV_INIT_PREM", 0, FieldType.Number, "0.00", "MV_INIT_PREM"))

        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property MV_PYTD_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_PYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_CYTD_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_CYTD_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_1YRTERM() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_1YRTERM)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_ADB() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_ADB)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_CHILD() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_CHILD)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_TERM() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_TERM)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_OIR() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_OIR)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_JT() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_JT)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_PRIM() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_PRIM)
            End Get
        End Property
        Public ReadOnly Property MV_FACE_AMT() As FieldDef
            Get
                Return Fields(FieldList.MV_FACE_AMT)
            End Get
        End Property
        Public ReadOnly Property MV_NAR() As FieldDef
            Get
                Return Fields(FieldList.MV_NAR)
            End Get
        End Property
        Public ReadOnly Property MV_DB() As FieldDef
            Get
                Return Fields(FieldList.MV_DB)
            End Get
        End Property
        Public ReadOnly Property MV_RIDER_CV() As FieldDef
            Get
                Return Fields(FieldList.MV_RIDER_CV)
            End Get
        End Property
        Public ReadOnly Property MV_BASE_CV() As FieldDef
            Get
                Return Fields(FieldList.MV_BASE_CV)
            End Get
        End Property
        Public ReadOnly Property MV_VALUATION_DATE() As FieldDef
            Get
                Return Fields(FieldList.MV_VALUATION_DATE)
            End Get
        End Property
        Public ReadOnly Property MV_POLICY_NUMBER() As FieldDef
            Get
                Return Fields(FieldList.MV_POLICY_NUMBER)
            End Get
        End Property
        Public ReadOnly Property MV_TOTAL_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_TOTAL_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_ANN_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_ANN_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_ANN_POL_FEE() As FieldDef
            Get
                Return Fields(FieldList.MV_ANN_POL_FEE)
            End Get
        End Property
        Public ReadOnly Property MV_TARGET_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_TARGET_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_PLANNED_MOD_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_PLANNED_MOD_PREM)
            End Get
        End Property
        Public ReadOnly Property MV_INIT_PREM() As FieldDef
            Get
                Return Fields(FieldList.MV_INIT_PREM)
            End Get
        End Property




#End Region

#Region " METHODS "


#End Region

    End Class

#End Region

End Namespace