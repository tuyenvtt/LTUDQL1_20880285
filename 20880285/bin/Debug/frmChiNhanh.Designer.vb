<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiNhanh
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
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbTimKiem = New System.Windows.Forms.TextBox()
        Me.lTen = New System.Windows.Forms.Label()
        Me.lDiaChi = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.AllowUserToAddRows = False
        Me.dgvDanhSach.AllowUserToDeleteRows = False
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSach.Location = New System.Drawing.Point(0, 0)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.RowHeadersWidth = 82
        Me.dgvDanhSach.RowTemplate.Height = 33
        Me.dgvDanhSach.Size = New System.Drawing.Size(682, 989)
        Me.dgvDanhSach.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbTimKiem)
        Me.Panel1.Controls.Add(Me.dgvDanhSach)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 989)
        Me.Panel1.TabIndex = 1
        '
        'tbTimKiem
        '
        Me.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTimKiem.Location = New System.Drawing.Point(0, 0)
        Me.tbTimKiem.Name = "tbTimKiem"
        Me.tbTimKiem.Size = New System.Drawing.Size(682, 31)
        Me.tbTimKiem.TabIndex = 0
        '
        'lTen
        '
        Me.lTen.AutoSize = True
        Me.lTen.Location = New System.Drawing.Point(843, 116)
        Me.lTen.Name = "lTen"
        Me.lTen.Size = New System.Drawing.Size(149, 25)
        Me.lTen.TabIndex = 2
        Me.lTen.Text = "Ten chi nhanh"
        '
        'lDiaChi
        '
        Me.lDiaChi.AutoSize = True
        Me.lDiaChi.Location = New System.Drawing.Point(843, 216)
        Me.lDiaChi.Name = "lDiaChi"
        Me.lDiaChi.Size = New System.Drawing.Size(178, 25)
        Me.lDiaChi.TabIndex = 3
        Me.lDiaChi.Text = "Dia chi chi nhanh"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(1040, 113)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(365, 31)
        Me.tbTen.TabIndex = 4
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(1040, 216)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(365, 31)
        Me.tbDiaChi.TabIndex = 5
        '
        'btnThem
        '
        Me.btnThem.ForeColor = System.Drawing.Color.Black
        Me.btnThem.Location = New System.Drawing.Point(811, 435)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(134, 55)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(1077, 435)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(134, 55)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "Cap Nhat"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(1342, 435)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(134, 55)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1606, 989)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.lDiaChi)
        Me.Controls.Add(Me.lTen)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmChiNhanh"
        Me.Text = "frmChiNhanh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents lTen As Label
    Friend WithEvents lDiaChi As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
