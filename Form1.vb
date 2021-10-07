Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Threading
Imports WMPLib

Public Class frmMusify
    'below is for data reading
    Dim fileWithName As String = "MusifyData\MusifyNames.txt"
    Dim lines() As String

    'below is for media controls
    Dim playing As Boolean = False
    Dim prevPlay As Boolean = False
    Dim songName As String = Nothing

    'below is for resizing and moving window
    Dim loc As Point
    Dim rs As New Resizer

    'variables for tmrError below
    Dim time As Integer
    Dim errorMsg As String

    'below is for copying files
    Dim copyPath As String

    'below is for screenshots
    Dim picNum As Integer = 0

    'below is for blur effects
    Dim picBlurSet As New PictureBox

    'below is for initating
    Dim picLoad As New PictureBox
    Dim lblLoad As New Label

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseMove, lblMusify.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseDown, lblMusify.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        MessageBox.Show("Sorry, This feature is in W.I.P );", "Sorry - W.I.P", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Me.WindowState = FormWindowState.Maximized  -                                                                          FIX THIS
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Call RefreshData()
        lblVolVal.Text = CStr(MusicPlayer.settings.volume) & "%"
        HScrollBar1.Value = 50
        hVolume.Value = 50
        Call menuIn()
        btnChangeName.Enabled = False

        picLoad.Size = New Size(801, 390)
        picLoad.Location = New Point(0, 60)
        picLoad.BackColor = Color.White
        Me.Controls.Add(picLoad)
        AddHandler picLoad.Click, AddressOf Me.picLoad_Click
        AddHandler lblLoad.Click, AddressOf Me.picLoad_Click

        lblLoad.Location = New Point(175, 100)
        lblLoad.Font = New Font("Times New Roman", 15, FontStyle.Bold)
        lblLoad.Size = New Size(500, 500)
        lblLoad.AutoSize = False
        lblLoad.TextAlign = ContentAlignment.TopCenter
        Me.Controls.Add(lblLoad)

        picLoad.Show()
        picLoad.BringToFront()
        lblLoad.Show()
        lblLoad.BringToFront()
        lblLoad.Text = "Click Anywhere To Initiate!"
    End Sub

    Private Sub picLoad_Click(sender As Object, e As EventArgs)
        If lblLoad.Text.Contains("Finished Initiating!") Then
            picLoad.Hide()
            lblLoad.Hide()
        Else
            lblLoad.Text &= vbNewLine & "Looking for MusifyData..."
            If Directory.Exists("MusifyData") Then
                lblLoad.Text &= vbNewLine & "Found MusifyData...!"
StartPosition1:
                lblLoad.Text &= vbNewLine & "Looking for MusifyNames.txt..."
                If File.Exists("MusifyData\MusifyNames.txt") Then
                    lblLoad.Text &= vbNewLine & "Found MusifyNames.txt...!"
StartPosition2:
                    lblLoad.Text &= vbNewLine & "Looking for log..."
                    If Directory.Exists("MusifyData\log") Then
                        lblLoad.Text &= vbNewLine & "Found log...!"
StartPosition3:
                        lblLoad.Text &= vbNewLine & "Looking for temp..."
                        If Directory.Exists("MusifyData\temp") Then
                            lblLoad.Text &= vbNewLine & "Found temp...!"
startposition4:
                            lblLoad.Text &= vbNewLine & "Looking for MusifySongs..."
                            If Directory.Exists("MusifyData\MusifySongs") Then
                                lblLoad.Text &= vbNewLine & "Found MusifySongs..!"
StartPosition5:
                                lblLoad.Text &= vbNewLine & "Finished Initiating! Click Anywhere To Launch!"
                            Else
                                lblLoad.Text &= vbNewLine & "Couldn't Find Directory"
                                Directory.CreateDirectory("MusifyData\MusifySongs")
                                lblLoad.Text &= vbNewLine & "Created New Directory"
                                GoTo StartPosition5
                            End If
                        Else
                            lblLoad.Text &= vbNewLine & "Couldn't Find Directory"
                            Directory.CreateDirectory("MusifyData\temp")
                            lblLoad.Text &= vbNewLine & "Created New Directory"
                            GoTo startposition4
                        End If
                    Else
                        lblLoad.Text &= vbNewLine & "Couldn't Find Directory"
                        Directory.CreateDirectory("MusifyData\log")
                        lblLoad.Text &= vbNewLine & "Created New Directory"
                        GoTo StartPosition3
                    End If
                Else
                    lblLoad.Text &= vbNewLine & "Couldn't Find MusifyNames.txt"
                    Dim x As StreamWriter = File.CreateText("MusifyData\MusifyNames.txt")
                    x.Close()
                    lblLoad.Text &= vbNewLine & "Created MusifyNames.txt"
                    GoTo StartPosition2
                End If
            Else
                lblLoad.Text &= vbNewLine & "Couldn't Find Directory"
                Directory.CreateDirectory("MusifyData")
                lblLoad.Text &= vbNewLine & "Created New Directory"
                GoTo StartPosition1
                lblLoad.Font = New Font("Times New Roman", 10, FontStyle.Bold)
            End If
        End If
    End Sub

    'Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    '    rs.ResizeAllControls(Me)
    'End Sub

    Private Sub lblDots_Click(sender As Object, e As EventArgs) Handles lblDots.Click
        cmsDots.Show()
    End Sub

    Private Sub menuIn()
        Dim rateLoc As Integer = 12
        Dim rateSize As Integer = 20
        For i As Integer = 0 To 7
            Refresh()
            pnlSide.Location = New Point(pnlSide.Location.X - 20, pnlSide.Location.Y)
            lblMainMusify.Location = New Point(lblMainMusify.Location.X - rateLoc, lblMainMusify.Location.Y)
            lblTime.Location = New Point(lblTime.Location.X - rateLoc, lblTime.Location.Y)
            lblVolume.Location = New Point(lblVolume.Location.X - rateLoc, lblVolume.Location.Y)
            lblVolVal.Location = New Point(lblVolVal.Location.X - rateLoc, lblVolVal.Location.Y)
            MusicPlayer.Size = New Size(MusicPlayer.Size.Width + rateSize, MusicPlayer.Size.Height)
            MusicPlayer.Location = New Point(MusicPlayer.Location.X - 20, MusicPlayer.Location.Y)
            picMainBack.Size = New Size(picMainBack.Size.Width + rateSize, picMainBack.Size.Height)
            picMainBack.Location = New Point(picMainBack.Location.X - 20, picMainBack.Location.Y)
            HScrollBar1.Size = New Size(HScrollBar1.Size.Width + rateSize, HScrollBar1.Size.Height)
            HScrollBar1.Location = New Point(HScrollBar1.Location.X - 20, HScrollBar1.Location.Y)
            picPausePlay.Location = New Point(picPausePlay.Location.X - rateLoc, picPausePlay.Location.Y)
            lblNowPlaying.Location = New Point(lblNowPlaying.Location.X - rateLoc, lblNowPlaying.Location.Y)
            btnChangeName.Location = New Point(btnChangeName.Location.X - rateLoc, btnChangeName.Location.Y)
            Thread.Sleep(1)
            Refresh()
        Next
        btnHide.Text = "-->"
        pnlSide.BackColor = Color.White
        btnHide.ForeColor = Color.White
        btnHide.BackColor = Color.Black
    End Sub
    Private Sub menuOut()
        For i As Integer = 0 To 7
            Refresh()
            pnlSide.Location = New Point(pnlSide.Location.X + 20, pnlSide.Location.Y)
            lblMainMusify.Location = New Point(lblMainMusify.Location.X + 12, lblMainMusify.Location.Y)
            lblTime.Location = New Point(lblTime.Location.X + 12, lblTime.Location.Y)
            lblVolume.Location = New Point(lblVolume.Location.X + 12, lblVolume.Location.Y)
            lblVolVal.Location = New Point(lblVolVal.Location.X + 12, lblVolVal.Location.Y)
            MusicPlayer.Size = New Size(MusicPlayer.Size.Width - 20, MusicPlayer.Size.Height)
            MusicPlayer.Location = New Point(MusicPlayer.Location.X + 20, MusicPlayer.Location.Y)
            picMainBack.Size = New Size(picMainBack.Size.Width - 20, picMainBack.Size.Height)
            picMainBack.Location = New Point(picMainBack.Location.X + 20, picMainBack.Location.Y)
            HScrollBar1.Size = New Size(HScrollBar1.Size.Width - 20, HScrollBar1.Size.Height)
            HScrollBar1.Location = New Point(HScrollBar1.Location.X + 20, HScrollBar1.Location.Y)
            picPausePlay.Location = New Point(picPausePlay.Location.X + 12, picPausePlay.Location.Y)
            lblNowPlaying.Location = New Point(lblNowPlaying.Location.X + 12, lblNowPlaying.Location.Y)
            btnChangeName.Location = New Point(btnChangeName.Location.X + 12, btnChangeName.Location.Y)
            Thread.Sleep(1)
            Refresh()
            btnHide.Refresh()
            pnlSide.BackColor = Color.Black
            btnHide.ForeColor = Color.Black
            btnHide.BackColor = Color.White
        Next
        btnHide.Text = "<--"
    End Sub
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If lblHome.Text.Contains("Hide") Then
            For i As Integer = 0 To 17
                pnlHome.Location = New Point(pnlHome.Location.X + 33, pnlHome.Location.Y)
                Thread.Sleep(1)
                Refresh()
            Next
            lblHome.Text = "Home"
        End If
        If lblAdd.Text.Contains("Hide") Then
            For i As Integer = 0 To 18
                pnlSaved.Location = New Point(pnlSaved.Location.X, pnlSaved.Location.Y + 20)
                Thread.Sleep(1)
                Refresh()
            Next
            lblAdd.Text = "Add"
        End If
        If btnHide.Text = "<--" Then
            Call menuIn()
        ElseIf btnHide.Text = "-->" Then
            Call menuOut()
        End If
    End Sub

    Private Sub RefreshData()
        Try
            lsvData.Items.Clear()
            lsvSaved.Items.Clear()
            lines = IO.File.ReadAllLines(fileWithName)
            For Each line As String In lines
                lsvData.Items.Add(line)
                lsvSaved.Items.Add(line)
            Next
            lblNowPlaying.Text = "Now Playing: " & songName
        Catch ex As Exception
            GiveError("Error Refreshing!")
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call RefreshData()
    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then


            Dim eacher As HtmlElementCollection = WebBrowser1.Document.All

            For Each w As HtmlElement In eacher
                If w.GetAttribute("id") = utubesearch Then
                    MsgBox("hi")
                End If
            Next
            Dim x = WebBrowser1.Document.GetElementById(utubesearch)
            MsgBox(x.GetAttribute("id"))
            x.SetAttribute("value", txtSearch.Text)


            Dim btn = WebBrowser1.Document.GetElementById(utubesearchbtn)

            btn.InvokeMember("click")

            MsgBox(WebBrowser1.Url)



            'Dim index As Integer
            'Dim found As Boolean = False

            'For i As Integer = 0 To lines.Length - 1
            '    If StrConv(lines(i), vbLowerCase).Contains(StrConv(txtSearch.Text, vbLowerCase)) Then
            '        index = i
            '        lsvData.Refresh() ' not WORKING...!
            '        lsvData.Items(i).Selected = True
            '        lsvData.Select()
            '        found = True
            '    End If
            'Next
            'If found = False Then
            '    Call GiveError("Song not found!")
            'End If
            'txtSearch.Text = Nothing
        End If
    End Sub
    Private Sub GiveError(errorMsg As String)
        lblOutput.Text = errorMsg
        time = 0
        lblOutput.Visible = True
        tmrError.Enabled = True
    End Sub
    Private Sub tmrError_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
        If time >= 5 Then
            lblOutput.Visible = False
            tmrError.Enabled = False
            Exit Sub
        End If
        time += 1
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Dim iHome As Integer = 17
        Dim rate As Integer = 33

        If lblHome.Text.Contains("Hide") Then
            For i As Integer = 0 To iHome
                pnlHome.Location = New Point(pnlHome.Location.X + rate, pnlHome.Location.Y)
                Thread.Sleep(1)
                Refresh()
            Next
            lblHome.Text = "Home"
        Else
            pnlHome.BringToFront()
            For i As Integer = 0 To iHome
                pnlHome.Location = New Point(pnlHome.Location.X - rate, pnlHome.Location.Y)
                Thread.Sleep(1)
                Refresh()
            Next
            lblHome.Text = "Hide Home"
        End If
    End Sub

    Private Sub lblSaved_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        Dim iSaved As Integer = 18
        Dim rate As Integer = 20

        If lblAdd.Text.Contains("Hide") Then
            For i As Integer = 0 To iSaved
                pnlSaved.Location = New Point(pnlSaved.Location.X, pnlSaved.Location.Y + rate)
                Thread.Sleep(1)
                Refresh()
            Next
            lblAdd.Text = "Add"
        Else
            pnlSaved.BringToFront()
            For i As Integer = 0 To iSaved
                pnlSaved.Location = New Point(pnlSaved.Location.X, pnlSaved.Location.Y - rate)
                Thread.Sleep(1)
                Refresh()
            Next
            lblAdd.Text = "Hide Add"
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        MusicPlayer.settings.volume = HScrollBar1.Value
        lblVolVal.Text = CStr(MusicPlayer.settings.volume) & "%"
        hVolume.Value = HScrollBar1.Value
    End Sub

    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        If lblSettings.Text.Contains("Hide") Then
            lblSettings.Text = "Settings"
            picBlurSet.Hide()
            For i As Integer = 0 To 44
                pnlSettings.Location = New Point(pnlSettings.Location.X, pnlSettings.Location.Y - 10)
                Thread.Sleep(1)
                Refresh()
            Next
        Else
            pnlSettings.BringToFront()
            For i As Integer = 0 To 44
                pnlSettings.Location = New Point(pnlSettings.Location.X, pnlSettings.Location.Y + 10)
                Thread.Sleep(1)
                Refresh()
            Next
            lblSettings.Text = "Hide Settings"

            'below code takes screenshot
            Dim s As Screen = Screen.PrimaryScreen
            Dim img As New Bitmap(800, 445)
            Dim gr As Graphics = Graphics.FromImage(img)
            gr.CopyFromScreen(Me.Location, Point.Empty, Me.Size)
            img.Save("MusifyData\temp\Ss" & picNum & ".jpeg")
            picNum += 1

            'below code saves pic to pic box
            Call BackPic()
            pnlSettings.BringToFront()
        End If
    End Sub
    Private Sub BackPic()
        picBlurSet.Location = New Point(0, 0)
        picBlurSet.Size = New Size(800, 445)
        Me.Controls.Add(picBlurSet)
        picBlurSet.Image = Image.FromFile("MusifyData\temp\Ss" & picNum - 1 & ".jpeg")
        picBlurSet.Show()
        picBlurSet.BringToFront()
    End Sub
    Private Sub btnSetBack_Click(sender As Object, e As EventArgs) Handles btnSetBack.Click
        lblSettings.Text = "Settings"
        picBlurSet.Hide()
        For i As Integer = 0 To 44
            pnlSettings.Location = New Point(pnlSettings.Location.X, pnlSettings.Location.Y - 10)
            Thread.Sleep(1)
            Refresh()
        Next
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim indexSelect As Integer = lsvSaved.SelectedIndices(0)
        Dim nameSong As String
        Dim lines As List(Of String) = System.IO.File.ReadAllLines("MusifyData\MusifyNames.txt").ToList
        nameSong = lines(indexSelect)
        lines.RemoveAt(indexSelect) ' index starts at 0 
        System.IO.File.WriteAllLines("MusifyData\MusifyNames.txt", lines)
        lsvSaved.SelectedItems.Clear()
        If My.Computer.FileSystem.FileExists("MusifyData\MusifySongs\" & nameSong & ".mp3") = True Then
            System.IO.File.Delete("MusifyData\MusifySongs\" & nameSong & ".mp3")
        End If
        Call RefreshData()
    End Sub

    Private Sub frmMusify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim s As String
            For Each s In System.IO.Directory.GetFiles("MusifyData\temp")
                System.IO.File.Delete(s)
            Next s
        Catch ex As Exception
            GiveError(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picImport.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            copyPath = OpenFileDialog1.FileName


            My.Computer.FileSystem.CopyFile(copyPath, "MusifyData\MusifySongs\" & IO.Path.GetFileName(OpenFileDialog1.FileName))

            Dim fileVB As IO.StreamWriter
            Dim nameOnly() As String = Split(IO.Path.GetFileName(OpenFileDialog1.FileName), ".", 2)

            fileVB = File.AppendText("MusifyData\MusifyNames.txt")
            fileVB.WriteLine(nameOnly(0) & vbNewLine)
            fileVB.Close()
            Call RefreshData()

            Dim x As MsgBoxResult = MessageBox.Show("Do you want to delete the other copy of this song?", "Confirm!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If x = vbYes Then
                My.Computer.FileSystem.DeleteFile(copyPath)
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim s As String
            For Each s In System.IO.Directory.GetFiles("MusifyData\MusifySongs")
                System.IO.File.Delete(s)
            Next s
        Catch ex As Exception
            GiveError(ex.ToString)
        End Try

        File.Delete("MusifyData\MusifyNames.txt")
        Dim x As StreamWriter = File.CreateText("MusifyData\MusifyNames.txt")
        x.Close()
        Call RefreshData()
    End Sub

    Private Sub hBarTime_Scroll(sender As Object, e As ScrollEventArgs) Handles hVolume.Scroll
        MusicPlayer.settings.volume = hVolume.Value
        lblVolVal.Text = CStr(MusicPlayer.settings.volume) & "%"
        HScrollBar1.Value = hVolume.Value
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picPausePlay.Click

        If playing = False Or lsvData.SelectedItems.Count > 0 Then
            If lsvData.SelectedItems.Count > 0 Then
                songname = lsvData.SelectedItems(0).SubItems(0).Text
                If File.Exists("MusifyData\MusifySongs\" & songName & ".mp3") Then
                    lblNowPlaying.Text = "Now Playing: " & songName
                    MusicPlayer.URL = "MusifyData\MusifySongs\" & songName & ".mp3"
                    MusicPlayer.Ctlcontrols.play()
                    playing = True
                    lsvData.SelectedItems.Clear()
                    picPausePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                    picHomePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                Else
                    GiveError("Song not found!")
                End If
            ElseIf prevPlay = True Then
                picPausePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                picHomePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                MusicPlayer.Ctlcontrols.play()
                lblNowPlaying.Text = "Now Playing: " & songName
                playing = True
            Else
                GiveError("Song not selected!")
            End If
        Else
            picPausePlay.BackgroundImage = My.Resources.darkconceptPlaybtn
            picHomePlay.BackgroundImage = My.Resources.darkconceptPlaybtn
            MusicPlayer.Ctlcontrols.pause()
            lblNowPlaying.Text = "Paused: " & songName
            playing = False
            prevPlay = True
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles picHomePlay.Click
        If playing = False Or lsvData.SelectedItems.Count > 0 Then
            If lsvData.SelectedItems.Count > 0 Then
                songName = lsvData.SelectedItems(0).SubItems(0).Text
                If File.Exists("MusifyData\MusifySongs\" & songName & ".mp3") Then
                    lblNowPlaying.Text = "Now Playing: " & songName
                    MusicPlayer.URL = "MusifyData\MusifySongs\" & songName & ".mp3"
                    MusicPlayer.Ctlcontrols.play()
                    playing = True
                    lsvData.SelectedItems.Clear()
                    picHomePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                    picPausePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                Else
                    GiveError("Song not found!")
                End If
            ElseIf prevPlay = True Then
                picHomePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                picPausePlay.BackgroundImage = My.Resources.darkconceptPausebtn
                MusicPlayer.Ctlcontrols.play()
                lblNowPlaying.Text = "Now Playing: " & songName
                playing = True
            Else
                GiveError("Song not selected!")
            End If
        Else
            picHomePlay.BackgroundImage = My.Resources.darkconceptPlaybtn
            picPausePlay.BackgroundImage = My.Resources.darkconceptPlaybtn
            MusicPlayer.Ctlcontrols.pause()
            lblNowPlaying.Text = "Paused: " & songName
            playing = False
            prevPlay = True
        End If
    End Sub

    Private Sub PictureBox1_Click_2(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MusicPlayer.Ctlcontrols.previous()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MusicPlayer.Ctlcontrols.next()
    End Sub

    Private Sub lblCredits_Click(sender As Object, e As EventArgs) Handles lblCredits.Click
        MessageBox.Show("Credits" & vbNewLine & "1. LegendsZ - Creator Of Musify", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click
        Dim newName As String = InputBox("Enter the new name you would like to give this song!", "Change Name!", "")
        If newName <> "" Then
            Dim indexSelect As Integer
            Dim lineAr() As String = File.ReadAllLines("MusifyData\MusifyNames.txt")
            For i As Integer = 0 To lineAr.Length - 1
                If lineAr(i) = songName Then
                    indexSelect = i
                End If
            Next
            lineAr(indexSelect) = newName
            System.IO.File.WriteAllLines("MusifyData\MusifyNames.txt", lineAr)
            FileSystem.Rename("MusifyData\MusifySongs\" & songName & ".mp3", "MusifyData\MusifySongs\" & newName & ".mp3")
            songName = newName
            Call RefreshData()
        End If
    End Sub

    Private Sub lblNowPlaying_TextChanged(sender As Object, e As EventArgs) Handles lblNowPlaying.TextChanged
        If lblNowPlaying.Text.Contains("...") = False Then
            btnChangeName.Enabled = True
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If chkDarkMode.Checked = True Then
            For Each c As Control In Me.Controls
                c.BackColor = Color.Black
                c.ForeColor = Color.White
            Next
        Else
            For Each c As Control In Me.Controls
                c.BackColor = Color.White
                c.ForeColor = Color.Black
            Next
        End If
    End Sub
End Class