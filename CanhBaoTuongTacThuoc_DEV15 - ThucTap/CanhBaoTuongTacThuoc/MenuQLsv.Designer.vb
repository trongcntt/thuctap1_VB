<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuQLsv
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
        Me.btnQlsv = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnXaPhuong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnQuanHuyen = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTinhThanh = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNguoiDung = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSinhVien = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLophoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGV = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQlsv
        '
        Me.btnQlsv.Location = New System.Drawing.Point(1, 0)
        Me.btnQlsv.Name = "btnQlsv"
        Me.btnQlsv.Size = New System.Drawing.Size(149, 48)
        Me.btnQlsv.TabIndex = 0
        Me.btnQlsv.Text = "Quản lí sinh viên"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnXaPhuong)
        Me.PanelControl1.Controls.Add(Me.btnQuanHuyen)
        Me.PanelControl1.Controls.Add(Me.btnTinhThanh)
        Me.PanelControl1.Controls.Add(Me.btnNguoiDung)
        Me.PanelControl1.Controls.Add(Me.btnSinhVien)
        Me.PanelControl1.Controls.Add(Me.btnLophoc)
        Me.PanelControl1.Controls.Add(Me.btnGV)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 54)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(639, 134)
        Me.PanelControl1.TabIndex = 1
        Me.PanelControl1.Visible = False
        '
        'btnXaPhuong
        '
        Me.btnXaPhuong.Location = New System.Drawing.Point(324, 46)
        Me.btnXaPhuong.Name = "btnXaPhuong"
        Me.btnXaPhuong.Size = New System.Drawing.Size(154, 34)
        Me.btnXaPhuong.TabIndex = 7
        Me.btnXaPhuong.Text = "Xã Phường"
        '
        'btnQuanHuyen
        '
        Me.btnQuanHuyen.Location = New System.Drawing.Point(166, 46)
        Me.btnQuanHuyen.Name = "btnQuanHuyen"
        Me.btnQuanHuyen.Size = New System.Drawing.Size(154, 34)
        Me.btnQuanHuyen.TabIndex = 6
        Me.btnQuanHuyen.Text = "Quận Huyện"
        '
        'btnTinhThanh
        '
        Me.btnTinhThanh.Location = New System.Drawing.Point(6, 46)
        Me.btnTinhThanh.Name = "btnTinhThanh"
        Me.btnTinhThanh.Size = New System.Drawing.Size(154, 34)
        Me.btnTinhThanh.TabIndex = 5
        Me.btnTinhThanh.Text = "Tỉnh Thành"
        '
        'btnNguoiDung
        '
        Me.btnNguoiDung.Location = New System.Drawing.Point(478, 6)
        Me.btnNguoiDung.Name = "btnNguoiDung"
        Me.btnNguoiDung.Size = New System.Drawing.Size(155, 33)
        Me.btnNguoiDung.TabIndex = 4
        Me.btnNguoiDung.Text = "Người Dùng"
        '
        'btnSinhVien
        '
        Me.btnSinhVien.Location = New System.Drawing.Point(323, 6)
        Me.btnSinhVien.Name = "btnSinhVien"
        Me.btnSinhVien.Size = New System.Drawing.Size(155, 33)
        Me.btnSinhVien.TabIndex = 3
        Me.btnSinhVien.Text = "Sinh Viên"
        '
        'btnLophoc
        '
        Me.btnLophoc.Location = New System.Drawing.Point(165, 6)
        Me.btnLophoc.Name = "btnLophoc"
        Me.btnLophoc.Size = New System.Drawing.Size(155, 33)
        Me.btnLophoc.TabIndex = 2
        Me.btnLophoc.Text = "Lớp học"
        '
        'btnGV
        '
        Me.btnGV.Location = New System.Drawing.Point(5, 5)
        Me.btnGV.Name = "btnGV"
        Me.btnGV.Size = New System.Drawing.Size(155, 34)
        Me.btnGV.TabIndex = 1
        Me.btnGV.Text = "Giáo Viên"
        '
        'MenuQLsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 229)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btnQlsv)
        Me.Name = "MenuQLsv"
        Me.Text = "MenuQLsv"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQlsv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLophoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSinhVien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNguoiDung As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXaPhuong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnQuanHuyen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTinhThanh As DevExpress.XtraEditors.SimpleButton
End Class
