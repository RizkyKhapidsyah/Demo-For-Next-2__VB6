Public Class Form1

    Private Sub tombolJalankan_Click(sender As Object, e As EventArgs) Handles tombolJalankan.Click
        Dim intHitung As Integer 'pencacah loop

        'menggeser citra melintasi form
        For intHitung = 16 To 328
            gbrTopi.Left = intHitung
        Next
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
