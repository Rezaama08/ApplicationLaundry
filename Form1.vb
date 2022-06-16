Public Class Form1
    Private Sub cbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjenis.SelectedIndexChanged
        If cbjenis.Text = "PAKAIAN" Then
            txtharga.Text = "7000"
        ElseIf cbjenis.Text = "KARPET" Then
            txtharga.Text = "10000"
        ElseIf cbjenis.Text = "SELIMUT" Then
            txtharga.Text = "12000"
        ElseIf cbjenis.Text = "BONEKA" Then
            txtharga.Text = "8000"
        ElseIf cbjenis.Text = "SPREI" Then
            txtharga.Text = "10000"
        End If
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Dim a, b As Integer
        Dim c = "5000"
        Dim hasil As Integer
        a = txtberat.Text
        b = txtharga.Text
        c = "5000"
        hasil = a * b
        txttotal.Text = hasil
        If RadioButton2.Checked Then
            txttotal.Text = hasil + c
        End If
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim p, q, kembalian As Integer
        p = txtuang.Text
        q = txttotal.Text
        kembalian = p - q
        txtkembali.Text = kembalian

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtnama.Text = ""
        txtberat.Text = ""
        txtharga.Text = ""
        txttotal.Text = ""
        txtuang.Text = ""
        txtkembali.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Form2.DataGridView1.Rows.Add(1)
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(0).Value = txtnama.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(1).Value = txtberat.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(2).Value = cbjenis.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(3).Value = txttotal.Text
        Form2.DataGridView1.Rows(Form2.DataGridView1.RowCount - 2).Cells(4).Value = DateTimePicker1.Value
        MsgBox("Perintah Telah Disimpan Terimakasih ", MsgBoxStyle.Information)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
