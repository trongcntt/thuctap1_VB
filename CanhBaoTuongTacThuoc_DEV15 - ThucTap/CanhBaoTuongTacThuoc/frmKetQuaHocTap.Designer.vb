<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKetQuaHocTap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKetQuaHocTap))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiemThi = New DevExpress.XtraEditors.TextEdit()
        Me.cbMaGV = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaLop = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaSV = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaMH = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dateNgayThi = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuuKQ = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDongKQ = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiemThi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaGV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaLop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaSV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaMH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayThi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateNgayThi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(27, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(17, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(27, 184)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Mã Sinh Viên"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(386, 117)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Ngày Thi"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(386, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(64, 19)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Điểm Thi"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(386, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Mã Môn Học"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(27, 117)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Mã Lớp Học"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(27, 64)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Mã Giáo Viên"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(163, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(192, 22)
        Me.txtID.TabIndex = 0
        '
        'txtDiemThi
        '
        Me.txtDiemThi.Location = New System.Drawing.Point(522, 64)
        Me.txtDiemThi.Name = "txtDiemThi"
        Me.txtDiemThi.Size = New System.Drawing.Size(239, 22)
        Me.txtDiemThi.TabIndex = 5
        '
        'cbMaGV
        '
        Me.cbMaGV.Location = New System.Drawing.Point(163, 64)
        Me.cbMaGV.Name = "cbMaGV"
        Me.cbMaGV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaGV.Size = New System.Drawing.Size(192, 22)
        Me.cbMaGV.TabIndex = 1
        '
        'cbMaLop
        '
        Me.cbMaLop.Location = New System.Drawing.Point(163, 116)
        Me.cbMaLop.Name = "cbMaLop"
        Me.cbMaLop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaLop.Size = New System.Drawing.Size(192, 22)
        Me.cbMaLop.TabIndex = 2
        '
        'cbMaSV
        '
        Me.cbMaSV.Location = New System.Drawing.Point(163, 181)
        Me.cbMaSV.Name = "cbMaSV"
        Me.cbMaSV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaSV.Size = New System.Drawing.Size(192, 22)
        Me.cbMaSV.TabIndex = 3
        '
        'cbMaMH
        '
        Me.cbMaMH.Location = New System.Drawing.Point(522, 11)
        Me.cbMaMH.Name = "cbMaMH"
        Me.cbMaMH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaMH.Size = New System.Drawing.Size(239, 22)
        Me.cbMaMH.TabIndex = 4
        '
        'dateNgayThi
        '
        Me.dateNgayThi.EditValue = Nothing
        Me.dateNgayThi.Location = New System.Drawing.Point(522, 116)
        Me.dateNgayThi.Name = "dateNgayThi"
        Me.dateNgayThi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateNgayThi.Size = New System.Drawing.Size(239, 22)
        Me.dateNgayThi.TabIndex = 6
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuuKQ)
        Me.PanelControl1.Controls.Add(Me.btnDongKQ)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 231)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(828, 50)
        Me.PanelControl1.TabIndex = 11
        '
        'btnLuuKQ
        '
        Me.btnLuuKQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuuKQ.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuuKQ.Appearance.Options.UseFont = True
        Me.btnLuuKQ.Image = CType(resources.GetObject("btnLuuKQ.Image"), System.Drawing.Image)
        Me.btnLuuKQ.Location = New System.Drawing.Point(574, 5)
        Me.btnLuuKQ.Name = "btnLuuKQ"
        Me.btnLuuKQ.Size = New System.Drawing.Size(108, 33)
        Me.btnLuuKQ.TabIndex = 7
        Me.btnLuuKQ.Text = "&Lưu (F2)"
        '
        'btnDongKQ
        '
        Me.btnDongKQ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDongKQ.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDongKQ.Appearance.Options.UseFont = True
        Me.btnDongKQ.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDongKQ.Image = CType(resources.GetObject("btnDongKQ.Image"), System.Drawing.Image)
        Me.btnDongKQ.Location = New System.Drawing.Point(697, 5)
        Me.btnDongKQ.Name = "btnDongKQ"
        Me.btnDongKQ.Size = New System.Drawing.Size(119, 33)
        Me.btnDongKQ.TabIndex = 8
        Me.btnDongKQ.Text = "&Đóng [ESC]"
        '
        'frmKetQuaHocTap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 281)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.dateNgayThi)
        Me.Controls.Add(Me.cbMaSV)
        Me.Controls.Add(Me.cbMaMH)
        Me.Controls.Add(Me.cbMaLop)
        Me.Controls.Add(Me.cbMaGV)
        Me.Controls.Add(Me.txtDiemThi)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "frmKetQuaHocTap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKetQuaHocTap"
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiemThi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaGV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaLop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaSV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaMH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayThi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateNgayThi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiemThi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbMaGV As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaLop As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaSV As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaMH As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dateNgayThi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuuKQ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDongKQ As DevExpress.XtraEditors.SimpleButton
End Class
