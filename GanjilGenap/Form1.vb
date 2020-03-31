Public Class Form1
    Private Sub proses_Click(sender As Object, e As EventArgs) Handles proses.Click
        'Try..Catch..Finally..End Try
        Try
            Dim X As Integer
            X = txtangka.Text
            Do
                X = X Mod 2
                If X = 0 Then
                    MessageBox.Show("Bilangan Genap", "Informasi")
                    Exit Do
                ElseIf X = 1 Then
                    MessageBox.Show("Bilangan Ganjil", "Informasi")
                    Exit Do
                End If

            Loop While Not (X)
        Catch ex As Exception
            MessageBox.Show("Inputan Harus Berupa Angka !!", "Informasi")
        Finally
            txtangka.Text = ""
            txtangka.Focus()
        End Try

    End Sub



    'on error resume next
    On Error Resume Next

    Dim X As Integer
        X = txtangka.Text
        If X = 2 Then
            MessageBox.Show("Bilangan Genap", "Informasi")
        ElseIf X = 1 Then
            MessageBox.Show("Bilangan Ganjil", "Informasi")
        End If



    'On Error Goto
    On Error GoTo informasi

        Dim X As Integer
        X = txtangka.Text
        If X = 2 Then
            MessageBox.Show("Bilangan Genap", "Informasi")
        ElseIf X = 1 Then
            MessageBox.Show("Bilangan Ganjil", "Informasi")
        End If

informasi:
        MessageBox.Show("Inputan tidak boleh kosong !!", "Error")
    End Sub
End Class
