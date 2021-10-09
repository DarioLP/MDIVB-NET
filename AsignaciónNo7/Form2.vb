'   Desarrollo de Software 8 | Laboratorio No7 | Estudiante: Darío López


Public Class WindDataGrid

    Dim inop, sumVert(0 To 100), sumHor, n0, n1, n2, n3 As Double
    Dim Ncelda(0 To 100, 0 To 100) As String
    Dim x, y As Integer

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click



        For y = 0 To 2
            For x = 0 To 2
                Ncelda(x, y) = ""
                inop = InputBox("Valor de Casilla:", "Asignación No7 - Darío López")

                Ncelda(x, y) = inop


            Next

        Next



        For y = 0 To 2

            sumHor = 0

            n0 = Double.Parse(Ncelda(0, y))
            n1 = Double.Parse(Ncelda(1, y))
            n2 = Double.Parse(Ncelda(2, y))

            sumHor = n0 + n1 + n2

            DataGridView1.Rows.Add(Ncelda(0, y), Ncelda(1, y), Ncelda(2, y), sumHor)

        Next

        For x = 0 To 2

            n0 = Double.Parse(Ncelda(x, 0))
            n1 = Double.Parse(Ncelda(x, 1))
            n2 = Double.Parse(Ncelda(x, 2))

            sumVert(x) = n0 + n1 + n2

        Next

        DataGridView1.Rows.Add(sumVert(0), sumVert(1), sumVert(2))

    End Sub
End Class