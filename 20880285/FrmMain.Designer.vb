<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.HeThongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUANLYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguoiDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhanhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoaiMonAnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeThongToolStripMenuItem, Me.QUANLYToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip2.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'HeThongToolStripMenuItem
        '
        Me.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem"
        Me.HeThongToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.HeThongToolStripMenuItem.Text = "HE THONG"
        '
        'QUANLYToolStripMenuItem
        '
        Me.QUANLYToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NguoiDungToolStripMenuItem, Me.ChiNhanhToolStripMenuItem, Me.MenuToolStripMenuItem, Me.LoaiMonAnToolStripMenuItem})
        Me.QUANLYToolStripMenuItem.Name = "QUANLYToolStripMenuItem"
        Me.QUANLYToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.QUANLYToolStripMenuItem.Text = "QUAN LY"
        '
        'NguoiDungToolStripMenuItem
        '
        Me.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem"
        Me.NguoiDungToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NguoiDungToolStripMenuItem.Text = "Nguoi dung"
        '
        'ChiNhanhToolStripMenuItem
        '
        Me.ChiNhanhToolStripMenuItem.Name = "ChiNhanhToolStripMenuItem"
        Me.ChiNhanhToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ChiNhanhToolStripMenuItem.Text = "Chi Nhanh"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LoaiMonAnToolStripMenuItem
        '
        Me.LoaiMonAnToolStripMenuItem.Name = "LoaiMonAnToolStripMenuItem"
        Me.LoaiMonAnToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.LoaiMonAnToolStripMenuItem.Text = "Loai Mon An"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 458)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMain"
        Me.Text = "Ung Dung Quan Ly Quan An"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents HeThongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QUANLYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NguoiDungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiNhanhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoaiMonAnToolStripMenuItem As ToolStripMenuItem
End Class
