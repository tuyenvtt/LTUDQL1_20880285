<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.dgvDSMenu = New System.Windows.Forms.DataGridView()
        Me.lTen = New System.Windows.Forms.Label()
        Me.lMoTa = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbMoTa = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbHienThiXoa = New System.Windows.Forms.CheckBox()
        Me.dgvDSMonAn = New System.Windows.Forms.DataGridView()
        Me.btnThemMonAn = New System.Windows.Forms.Button()
        Me.btnXoaMonAn = New System.Windows.Forms.Button()
        CType(Me.dgvDSMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSMenu
        '
        Me.dgvDSMenu.AllowUserToAddRows = False
        Me.dgvDSMenu.AllowUserToDeleteRows = False
        Me.dgvDSMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvDSMenu.Location = New System.Drawing.Point(0, 0)
        Me.dgvDSMenu.Name = "dgvDSMenu"
        Me.dgvDSMenu.Size = New System.Drawing.Size(350, 553)
        Me.dgvDSMenu.TabIndex = 0
        '
        'lTen
        '
        Me.lTen.AutoSize = True
        Me.lTen.Location = New System.Drawing.Point(417, 21)
        Me.lTen.Name = "lTen"
        Me.lTen.Size = New System.Drawing.Size(26, 13)
        Me.lTen.TabIndex = 1
        Me.lTen.Text = "Ten"
        '
        'lMoTa
        '
        Me.lMoTa.AutoSize = True
        Me.lMoTa.Location = New System.Drawing.Point(417, 77)
        Me.lMoTa.Name = "lMoTa"
        Me.lMoTa.Size = New System.Drawing.Size(34, 13)
        Me.lMoTa.TabIndex = 2
        Me.lMoTa.Text = "Mo ta"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(491, 21)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(185, 20)
        Me.tbTen.TabIndex = 3
        '
        'tbMoTa
        '
        Me.tbMoTa.Location = New System.Drawing.Point(491, 77)
        Me.tbMoTa.Name = "tbMoTa"
        Me.tbMoTa.Size = New System.Drawing.Size(185, 20)
        Me.tbMoTa.TabIndex = 4
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(404, 117)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(63, 29)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(522, 117)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(69, 29)
        Me.btnCapNhat.TabIndex = 6
        Me.btnCapNhat.Text = "Cap Nhat"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(649, 117)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(63, 29)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbHienThiXoa
        '
        Me.cbHienThiXoa.AutoSize = True
        Me.cbHienThiXoa.Location = New System.Drawing.Point(404, 161)
        Me.cbHienThiXoa.Name = "cbHienThiXoa"
        Me.cbHienThiXoa.Size = New System.Drawing.Size(122, 17)
        Me.cbHienThiXoa.TabIndex = 8
        Me.cbHienThiXoa.Text = "Hien thi menu bi xoa"
        Me.cbHienThiXoa.UseVisualStyleBackColor = True
        '
        'dgvDSMonAn
        '
        Me.dgvDSMonAn.AllowUserToAddRows = False
        Me.dgvDSMonAn.AllowUserToDeleteRows = False
        Me.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSMonAn.Location = New System.Drawing.Point(370, 244)
        Me.dgvDSMonAn.Name = "dgvDSMonAn"
        Me.dgvDSMonAn.Size = New System.Drawing.Size(496, 297)
        Me.dgvDSMonAn.TabIndex = 9
        '
        'btnThemMonAn
        '
        Me.btnThemMonAn.Location = New System.Drawing.Point(370, 206)
        Me.btnThemMonAn.Name = "btnThemMonAn"
        Me.btnThemMonAn.Size = New System.Drawing.Size(97, 32)
        Me.btnThemMonAn.TabIndex = 10
        Me.btnThemMonAn.Text = "Them mon an"
        Me.btnThemMonAn.UseVisualStyleBackColor = True
        '
        'btnXoaMonAn
        '
        Me.btnXoaMonAn.Location = New System.Drawing.Point(491, 206)
        Me.btnXoaMonAn.Name = "btnXoaMonAn"
        Me.btnXoaMonAn.Size = New System.Drawing.Size(97, 32)
        Me.btnXoaMonAn.TabIndex = 11
        Me.btnXoaMonAn.Text = "Xoa mon an"
        Me.btnXoaMonAn.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 553)
        Me.Controls.Add(Me.btnXoaMonAn)
        Me.Controls.Add(Me.btnThemMonAn)
        Me.Controls.Add(Me.dgvDSMonAn)
        Me.Controls.Add(Me.cbHienThiXoa)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.tbMoTa)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.lMoTa)
        Me.Controls.Add(Me.lTen)
        Me.Controls.Add(Me.dgvDSMenu)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        CType(Me.dgvDSMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDSMenu As DataGridView
    Friend WithEvents lTen As Label
    Friend WithEvents lMoTa As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents dgvDSMonAn As DataGridView
    Friend WithEvents btnThemMonAn As Button
    Friend WithEvents btnXoaMonAn As Button
End Class
