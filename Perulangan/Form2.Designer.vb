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
        Me.Cmb_pola = New System.Windows.Forms.ComboBox()
        Me.Txb_baris = New System.Windows.Forms.TextBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.Btn_proses = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Baris"
        '
        'Cmb_pola
        '
        Me.Cmb_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_pola.FormattingEnabled = True
        Me.Cmb_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.Cmb_pola.Location = New System.Drawing.Point(58, 15)
        Me.Cmb_pola.Name = "Cmb_pola"
        Me.Cmb_pola.Size = New System.Drawing.Size(353, 21)
        Me.Cmb_pola.TabIndex = 2
        '
        'Txb_baris
        '
        Me.Txb_baris.Location = New System.Drawing.Point(58, 64)
        Me.Txb_baris.Name = "Txb_baris"
        Me.Txb_baris.Size = New System.Drawing.Size(351, 20)
        Me.Txb_baris.TabIndex = 3
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txb_hasil.Location = New System.Drawing.Point(21, 115)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.ReadOnly = True
        Me.Txb_hasil.Size = New System.Drawing.Size(389, 233)
        Me.Txb_hasil.TabIndex = 4
        '
        'Btn_proses
        '
        Me.Btn_proses.Location = New System.Drawing.Point(30, 371)
        Me.Btn_proses.Name = "Btn_proses"
        Me.Btn_proses.Size = New System.Drawing.Size(76, 22)
        Me.Btn_proses.TabIndex = 5
        Me.Btn_proses.Text = "Proses"
        Me.Btn_proses.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 22)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Keluar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_proses)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Txb_baris)
        Me.Controls.Add(Me.Cmb_pola)
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
    Friend WithEvents Cmb_pola As System.Windows.Forms.ComboBox
    Friend WithEvents Txb_baris As System.Windows.Forms.TextBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Btn_proses As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
