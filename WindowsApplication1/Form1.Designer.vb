<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BWStegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorStegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolPanel = New System.Windows.Forms.Panel()
        Me.OverlayEnabledCheck = New System.Windows.Forms.CheckBox()
        Me.LiveFilteringCheck = New System.Windows.Forms.CheckBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Bstate = New System.Windows.Forms.CheckBox()
        Me.Gstate = New System.Windows.Forms.CheckBox()
        Me.Rstate = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolPanelTitleBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.HexEditorPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HexEditorTextBoxHEX = New System.Windows.Forms.TextBox()
        Me.HexEditorTextBoxASCII = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.HexEditorGstate = New System.Windows.Forms.CheckBox()
        Me.HexEditorBstate = New System.Windows.Forms.CheckBox()
        Me.HexEditorRstate = New System.Windows.Forms.CheckBox()
        Me.HexEditorLoadButton = New System.Windows.Forms.Button()
        Me.HexEditorPageSelector = New System.Windows.Forms.NumericUpDown()
        Me.HexEditorTrackBar = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MouseCoordsLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Rstate2 = New System.Windows.Forms.CheckBox()
        Me.Gstate2 = New System.Windows.Forms.CheckBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Bstate2 = New System.Windows.Forms.CheckBox()
        Me.HexEditorPanelTitleBar = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HexEditorPanelHideButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadImageButton = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackgroundRenderBoxMain = New System.Windows.Forms.PictureBox()
        Me.BackgroundRenderBoxBackBuffer = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolPanel.SuspendLayout()
        Me.ToolPanelTitleBar.SuspendLayout()
        Me.HexEditorPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.HexEditorPageSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HexEditorTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.HexEditorPanelTitleBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackgroundRenderBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackgroundRenderBoxBackBuffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.TransparencyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 48)
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BWStegToolStripMenuItem, Me.ColorStegToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'BWStegToolStripMenuItem
        '
        Me.BWStegToolStripMenuItem.Name = "BWStegToolStripMenuItem"
        Me.BWStegToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BWStegToolStripMenuItem.Text = "B+W Steg"
        '
        'ColorStegToolStripMenuItem
        '
        Me.ColorStegToolStripMenuItem.Name = "ColorStegToolStripMenuItem"
        Me.ColorStegToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ColorStegToolStripMenuItem.Text = "16 Color Steg"
        '
        'TransparencyToolStripMenuItem
        '
        Me.TransparencyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.TransparencyToolStripMenuItem.Name = "TransparencyToolStripMenuItem"
        Me.TransparencyToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TransparencyToolStripMenuItem.Text = "Transparency"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem2.Text = "25%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem3.Text = "50%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem4.Text = "75%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem5.Text = "100%"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "png"
        '
        'ToolPanel
        '
        Me.ToolPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ToolPanel.Controls.Add(Me.OverlayEnabledCheck)
        Me.ToolPanel.Controls.Add(Me.LiveFilteringCheck)
        Me.ToolPanel.Controls.Add(Me.Button7)
        Me.ToolPanel.Controls.Add(Me.ProgressBar1)
        Me.ToolPanel.Controls.Add(Me.ComboBox2)
        Me.ToolPanel.Controls.Add(Me.Button5)
        Me.ToolPanel.Controls.Add(Me.Bstate)
        Me.ToolPanel.Controls.Add(Me.Gstate)
        Me.ToolPanel.Controls.Add(Me.Rstate)
        Me.ToolPanel.Controls.Add(Me.Button3)
        Me.ToolPanel.Controls.Add(Me.ComboBox1)
        Me.ToolPanel.Controls.Add(Me.Button2)
        Me.ToolPanel.Controls.Add(Me.Button1)
        Me.ToolPanel.Controls.Add(Me.ToolPanelTitleBar)
        Me.ToolPanel.Location = New System.Drawing.Point(209, 168)
        Me.ToolPanel.Name = "ToolPanel"
        Me.ToolPanel.Size = New System.Drawing.Size(194, 164)
        Me.ToolPanel.TabIndex = 3
        '
        'OverlayEnabledCheck
        '
        Me.OverlayEnabledCheck.AutoSize = True
        Me.OverlayEnabledCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.OverlayEnabledCheck.Checked = True
        Me.OverlayEnabledCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OverlayEnabledCheck.FlatAppearance.BorderSize = 0
        Me.OverlayEnabledCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OverlayEnabledCheck.ForeColor = System.Drawing.Color.Silver
        Me.OverlayEnabledCheck.Location = New System.Drawing.Point(131, 51)
        Me.OverlayEnabledCheck.Name = "OverlayEnabledCheck"
        Me.OverlayEnabledCheck.Size = New System.Drawing.Size(59, 17)
        Me.OverlayEnabledCheck.TabIndex = 15
        Me.OverlayEnabledCheck.Text = "Overlay"
        Me.OverlayEnabledCheck.UseVisualStyleBackColor = False
        '
        'LiveFilteringCheck
        '
        Me.LiveFilteringCheck.AutoSize = True
        Me.LiveFilteringCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LiveFilteringCheck.FlatAppearance.BorderSize = 0
        Me.LiveFilteringCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiveFilteringCheck.ForeColor = System.Drawing.Color.Silver
        Me.LiveFilteringCheck.Location = New System.Drawing.Point(131, 28)
        Me.LiveFilteringCheck.Name = "LiveFilteringCheck"
        Me.LiveFilteringCheck.Size = New System.Drawing.Size(53, 17)
        Me.LiveFilteringCheck.TabIndex = 14
        Me.LiveFilteringCheck.Text = "Active"
        Me.LiveFilteringCheck.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Gray
        Me.Button7.Location = New System.Drawing.Point(146, 116)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 45)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "HEX"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(55, 99)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(136, 11)
        Me.ProgressBar1.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"100%", "75%", "50%", "25%"})
        Me.ComboBox2.Location = New System.Drawing.Point(55, 129)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.Text = "100%"
        '
        'Bstate
        '
        Me.Bstate.AutoSize = True
        Me.Bstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Bstate.Checked = True
        Me.Bstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Bstate.FlatAppearance.BorderSize = 0
        Me.Bstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bstate.ForeColor = System.Drawing.Color.Silver
        Me.Bstate.Location = New System.Drawing.Point(99, 56)
        Me.Bstate.Name = "Bstate"
        Me.Bstate.Size = New System.Drawing.Size(30, 17)
        Me.Bstate.TabIndex = 7
        Me.Bstate.Text = "B"
        Me.Bstate.UseVisualStyleBackColor = False
        '
        'Gstate
        '
        Me.Gstate.AutoSize = True
        Me.Gstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Gstate.Checked = True
        Me.Gstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Gstate.FlatAppearance.BorderSize = 0
        Me.Gstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gstate.ForeColor = System.Drawing.Color.Silver
        Me.Gstate.Location = New System.Drawing.Point(99, 42)
        Me.Gstate.Name = "Gstate"
        Me.Gstate.Size = New System.Drawing.Size(31, 17)
        Me.Gstate.TabIndex = 6
        Me.Gstate.Text = "G"
        Me.Gstate.UseVisualStyleBackColor = False
        '
        'Rstate
        '
        Me.Rstate.AutoSize = True
        Me.Rstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Rstate.Checked = True
        Me.Rstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Rstate.FlatAppearance.BorderSize = 0
        Me.Rstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rstate.ForeColor = System.Drawing.Color.Silver
        Me.Rstate.Location = New System.Drawing.Point(99, 28)
        Me.Rstate.Name = "Rstate"
        Me.Rstate.Size = New System.Drawing.Size(31, 17)
        Me.Rstate.TabIndex = 5
        Me.Rstate.Text = "R"
        Me.Rstate.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"LSB 1-Bit (Greyscale)", "LSB 3-Bit (16-Bit Color)", "Invert Colors", "Extract Selected Channels"})
        Me.ComboBox1.Location = New System.Drawing.Point(55, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Select Filter..."
        '
        'ToolPanelTitleBar
        '
        Me.ToolPanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolPanelTitleBar.Controls.Add(Me.PictureBox1)
        Me.ToolPanelTitleBar.Controls.Add(Me.Label1)
        Me.ToolPanelTitleBar.Controls.Add(Me.Button4)
        Me.ToolPanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolPanelTitleBar.Name = "ToolPanelTitleBar"
        Me.ToolPanelTitleBar.Size = New System.Drawing.Size(194, 25)
        Me.ToolPanelTitleBar.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(29, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ActiveSteg v2.23"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(161, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(33, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'HexEditorPanel
        '
        Me.HexEditorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorPanel.Controls.Add(Me.Panel2)
        Me.HexEditorPanel.Controls.Add(Me.Panel1)
        Me.HexEditorPanel.Controls.Add(Me.HexEditorPanelTitleBar)
        Me.HexEditorPanel.Enabled = False
        Me.HexEditorPanel.Location = New System.Drawing.Point(702, 91)
        Me.HexEditorPanel.Name = "HexEditorPanel"
        Me.HexEditorPanel.Size = New System.Drawing.Size(854, 596)
        Me.HexEditorPanel.TabIndex = 5
        Me.HexEditorPanel.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.HexEditorTextBoxHEX)
        Me.Panel2.Controls.Add(Me.HexEditorTextBoxASCII)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(854, 442)
        Me.Panel2.TabIndex = 38
        '
        'HexEditorTextBoxHEX
        '
        Me.HexEditorTextBoxHEX.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorTextBoxHEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HexEditorTextBoxHEX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HexEditorTextBoxHEX.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexEditorTextBoxHEX.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorTextBoxHEX.Location = New System.Drawing.Point(442, 0)
        Me.HexEditorTextBoxHEX.Multiline = True
        Me.HexEditorTextBoxHEX.Name = "HexEditorTextBoxHEX"
        Me.HexEditorTextBoxHEX.ReadOnly = True
        Me.HexEditorTextBoxHEX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HexEditorTextBoxHEX.Size = New System.Drawing.Size(412, 442)
        Me.HexEditorTextBoxHEX.TabIndex = 20
        Me.HexEditorTextBoxHEX.Text = resources.GetString("HexEditorTextBoxHEX.Text")
        '
        'HexEditorTextBoxASCII
        '
        Me.HexEditorTextBoxASCII.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorTextBoxASCII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HexEditorTextBoxASCII.Dock = System.Windows.Forms.DockStyle.Left
        Me.HexEditorTextBoxASCII.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexEditorTextBoxASCII.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorTextBoxASCII.Location = New System.Drawing.Point(0, 0)
        Me.HexEditorTextBoxASCII.Multiline = True
        Me.HexEditorTextBoxASCII.Name = "HexEditorTextBoxASCII"
        Me.HexEditorTextBoxASCII.ReadOnly = True
        Me.HexEditorTextBoxASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HexEditorTextBoxASCII.Size = New System.Drawing.Size(442, 442)
        Me.HexEditorTextBoxASCII.TabIndex = 19
        Me.HexEditorTextBoxASCII.Text = resources.GetString("HexEditorTextBoxASCII.Text")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LoadImageButton)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 129)
        Me.Panel1.TabIndex = 37
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.HexEditorLoadButton)
        Me.GroupBox4.Controls.Add(Me.HexEditorPageSelector)
        Me.GroupBox4.Controls.Add(Me.HexEditorTrackBar)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox4.Location = New System.Drawing.Point(381, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 125)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hex Editor Options:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.HexEditorGstate)
        Me.GroupBox5.Controls.Add(Me.HexEditorBstate)
        Me.GroupBox5.Controls.Add(Me.HexEditorRstate)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(68, 87)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Channels:"
        '
        'HexEditorGstate
        '
        Me.HexEditorGstate.AutoSize = True
        Me.HexEditorGstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorGstate.Checked = True
        Me.HexEditorGstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HexEditorGstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexEditorGstate.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorGstate.Location = New System.Drawing.Point(6, 39)
        Me.HexEditorGstate.Name = "HexEditorGstate"
        Me.HexEditorGstate.Size = New System.Drawing.Size(52, 17)
        Me.HexEditorGstate.TabIndex = 17
        Me.HexEditorGstate.Text = "Green"
        Me.HexEditorGstate.UseVisualStyleBackColor = False
        '
        'HexEditorBstate
        '
        Me.HexEditorBstate.AutoSize = True
        Me.HexEditorBstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorBstate.Checked = True
        Me.HexEditorBstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HexEditorBstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexEditorBstate.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorBstate.Location = New System.Drawing.Point(6, 62)
        Me.HexEditorBstate.Name = "HexEditorBstate"
        Me.HexEditorBstate.Size = New System.Drawing.Size(44, 17)
        Me.HexEditorBstate.TabIndex = 18
        Me.HexEditorBstate.Text = "Blue"
        Me.HexEditorBstate.UseVisualStyleBackColor = False
        '
        'HexEditorRstate
        '
        Me.HexEditorRstate.AutoSize = True
        Me.HexEditorRstate.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.HexEditorRstate.Checked = True
        Me.HexEditorRstate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HexEditorRstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexEditorRstate.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorRstate.Location = New System.Drawing.Point(6, 16)
        Me.HexEditorRstate.Name = "HexEditorRstate"
        Me.HexEditorRstate.Size = New System.Drawing.Size(43, 17)
        Me.HexEditorRstate.TabIndex = 16
        Me.HexEditorRstate.Text = "Red"
        Me.HexEditorRstate.UseVisualStyleBackColor = False
        '
        'HexEditorLoadButton
        '
        Me.HexEditorLoadButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HexEditorLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexEditorLoadButton.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorLoadButton.Location = New System.Drawing.Point(148, 11)
        Me.HexEditorLoadButton.Name = "HexEditorLoadButton"
        Me.HexEditorLoadButton.Size = New System.Drawing.Size(75, 108)
        Me.HexEditorLoadButton.TabIndex = 15
        Me.HexEditorLoadButton.Text = "Load"
        Me.HexEditorLoadButton.UseVisualStyleBackColor = False
        '
        'HexEditorPageSelector
        '
        Me.HexEditorPageSelector.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.HexEditorPageSelector.ForeColor = System.Drawing.Color.Silver
        Me.HexEditorPageSelector.Location = New System.Drawing.Point(80, 14)
        Me.HexEditorPageSelector.Name = "HexEditorPageSelector"
        Me.HexEditorPageSelector.Size = New System.Drawing.Size(62, 20)
        Me.HexEditorPageSelector.TabIndex = 21
        '
        'HexEditorTrackBar
        '
        Me.HexEditorTrackBar.LargeChange = 50
        Me.HexEditorTrackBar.Location = New System.Drawing.Point(91, 37)
        Me.HexEditorTrackBar.Maximum = 100
        Me.HexEditorTrackBar.Name = "HexEditorTrackBar"
        Me.HexEditorTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.HexEditorTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HexEditorTrackBar.Size = New System.Drawing.Size(45, 85)
        Me.HexEditorTrackBar.TabIndex = 8
        Me.HexEditorTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.HexEditorTrackBar.Value = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox5)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox3.Location = New System.Drawing.Point(238, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 125)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Overlay Controls:"
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox5.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"3sec", "2sec", "1sec", "0.5s", "0.25s", "0.1s", "0.05s"})
        Me.ComboBox5.Location = New System.Drawing.Point(74, 95)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox5.TabIndex = 34
        Me.ComboBox5.Text = "3sec"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"100%", "75%", "50%", "25%"})
        Me.ComboBox3.Location = New System.Drawing.Point(57, 27)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(52, 21)
        Me.ComboBox3.TabIndex = 30
        Me.ComboBox3.Text = "100%"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.CheckBox2.Location = New System.Drawing.Point(15, 96)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "Active"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.CheckBox1.Location = New System.Drawing.Point(15, 73)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Overlay"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MouseCoordsLabel)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(671, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 36)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mouse Coords (X,Y):"
        Me.GroupBox1.Visible = False
        '
        'MouseCoordsLabel
        '
        Me.MouseCoordsLabel.AutoSize = True
        Me.MouseCoordsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MouseCoordsLabel.Location = New System.Drawing.Point(3, 16)
        Me.MouseCoordsLabel.Name = "MouseCoordsLabel"
        Me.MouseCoordsLabel.Size = New System.Drawing.Size(49, 13)
        Me.MouseCoordsLabel.TabIndex = 0
        Me.MouseCoordsLabel.Text = "500, 500"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Rstate2)
        Me.GroupBox2.Controls.Add(Me.Gstate2)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Bstate2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(0, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 62)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtering Options:"
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox4.ForeColor = System.Drawing.Color.Silver
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"LSB 1-Bit (Greyscale)", "LSB 3-Bit (16-Bit Color)", "Invert Colors", "Extract Selected Channels"})
        Me.ComboBox4.Location = New System.Drawing.Point(54, 19)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox4.TabIndex = 24
        Me.ComboBox4.Text = "Select Filter..."
        '
        'Rstate2
        '
        Me.Rstate2.AutoSize = True
        Me.Rstate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Rstate2.Checked = True
        Me.Rstate2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Rstate2.FlatAppearance.BorderSize = 0
        Me.Rstate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rstate2.ForeColor = System.Drawing.Color.Silver
        Me.Rstate2.Location = New System.Drawing.Point(196, 12)
        Me.Rstate2.Name = "Rstate2"
        Me.Rstate2.Size = New System.Drawing.Size(31, 17)
        Me.Rstate2.TabIndex = 26
        Me.Rstate2.Text = "R"
        Me.Rstate2.UseVisualStyleBackColor = False
        '
        'Gstate2
        '
        Me.Gstate2.AutoSize = True
        Me.Gstate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Gstate2.Checked = True
        Me.Gstate2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Gstate2.FlatAppearance.BorderSize = 0
        Me.Gstate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gstate2.ForeColor = System.Drawing.Color.Silver
        Me.Gstate2.Location = New System.Drawing.Point(196, 26)
        Me.Gstate2.Name = "Gstate2"
        Me.Gstate2.Size = New System.Drawing.Size(31, 17)
        Me.Gstate2.TabIndex = 27
        Me.Gstate2.Text = "G"
        Me.Gstate2.UseVisualStyleBackColor = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(54, 39)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(136, 11)
        Me.ProgressBar2.TabIndex = 31
        '
        'Bstate2
        '
        Me.Bstate2.AutoSize = True
        Me.Bstate2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Bstate2.Checked = True
        Me.Bstate2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Bstate2.FlatAppearance.BorderSize = 0
        Me.Bstate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bstate2.ForeColor = System.Drawing.Color.Silver
        Me.Bstate2.Location = New System.Drawing.Point(196, 40)
        Me.Bstate2.Name = "Bstate2"
        Me.Bstate2.Size = New System.Drawing.Size(30, 17)
        Me.Bstate2.TabIndex = 28
        Me.Bstate2.Text = "B"
        Me.Bstate2.UseVisualStyleBackColor = False
        '
        'HexEditorPanelTitleBar
        '
        Me.HexEditorPanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HexEditorPanelTitleBar.Controls.Add(Me.Button8)
        Me.HexEditorPanelTitleBar.Controls.Add(Me.PictureBox2)
        Me.HexEditorPanelTitleBar.Controls.Add(Me.Label2)
        Me.HexEditorPanelTitleBar.Controls.Add(Me.HexEditorPanelHideButton)
        Me.HexEditorPanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.HexEditorPanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.HexEditorPanelTitleBar.Name = "HexEditorPanelTitleBar"
        Me.HexEditorPanelTitleBar.Size = New System.Drawing.Size(854, 25)
        Me.HexEditorPanelTitleBar.TabIndex = 14
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(789, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(30, 25)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "_"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(29, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ActiveSteg v2.23 - ASCII / HEX Viewer"
        '
        'HexEditorPanelHideButton
        '
        Me.HexEditorPanelHideButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HexEditorPanelHideButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HexEditorPanelHideButton.FlatAppearance.BorderSize = 0
        Me.HexEditorPanelHideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HexEditorPanelHideButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HexEditorPanelHideButton.ForeColor = System.Drawing.Color.White
        Me.HexEditorPanelHideButton.Location = New System.Drawing.Point(819, 0)
        Me.HexEditorPanelHideButton.Name = "HexEditorPanelHideButton"
        Me.HexEditorPanelHideButton.Size = New System.Drawing.Size(35, 25)
        Me.HexEditorPanelHideButton.TabIndex = 4
        Me.HexEditorPanelHideButton.Text = "X"
        Me.HexEditorPanelHideButton.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Gray
        Me.Button5.Image = Global.ActiveSteg.My.Resources.Resources.alpha
        Me.Button5.Location = New System.Drawing.Point(4, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 45)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Gray
        Me.Button3.Image = Global.ActiveSteg.My.Resources.Resources.gear
        Me.Button3.Location = New System.Drawing.Point(4, 72)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.Image = Global.ActiveSteg.My.Resources.Resources.save
        Me.Button2.Location = New System.Drawing.Point(48, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Image = Global.ActiveSteg.My.Resources.Resources.camera
        Me.Button1.Location = New System.Drawing.Point(4, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.ActiveSteg.My.Resources.Resources.StegTool
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 25)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadImageButton
        '
        Me.LoadImageButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoadImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoadImageButton.FlatAppearance.BorderSize = 0
        Me.LoadImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadImageButton.ForeColor = System.Drawing.Color.Gray
        Me.LoadImageButton.Image = Global.ActiveSteg.My.Resources.Resources.open
        Me.LoadImageButton.Location = New System.Drawing.Point(96, 9)
        Me.LoadImageButton.Name = "LoadImageButton"
        Me.LoadImageButton.Size = New System.Drawing.Size(45, 45)
        Me.LoadImageButton.TabIndex = 37
        Me.LoadImageButton.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.Gray
        Me.Button12.Image = Global.ActiveSteg.My.Resources.Resources.camera
        Me.Button12.Location = New System.Drawing.Point(32, 9)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(45, 45)
        Me.Button12.TabIndex = 22
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.Color.Gray
        Me.Button11.Image = Global.ActiveSteg.My.Resources.Resources.save
        Me.Button11.Location = New System.Drawing.Point(162, 9)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(45, 45)
        Me.Button11.TabIndex = 23
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.Color.Gray
        Me.Button9.Image = Global.ActiveSteg.My.Resources.Resources.alpha
        Me.Button9.Location = New System.Drawing.Point(6, 14)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(45, 45)
        Me.Button9.TabIndex = 29
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.Gray
        Me.Button10.Image = Global.ActiveSteg.My.Resources.Resources.gear
        Me.Button10.Location = New System.Drawing.Point(3, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(45, 45)
        Me.Button10.TabIndex = 25
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.ActiveSteg.My.Resources.Resources.StegTool
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 25)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'BackgroundRenderBoxMain
        '
        Me.BackgroundRenderBoxMain.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundRenderBoxMain.Name = "BackgroundRenderBoxMain"
        Me.BackgroundRenderBoxMain.Size = New System.Drawing.Size(2560, 1400)
        Me.BackgroundRenderBoxMain.TabIndex = 0
        Me.BackgroundRenderBoxMain.TabStop = False
        '
        'BackgroundRenderBoxBackBuffer
        '
        Me.BackgroundRenderBoxBackBuffer.Location = New System.Drawing.Point(0, 0)
        Me.BackgroundRenderBoxBackBuffer.Name = "BackgroundRenderBoxBackBuffer"
        Me.BackgroundRenderBoxBackBuffer.Size = New System.Drawing.Size(2560, 1400)
        Me.BackgroundRenderBoxBackBuffer.TabIndex = 4
        Me.BackgroundRenderBoxBackBuffer.TabStop = False
        Me.BackgroundRenderBoxBackBuffer.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(2560, 1400)
        Me.Controls.Add(Me.ToolPanel)
        Me.Controls.Add(Me.HexEditorPanel)
        Me.Controls.Add(Me.BackgroundRenderBoxMain)
        Me.Controls.Add(Me.BackgroundRenderBoxBackBuffer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ActiveSteg v2.23"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolPanel.ResumeLayout(False)
        Me.ToolPanel.PerformLayout()
        Me.ToolPanelTitleBar.ResumeLayout(False)
        Me.ToolPanelTitleBar.PerformLayout()
        Me.HexEditorPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.HexEditorPageSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HexEditorTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.HexEditorPanelTitleBar.ResumeLayout(False)
        Me.HexEditorPanelTitleBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackgroundRenderBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackgroundRenderBoxBackBuffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundRenderBoxMain As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ColorStegToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BWStegToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolPanel As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Bstate As CheckBox
    Friend WithEvents Gstate As CheckBox
    Friend WithEvents Rstate As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button7 As Button
    Friend WithEvents ToolPanelTitleBar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LiveFilteringCheck As CheckBox
    Friend WithEvents BackgroundRenderBoxBackBuffer As PictureBox
    Friend WithEvents OverlayEnabledCheck As CheckBox
    Friend WithEvents HexEditorPanel As Panel
    Friend WithEvents HexEditorPanelTitleBar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents HexEditorPanelHideButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HexEditorTrackBar As TrackBar
    Friend WithEvents HexEditorLoadButton As Button
    Friend WithEvents HexEditorBstate As CheckBox
    Friend WithEvents HexEditorGstate As CheckBox
    Friend WithEvents HexEditorRstate As CheckBox
    Friend WithEvents HexEditorPageSelector As NumericUpDown
    Friend WithEvents HexEditorTextBoxHEX As TextBox
    Friend WithEvents HexEditorTextBoxASCII As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Rstate2 As CheckBox
    Friend WithEvents Gstate2 As CheckBox
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Bstate2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MouseCoordsLabel As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LoadImageButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
