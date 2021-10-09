'   Desarrollo de Software 8 | Laboratorio No7 | Estudiante: Darío López

Public Class Principal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Splash.Close()
    End Sub

    Private Sub DataGridViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataGridViewToolStripMenuItem.Click

        WindDataGrid.Show()

    End Sub
End Class
