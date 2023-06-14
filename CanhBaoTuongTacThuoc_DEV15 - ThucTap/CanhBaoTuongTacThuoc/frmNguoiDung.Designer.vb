<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoiDung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNguoiDung))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaND = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenND = New DevExpress.XtraEditors.TextEdit()
        Me.txtMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenND.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 17)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Mã Người Dùng"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 124)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(105, 17)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = " Tên Người Dùng"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 173)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 17)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Mật Khẩu"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(177, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(214, 22)
        Me.txtID.TabIndex = 1
        '
        'txtMaND
        '
        Me.txtMaND.Location = New System.Drawing.Point(177, 66)
        Me.txtMaND.Name = "txtMaND"
        Me.txtMaND.Size = New System.Drawing.Size(214, 22)
        Me.txtMaND.TabIndex = 2
        '
        'txtTenND
        '
        Me.txtTenND.Location = New System.Drawing.Point(177, 119)
        Me.txtTenND.Name = "txtTenND"
        Me.txtTenND.Size = New System.Drawing.Size(214, 22)
        Me.txtTenND.TabIndex = 3
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(177, 170)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(214, 22)
        Me.txtMatKhau.TabIndex = 4
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 226)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(510, 50)
        Me.PanelControl1.TabIndex = 2
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(256, 5)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(108, 33)
        Me.btnLuu.TabIndex = 5
        Me.btnLuu.Text = "&Lưu (F2)"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDong.Appearance.Options.UseFont = True
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.Location = New System.Drawing.Point(379, 5)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(119, 33)
        Me.btnDong.TabIndex = 6
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'frmNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 276)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.txtTenND)
        Me.Controls.Add(Me.txtMaND)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "frmNguoiDung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNguoiDung"
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenND.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenND As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
