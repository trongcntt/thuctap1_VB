<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSinhVien
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSinhVien))
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaSV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenSV = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNamsinh = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuuSV = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDongSV = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMaLop = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaGV = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbGioiTinh = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.NanoThucTapDataSet = New CanhBaoTuongTacThuoc.NanoThucTapDataSet()
        Me.TinhBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TinhTableAdapter = New CanhBaoTuongTacThuoc.NanoThucTapDataSetTableAdapters.tinhTableAdapter()
        Me.cbTT = New System.Windows.Forms.ComboBox()
        Me.TinhBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbXP = New System.Windows.Forms.ComboBox()
        Me.cbQH = New System.Windows.Forms.ComboBox()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaSV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenSV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamsinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbMaLop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaGV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NanoThucTapDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinhBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinhBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(110, 30)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(138, 22)
        Me.txtId.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 34)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(110, 75)
        Me.txtMaSV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(138, 22)
        Me.txtMaSV.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 73)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Mã Sinh Viên"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 120)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 17)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Mã Lớp"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(18, 177)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Mã Giáo Viên"
        '
        'txtTenSV
        '
        Me.txtTenSV.Location = New System.Drawing.Point(110, 233)
        Me.txtTenSV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(138, 22)
        Me.txtTenSV.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(18, 236)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Tên Sinh Viên"
        '
        'txtNamsinh
        '
        Me.txtNamsinh.Location = New System.Drawing.Point(407, 34)
        Me.txtNamsinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamsinh.Name = "txtNamsinh"
        Me.txtNamsinh.Size = New System.Drawing.Size(138, 22)
        Me.txtNamsinh.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(309, 37)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Năm Sinh"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(309, 72)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Giới Tính"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(309, 124)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 17)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "Tỉnh Thành"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(309, 179)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Quận Huyện"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(309, 236)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(68, 17)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "Xã Phường"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuuSV)
        Me.PanelControl1.Controls.Add(Me.btnDongSV)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 270)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(573, 50)
        Me.PanelControl1.TabIndex = 10
        '
        'btnLuuSV
        '
        Me.btnLuuSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuuSV.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuuSV.Appearance.Options.UseFont = True
        Me.btnLuuSV.Image = CType(resources.GetObject("btnLuuSV.Image"), System.Drawing.Image)
        Me.btnLuuSV.Location = New System.Drawing.Point(233, 0)
        Me.btnLuuSV.Name = "btnLuuSV"
        Me.btnLuuSV.Size = New System.Drawing.Size(119, 35)
        Me.btnLuuSV.TabIndex = 0
        Me.btnLuuSV.Text = "&Lưu (F2)"
        '
        'btnDongSV
        '
        Me.btnDongSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDongSV.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDongSV.Appearance.Options.UseFont = True
        Me.btnDongSV.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDongSV.Image = CType(resources.GetObject("btnDongSV.Image"), System.Drawing.Image)
        Me.btnDongSV.Location = New System.Drawing.Point(374, 0)
        Me.btnDongSV.Name = "btnDongSV"
        Me.btnDongSV.Size = New System.Drawing.Size(125, 35)
        Me.btnDongSV.TabIndex = 1
        Me.btnDongSV.Text = "&Đóng [ESC]"
        '
        'cbMaLop
        '
        Me.cbMaLop.Location = New System.Drawing.Point(110, 121)
        Me.cbMaLop.Name = "cbMaLop"
        Me.cbMaLop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaLop.Properties.Items.AddRange(New Object() {"lop01", "lop02", "lop03", "lop04", "lop05"})
        Me.cbMaLop.Size = New System.Drawing.Size(138, 22)
        Me.cbMaLop.TabIndex = 2
        '
        'cbMaGV
        '
        Me.cbMaGV.Location = New System.Drawing.Point(110, 176)
        Me.cbMaGV.Name = "cbMaGV"
        Me.cbMaGV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaGV.Properties.Items.AddRange(New Object() {"gv01", "gv02", "gv03", "gv04", "gv05"})
        Me.cbMaGV.Size = New System.Drawing.Size(138, 22)
        Me.cbMaGV.TabIndex = 3
        '
        'cbGioiTinh
        '
        Me.cbGioiTinh.Location = New System.Drawing.Point(407, 75)
        Me.cbGioiTinh.Name = "cbGioiTinh"
        Me.cbGioiTinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbGioiTinh.Properties.Items.AddRange(New Object() {"Nam", "Nữ", "Khác"})
        Me.cbGioiTinh.Size = New System.Drawing.Size(138, 22)
        Me.cbGioiTinh.TabIndex = 6
        '
        'NanoThucTapDataSet
        '
        Me.NanoThucTapDataSet.DataSetName = "NanoThucTapDataSet"
        Me.NanoThucTapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TinhBindingSource
        '
        Me.TinhBindingSource.DataMember = "tinh"
        Me.TinhBindingSource.DataSource = Me.NanoThucTapDataSet
        '
        'TinhTableAdapter
        '
        Me.TinhTableAdapter.ClearBeforeFill = True
        '
        'cbTT
        '
        Me.cbTT.FormattingEnabled = True
        Me.cbTT.Location = New System.Drawing.Point(407, 124)
        Me.cbTT.Name = "cbTT"
        Me.cbTT.Size = New System.Drawing.Size(138, 30)
        Me.cbTT.TabIndex = 7
        '
        'TinhBindingSource1
        '
        Me.TinhBindingSource1.DataMember = "tinh"
        Me.TinhBindingSource1.DataSource = Me.NanoThucTapDataSet
        '
        'cbXP
        '
        Me.cbXP.FormattingEnabled = True
        Me.cbXP.Location = New System.Drawing.Point(407, 229)
        Me.cbXP.Name = "cbXP"
        Me.cbXP.Size = New System.Drawing.Size(138, 30)
        Me.cbXP.TabIndex = 9
        '
        'cbQH
        '
        Me.cbQH.FormattingEnabled = True
        Me.cbQH.Location = New System.Drawing.Point(407, 170)
        Me.cbQH.Name = "cbQH"
        Me.cbQH.Size = New System.Drawing.Size(138, 30)
        Me.cbQH.TabIndex = 8
        '
        'frmSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 320)
        Me.Controls.Add(Me.cbXP)
        Me.Controls.Add(Me.cbQH)
        Me.Controls.Add(Me.cbTT)
        Me.Controls.Add(Me.cbMaGV)
        Me.Controls.Add(Me.cbGioiTinh)
        Me.Controls.Add(Me.cbMaLop)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtNamsinh)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtTenSV)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.txtId)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSinhVien"
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaSV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenSV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamsinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cbMaLop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaGV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbGioiTinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NanoThucTapDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinhBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinhBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaSV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenSV As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNamsinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuuSV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDongSV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMaLop As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaGV As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbGioiTinh As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents NanoThucTapDataSet As NanoThucTapDataSet
    Friend WithEvents TinhBindingSource As BindingSource
    Friend WithEvents TinhTableAdapter As NanoThucTapDataSetTableAdapters.tinhTableAdapter
    Friend WithEvents cbTT As ComboBox
    Friend WithEvents TinhBindingSource1 As BindingSource
    Friend WithEvents cbXP As ComboBox
    Friend WithEvents cbQH As ComboBox
End Class
