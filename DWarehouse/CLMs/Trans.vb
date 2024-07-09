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

#Region " TRANS "

    Public Class TRANS
        Inherits BaseLogic

        Public Shadows Property Se2Source As SourceLayouts.TRANS

        Public Sub New()
            MyBase.New()
            ClientRecord = New Records.TRANS
            Se2Source = New SourceLayouts.TRANS
            MyBase.Se2Source = Me.Se2Source

        End Sub


#Region " POPULATION FUNCTIONS "

        ''' <summary>
        ''' RJM SIINTDWH-277, per spec if the status has a value of "0" (zero) return an empty string, otherwise return the status.
        ''' RJM SIINTDWH-277, updated spec, changed logic, per v2 of spec doc:  TXN_CODE = TX_TXN_TYPE and TXN_NAME = TX_PRD_TXN_DESC
        ''' RJM SIINTDWH-277, 2019-05-06: per data review it was determined that the condition of TX_TXN_TYPE = "WITHDRAWAL" should be removed.
        ''' </summary>
        ''' <param name="values"></param>
        ''' <returns></returns>
        Public Function GET_VITL_TRX_VL(ByVal values As Se2Args) As String
            Dim RetVal As String = ""

            If Se2Source.TX_CONT = "019115077001349" Then
                Dim x As Int16 = 0
            End If

            ''If Se2Source.TX_LFT_VTLTY_STATUS = "0" Then
            ''    RetVal = ""
            ''Else
            ''    RetVal = Se2Source.TX_LFT_VTLTY_STATUS
            ''End If

            If Se2Source.TX_PRD_TXN_DESC.ToUpper = "PREFUND" Then
                If Se2Source.TX_LFT_VTLTY_STATUS = "0" Then
                    RetVal = ""
                Else
                    RetVal = Se2Source.TX_LFT_VTLTY_STATUS
                End If
            Else
                RetVal = ""
            End If

            Return RetVal
        End Function

        ''' <summary>
        ''' RJM SIINTDWH-277, updated spec V2.
        ''' RJM SIINTDWH-277, 2019-05-06: per data review it was determined that the condition of TX_TXN_TYPE = "WITHDRAWAL" should be removed.
        ''' </summary>
        ''' <param name="values"></param>
        ''' <returns></returns>
        Public Function GET_LFT_VTLTY_REFUND(ByVal values As Se2Args) As Decimal
            Dim RetVal As Decimal = CDec(0.00)

            If Se2Source.TX_CONT = "019115077002962" Then
                Dim x As Int16 = 0
            End If

            If Se2Source.TX_PRD_TXN_DESC.ToUpper = "PREFUND" Then
                RetVal = Se2Source.TX_LFT_VTLTY_REFUND
            Else
                RetVal = CDec(0.00)
            End If

            Return RetVal

        End Function


#End Region

    End Class

#End Region

End Namespace