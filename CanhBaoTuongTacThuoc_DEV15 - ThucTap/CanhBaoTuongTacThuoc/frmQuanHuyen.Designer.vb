<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanHuyen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanHuyen))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMaQH = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaTT = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTenQH = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuuQH = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbMaQH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(32, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(117, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã Quận Huyện"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(413, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 21)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Ghi Chú"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(413, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 21)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Mã Tỉnh Thành"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(32, 63)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(123, 21)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Tên Quận Huyện"
        '
        'cbMaQH
        '
        Me.cbMaQH.Location = New System.Drawing.Point(188, 13)
        Me.cbMaQH.Name = "cbMaQH"
        Me.cbMaQH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaQH.Properties.Items.AddRange(New Object() {"Huyen01", "Huyen02", "Huyen03", "Huyen04", "Huyen05"})
        Me.cbMaQH.Size = New System.Drawing.Size(194, 22)
        Me.cbMaQH.TabIndex = 0
        '
        'cbMaTT
        '
        Me.cbMaTT.Location = New System.Drawing.Point(546, 13)
        Me.cbMaTT.Name = "cbMaTT"
        Me.cbMaTT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaTT.Properties.Items.AddRange(New Object() {"Tinh01", "Tinh02", "Tinh03", "Tinh04", "Tinh05"})
        Me.cbMaTT.Size = New System.Drawing.Size(194, 22)
        Me.cbMaTT.TabIndex = 2
        '
        'txtTenQH
        '
        Me.txtTenQH.Location = New System.Drawing.Point(188, 63)
        Me.txtTenQH.Name = "txtTenQH"
        Me.txtTenQH.Size = New System.Drawing.Size(194, 22)
        Me.txtTenQH.TabIndex = 1
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(546, 64)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(194, 85)
        Me.txtGhiChu.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuuQH)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 163)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(779, 50)
        Me.PanelControl1.TabIndex = 10
        '
        'btnLuuQH
        '
        Me.btnLuuQH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuuQH.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuuQH.Appearance.Options.UseFont = True
        Me.btnLuuQH.Image = CType(resources.GetObject("btnLuuQH.Image"), System.Drawing.Image)
        Me.btnLuuQH.Location = New System.Drawing.Point(525, 5)
        Me.btnLuuQH.Name = "btnLuuQH"
        Me.btnLuuQH.Size = New System.Drawing.Size(108, 33)
        Me.btnLuuQH.TabIndex = 4
        Me.btnLuuQH.Text = "&Lưu (F2)"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDong.Appearance.Options.UseFont = True
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.Location = New System.Drawing.Point(648, 5)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(119, 33)
        Me.btnDong.TabIndex = 5
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'frmQuanHuyen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 213)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTenQH)
        Me.Controls.Add(Me.cbMaTT)
        Me.Controls.Add(Me.cbMaQH)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "frmQuanHuyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmQuanHuyen"
        CType(Me.cbMaQH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMaQH As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaTT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTenQH As TextBox
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuuQH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
