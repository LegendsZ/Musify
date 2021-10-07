<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMusify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMusify))
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDots = New System.Windows.Forms.Label()
        Me.cmsDots = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMusify = New System.Windows.Forms.Label()
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblMusifyMenu = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.tmrError = New System.Windows.Forms.Timer(Me.components)
        Me.lblMainMusify = New System.Windows.Forms.Label()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.lblSearchit = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lsvData = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlMusic = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picHomePlay = New System.Windows.Forms.PictureBox()
        Me.hVolume = New System.Windows.Forms.HScrollBar()
        Me.pnlSaved = New System.Windows.Forms.Panel()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picImport = New System.Windows.Forms.PictureBox()
        Me.lblImport = New System.Windows.Forms.Label()
        Me.lblAddSong = New System.Windows.Forms.Label()
        Me.lsvSaved = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsDeleteAdd = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnSetBack = New System.Windows.Forms.Button()
        Me.lblSettingsDis = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblVolVal = New System.Windows.Forms.Label()
        Me.MusicPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.picPausePlay = New System.Windows.Forms.PictureBox()
        Me.picMainBack = New System.Windows.Forms.PictureBox()
        Me.lblNowPlaying = New System.Windows.Forms.Label()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.chkDarkMode = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.pnlControl.SuspendLayout()
        Me.cmsDots.SuspendLayout()
        Me.pnlSide.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMusic.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHomePlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSaved.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDeleteAdd.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        CType(Me.MusicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPausePlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.Black
        Me.pnlControl.Controls.Add(Me.lblOutput)
        Me.pnlControl.Controls.Add(Me.btnMin)
        Me.pnlControl.Controls.Add(Me.btnMax)
        Me.pnlControl.Controls.Add(Me.btnClose)
        Me.pnlControl.Controls.Add(Me.lblDots)
        Me.pnlControl.Controls.Add(Me.lblMusify)
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(801, 57)
        Me.pnlControl.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(332, 17)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(51, 23)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "ABC"
        Me.lblOutput.Visible = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.White
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.Location = New System.Drawing.Point(661, 9)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(40, 37)
        Me.btnMin.TabIndex = 4
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.White
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.Location = New System.Drawing.Point(707, 9)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(40, 37)
        Me.btnMax.TabIndex = 3
        Me.btnMax.Text = "+"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(753, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblDots
        '
        Me.lblDots.AutoSize = True
        Me.lblDots.ContextMenuStrip = Me.cmsDots
        Me.lblDots.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDots.ForeColor = System.Drawing.Color.White
        Me.lblDots.Location = New System.Drawing.Point(12, 1)
        Me.lblDots.Name = "lblDots"
        Me.lblDots.Size = New System.Drawing.Size(57, 37)
        Me.lblDots.TabIndex = 1
        Me.lblDots.Text = ". . ."
        '
        'cmsDots
        '
        Me.cmsDots.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsDots.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayToolStripMenuItem, Me.RecentsToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.cmsDots.Name = "cmsDots"
        Me.cmsDots.Size = New System.Drawing.Size(143, 108)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'RecentsToolStripMenuItem
        '
        Me.RecentsToolStripMenuItem.Name = "RecentsToolStripMenuItem"
        Me.RecentsToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.RecentsToolStripMenuItem.Text = "Recents"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'lblMusify
        '
        Me.lblMusify.AutoSize = True
        Me.lblMusify.Font = New System.Drawing.Font("Times New Roman", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMusify.ForeColor = System.Drawing.Color.White
        Me.lblMusify.Location = New System.Drawing.Point(83, 9)
        Me.lblMusify.Name = "lblMusify"
        Me.lblMusify.Size = New System.Drawing.Size(116, 37)
        Me.lblMusify.TabIndex = 0
        Me.lblMusify.Text = "Musify"
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.Black
        Me.pnlSide.Controls.Add(Me.lblSettings)
        Me.pnlSide.Controls.Add(Me.lblCredits)
        Me.pnlSide.Controls.Add(Me.lblMusifyMenu)
        Me.pnlSide.Controls.Add(Me.lblAdd)
        Me.pnlSide.Controls.Add(Me.lblHome)
        Me.pnlSide.Controls.Add(Me.btnHide)
        Me.pnlSide.Location = New System.Drawing.Point(0, 63)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(200, 375)
        Me.pnlSide.TabIndex = 2
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(12, 239)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(100, 31)
        Me.lblSettings.TabIndex = 7
        Me.lblSettings.Text = "Settings"
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.ForeColor = System.Drawing.Color.White
        Me.lblCredits.Location = New System.Drawing.Point(14, 315)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(92, 31)
        Me.lblCredits.TabIndex = 6
        Me.lblCredits.Text = "Credits"
        '
        'lblMusifyMenu
        '
        Me.lblMusifyMenu.AutoSize = True
        Me.lblMusifyMenu.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMusifyMenu.ForeColor = System.Drawing.Color.White
        Me.lblMusifyMenu.Location = New System.Drawing.Point(43, 23)
        Me.lblMusifyMenu.Name = "lblMusifyMenu"
        Me.lblMusifyMenu.Size = New System.Drawing.Size(116, 37)
        Me.lblMusifyMenu.TabIndex = 5
        Me.lblMusifyMenu.Text = "Musify"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.White
        Me.lblAdd.Location = New System.Drawing.Point(13, 164)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(61, 31)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "Add"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(11, 93)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(79, 31)
        Me.lblHome.TabIndex = 2
        Me.lblHome.Text = "Home"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.White
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(148, 165)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(50, 50)
        Me.btnHide.TabIndex = 0
        Me.btnHide.Text = "<--"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'tmrError
        '
        Me.tmrError.Interval = 500
        '
        'lblMainMusify
        '
        Me.lblMainMusify.AutoSize = True
        Me.lblMainMusify.Font = New System.Drawing.Font("Times New Roman", 75.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMusify.ForeColor = System.Drawing.Color.Black
        Me.lblMainMusify.Location = New System.Drawing.Point(334, 60)
        Me.lblMainMusify.Name = "lblMainMusify"
        Me.lblMainMusify.Size = New System.Drawing.Size(349, 114)
        Me.lblMainMusify.TabIndex = 8
        Me.lblMainMusify.Text = "Musify"
        Me.lblMainMusify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.Color.White
        Me.pnlHome.Controls.Add(Me.lblSearchit)
        Me.pnlHome.Controls.Add(Me.txtSearch)
        Me.pnlHome.Controls.Add(Me.Panel1)
        Me.pnlHome.Controls.Add(Me.pnlMusic)
        Me.pnlHome.Location = New System.Drawing.Point(800, 63)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(587, 375)
        Me.pnlHome.TabIndex = 9
        '
        'lblSearchit
        '
        Me.lblSearchit.AutoSize = True
        Me.lblSearchit.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchit.ForeColor = System.Drawing.Color.Black
        Me.lblSearchit.Location = New System.Drawing.Point(0, 8)
        Me.lblSearchit.Name = "lblSearchit"
        Me.lblSearchit.Size = New System.Drawing.Size(124, 37)
        Me.lblSearchit.TabIndex = 11
        Me.lblSearchit.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Black
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(130, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(457, 45)
        Me.txtSearch.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lsvData)
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 247)
        Me.Panel1.TabIndex = 9
        '
        'lsvData
        '
        Me.lsvData.BackColor = System.Drawing.Color.White
        Me.lsvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName})
        Me.lsvData.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvData.ForeColor = System.Drawing.Color.Black
        Me.lsvData.HideSelection = False
        Me.lsvData.Location = New System.Drawing.Point(18, 15)
        Me.lsvData.Name = "lsvData"
        Me.lsvData.Size = New System.Drawing.Size(550, 216)
        Me.lsvData.TabIndex = 0
        Me.lsvData.UseCompatibleStateImageBehavior = False
        Me.lsvData.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Song Name"
        Me.chName.Width = 128
        '
        'pnlMusic
        '
        Me.pnlMusic.BackColor = System.Drawing.Color.Black
        Me.pnlMusic.Controls.Add(Me.PictureBox3)
        Me.pnlMusic.Controls.Add(Me.PictureBox1)
        Me.pnlMusic.Controls.Add(Me.picHomePlay)
        Me.pnlMusic.Controls.Add(Me.hVolume)
        Me.pnlMusic.Location = New System.Drawing.Point(0, 309)
        Me.pnlMusic.Name = "pnlMusic"
        Me.pnlMusic.Size = New System.Drawing.Size(587, 66)
        Me.pnlMusic.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(504, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(106, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 48)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picHomePlay
        '
        Me.picHomePlay.BackgroundImage = Global.Musify.My.Resources.Resources.darkconceptPlaybtn
        Me.picHomePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHomePlay.Location = New System.Drawing.Point(18, 9)
        Me.picHomePlay.Name = "picHomePlay"
        Me.picHomePlay.Size = New System.Drawing.Size(64, 48)
        Me.picHomePlay.TabIndex = 3
        Me.picHomePlay.TabStop = False
        '
        'hVolume
        '
        Me.hVolume.Location = New System.Drawing.Point(185, 21)
        Me.hVolume.Name = "hVolume"
        Me.hVolume.Size = New System.Drawing.Size(295, 20)
        Me.hVolume.TabIndex = 2
        '
        'pnlSaved
        '
        Me.pnlSaved.Controls.Add(Me.lblDelete)
        Me.pnlSaved.Controls.Add(Me.PictureBox2)
        Me.pnlSaved.Controls.Add(Me.picImport)
        Me.pnlSaved.Controls.Add(Me.lblImport)
        Me.pnlSaved.Controls.Add(Me.lblAddSong)
        Me.pnlSaved.Controls.Add(Me.lsvSaved)
        Me.pnlSaved.Location = New System.Drawing.Point(207, 443)
        Me.pnlSaved.Name = "pnlSaved"
        Me.pnlSaved.Size = New System.Drawing.Size(587, 375)
        Me.pnlSaved.TabIndex = 10
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.ForeColor = System.Drawing.Color.Black
        Me.lblDelete.Location = New System.Drawing.Point(317, 309)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(164, 37)
        Me.lblDelete.TabIndex = 13
        Me.lblDelete.Text = "Delete All:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(486, 294)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 73)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'picImport
        '
        Me.picImport.BackgroundImage = CType(resources.GetObject("picImport.BackgroundImage"), System.Drawing.Image)
        Me.picImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picImport.Location = New System.Drawing.Point(176, 294)
        Me.picImport.Name = "picImport"
        Me.picImport.Size = New System.Drawing.Size(78, 73)
        Me.picImport.TabIndex = 11
        Me.picImport.TabStop = False
        '
        'lblImport
        '
        Me.lblImport.AutoSize = True
        Me.lblImport.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImport.ForeColor = System.Drawing.Color.Black
        Me.lblImport.Location = New System.Drawing.Point(41, 307)
        Me.lblImport.Name = "lblImport"
        Me.lblImport.Size = New System.Drawing.Size(129, 37)
        Me.lblImport.TabIndex = 9
        Me.lblImport.Text = "Import:"
        '
        'lblAddSong
        '
        Me.lblAddSong.AutoSize = True
        Me.lblAddSong.Font = New System.Drawing.Font("Times New Roman", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddSong.ForeColor = System.Drawing.Color.Black
        Me.lblAddSong.Location = New System.Drawing.Point(194, 8)
        Me.lblAddSong.Name = "lblAddSong"
        Me.lblAddSong.Size = New System.Drawing.Size(167, 37)
        Me.lblAddSong.TabIndex = 7
        Me.lblAddSong.Text = "Add Songs"
        '
        'lsvSaved
        '
        Me.lsvSaved.BackColor = System.Drawing.Color.White
        Me.lsvSaved.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvSaved.ContextMenuStrip = Me.cmsDeleteAdd
        Me.lsvSaved.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvSaved.ForeColor = System.Drawing.Color.Black
        Me.lsvSaved.HideSelection = False
        Me.lsvSaved.Location = New System.Drawing.Point(20, 56)
        Me.lsvSaved.Name = "lsvSaved"
        Me.lsvSaved.Size = New System.Drawing.Size(550, 231)
        Me.lsvSaved.TabIndex = 1
        Me.lsvSaved.UseCompatibleStateImageBehavior = False
        Me.lsvSaved.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Song Name"
        Me.ColumnHeader1.Width = 128
        '
        'cmsDeleteAdd
        '
        Me.cmsDeleteAdd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.cmsDeleteAdd.Name = "cmsDeleteAdd"
        Me.cmsDeleteAdd.Size = New System.Drawing.Size(130, 30)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Mp3 Files|*.mp3|Mp4 Files|*.mp4|Wav Files|*.wav"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(207, 387)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(552, 17)
        Me.HScrollBar1.TabIndex = 13
        Me.HScrollBar1.Value = 50
        '
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.Black
        Me.pnlSettings.Controls.Add(Me.chkDarkMode)
        Me.pnlSettings.Controls.Add(Me.btnApply)
        Me.pnlSettings.Controls.Add(Me.btnSetBack)
        Me.pnlSettings.Controls.Add(Me.lblSettingsDis)
        Me.pnlSettings.Location = New System.Drawing.Point(309, -383)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(353, 370)
        Me.pnlSettings.TabIndex = 14
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.Black
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.Location = New System.Drawing.Point(211, 315)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(119, 39)
        Me.btnApply.TabIndex = 10
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnSetBack
        '
        Me.btnSetBack.BackColor = System.Drawing.Color.Black
        Me.btnSetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetBack.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetBack.ForeColor = System.Drawing.Color.White
        Me.btnSetBack.Location = New System.Drawing.Point(27, 315)
        Me.btnSetBack.Name = "btnSetBack"
        Me.btnSetBack.Size = New System.Drawing.Size(119, 39)
        Me.btnSetBack.TabIndex = 9
        Me.btnSetBack.Text = "Back"
        Me.btnSetBack.UseVisualStyleBackColor = False
        '
        'lblSettingsDis
        '
        Me.lblSettingsDis.AutoSize = True
        Me.lblSettingsDis.Font = New System.Drawing.Font("Times New Roman", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsDis.ForeColor = System.Drawing.Color.White
        Me.lblSettingsDis.Location = New System.Drawing.Point(117, 8)
        Me.lblSettingsDis.Name = "lblSettingsDis"
        Me.lblSettingsDis.Size = New System.Drawing.Size(129, 37)
        Me.lblSettingsDis.TabIndex = 8
        Me.lblSettingsDis.Text = "Settings"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(457, 355)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(98, 31)
        Me.lblVolume.TabIndex = 15
        Me.lblVolume.Text = "Volume"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(471, 302)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(68, 31)
        Me.lblTime.TabIndex = 16
        Me.lblTime.Text = "Time"
        '
        'lblVolVal
        '
        Me.lblVolVal.AutoSize = True
        Me.lblVolVal.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolVal.Location = New System.Drawing.Point(477, 413)
        Me.lblVolVal.Name = "lblVolVal"
        Me.lblVolVal.Size = New System.Drawing.Size(50, 22)
        Me.lblVolVal.TabIndex = 17
        Me.lblVolVal.Text = "ABC"
        '
        'MusicPlayer
        '
        Me.MusicPlayer.Enabled = True
        Me.MusicPlayer.Location = New System.Drawing.Point(207, 336)
        Me.MusicPlayer.Name = "MusicPlayer"
        Me.MusicPlayer.OcxState = CType(resources.GetObject("MusicPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MusicPlayer.Size = New System.Drawing.Size(552, 45)
        Me.MusicPlayer.TabIndex = 11
        '
        'picPausePlay
        '
        Me.picPausePlay.BackgroundImage = Global.Musify.My.Resources.Resources.darkconceptPlaybtn
        Me.picPausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPausePlay.Location = New System.Drawing.Point(453, 224)
        Me.picPausePlay.Name = "picPausePlay"
        Me.picPausePlay.Size = New System.Drawing.Size(102, 72)
        Me.picPausePlay.TabIndex = 18
        Me.picPausePlay.TabStop = False
        '
        'picMainBack
        '
        Me.picMainBack.Location = New System.Drawing.Point(206, 348)
        Me.picMainBack.Name = "picMainBack"
        Me.picMainBack.Size = New System.Drawing.Size(588, 69)
        Me.picMainBack.TabIndex = 12
        Me.picMainBack.TabStop = False
        '
        'lblNowPlaying
        '
        Me.lblNowPlaying.AutoSize = True
        Me.lblNowPlaying.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNowPlaying.Location = New System.Drawing.Point(234, 183)
        Me.lblNowPlaying.Name = "lblNowPlaying"
        Me.lblNowPlaying.Size = New System.Drawing.Size(199, 31)
        Me.lblNowPlaying.TabIndex = 19
        Me.lblNowPlaying.Text = "Now Playing: ..."
        Me.lblNowPlaying.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeName
        '
        Me.btnChangeName.BackColor = System.Drawing.Color.White
        Me.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeName.Location = New System.Drawing.Point(647, 188)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(124, 31)
        Me.btnChangeName.TabIndex = 20
        Me.btnChangeName.Text = "Change Name"
        Me.btnChangeName.UseVisualStyleBackColor = False
        '
        'chkDarkMode
        '
        Me.chkDarkMode.AutoSize = True
        Me.chkDarkMode.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.chkDarkMode.ForeColor = System.Drawing.Color.White
        Me.chkDarkMode.Location = New System.Drawing.Point(44, 83)
        Me.chkDarkMode.Name = "chkDarkMode"
        Me.chkDarkMode.Size = New System.Drawing.Size(125, 27)
        Me.chkDarkMode.TabIndex = 11
        Me.chkDarkMode.Text = "Dark Mode"
        Me.chkDarkMode.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(760, 423)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(41, 22)
        Me.WebBrowser1.TabIndex = 21
        Me.WebBrowser1.Url = New System.Uri("http://www.youtube.com", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'frmMusify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 445)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.lblNowPlaying)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.picPausePlay)
        Me.Controls.Add(Me.lblVolVal)
        Me.Controls.Add(Me.pnlSaved)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.picMainBack)
        Me.Controls.Add(Me.lblMainMusify)
        Me.Controls.Add(Me.pnlSide)
        Me.Controls.Add(Me.MusicPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMusify"
        Me.Text = "Musify"
        Me.pnlControl.ResumeLayout(False)
        Me.pnlControl.PerformLayout()
        Me.cmsDots.ResumeLayout(False)
        Me.pnlSide.ResumeLayout(False)
        Me.pnlSide.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlMusic.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHomePlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSaved.ResumeLayout(False)
        Me.pnlSaved.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDeleteAdd.ResumeLayout(False)
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.MusicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPausePlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlControl As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDots As Label
    Friend WithEvents lblMusify As Label
    Friend WithEvents cmsDots As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlSide As Panel
    Friend WithEvents btnHide As Button
    Friend WithEvents lblCredits As Label
    Friend WithEvents lblMusifyMenu As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblOutput As Label
    Friend WithEvents tmrError As Timer
    Friend WithEvents lblMainMusify As Label
    Friend WithEvents pnlHome As Panel
    Friend WithEvents lblSearchit As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lsvData As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents pnlMusic As Panel
    Friend WithEvents hVolume As HScrollBar
    Friend WithEvents pnlSaved As Panel
    Friend WithEvents lblAddSong As Label
    Friend WithEvents lsvSaved As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents MusicPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblImport As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents picMainBack As PictureBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents lblSettings As Label
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents btnApply As Button
    Friend WithEvents btnSetBack As Button
    Friend WithEvents lblSettingsDis As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents cmsDeleteAdd As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picImport As PictureBox
    Friend WithEvents lblDelete As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblVolVal As Label
    Friend WithEvents picPausePlay As PictureBox
    Friend WithEvents picHomePlay As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblNowPlaying As Label
    Friend WithEvents btnChangeName As Button
    Friend WithEvents chkDarkMode As CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
