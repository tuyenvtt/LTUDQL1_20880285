<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDangNhap
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
        Me.lTenDangNhap = New System.Windows.Forms.Label()
        Me.lMatKhau = New System.Windows.Forms.Label()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lTenDangNhap
        '
        Me.lTenDangNhap.AutoSize = True
        Me.lTenDangNhap.Location = New System.Drawing.Point(58, 54)
        Me.lTenDangNhap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTenDangNhap.Name = "lTenDangNhap"
        Me.lTenDangNhap.Size = New System.Drawing.Size(80, 13)
        Me.lTenDangNhap.TabIndex = 0
        Me.lTenDangNhap.Text = "Ten dang nhap"
        '
        'lMatKhau
        '
        Me.lMatKhau.AutoSize = True
        Me.lMatKhau.Location = New System.Drawing.Point(58, 90)
        Me.lMatKhau.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMatKhau.Name = "lMatKhau"
        Me.lMatKhau.Size = New System.Drawing.Size(52, 13)
        Me.lMatKhau.TabIndex = 1
        Me.lMatKhau.Text = "Mat khau"
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(145, 54)
        Me.tbTenDangNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(162, 20)
        Me.tbTenDangNhap.TabIndex = 2
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(145, 87)
        Me.tbMatKhau.Margin = New System.Windows.Forms.Padding(2)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.Size = New System.Drawing.Size(162, 20)
        Me.tbMatKhau.TabIndex = 3
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(145, 135)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(48, 22)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Thoat"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(228, 135)
        Me.btnDangNhap.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(76, 22)
        Me.btnDangNhap.TabIndex = 5
        Me.btnDangNhap.Text = "Dang Nhap"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'FrmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 252)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.lMatKhau)
        Me.Controls.Add(Me.lTenDangNhap)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmDangNhap"
        Me.Text = "FrmDangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lTenDangNhap As Label
    Friend WithEvents lMatKhau As Label
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents btnDong As Button
    Friend WithEvents btnDangNhap As Button
End Class
