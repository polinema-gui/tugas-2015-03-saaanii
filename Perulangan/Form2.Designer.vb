<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmb_pola = New System.Windows.Forms.ComboBox()
        Me.Txb_baris = New System.Windows.Forms.TextBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_proses = New System.Windows.Forms.Button()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baris"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'Cmb_pola
        '
        Me.Cmb_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_pola.FormattingEnabled = True
        Me.Cmb_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Cmb_pola.Location = New System.Drawing.Point(51, 10)
        Me.Cmb_pola.Name = "Cmb_pola"
        Me.Cmb_pola.Size = New System.Drawing.Size(360, 21)
        Me.Cmb_pola.TabIndex = 3
        '
        'Txb_baris
        '
        Me.Txb_baris.Location = New System.Drawing.Point(52, 53)
        Me.Txb_baris.Name = "Txb_baris"
        Me.Txb_baris.Size = New System.Drawing.Size(358, 20)
        Me.Txb_baris.TabIndex = 4
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_hasil.Location = New System.Drawing.Point(55, 108)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.ReadOnly = True
        Me.Txb_hasil.Size = New System.Drawing.Size(355, 218)
        Me.Txb_hasil.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 20)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_proses
        '
        Me.Btn_proses.Location = New System.Drawing.Point(314, 350)
        Me.Btn_proses.Name = "Btn_proses"
        Me.Btn_proses.Size = New System.Drawing.Size(68, 20)
        Me.Btn_proses.TabIndex = 7
        Me.Btn_proses.Text = "Proses"
        Me.Btn_proses.UseVisualStyleBackColor = True
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(469, 175)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.DomainUpDown1.TabIndex = 8
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.Btn_proses)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Txb_baris)
        Me.Controls.Add(Me.Cmb_pola)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_pola As System.Windows.Forms.ComboBox
    Friend WithEvents Txb_baris As System.Windows.Forms.TextBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_proses As System.Windows.Forms.Button
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
End Class
