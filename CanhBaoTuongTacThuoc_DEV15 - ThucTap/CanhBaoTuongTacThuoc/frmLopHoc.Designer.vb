<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLopHoc
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLopHoc))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMaLop = New System.Windows.Forms.ComboBox()
        Me.txtTenLop = New System.Windows.Forms.TextBox()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 181)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(495, 50)
        Me.PanelControl1.TabIndex = 3
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(250, 6)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(111, 35)
        Me.btnLuu.TabIndex = 0
        Me.btnLuu.Text = "&Lưu (F2)"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDong.Appearance.Options.UseFont = True
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.Location = New System.Drawing.Point(367, 6)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(116, 35)
        Me.btnDong.TabIndex = 1
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(150, 79)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(336, 83)
        Me.txtGhiChu.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(5, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Ghi chú :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(5, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Mã Lớp:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Tên Lớp :"
        '
        'cbMaLop
        '
        Me.cbMaLop.FormattingEnabled = True
        Me.cbMaLop.Items.AddRange(New Object() {"Lop01", "Lop02", "Lop03"})
        Me.cbMaLop.Location = New System.Drawing.Point(150, 15)
        Me.cbMaLop.Name = "cbMaLop"
        Me.cbMaLop.Size = New System.Drawing.Size(333, 24)
        Me.cbMaLop.TabIndex = 0
        '
        'txtTenLop
        '
        Me.txtTenLop.Location = New System.Drawing.Point(150, 47)
        Me.txtTenLop.Name = "txtTenLop"
        Me.txtTenLop.Size = New System.Drawing.Size(333, 23)
        Me.txtTenLop.TabIndex = 1
        '
        'frmLopHoc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(495, 231)
        Me.Controls.Add(Me.txtTenLop)
        Me.Controls.Add(Me.cbMaLop)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmLopHoc"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cập nhật danh mục tương tác thuốc"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMaLop As ComboBox
    Friend WithEvents txtTenLop As TextBox
End Class
