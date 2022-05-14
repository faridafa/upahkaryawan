<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tNama = New System.Windows.Forms.TextBox()
        Me.jCowok = New System.Windows.Forms.RadioButton()
        Me.jCewek = New System.Windows.Forms.RadioButton()
        Me.Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.tMasuk = New System.Windows.Forms.TextBox()
        Me.tPulang = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rHumas = New System.Windows.Forms.RadioButton()
        Me.rGudang = New System.Windows.Forms.RadioButton()
        Me.rKeuangan = New System.Windows.Forms.RadioButton()
        Me.rProduksi = New System.Windows.Forms.RadioButton()
        Me.rPemasaran = New System.Windows.Forms.RadioButton()
        Me.rIT = New System.Windows.Forms.RadioButton()
        Me.tUpah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bHitung = New System.Windows.Forms.Button()
        Me.bHapus = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.bKeluar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pCowok = New System.Windows.Forms.PictureBox()
        Me.pCewek = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCowok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pCewek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(413, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UPAH KARYAWAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(92, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(92, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(92, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(92, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 30)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jam Masuk"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(92, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jam Pulang"
        '
        'tNama
        '
        Me.tNama.Location = New System.Drawing.Point(334, 105)
        Me.tNama.Name = "tNama"
        Me.tNama.Size = New System.Drawing.Size(360, 31)
        Me.tNama.TabIndex = 7
        '
        'jCowok
        '
        Me.jCowok.AutoSize = True
        Me.jCowok.Location = New System.Drawing.Point(334, 167)
        Me.jCowok.Name = "jCowok"
        Me.jCowok.Size = New System.Drawing.Size(104, 29)
        Me.jCowok.TabIndex = 8
        Me.jCowok.TabStop = True
        Me.jCowok.Text = "Laki-Laki"
        Me.jCowok.UseVisualStyleBackColor = True
        '
        'jCewek
        '
        Me.jCewek.AutoSize = True
        Me.jCewek.Location = New System.Drawing.Point(491, 167)
        Me.jCewek.Name = "jCewek"
        Me.jCewek.Size = New System.Drawing.Size(126, 29)
        Me.jCewek.TabIndex = 9
        Me.jCewek.TabStop = True
        Me.jCewek.Text = "Perempuan"
        Me.jCewek.UseVisualStyleBackColor = True
        '
        'Tanggal
        '
        Me.Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Tanggal.Location = New System.Drawing.Point(334, 224)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(283, 31)
        Me.Tanggal.TabIndex = 10
        '
        'tMasuk
        '
        Me.tMasuk.Location = New System.Drawing.Point(334, 286)
        Me.tMasuk.Name = "tMasuk"
        Me.tMasuk.Size = New System.Drawing.Size(104, 31)
        Me.tMasuk.TabIndex = 11
        '
        'tPulang
        '
        Me.tPulang.Location = New System.Drawing.Point(334, 347)
        Me.tPulang.Name = "tPulang"
        Me.tPulang.Size = New System.Drawing.Size(104, 31)
        Me.tPulang.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.rHumas)
        Me.GroupBox1.Controls.Add(Me.rGudang)
        Me.GroupBox1.Controls.Add(Me.rKeuangan)
        Me.GroupBox1.Controls.Add(Me.rProduksi)
        Me.GroupBox1.Controls.Add(Me.rPemasaran)
        Me.GroupBox1.Controls.Add(Me.rIT)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 412)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 214)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Departemen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(508, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'rHumas
        '
        Me.rHumas.AutoSize = True
        Me.rHumas.Location = New System.Drawing.Point(346, 145)
        Me.rHumas.Name = "rHumas"
        Me.rHumas.Size = New System.Drawing.Size(93, 29)
        Me.rHumas.TabIndex = 5
        Me.rHumas.TabStop = True
        Me.rHumas.Text = "Humas"
        Me.rHumas.UseVisualStyleBackColor = True
        '
        'rGudang
        '
        Me.rGudang.AutoSize = True
        Me.rGudang.Location = New System.Drawing.Point(38, 145)
        Me.rGudang.Name = "rGudang"
        Me.rGudang.Size = New System.Drawing.Size(100, 29)
        Me.rGudang.TabIndex = 4
        Me.rGudang.TabStop = True
        Me.rGudang.Text = "Gudang"
        Me.rGudang.UseVisualStyleBackColor = True
        '
        'rKeuangan
        '
        Me.rKeuangan.AutoSize = True
        Me.rKeuangan.Location = New System.Drawing.Point(346, 95)
        Me.rKeuangan.Name = "rKeuangan"
        Me.rKeuangan.Size = New System.Drawing.Size(115, 29)
        Me.rKeuangan.TabIndex = 3
        Me.rKeuangan.TabStop = True
        Me.rKeuangan.Text = "Keuangan"
        Me.rKeuangan.UseVisualStyleBackColor = True
        '
        'rProduksi
        '
        Me.rProduksi.AutoSize = True
        Me.rProduksi.Location = New System.Drawing.Point(38, 45)
        Me.rProduksi.Name = "rProduksi"
        Me.rProduksi.Size = New System.Drawing.Size(106, 29)
        Me.rProduksi.TabIndex = 2
        Me.rProduksi.TabStop = True
        Me.rProduksi.Text = "Produksi"
        Me.rProduksi.UseVisualStyleBackColor = True
        '
        'rPemasaran
        '
        Me.rPemasaran.AutoSize = True
        Me.rPemasaran.Location = New System.Drawing.Point(38, 95)
        Me.rPemasaran.Name = "rPemasaran"
        Me.rPemasaran.Size = New System.Drawing.Size(122, 29)
        Me.rPemasaran.TabIndex = 1
        Me.rPemasaran.TabStop = True
        Me.rPemasaran.Text = "Pemasaran"
        Me.rPemasaran.UseVisualStyleBackColor = True
        '
        'rIT
        '
        Me.rIT.AutoSize = True
        Me.rIT.Location = New System.Drawing.Point(346, 45)
        Me.rIT.Name = "rIT"
        Me.rIT.Size = New System.Drawing.Size(51, 29)
        Me.rIT.TabIndex = 0
        Me.rIT.TabStop = True
        Me.rIT.Text = "IT"
        Me.rIT.UseVisualStyleBackColor = True
        '
        'tUpah
        '
        Me.tUpah.Enabled = False
        Me.tUpah.Location = New System.Drawing.Point(334, 655)
        Me.tUpah.Name = "tUpah"
        Me.tUpah.Size = New System.Drawing.Size(360, 31)
        Me.tUpah.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(92, 656)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 30)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Upah dibayar"
        '
        'bHitung
        '
        Me.bHitung.Location = New System.Drawing.Point(768, 592)
        Me.bHitung.Name = "bHitung"
        Me.bHitung.Size = New System.Drawing.Size(112, 34)
        Me.bHitung.TabIndex = 16
        Me.bHitung.Text = "Hitung"
        Me.bHitung.UseVisualStyleBackColor = True
        '
        'bHapus
        '
        Me.bHapus.Location = New System.Drawing.Point(898, 592)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(112, 34)
        Me.bHapus.TabIndex = 17
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = True
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(768, 656)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(112, 34)
        Me.bSimpan.TabIndex = 18
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseVisualStyleBackColor = True
        '
        'bKeluar
        '
        Me.bKeluar.Location = New System.Drawing.Point(898, 656)
        Me.bKeluar.Name = "bKeluar"
        Me.bKeluar.Size = New System.Drawing.Size(112, 34)
        Me.bKeluar.TabIndex = 19
        Me.bKeluar.Text = "Keluar"
        Me.bKeluar.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dg.Location = New System.Drawing.Point(12, 719)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersWidth = 62
        Me.dg.RowTemplate.Height = 33
        Me.dg.Size = New System.Drawing.Size(1084, 225)
        Me.dg.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jenis Kelamin"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tanggal"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jam Masuk"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jam Pulang"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Departemen"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Upah"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(646, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'pCowok
        '
        Me.pCowok.Enabled = False
        Me.pCowok.Image = CType(resources.GetObject("pCowok.Image"), System.Drawing.Image)
        Me.pCowok.Location = New System.Drawing.Point(860, 115)
        Me.pCowok.Name = "pCowok"
        Me.pCowok.Size = New System.Drawing.Size(150, 153)
        Me.pCowok.TabIndex = 22
        Me.pCowok.TabStop = False
        Me.pCowok.Visible = False
        '
        'pCewek
        '
        Me.pCewek.Enabled = False
        Me.pCewek.Image = CType(resources.GetObject("pCewek.Image"), System.Drawing.Image)
        Me.pCewek.Location = New System.Drawing.Point(860, 115)
        Me.pCewek.Name = "pCewek"
        Me.pCewek.Size = New System.Drawing.Size(150, 153)
        Me.pCewek.TabIndex = 22
        Me.pCewek.TabStop = False
        Me.pCewek.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 996)
        Me.Controls.Add(Me.pCewek)
        Me.Controls.Add(Me.pCowok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.bKeluar)
        Me.Controls.Add(Me.bSimpan)
        Me.Controls.Add(Me.bHapus)
        Me.Controls.Add(Me.bHitung)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tUpah)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tPulang)
        Me.Controls.Add(Me.tMasuk)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.jCewek)
        Me.Controls.Add(Me.jCowok)
        Me.Controls.Add(Me.tNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form Upah Karyawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCowok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pCewek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tNama As TextBox
    Friend WithEvents jCowok As RadioButton
    Friend WithEvents jCewek As RadioButton
    Friend WithEvents Tanggal As DateTimePicker
    Friend WithEvents tMasuk As TextBox
    Friend WithEvents tPulang As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rHumas As RadioButton
    Friend WithEvents rGudang As RadioButton
    Friend WithEvents rKeuangan As RadioButton
    Friend WithEvents rProduksi As RadioButton
    Friend WithEvents rPemasaran As RadioButton
    Friend WithEvents rIT As RadioButton
    Friend WithEvents tUpah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bHitung As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents bKeluar As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents pCowok As PictureBox
    Friend WithEvents pCewek As PictureBox
End Class
