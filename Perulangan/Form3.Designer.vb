<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim operasi1 As System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_operasi = New System.Windows.Forms.Label()
        Me.Txb_matrik1 = New System.Windows.Forms.TextBox()
        Me.Txb_matrik2 = New System.Windows.Forms.TextBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hasil = New System.Windows.Forms.Label()
        Me.btn_proses = New System.Windows.Forms.Button()
        operasi1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'operasi1
        '
        operasi1.FormattingEnabled = True
        operasi1.Items.AddRange(New Object() {"Tambah", "Kurang"})
        operasi1.Location = New System.Drawing.Point(57, 83)
        operasi1.Name = "operasi1"
        operasi1.Size = New System.Drawing.Size(305, 21)
        operasi1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "matrik1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "matrik2"
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.AutoSize = True
        Me.Cmb_operasi.Location = New System.Drawing.Point(9, 88)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(41, 13)
        Me.Cmb_operasi.TabIndex = 2
        Me.Cmb_operasi.Text = "operasi"
        '
        'Txb_matrik1
        '
        Me.Txb_matrik1.Location = New System.Drawing.Point(57, 5)
        Me.Txb_matrik1.Multiline = True
        Me.Txb_matrik1.Name = "Txb_matrik1"
        Me.Txb_matrik1.Size = New System.Drawing.Size(306, 66)
        Me.Txb_matrik1.TabIndex = 3
        '
        'Txb_matrik2
        '
        Me.Txb_matrik2.Location = New System.Drawing.Point(57, 117)
        Me.Txb_matrik2.Multiline = True
        Me.Txb_matrik2.Name = "Txb_matrik2"
        Me.Txb_matrik2.Size = New System.Drawing.Size(306, 66)
        Me.Txb_matrik2.TabIndex = 4
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Location = New System.Drawing.Point(57, 202)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.ReadOnly = True
        Me.Txb_hasil.Size = New System.Drawing.Size(304, 131)
        Me.Txb_hasil.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hasil
        '
        Me.hasil.AutoSize = True
        Me.hasil.Location = New System.Drawing.Point(14, 231)
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(30, 13)
        Me.hasil.TabIndex = 9
        Me.hasil.Text = "Hasil"
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(266, 359)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(84, 23)
        Me.btn_proses.TabIndex = 10
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 402)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.hasil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(operasi1)
        Me.Controls.Add(Me.Txb_matrik2)
        Me.Controls.Add(Me.Txb_matrik1)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmb_operasi As System.Windows.Forms.Label
    Friend WithEvents Txb_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Txb_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents hasil As System.Windows.Forms.Label

    Private Sub Btn_proses_Click(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents btn_proses As System.Windows.Forms.Button
End Class
