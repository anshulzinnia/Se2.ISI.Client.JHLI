Imports Se2.ISI.Base.Presentation

Namespace Se2.ISI.Client.JHLI.GL.Records

#Region " HEADER "

    <Serializable()>
    Public Class HEADER
        Inherits RecordDef

        Private Shadows Enum FieldList
            DATA_SOURCE
            SYSTEM_CODE
            ORIG_CYCLE_ID
            BATCH_DATE
            RECORD_COUNT
            TOTAL_DEBITS
            TOTAL_CREDITS
            EXTRACT_TO_GL
        End Enum

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.PSTHDR
            Delimiter = ","c
            Terminator = vbCrLf
            Initialize()
        End Sub
        Private Sub Initialize()

            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("DATA_SOURCE", "S:SE2"))
            Fields.Add(New FieldDef("SYSTEM_CODE", "S:1M"))
            Fields.Add(New FieldDef("ORIG_CYCLE_ID", "S:"))
            Fields.Add(New FieldDef("BATCH_DATE", "F:CYCLE_DATE"))
            Fields.Add(New FieldDef("RECORD_COUNT", "F:TOTAL_RECORDS"))
            Fields.Add(New FieldDef("TOTAL_DEBITS", "F:TOTAL_DEBITS"))
            Fields.Add(New FieldDef("TOTAL_CREDITS", "F:TOTAL_CREDITS"))
            Fields.Add(New FieldDef("EXTRACT_TO_GL", "S:Y"))

        End Sub
#End Region

#Region " PROPERTIES "
        Public ReadOnly Property DATA_SOURCE() As FieldDef
            Get
                Return Fields(FieldList.DATA_SOURCE)
            End Get
        End Property
        Public ReadOnly Property SYSTEM_CODE() As FieldDef
            Get
                Return Fields(FieldList.SYSTEM_CODE)
            End Get
        End Property
        Public ReadOnly Property ORIG_CYCLE_ID() As FieldDef
            Get
                Return Fields(FieldList.ORIG_CYCLE_ID)
            End Get
        End Property
        Public ReadOnly Property BATCH_DATE() As FieldDef
            Get
                Return Fields(FieldList.BATCH_DATE)
            End Get
        End Property
        Public ReadOnly Property RECORD_COUNT() As FieldDef
            Get
                Return Fields(FieldList.RECORD_COUNT)
            End Get
        End Property
        Public ReadOnly Property TOTAL_DEBITS() As FieldDef
            Get
                Return Fields(FieldList.TOTAL_DEBITS)
            End Get
        End Property
        Public ReadOnly Property TOTAL_CREDITS() As FieldDef
            Get
                Return Fields(FieldList.TOTAL_CREDITS)
            End Get
        End Property
        Public ReadOnly Property EXTRACT_TO_GL() As FieldDef
            Get
                Return Fields(FieldList.EXTRACT_TO_GL)
            End Get
        End Property

#End Region


    End Class

#End Region

#Region " GL_ADH "


    Public Class GL_ADH
        Inherits RecordDef

#Region " CONSTRUCTORS "

        Public Sub New()
            MyBase.New(PresentationFormat.Delimited)
            Type = RecordType.DET
            Delimiter = ","c
            Terminator = vbCrLf
            Initialize()
        End Sub

        Private Shadows Enum FieldList
            POSTING_DATE
            COMPANY
            LEDGER_CODE
            ACCOUNT
            SUB_ACCOUNT
            CURRENCY
            DIVISION
            PAR_INDICATOR
            LINE_OF_BUS
            FUND
            AMOUNT
            POL_NUM
            CASE_NUM
            CASE_VERSION
            ISSUE_DATE
            EVENT_SEQ
            EVENT_CODE
            EVENT_DATE
            TXN_EFF_DATE
            TXN_CODE
            TXN_SUB_CODE
            TXN_DESC
            SYSTEM_CODE
            TXN_USER_ID
            PRODUCT_CODE
            PRODUCT_LINE_CODE
            PLAN_CODE
            INVS_ID
            PREM_STATE
            PREM_ZIP
            RESIDENT_STATE
            RESIDENT_ZIP
            ISSUE_STATE
            AGENT_ID
            BROKER_ID
            REINSURE_CODE
            QUAL_IND
            GL_EVENT
            SUSPENSE_CONTROL
            COST_CENTER
            ALT_COST_CENTER
            ORIG_TERRITORY
            REPORT
            LEGACY_SYS
            UNIVER_USER_ID
            ROLE_CODE
            JT_JRNL_LINE_NUM
            SNOW_TICKET
            ADJUST_JRNL_LINE_ID
            GROUP_BILL_NUM
            REFERENCE
            MISC_CODE1
            MISC_CODE2
            ALTDATE
        End Enum

        Private Sub Initialize()
            Fields = New List(Of FieldDef)
            Fields.Add(New FieldDef("POSTING_DATE", "F:JRNL_DATE"))
            Fields.Add(New FieldDef("COMPANY", "F:COMPANY"))
            Fields.Add(New FieldDef("LEDGER_CODE", "S:1"))
            Fields.Add(New FieldDef("ACCOUNT", "F:ACCOUNT"))
            Fields.Add(New FieldDef("SUB_ACCOUNT", "F:SUBACCOUNT"))
            Fields.Add(New FieldDef("CURRENCY", "S:USD"))
            Fields.Add(New FieldDef("DIVISION", "S:U"))
            Fields.Add(New FieldDef("PAR_INDICATOR", "S:2"))
            Fields.Add(New FieldDef("LINE_OF_BUS", "S:01"))
            Fields.Add(New FieldDef("FUND", "S:"))
            Fields.Add(New FieldDef("AMOUNT", "F:AMOUNT"))
            Fields.Add(New FieldDef("POL_NUM", "F:CONTRACT"))
            Fields.Add(New FieldDef("CASE_NUM", "S:"))
            Fields.Add(New FieldDef("CASE_VERSION", "S:"))
            Fields.Add(New FieldDef("ISSUE_DATE", "F:ISSUE_DATE"))
            Fields.Add(New FieldDef("EVENT_SEQ", "S:"))
            Fields.Add(New FieldDef("EVENT_CODE", "S:"))
            Fields.Add(New FieldDef("EVENT_DATE", "F:JRNL_DATE"))
            Fields.Add(New FieldDef("TXN_EFF_DATE", "F:JRNL_DATE"))
            Fields.Add(New FieldDef("TXN_CODE", "S:"))
            Fields.Add(New FieldDef("TXN_SUB_CODE", "S:"))
            Fields.Add(New FieldDef("TXN_DESC", "V:GL_ADMIN_TRAN_TYPE"))
            Fields.Add(New FieldDef("SYSTEM_CODE", "S:1M"))
            Fields.Add(New FieldDef("TXN_USER_ID", "S:"))
            Fields.Add(New FieldDef("PRODUCT_CODE", "F:PRODUCT"))
            Fields.Add(New FieldDef("PRODUCT_LINE_CODE", "S:115"))
            Fields.Add(New FieldDef("PLAN_CODE", "V:CN_PLN_CODE"))
            Fields.Add(New FieldDef("INVS_ID", "S:"))
            Fields.Add(New FieldDef("PREM_STATE", "F:STATE"))
            Fields.Add(New FieldDef("PREM_ZIP", "F:OWNER_ZIP"))
            Fields.Add(New FieldDef("RESIDENT_STATE", "F:STATE"))
            Fields.Add(New FieldDef("RESIDENT_ZIP", "F:OWNER_ZIP"))
            Fields.Add(New FieldDef("ISSUE_STATE", "F:ISSUE_STATE"))
            Fields.Add(New FieldDef("AGENT_ID", "V:SERVREP_EXT_ID"))
            Fields.Add(New FieldDef("BROKER_ID", "V:BROKER_ID"))
            Fields.Add(New FieldDef("REINSURE_CODE", "S:O"))
            Fields.Add(New FieldDef("QUAL_IND", "F:QUAL_IND"))
            Fields.Add(New FieldDef("GL_EVENT", "S:B"))
            Fields.Add(New FieldDef("SUSPENSE_CONTROL", "S:"))
            Fields.Add(New FieldDef("COST_CENTER", "F:COSTCENTER"))
            Fields.Add(New FieldDef("ALT_COST_CENTER", "S:"))
            Fields.Add(New FieldDef("ORIG_TERRITORY", "F:ORIG_TERRITORY"))
            Fields.Add(New FieldDef("REPORT", "F:REPORT"))
            Fields.Add(New FieldDef("LEGACY_SYS", "S:XX"))
            Fields.Add(New FieldDef("UNIVER_USER_ID", "S:"))
            Fields.Add(New FieldDef("ROLE_CODE", "S:"))
            Fields.Add(New FieldDef("JT_JRNL_LINE_NUM", "S:"))
            Fields.Add(New FieldDef("SNOW_TICKET", "S:"))
            Fields.Add(New FieldDef("ADJUST_JRNL_LINE_ID", "S:"))
            Fields.Add(New FieldDef("GROUP_BILL_NUM", "F:CONTRACT"))
            Fields.Add(New FieldDef("REFERENCE", "S:"))
            Fields.Add(New FieldDef("MISC_CODE1", "S:"))
            Fields.Add(New FieldDef("MISC_CODE2", "S:"))
            Fields.Add(New FieldDef("ALTDATE", "F:JRNL_DATE"))

        End Sub
#End Region

#Region " PROPERTIES "

        Public ReadOnly Property POSTING_DATE() As FieldDef
            Get
                Return Fields(FieldList.POSTING_DATE)
            End Get
        End Property
        Public ReadOnly Property COMPANY() As FieldDef
            Get
                Return Fields(FieldList.COMPANY)
            End Get
        End Property
        Public ReadOnly Property LEDGER_CODE() As FieldDef
            Get
                Return Fields(FieldList.LEDGER_CODE)
            End Get
        End Property
        Public ReadOnly Property ACCOUNT() As FieldDef
            Get
                Return Fields(FieldList.ACCOUNT)
            End Get
        End Property
        Public ReadOnly Property SUB_ACCOUNT() As FieldDef
            Get
                Return Fields(FieldList.SUB_ACCOUNT)
            End Get
        End Property
        Public ReadOnly Property CURRENCY() As FieldDef
            Get
                Return Fields(FieldList.CURRENCY)
            End Get
        End Property
        Public ReadOnly Property DIVISION() As FieldDef
            Get
                Return Fields(FieldList.DIVISION)
            End Get
        End Property
        Public ReadOnly Property PAR_INDICATOR() As FieldDef
            Get
                Return Fields(FieldList.PAR_INDICATOR)
            End Get
        End Property
        Public ReadOnly Property LINE_OF_BUS() As FieldDef
            Get
                Return Fields(FieldList.LINE_OF_BUS)
            End Get
        End Property
        Public ReadOnly Property FUND() As FieldDef
            Get
                Return Fields(FieldList.FUND)
            End Get
        End Property
        Public ReadOnly Property AMOUNT() As FieldDef
            Get
                Return Fields(FieldList.AMOUNT)
            End Get
        End Property
        Public ReadOnly Property POL_NUM() As FieldDef
            Get
                Return Fields(FieldList.POL_NUM)
            End Get
        End Property
        Public ReadOnly Property CASE_NUM() As FieldDef
            Get
                Return Fields(FieldList.CASE_NUM)
            End Get
        End Property
        Public ReadOnly Property CASE_VERSION() As FieldDef
            Get
                Return Fields(FieldList.CASE_VERSION)
            End Get
        End Property
        Public ReadOnly Property ISSUE_DATE() As FieldDef
            Get
                Return Fields(FieldList.ISSUE_DATE)
            End Get
        End Property
        Public ReadOnly Property EVENT_SEQ() As FieldDef
            Get
                Return Fields(FieldList.EVENT_SEQ)
            End Get
        End Property
        Public ReadOnly Property EVENT_CODE() As FieldDef
            Get
                Return Fields(FieldList.EVENT_CODE)
            End Get
        End Property
        Public ReadOnly Property EVENT_DATE() As FieldDef
            Get
                Return Fields(FieldList.EVENT_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_EFF_DATE() As FieldDef
            Get
                Return Fields(FieldList.TXN_EFF_DATE)
            End Get
        End Property
        Public ReadOnly Property TXN_CODE() As FieldDef
            Get
                Return Fields(FieldList.TXN_CODE)
            End Get
        End Property
        Public ReadOnly Property TXN_SUB_CODE() As FieldDef
            Get
                Return Fields(FieldList.TXN_SUB_CODE)
            End Get
        End Property
        Public ReadOnly Property TXN_DESC() As FieldDef
            Get
                Return Fields(FieldList.TXN_DESC)
            End Get
        End Property
        Public ReadOnly Property SYSTEM_CODE() As FieldDef
            Get
                Return Fields(FieldList.SYSTEM_CODE)
            End Get
        End Property
        Public ReadOnly Property TXN_USER_ID() As FieldDef
            Get
                Return Fields(FieldList.TXN_USER_ID)
            End Get
        End Property
        Public ReadOnly Property PRODUCT_CODE() As FieldDef
            Get
                Return Fields(FieldList.SYSTEM_CODE)
            End Get
        End Property
        Public ReadOnly Property PRODUCT_LINE_CODE() As FieldDef
            Get
                Return Fields(FieldList.PRODUCT_LINE_CODE)
            End Get
        End Property
        Public ReadOnly Property PLAN_CODE() As FieldDef
            Get
                Return Fields(FieldList.PLAN_CODE)
            End Get
        End Property
        Public ReadOnly Property INVS_ID() As FieldDef
            Get
                Return Fields(FieldList.INVS_ID)
            End Get
        End Property
        Public ReadOnly Property PREM_STATE() As FieldDef
            Get
                Return Fields(FieldList.PREM_STATE)
            End Get
        End Property
        Public ReadOnly Property PREM_ZIP() As FieldDef
            Get
                Return Fields(FieldList.PREM_ZIP)
            End Get
        End Property
        Public ReadOnly Property RESIDENT_STATE() As FieldDef
            Get
                Return Fields(FieldList.RESIDENT_STATE)
            End Get
        End Property
        Public ReadOnly Property RESIDENT_ZIP() As FieldDef
            Get
                Return Fields(FieldList.RESIDENT_ZIP)
            End Get
        End Property
        Public ReadOnly Property ISSUE_STATE() As FieldDef
            Get
                Return Fields(FieldList.ISSUE_STATE)
            End Get
        End Property
        Public ReadOnly Property AGENT_ID() As FieldDef
            Get
                Return Fields(FieldList.AGENT_ID)
            End Get
        End Property
        Public ReadOnly Property BROKER_ID() As FieldDef
            Get
                Return Fields(FieldList.BROKER_ID)
            End Get
        End Property
        Public ReadOnly Property REINSURE_CODE() As FieldDef
            Get
                Return Fields(FieldList.REINSURE_CODE)
            End Get
        End Property
        Public ReadOnly Property QUAL_IND() As FieldDef
            Get
                Return Fields(FieldList.QUAL_IND)
            End Get
        End Property
        Public ReadOnly Property GL_EVENT() As FieldDef
            Get
                Return Fields(FieldList.GL_EVENT)
            End Get
        End Property
        Public ReadOnly Property SUSPENSE_CONTROL() As FieldDef
            Get
                Return Fields(FieldList.SUSPENSE_CONTROL)
            End Get
        End Property
        Public ReadOnly Property COST_CENTER() As FieldDef
            Get
                Return Fields(FieldList.COST_CENTER)
            End Get
        End Property
        Public ReadOnly Property ALT_COST_CENTER() As FieldDef
            Get
                Return Fields(FieldList.ALT_COST_CENTER)
            End Get
        End Property
        Public ReadOnly Property ORIG_TERRITORY() As FieldDef
            Get
                Return Fields(FieldList.ORIG_TERRITORY)
            End Get
        End Property
        Public ReadOnly Property REPORT() As FieldDef
            Get
                Return Fields(FieldList.REPORT)
            End Get
        End Property
        Public ReadOnly Property LEGACY_SYS() As FieldDef
            Get
                Return Fields(FieldList.LEGACY_SYS)
            End Get
        End Property
        Public ReadOnly Property UNIVER_USER_ID() As FieldDef
            Get
                Return Fields(FieldList.UNIVER_USER_ID)
            End Get
        End Property
        Public ReadOnly Property ROLE_CODE() As FieldDef
            Get
                Return Fields(FieldList.ROLE_CODE)
            End Get
        End Property
        Public ReadOnly Property JT_JRNL_LINE_NUM() As FieldDef
            Get
                Return Fields(FieldList.JT_JRNL_LINE_NUM)
            End Get
        End Property
        Public ReadOnly Property SNOW_TICKET() As FieldDef
            Get
                Return Fields(FieldList.SNOW_TICKET)
            End Get
        End Property
        Public ReadOnly Property ADJUST_JRNL_LINE_ID() As FieldDef
            Get
                Return Fields(FieldList.ADJUST_JRNL_LINE_ID)
            End Get
        End Property
        Public ReadOnly Property GROUP_BILL_NUM() As FieldDef
            Get
                Return Fields(FieldList.GROUP_BILL_NUM)
            End Get
        End Property
        Public ReadOnly Property REFERENCE() As FieldDef
            Get
                Return Fields(FieldList.REFERENCE)
            End Get
        End Property
        Public ReadOnly Property MISC_CODE1() As FieldDef
            Get
                Return Fields(FieldList.MISC_CODE1)
            End Get
        End Property
        Public ReadOnly Property MISC_CODE2() As FieldDef
            Get
                Return Fields(FieldList.MISC_CODE2)
            End Get
        End Property
        Public ReadOnly Property ALTDATE() As FieldDef
            Get
                Return Fields(FieldList.ALTDATE)
            End Get
        End Property

#End Region

    End Class

#End Region

End Namespace





