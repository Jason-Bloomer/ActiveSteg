Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Form1
    Private Declare Function GetTickCount Lib "kernel32" () As Long

    Dim OrigAlpha As Double = 1
    Dim Go As Boolean
    Dim LeftSet As Boolean
    Dim TopSet As Boolean
    Dim HoldLeft As Integer
    Dim HoldTop As Integer
    Dim OffLeft As Integer
    Dim OffTop As Integer
    Dim LiveFilteringState As Boolean = False
    Dim LiveUpdateLine As Integer = 0
    Dim LiveUpdateTimer As Integer = 0
    Dim HexEditorOpen As Boolean = False
    Dim SelectedFilterIndex As Integer = 0

    Dim image_data1 As Bitmap

    Dim Rchan As Boolean = True
    Dim Gchan As Boolean = True
    Dim Bchan As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub UpdateProgressBar(ByRef P1, P2)
        If P1 >= P2 Then
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 1
                P1 = 0
            End If
            If ProgressBar1.Value >= 100 Then
                ProgressBar1.Value = 100
                P1 = 0
            End If
        End If
    End Sub



    '########## Image Filters and Editing Functions ##########
    Private Sub CaptureScreen()
        Dim area As Rectangle
        Dim capture As Bitmap
        Dim graph As Graphics
        area = Me.Bounds
        capture = New Bitmap(area.Width, area.Height, Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        Me.Opacity = 0
        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
        Me.Opacity = OrigAlpha
        BackgroundRenderBoxMain.Image = capture
        graph.Dispose()
    End Sub

    Private Function ChannelFilter(ByRef bm_combined As Bitmap)
        Dim g_RowSizeBytes As Integer
        Dim g_PixBytes() As Byte
        Dim bounds As Rectangle = New Rectangle(0, 0, bm_combined.Width, bm_combined.Height)
        Dim m_BitmapData = bm_combined.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
        g_RowSizeBytes = m_BitmapData.Stride
        Dim total_size As Integer = m_BitmapData.Stride * m_BitmapData.Height
        ReDim g_PixBytes(total_size)
        Marshal.Copy(m_BitmapData.Scan0, g_PixBytes, 0, total_size)
        Dim pix As Integer = 0
        For Y = 0 To bm_combined.Height - 1
            For X = 0 To bm_combined.Width - 1
                'Remove unselected channels.
                For k = 0 To 2
                    If Rchan = False And k = 2 Then
                        g_PixBytes(pix) = 0
                    End If
                    If Gchan = False And k = 1 Then
                        g_PixBytes(pix) = 0
                    End If
                    If Bchan = False And k = 0 Then
                        g_PixBytes(pix) = 0
                    End If
                    pix += 1
                Next k
            Next X
            UpdateProgressBar((bm_combined.Height / Y), 0)
        Next Y
        Marshal.Copy(g_PixBytes, 0, m_BitmapData.Scan0, total_size)
        bm_combined.UnlockBits(m_BitmapData)
        g_PixBytes = Nothing
        m_BitmapData = Nothing
        ProgressBar1.Value = 0
        Return bm_combined
    End Function

    Private Function InvertFilter(ByRef bm_combined As Bitmap) As Bitmap
        Dim g_RowSizeBytes As Integer
        Dim g_PixBytes() As Byte
        Dim bounds As Rectangle = New Rectangle(0, 0, bm_combined.Width, bm_combined.Height)
        Dim m_BitmapData = bm_combined.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
        g_RowSizeBytes = m_BitmapData.Stride
        Dim total_size As Integer = m_BitmapData.Stride * m_BitmapData.Height
        ReDim g_PixBytes(total_size)
        Marshal.Copy(m_BitmapData.Scan0, g_PixBytes, 0, total_size)
        Dim pix As Integer = 0
        For Y = 0 To bm_combined.Height - 1
            For X = 0 To bm_combined.Width - 1
                ' Subtract r, g, and b from 255.
                For k = 0 To 2
                    If Rchan = True And k = 2 Then
                        g_PixBytes(pix) = 255 - g_PixBytes(pix)
                    End If
                    If Gchan = True And k = 1 Then
                        g_PixBytes(pix) = 255 - g_PixBytes(pix)
                    End If
                    If Bchan = True And k = 0 Then
                        g_PixBytes(pix) = 255 - g_PixBytes(pix)
                    End If
                    pix += 1
                Next k
            Next X
            UpdateProgressBar((bm_combined.Height / Y), 0)
        Next Y
        Marshal.Copy(g_PixBytes, 0, m_BitmapData.Scan0, total_size)
        bm_combined.UnlockBits(m_BitmapData)
        g_PixBytes = Nothing
        m_BitmapData = Nothing
        ProgressBar1.Value = 0
        Return bm_combined
    End Function

    Private Function StegBWFilter(ByRef bm_combined As Bitmap) As Bitmap
        Dim hidden_bits As Integer = 1
        Dim shift As Integer = (8 - hidden_bits)
        Dim hidden_mask As Integer = &HFF >> shift
        Dim g_RowSizeBytes As Integer
        Dim g_PixBytes() As Byte
        Dim bounds As Rectangle = New Rectangle(0, 0, bm_combined.Width, bm_combined.Height)
        Dim m_BitmapData = bm_combined.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
        g_RowSizeBytes = m_BitmapData.Stride
        Dim total_size As Integer = m_BitmapData.Stride * m_BitmapData.Height
        ReDim g_PixBytes(total_size)
        Marshal.Copy(m_BitmapData.Scan0, g_PixBytes, 0, total_size)
        Dim pix As Integer = 0
        For Y = 0 To bm_combined.Height - 1
            For X = 0 To bm_combined.Width - 1
                If pix < g_PixBytes.Length - 1 Then
                    Dim r As Integer
                    r = (g_PixBytes(pix) And hidden_mask) << shift
                    Dim g As Integer
                    g = (g_PixBytes(pix + 1) And hidden_mask) << shift
                    Dim b As Integer
                    b = (g_PixBytes(pix + 2) And hidden_mask) << shift
                    Dim newrgb As Integer = ((r * 1) + (g * 0.5) + (b * 0.25))
                    'newrgb
                    g_PixBytes(pix) = newrgb
                    g_PixBytes(pix + 1) = newrgb
                    g_PixBytes(pix + 2) = newrgb
                    pix += 3
                End If
            Next X
            UpdateProgressBar((bm_combined.Height / Y), 0)
        Next Y
        Marshal.Copy(g_PixBytes, 0, m_BitmapData.Scan0, total_size)
        bm_combined.UnlockBits(m_BitmapData)
        g_PixBytes = Nothing
        m_BitmapData = Nothing
        ProgressBar1.Value = 0
        Return bm_combined
    End Function

    Private Function StegColorFilter(ByRef bm_combined As Bitmap) As Bitmap
        Dim hidden_bits As Integer = 3
        Dim shift As Integer = (8 - hidden_bits)
        Dim hidden_mask As Integer = &HFF >> shift
        Dim g_RowSizeBytes As Integer
        Dim g_PixBytes() As Byte
        Dim bounds As Rectangle = New Rectangle(0, 0, bm_combined.Width, bm_combined.Height)
        Dim m_BitmapData = bm_combined.LockBits(bounds, Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format24bppRgb)
        g_RowSizeBytes = m_BitmapData.Stride
        Dim total_size As Integer = m_BitmapData.Stride * m_BitmapData.Height
        ReDim g_PixBytes(total_size)
        Marshal.Copy(m_BitmapData.Scan0, g_PixBytes, 0, total_size)
        Dim pix As Integer = 0
        For Y = 0 To bm_combined.Height - 1
            For X = 0 To bm_combined.Width - 1
                If pix < g_PixBytes.Length - 1 Then
                    For K = 0 To 2
                        Dim new_color As Byte = (g_PixBytes(pix) And hidden_mask) << shift
                        g_PixBytes(pix) = new_color
                        pix += 1
                    Next K
                End If
            Next X
            UpdateProgressBar((bm_combined.Height / Y), 0)
        Next Y
        Marshal.Copy(g_PixBytes, 0, m_BitmapData.Scan0, total_size)
        bm_combined.UnlockBits(m_BitmapData)
        g_PixBytes = Nothing
        m_BitmapData = Nothing
        ProgressBar1.Value = 0
        Return bm_combined
    End Function



    '########## Main UI Window Functions ##########
    Private Sub TitleBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolPanelTitleBar.MouseUp, HexEditorPanelTitleBar.MouseUp
        Go = False
        LeftSet = False
        TopSet = False
    End Sub

    Private Sub TitleBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolPanelTitleBar.MouseDown, HexEditorPanelTitleBar.MouseDown
        Go = True
    End Sub

    Private Sub TitleBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolPanelTitleBar.MouseMove, HexEditorPanelTitleBar.MouseMove
        If Go = True Then
            HoldLeft = (Control.MousePosition.X - Me.Left)
            HoldTop = (Control.MousePosition.Y - Me.Top)
            If TopSet = False Then
                OffTop = HoldTop - sender.Parent.Top
                TopSet = True
            End If
            If LeftSet = False Then
                OffLeft = HoldLeft - sender.Parent.Left
                LeftSet = True
            End If
            sender.Parent.Left = HoldLeft - OffLeft
            sender.Parent.Top = HoldTop - OffTop
            sender.Parent.Parent.Refresh()
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        BackgroundRenderBoxMain.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button12.Click
        CaptureScreen()
        If HexEditorOpen = True Then
            If BackgroundRenderBoxMain.Image IsNot Nothing Then
                image_data1 = BackgroundRenderBoxMain.Image
                UpdateHexEditorPanelConstraints()
                LoadImageData(0)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button11.Click
        SaveFileDialog1.Title() = "Save Image As..."
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button10.Click
        If LiveFilteringCheck.Checked = True Then
            Do While LiveFilteringCheck.Checked = True
                If LiveUpdateTimer < GetTickCount() Then
                    Dim area As Rectangle
                    Dim capture As Bitmap
                    Dim graph As Graphics
                    area = Me.Bounds
                    capture = New System.Drawing.Bitmap(area.Width, area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                    graph = Graphics.FromImage(capture)
                    Me.Opacity = 0
                    graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
                    Me.Opacity = OrigAlpha
                    graph.Dispose()
                    If ComboBox1.SelectedIndex = 0 Then
                        capture = StegBWFilter(capture)
                        BackgroundRenderBoxMain.Image = capture
                    ElseIf ComboBox1.SelectedIndex = 1 Then
                        capture = StegColorFilter(capture)
                        BackgroundRenderBoxMain.Image = capture
                    ElseIf ComboBox1.SelectedIndex = 2 Then
                        capture = InvertFilter(capture)
                        BackgroundRenderBoxMain.Image = capture
                    ElseIf ComboBox1.SelectedIndex = 3 Then
                        capture = ChannelFilter(capture)
                        BackgroundRenderBoxMain.Image = capture
                    End If
                    LiveUpdateTimer = GetTickCount() + 1000
                End If
                Application.DoEvents()
            Loop
        Else
            Dim capture As Bitmap = BackgroundRenderBoxMain.Image
            If ComboBox1.SelectedIndex = 0 Then
                capture = StegBWFilter(capture)
                BackgroundRenderBoxMain.Image = capture
            End If
            If ComboBox1.SelectedIndex = 1 Then
                capture = StegColorFilter(capture)
                BackgroundRenderBoxMain.Image = capture
            End If
            If ComboBox1.SelectedIndex = 2 Then
                capture = InvertFilter(capture)
                BackgroundRenderBoxMain.Image = capture
            End If
            If ComboBox1.SelectedIndex = 3 Then
                capture = ChannelFilter(capture)
                BackgroundRenderBoxMain.Image = capture
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button9.Click
        Me.Opacity = OrigAlpha
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        HexEditorOpen = True
        If BackgroundRenderBoxMain.Image IsNot Nothing Then
            image_data1 = BackgroundRenderBoxMain.Image
            UpdateHexEditorPanelConstraints()
            LoadImageData(0)
        End If
        HexEditorPanel.Top = ToolPanel.Top
        HexEditorPanel.Left = ToolPanel.Left
        HexEditorPanel.Visible = True
        HexEditorPanel.Enabled = True
        ToolPanel.Visible = False
        ToolPanel.Enabled = False
    End Sub

    Private Sub OverlayEnabledCheck_CheckedChanged_1(sender As Object, e As EventArgs) Handles OverlayEnabledCheck.CheckedChanged
        BackgroundRenderBoxMain.Visible = OverlayEnabledCheck.Checked
        BackgroundRenderBoxMain.Enabled = OverlayEnabledCheck.Checked
    End Sub



    '########## Hex Editor Panel Functions ##########
    Public Sub LoadImageData(ByVal LineNum As Integer)
        Dim progresstick As Integer = image_data1.Width / 100
        HexEditorTextBoxASCII.Text = ""
        HexEditorTextBoxHEX.Text = ""
        Dim posx As Integer = 0
        Dim AddData1 As String = ""
        Dim AddData2 As String = ""
        Dim PixClr As Color
        For posx = 0 To image_data1.Width - 1
            PixClr = image_data1.GetPixel(posx, LineNum)
            If HexEditorRstate.Checked = True Then
                Dim asciistr As String = ChrW(PixClr.R)
                If asciistr.Length < 1 Then
                    AddData1 = AddData1 & ". "
                Else
                    AddData1 = AddData1 & asciistr & " "
                End If
                Dim hexstr As String = Hex(PixClr.R)
                If hexstr.Length < 2 Then
                    AddData2 = AddData2 & "0" & hexstr & " "
                Else
                    AddData2 = AddData2 & hexstr & " "
                End If
            End If
            If HexEditorGstate.Checked = True Then
                Dim asciistr As String = ChrW(PixClr.G)
                If asciistr.Length < 1 Then
                    AddData1 = AddData1 & ". "
                Else
                    AddData1 = AddData1 & asciistr & " "
                End If
                Dim hexstr As String = Hex(PixClr.G)
                If hexstr.Length < 2 Then
                    AddData2 = AddData2 & "0" & hexstr & " "
                Else
                    AddData2 = AddData2 & hexstr & " "
                End If
            End If
            If HexEditorBstate.Checked = True Then
                Dim asciistr As String = ChrW(PixClr.B)
                If asciistr.Length < 1 Then
                    AddData1 = AddData1 & ". "
                Else
                    AddData1 = AddData1 & asciistr & " "
                End If
                Dim hexstr As String = Hex(PixClr.B)
                If hexstr.Length < 2 Then
                    AddData2 = AddData2 & "0" & hexstr & " "
                Else
                    AddData2 = AddData2 & hexstr & " "
                End If
            End If
        Next posx
        Application.DoEvents()
        HexEditorTextBoxASCII.Text = HexEditorTextBoxASCII.Text & AddData1
        HexEditorTextBoxHEX.Text = HexEditorTextBoxHEX.Text & AddData2
    End Sub

    Public Sub UpdateHexEditorPanelConstraints()
        HexEditorTrackBar.Maximum = image_data1.Height - 1
        HexEditorPageSelector.Maximum = image_data1.Height - 1
    End Sub

    Private Sub HexEditorLoadButton_Click(sender As Object, e As EventArgs) Handles HexEditorLoadButton.Click
        LoadImageData(HexEditorPageSelector.Value)
    End Sub

    Private Sub HexEditorPageSelector_ValueChanged(sender As Object, e As EventArgs) Handles HexEditorPageSelector.ValueChanged
        HexEditorTrackBar.Value = HexEditorPageSelector.Value
    End Sub

    Private Sub HexEditorTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles HexEditorTrackBar.ValueChanged
        HexEditorPageSelector.Value = HexEditorTrackBar.Value
    End Sub

    Private Sub HexEditorPanelHideButton_Click(sender As Object, e As EventArgs) Handles HexEditorPanelHideButton.Click
        HexEditorPanel.Visible = False
        HexEditorPanel.Enabled = False
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const WS_EX_COMPOSITED As Integer = 33554432
            Dim cp = MyBase.CreateParams
            cp.ExStyle = (cp.ExStyle Or WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property

    Private Sub LoadImageButton_Click(sender As Object, e As EventArgs) Handles LoadImageButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using fs As New System.IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open)
                    BackgroundRenderBoxMain.Image = New Bitmap(Image.FromStream(fs))
                End Using
                If HexEditorOpen = True Then
                    If BackgroundRenderBoxMain.Image IsNot Nothing Then
                        image_data1 = BackgroundRenderBoxMain.Image
                        UpdateHexEditorPanelConstraints()
                        LoadImageData(0)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading the file:" & Environment.NewLine & OpenFileDialog1.FileName & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString & Environment.NewLine & ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        SelectedFilterIndex = ComboBox4.SelectedIndex
        ComboBox1.SelectedIndex = SelectedFilterIndex
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SelectedFilterIndex = ComboBox4.SelectedIndex
        ComboBox4.SelectedIndex = SelectedFilterIndex
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        OrigAlpha = 1 - (ComboBox2.SelectedIndex * 0.25)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        OrigAlpha = 1 - (ComboBox3.SelectedIndex * 0.25)
    End Sub

    Private Sub Rstate2_CheckedChanged(sender As Object, e As EventArgs) Handles Rstate2.CheckedChanged
        Rchan = Rstate2.CheckState
        Rstate.CheckState = Rstate2.CheckState
    End Sub

    Private Sub Gstate2_CheckedChanged(sender As Object, e As EventArgs) Handles Gstate2.CheckedChanged
        Gchan = Gstate2.CheckState
        Gstate.CheckState = Gstate2.CheckState
    End Sub

    Private Sub Bstate2_CheckedChanged(sender As Object, e As EventArgs) Handles Bstate2.CheckedChanged
        Bchan = Bstate2.CheckState
        Bstate.CheckState = Bstate2.CheckState
    End Sub

    Private Sub Rstate_CheckedChanged(sender As Object, e As EventArgs) Handles Rstate.CheckedChanged
        Rchan = Rstate.CheckState
        Rstate2.CheckState = Rstate.CheckState
    End Sub

    Private Sub Gstate_CheckedChanged(sender As Object, e As EventArgs) Handles Gstate.CheckedChanged
        Gchan = Gstate2.CheckState
        Gstate2.CheckState = Gstate.CheckState
    End Sub

    Private Sub Bstate_CheckedChanged(sender As Object, e As EventArgs) Handles Bstate.CheckedChanged
        Bchan = Bstate2.CheckState
        Bstate2.CheckState = Bstate.CheckState
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        HexEditorOpen = False
        ToolPanel.Top = HexEditorPanel.Top
        ToolPanel.Left = HexEditorPanel.Left
        HexEditorPanel.Visible = False
        HexEditorPanel.Enabled = False
        ToolPanel.Visible = True
        ToolPanel.Enabled = True
    End Sub
End Class
