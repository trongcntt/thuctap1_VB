Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class MessageBox
    '/* Create By: Phạm Phú Đăng */
    '/* Company: Nanosoft.jsc */
    '/* Date: 20/10/2010 */
    '/* Note: Show message */
    Public Enum MessageBoxButton
        OK
        AbortRetryIgnore
        YesNoCancel
        YesNo
        RetryCancel
    End Enum

    'An bỏ X ở messageBox
    Public Enum MessageIcon
        Question
        Warning
        Information
        Delete
    End Enum

    Private intWith As Int32 = 0
    Private intWithMin As Int32 = 300
    Private intWithPanel As Int32 = 255
    Private intHeight As Int32 = 95

    Private Sub XmessageBox(ByVal nContent As String, ByVal nSize As Size, ByVal nFont As Font)
        Me.Text = "NanoSoft MessageBox"
        Me.lblNoiDung.Text = nContent.Trim
        Me.Font = nFont
    End Sub

    Private Sub SetButtons(ByVal buttons As MessageBoxButton)

        btnButton1.Visible = False
        btnButton2.Visible = False
        btnButton3.Visible = False

        Select Case buttons
            Case MessageBoxButton.OK
                btnButton3.Visible = True
                btnButton3.Text = "&Đóng"
                btnButton3.DialogResult = DialogResult.OK
                Exit Select
            Case MessageBoxButton.AbortRetryIgnore
                btnButton3.Visible = True
                btnButton3.Text = "&Hủy"
                btnButton3.DialogResult = DialogResult.Abort
                btnButton2.Visible = True
                btnButton2.Text = "&Thử lại"
                btnButton2.DialogResult = DialogResult.Retry
                btnButton2.Select()
                btnButton1.Visible = True
                btnButton1.Text = "&Bỏ qua"
                btnButton1.DialogResult = DialogResult.Ignore
                Exit Select
            Case MessageBoxButton.RetryCancel
                btnButton2.Visible = True
                btnButton2.Text = "&Thử lại"
                btnButton2.DialogResult = DialogResult.Retry
                btnButton2.Select()
                btnButton3.Visible = True
                btnButton3.Text = "&Hủy"
                btnButton3.DialogResult = DialogResult.Cancel
                Exit Select
            Case MessageBoxButton.YesNo
                btnButton2.Visible = True
                btnButton2.Text = "&Có"
                btnButton2.DialogResult = DialogResult.Yes
                btnButton2.Select()
                btnButton3.Visible = True
                btnButton3.Text = "&Không"
                btnButton3.DialogResult = DialogResult.No
                Exit Select
            Case MessageBoxButton.YesNoCancel
                btnButton1.Visible = True
                btnButton1.DialogResult = DialogResult.Yes
                btnButton1.Text = "&Có"
                btnButton1.Select()
                btnButton2.Visible = True
                btnButton2.DialogResult = DialogResult.No
                btnButton2.Text = "&Không"
                btnButton3.Visible = True
                btnButton3.DialogResult = DialogResult.Cancel
                btnButton3.Text = "&Hủy"
                Exit Select
        End Select

        'intWith = lblNoiDung.Width '/* width lblNoiDung */

        'If buttons = MessageBoxButton.AbortRetryIgnore Or buttons = MessageBoxButton.YesNoCancel Then '/* Giới hạn chiều dài của form thông báo khi chuỗi thông báo ngắn hơn chiều dài panel */
        '    If intWith <= intWithPanel Then
        '        intWith = intWithPanel
        '    Else
        '        intWith = lblNoiDung.Width + 200
        '    End If
        'ElseIf buttons = MessageBoxButton.RetryCancel Or buttons = MessageBoxButton.YesNo Then
        '    If intWith <= intWithMin Then '/* Nếu chiều dài của nội dung thông báo quá ngắn */
        '        intWith = intWithMin
        '    Else
        '        intWith = lblNoiDung.Width + 200
        '    End If
        'Else '/* Chiều dài của form thông báo bằng với chiều dài nội dung thông báo + 70 */
        '    intWith = lblNoiDung.Width + 200
        'End If

        'Me.Size = New System.Drawing.Size(intWith, intHeight)

    End Sub

    Private Sub SetIcon(ByVal icon As MessageIcon)
        Select Case icon
            Case MessageIcon.Information
                picPicture.Image = My.Resources.InformationN
                Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
                Exit Select
            Case MessageIcon.Warning
                picPicture.Image = My.Resources.ExclamationN
                Me.Appearance.BackColor = System.Drawing.Color.Moccasin
                Me.lblNoiDung.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin
                Exit Select
            Case MessageIcon.Question
                picPicture.Image = My.Resources.QuestionN
                Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
                Exit Select
            Case MessageIcon.Delete
                picPicture.Image = My.Resources.DeleteN
                Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
                Exit Select
        End Select

    End Sub

    Public Function Show_Message(ByVal Noidung As String, ByVal button As MessageBoxButton, ByVal Icon As MessageIcon) As DialogResult
        Dim frm As New MessageBox
        frm.XmessageBox(Noidung, frm.Size, frm.Font)
        frm.SetButtons(button)
        frm.SetIcon(Icon)
        Return frm.ShowDialog
    End Function

    Public Function Show_TrungDuLieu() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Dữ liệu đã tồn tại!", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Warning)
        Return frm.ShowDialog()
    End Function

    Public Function Show_DuLieuKhongHopLe() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Dữ liệu nhập không hợp lệ!", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Warning)
        Return frm.ShowDialog()
    End Function

    Public Function Show_DuLieuTrong(ByVal FieldName As String) As String
        Dim frm As New MessageBox()
        frm.XmessageBox("Bạn chưa nhập " + FieldName.Trim().ToLower() + " !", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Warning)
        Return frm.ShowDialog()
    End Function

    Public Function Show_CapNhatThanhCong() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Cập nhật thành công !", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Information)
        Return frm.ShowDialog()
    End Function

    Public Function Show_DuLieuBiRangBuoc() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Dữ liệu bị dàng buộc. Bạn không thể xóa!", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Warning)
        Return frm.ShowDialog()
    End Function

    Public Function Show_ChuaChonBanGhiDeXoa() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Bạn chưa chọn bản ghi để xóa !", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.OK)
        frm.SetIcon(MessageIcon.Warning)
        Return frm.ShowDialog()
    End Function

    Public Function Show_HoiTruocKhiXoa() As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox("Bạn có chắc muốn xóa bản ghi này không?", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.YesNo)
        frm.SetIcon(MessageIcon.Question)
        Return frm.ShowDialog()
    End Function
    Public Function Show_HoiTruocKhiGui(ByVal s As String) As DialogResult
        Dim frm As New MessageBox()
        frm.XmessageBox(s, frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.YesNo)
        frm.SetIcon(MessageIcon.Question)
        Return frm.ShowDialog()
    End Function
    Public Function Show_TaiKham(ByVal SoNgay As String, ByVal Ngay As String) As DialogResult
        Dim frm As New MessageBox()
        frm.lblNoiDung.Visible = False
        frm.lblND1.Visible = True
        frm.lblND2.Visible = True
        frm.lblND3.Visible = True
        frm.lblNgay.Visible = True

        frm.lblNgay.Text = SoNgay
        frm.lblND3.Text = "ngày (" & Ngay & ")"
        frm.XmessageBox("", frm.Size, frm.Font)
        frm.SetButtons(MessageBoxButton.YesNo)
        frm.SetIcon(MessageIcon.Question)
        Return frm.ShowDialog()
    End Function

End Class