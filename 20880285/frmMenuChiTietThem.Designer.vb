<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuChiTietThem
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
        Me.dgvDSMonAn = New System.Windows.Forms.DataGridView()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnDongY = New System.Windows.Forms.Button()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSMonAn
        '
        Me.dgvDSMonAn.AllowUserToAddRows = False
        Me.dgvDSMonAn.AllowUserToDeleteRows = False
        Me.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSMonAn.Location = New System.Drawing.Point(12, 12)
        Me.dgvDSMonAn.Name = "dgvDSMonAn"
        Me.dgvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSMonAn.Size = New System.Drawing.Size(417, 257)
        Me.dgvDSMonAn.TabIndex = 0
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(82, 298)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 28)
        Me.btnDong.TabIndex = 1
        Me.btnDong.Text = "Thoat"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnDongY
        '
        Me.btnDongY.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnDongY.Location = New System.Drawing.Point(276, 298)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(75, 28)
        Me.btnDongY.TabIndex = 2
        Me.btnDongY.Text = "Dong Y"
        Me.btnDongY.UseVisualStyleBackColor = True
        '
        'frmMenuChiTietThem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 349)
        Me.Controls.Add(Me.btnDongY)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvDSMonAn)
        Me.Name = "frmMenuChiTietThem"
        Me.Text = "frmMenuChiTietThem"
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDSMonAn As DataGridView
    Friend WithEvents btnDong As Button
    Friend WithEvents btnDongY As Button
End Class
