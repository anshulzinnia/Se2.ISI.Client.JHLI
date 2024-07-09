Namespace Se2.ISI

    Public Class Main

        Shared Sub Main(ByVal args() As String)


            System.Console.WriteLine("START: " + Now.ToLongTimeString)
            Dim Controller As Se2.ISI.Base.Processing.ISIController
            Dim cmdArgs As New Se2.ISI.Base.Processing.Se2CmdArgs(args)
            Controller = New Se2.ISI.Base.Processing.ISIController
            For Each itm As Se2.ISI.Base.Objects.Result In Controller.Process(cmdArgs)
                System.Console.WriteLine()
                System.Console.WriteLine("Interface Key: " & itm.InterfaceKey)
                System.Console.WriteLine("Result: " & itm.ToString)
                For Each msg As String In itm.DisplayMessage
                    System.Console.WriteLine("Result Message: " & msg)
                Next
            Next
            System.Console.WriteLine()
            System.Console.WriteLine("END: " + Now.ToLongTimeString)
            System.Console.ReadLine()


        End Sub

    End Class

End Namespace
