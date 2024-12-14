<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        LabelGajiTotal = New Label()
        txtNama = New TextBox()
        txtGajiPokok = New TextBox()
        txtJumlahAnak = New TextBox()
        txtGajiTotal = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 21)
        Label1.TabIndex = 0
        Label1.Text = "Aplikasi Penghitung Gaji Karyawan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "Gaji Pokok"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 3
        Label4.Text = "Jumlah Anak"
        ' 
        ' LabelGajiTotal
        ' 
        LabelGajiTotal.AutoSize = True
        LabelGajiTotal.Location = New Point(25, 291)
        LabelGajiTotal.Name = "LabelGajiTotal"
        LabelGajiTotal.Size = New Size(55, 15)
        LabelGajiTotal.TabIndex = 4
        LabelGajiTotal.Text = "Gaji Total"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(159, 81)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(140, 23)
        txtNama.TabIndex = 6
        ' 
        ' txtGajiPokok
        ' 
        txtGajiPokok.Location = New Point(159, 154)
        txtGajiPokok.Name = "txtGajiPokok"
        txtGajiPokok.Size = New Size(140, 23)
        txtGajiPokok.TabIndex = 7
        ' 
        ' txtJumlahAnak
        ' 
        txtJumlahAnak.Location = New Point(159, 222)
        txtJumlahAnak.Name = "txtJumlahAnak"
        txtJumlahAnak.Size = New Size(140, 23)
        txtJumlahAnak.TabIndex = 8
        ' 
        ' txtGajiTotal
        ' 
        txtGajiTotal.Location = New Point(159, 283)
        txtGajiTotal.Name = "txtGajiTotal"
        txtGajiTotal.Size = New Size(140, 23)
        txtGajiTotal.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(349, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 68)
        Button1.TabIndex = 10
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(476, 412)
        Controls.Add(Button1)
        Controls.Add(txtGajiTotal)
        Controls.Add(txtJumlahAnak)
        Controls.Add(txtGajiPokok)
        Controls.Add(txtNama)
        Controls.Add(LabelGajiTotal)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelGajiTotal As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtGajiPokok As TextBox
    Friend WithEvents txtJumlahAnak As TextBox
    Friend WithEvents txtGajiTotal As TextBox
    Friend WithEvents Button1 As Button

End Class
