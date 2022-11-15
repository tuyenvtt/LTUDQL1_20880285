<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiMonAn
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
        Me.lbDanhSach = New System.Windows.Forms.ListBox()
        Me.lTen = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.cbHienThiXoa = New System.Windows.Forms.CheckBox()
        Me.btnKhoiPhuc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDanhSach
        '
        Me.lbDanhSach.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbDanhSach.FormattingEnabled = True
        Me.lbDanhSach.Location = New System.Drawing.Point(0, 0)
        Me.lbDanhSach.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbDanhSach.Name = "lbDanhSach"
        Me.lbDanhSach.Size = New System.Drawing.Size(287, 457)
        Me.lbDanhSach.TabIndex = 0
        '
        'lTen
        '
        Me.lTen.AutoSize = True
        Me.lTen.Location = New System.Drawing.Point(307, 57)
        Me.lTen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTen.Name = "lTen"
        Me.lTen.Size = New System.Drawing.Size(83, 13)
        Me.lTen.TabIndex = 1
        Me.lTen.Text = "Ten loai mon an"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(393, 57)
        Me.tbTen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(168, 20)
        Me.tbTen.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(313, 134)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(56, 27)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(412, 134)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(60, 27)
        Me.btnCapNhat.TabIndex = 4
        Me.btnCapNhat.Text = "Cap Nhat"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(504, 134)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(56, 27)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'cbHienThiXoa
        '
        Me.cbHienThiXoa.AutoSize = True
        Me.cbHienThiXoa.Location = New System.Drawing.Point(325, 216)
        Me.cbHienThiXoa.Name = "cbHienThiXoa"
        Me.cbHienThiXoa.Size = New System.Drawing.Size(131, 17)
        Me.cbHienThiXoa.TabIndex = 6
        Me.cbHienThiXoa.Text = "Hien thi mon an bi xoa"
        Me.cbHienThiXoa.UseVisualStyleBackColor = True
        '
        'btnKhoiPhuc
        '
        Me.btnKhoiPhuc.Location = New System.Drawing.Point(504, 216)
        Me.btnKhoiPhuc.Name = "btnKhoiPhuc"
        Me.btnKhoiPhuc.Size = New System.Drawing.Size(75, 23)
        Me.btnKhoiPhuc.TabIndex = 7
        Me.btnKhoiPhuc.Text = "Khoi phuc"
        Me.btnKhoiPhuc.UseVisualStyleBackColor = True
        '
        'frmLoaiMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 457)
        Me.Controls.Add(Me.btnKhoiPhuc)
        Me.Controls.Add(Me.cbHienThiXoa)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.lTen)
        Me.Controls.Add(Me.lbDanhSach)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmLoaiMonAn"
        Me.Text = "frmLoaiMonAn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDanhSach As ListBox
    Friend WithEvents lTen As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents cbHienThiXoa As CheckBox
    Friend WithEvents btnKhoiPhuc As Button
End Class
