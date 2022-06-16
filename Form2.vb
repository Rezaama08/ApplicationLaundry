Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As MsgBoxStyle
        response = MsgBox("Apakah Anda ingin keluar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxStyle.YesNo Then
        End If
        Form1.Show()
        Me.Hide()
    End Sub
End Class