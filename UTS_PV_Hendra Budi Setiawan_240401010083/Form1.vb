Public Class Form1

    Const Tunjangan_Anak As Decimal = 250000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Nama As String = txtNama.Text
        Dim GajiPokok As Decimal
        Dim JumlahAnak As Integer


        If Not Decimal.TryParse(txtGajiPokok.Text, GajiPokok) Then
            MessageBox.Show("Gaji Pokok tidak valid")
            Return
        End If

        If Not Integer.TryParse(txtJumlahAnak.Text, JumlahAnak) Then
            MessageBox.Show("Jumlah Anak tidak valid")
            Return
        End If

        If JumlahAnak > 3 Then
            MessageBox.Show("Jumlah Anak yang diberi tunjangan hanya sampai anak ke-3")
            Return
        End If

        Dim TunjanganAnak As Decimal = JumlahAnak * Tunjangan_Anak

        Dim GajiTotal As Decimal = GajiPokok + TunjanganAnak

        txtGajiTotal.Text = "Rp: " & GajiTotal.ToString("C")

    End Sub


End Class
