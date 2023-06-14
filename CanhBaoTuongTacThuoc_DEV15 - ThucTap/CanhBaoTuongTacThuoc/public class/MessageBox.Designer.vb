<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox
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
        Me.picPicture = New DevExpress.XtraEditors.PictureEdit
        Me.btnButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.btnButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lblND1 = New DevExpress.XtraEditors.LabelControl
        Me.lblND2 = New DevExpress.XtraEditors.LabelControl
        Me.lblNgay = New DevExpress.XtraEditors.LabelControl
        Me.lblND3 = New DevExpress.XtraEditors.LabelControl
        Me.lblNoiDung = New DevExpress.XtraEditors.MemoEdit
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNoiDung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPicture.Location = New System.Drawing.Point(4, 3)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(48, 48)
        Me.picPicture.TabIndex = 0
        '
        'btnButton3
        '
        Me.btnButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton3.Appearance.Options.UseFont = True
        Me.btnButton3.Location = New System.Drawing.Point(362, 57)
        Me.btnButton3.Name = "btnButton3"
        Me.btnButton3.Size = New System.Drawing.Size(80, 30)
        Me.btnButton3.TabIndex = 4
        Me.btnButton3.Text = "SimpleButton1"
        '
        'btnButton2
        '
        Me.btnButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton2.Appearance.Options.UseFont = True
        Me.btnButton2.Location = New System.Drawing.Point(276, 57)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(80, 30)
        Me.btnButton2.TabIndex = 3
        Me.btnButton2.Text = "SimpleButton2"
        '
        'btnButton1
        '
        Me.btnButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnButton1.Appearance.Options.UseFont = True
        Me.btnButton1.Location = New System.Drawing.Point(190, 57)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(80, 30)
        Me.btnButton1.TabIndex = 2
        Me.btnButton1.Text = "SimpleButton3"
        '
        'lblND1
        '
        Me.lblND1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblND1.Appearance.Options.UseFont = True
        Me.lblND1.Location = New System.Drawing.Point(61, 10)
        Me.lblND1.Name = "lblND1"
        Me.lblND1.Size = New System.Drawing.Size(150, 16)
        Me.lblND1.TabIndex = 9
        Me.lblND1.Text = "Số thẻ vào khám cách đây"
        Me.lblND1.Visible = False
        '
        'lblND2
        '
        Me.lblND2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblND2.Appearance.Options.UseFont = True
        Me.lblND2.Location = New System.Drawing.Point(61, 30)
        Me.lblND2.Name = "lblND2"
        Me.lblND2.Size = New System.Drawing.Size(167, 16)
        Me.lblND2.TabIndex = 10
        Me.lblND2.Text = "Đồng ý lưu hồ sơ bệnh nhân?"
        Me.lblND2.Visible = False
        '
        'lblNgay
        '
        Me.lblNgay.Appearance.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lblNgay.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblNgay.Appearance.Options.UseFont = True
        Me.lblNgay.Appearance.Options.UseForeColor = True
        Me.lblNgay.Appearance.Options.UseTextOptions = True
        Me.lblNgay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNgay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNgay.Location = New System.Drawing.Point(211, 4)
        Me.lblNgay.Name = "lblNgay"
        Me.lblNgay.Size = New System.Drawing.Size(55, 25)
        Me.lblNgay.TabIndex = 11
        Me.lblNgay.Text = "100"
        Me.lblNgay.Visible = False
        '
        'lblND3
        '
        Me.lblND3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblND3.Appearance.Options.UseFont = True
        Me.lblND3.Location = New System.Drawing.Point(267, 10)
        Me.lblND3.Name = "lblND3"
        Me.lblND3.Size = New System.Drawing.Size(27, 16)
        Me.lblND3.TabIndex = 12
        Me.lblND3.Text = "ngày"
        Me.lblND3.Visible = False
        '
        'lblNoiDung
        '
        Me.lblNoiDung.EditValue = ""
        Me.lblNoiDung.Location = New System.Drawing.Point(58, 4)
        Me.lblNoiDung.Name = "lblNoiDung"
        Me.lblNoiDung.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoiDung.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblNoiDung.Properties.Appearance.Options.UseBackColor = True
        Me.lblNoiDung.Properties.Appearance.Options.UseFont = True
        Me.lblNoiDung.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblNoiDung.Properties.ReadOnly = True
        Me.lblNoiDung.Size = New System.Drawing.Size(384, 50)
        Me.lblNoiDung.TabIndex = 13
        '
        'MessageBox
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(448, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblND1)
        Me.Controls.Add(Me.lblND3)
        Me.Controls.Add(Me.lblNgay)
        Me.Controls.Add(Me.lblND2)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton3)
        Me.Controls.Add(Me.picPicture)
        Me.Controls.Add(Me.lblNoiDung)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNoiDung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblND1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblND2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNgay As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblND3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNoiDung As DevExpress.XtraEditors.MemoEdit
End Class
