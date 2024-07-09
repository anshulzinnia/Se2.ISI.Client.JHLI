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

Namespace Se2.ISI.Client.JHLI.DWarehouse.CLM

#Region " HEADER "

    Public Class Header
        Inherits BaseLogic

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.COLUMNHEADERS
        End Sub

#Region " POPULATION FUNCTIONS "

        Public Function GetColumnHeaders(ByVal value As Se2Args) As Object
            Dim HeaderDef As RecordDef
            Select Case value.cmdLnArgs.PROCESSOR.ToUpper
                Case "ADDRESS"
                    HeaderDef = New Records.ADDRESS
                Case "NAMES"
                    HeaderDef = New Records.NAMES
                Case "PHONE"
                    HeaderDef = New Records.PHONE
                Case "POLICY"
                    HeaderDef = New Records.POLICY
                Case "ROLES"
                    HeaderDef = New Records.ROLES
                Case "TRANS"
                    HeaderDef = New Records.TRANS
                Case "RIDER"
                    HeaderDef = New Records.RIDERS
                Case "DPVALUES"
                    HeaderDef = New Records.DPVALUES
                Case "DISB"
                    HeaderDef = New Records.DISB
                Case "CLAIMS"
                    HeaderDef = New Records.CLAIMS
                Case "CLAIMS_BENEFICIARY"
                    HeaderDef = New Records.CLAIMS_BENEFICIARY
                Case Else

                    HeaderDef = New Records.POLICY  ' dumb default
            End Select

            Return HeaderDef.FieldList(",", """", """").Trim(""""c)

        End Function

#End Region

    End Class

#End Region

End Namespace