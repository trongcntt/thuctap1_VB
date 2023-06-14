<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXaPhuong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXaPhuong))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMaXa = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbMaQH = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtTenXa = New DevExpress.XtraEditors.TextEdit()
        Me.txtMoTa = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbMaXa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMaQH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenXa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMoTa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã Xã"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(361, 13)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(117, 21)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Mã Quận Huyện"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(361, 72)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(112, 21)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Mô Tả Thôn Xã"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(52, 21)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Tên Xã"
        '
        'cbMaXa
        '
        Me.cbMaXa.Location = New System.Drawing.Point(143, 13)
        Me.cbMaXa.Name = "cbMaXa"
        Me.cbMaXa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaXa.Properties.Items.AddRange(New Object() {"Xa01", "Xa02", "Xa03", "Xa04", "Xa05"})
        Me.cbMaXa.Size = New System.Drawing.Size(183, 22)
        Me.cbMaXa.TabIndex = 0
        '
        'cbMaQH
        '
        Me.cbMaQH.Location = New System.Drawing.Point(498, 13)
        Me.cbMaQH.Name = "cbMaQH"
        Me.cbMaQH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaQH.Properties.Items.AddRange(New Object() {"Huyen01", "Huyen02", "Huyen03", "Huyen04", "Huyen05"})
        Me.cbMaQH.Size = New System.Drawing.Size(240, 22)
        Me.cbMaQH.TabIndex = 2
        '
        'txtTenXa
        '
        Me.txtTenXa.Location = New System.Drawing.Point(143, 60)
        Me.txtTenXa.Name = "txtTenXa"
        Me.txtTenXa.Size = New System.Drawing.Size(183, 22)
        Me.txtTenXa.TabIndex = 1
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(498, 50)
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(240, 77)
        Me.txtMoTa.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 160)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(801, 50)
        Me.PanelControl1.TabIndex = 12
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(547, 5)
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
        Me.btnDong.Location = New System.Drawing.Point(670, 5)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(119, 33)
        Me.btnDong.TabIndex = 5
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'frmXaPhuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 210)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtMoTa)
        Me.Controls.Add(Me.txtTenXa)
        Me.Controls.Add(Me.cbMaQH)
        Me.Controls.Add(Me.cbMaXa)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "frmXaPhuong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmXaPhuong"
        CType(Me.cbMaXa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMaQH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenXa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMoTa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMaXa As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbMaQH As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTenXa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMoTa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
