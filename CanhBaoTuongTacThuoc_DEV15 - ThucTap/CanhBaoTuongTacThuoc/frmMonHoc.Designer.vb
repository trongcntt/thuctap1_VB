<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonHoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonHoc))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtID = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenMonHoc = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.cbMaMonHoc = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenMonHoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbMaMonHoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(27, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(17, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(27, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Mã Môn Học"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(27, 113)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 19)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Tên Môn Học"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(169, 13)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(260, 22)
        Me.txtID.TabIndex = 1
        '
        'txtTenMonHoc
        '
        Me.txtTenMonHoc.Location = New System.Drawing.Point(169, 110)
        Me.txtTenMonHoc.Name = "txtTenMonHoc"
        Me.txtTenMonHoc.Size = New System.Drawing.Size(260, 22)
        Me.txtTenMonHoc.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 161)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(464, 50)
        Me.PanelControl1.TabIndex = 4
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(210, 5)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(108, 33)
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
        Me.btnDong.Location = New System.Drawing.Point(333, 5)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(119, 33)
        Me.btnDong.TabIndex = 1
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'cbMaMonHoc
        '
        Me.cbMaMonHoc.Location = New System.Drawing.Point(169, 58)
        Me.cbMaMonHoc.Name = "cbMaMonHoc"
        Me.cbMaMonHoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMaMonHoc.Size = New System.Drawing.Size(260, 22)
        Me.cbMaMonHoc.TabIndex = 2
        '
        'frmMonHoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 211)
        Me.Controls.Add(Me.cbMaMonHoc)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtTenMonHoc)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "frmMonHoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMonHoc"
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenMonHoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.cbMaMonHoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenMonHoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbMaMonHoc As DevExpress.XtraEditors.ComboBoxEdit
End Class
