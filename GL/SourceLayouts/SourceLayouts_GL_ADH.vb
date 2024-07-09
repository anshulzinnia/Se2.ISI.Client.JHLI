Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.SourceLayouts

#Region " GL_ADH "

    <Serializable()>
    Public Class GL_ADH
        Inherits SourceDef

#Region " FIELD ARRAY ENUM "

        Public Enum FieldList
            REC_TYPE
            GL_BUSINESS_UNIT
            GL_JRNL_DATE
            GL_ACCOUNT
            GL_JRNL_LN_REF
            GL_PRODUCT
            GL_FUND_CODE
            GL_OPR_UNIT
            GL_CLASS_FLD
            GL_AMOUNT
            GL_CONTRACT
            GL_ADMIN_TRAN_TYPE
            CN_PLN_CODE
            CN_ISSUE_DATE
            CN_ISSUE_STATE
            BROKER_ID
            OWNER_STATE
            OWNER_ZIP
            OWNER_ZIP_SUFFIX
            SERVREP_EXT_ID
        End Enum

#End Region

#Region " PUBLIC PROPERTIES "

        Public ReadOnly Property REC_TYPE() As String
            Get
                Return Values(FieldList.REC_TYPE)
            End Get
        End Property
        Public ReadOnly Property GL_BUSINESS_UNIT() As String
            Get
                Return Values(FieldList.GL_BUSINESS_UNIT)
            End Get
        End Property
        Public ReadOnly Property GL_JRNL_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.GL_JRNL_DATE))
            End Get
        End Property
        Public ReadOnly Property GL_ACCOUNT() As String
            Get
                Return Values(FieldList.GL_ACCOUNT)
            End Get
        End Property
        Public ReadOnly Property GL_JRNL_LN_REF() As String
            Get
                Return Values(FieldList.GL_JRNL_LN_REF)
            End Get
        End Property
        Public ReadOnly Property GL_PRODUCT() As String
            Get
                Return Values(FieldList.GL_PRODUCT)
            End Get
        End Property
        Public ReadOnly Property GL_FUND_CODE() As String
            Get
                Return Values(FieldList.GL_FUND_CODE)
            End Get
        End Property
        Public ReadOnly Property GL_OPR_UNIT() As String
            Get
                Return Values(FieldList.GL_OPR_UNIT)
            End Get
        End Property
        Public ReadOnly Property GL_CLASS_FLD() As String
            Get
                Return Values(FieldList.GL_CLASS_FLD)
            End Get
        End Property
        Public ReadOnly Property GL_AMOUNT() As Decimal
            Get
                Return Convert.ToDecimal(Values(FieldList.GL_AMOUNT))
            End Get
        End Property
        Public ReadOnly Property GL_CONTRACT() As String
            Get
                Return Values(FieldList.GL_CONTRACT)
            End Get
        End Property
        Public ReadOnly Property GL_ADMIN_TRAN_TYPE() As String
            Get
                Return Values(FieldList.GL_ADMIN_TRAN_TYPE)
            End Get
        End Property
        Public ReadOnly Property CN_PLN_CODE() As String
            Get
                Return Values(FieldList.CN_PLN_CODE)
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_DATE() As Date
            Get
                Return Date.Parse(Values(FieldList.CN_ISSUE_DATE))
            End Get
        End Property
        Public ReadOnly Property CN_ISSUE_STATE() As String
            Get
                Return Values(FieldList.CN_ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property BROKER_ID() As String
            Get
                Return Values(FieldList.BROKER_ID)
            End Get
        End Property
        Public ReadOnly Property OWNER_STATE() As String
            Get
                Return Values(FieldList.OWNER_STATE)
            End Get
        End Property
        Public ReadOnly Property OWNER_ZIP() As String
            Get
                Return Values(FieldList.OWNER_ZIP)
            End Get
        End Property
        Public ReadOnly Property OWNER_ZIP_SUFFIX() As String
            Get
                Return Values(FieldList.OWNER_ZIP_SUFFIX)
            End Get
        End Property
        Public ReadOnly Property SERVREP_EXT_ID() As String
            Get
                Return Values(FieldList.SERVREP_EXT_ID)
            End Get
        End Property
#End Region


#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New("~"c, [Enum].GetNames(GetType(FieldList)).ToList)
        End Sub
        Public Sub New(ByVal FieldList As List(Of String))
            MyBase.New("~"c, FieldList)
        End Sub

#End Region

    End Class

#End Region

End Namespace


