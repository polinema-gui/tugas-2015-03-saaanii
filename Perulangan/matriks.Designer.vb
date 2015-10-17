<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class matriks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.matrik1 = New System.Windows.Forms.Label()
        Me.matrik2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txb_matrik1 = New System.Windows.Forms.TextBox()
        Me.Txb_matrik2 = New System.Windows.Forms.TextBox()
        Me.Cmb_operasi = New System.Windows.Forms.ComboBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'matrik1
        '
        Me.matrik1.AutoSize = True
        Me.matrik1.Location = New System.Drawing.Point(11, 43)
        Me.matrik1.Name = "matrik1"
        Me.matrik1.Size = New System.Drawing.Size(41, 13)
        Me.matrik1.TabIndex = 0
        Me.matrik1.Text = "matrik1"
        '
        'matrik2
        '
        Me.matrik2.AutoSize = True
        Me.matrik2.Location = New System.Drawing.Point(12, 105)
        Me.matrik2.Name = "matrik2"
        Me.matrik2.Size = New System.Drawing.Size(41, 13)
        Me.matrik2.TabIndex = 1
        Me.matrik2.Text = "matrik2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "operasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "hasil"
        '
        'Txb_matrik1
        '
        Me.Txb_matrik1.Location = New System.Drawing.Point(55, 23)
        Me.Txb_matrik1.Multiline = True
        Me.Txb_matrik1.Name = "Txb_matrik1"
        Me.Txb_matrik1.Size = New System.Drawing.Size(304, 55)
        Me.Txb_matrik1.TabIndex = 4
        '
        'Txb_matrik2
        '
        Me.Txb_matrik2.Location = New System.Drawing.Point(55, 84)
        Me.Txb_matrik2.Multiline = True
        Me.Txb_matrik2.Name = "Txb_matrik2"
        Me.Txb_matrik2.Size = New System.Drawing.Size(304, 55)
        Me.Txb_matrik2.TabIndex = 5
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.FormattingEnabled = True
        Me.Cmb_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Cmb_operasi.Location = New System.Drawing.Point(62, 175)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(296, 21)
        Me.Cmb_operasi.TabIndex = 6
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Location = New System.Drawing.Point(55, 232)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.Size = New System.Drawing.Size(304, 108)
        Me.Txb_hasil.TabIndex = 7
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(50, 360)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(69, 23)
        Me.btn_proses.TabIndex = 8
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 396)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Txb_matrik2)
        Me.Controls.Add(Me.Txb_matrik1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.matrik2)
        Me.Controls.Add(Me.matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents matrik1 As System.Windows.Forms.Label
    Friend WithEvents matrik2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txb_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Txb_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
