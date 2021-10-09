Public Class WindDataGrid

    Dim inop As String
    Dim Ncelda(0 To 100)(0 To 100) As String

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click


        x = 0
        y = 0
        Do While x <= 3

            Do While y <= 3

                Ncelda()() = ""
                inop = InputBox("Introducir texto")

                If inop2 = "a" Or inop2 = "e" Or inop2 = "i" Or inop2 = "o" Or inop2 = "u" Then
                    x = -1
                Else
                    Ncelda()() = inop2
                    x = x + 1
                    f = f + 1
                End If

            Loop

        Loop

    End Sub
End Class