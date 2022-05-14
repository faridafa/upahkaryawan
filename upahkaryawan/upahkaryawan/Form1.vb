Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tMasuk.Text = "00:00:00"
        tPulang.Text = "00:00:00"
    End Sub
    Private Sub bKeluar_Click(sender As Object, e As EventArgs) Handles bKeluar.Click
        End
    End Sub

    Private Sub bHitung_Click(sender As Object, e As EventArgs) Handles bHitung.Click
        Dim Hasil As TimeSpan = TimeValue(tPulang.Text) - TimeValue(tMasuk.Text)
        If rProduksi.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 10000
        ElseIf rPemasaran.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 15000
        ElseIf rIT.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 20000
        ElseIf rHumas.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 25000
        ElseIf rKeuangan.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 30000
        ElseIf rGudang.Checked Then
            tUpah.Text = (String.Format("{0}", Hasil.Hours)) * 10000
        End If

    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        tNama.Clear()
        tUpah.Clear()
        jCewek.Checked = False
        jCowok.Checked = False
        rGudang.Checked = False
        rHumas.Checked = False
        rIT.Checked = False
        rPemasaran.Checked = False
        rProduksi.Checked = False
        rKeuangan.Checked = False
        tMasuk.Text = "00:00:00"
        tPulang.Text = "00:00:00"
        pCowok.Visible = False
        pCewek.Visible = False
    End Sub

    Private Sub jCowok_CheckedChanged(sender As Object, e As EventArgs) Handles jCowok.CheckedChanged
        If jCowok.Checked = True Then
            pCowok.Visible = True
            pCewek.Visible = False
        End If
    End Sub

    Private Sub jCewek_CheckedChanged(sender As Object, e As EventArgs) Handles jCewek.CheckedChanged
        If jCewek.Checked = True Then
            pCewek.Visible = True
            pCowok.Visible = False
        End If
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Dim tgl As String
        tgl = Format(Tanggal.Value, "dd-MM-yyyy")

        Dim jk As String
        If jCewek.Checked Then
            jk = "Perempuan"
        ElseIf jCowok.Checked Then
            jk = "Laki-Laki"
        End If

        Dim dep As String
        If rProduksi.Checked Then
            dep = "Produksi"
        ElseIf rPemasaran.Checked Then
            dep = "Pemasaran"
        ElseIf rHumas.Checked Then
            dep = "Humas"
        ElseIf rIT.Checked Then
            dep = "IT"
        ElseIf rKeuangan.Checked Then
            dep = "Keuangan"
        ElseIf rGudang.Checked Then
            dep = "Gudang"
        End If

        dg.Rows.Add(1)
        dg.Rows(dg.RowCount - 2).Cells(0).Value = tNama.Text
        dg.Rows(dg.RowCount - 2).Cells(1).Value = jk
        dg.Rows(dg.RowCount - 2).Cells(2).Value = tgl
        dg.Rows(dg.RowCount - 2).Cells(3).Value = tMasuk.Text
        dg.Rows(dg.RowCount - 2).Cells(4).Value = tPulang.Text
        dg.Rows(dg.RowCount - 2).Cells(5).Value = dep
        dg.Rows(dg.RowCount - 2).Cells(6).Value = tUpah.Text

    End Sub
End Class
