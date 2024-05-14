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
        components = New ComponentModel.Container()
        CollegeSim = New TabControl()
        Mainmenu = New TabPage()
        RArrowExit = New Label()
        LArrowSett = New Label()
        RArrowSett = New Label()
        ExitGame = New Label()
        Settingsbtn = New Label()
        StartGame = New Label()
        LArrowSg = New Label()
        RArrowSG = New Label()
        LArrowExit = New Label()
        Gifimagebox = New PictureBox()
        CharSelect = New TabPage()
        Label1 = New Label()
        selectedcharacter = New Label()
        CharacterSelectgirl = New PictureBox()
        CharacterSelectboy = New PictureBox()
        Charmenustart = New Label()
        Chargoback = New Label()
        Maingame = New TabPage()
        Panel1 = New Panel()
        storytextbox = New Label()
        currentname = New Label()
        Autoplay = New Label()
        Maingamequit = New Label()
        maingamesettings = New Label()
        Maingamebg = New PictureBox()
        Settingstab = New TabPage()
        settingsquit = New Label()
        autoplayspeed = New Label()
        Label2 = New Label()
        speedbar = New TrackBar()
        Returnbtn = New Label()
        Quiztab = New TabPage()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        openquiz = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        quizpanelbot = New Panel()
        q5ans2 = New CheckBox()
        q5ans3 = New CheckBox()
        q5ans1 = New CheckBox()
        q4ans2 = New CheckBox()
        q4ans3 = New CheckBox()
        q4ans1 = New CheckBox()
        q3ans2 = New CheckBox()
        q3ans3 = New CheckBox()
        q3ans1 = New CheckBox()
        q2ans2 = New CheckBox()
        q2ans3 = New CheckBox()
        q2ans1 = New CheckBox()
        q1ans2 = New CheckBox()
        q1ans3 = New CheckBox()
        q1ans1 = New CheckBox()
        quizq5 = New Label()
        quizq4 = New Label()
        quizq3 = New Label()
        quizq2 = New Label()
        quizq1 = New Label()
        submitbtn = New Button()
        quizpaneltop = New Panel()
        quizclose = New Label()
        quiztitle = New Label()
        Panel2 = New Panel()
        TabPage1 = New TabPage()
        Label3 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Panel3 = New Panel()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Panel4 = New Panel()
        Label14 = New Label()
        Label15 = New Label()
        Panel5 = New Panel()
        bgmaintimer = New Timer(components)
        autoplaymode = New Timer(components)
        CollegeSim.SuspendLayout()
        Mainmenu.SuspendLayout()
        CType(Gifimagebox, ComponentModel.ISupportInitialize).BeginInit()
        CharSelect.SuspendLayout()
        CType(CharacterSelectgirl, ComponentModel.ISupportInitialize).BeginInit()
        CType(CharacterSelectboy, ComponentModel.ISupportInitialize).BeginInit()
        Maingame.SuspendLayout()
        Panel1.SuspendLayout()
        CType(Maingamebg, ComponentModel.ISupportInitialize).BeginInit()
        Settingstab.SuspendLayout()
        CType(speedbar, ComponentModel.ISupportInitialize).BeginInit()
        Quiztab.SuspendLayout()
        CType(openquiz, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        quizpanelbot.SuspendLayout()
        quizpaneltop.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' CollegeSim
        ' 
        CollegeSim.Controls.Add(Mainmenu)
        CollegeSim.Controls.Add(CharSelect)
        CollegeSim.Controls.Add(Maingame)
        CollegeSim.Controls.Add(Settingstab)
        CollegeSim.Controls.Add(Quiztab)
        CollegeSim.Controls.Add(TabPage1)
        CollegeSim.Dock = DockStyle.Fill
        CollegeSim.Location = New Point(0, 0)
        CollegeSim.Margin = New Padding(3, 4, 3, 4)
        CollegeSim.Name = "CollegeSim"
        CollegeSim.SelectedIndex = 0
        CollegeSim.Size = New Size(1445, 908)
        CollegeSim.TabIndex = 0
        ' 
        ' Mainmenu
        ' 
        Mainmenu.BackgroundImage = My.Resources.Resources.Mainmenupause
        Mainmenu.BackgroundImageLayout = ImageLayout.Stretch
        Mainmenu.Controls.Add(RArrowExit)
        Mainmenu.Controls.Add(LArrowSett)
        Mainmenu.Controls.Add(RArrowSett)
        Mainmenu.Controls.Add(ExitGame)
        Mainmenu.Controls.Add(Settingsbtn)
        Mainmenu.Controls.Add(StartGame)
        Mainmenu.Controls.Add(LArrowSg)
        Mainmenu.Controls.Add(RArrowSG)
        Mainmenu.Controls.Add(LArrowExit)
        Mainmenu.Controls.Add(Gifimagebox)
        Mainmenu.Location = New Point(4, 29)
        Mainmenu.Margin = New Padding(3, 4, 3, 4)
        Mainmenu.Name = "Mainmenu"
        Mainmenu.Padding = New Padding(3, 4, 3, 4)
        Mainmenu.Size = New Size(1437, 875)
        Mainmenu.TabIndex = 0
        Mainmenu.Text = "MainMenu"
        Mainmenu.UseVisualStyleBackColor = True
        ' 
        ' RArrowExit
        ' 
        RArrowExit.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RArrowExit.ForeColor = Color.White
        RArrowExit.Location = New Point(174, 621)
        RArrowExit.Name = "RArrowExit"
        RArrowExit.Size = New Size(50, 67)
        RArrowExit.TabIndex = 8
        RArrowExit.Text = "<"
        ' 
        ' LArrowSett
        ' 
        LArrowSett.AutoSize = True
        LArrowSett.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        LArrowSett.ForeColor = Color.White
        LArrowSett.Location = New Point(19, 465)
        LArrowSett.Name = "LArrowSett"
        LArrowSett.Size = New Size(44, 59)
        LArrowSett.TabIndex = 6
        LArrowSett.Text = ">"
        ' 
        ' RArrowSett
        ' 
        RArrowSett.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RArrowSett.ForeColor = Color.White
        RArrowSett.Location = New Point(187, 461)
        RArrowSett.Name = "RArrowSett"
        RArrowSett.Size = New Size(50, 67)
        RArrowSett.TabIndex = 5
        RArrowSett.Text = "<"
        ' 
        ' ExitGame
        ' 
        ExitGame.AutoSize = True
        ExitGame.Cursor = Cursors.Hand
        ExitGame.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ExitGame.ForeColor = Color.Red
        ExitGame.Location = New Point(53, 635)
        ExitGame.Name = "ExitGame"
        ExitGame.Size = New Size(138, 30)
        ExitGame.TabIndex = 2
        ExitGame.Text = "Exit Game"
        ' 
        ' Settingsbtn
        ' 
        Settingsbtn.AutoSize = True
        Settingsbtn.Cursor = Cursors.Hand
        Settingsbtn.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Settingsbtn.Location = New Point(53, 479)
        Settingsbtn.Name = "Settingsbtn"
        Settingsbtn.Size = New Size(156, 37)
        Settingsbtn.TabIndex = 1
        Settingsbtn.Text = "Settings"
        ' 
        ' StartGame
        ' 
        StartGame.AutoSize = True
        StartGame.Cursor = Cursors.Hand
        StartGame.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        StartGame.Location = New Point(53, 395)
        StartGame.Name = "StartGame"
        StartGame.Size = New Size(302, 59)
        StartGame.TabIndex = 0
        StartGame.Text = "Start Game"
        ' 
        ' LArrowSg
        ' 
        LArrowSg.AutoSize = True
        LArrowSg.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        LArrowSg.ForeColor = Color.White
        LArrowSg.Location = New Point(19, 395)
        LArrowSg.Name = "LArrowSg"
        LArrowSg.Size = New Size(44, 59)
        LArrowSg.TabIndex = 3
        LArrowSg.Text = ">"
        ' 
        ' RArrowSG
        ' 
        RArrowSG.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        RArrowSG.ForeColor = Color.White
        RArrowSG.Location = New Point(322, 395)
        RArrowSG.Name = "RArrowSG"
        RArrowSG.Size = New Size(50, 67)
        RArrowSG.TabIndex = 4
        RArrowSG.Text = "<"
        ' 
        ' LArrowExit
        ' 
        LArrowExit.AutoSize = True
        LArrowExit.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        LArrowExit.ForeColor = Color.White
        LArrowExit.Location = New Point(19, 621)
        LArrowExit.Name = "LArrowExit"
        LArrowExit.Size = New Size(44, 59)
        LArrowExit.TabIndex = 7
        LArrowExit.Text = ">"
        ' 
        ' Gifimagebox
        ' 
        Gifimagebox.Image = My.Resources.Resources.MainMenugif
        Gifimagebox.Location = New Point(0, 0)
        Gifimagebox.Margin = New Padding(3, 4, 3, 4)
        Gifimagebox.Name = "Gifimagebox"
        Gifimagebox.Size = New Size(1440, 903)
        Gifimagebox.SizeMode = PictureBoxSizeMode.StretchImage
        Gifimagebox.TabIndex = 9
        Gifimagebox.TabStop = False
        ' 
        ' CharSelect
        ' 
        CharSelect.BackColor = SystemColors.ActiveCaption
        CharSelect.BackgroundImage = My.Resources.Resources.Classroom
        CharSelect.BackgroundImageLayout = ImageLayout.Stretch
        CharSelect.Controls.Add(Label1)
        CharSelect.Controls.Add(selectedcharacter)
        CharSelect.Controls.Add(CharacterSelectgirl)
        CharSelect.Controls.Add(CharacterSelectboy)
        CharSelect.Controls.Add(Charmenustart)
        CharSelect.Controls.Add(Chargoback)
        CharSelect.Location = New Point(4, 29)
        CharSelect.Margin = New Padding(3, 4, 3, 4)
        CharSelect.Name = "CharSelect"
        CharSelect.Padding = New Padding(3, 4, 3, 4)
        CharSelect.Size = New Size(1437, 875)
        CharSelect.TabIndex = 1
        CharSelect.Text = "CharacterMenu"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(93, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(797, 74)
        Label1.TabIndex = 5
        Label1.Text = "Choose your character"
        ' 
        ' selectedcharacter
        ' 
        selectedcharacter.BackColor = Color.Transparent
        selectedcharacter.BorderStyle = BorderStyle.FixedSingle
        selectedcharacter.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        selectedcharacter.Location = New Point(1009, 227)
        selectedcharacter.Name = "selectedcharacter"
        selectedcharacter.Size = New Size(209, 71)
        selectedcharacter.TabIndex = 4
        selectedcharacter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CharacterSelectgirl
        ' 
        CharacterSelectgirl.BackColor = Color.Transparent
        CharacterSelectgirl.Cursor = Cursors.Hand
        CharacterSelectgirl.Image = My.Resources.Resources.girl1
        CharacterSelectgirl.Location = New Point(1146, 303)
        CharacterSelectgirl.Margin = New Padding(3, 4, 3, 4)
        CharacterSelectgirl.Name = "CharacterSelectgirl"
        CharacterSelectgirl.Size = New Size(224, 996)
        CharacterSelectgirl.SizeMode = PictureBoxSizeMode.Zoom
        CharacterSelectgirl.TabIndex = 3
        CharacterSelectgirl.TabStop = False
        ' 
        ' CharacterSelectboy
        ' 
        CharacterSelectboy.BackColor = Color.Transparent
        CharacterSelectboy.Cursor = Cursors.Hand
        CharacterSelectboy.Image = My.Resources.Resources.boy
        CharacterSelectboy.Location = New Point(840, 335)
        CharacterSelectboy.Margin = New Padding(3, 4, 3, 4)
        CharacterSelectboy.Name = "CharacterSelectboy"
        CharacterSelectboy.Size = New Size(288, 588)
        CharacterSelectboy.SizeMode = PictureBoxSizeMode.Zoom
        CharacterSelectboy.TabIndex = 2
        CharacterSelectboy.TabStop = False
        ' 
        ' Charmenustart
        ' 
        Charmenustart.AutoSize = True
        Charmenustart.BackColor = Color.Transparent
        Charmenustart.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Charmenustart.ForeColor = Color.White
        Charmenustart.Location = New Point(119, 543)
        Charmenustart.Name = "Charmenustart"
        Charmenustart.Size = New Size(168, 59)
        Charmenustart.TabIndex = 1
        Charmenustart.Text = "Start"
        ' 
        ' Chargoback
        ' 
        Chargoback.AutoSize = True
        Chargoback.BackColor = Color.Transparent
        Chargoback.BorderStyle = BorderStyle.FixedSingle
        Chargoback.Font = New Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Chargoback.ForeColor = Color.Transparent
        Chargoback.Location = New Point(122, 727)
        Chargoback.Name = "Chargoback"
        Chargoback.Size = New Size(164, 45)
        Chargoback.TabIndex = 0
        Chargoback.Text = "Go back"
        ' 
        ' Maingame
        ' 
        Maingame.BackgroundImageLayout = ImageLayout.Stretch
        Maingame.Controls.Add(Panel1)
        Maingame.Controls.Add(Maingamebg)
        Maingame.Location = New Point(4, 29)
        Maingame.Margin = New Padding(3, 4, 3, 4)
        Maingame.Name = "Maingame"
        Maingame.Padding = New Padding(3, 4, 3, 4)
        Maingame.Size = New Size(1437, 875)
        Maingame.TabIndex = 2
        Maingame.Text = "Main Game"
        Maingame.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(storytextbox)
        Panel1.Controls.Add(currentname)
        Panel1.Controls.Add(Autoplay)
        Panel1.Controls.Add(Maingamequit)
        Panel1.Controls.Add(maingamesettings)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(357, 676)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(767, 184)
        Panel1.TabIndex = 5
        ' 
        ' storytextbox
        ' 
        storytextbox.BorderStyle = BorderStyle.FixedSingle
        storytextbox.FlatStyle = FlatStyle.Flat
        storytextbox.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        storytextbox.Location = New Point(22, 35)
        storytextbox.Name = "storytextbox"
        storytextbox.Size = New Size(717, 117)
        storytextbox.TabIndex = 11
        storytextbox.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' currentname
        ' 
        currentname.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        currentname.Location = New Point(22, 4)
        currentname.Name = "currentname"
        currentname.Size = New Size(296, 31)
        currentname.TabIndex = 10
        ' 
        ' Autoplay
        ' 
        Autoplay.AutoSize = True
        Autoplay.Cursor = Cursors.Hand
        Autoplay.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Autoplay.Location = New Point(661, 152)
        Autoplay.Name = "Autoplay"
        Autoplay.Size = New Size(84, 18)
        Autoplay.TabIndex = 9
        Autoplay.Text = "autoplay"
        ' 
        ' Maingamequit
        ' 
        Maingamequit.AutoSize = True
        Maingamequit.Cursor = Cursors.Hand
        Maingamequit.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Maingamequit.Location = New Point(22, 152)
        Maingamequit.Name = "Maingamequit"
        Maingamequit.Size = New Size(47, 18)
        Maingamequit.TabIndex = 8
        Maingamequit.Text = "Quit "
        ' 
        ' maingamesettings
        ' 
        maingamesettings.AutoSize = True
        maingamesettings.Cursor = Cursors.Hand
        maingamesettings.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        maingamesettings.Location = New Point(73, 152)
        maingamesettings.Name = "maingamesettings"
        maingamesettings.Size = New Size(76, 18)
        maingamesettings.TabIndex = 6
        maingamesettings.Text = "Settings"
        ' 
        ' Maingamebg
        ' 
        Maingamebg.BackgroundImageLayout = ImageLayout.Stretch
        Maingamebg.Dock = DockStyle.Fill
        Maingamebg.Location = New Point(3, 4)
        Maingamebg.Margin = New Padding(3, 4, 3, 4)
        Maingamebg.Name = "Maingamebg"
        Maingamebg.Size = New Size(1431, 867)
        Maingamebg.TabIndex = 2
        Maingamebg.TabStop = False
        ' 
        ' Settingstab
        ' 
        Settingstab.BackColor = SystemColors.ActiveCaption
        Settingstab.BackgroundImage = My.Resources.Resources.Mainmenupause
        Settingstab.BackgroundImageLayout = ImageLayout.Stretch
        Settingstab.Controls.Add(settingsquit)
        Settingstab.Controls.Add(autoplayspeed)
        Settingstab.Controls.Add(Label2)
        Settingstab.Controls.Add(speedbar)
        Settingstab.Controls.Add(Returnbtn)
        Settingstab.Location = New Point(4, 29)
        Settingstab.Margin = New Padding(3, 4, 3, 4)
        Settingstab.Name = "Settingstab"
        Settingstab.Padding = New Padding(3, 4, 3, 4)
        Settingstab.Size = New Size(1437, 875)
        Settingstab.TabIndex = 3
        Settingstab.Text = "Settings"
        ' 
        ' settingsquit
        ' 
        settingsquit.AutoSize = True
        settingsquit.BackColor = Color.Transparent
        settingsquit.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        settingsquit.Location = New Point(53, 635)
        settingsquit.Name = "settingsquit"
        settingsquit.Size = New Size(173, 37)
        settingsquit.TabIndex = 4
        settingsquit.Text = "Exit game"
        ' 
        ' autoplayspeed
        ' 
        autoplayspeed.BackColor = Color.Transparent
        autoplayspeed.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        autoplayspeed.Location = New Point(791, 127)
        autoplayspeed.Name = "autoplayspeed"
        autoplayspeed.Size = New Size(128, 31)
        autoplayspeed.TabIndex = 3
        autoplayspeed.Text = "Moderate"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(590, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 30)
        Label2.TabIndex = 2
        Label2.Text = "Autoplay speed:"
        ' 
        ' speedbar
        ' 
        speedbar.BackColor = Color.SlateGray
        speedbar.LargeChange = 0
        speedbar.Location = New Point(590, 160)
        speedbar.Margin = New Padding(3, 4, 3, 4)
        speedbar.Maximum = 5
        speedbar.Minimum = 1
        speedbar.Name = "speedbar"
        speedbar.Size = New Size(329, 56)
        speedbar.TabIndex = 1
        speedbar.Value = 3
        ' 
        ' Returnbtn
        ' 
        Returnbtn.AutoSize = True
        Returnbtn.BackColor = Color.Transparent
        Returnbtn.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Returnbtn.Location = New Point(53, 769)
        Returnbtn.Name = "Returnbtn"
        Returnbtn.Size = New Size(136, 37)
        Returnbtn.TabIndex = 0
        Returnbtn.Text = "Return"
        ' 
        ' Quiztab
        ' 
        Quiztab.BackgroundImage = My.Resources.Resources.quizwallpeper
        Quiztab.BackgroundImageLayout = ImageLayout.Stretch
        Quiztab.Controls.Add(Label7)
        Quiztab.Controls.Add(Label6)
        Quiztab.Controls.Add(Label4)
        Quiztab.Controls.Add(openquiz)
        Quiztab.Controls.Add(PictureBox2)
        Quiztab.Controls.Add(PictureBox1)
        Quiztab.Controls.Add(quizpanelbot)
        Quiztab.Controls.Add(quizpaneltop)
        Quiztab.Controls.Add(Panel2)
        Quiztab.Location = New Point(4, 29)
        Quiztab.Margin = New Padding(3, 4, 3, 4)
        Quiztab.Name = "Quiztab"
        Quiztab.Padding = New Padding(3, 4, 3, 4)
        Quiztab.Size = New Size(1437, 875)
        Quiztab.TabIndex = 4
        Quiztab.Text = "Quiz"
        Quiztab.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 241)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 9
        Label7.Text = "Start quiz"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 8
        Label6.Text = "This pc"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 7
        Label4.Text = "Recycle bin"
        ' 
        ' openquiz
        ' 
        openquiz.Image = My.Resources.Resources.quizbook
        openquiz.Location = New Point(9, 184)
        openquiz.Margin = New Padding(3, 4, 3, 4)
        openquiz.Name = "openquiz"
        openquiz.Size = New Size(51, 60)
        openquiz.SizeMode = PictureBoxSizeMode.Zoom
        openquiz.TabIndex = 6
        openquiz.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.this_pc
        PictureBox2.Location = New Point(9, 96)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(51, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.recycle_bin
        PictureBox1.Location = New Point(9, 8)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' quizpanelbot
        ' 
        quizpanelbot.BackColor = Color.White
        quizpanelbot.Controls.Add(q5ans2)
        quizpanelbot.Controls.Add(q5ans3)
        quizpanelbot.Controls.Add(q5ans1)
        quizpanelbot.Controls.Add(q4ans2)
        quizpanelbot.Controls.Add(q4ans3)
        quizpanelbot.Controls.Add(q4ans1)
        quizpanelbot.Controls.Add(q3ans2)
        quizpanelbot.Controls.Add(q3ans3)
        quizpanelbot.Controls.Add(q3ans1)
        quizpanelbot.Controls.Add(q2ans2)
        quizpanelbot.Controls.Add(q2ans3)
        quizpanelbot.Controls.Add(q2ans1)
        quizpanelbot.Controls.Add(q1ans2)
        quizpanelbot.Controls.Add(q1ans3)
        quizpanelbot.Controls.Add(q1ans1)
        quizpanelbot.Controls.Add(quizq5)
        quizpanelbot.Controls.Add(quizq4)
        quizpanelbot.Controls.Add(quizq3)
        quizpanelbot.Controls.Add(quizq2)
        quizpanelbot.Controls.Add(quizq1)
        quizpanelbot.Controls.Add(submitbtn)
        quizpanelbot.Location = New Point(395, 95)
        quizpanelbot.Margin = New Padding(3, 4, 3, 4)
        quizpanelbot.Name = "quizpanelbot"
        quizpanelbot.Size = New Size(631, 700)
        quizpanelbot.TabIndex = 3
        ' 
        ' q5ans2
        ' 
        q5ans2.AutoSize = True
        q5ans2.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q5ans2.Location = New Point(39, 633)
        q5ans2.Margin = New Padding(3, 4, 3, 4)
        q5ans2.Name = "q5ans2"
        q5ans2.Size = New Size(18, 17)
        q5ans2.TabIndex = 35
        q5ans2.UseVisualStyleBackColor = True
        ' 
        ' q5ans3
        ' 
        q5ans3.AutoSize = True
        q5ans3.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q5ans3.Location = New Point(39, 660)
        q5ans3.Margin = New Padding(3, 4, 3, 4)
        q5ans3.Name = "q5ans3"
        q5ans3.Size = New Size(18, 17)
        q5ans3.TabIndex = 34
        q5ans3.UseVisualStyleBackColor = True
        ' 
        ' q5ans1
        ' 
        q5ans1.AutoSize = True
        q5ans1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q5ans1.Location = New Point(39, 611)
        q5ans1.Margin = New Padding(3, 4, 3, 4)
        q5ans1.Name = "q5ans1"
        q5ans1.Size = New Size(18, 17)
        q5ans1.TabIndex = 33
        q5ans1.UseVisualStyleBackColor = True
        ' 
        ' q4ans2
        ' 
        q4ans2.AutoSize = True
        q4ans2.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q4ans2.Location = New Point(39, 493)
        q4ans2.Margin = New Padding(3, 4, 3, 4)
        q4ans2.Name = "q4ans2"
        q4ans2.Size = New Size(18, 17)
        q4ans2.TabIndex = 32
        q4ans2.UseVisualStyleBackColor = True
        ' 
        ' q4ans3
        ' 
        q4ans3.AutoSize = True
        q4ans3.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q4ans3.Location = New Point(39, 520)
        q4ans3.Margin = New Padding(3, 4, 3, 4)
        q4ans3.Name = "q4ans3"
        q4ans3.Size = New Size(18, 17)
        q4ans3.TabIndex = 31
        q4ans3.UseVisualStyleBackColor = True
        ' 
        ' q4ans1
        ' 
        q4ans1.AutoSize = True
        q4ans1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q4ans1.Location = New Point(39, 471)
        q4ans1.Margin = New Padding(3, 4, 3, 4)
        q4ans1.Name = "q4ans1"
        q4ans1.Size = New Size(18, 17)
        q4ans1.TabIndex = 30
        q4ans1.UseVisualStyleBackColor = True
        ' 
        ' q3ans2
        ' 
        q3ans2.AutoSize = True
        q3ans2.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q3ans2.Location = New Point(39, 364)
        q3ans2.Margin = New Padding(3, 4, 3, 4)
        q3ans2.Name = "q3ans2"
        q3ans2.Size = New Size(18, 17)
        q3ans2.TabIndex = 29
        q3ans2.UseVisualStyleBackColor = True
        ' 
        ' q3ans3
        ' 
        q3ans3.AutoSize = True
        q3ans3.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q3ans3.Location = New Point(39, 391)
        q3ans3.Margin = New Padding(3, 4, 3, 4)
        q3ans3.Name = "q3ans3"
        q3ans3.Size = New Size(18, 17)
        q3ans3.TabIndex = 28
        q3ans3.UseVisualStyleBackColor = True
        ' 
        ' q3ans1
        ' 
        q3ans1.AutoSize = True
        q3ans1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q3ans1.Location = New Point(39, 341)
        q3ans1.Margin = New Padding(3, 4, 3, 4)
        q3ans1.Name = "q3ans1"
        q3ans1.Size = New Size(18, 17)
        q3ans1.TabIndex = 27
        q3ans1.UseVisualStyleBackColor = True
        ' 
        ' q2ans2
        ' 
        q2ans2.AutoSize = True
        q2ans2.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q2ans2.Location = New Point(39, 232)
        q2ans2.Margin = New Padding(3, 4, 3, 4)
        q2ans2.Name = "q2ans2"
        q2ans2.Size = New Size(18, 17)
        q2ans2.TabIndex = 26
        q2ans2.UseVisualStyleBackColor = True
        ' 
        ' q2ans3
        ' 
        q2ans3.AutoSize = True
        q2ans3.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q2ans3.Location = New Point(39, 259)
        q2ans3.Margin = New Padding(3, 4, 3, 4)
        q2ans3.Name = "q2ans3"
        q2ans3.Size = New Size(18, 17)
        q2ans3.TabIndex = 25
        q2ans3.UseVisualStyleBackColor = True
        ' 
        ' q2ans1
        ' 
        q2ans1.AutoSize = True
        q2ans1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q2ans1.Location = New Point(39, 209)
        q2ans1.Margin = New Padding(3, 4, 3, 4)
        q2ans1.Name = "q2ans1"
        q2ans1.Size = New Size(18, 17)
        q2ans1.TabIndex = 24
        q2ans1.UseVisualStyleBackColor = True
        ' 
        ' q1ans2
        ' 
        q1ans2.AutoSize = True
        q1ans2.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q1ans2.Location = New Point(39, 88)
        q1ans2.Margin = New Padding(3, 4, 3, 4)
        q1ans2.Name = "q1ans2"
        q1ans2.Size = New Size(18, 17)
        q1ans2.TabIndex = 23
        q1ans2.UseVisualStyleBackColor = True
        ' 
        ' q1ans3
        ' 
        q1ans3.AutoSize = True
        q1ans3.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q1ans3.Location = New Point(39, 115)
        q1ans3.Margin = New Padding(3, 4, 3, 4)
        q1ans3.Name = "q1ans3"
        q1ans3.Size = New Size(18, 17)
        q1ans3.TabIndex = 22
        q1ans3.UseVisualStyleBackColor = True
        ' 
        ' q1ans1
        ' 
        q1ans1.AutoSize = True
        q1ans1.Font = New Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point)
        q1ans1.Location = New Point(39, 65)
        q1ans1.Margin = New Padding(3, 4, 3, 4)
        q1ans1.Name = "q1ans1"
        q1ans1.Size = New Size(18, 17)
        q1ans1.TabIndex = 21
        q1ans1.UseVisualStyleBackColor = True
        ' 
        ' quizq5
        ' 
        quizq5.BorderStyle = BorderStyle.FixedSingle
        quizq5.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        quizq5.Location = New Point(39, 557)
        quizq5.Name = "quizq5"
        quizq5.Size = New Size(345, 46)
        quizq5.TabIndex = 17
        quizq5.Text = "Test"
        ' 
        ' quizq4
        ' 
        quizq4.BorderStyle = BorderStyle.FixedSingle
        quizq4.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        quizq4.Location = New Point(39, 420)
        quizq4.Name = "quizq4"
        quizq4.Size = New Size(345, 46)
        quizq4.TabIndex = 13
        quizq4.Text = "Test"
        ' 
        ' quizq3
        ' 
        quizq3.BorderStyle = BorderStyle.FixedSingle
        quizq3.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        quizq3.Location = New Point(39, 293)
        quizq3.Name = "quizq3"
        quizq3.Size = New Size(345, 46)
        quizq3.TabIndex = 9
        quizq3.Text = "Test"
        ' 
        ' quizq2
        ' 
        quizq2.BorderStyle = BorderStyle.FixedSingle
        quizq2.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        quizq2.Location = New Point(39, 159)
        quizq2.Name = "quizq2"
        quizq2.Size = New Size(345, 46)
        quizq2.TabIndex = 5
        quizq2.Text = "Test"
        ' 
        ' quizq1
        ' 
        quizq1.BorderStyle = BorderStyle.FixedSingle
        quizq1.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        quizq1.Location = New Point(39, 15)
        quizq1.Name = "quizq1"
        quizq1.Size = New Size(345, 46)
        quizq1.TabIndex = 1
        quizq1.Text = "Test"
        ' 
        ' submitbtn
        ' 
        submitbtn.BackColor = Color.Silver
        submitbtn.FlatStyle = FlatStyle.Flat
        submitbtn.Location = New Point(491, 621)
        submitbtn.Margin = New Padding(3, 4, 3, 4)
        submitbtn.Name = "submitbtn"
        submitbtn.Size = New Size(86, 31)
        submitbtn.TabIndex = 0
        submitbtn.Text = "Submit"
        submitbtn.UseVisualStyleBackColor = False
        ' 
        ' quizpaneltop
        ' 
        quizpaneltop.BackColor = Color.White
        quizpaneltop.Controls.Add(quizclose)
        quizpaneltop.Controls.Add(quiztitle)
        quizpaneltop.Location = New Point(395, 61)
        quizpaneltop.Margin = New Padding(3, 4, 3, 4)
        quizpaneltop.Name = "quizpaneltop"
        quizpaneltop.Size = New Size(631, 39)
        quizpaneltop.TabIndex = 2
        ' 
        ' quizclose
        ' 
        quizclose.AutoSize = True
        quizclose.Font = New Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point)
        quizclose.Location = New Point(600, 7)
        quizclose.Name = "quizclose"
        quizclose.Size = New Size(18, 20)
        quizclose.TabIndex = 2
        quizclose.Text = "X"
        ' 
        ' quiztitle
        ' 
        quiztitle.AutoSize = True
        quiztitle.Font = New Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point)
        quiztitle.Location = New Point(18, 7)
        quiztitle.Name = "quiztitle"
        quiztitle.Size = New Size(39, 20)
        quiztitle.TabIndex = 0
        quiztitle.Text = "Quiz"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.barbar
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(0, 859)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1440, 40)
        Panel2.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.quizwallpeper
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(PictureBox3)
        TabPage1.Controls.Add(PictureBox4)
        TabPage1.Controls.Add(PictureBox5)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(Panel4)
        TabPage1.Controls.Add(Panel5)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(1437, 875)
        TabPage1.TabIndex = 5
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(1, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 18
        Label3.Text = "Start quiz"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 167)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 17
        Label5.Text = "This pc"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 79)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 20)
        Label8.TabIndex = 16
        Label8.Text = "Recycle bin"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.quizbook
        PictureBox3.Location = New Point(3, 191)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 60)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 15
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.this_pc
        PictureBox4.Location = New Point(3, 103)
        PictureBox4.Margin = New Padding(3, 4, 3, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(51, 60)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 14
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.recycle_bin
        PictureBox5.Location = New Point(3, 15)
        PictureBox5.Margin = New Padding(3, 4, 3, 4)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(51, 60)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(393, 76)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(631, 700)
        Panel3.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(119, 541)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(153, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(491, 621)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Label15)
        Panel4.Location = New Point(393, 43)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(631, 39)
        Panel4.TabIndex = 11
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(600, 7)
        Label14.Name = "Label14"
        Label14.Size = New Size(18, 20)
        Label14.TabIndex = 2
        Label14.Text = "X"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(18, 7)
        Label15.Name = "Label15"
        Label15.Size = New Size(39, 20)
        Label15.TabIndex = 0
        Label15.Text = "Quiz"
        ' 
        ' Panel5
        ' 
        Panel5.BackgroundImage = My.Resources.Resources.barbar
        Panel5.BackgroundImageLayout = ImageLayout.Zoom
        Panel5.Location = New Point(-2, 840)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1440, 40)
        Panel5.TabIndex = 10
        ' 
        ' bgmaintimer
        ' 
        ' 
        ' autoplaymode
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1445, 908)
        Controls.Add(CollegeSim)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CollegeSim.ResumeLayout(False)
        Mainmenu.ResumeLayout(False)
        Mainmenu.PerformLayout()
        CType(Gifimagebox, ComponentModel.ISupportInitialize).EndInit()
        CharSelect.ResumeLayout(False)
        CharSelect.PerformLayout()
        CType(CharacterSelectgirl, ComponentModel.ISupportInitialize).EndInit()
        CType(CharacterSelectboy, ComponentModel.ISupportInitialize).EndInit()
        Maingame.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Maingamebg, ComponentModel.ISupportInitialize).EndInit()
        Settingstab.ResumeLayout(False)
        Settingstab.PerformLayout()
        CType(speedbar, ComponentModel.ISupportInitialize).EndInit()
        Quiztab.ResumeLayout(False)
        Quiztab.PerformLayout()
        CType(openquiz, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        quizpanelbot.ResumeLayout(False)
        quizpanelbot.PerformLayout()
        quizpaneltop.ResumeLayout(False)
        quizpaneltop.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CollegeSim As TabControl
    Friend WithEvents CharSelect As TabPage
    Friend WithEvents Maingame As TabPage
    Friend WithEvents Chargoback As Label
    Friend WithEvents Charmenustart As Label
    Friend WithEvents CharacterSelectboy As PictureBox
    Friend WithEvents CharacterSelectgirl As PictureBox
    Friend WithEvents Settingstab As TabPage
    Friend WithEvents selectedcharacter As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mainmenu As TabPage
    Friend WithEvents RArrowExit As Label
    Friend WithEvents LArrowSett As Label
    Friend WithEvents RArrowSett As Label
    Friend WithEvents ExitGame As Label
    Friend WithEvents Settingsbtn As Label
    Friend WithEvents StartGame As Label
    Friend WithEvents LArrowSg As Label
    Friend WithEvents RArrowSG As Label
    Friend WithEvents LArrowExit As Label
    Friend WithEvents bgmaintimer As Timer
    Friend WithEvents Gifimagebox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Returnbtn As Label
    Friend WithEvents maingamesettings As Label
    Friend WithEvents Maingamequit As Label
    Friend WithEvents Autoplay As Label
    Friend WithEvents autoplaymode As Timer
    Friend WithEvents speedbar As TrackBar
    Friend WithEvents autoplayspeed As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents settingsquit As Label
    Friend WithEvents Maingamebg As PictureBox
    Friend WithEvents Quiztab As TabPage
    Friend WithEvents currentname As Label
    Friend WithEvents storytextbox As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents quizpaneltop As Panel
    Friend WithEvents quizpanelbot As Panel
    Friend WithEvents quiztitle As Label
    Friend WithEvents quizclose As Label
    Friend WithEvents submitbtn As Button
    Friend WithEvents quizq1 As Label
    Friend WithEvents quizq5 As Label
    Friend WithEvents quizq4 As Label
    Friend WithEvents quizq3 As Label
    Friend WithEvents quizq2 As Label
    Friend WithEvents openquiz As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents q5ans2 As CheckBox
    Friend WithEvents q5ans3 As CheckBox
    Friend WithEvents q5ans1 As CheckBox
    Friend WithEvents q4ans2 As CheckBox
    Friend WithEvents q4ans3 As CheckBox
    Friend WithEvents q4ans1 As CheckBox
    Friend WithEvents q3ans2 As CheckBox
    Friend WithEvents q3ans3 As CheckBox
    Friend WithEvents q3ans1 As CheckBox
    Friend WithEvents q2ans2 As CheckBox
    Friend WithEvents q2ans3 As CheckBox
    Friend WithEvents q2ans1 As CheckBox
    Friend WithEvents q1ans2 As CheckBox
    Friend WithEvents q1ans3 As CheckBox
    Friend WithEvents q1ans1 As CheckBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class
