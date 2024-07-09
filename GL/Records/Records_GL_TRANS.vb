Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.Records


#Region " TRANS "


    Public Class DETAIL
        Inherits RecordDef

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New()
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            DIVISION
            SYSTEM
            GLEVENT
            ACCTENTITY
            FUND
            LEDGER
            BATCH_DATE
            CURRENCY_CODE
            GLAMOUNT
            UNITS
            POSTING_DATE
            ACCOUNT
            SUBACCOUNT
            PRODUCT
            PARNONPAR
            REFERENCE
            DESCRIPTION
            PROJECT
            COST_CENTER
            ALT_CC
            RES
            ORIGTERR
            CONTRACT
            AGENT
            MEDIA
            MISC1
            REPORT
            CHECK
            CERT
            MISC2
            ALT_DATE
            DISTRIB
            BRTYPE
            BANKID
            ALT_PROJ
            ADM_ACCT
            TAX_ID
            AGNT_RNK
            CVRG
            OLD_ENTITY
            OLD_ACCT
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("DIVISION", "S:U"))
            Fields.Add(New FieldDef("SYSTEM", "S:1M"))
            Fields.Add(New FieldDef("GLEVENT", "S:B"))
            Fields.Add(New FieldDef("ACCTENTITY", "F:LEGAL_ENITTY"))
            Fields.Add(New FieldDef("FUND", "FUND"))
            Fields.Add(New FieldDef("LEDGER", "S:1"))
            Fields.Add(New FieldDef("BATCH_DATE", "F:BATCH_DATE"))
            Fields.Add(New FieldDef("CURRENCY_CODE", "S:USD")) ' "F:GET_FUND_NAME"))
            Fields.Add(New FieldDef("GLAMOUNT", "F:AMOUNT"))
            Fields.Add(New FieldDef("UNITS", "S:"))                             ' 10
            Fields.Add(New FieldDef("POSTING_DATE", "F:JRNL_DATE"))
            Fields.Add(New FieldDef("ACCOUNT", "F:ACCOUNT"))
            Fields.Add(New FieldDef("SUBACCOUNT", "F:SUBACCOUNT"))
            Fields.Add(New FieldDef("PRODUCT", "F:PRODUCT"))
            Fields.Add(New FieldDef("PARNONPAR", "S:2"))
            Fields.Add(New FieldDef("REFERENCE", "S:"))
            Fields.Add(New FieldDef("DESCRIPTION", "GL_ADMIN_TRAN_TYPE"))
            Fields.Add(New FieldDef("PROJECT", "S:"))
            Fields.Add(New FieldDef("COST_CENTER", "F:COSTCENTER"))
            Fields.Add(New FieldDef("ALT_CC", "S:"))                                '20
            Fields.Add(New FieldDef("RES", "F:STATE"))
            Fields.Add(New FieldDef("ORIGTERR", "S:20"))
            Fields.Add(New FieldDef("CONTRACT", "F:CONTRACT"))
            Fields.Add(New FieldDef("AGENT", "S:"))
            Fields.Add(New FieldDef("MEDIA", "S:"))                                 '25
            Fields.Add(New FieldDef("MISC1", "S:"))
            Fields.Add(New FieldDef("REPORT", "F:REPORT"))
            Fields.Add(New FieldDef("CHECK", "S:"))
            Fields.Add(New FieldDef("CERT", "S:"))
            Fields.Add(New FieldDef("MISC2", "S:"))
            Fields.Add(New FieldDef("ALT_DATE", "F:JRNL_DATE"))                     '30
            Fields.Add(New FieldDef("DISTRIB", "S:"))
            Fields.Add(New FieldDef("BRTYPE", "S:"))
            Fields.Add(New FieldDef("BANKID", "S:"))
            Fields.Add(New FieldDef("ALT_PROJ", "S:"))
            Fields.Add(New FieldDef("ADM_ACCT", "S:"))
            Fields.Add(New FieldDef("TAX_ID", "S:"))
            Fields.Add(New FieldDef("AGNT_RNK", "S:"))
            Fields.Add(New FieldDef("CVRG", "S:"))
            Fields.Add(New FieldDef("OLD_ENTITY", "S:"))
            Fields.Add(New FieldDef("OLD_ACCT", "S:"))                              '40

        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property DIVISION() As FieldDef
            Get
                Return Fields(FieldList.DIVISION)
            End Get
        End Property
        Public ReadOnly Property SYSTEM() As FieldDef
            Get
                Return Fields(FieldList.SYSTEM)
            End Get
        End Property
        Public ReadOnly Property GLEVENT() As FieldDef
            Get
                Return Fields(FieldList.GLEVENT)
            End Get
        End Property
        Public ReadOnly Property ACCTENTITY() As FieldDef
            Get
                Return Fields(FieldList.ACCTENTITY)
            End Get
        End Property
        Public ReadOnly Property FUND() As FieldDef
            Get
                Return Fields(FieldList.FUND)
            End Get
        End Property
        Public ReadOnly Property LEDGER() As FieldDef
            Get
                Return Fields(FieldList.LEDGER)
            End Get
        End Property
        Public ReadOnly Property BATCH_DATE() As FieldDef
            Get
                Return Fields(FieldList.BATCH_DATE)
            End Get
        End Property
        Public ReadOnly Property CURRENCY_CODE() As FieldDef
            Get
                Return Fields(FieldList.CURRENCY_CODE)
            End Get
        End Property
        Public ReadOnly Property GLAMOUNT() As FieldDef
            Get
                Return Fields(FieldList.GLAMOUNT)
            End Get
        End Property
        Public ReadOnly Property UNITS() As FieldDef
            Get
                Return Fields(FieldList.UNITS)
            End Get
        End Property
        Public ReadOnly Property POSTING_DATE() As FieldDef
            Get
                Return Fields(FieldList.POSTING_DATE)
            End Get
        End Property
        Public ReadOnly Property ACCOUNT() As FieldDef
            Get
                Return Fields(FieldList.ACCOUNT)
            End Get
        End Property
        Public ReadOnly Property SUBACCOUNT() As FieldDef
            Get
                Return Fields(FieldList.SUBACCOUNT)
            End Get
        End Property
        Public ReadOnly Property PRODUCT() As FieldDef
            Get
                Return Fields(FieldList.PRODUCT)
            End Get
        End Property
        Public ReadOnly Property PARNONPAR() As FieldDef
            Get
                Return Fields(FieldList.PARNONPAR)
            End Get
        End Property
        Public ReadOnly Property REFERENCE() As FieldDef
            Get
                Return Fields(FieldList.REFERENCE)
            End Get
        End Property
        Public ReadOnly Property DESCRIPTION() As FieldDef
            Get
                Return Fields(FieldList.DESCRIPTION)
            End Get
        End Property
        Public ReadOnly Property PROJECT() As FieldDef
            Get
                Return Fields(FieldList.PROJECT)
            End Get
        End Property
        Public ReadOnly Property COST_CENTER() As FieldDef
            Get
                Return Fields(FieldList.COST_CENTER)
            End Get
        End Property
        Public ReadOnly Property ALT_CC() As FieldDef
            Get
                Return Fields(FieldList.ALT_CC)
            End Get
        End Property
        Public ReadOnly Property RES() As FieldDef
            Get
                Return Fields(FieldList.RES)
            End Get
        End Property
        Public ReadOnly Property ORIGTERR() As FieldDef
            Get
                Return Fields(FieldList.ORIGTERR)
            End Get
        End Property
        Public ReadOnly Property CONTRACT() As FieldDef
            Get
                Return Fields(FieldList.CONTRACT)
            End Get
        End Property
        Public ReadOnly Property AGENT() As FieldDef
            Get
                Return Fields(FieldList.AGENT)
            End Get
        End Property
        Public ReadOnly Property MEDIA() As FieldDef
            Get
                Return Fields(FieldList.MEDIA)
            End Get
        End Property
        Public ReadOnly Property MISC1() As FieldDef
            Get
                Return Fields(FieldList.MISC1)
            End Get
        End Property
        Public ReadOnly Property REPORT() As FieldDef
            Get
                Return Fields(FieldList.REPORT)
            End Get
        End Property
        Public ReadOnly Property CHECK() As FieldDef
            Get
                Return Fields(FieldList.CHECK)
            End Get
        End Property
        Public ReadOnly Property CERT() As FieldDef
            Get
                Return Fields(FieldList.CERT)
            End Get
        End Property
        Public ReadOnly Property MISC2() As FieldDef
            Get
                Return Fields(FieldList.MISC2)
            End Get
        End Property
        Public ReadOnly Property ALT_DATE() As FieldDef
            Get
                Return Fields(FieldList.ALT_DATE)
            End Get
        End Property
        Public ReadOnly Property DISTRIB() As FieldDef
            Get
                Return Fields(FieldList.DISTRIB)
            End Get
        End Property
        Public ReadOnly Property BRTYPE() As FieldDef
            Get
                Return Fields(FieldList.BRTYPE)
            End Get
        End Property
        Public ReadOnly Property BANKID() As FieldDef
            Get
                Return Fields(FieldList.BANKID)
            End Get
        End Property
        Public ReadOnly Property ALT_PROJ() As FieldDef
            Get
                Return Fields(FieldList.ALT_PROJ)
            End Get
        End Property
        Public ReadOnly Property ADM_ACCT() As FieldDef
            Get
                Return Fields(FieldList.ADM_ACCT)
            End Get
        End Property
        Public ReadOnly Property TAX_ID() As FieldDef
            Get
                Return Fields(FieldList.TAX_ID)
            End Get
        End Property
        Public ReadOnly Property AGNT_RNK() As FieldDef
            Get
                Return Fields(FieldList.AGNT_RNK)
            End Get
        End Property
        Public ReadOnly Property CVRG() As FieldDef
            Get
                Return Fields(FieldList.CVRG)
            End Get
        End Property
        Public ReadOnly Property OLD_ENTITY() As FieldDef
            Get
                Return Fields(FieldList.OLD_ENTITY)
            End Get
        End Property
        Public ReadOnly Property OLD_ACCT() As FieldDef
            Get
                Return Fields(FieldList.OLD_ACCT)
            End Get
        End Property
#End Region

#Region " METHODS "


#End Region

    End Class

#End Region
End Namespace





