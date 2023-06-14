<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinhThanh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTinhThanh))
        Me.txtTenTT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMaTT = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaQuocGia = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtTenTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaQuocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTenTT
        '
        Me.txtTenTT.Location = New System.Drawing.Point(158, 75)
        Me.txtTenTT.Name = "txtTenTT"
        Me.txtTenTT.Size = New System.Drawing.Size(216, 22)
        Me.txtTenTT.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(27, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 21)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Mã Tỉnh Thành"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(402, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Mã Quốc Gia"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(402, 79)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 21)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Ghi Chú"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(27, 78)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(116, 21)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Tên Tỉnh Thành"
        '
        'cbMaTT
        '
        Me.cbMaTT.Location = New System.Drawing.Point(158, 25)
        Me.cbMaTT.Name = "cbMaTT"
        Me.cbMaTT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaTT.Properties.Items.AddRange(New Object() {"Tinh01", "Tinh02", "Tinh03", "Tinh04", "Tinh05"})
        Me.cbMaTT.Size = New System.Drawing.Size(216, 22)
        Me.cbMaTT.TabIndex = 0
        '
        'cbMaQuocGia
        '
        Me.cbMaQuocGia.Location = New System.Drawing.Point(513, 25)
        Me.cbMaQuocGia.Name = "cbMaQuocGia"
        Me.cbMaQuocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaQuocGia.Properties.Items.AddRange(New Object() {"Tinh01_BH1", "Tinh02_BH2", "Tinh03_BH3", "Tinh04_BH4", "Tinh05_BH5"})
        Me.cbMaQuocGia.Size = New System.Drawing.Size(216, 22)
        Me.cbMaQuocGia.TabIndex = 2
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(513, 69)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(216, 69)
        Me.txtGhiChu.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 147)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(736, 50)
        Me.PanelControl1.TabIndex = 8
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(482, 5)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(108, 33)
        Me.btnLuu.TabIndex = 4
        Me.btnLuu.Text = "&Lưu (F2)"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDong.Appearance.Options.UseFont = True
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.Location = New System.Drawing.Point(605, 5)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(119, 33)
        Me.btnDong.TabIndex = 5
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'frmTinhThanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 197)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.cbMaQuocGia)
        Me.Controls.Add(Me.cbMaTT)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtTenTT)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmTinhThanh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTinhThanh"
        CType(Me.txtTenTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaQuocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTenTT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMaTT As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaQuocGia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
