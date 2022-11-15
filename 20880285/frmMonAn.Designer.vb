<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonAn
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.tbTimKiem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.cbLoai = New System.Windows.Forms.ComboBox()
        Me.nudGia = New System.Windows.Forms.NumericUpDown()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDanhSach)
        Me.Panel1.Controls.Add(Me.tbTimKiem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 817)
        Me.Panel1.TabIndex = 0
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSach.Location = New System.Drawing.Point(0, 31)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.RowHeadersWidth = 82
        Me.dgvDanhSach.RowTemplate.Height = 33
        Me.dgvDanhSach.Size = New System.Drawing.Size(430, 786)
        Me.dgvDanhSach.TabIndex = 1
        '
        'tbTimKiem
        '
        Me.tbTimKiem.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTimKiem.Location = New System.Drawing.Point(0, 0)
        Me.tbTimKiem.Name = "tbTimKiem"
        Me.tbTimKiem.Size = New System.Drawing.Size(430, 31)
        Me.tbTimKiem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(503, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loai mon an"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ten mon an"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gia mon an"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(668, 219)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(281, 31)
        Me.tbTen.TabIndex = 4
        '
        'cbLoai
        '
        Me.cbLoai.FormattingEnabled = True
        Me.cbLoai.Location = New System.Drawing.Point(668, 123)
        Me.cbLoai.Name = "cbLoai"
        Me.cbLoai.Size = New System.Drawing.Size(281, 33)
        Me.cbLoai.TabIndex = 5
        '
        'nudGia
        '
        Me.nudGia.Location = New System.Drawing.Point(668, 316)
        Me.nudGia.Name = "nudGia"
        Me.nudGia.Size = New System.Drawing.Size(281, 31)
        Me.nudGia.TabIndex = 6
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(468, 450)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(112, 64)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(700, 450)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(112, 64)
        Me.btnCapNhat.TabIndex = 8
        Me.btnCapNhat.Text = "Cap Nhat"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(925, 441)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(112, 64)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 817)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.nudGia)
        Me.Controls.Add(Me.cbLoai)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMonAn"
        Me.Text = "frmMonAn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTimKiem As TextBox
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents cbLoai As ComboBox
    Friend WithEvents nudGia As NumericUpDown
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
