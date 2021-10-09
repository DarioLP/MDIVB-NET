'   Desarrollo de Software 8 | Laboratorio No7 | Estudiante: Darío López


Public Class Splash

    Dim contador As Byte = 0
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            contador = contador + 25
            ProgressBar1.Value = contador
        Else
            Me.Hide()
            Principal.Show()
            Timer1.Enabled = False
        End If

    End Sub
End Class