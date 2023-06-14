<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiaoVienn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGiaoVienn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGhiChu = New DevExpress.XtraEditors.MemoEdit()
        Me.cbMaGV = New System.Windows.Forms.ComboBox()
        Me.txtTenGV = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Mã GV:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Tên Giáo Viên :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 21)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Ghi chú :"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(171, 160)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(501, 106)
        Me.txtGhiChu.TabIndex = 3
        '
        'cbMaGV
        '
        Me.cbMaGV.FormattingEnabled = True
        Me.cbMaGV.Items.AddRange(New Object() {"GiaoVien1", "GiaoVien2", "GiaoVien3", "GiaoVien4", "GiaoVien5"})
        Me.cbMaGV.Location = New System.Drawing.Point(208, 38)
        Me.cbMaGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMaGV.Name = "cbMaGV"
        Me.cbMaGV.Size = New System.Drawing.Size(464, 28)
        Me.cbMaGV.TabIndex = 0
        '
        'txtTenGV
        '
        Me.txtTenGV.Location = New System.Drawing.Point(208, 102)
        Me.txtTenGV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTenGV.Name = "txtTenGV"
        Me.txtTenGV.Size = New System.Drawing.Size(464, 27)
        Me.txtTenGV.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnLuu)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 289)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(692, 62)
        Me.PanelControl1.TabIndex = 62
        '
        'btnLuu
        '
        Me.btnLuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(375, 6)
        Me.btnLuu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(146, 41)
        Me.btnLuu.TabIndex = 3
        Me.btnLuu.Text = "&Lưu (F2)"
        '
        'btnDong
        '
        Me.btnDong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDong.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnDong.Appearance.Options.UseFont = True
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.Location = New System.Drawing.Point(529, 6)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(149, 41)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "&Đóng [ESC]"
        '
        'frmGiaoVienn
        '
        Me.AcceptButton = Me.btnLuu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 351)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtTenGV)
        Me.Controls.Add(Me.cbMaGV)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmGiaoVienn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lí giáo viên"
        CType(Me.txtGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cbMaGV As ComboBox
    Friend WithEvents txtTenGV As TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
End Class
