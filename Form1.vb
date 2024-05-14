Imports System.Drawing.Text
Imports System.Media
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    'Music players
    Dim Menubgm As New SoundPlayer(My.Resources.MainMenubgm)
    Dim btnpress As New SoundPlayer(My.Resources.PressBtn)

    'Menu switcher
    Dim menuswitcher As Integer = 0

    Private originalSize As Size
    Private originalSize2 As Size

    'script string int
    Dim storygame As Integer = 0

    Dim quizcount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menubgm.Load()


        ' tab hider
        CollegeSim.ItemSize = New Size(0, 1)
        CollegeSim.SizeMode = TabSizeMode.Fixed


        ' Attach event handlers for PictureBox1
        AddHandler CharacterSelectboy.MouseEnter, Sub() EnlargePictureBox(CharacterSelectboy)
        AddHandler CharacterSelectboy.MouseLeave, Sub() ShrinkPictureBox(CharacterSelectboy)

        ' Attach event handlers for PictureBox2
        AddHandler CharacterSelectgirl.MouseEnter, Sub() EnlargePictureBox(CharacterSelectgirl)
        AddHandler CharacterSelectgirl.MouseLeave, Sub() ShrinkPictureBox(CharacterSelectgirl)


        'Menu arrow
        LArrowExit.Visible = False
        LArrowSett.Visible = False
        LArrowSg.Visible = False
        RArrowExit.Visible = False
        RArrowSett.Visible = False
        RArrowSG.Visible = False
        StartGame.Visible = False
        ExitGame.Visible = False
        Settingsbtn.Visible = False

        'timertimer
        bgmaintimer.Start()
        bgmaintimer.Interval = 2500

        Maingamebg.SizeMode = PictureBoxSizeMode.StretchImage



        'quiz invisible
        quizq1.Visible = False
        quizq2.Visible = False
        quizq3.Visible = False
        quizq4.Visible = False
        quizq5.Visible = False
        q1ans1.Visible = False
        q1ans2.Visible = False
        q1ans3.Visible = False
        q2ans1.Visible = False
        q2ans2.Visible = False
        q2ans3.Visible = False
        q3ans1.Visible = False
        q3ans2.Visible = False
        q3ans3.Visible = False
        q4ans1.Visible = False
        q4ans2.Visible = False
        q4ans3.Visible = False
        q5ans1.Visible = False
        q5ans2.Visible = False
        q4ans3.Visible = False
        quiztitle.Visible = False
        quizclose.Visible = False
        quizpanelbot.Visible = False
        quizpaneltop.Visible = False
        submitbtn.Visible = False

    End Sub


    'Main Menu ==============
    Private Sub StartGame_MouseHover(sender As Object, e As EventArgs) Handles StartGame.MouseHover
        StartGame.ForeColor = Color.White
        LArrowSg.Visible = True
        RArrowSG.Visible = True
    End Sub

    Private Sub StartGame_MouseLeave(sender As Object, e As EventArgs) Handles StartGame.MouseLeave
        StartGame.ForeColor = Color.Black
        LArrowSg.Visible = False
        RArrowSG.Visible = False
    End Sub
    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click
        btnpress.Play()
        CollegeSim.SelectedTab = CharSelect

        Select Case menuswitcher
            Case 0 'Case 0 main menu
                menuswitcher += 1
                'case 1 character menu
        End Select
    End Sub

    'settings button ==============
    Private Sub Settingsbtn_MouseHover(sender As Object, e As EventArgs) Handles Settingsbtn.MouseHover
        Settingsbtn.ForeColor = Color.White
        LArrowSett.Visible = True
        RArrowSett.Visible = True
    End Sub

    Private Sub Settingsbtn_MouseLeave(sender As Object, e As EventArgs) Handles Settingsbtn.MouseLeave
        Settingsbtn.ForeColor = Color.Black
        LArrowSett.Visible = False
        RArrowSett.Visible = False
    End Sub

    Private Sub Settingsbtn_Click(sender As Object, e As EventArgs) Handles Settingsbtn.Click
        btnpress.Play()

        CollegeSim.SelectedTab = Settingstab
        menuswitcher += 5

    End Sub

    'Exit game

    Private Sub ExitGame_MouseLeave(sender As Object, e As EventArgs) Handles ExitGame.MouseLeave
        ExitGame.ForeColor = Color.Red

        LArrowExit.Visible = False
        RArrowExit.Visible = False
    End Sub

    Private Sub ExitGame_MouseHover(sender As Object, e As EventArgs) Handles ExitGame.MouseHover
        ExitGame.ForeColor = Color.White
        LArrowExit.Visible = True
        RArrowExit.Visible = True
    End Sub

    Private Sub ExitGame_Click(sender As Object, e As EventArgs) Handles ExitGame.Click
        Me.Close()
    End Sub
    'Character Select clicks

    'Chargoback
    Private Sub Chargoback_Click(sender As Object, e As EventArgs) Handles Chargoback.Click
        CollegeSim.SelectedTab = Mainmenu
        btnpress.Play()

        menuswitcher -= 1

        selectedcharacter.Text = ""
    End Sub

    Private Sub Chargoback_MouseHover(sender As Object, e As EventArgs) Handles Chargoback.MouseHover
        Chargoback.ForeColor = Color.White
    End Sub

    Private Sub Chargoback_MouseLeave(sender As Object, e As EventArgs) Handles Chargoback.MouseLeave
        Chargoback.ForeColor = Color.Black
    End Sub



    'charmenustart
    Private Sub Charmenustart_MouseHover(sender As Object, e As EventArgs) Handles Charmenustart.MouseHover
        Charmenustart.ForeColor = Color.Black
    End Sub

    Private Sub Charmenustart_MouseLeave(sender As Object, e As EventArgs) Handles Charmenustart.MouseLeave
        Charmenustart.ForeColor = Color.White
    End Sub
    Private Sub Charmenustart_Click(sender As Object, e As EventArgs) Handles Charmenustart.Click

        Menubgm.PlayLooping()

        If selectedcharacter.Text = "" Then
            MessageBox.Show("Please select a character first", "Choose a character", MessageBoxButtons.OK)
        Else
            CollegeSim.SelectedTab = Maingame
            menuswitcher += 1
        End If

    End Sub


    'character image select
    Private Sub EnlargePictureBox(pictureBox As PictureBox)
        pictureBox.Size = New Size(pictureBox.Width + 20, pictureBox.Height + 20)
    End Sub

    Private Sub ShrinkPictureBox(pictureBox As PictureBox)
        pictureBox.Size = New Size(pictureBox.Width - 20, pictureBox.Height - 20)
    End Sub

    Private Sub CharacterSelectboy_Click(sender As Object, e As EventArgs) Handles CharacterSelectboy.Click
        selectedcharacter.Text = "Miyuki"
    End Sub

    Private Sub CharacterSelectgirl_Click(sender As Object, e As EventArgs) Handles CharacterSelectgirl.Click
        selectedcharacter.Text = "Sayori"
    End Sub


    Private Sub Bgmaintimer_Tick(sender As Object, e As EventArgs) Handles bgmaintimer.Tick
        bgmaintimer.Stop()
        Settingsbtn.Visible = True
        ExitGame.Visible = True
        StartGame.Visible = True
        Gifimagebox.Visible = False
    End Sub

    'settigns tab
    'return button
    Private Sub Returnbtn_Click(sender As Object, e As EventArgs) Handles Returnbtn.Click
        Select Case menuswitcher
            Case 5 'from main menu settings
                CollegeSim.SelectedTab = Mainmenu
                menuswitcher -= 5
            Case 7 'from main game settings
                CollegeSim.SelectedTab = Maingame
                menuswitcher -= 5
        End Select
    End Sub

    Private Sub Settingsquit_Click(sender As Object, e As EventArgs) Handles settingsquit.Click
        Me.Close()
    End Sub
    Private Sub Speedbar_Scroll(sender As Object, e As EventArgs) Handles speedbar.Scroll
        autoplayspeed.Text = speedbar.Value
        If speedbar.Value = 5 Then
            autoplayspeed.Text = "Very Fast"
        ElseIf speedbar.Value = 4 Then
            autoplayspeed.Text = "Fast"
        ElseIf speedbar.Value = 3 Then
            autoplayspeed.Text = "Moderate"
        ElseIf speedbar.Value = 2 Then
            autoplayspeed.Text = "Slow"
        ElseIf speedbar.Value = 1 Then
            autoplayspeed.Text = "Very Slow"
        End If
    End Sub



    'main game

    'settings
    Private Sub Maingamesettings_Click(sender As Object, e As EventArgs) Handles maingamesettings.Click
        menuswitcher += 5
        CollegeSim.SelectedTab = Settingstab
    End Sub

    'quit game
    Private Sub Maingamequit_Click(sender As Object, e As EventArgs) Handles Maingamequit.Click
        Select Case menuswitcher
            Case 2
                Dim result As DialogResult = MessageBox.Show("Are you sure? Doing this all progress will be lost", "You're about to quit the game", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    CollegeSim.SelectedTab = Mainmenu
                    menuswitcher -= 2
                    selectedcharacter.Text = ""

                    currentname.Text = ""

                    storygame = 0

                    storytextbox.Text = ""
                    selectedcharacter.Text = ""

                    Maingamebg.Image = My.Resources.y1s3schoolfront
                End If
        End Select
    End Sub
    'autoplay

    Private Sub Autoplay_Click(sender As Object, e As EventArgs) Handles Autoplay.Click
        If Autoplay.Text = "autoplay" Then
            Autoplay.Text = "stop"
            autoplaymode.Start()
        Else
            Autoplay.Text = "autoplay"
            autoplaymode.Stop()
        End If


    End Sub

    Private Sub Autoplaymode_Tick(sender As Object, e As EventArgs) Handles autoplaymode.Tick
        If speedbar.Value = 5 Then
            autoplaymode.Interval = 1500
        ElseIf speedbar.Value = 4 Then
            autoplaymode.Interval = 3000
        ElseIf speedbar.Value = 3 Then
            autoplaymode.Interval = 4500
        ElseIf speedbar.Value = 2 Then
            autoplaymode.Interval = 5500
        ElseIf speedbar.Value = 1 Then
            autoplaymode.Interval = 6500
        End If
        storygame += 1

        Dim chargender As String = selectedcharacter.Text

        Dim selectedname As String


        If selectedcharacter.Text = "Miyuki" Then
            selectedname = "Miyuki"
        Else
            selectedname = "Sayori"
        End If

        'script story

        Dim script1 As String = "In the bustling city of Laguna there lived a bright and curious 1st-year high school student named " & selectedname & ". " & selectedname & " had always been fascinated by the world of technology. When it came time to choose a specialization for high school, there was no doubt in his mind – it had to be the Bachelor of Science in Information Technology program."
        Dim script2 As String = “Excitement bubbled within ” & selectedname & “ as the first day of high school approached. The campus was in a modern structure, with big glass windows. As ” & selectedname & “ entered the hallowed halls of Amethyst University a sense of anticipation and nervousness mingled in the air.”

        'main char
        Dim script3 As String = “So this is what college looks like. Time to get serious self. Okay, deep breaths, “ & selectedname & “. You got this. Just open the door, find a seat, and act normally.”

        'story
        Dim script4 As String = selectedname & “ took a moment to collect himself before approaching the front door. The classroom is abuzz with chatter as new students find their seats.”
        Dim script5 As String = "The first few weeks were a whirlwind of new faces, challenging classes, and the excitement of diving into Information Technology. “ & selectedname & “ found himself in a diverse group of classmates, all passionate about the endless possibilities the digital world offered. "

        'IN THE SCHOOL FRONT - MORNING
        'Bff 3
        Dim script6 As String = "Did you guys see the news about the new coding boot camp opening downtown? I'm seriously considering it."

        'main char
        Dim script7 As String = "Yeah, coding is the future. I heard they're incorporating AI and machine "

        'bff 1
        Dim script8 As String = "Cybersecurity is my jam! I attended a webinar last night, and they discussed the latest trends. It's scary how vulnerable we can be online."

        'bff 2
        Dim script9 As String = "You should check out this article about quantum computing. It might change the game in cybersecurity."

        'story
        Dim script10 As String = "The introductory courses covered the basics and the majors of programming, units for Purposive communication, Philippine history, Filipino, and Mathematics in the  Modern World."

        'COMPUTER LAB - AFTERNOON
        'story
        Dim script11 As String = selectedname & "'s eyes sparkled with enthusiasm as they wrote their first lines of code, realizing the power of turning ideas into tangible programs."

        'main char
        Dim script12 As String = "Woah! This is so cool! I want to learn more about programming."

        'bff 3
        Dim script13 As String = "Me too!"

        'main char room - evening
        Dim script14 As String = selectedname & “ encountered both challenges and triumphs. Late-night coding sessions became a routine, and group projects forged lasting friendships. The camaraderie among the IT students was palpable, as they collaborated on projects that ranged from developing simple websites to designing apps that provide solutions."

        'DISCORD [group chat]
        'main char
        Dim script15 As String = "This program is driving me crazy! I can't figure out where I went wrong"

        'bff 2
        Dim script16 As String = "Let me take a look. Ah, right here. You missed a semicolon. It happens to the best of us."

        'main char
        Dim script17 As String = "Thanks, Grian! You're a lifesaver. How did you become so good at this stuff?"

        'bff/grian
        Dim script18 As String = "Well, it's all about practice and not being afraid to make mistakes. Coding is like solving puzzles. The more you do, the better you get."

        'story
        Dim script19 As String = "Together, they tackled the challenge with passion, creativity, and a dash of sleep deprivation."
        'CLASSROOM - MORNING
        Dim script20 As String = "The 1st-year Information Technology students sit at their desks, laptops open, ready for a surprise quiz. The tension in the air is palpable as the professor hands out the question papers."

        'professor jax
        Dim script21 As String = "Alright, everyone, time for a quick pop quiz to test your knowledge. No need to stress, just show what you've learned so far."

        'main char to bff 1
        Dim script22 As String = "Did you review the lessons we studied last week?"

        'bff1
        Dim script23 As String = "I did, but I'm not sure I remember all of them. This could be challenging."

        'pause for quiz
        Dim script24 As String = "The clock ticked relentlessly, but they persevered, drawing on their collective knowledge and skills. In the end, they finished the quiz on time. The professor dismissed the class. "

        'campus courtyard lunch
        Dim script25 As String = "Underneath a vibrant blue sky, “ & selectedname & “ ,  Cory, France, and Grian gather on a bench near the campus courtyard, eagerly discussing the quiz they've just taken."

        'bff2
        Dim script26 As String = "That quiz was something Else, right? I didn't expect so many multithreading questions."
        'bff3
        Dim script27 As String = "Seriously, En! Some of the questions threw me off."
        'mainchar
        Dim script28 As String = "I completely blanked on that URL acronym. Embarrassing, considering we've all typed a million of them."
        'bff1
        Dim script29 As String = "I won't lie, I had a moment of panic with the encryption question. Thank goodness I remembered my ciphers."
        'main char
        Dim script30 As String = "True, true. But hey, at least it covered a bit of everything. Networking, programming, security — it's like a crash course in one quiz."
        'bff 3
        Dim script31 As String = "And it's just the beginning, right? We're here to learn, and quizzes like these keep us on our toes."
        'bff 2
        Dim script32 As String = "Absolutely. Keeps the brain cells alive. Plus, we can always study together to fill in the gaps."
        'story
        Dim script33 As String = "The group leaves the courtyard, still buzzing with energy and laughter, ready to face the challenges and discoveries of their 1st year in the world of Information Technology."
        Dim script34 As String = "The journey through the first year of high school flew by, leaving “ & selectedname & “ with a treasure trove of experiences and knowledge. The initial nervousness had transformed into a sense of belonging and purpose. With each passing day, “ & selectedname & “ looked forward to the challenges and adventures that lay ahead in the dynamic world of Information Technology"

        'comlab
        Dim script35 As String = "The air in the computer lab is tense as 1st-year Information Technology students settle into their seats, each with a laptop and exam paper that contains the requirements and instructions in a website that they will be making. Professor Annaliese paces at the front of the room, ready to distribute the exams."

        'professor anne
        Dim script36 As String = "Good morning, everyone. Today's exam will cover the fundamental concepts we've discussed in the past few weeks. Please ensure your phones are switched off, and let's begin."
        Dim script37 As String = "The professor hands out the exam papers, and the room falls into a focused silence as students read through the instructions."

        'main char
        Dim script38 As String = "HTML and CSS again? Did we spend enough time on that?"
        'bff 2
        Dim script39 As String = "I hope so. That one always gets me."
        'bff 3
        Dim script40 As String = "It’s quite hard."
        'quizquiz

        'professort ana
        Dim script41 As String = "Alright, you have 90 minutes. Pace yourselves, and if you have any questions, raise your hand. Begin."

        Dim script42 As String = "The sound of tapping keyboards fills the room as the students dive into the exam, grappling with algorithms, coding problems, and theoretical concepts."

        Dim script43 As String = "Time's up. Please pass your output to our MS Teams."

        Dim script44 As String = "The students reluctantly stop typing, exchanging glances of relief, accomplishment, and perhaps a touch of anxiety about the impending results."

        'bff 3
        Dim script45 As String = "Well, that was intense. Now, let's hope we all ace it."
        Dim script46 As String = "The students gather their belongings, hand in their outputs, and exit the classroom, reflecting on the challenges and triumphs of the exam."
        Dim script47 As String = "And so, the 1st-year high school student, fueled by passion and a hunger for knowledge, continued their journey, eager to explore the ever-evolving landscape of technology and shape the future with lines of code and innovative solutions. The halls of Amethyst University echoed with the footsteps of dreamers, and “ & selectedname & “was ready to leave a mark in the world of Information Technology."

        'second year
        Dim script48 As String = "Amethyst University where two second-year college students,” & selectedname & “ and Riley found themselves knee-deep in the challenges of pursuing a bachelor's degree in information technology. As they embarked on their journey together, they discovered that the road to success in their coursework was not without its bumps"
        Dim script49 As String = "Riley, with her sharp mind for coding, and ” & selectedname & “, a tech enthusiast with a knack for staying ahead of emerging trends, were excited about the possibilities this class held. However, as the weeks went by, their excitement morphed into a sense of apprehension."

        'school front
        'main char
        Dim script50 As String = "Hey! How's it going with the information management courses this semester?"

        'Riley
        Dim script51 As String = "Hey! It's been quite intriguing. The database design class is keeping me on my toes. Have you tackled the ER diagrams and normalization stuff?"

        'main char
        Dim script52 As String = "Oh yeah, ER diagrams and normalization have become a constant in my life. I'm trying to wrap my head around the third normal form for our latest project."

        'Riley
        Dim script53 As String = "Third normal form is a beast, no doubt. But once you get it, it's like a lightbulb moment. Speaking of projects, have you started the data warehouse project for the data warehousing class?"

        'main char
        Dim script54 As String = "Yeah, we're building a small-scale data warehouse for a fictional retail company. Extracting, transforming, and loading data is proving to be more intricate than I anticipated."

        'Riley
        Dim script55 As String = "Tell me about it. I spent half the weekend figuring out the best way to optimize our data transformation processes. Are you taking any elective courses this semester?"

        'main char
        Dim script56 As String = "I'm diving into a business analytics elective. It's fascinating to see how data can be used to make strategic decisions in a business context. How about you?"

        'Riley
        Dim script57 As String = "Nice choice! I opted for a cybersecurity elective. I figure it complements our information management studies well. You never know when those skills might come in handy."

        'main char
        Dim script58 As String = "True, cybersecurity is becoming increasingly important. Hey, have you thought about potential career paths within information management?"

        'Riley
        Dim script59 As String = "I've been exploring a bit. Database administration seems interesting, but I'm also considering data analysis roles. How about you?"

        'main char
        Dim script60 As String = "I'm leaning towards data engineering or maybe a role that involves designing and optimizing databases. The idea of creating efficient data systems appeals to me."

        'Riley
        Dim script61 As String = "Smart choices. We should start looking into internships or part-time opportunities related to our interests. It's never too early to gain practical experience."

        'mainchar
        Dim script62 As String = "Totally agree. Landing a relevant internship could open a lot of doors. Have you checked out any companies yet?"

        'Riley
        Dim script63 As String = "Yeah, there are a couple of tech firms in the area that specialize in database management and analytics. Let's keep each other updated on any leads or opportunities."

        'main char
        Dim script64 As String = "Absolutely. Here's to conquering information management, acing those projects, and securing some awesome internships!"

        'Riley
        Dim script65 As String = "Let's make the most of our journey."

        'classroom
        Dim script66 As String = "The second-year information technology students sit at their designated chair, and they're getting ready for the surprise quiz. As the professor distributes the question papers, there is a noticeable sense of pressure in the room."

        'professor kenny
        Dim script67 As String = "Good morning, class! I hope you're all ready for a quiz on our information management topics. It's designed to evaluate your comprehension of the material we've covered so far. No need to panic; it's a chance to showcase what you've learned."

        'main char
        Dim script68 As String = "I hope it's not too detailed. My brain is not fully awake yet."
        'Riley
        Dim script69 As String = "Tell me about it. I barely had time to finish reviewing."
        'professor
        Dim script70 As String = "You'll be fine! Just relax and give it your best shot. Now, let’s get started"
        'pause for quiz

        Dim script71 As String = "One day, after a particularly demanding class, Riley and “ & selectedname & “ found themselves huddled in the campus library, surrounded by stacks of programming books and laptops glowing with lines of code."

        'riley
        Dim script72 As String = selectedname & “, I never thought developing mobile applications could be this challenging. The pressure is getting to me."

        Dim script73 As String = "I know what you mean, Riley. And  these emerging technologies keep throwing at us? It's like trying to catch a moving train."

        'story
        Dim script74 As String = "Their primary source of stress stemmed from the relentless stream of quizzes and exams that seemed to gauge not only their coding skills but also their ability to adapt to the ever-evolving tech landscape."
        Dim script75 As String = "As the semester progressed, Bestfriends and Selectedname found themselves in a perpetual cycle of coding, debugging, and studying for exams. The pressure mounted, and their confidence wavered as they faced challenges in understanding the intricacies of mobile application frameworks and staying abreast of the latest technological advancements."

        'coffeshop
        Dim script76 As String = "One evening, as they sat in the campus cafe, surrounded by the low hum of conversations and the aroma of freshly brewed coffee, Bestfriends sighed."

        'riley
        Dim script77 As String = "I feel like I'm drowning in code, " & selectedname & ". How are we going to make it through the upcoming exam? It's like a marathon of programming challenges"

        'mainchar
        Dim script78 As String = "sipping his coffee thoughtfully, looked at Riley with determination."
        Dim script79 As String = "We can do this, Riley. We just need to focus, prioritize, and maybe ask for help when we need it."

        'story
        Dim script80 As String = "The next day, as Riley and “ & selectedname & “ sat in the exam hall, they recalled the countless hours of hard work and determination they had invested. The questions were challenging, but their preparation and collaboration had equipped them with the skills needed to navigate the complexity of the subject."
        Dim script81 As String = "When the results were finally released, Riley and “ & selectedname & “ were overjoyed to discover that their efforts had paid off. They not only passed the exam but excelled in a subject that had initially seemed insurmountable."
        Dim script82 As String = "As they celebrated their victory in the campus hallway, Riley raised her laptop as a toast."

        'riley
        Dim script83 As String = "To overcome the code storms and emerge victorious!"
        Dim script84 As String = "We may have been pushed to our limits but look at us—we've mastered the art of coding under pressure."

        'classroomm
        Dim script85 As String = "After a particularly challenging lecture, Riley and “ & selectedname & “ sought refuge in the campus classroom, surrounded by the comforting hum of students engaged in animated conversations."

        'riley
        Dim script86 As String = "Mark, this HCI class is turning out to be more complex than I thought. I can't wrap my head around these usability principles, and the exams are just around the corner."

        'mc
        Dim script87 As String = "frowning, nodded in agreement."
        Dim script88 As String = "I feel the same, Lisa. Understanding the psychology of users and how it translates into designing effective interfaces is proving to be a real struggle. And the quizzes—don't even get me started."

        'story
        Dim script89 As String = "Their shared sentiment wasn't limited to grasping theories; the quizzes and exams in HCI seemed like a gauntlet of uncertainty, challenging their ability to apply theoretical concepts to real-world scenarios."
        Dim script90 As String = "Determined to overcome their struggles, Riley and “ & selectedname & “ decided to form a study group with classmates who shared their concerns. They gathered in the campus library, surrounded by books on user experience and interaction design, engaging in discussions that ranged from cognitive psychology to the principles of effective interface design."
        Dim script91 As String = "As the weeks passed, they found themselves working on projects that involved creating prototypes and conducting user testing. However, the stress lingered, as they questioned whether their designs truly resonated with the needs and preferences of potential users."
        Dim script92 As String = "One evening, as they huddled over a prototype in the computer lab, Riley let out a sigh."

        'riley
        Dim script93 As String = "I want our interface to be intuitive, but I'm worried we're missing “ & selectedname & “. What if our users find it confusing?"

        'mc
        Dim script94 As String = "tapping his pen thoughtfully, reassured her."
        Dim script95 As String = "We've put in the effort to understand the principles. Let's trust our instincts, conduct thorough testing, and make improvements based on feedback. We got this, Lisa."
        Dim script96 As String = "The night before the final exam, the study group gathered for a last-minute review, discussing theories, principles, and case studies. The anxiety in the room was palpable, but the support they offered each other provided a sense of camaraderie in the face of academic challenges."
        Dim script97 As String = "On the day of the exam, “ & selectedname & “ and Riley approached the questions with a newfound confidence, drawing on their shared experiences and the knowledge gained throughout the semester."
        Dim script98 As String = "When the grades were released, “ & selectedname & “ and Riley were relieved to find that their efforts had not been in vain. They had not only passed the HCI class but had also gained a deeper understanding of the delicate balance between technology and human experience."
        Dim script99 As String = "As they celebrated their victory in the campus courtyard, Lisa raised her sketchpad in a toast."

        'riley
        Dim script100 As String = "To navigate the intricate world of human-computer interaction and emerging triumphant!"

        'mc
        Dim script101 As String = "We may have faced stress and uncertainty, but in the end, we've created interfaces that don't just function but truly connect with the users."
        Dim script102 As String = "And so, with a sense of accomplishment and a shared understanding of the importance of human-computer interaction, “ & selectedname & “ and Riley continued their BSIT journey, ready to apply their newfound knowledge to create technology that not only works efficiently but also enhances the human experience."

        'third year
        'mc
        Dim script103 As String = "Ugh, this code just won't compile! I've been at it for hours."

        'bff
        Dim script104 As String = "What's going on, “ & selectedname & “? Need a hand?"
        'mc
        Dim script105 As String = "I appreciate it, Charlie, but this bug is driving me crazy. It's like there's a gremlin in my code!"
        Dim script106 As String = "Let me take a look. Sometimes fresh eyes can spot the issue."
        Dim script107 As String = "Be my guest. I've been staring at this for so long, everything looks like gibberish now."
        'pause for quiz


        'charlie
        Dim script108 As String = "Ah-ha! Found it. You're missing a semicolon here at the end of line 42."
        Dim script109 As String = "Are you serious? That tiny thing caused all this headache?"
        Dim script110 As String = "It happens to the best of us. Remember, the devil's in the details."
        Dim script111 As String = "Thanks a ton, Charlie! You saved my sanity. How can I ever repay you?"
        Dim script112 As String = "No need for repayment. Just promise me you'll be my partner for the upcoming hackathon."
        Dim script113 As String = "Deal! With your eagle eyes and my programming skills, we'll be unstoppable."

        'courtyard
        Dim script114 As String = "Hey, “ & selectedname & “! Ready for Professor Reynolds' final project presentation?"
        Dim script115 As String = "Absolutely, Alex. Charlie And I have been burning the midnight oil To make our project stand out."
        Dim script116 As String = "That's the spirit! I know you'll nail it."

        'comlab
        'prof reynolds
        Dim script117 As String = "Welcome, everyone, to the final project presentations! Our first team up is “ & selectedname & “ and Charlie. Please, begin."
        'pause for quiz

        Dim script118 As String = "Good afternoon, everyone. Our project focuses on cybersecurity measures for small businesses, aiming to create an accessible and comprehensive solution..."

        'after presentation
        'charlie
        Dim script119 As String = "Did you see the professor's reaction? I think we knocked it out of the park!"
        Dim script120 As String = "Absolutely! I couldn't have asked for a better partner."
        Dim script121 As String = "You guys killed it! The way you explained those encryption algorithms was impressive."
        Dim script122 As String = "Thanks, Alex. Couldn't have done it without your encouragement."


        Dim script123 As String = "Finals are around the corner. I hope I can manage everything."
        Dim script124 As String = "You got this, “ & selectedname & “! We've been through tougher challenges."
        Dim script125 As String = "Here, a little fuel to keep you going."
        Dim script126 As String = "Thanks, guys. I couldn't ask for better friends."
        'quiz

        'dean
        Dim script127 As String = "Congratulations to the graduating class of I.T! Especially to our exceptional student, “ & selectedname & “, who also won this year's Best Project Award!"
        Dim script128 As String = "Thank you so much, Dean! None of this would have been possible without the support of my amazing friends and mentors."
        Dim script129 As String = "We did it, “ & selectedname & “! Cheers to our bright futures in the world of technology."
        Dim script130 As String = "To “ & selectedname & ”, the genius coder and an even better friend!"

        '4th year
        Dim script131 As String = "Hi my name is “ & selectedname & “ and I'm an 4th year college student now. I am troubling with my academic and right now I need to do my best because this is the last chapter of my school, so help me to do better in my acads."
        Dim script132 As String = "I've heard a lot of fourth-year students complain that CS and IT are tough for them in their final year. Well, maybe, but there are certain things we can all relate to when we reach our final year of college because that's when we're going to be able to live out our ambitions and start making our own money, and that's also when we start to experience life in the real world..."
        Dim script133 As String = "It was our first day of school as a 4th year student and it was the first day that the teachers immediately made us do activities and quizzes, it is no longer required to introduce ourselves in the 4th year because we have known each other for so long when we're together we don't need that kind of thing anymore."

        'ms cathernie
        Dim script134 As String = "Hello everyone, Please provide one whole sheet paper and do this activity."
        'pause for quiz

        Dim script135 As String = "Ms. Renalyn Delos Reyes arrived immediately following our first subject with Ms. Cath. She explained us how to write a thesis paper, as well as how to start writing a thesis paper. "
        Dim script136 As String = "She also introduced herself to us before we discussed what we should do, and her advice for this subject is to listen carefully and cooperate with her because she claims her subject can be understood if students listen to her. She also made us take a quiz right after we finished talking and prepare an essay about how to start writing the thesis paper."
        Dim script137 As String = "Ms. Renalyn gave us a quiz after we finished the essay, but before she gave us 10 minutes to review."

        'ms renalyn
        Dim script138 As String = "Please provide a 1/4 sheet of paper and be ready for our quiz. I will give you 10 mins to review"
        'pause for quiz


        'mostly self narration
        Dim script139 As String = "We've finished school, and the day has been filled with activities and quizzes, but I'm still living in the world. I am still able to do everything that we are required to do, and I am happy that God does not leave me in moments like this, when I give up on things that I can no longer do, and I have given up multiple times because it is too difficult when I am in college."
        Dim script140 As String = "When I got home, I went straight to my room and changed my clothes. As I was getting dressed, I remembered that our homework on information assurance and security was due tomorrow, so I needed to finish it right away. "
        Dim script141 As String = "10:05 p.m. I finished eating and took a half-bath, but it was too late for me to move and accomplish the things I needed to do because it was late at night when we got out of school, which was 8:30 p.m. I'm about to begin working on our project, but it'll be 10:20 p.m. before I can begin."
        Dim script142 As String = "I went to bed right after finishing the tasks since I was so exhausted from school that I didn't realize I had fallen asleep..."
        Dim script143 As String = "Next day..."
        Dim script144 As String = "My alarm went off, and I got up to get dressed and go to school. I ate before going in, so my stomach was full, and then I left quickly to go to school."
        Dim script145 As String = "As I walked to my seat, I noticed a teacher inside our class and Sir Calintan collecting the assignment since he stated that he would be unable to attend his subject later, therefore we have a vacancy later. When our vacancy ended, Ms. Delos Reyes and I were divided into five groups since we were supposed to conduct a research article."
        Dim script146 As String = "We have already discussed our study topic, which is quite difficult because we are in our fourth year and what we will be doing is no longer normal or easy. We also reviewed the titles given by my group members, and one of our proposals was approved."
        Dim script147 As String = "I ate and rested when I arrived home. After I finished eating, I went straight to my room to start our research paper and I also chatted with our group chat because tomorrow we will defend it immediately, but no one responds to one of my chats so I suddenly "
        Dim script148 As String = "panicked and cried because what if we don't have anything to defend tomorrow so I tried to do our paper alone but I didn't finish so I immediately opened my cell phone and checked if anyone responded to my messages."

        'mc
        Dim script149 As String = "Guys, tomorrow is our defense. What do you intend to do with flowchart and methodology?"
        'khalil
        Dim script150 As String = "Here is the flowchart and methodology I created, just check if it is correct and sorry for not responding earlier, I am busy doing the flowchart and methodology."
        Dim script151 As String = "Oh, thanks Khalil. I will check this so that I can put it in our papers and guys, review what I will send later so that we won't be asked too many questions by the panelists about our defense tomorrow."

        'school
        Dim script152 As String = "We defended our research successfully, and the panels teased us a little, but we responded well and received excellent ratings, and luckily, our final defense is completed, so we can go on vacation. Our finals are finished, and we are preparing for our graduation photo shoot."
        Dim script153 As String = "And this is it the graduation day, First I would like to thank god for guiding me all this stressful life and second, thanks for my mom and dad for always supporting me. And lastly to all the teachers thank you so much for guiding and teaching us..."

        Select Case storygame
            Case 1
                storytextbox.Text = script1
                Maingamebg.Image = My.Resources.y1s3schoolfront
            Case 2
                storytextbox.Text = script2
                Maingamebg.Image = My.Resources.hallway
            Case 3
                storytextbox.Text = script3
                currentname.Text = selectedname

                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s2hallwaymale
                Else
                    Maingamebg.Image = My.Resources.y1s2hallwayfemale
                End If
            Case 4
                storytextbox.Text = script4
                currentname.Text = ""
            Case 5
                storytextbox.Text = script5
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s5schoolfrontmalefriends
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemale
                End If
            Case 6
                storytextbox.Text = script6
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s6schoolfrontmalefriends2
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend1
                End If
            Case 7
                storytextbox.Text = script7
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s7schoolfrontmalefriends3
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend2
                End If
            Case 8
                currentname.Text = "Jamie"
                storytextbox.Text = script8
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s8schoolfrontmalefriends4
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend3
                End If
            Case 9
                currentname.Text = "Gian"
                storytextbox.Text = script9
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s5schoolfrontmalefriends
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemale
                End If
            Case 10
                currentname.Text = ""
                storytextbox.Text = script10
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s3schoolfront
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfront
                End If
            Case 11
                storytextbox.Text = script11
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s9comlab
                Else
                    Maingamebg.Image = My.Resources.y1s9comlab
                End If
            Case 12
                currentname.Text = selectedname
                storytextbox.Text = script12
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s10comlabmalebff1
                Else
                    Maingamebg.Image = My.Resources.y1s4femalefriend1
                End If
            Case 13
                currentname.Text = "France"
                storytextbox.Text = script13
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s10comlabmalebff1
                Else

                End If
            Case 14
                currentname.Text = ""
                storytextbox.Text = script14
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s11bedroom
                Else
                    Maingamebg.Image = My.Resources.femaleroom
                End If

                'discord
            Case 15
                currentname.Text = selectedname
                storytextbox.Text = script15
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s13maledc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleroom
                End If
            Case 16
                currentname.Text = "Gian"
                storytextbox.Text = script16
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s14bff
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleandfriend1
                End If
            Case 17
                currentname.Text = selectedname
                storytextbox.Text = script17
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s13maledc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleroom
                End If
            Case 18
                currentname.Text = "Gian"
                storytextbox.Text = script18
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s14bff
                Else
                    Maingamebg.Image = My.Resources.yr1s6femalefriend1roomdiscord
                End If
            Case 19
                currentname.Text = ""
                storytextbox.Text = script19
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s15malebffdc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleandfriend1
                End If
            Case 20
                storytextbox.Text = script20
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s16classroom
                Else
                    Maingamebg.Image = My.Resources.y1s16classroom
                End If
            Case 21
                currentname.Text = "Professor Jax"
                storytextbox.Text = script21
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s17classteacher
                Else
                    Maingamebg.Image = My.Resources.y1s17classteacher
                End If
            Case 22
                currentname.Text = selectedname
                storytextbox.Text = script22
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s18malebffclassroom
                Else
                    Maingamebg.Image = My.Resources.y1s4femalefriend1
                End If
            Case 23
                storytextbox.Text = script23
                currentname.Text = "Jamie"
            Case 24
                CollegeSim.SelectedTab = Quiztab
                storytextbox.Text = script24
                quizcount = 1
                autoplaymode.Stop()

                Autoplay.Text = "stop"

                If Autoplay.Text = "autoplay" Then
                    Autoplay.Text = "stop"
                    autoplaymode.Start()
                Else
                    Autoplay.Text = "autoplay"
                    autoplaymode.Stop()
                End If
                Select Case quizcount
                    Case 1
                        'quiz
                        quizq1.Text = "What does IT stands for?"
                        quizq2.Text = "Which term refers to the process of converting human-readable code into machine-readable code?"
                        quizq3.Text = "The acronym URL stands for "
                        quizq4.Text = "Binary code is the fundamental language that computers use to process information, using only two digits:"
                        quizq5.Text = "Is a self-replicating program that spreads by inserting copies of itself into other executable code."

                        'quiz choices
                        'q1
                        q1ans1.Text = "Information Technology"
                        q1ans2.Text = "Information Tools"
                        q1ans3.Text = "Intelligent Technology"
                        'q2
                        q2ans1.Text = "Compilation"
                        q2ans2.Text = "Encryption"
                        q2ans3.Text = "Execution"
                        'q3
                        q3ans1.Text = "Unified Resource Locator"
                        q3ans2.Text = "Uniform Resource Langguage"
                        q3ans3.Text = "Uniform Resource Locator"
                        'q4
                        q4ans1.Text = "1s and 0s"
                        q4ans2.Text = "2s and 20s"
                        q4ans3.Text = "0s and 2s"
                        'q5
                        q5ans1.Text = "Virus"
                        q5ans2.Text = "Covid"
                        q5ans3.Text = "Flu"
                End Select
            Case 25
                storytextbox.Text = script25
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s20courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s20courtyard
                End If
            Case 26
                storytextbox.Text = script26
                currentname.Text = "Gian"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s21malebff1courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend1
                End If
            Case 27
                storytextbox.Text = script27
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s22malebff2courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend2
                End If
            Case 28
                storytextbox.Text = script28
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s22malebff2courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female3
                End If
            Case 29
                storytextbox.Text = script29
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s23malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend4
                End If
            Case 30
                storytextbox.Text = script30
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s24malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female5
                End If
            Case 31
                storytextbox.Text = script31
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s25malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female5
                End If
            Case 32
                storytextbox.Text = script32
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s20courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s20courtyard
                End If
            Case 33
                storytextbox.Text = script33
            Case 34
                storytextbox.Text = script34

                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s28comlab
                Else
                    Maingamebg.Image = My.Resources.y1s9comlab
                End If
            Case 35
                storytextbox.Text = script35
                currentname.Text = "Professor Annaliese"
                Maingamebg.Image = My.Resources.y1s29comlabteacher
            Case 36
                storytextbox.Text = script36
                currentname.Text = ""
            Case 37
                storytextbox.Text = script37
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s30malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 38
                storytextbox.Text = script38
                currentname.Text = "France"
            Case 39
                storytextbox.Text = script39
                currentname.Text = selectedname

               'quiz time
            Case 40
                storytextbox.Text = script40
                currentname.Text = "France"
                Maingamebg.Image = My.Resources.y1s35teachercomlab

            Case 41
                storytextbox.Text = script41
                Maingamebg.Image = My.Resources.y1s28comlab
            Case 42
                storytextbox.Text = script42
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s30malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 43
                storytextbox.Text = script43
            Case 44
                Maingamebg.Image = My.Resources.y1s28comlab
                storytextbox.Text = script44
            Case 45
                storytextbox.Text = script45

                Maingamebg.Image = My.Resources.y1s29comlabteacher
            Case 46
                currentname.Text = "Professor Annaliese"
                storytextbox.Text = script46
                Maingamebg.Image = My.Resources.y1s28comlab
            Case 47
                storytextbox.Text = script47
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s36malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 48
                storytextbox.Text = script48
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s36malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s10female_friends
                End If
            Case 49
                Maingamebg.Image = My.Resources.y1s20courtyard
                storytextbox.Text = script49
            Case 50
                storytextbox.Text = script50

                'second year
            Case 51
                storytextbox.Text = script51
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3malebffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                End If
            Case 52
                storytextbox.Text = script52
            Case 53
                storytextbox.Text = script53
                currentname.Text = selectedname
            Case 54
                storytextbox.Text = script54
                currentname.Text = "Riley"
            Case 55
                storytextbox.Text = script55
                currentname.Text = selectedname
            Case 56
                storytextbox.Text = script56
                currentname.Text = "Riley"
            Case 57
                storytextbox.Text = script57
                currentname.Text = selectedname
            Case 58
                storytextbox.Text = script58
                currentname.Text = "Riley"
            Case 59
                storytextbox.Text = script59
                currentname.Text = selectedname
            Case 60
                storytextbox.Text = script60
                currentname.Text = "Riley"
            Case 61
                storytextbox.Text = script61
                currentname.Text = selectedname
            Case 62
                storytextbox.Text = script62
                currentname.Text = "Riley"
            Case 63
                storytextbox.Text = script63
                currentname.Text = selectedname
            Case 64
                storytextbox.Text = script64
                currentname.Text = "Riley"
            Case 65
                storytextbox.Text = script65
                currentname.Text = selectedname
            Case 66
                storytextbox.Text = script66
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd5bffclassroom
                Else
                    Maingamebg.Image = My.Resources.y2nd5bffclassroom
                End If
            Case 67
                storytextbox.Text = script67
                currentname.Text = "Professor Kenny"
                Maingamebg.Image = My.Resources.y1s17classteacher
            Case 68
                storytextbox.Text = script68
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd1girlbffclassroom
                Else
                    Maingamebg.Image = My.Resources.y2nd5girlbffclassroom
                End If
            Case 69
                storytextbox.Text = script69
                currentname.Text = "Riley"
            Case 70
                storytextbox.Text = script70
                currentname.Text = "Professor Kenny"

                'quiz time
            Case 71
                storytextbox.Text = script71

            Case 72
                storytextbox.Text = script72
                currentname.Text = "Riley"
            Case 73
                storytextbox.Text = script73
                currentname.Text = selectedname
            Case 74
                storytextbox.Text = script74
                currentname.Text = ""
            Case 75
                storytextbox.Text = script75

            Case 76
                storytextbox.Text = script76
            Case 77
                storytextbox.Text = script77
                currentname.Text = "Riley"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd2malebffcoffeshop
                Else
                    Maingamebg.Image = My.Resources.y2nd6girlbffcoffeeshop
                End If
            Case 78
                storytextbox.Text = script78
            Case 79
                storytextbox.Text = script79
                currentname.Text = selectedname
            Case 80
                storytextbox.Text = script80
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd4girlbfflibrary
                Else
                    Maingamebg.Image = My.Resources.y2nd8girlbfflibrary
                End If
            Case 81
                storytextbox.Text = script81
            Case 82
                storytextbox.Text = script82
            Case 83
                storytextbox.Text = script83
                currentname.Text = "Riley"
            Case 84
                storytextbox.Text = script84
                currentname.Text = selectedname
            Case 85
                storytextbox.Text = script85
                currentname.Text = ""
            Case 86
                storytextbox.Text = script86
                currentname.Text = "Riley"
            Case 87
                storytextbox.Text = script87
                currentname.Text = selectedname
            Case 88
                storytextbox.Text = script88
            Case 89
                storytextbox.Text = script89
                currentname.Text = ""
            Case 90
                storytextbox.Text = script90
            Case 91
                storytextbox.Text = script91
            Case 92
                storytextbox.Text = script92
            Case 93
                storytextbox.Text = script93
                currentname.Text = "Riley"
            Case 94
                storytextbox.Text = script94
                currentname.Text = selectedname
            Case 95
                storytextbox.Text = script95
            Case 96
                storytextbox.Text = script96
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_his_room
                Else
                    Maingamebg.Image = My.Resources.girl_in_her_room
                End If
            Case 97
                storytextbox.Text = script97
            Case 98
                storytextbox.Text = script98
            Case 99
                storytextbox.Text = script99
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd9girlbffschoolfront
                End If
            Case 100
                storytextbox.Text = script100
                currentname.Text = "Riley"
            Case 101
                storytextbox.Text = script101
                currentname.Text = selectedname
            Case 102
                storytextbox.Text = script102
                currentname.Text = ""
                Maingamebg.Image = My.Resources.y1s3schoolfront
            Case 103
                storytextbox.Text = script103
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s18malebffclassroom
                Else
                    Maingamebg.Image = My.Resources.y1s9femalefriend2
                End If
            Case 104
                storytextbox.Text = script104
                currentname.Text = "Charlie"
            Case 105
                storytextbox.Text = script105
                currentname.Text = selectedname
            Case 106
                storytextbox.Text = script106
                currentname.Text = "Charlie"
            Case 107
                storytextbox.Text = script107
                currentname.Text = selectedname

                'quiz pause
            Case 108
                storytextbox.Text = script108
                currentname.Text = "Charlie"
            Case 109
                storytextbox.Text = script109
                currentname.Text = selectedname
            Case 110
                storytextbox.Text = script110
                currentname.Text = "Charlie"
            Case 111
                storytextbox.Text = script111
                currentname.Text = selectedname
            Case 112
                storytextbox.Text = script112
                currentname.Text = "Charlie"
            Case 113
                storytextbox.Text = script113
                currentname.Text = selectedname

                'courtyard
            Case 114
                storytextbox.Text = script114
                currentname.Text = "Alex"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd9girlbffschoolfront
                End If
            Case 115
                storytextbox.Text = script115
                currentname.Text = selectedname
            Case 116
                currentname.Text = "Alex"
                storytextbox.Text = script116
            Case 117
                storytextbox.Text = script117
                currentname.Text = "Professor Ray"
                Maingamebg.Image = My.Resources.y1s29comlabteacher

                'quiz
            Case 118
                storytextbox.Text = script118
            Case 119
                storytextbox.Text = script119
                currentname.Text = "Charlie"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y3male2bff
                Else
                    Maingamebg.Image = My.Resources.y3female2bff
                End If
            Case 120
                storytextbox.Text = script120
                currentname.Text = selectedname
            Case 121
                storytextbox.Text = script121
                currentname.Text = "Alex"
            Case 122
                storytextbox.Text = script122
                currentname.Text = selectedname
            Case 123
                storytextbox.Text = script123
                currentname.Text = selectedname
            Case 124
                storytextbox.Text = script124
                currentname.Text = "Charlie"
            Case 125
                storytextbox.Text = script125
                currentname.Text = "Alex"
            Case 126
                storytextbox.Text = script126
                currentname.Text = selectedname

                'grad

            Case 127
                storytextbox.Text = script127
                currentname.Text = "Dean"
                Maingamebg.Image = My.Resources.y1s16classroom
            Case 128
                storytextbox.Text = script128
                currentname.Text = selectedname
            Case 129
                storytextbox.Text = script129
                currentname.Text = "Charlie"
            Case 130
                storytextbox.Text = script130
                currentname.Text = "Alex"
            Case 131
                storytextbox.Text = script131
                If selectedname = "Miyuki" Then
                    currentname.Text = selectedname
                    Maingamebg.Image = My.Resources.boy_with_his_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_with_her_classmate
                End If
            Case 132
                storytextbox.Text = script132
            Case 133
                storytextbox.Text = script133
            Case 134
                currentname.Text = "Ms. Catherine"
                storytextbox.Text = script134
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_his_teacher_natural_language_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_natural_languange_classmate_comlab
                End If

                'quiztime
            Case 135
                storytextbox.Text = script135
                currentname.Text = ""
            Case 136
                storytextbox.Text = script136
            Case 137
                storytextbox.Text = script137
            Case 138
                storytextbox.Text = script138
                currentname.Text = "Ms. Renalyn"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_teacher_in_research_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_in_research_classmate
                End If
            Case 139
                storytextbox.Text = script139
                currentname.Text = selectedname
            Case 140
                storytextbox.Text = script140
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_his_room
                Else
                    Maingamebg.Image = My.Resources.girl_in_her_room
                End If
            Case 141
                storytextbox.Text = script141
            Case 142
                storytextbox.Text = script142
            Case 143
                currentname.Text = ""
                storytextbox.Text = script143
            Case 144
                storytextbox.Text = script144
                currentname.Text = selectedname
            Case 145
                storytextbox.Text = script145
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_hallway
                Else
                    Maingamebg.Image = My.Resources.girl_hallway
                End If
            Case 146
                storytextbox.Text = script146
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_teacher_in_research_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_in_research_classmate
                End If
            Case 147
                storytextbox.Text = script147
            Case 148
                storytextbox.Text = script148
            Case 149
                storytextbox.Text = script149
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_his_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_with_her_classmate
                End If
            Case 150
                storytextbox.Text = script150
                currentname.Text = "Khalil"
            Case 151
                storytextbox.Text = script151
                currentname.Text = selectedname
            Case 152
                storytextbox.Text = script152
            Case 153
                storytextbox.Text = script153

                Autoplay.Text = "stop"
                MessageBox.Show("Congratulations on completing the game!", "Thank you", MessageBoxButtons.OK)
        End Select
    End Sub

    Private Sub storytextbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'click anywhere to continue dialogue
    Private Sub Maingamebg_Click(sender As Object, e As EventArgs) Handles Maingamebg.Click
        storygame += 1

        Dim chargender As String = selectedcharacter.Text

        Dim selectedname As String

        Dim currentchar As String = ""

        If selectedcharacter.Text = "Miyuki" Then
            selectedname = "Miyuki"
        Else
            selectedname = "Sayori"
        End If

        'script story

        Dim script1 As String = "In the bustling city of Laguna there lived a bright and curious 1st-year high school student named " & selectedname & ". " & selectedname & " had always been fascinated by the world of technology. When it came time to choose a specialization for high school, there was no doubt in his mind – it had to be the Bachelor of Science in Information Technology program."
        Dim script2 As String = “Excitement bubbled within ” & selectedname & “ as the first day of high school approached. The campus was in a modern structure, with big glass windows. As ” & selectedname & “ entered the hallowed halls of Amethyst University a sense of anticipation and nervousness mingled in the air.”

        'main char
        Dim script3 As String = “So this is what college looks like. Time to get serious self. Okay, deep breaths, “ & selectedname & “. You got this. Just open the door, find a seat, and act normally.”

        'story
        Dim script4 As String = selectedname & “ took a moment to collect himself before approaching the front door. The classroom is abuzz with chatter as new students find their seats.”
        Dim script5 As String = "The first few weeks were a whirlwind of new faces, challenging classes, and the excitement of diving into Information Technology. “ & selectedname & “ found himself in a diverse group of classmates, all passionate about the endless possibilities the digital world offered. "

        'IN THE SCHOOL FRONT - MORNING
        'Bff 3
        Dim script6 As String = "Did you guys see the news about the new coding boot camp opening downtown? I'm seriously considering it."

        'main char
        Dim script7 As String = "Yeah, coding is the future. I heard they're incorporating AI and machine "

        'bff 1
        Dim script8 As String = "Cybersecurity is my jam! I attended a webinar last night, and they discussed the latest trends. It's scary how vulnerable we can be online."

        'bff 2
        Dim script9 As String = "You should check out this article about quantum computing. It might change the game in cybersecurity."

        'story
        Dim script10 As String = "The introductory courses covered the basics and the majors of programming, units for Purposive communication, Philippine history, Filipino, and Mathematics in the  Modern World."

        'COMPUTER LAB - AFTERNOON
        'story
        Dim script11 As String = selectedname & "'s eyes sparkled with enthusiasm as they wrote their first lines of code, realizing the power of turning ideas into tangible programs."

        'main char
        Dim script12 As String = "Woah! This is so cool! I want to learn more about programming."

        'bff 3
        Dim script13 As String = "Me too!"

        'main char room - evening
        Dim script14 As String = selectedname & “ encountered both challenges and triumphs. Late-night coding sessions became a routine, and group projects forged lasting friendships. The camaraderie among the IT students was palpable, as they collaborated on projects that ranged from developing simple websites to designing apps that provide solutions."

        'DISCORD [group chat]
        'main char
        Dim script15 As String = "This program is driving me crazy! I can't figure out where I went wrong"

        'bff 2
        Dim script16 As String = "Let me take a look. Ah, right here. You missed a semicolon. It happens to the best of us."

        'main char
        Dim script17 As String = "Thanks, Grian! You're a lifesaver. How did you become so good at this stuff?"

        'bff/grian
        Dim script18 As String = "Well, it's all about practice and not being afraid to make mistakes. Coding is like solving puzzles. The more you do, the better you get."

        'story
        Dim script19 As String = "Together, they tackled the challenge with passion, creativity, and a dash of sleep deprivation."
        'CLASSROOM - MORNING
        Dim script20 As String = "The 1st-year Information Technology students sit at their desks, laptops open, ready for a surprise quiz. The tension in the air is palpable as the professor hands out the question papers."

        'professor jax
        Dim script21 As String = "Alright, everyone, time for a quick pop quiz to test your knowledge. No need to stress, just show what you've learned so far."

        'main char to bff 1
        Dim script22 As String = "Did you review the lessons we studied last week?"

        'bff1
        Dim script23 As String = "I did, but I'm not sure I remember all of them. This could be challenging."

        'pause for quiz
        Dim script24 As String = "The clock ticked relentlessly, but they persevered, drawing on their collective knowledge and skills. In the end, they finished the quiz on time. The professor dismissed the class. "

        'campus courtyard lunch
        Dim script25 As String = "Underneath a vibrant blue sky, “ & selectedname & “ ,  Cory, France, and Grian gather on a bench near the campus courtyard, eagerly discussing the quiz they've just taken."

        'bff2
        Dim script26 As String = "That quiz was something Else, right? I didn't expect so many multithreading questions."
        'bff3
        Dim script27 As String = "Seriously, En! Some of the questions threw me off."
        'mainchar
        Dim script28 As String = "I completely blanked on that URL acronym. Embarrassing, considering we've all typed a million of them."
        'bff1
        Dim script29 As String = "I won't lie, I had a moment of panic with the encryption question. Thank goodness I remembered my ciphers."
        'main char
        Dim script30 As String = "True, true. But hey, at least it covered a bit of everything. Networking, programming, security — it's like a crash course in one quiz."
        'bff 3
        Dim script31 As String = "And it's just the beginning, right? We're here to learn, and quizzes like these keep us on our toes."
        'bff 2
        Dim script32 As String = "Absolutely. Keeps the brain cells alive. Plus, we can always study together to fill in the gaps."
        'story
        Dim script33 As String = "The group leaves the courtyard, still buzzing with energy and laughter, ready to face the challenges and discoveries of their 1st year in the world of Information Technology."
        Dim script34 As String = "The journey through the first year of high school flew by, leaving “ & selectedname & “ with a treasure trove of experiences and knowledge. The initial nervousness had transformed into a sense of belonging and purpose. With each passing day, “ & selectedname & “ looked forward to the challenges and adventures that lay ahead in the dynamic world of Information Technology"

        'comlab
        Dim script35 As String = "The air in the computer lab is tense as 1st-year Information Technology students settle into their seats, each with a laptop and exam paper that contains the requirements and instructions in a website that they will be making. Professor Annaliese paces at the front of the room, ready to distribute the exams."

        'professor anne
        Dim script36 As String = "Good morning, everyone. Today's exam will cover the fundamental concepts we've discussed in the past few weeks. Please ensure your phones are switched off, and let's begin."
        Dim script37 As String = "The professor hands out the exam papers, and the room falls into a focused silence as students read through the instructions."

        'main char
        Dim script38 As String = "HTML and CSS again? Did we spend enough time on that?"
        'bff 2
        Dim script39 As String = "I hope so. That one always gets me."
        'bff 3
        Dim script40 As String = "It’s quite hard."
        'quizquiz

        'professort ana
        Dim script41 As String = "Alright, you have 90 minutes. Pace yourselves, and if you have any questions, raise your hand. Begin."

        Dim script42 As String = "The sound of tapping keyboards fills the room as the students dive into the exam, grappling with algorithms, coding problems, and theoretical concepts."

        Dim script43 As String = "Time's up. Please pass your output to our MS Teams."

        Dim script44 As String = "The students reluctantly stop typing, exchanging glances of relief, accomplishment, and perhaps a touch of anxiety about the impending results."

        'bff 3
        Dim script45 As String = "Well, that was intense. Now, let's hope we all ace it."
        Dim script46 As String = "The students gather their belongings, hand in their outputs, and exit the classroom, reflecting on the challenges and triumphs of the exam."
        Dim script47 As String = "And so, the 1st-year high school student, fueled by passion and a hunger for knowledge, continued their journey, eager to explore the ever-evolving landscape of technology and shape the future with lines of code and innovative solutions. The halls of Amethyst University echoed with the footsteps of dreamers, and “ & selectedname & “was ready to leave a mark in the world of Information Technology."

        'second year
        Dim script48 As String = "Amethyst University where two second-year college students,” & selectedname & “ and Riley found themselves knee-deep in the challenges of pursuing a bachelor's degree in information technology. As they embarked on their journey together, they discovered that the road to success in their coursework was not without its bumps"
        Dim script49 As String = "Riley, with her sharp mind for coding, and ” & selectedname & “, a tech enthusiast with a knack for staying ahead of emerging trends, were excited about the possibilities this class held. However, as the weeks went by, their excitement morphed into a sense of apprehension."

        'school front
        'main char
        Dim script50 As String = "Hey! How's it going with the information management courses this semester?"

        'Riley
        Dim script51 As String = "Hey! It's been quite intriguing. The database design class is keeping me on my toes. Have you tackled the ER diagrams and normalization stuff?"

        'main char
        Dim script52 As String = "Oh yeah, ER diagrams and normalization have become a constant in my life. I'm trying to wrap my head around the third normal form for our latest project."

        'Riley
        Dim script53 As String = "Third normal form is a beast, no doubt. But once you get it, it's like a lightbulb moment. Speaking of projects, have you started the data warehouse project for the data warehousing class?"

        'main char
        Dim script54 As String = "Yeah, we're building a small-scale data warehouse for a fictional retail company. Extracting, transforming, and loading data is proving to be more intricate than I anticipated."

        'Riley
        Dim script55 As String = "Tell me about it. I spent half the weekend figuring out the best way to optimize our data transformation processes. Are you taking any elective courses this semester?"

        'main char
        Dim script56 As String = "I'm diving into a business analytics elective. It's fascinating to see how data can be used to make strategic decisions in a business context. How about you?"

        'Riley
        Dim script57 As String = "Nice choice! I opted for a cybersecurity elective. I figure it complements our information management studies well. You never know when those skills might come in handy."

        'main char
        Dim script58 As String = "True, cybersecurity is becoming increasingly important. Hey, have you thought about potential career paths within information management?"

        'Riley
        Dim script59 As String = "I've been exploring a bit. Database administration seems interesting, but I'm also considering data analysis roles. How about you?"

        'main char
        Dim script60 As String = "I'm leaning towards data engineering or maybe a role that involves designing and optimizing databases. The idea of creating efficient data systems appeals to me."

        'Riley
        Dim script61 As String = "Smart choices. We should start looking into internships or part-time opportunities related to our interests. It's never too early to gain practical experience."

        'mainchar
        Dim script62 As String = "Totally agree. Landing a relevant internship could open a lot of doors. Have you checked out any companies yet?"

        'Riley
        Dim script63 As String = "Yeah, there are a couple of tech firms in the area that specialize in database management and analytics. Let's keep each other updated on any leads or opportunities."

        'main char
        Dim script64 As String = "Absolutely. Here's to conquering information management, acing those projects, and securing some awesome internships!"

        'Riley
        Dim script65 As String = "Let's make the most of our journey."

        'classroom
        Dim script66 As String = "The second-year information technology students sit at their designated chair, and they're getting ready for the surprise quiz. As the professor distributes the question papers, there is a noticeable sense of pressure in the room."

        'professor kenny
        Dim script67 As String = "Good morning, class! I hope you're all ready for a quiz on our information management topics. It's designed to evaluate your comprehension of the material we've covered so far. No need to panic; it's a chance to showcase what you've learned."

        'main char
        Dim script68 As String = "I hope it's not too detailed. My brain is not fully awake yet."
        'Riley
        Dim script69 As String = "Tell me about it. I barely had time to finish reviewing."
        'professor
        Dim script70 As String = "You'll be fine! Just relax and give it your best shot. Now, let’s get started"
        'pause for quiz

        Dim script71 As String = "One day, after a particularly demanding class, Riley and “ & selectedname & “ found themselves huddled in the campus library, surrounded by stacks of programming books and laptops glowing with lines of code."

        'riley
        Dim script72 As String = selectedname & “, I never thought developing mobile applications could be this challenging. The pressure is getting to me."

        Dim script73 As String = "I know what you mean, Riley. And  these emerging technologies keep throwing at us? It's like trying to catch a moving train."

        'story
        Dim script74 As String = "Their primary source of stress stemmed from the relentless stream of quizzes and exams that seemed to gauge not only their coding skills but also their ability to adapt to the ever-evolving tech landscape."
        Dim script75 As String = "As the semester progressed, Bestfriends and Selectedname found themselves in a perpetual cycle of coding, debugging, and studying for exams. The pressure mounted, and their confidence wavered as they faced challenges in understanding the intricacies of mobile application frameworks and staying abreast of the latest technological advancements."

        'coffeshop
        Dim script76 As String = "One evening, as they sat in the campus cafe, surrounded by the low hum of conversations and the aroma of freshly brewed coffee, Bestfriends sighed."

        'riley
        Dim script77 As String = "I feel like I'm drowning in code, " & selectedname & ". How are we going to make it through the upcoming exam? It's like a marathon of programming challenges"

        'mainchar
        Dim script78 As String = "sipping his coffee thoughtfully, looked at Riley with determination."
        Dim script79 As String = "We can do this, Riley. We just need to focus, prioritize, and maybe ask for help when we need it."

        'story
        Dim script80 As String = "The next day, as Riley and “ & selectedname & “ sat in the exam hall, they recalled the countless hours of hard work and determination they had invested. The questions were challenging, but their preparation and collaboration had equipped them with the skills needed to navigate the complexity of the subject."
        Dim script81 As String = "When the results were finally released, Riley and “ & selectedname & “ were overjoyed to discover that their efforts had paid off. They not only passed the exam but excelled in a subject that had initially seemed insurmountable."
        Dim script82 As String = "As they celebrated their victory in the campus hallway, Riley raised her laptop as a toast."

        'riley
        Dim script83 As String = "To overcome the code storms and emerge victorious!"
        Dim script84 As String = "We may have been pushed to our limits but look at us—we've mastered the art of coding under pressure."

        'classroomm
        Dim script85 As String = "After a particularly challenging lecture, Riley and “ & selectedname & “ sought refuge in the campus classroom, surrounded by the comforting hum of students engaged in animated conversations."

        'riley
        Dim script86 As String = "Mark, this HCI class is turning out to be more complex than I thought. I can't wrap my head around these usability principles, and the exams are just around the corner."

        'mc
        Dim script87 As String = "frowning, nodded in agreement."
        Dim script88 As String = "I feel the same, Lisa. Understanding the psychology of users and how it translates into designing effective interfaces is proving to be a real struggle. And the quizzes—don't even get me started."

        'story
        Dim script89 As String = "Their shared sentiment wasn't limited to grasping theories; the quizzes and exams in HCI seemed like a gauntlet of uncertainty, challenging their ability to apply theoretical concepts to real-world scenarios."
        Dim script90 As String = "Determined to overcome their struggles, Riley and “ & selectedname & “ decided to form a study group with classmates who shared their concerns. They gathered in the campus library, surrounded by books on user experience and interaction design, engaging in discussions that ranged from cognitive psychology to the principles of effective interface design."
        Dim script91 As String = "As the weeks passed, they found themselves working on projects that involved creating prototypes and conducting user testing. However, the stress lingered, as they questioned whether their designs truly resonated with the needs and preferences of potential users."
        Dim script92 As String = "One evening, as they huddled over a prototype in the computer lab, Riley let out a sigh."

        'riley
        Dim script93 As String = "I want our interface to be intuitive, but I'm worried we're missing “ & selectedname & “. What if our users find it confusing?"

        'mc
        Dim script94 As String = "tapping his pen thoughtfully, reassured her."
        Dim script95 As String = "We've put in the effort to understand the principles. Let's trust our instincts, conduct thorough testing, and make improvements based on feedback. We got this, Lisa."
        Dim script96 As String = "The night before the final exam, the study group gathered for a last-minute review, discussing theories, principles, and case studies. The anxiety in the room was palpable, but the support they offered each other provided a sense of camaraderie in the face of academic challenges."
        Dim script97 As String = "On the day of the exam, “ & selectedname & “ and Riley approached the questions with a newfound confidence, drawing on their shared experiences and the knowledge gained throughout the semester."
        Dim script98 As String = "When the grades were released, “ & selectedname & “ and Riley were relieved to find that their efforts had not been in vain. They had not only passed the HCI class but had also gained a deeper understanding of the delicate balance between technology and human experience."
        Dim script99 As String = "As they celebrated their victory in the campus courtyard, Lisa raised her sketchpad in a toast."

        'riley
        Dim script100 As String = "To navigate the intricate world of human-computer interaction and emerging triumphant!"

        'mc
        Dim script101 As String = "We may have faced stress and uncertainty, but in the end, we've created interfaces that don't just function but truly connect with the users."
        Dim script102 As String = "And so, with a sense of accomplishment and a shared understanding of the importance of human-computer interaction, “ & selectedname & “ and Riley continued their BSIT journey, ready to apply their newfound knowledge to create technology that not only works efficiently but also enhances the human experience."

        'third year
        'mc
        Dim script103 As String = "Ugh, this code just won't compile! I've been at it for hours."

        'bff
        Dim script104 As String = "What's going on, “ & selectedname & “? Need a hand?"
        'mc
        Dim script105 As String = "I appreciate it, Charlie, but this bug is driving me crazy. It's like there's a gremlin in my code!"
        Dim script106 As String = "Let me take a look. Sometimes fresh eyes can spot the issue."
        Dim script107 As String = "Be my guest. I've been staring at this for so long, everything looks like gibberish now."
        'pause for quiz


        'charlie
        Dim script108 As String = "Ah-ha! Found it. You're missing a semicolon here at the end of line 42."
        Dim script109 As String = "Are you serious? That tiny thing caused all this headache?"
        Dim script110 As String = "It happens to the best of us. Remember, the devil's in the details."
        Dim script111 As String = "Thanks a ton, Charlie! You saved my sanity. How can I ever repay you?"
        Dim script112 As String = "No need for repayment. Just promise me you'll be my partner for the upcoming hackathon."
        Dim script113 As String = "Deal! With your eagle eyes and my programming skills, we'll be unstoppable."

        'courtyard
        Dim script114 As String = "Hey, “ & selectedname & “! Ready for Professor Reynolds' final project presentation?"
        Dim script115 As String = "Absolutely, Alex. Charlie And I have been burning the midnight oil To make our project stand out."
        Dim script116 As String = "That's the spirit! I know you'll nail it."

        'comlab
        'prof reynolds
        Dim script117 As String = "Welcome, everyone, to the final project presentations! Our first team up is “ & selectedname & “ and Charlie. Please, begin."
        'pause for quiz

        Dim script118 As String = "Good afternoon, everyone. Our project focuses on cybersecurity measures for small businesses, aiming to create an accessible and comprehensive solution..."

        'after presentation
        'charlie
        Dim script119 As String = "Did you see the professor's reaction? I think we knocked it out of the park!"
        Dim script120 As String = "Absolutely! I couldn't have asked for a better partner."
        Dim script121 As String = "You guys killed it! The way you explained those encryption algorithms was impressive."
        Dim script122 As String = "Thanks, Alex. Couldn't have done it without your encouragement."


        Dim script123 As String = "Finals are around the corner. I hope I can manage everything."
        Dim script124 As String = "You got this, “ & selectedname & “! We've been through tougher challenges."
        Dim script125 As String = "Here, a little fuel to keep you going."
        Dim script126 As String = "Thanks, guys. I couldn't ask for better friends."
        'quiz

        'dean
        Dim script127 As String = "Congratulations to the graduating class of I.T! Especially to our exceptional student, “ & selectedname & “, who also won this year's Best Project Award!"
        Dim script128 As String = "Thank you so much, Dean! None of this would have been possible without the support of my amazing friends and mentors."
        Dim script129 As String = "We did it, “ & selectedname & “! Cheers to our bright futures in the world of technology."
        Dim script130 As String = "To “ & selectedname & ”, the genius coder and an even better friend!"

        '4th year
        Dim script131 As String = "Hi my name is “ & selectedname & “ and I'm an 4th year college student now. I am troubling with my academic and right now I need to do my best because this is the last chapter of my school, so help me to do better in my acads."
        Dim script132 As String = "I've heard a lot of fourth-year students complain that CS and IT are tough for them in their final year. Well, maybe, but there are certain things we can all relate to when we reach our final year of college because that's when we're going to be able to live out our ambitions and start making our own money, and that's also when we start to experience life in the real world..."
        Dim script133 As String = "It was our first day of school as a 4th year student and it was the first day that the teachers immediately made us do activities and quizzes, it is no longer required to introduce ourselves in the 4th year because we have known each other for so long when we're together we don't need that kind of thing anymore."

        'ms cathernie
        Dim script134 As String = "Hello everyone, Please provide one whole sheet paper and do this activity."
        'pause for quiz

        Dim script135 As String = "Ms. Renalyn Delos Reyes arrived immediately following our first subject with Ms. Cath. She explained us how to write a thesis paper, as well as how to start writing a thesis paper. "
        Dim script136 As String = "She also introduced herself to us before we discussed what we should do, and her advice for this subject is to listen carefully and cooperate with her because she claims her subject can be understood if students listen to her. She also made us take a quiz right after we finished talking and prepare an essay about how to start writing the thesis paper."
        Dim script137 As String = "Ms. Renalyn gave us a quiz after we finished the essay, but before she gave us 10 minutes to review."

        'ms renalyn
        Dim script138 As String = "Please provide a 1/4 sheet of paper and be ready for our quiz. I will give you 10 mins to review"
        'pause for quiz


        'mostly self narration
        Dim script139 As String = "We've finished school, and the day has been filled with activities and quizzes, but I'm still living in the world. I am still able to do everything that we are required to do, and I am happy that God does not leave me in moments like this, when I give up on things that I can no longer do, and I have given up multiple times because it is too difficult when I am in college."
        Dim script140 As String = "When I got home, I went straight to my room and changed my clothes. As I was getting dressed, I remembered that our homework on information assurance and security was due tomorrow, so I needed to finish it right away. "
        Dim script141 As String = "10:05 p.m. I finished eating and took a half-bath, but it was too late for me to move and accomplish the things I needed to do because it was late at night when we got out of school, which was 8:30 p.m. I'm about to begin working on our project, but it'll be 10:20 p.m. before I can begin."
        Dim script142 As String = "I went to bed right after finishing the tasks since I was so exhausted from school that I didn't realize I had fallen asleep..."
        Dim script143 As String = "Next day..."
        Dim script144 As String = "My alarm went off, and I got up to get dressed and go to school. I ate before going in, so my stomach was full, and then I left quickly to go to school."
        Dim script145 As String = "As I walked to my seat, I noticed a teacher inside our class and Sir Calintan collecting the assignment since he stated that he would be unable to attend his subject later, therefore we have a vacancy later. When our vacancy ended, Ms. Delos Reyes and I were divided into five groups since we were supposed to conduct a research article."
        Dim script146 As String = "We have already discussed our study topic, which is quite difficult because we are in our fourth year and what we will be doing is no longer normal or easy. We also reviewed the titles given by my group members, and one of our proposals was approved."
        Dim script147 As String = "I ate and rested when I arrived home. After I finished eating, I went straight to my room to start our research paper and I also chatted with our group chat because tomorrow we will defend it immediately, but no one responds to one of my chats so I suddenly "
        Dim script148 As String = "panicked and cried because what if we don't have anything to defend tomorrow so I tried to do our paper alone but I didn't finish so I immediately opened my cell phone and checked if anyone responded to my messages."

        'mc
        Dim script149 As String = "Guys, tomorrow is our defense. What do you intend to do with flowchart and methodology?"
        'khalil
        Dim script150 As String = "Here is the flowchart and methodology I created, just check if it is correct and sorry for not responding earlier, I am busy doing the flowchart and methodology."
        Dim script151 As String = "Oh, thanks Khalil. I will check this so that I can put it in our papers and guys, review what I will send later so that we won't be asked too many questions by the panelists about our defense tomorrow."

        'school
        Dim script152 As String = "We defended our research successfully, and the panels teased us a little, but we responded well and received excellent ratings, and luckily, our final defense is completed, so we can go on vacation. Our finals are finished, and we are preparing for our graduation photo shoot."
        Dim script153 As String = "And this is it the graduation day, First I would like to thank god for guiding me all this stressful life and second, thanks for my mom and dad for always supporting me. And lastly to all the teachers thank you so much for guiding and teaching us..."

        Select Case storygame
            Case 1
                storytextbox.Text = script1
                Maingamebg.Image = My.Resources.y1s3schoolfront
            Case 2
                storytextbox.Text = script2
                Maingamebg.Image = My.Resources.hallway
            Case 3
                storytextbox.Text = script3
                currentname.Text = selectedname

                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s2hallwaymale
                Else
                    Maingamebg.Image = My.Resources.y1s2hallwayfemale
                End If
            Case 4
                storytextbox.Text = script4
                currentname.Text = ""
            Case 5
                storytextbox.Text = script5
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s5schoolfrontmalefriends
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemale
                End If
            Case 6
                storytextbox.Text = script6
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s6schoolfrontmalefriends2
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend1
                End If
            Case 7
                storytextbox.Text = script7
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s7schoolfrontmalefriends3
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend2
                End If
            Case 8
                currentname.Text = "Jamie"
                storytextbox.Text = script8
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s8schoolfrontmalefriends4
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemalefriend3
                End If
            Case 9
                currentname.Text = "Gian"
                storytextbox.Text = script9
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s5schoolfrontmalefriends
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfrontfemale
                End If
            Case 10
                currentname.Text = ""
                storytextbox.Text = script10
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s3schoolfront
                Else
                    Maingamebg.Image = My.Resources.y1s3schoolfront
                End If
            Case 11
                storytextbox.Text = script11
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s9comlab
                Else
                    Maingamebg.Image = My.Resources.y1s9comlab
                End If
            Case 12
                currentname.Text = selectedname
                storytextbox.Text = script12
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s10comlabmalebff1
                Else
                    Maingamebg.Image = My.Resources.y1s4femalefriend1
                End If
            Case 13
                currentname.Text = "France"
                storytextbox.Text = script13
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s10comlabmalebff1
                Else

                End If
            Case 14
                currentname.Text = ""
                storytextbox.Text = script14
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s11bedroom
                Else
                    Maingamebg.Image = My.Resources.femaleroom
                End If

                'discord
            Case 15
                currentname.Text = selectedname
                storytextbox.Text = script15
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s13maledc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleroom
                End If
            Case 16
                currentname.Text = "Gian"
                storytextbox.Text = script16
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s14bff
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleandfriend1
                End If
            Case 17
                currentname.Text = selectedname
                storytextbox.Text = script17
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s13maledc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleroom
                End If
            Case 18
                currentname.Text = "Gian"
                storytextbox.Text = script18
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s14bff
                Else
                    Maingamebg.Image = My.Resources.yr1s6femalefriend1roomdiscord
                End If
            Case 19
                currentname.Text = ""
                storytextbox.Text = script19
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s15malebffdc
                Else
                    Maingamebg.Image = My.Resources.y1s6femaleandfriend1
                End If
            Case 20
                storytextbox.Text = script20
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s16classroom
                Else
                    Maingamebg.Image = My.Resources.y1s16classroom
                End If
            Case 21
                currentname.Text = "Professor Jax"
                storytextbox.Text = script21
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s17classteacher
                Else
                    Maingamebg.Image = My.Resources.y1s17classteacher
                End If
            Case 22
                currentname.Text = selectedname
                storytextbox.Text = script22
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s18malebffclassroom
                Else
                    Maingamebg.Image = My.Resources.y1s4femalefriend1
                End If
            Case 23
                storytextbox.Text = script23
                currentname.Text = "Jamie"
            Case 24
                CollegeSim.SelectedTab = Quiztab
                storytextbox.Text = script24
                quizcount = 1
                Select Case quizcount
                    Case 1
                        'quiz
                        quizq1.Text = "What does IT stands for?"
                        quizq2.Text = "Which term refers to the process of converting human-readable code into machine-readable code?"
                        quizq3.Text = "The acronym URL stands for "
                        quizq4.Text = "Binary code is the fundamental language that computers use to process information, using only two digits:"
                        quizq5.Text = "Is a self-replicating program that spreads by inserting copies of itself into other executable code."

                        'quiz choices
                        'q1
                        q1ans1.Text = "Information Technology"
                        q1ans2.Text = "Information Tools"
                        q1ans3.Text = "Intelligent Technology"
                        'q2
                        q2ans1.Text = "Compilation"
                        q2ans2.Text = "Encryption"
                        q2ans3.Text = "Execution"
                        'q3
                        q3ans1.Text = "Unified Resource Locator"
                        q3ans2.Text = "Uniform Resource Langguage"
                        q3ans3.Text = "Uniform Resource Locator"
                        'q4
                        q4ans1.Text = "1s and 0s"
                        q4ans2.Text = "2s and 20s"
                        q4ans3.Text = "0s and 2s"
                        'q5
                        q5ans1.Text = "Virus"
                        q5ans2.Text = "Covid"
                        q5ans3.Text = "Flu"
                End Select
            Case 25
                storytextbox.Text = script25
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s20courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s20courtyard
                End If
            Case 26
                storytextbox.Text = script26
                currentname.Text = "Gian"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s21malebff1courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend1
                End If
            Case 27
                storytextbox.Text = script27
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s22malebff2courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend2
                End If
            Case 28
                storytextbox.Text = script28
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s22malebff2courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female3
                End If
            Case 29
                storytextbox.Text = script29
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s23malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8femalefriend4
                End If
            Case 30
                storytextbox.Text = script30
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s24malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female5
                End If
            Case 31
                storytextbox.Text = script31
                currentname.Text = "France"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s25malebffcourtyard
                Else
                    Maingamebg.Image = My.Resources.y1s8female5
                End If
            Case 32
                storytextbox.Text = script32
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s20courtyard
                Else
                    Maingamebg.Image = My.Resources.y1s20courtyard
                End If
            Case 33
                storytextbox.Text = script33
            Case 34
                storytextbox.Text = script34

                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s28comlab
                Else
                    Maingamebg.Image = My.Resources.y1s9comlab
                End If
            Case 35
                storytextbox.Text = script35
                currentname.Text = "Professor Annaliese"
                Maingamebg.Image = My.Resources.y1s29comlabteacher
            Case 36
                storytextbox.Text = script36
                currentname.Text = ""
            Case 37
                storytextbox.Text = script37
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s30malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 38
                storytextbox.Text = script38
                currentname.Text = "France"
            Case 39
                storytextbox.Text = script39
                currentname.Text = selectedname

               'quiz time
            Case 40
                storytextbox.Text = script40
                currentname.Text = "France"
                Maingamebg.Image = My.Resources.y1s35teachercomlab

            Case 41
                storytextbox.Text = script41
                Maingamebg.Image = My.Resources.y1s28comlab
            Case 42
                storytextbox.Text = script42
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s30malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 43
                storytextbox.Text = script43
            Case 44
                Maingamebg.Image = My.Resources.y1s28comlab
                storytextbox.Text = script44
            Case 45
                storytextbox.Text = script45

                Maingamebg.Image = My.Resources.y1s29comlabteacher
            Case 46
                currentname.Text = "Professor Annaliese"
                storytextbox.Text = script46
                Maingamebg.Image = My.Resources.y1s28comlab
            Case 47
                storytextbox.Text = script47
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s36malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s9female_friend1
                End If
            Case 48
                storytextbox.Text = script48
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s36malebffcomlab
                Else
                    Maingamebg.Image = My.Resources.y1s10female_friends
                End If
            Case 49
                Maingamebg.Image = My.Resources.y1s20courtyard
                storytextbox.Text = script49
            Case 50
                storytextbox.Text = script50

                'second year
            Case 51
                storytextbox.Text = script51
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3malebffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                End If
            Case 52
                storytextbox.Text = script52
            Case 53
                storytextbox.Text = script53
                currentname.Text = selectedname
            Case 54
                storytextbox.Text = script54
                currentname.Text = "Riley"
            Case 55
                storytextbox.Text = script55
                currentname.Text = selectedname
            Case 56
                storytextbox.Text = script56
                currentname.Text = "Riley"
            Case 57
                storytextbox.Text = script57
                currentname.Text = selectedname
            Case 58
                storytextbox.Text = script58
                currentname.Text = "Riley"
            Case 59
                storytextbox.Text = script59
                currentname.Text = selectedname
            Case 60
                storytextbox.Text = script60
                currentname.Text = "Riley"
            Case 61
                storytextbox.Text = script61
                currentname.Text = selectedname
            Case 62
                storytextbox.Text = script62
                currentname.Text = "Riley"
            Case 63
                storytextbox.Text = script63
                currentname.Text = selectedname
            Case 64
                storytextbox.Text = script64
                currentname.Text = "Riley"
            Case 65
                storytextbox.Text = script65
                currentname.Text = selectedname
            Case 66
                storytextbox.Text = script66
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd5bffclassroom
                Else
                    Maingamebg.Image = My.Resources.y2nd5bffclassroom
                End If
            Case 67
                storytextbox.Text = script67
                currentname.Text = "Professor Kenny"
                Maingamebg.Image = My.Resources.y1s17classteacher
            Case 68
                storytextbox.Text = script68
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd1girlbffclassroom
                Else
                    Maingamebg.Image = My.Resources.y2nd5girlbffclassroom
                End If
            Case 69
                storytextbox.Text = script69
                currentname.Text = "Riley"
            Case 70
                storytextbox.Text = script70
                currentname.Text = "Professor Kenny"

                'quiz time
            Case 71
                storytextbox.Text = script71

            Case 72
                storytextbox.Text = script72
                currentname.Text = "Riley"
            Case 73
                storytextbox.Text = script73
                currentname.Text = selectedname
            Case 74
                storytextbox.Text = script74
                currentname.Text = ""
            Case 75
                storytextbox.Text = script75

            Case 76
                storytextbox.Text = script76
            Case 77
                storytextbox.Text = script77
                currentname.Text = "Riley"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd2malebffcoffeshop
                Else
                    Maingamebg.Image = My.Resources.y2nd6girlbffcoffeeshop
                End If
            Case 78
                storytextbox.Text = script78
            Case 79
                storytextbox.Text = script79
                currentname.Text = selectedname
            Case 80
                storytextbox.Text = script80
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd4girlbfflibrary
                Else
                    Maingamebg.Image = My.Resources.y2nd8girlbfflibrary
                End If
            Case 81
                storytextbox.Text = script81
            Case 82
                storytextbox.Text = script82
            Case 83
                storytextbox.Text = script83
                currentname.Text = "Riley"
            Case 84
                storytextbox.Text = script84
                currentname.Text = selectedname
            Case 85
                storytextbox.Text = script85
                currentname.Text = ""
            Case 86
                storytextbox.Text = script86
                currentname.Text = "Riley"
            Case 87
                storytextbox.Text = script87
                currentname.Text = selectedname
            Case 88
                storytextbox.Text = script88
            Case 89
                storytextbox.Text = script89
                currentname.Text = ""
            Case 90
                storytextbox.Text = script90
            Case 91
                storytextbox.Text = script91
            Case 92
                storytextbox.Text = script92
            Case 93
                storytextbox.Text = script93
                currentname.Text = "Riley"
            Case 94
                storytextbox.Text = script94
                currentname.Text = selectedname
            Case 95
                storytextbox.Text = script95
            Case 96
                storytextbox.Text = script96
                currentname.Text = ""
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_his_room
                Else
                    Maingamebg.Image = My.Resources.girl_in_her_room
                End If
            Case 97
                storytextbox.Text = script97
            Case 98
                storytextbox.Text = script98
            Case 99
                storytextbox.Text = script99
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd9girlbffschoolfront
                End If
            Case 100
                storytextbox.Text = script100
                currentname.Text = "Riley"
            Case 101
                storytextbox.Text = script101
                currentname.Text = selectedname
            Case 102
                storytextbox.Text = script102
                currentname.Text = ""
                Maingamebg.Image = My.Resources.y1s3schoolfront
            Case 103
                storytextbox.Text = script103
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y1s18malebffclassroom
                Else
                    Maingamebg.Image = My.Resources.y1s9femalefriend2
                End If
            Case 104
                storytextbox.Text = script104
                currentname.Text = "Charlie"
            Case 105
                storytextbox.Text = script105
                currentname.Text = selectedname
            Case 106
                storytextbox.Text = script106
                currentname.Text = "Charlie"
            Case 107
                storytextbox.Text = script107
                currentname.Text = selectedname

                'quiz pause
            Case 108
                storytextbox.Text = script108
                currentname.Text = "Charlie"
            Case 109
                storytextbox.Text = script109
                currentname.Text = selectedname
            Case 110
                storytextbox.Text = script110
                currentname.Text = "Charlie"
            Case 111
                storytextbox.Text = script111
                currentname.Text = selectedname
            Case 112
                storytextbox.Text = script112
                currentname.Text = "Charlie"
            Case 113
                storytextbox.Text = script113
                currentname.Text = selectedname

                'courtyard
            Case 114
                storytextbox.Text = script114
                currentname.Text = "Alex"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y2nd3girlbffschoolfront
                Else
                    Maingamebg.Image = My.Resources.y2nd9girlbffschoolfront
                End If
            Case 115
                storytextbox.Text = script115
                currentname.Text = selectedname
            Case 116
                currentname.Text = "Alex"
                storytextbox.Text = script116
            Case 117
                storytextbox.Text = script117
                currentname.Text = "Professor Ray"
                Maingamebg.Image = My.Resources.y1s29comlabteacher

                'quiz
            Case 118
                storytextbox.Text = script118
            Case 119
                storytextbox.Text = script119
                currentname.Text = "Charlie"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.y3male2bff
                Else
                    Maingamebg.Image = My.Resources.y3female2bff
                End If
            Case 120
                storytextbox.Text = script120
                currentname.Text = selectedname
            Case 121
                storytextbox.Text = script121
                currentname.Text = "Alex"
            Case 122
                storytextbox.Text = script122
                currentname.Text = selectedname
            Case 123
                storytextbox.Text = script123
                currentname.Text = selectedname
            Case 124
                storytextbox.Text = script124
                currentname.Text = "Charlie"
            Case 125
                storytextbox.Text = script125
                currentname.Text = "Alex"
            Case 126
                storytextbox.Text = script126
                currentname.Text = selectedname

                'grad

            Case 127
                storytextbox.Text = script127
                currentname.Text = "Dean"
                Maingamebg.Image = My.Resources.y1s16classroom
            Case 128
                storytextbox.Text = script128
                currentname.Text = selectedname
            Case 129
                storytextbox.Text = script129
                currentname.Text = "Charlie"
            Case 130
                storytextbox.Text = script130
                currentname.Text = "Alex"
            Case 131
                storytextbox.Text = script131
                If selectedname = "Miyuki" Then
                    currentname.Text = selectedname
                    Maingamebg.Image = My.Resources.boy_with_his_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_with_her_classmate
                End If
            Case 132
                storytextbox.Text = script132
            Case 133
                storytextbox.Text = script133
            Case 134
                currentname.Text = "Ms. Catherine"
                storytextbox.Text = script134
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_his_teacher_natural_language_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_natural_languange_classmate_comlab
                End If

                'quiztime
            Case 135
                storytextbox.Text = script135
                currentname.Text = ""
            Case 136
                storytextbox.Text = script136
            Case 137
                storytextbox.Text = script137
            Case 138
                storytextbox.Text = script138
                currentname.Text = "Ms. Renalyn"
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_teacher_in_research_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_in_research_classmate
                End If
            Case 139
                storytextbox.Text = script139
                currentname.Text = selectedname
            Case 140
                storytextbox.Text = script140
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_his_room
                Else
                    Maingamebg.Image = My.Resources.girl_in_her_room
                End If
            Case 141
                storytextbox.Text = script141
            Case 142
                storytextbox.Text = script142
            Case 143
                currentname.Text = ""
                storytextbox.Text = script143
            Case 144
                storytextbox.Text = script144
                currentname.Text = selectedname
            Case 145
                storytextbox.Text = script145
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_in_hallway
                Else
                    Maingamebg.Image = My.Resources.girl_hallway
                End If
            Case 146
                storytextbox.Text = script146
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_teacher_in_research_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_teacher_in_research_classmate
                End If
            Case 147
                storytextbox.Text = script147
            Case 148
                storytextbox.Text = script148
            Case 149
                storytextbox.Text = script149
                currentname.Text = selectedname
                If selectedname = "Miyuki" Then
                    Maingamebg.Image = My.Resources.boy_with_his_classmate
                Else
                    Maingamebg.Image = My.Resources.girl_with_her_classmate
                End If
            Case 150
                storytextbox.Text = script150
                currentname.Text = "Khalil"
            Case 151
                storytextbox.Text = script151
                currentname.Text = selectedname
            Case 152
                storytextbox.Text = script152
            Case 153
                storytextbox.Text = script153
                MessageBox.Show("Congratulations on completing the game!", "Thank you", MessageBoxButtons.OK)
        End Select
    End Sub


    'quiz
    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click

        Dim quizscore As Integer = 0
        Dim quizresult As String = quizscore & "/5"


        Select Case quizcount
            Case 1
                Dim answer1 As Boolean = q1ans1.Checked
                Dim answer2 As Boolean = q2ans1.Checked
                Dim answer3 As Boolean = q3ans3.Checked
                Dim answer4 As Boolean = q4ans1.Checked
                Dim answer5 As Boolean = q5ans1.Checked

                If answer1 Then
                    quizscore += 1
                End If

                If answer2 Then
                    quizscore += 1
                End If

                If answer3 Then
                    quizscore += 1
                End If

                If answer4 Then
                    quizscore += 1
                End If

                If answer5 Then
                    quizscore += 1
                End If
        End Select


        Dim resultMessage As String = $"You got {quizscore} out of 5 correct."

        Dim resultbox As DialogResult = MessageBox.Show(resultMessage, "Quiz Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If resultbox = DialogResult.OK Then
            CollegeSim.SelectedTab = Maingame

            quizcount += 1
        End If


    End Sub

    Private Sub openquiz_Click(sender As Object, e As EventArgs) Handles openquiz.Click
        quizq1.Visible = True
        quizq2.Visible = True
        quizq3.Visible = True
        quizq4.Visible = True
        quizq5.Visible = True
        q1ans1.Visible = True
        q1ans2.Visible = True
        q1ans3.Visible = True
        q2ans1.Visible = True
        q2ans2.Visible = True
        q2ans3.Visible = True
        q3ans1.Visible = True
        q3ans2.Visible = True
        q3ans3.Visible = True
        q4ans1.Visible = True
        q4ans2.Visible = True
        q4ans3.Visible = True
        q5ans1.Visible = True
        q5ans2.Visible = True
        q4ans3.Visible = True
        quiztitle.Visible = True
        quizclose.Visible = True
        quizpanelbot.Visible = True
        quizpaneltop.Visible = True
        submitbtn.Visible = True

    End Sub

    Private Sub quizclose_Click(sender As Object, e As EventArgs) Handles quizclose.Click
        quizq1.Visible = False
        quizq2.Visible = False
        quizq3.Visible = False
        quizq4.Visible = False
        quizq5.Visible = False
        q1ans1.Visible = False
        q1ans2.Visible = False
        q1ans3.Visible = False
        q2ans1.Visible = False
        q2ans2.Visible = False
        q2ans3.Visible = False
        q3ans1.Visible = False
        q3ans2.Visible = False
        q3ans3.Visible = False
        q4ans1.Visible = False
        q4ans2.Visible = False
        q4ans3.Visible = False
        q5ans1.Visible = False
        q5ans2.Visible = False
        q4ans3.Visible = False
        quiztitle.Visible = False
        quizclose.Visible = False
        quizpanelbot.Visible = False
        quizpaneltop.Visible = False
        submitbtn.Visible = False
    End Sub


    'checkbox changed

    Private Sub q1ans1_CheckedChanged(sender As Object, e As EventArgs) Handles q1ans1.CheckedChanged

        q1ans2.Checked = False
        q1ans3.Checked = False

        If q1ans1.Checked = True Then
            q1ans2.Enabled = False
            q1ans3.Enabled = False
        Else
            q1ans2.Enabled = True
            q1ans3.Enabled = True
        End If

    End Sub

    Private Sub q1ans2_CheckedChanged(sender As Object, e As EventArgs) Handles q1ans2.CheckedChanged
        q1ans1.Checked = False
        q1ans3.Checked = False

        If q1ans2.Checked = True Then
            q1ans1.Enabled = False
            q1ans3.Enabled = False
        Else
            q1ans1.Enabled = True
            q1ans3.Enabled = True
        End If
    End Sub

    Private Sub q1ans3_CheckedChanged(sender As Object, e As EventArgs) Handles q1ans3.CheckedChanged
        q1ans1.Checked = False
        q1ans2.Checked = False

        If q1ans3.Checked = True Then
            q1ans2.Enabled = False
            q1ans1.Enabled = False
        Else
            q1ans2.Enabled = True
            q1ans1.Enabled = True
        End If
    End Sub

    Private Sub q2ans1_CheckedChanged(sender As Object, e As EventArgs) Handles q2ans1.CheckedChanged

        q2ans2.Checked = False
        q2ans3.Checked = False

        If q2ans1.Checked = True Then
            q2ans2.Enabled = False
            q2ans3.Enabled = False
        Else
            q2ans2.Enabled = True
            q2ans3.Enabled = True
        End If

    End Sub

    Private Sub q2ans2_CheckedChanged(sender As Object, e As EventArgs) Handles q2ans2.CheckedChanged

        q2ans1.Checked = False
        q2ans3.Checked = False

        If q2ans2.Checked = True Then
            q2ans1.Enabled = False
            q2ans3.Enabled = False
        Else
            q2ans1.Enabled = True
            q2ans3.Enabled = True
        End If

    End Sub

    Private Sub q2ans3_CheckedChanged(sender As Object, e As EventArgs) Handles q2ans3.CheckedChanged

        q2ans1.Checked = False
        q2ans2.Checked = False

        If q2ans3.Checked = True Then
            q2ans1.Enabled = False
            q2ans2.Enabled = False
        Else
            q2ans2.Enabled = True
            q2ans1.Enabled = True
        End If

    End Sub

    Private Sub q3ans1_CheckedChanged(sender As Object, e As EventArgs) Handles q3ans1.CheckedChanged

        q3ans2.Checked = False
        q3ans3.Checked = False

        If q3ans1.Checked = True Then
            q3ans2.Enabled = False
            q3ans3.Enabled = False
        Else
            q3ans2.Enabled = True
            q3ans3.Enabled = True
        End If

    End Sub

    Private Sub q3ans2_CheckedChanged(sender As Object, e As EventArgs) Handles q3ans2.CheckedChanged

        q3ans1.Checked = False
        q3ans3.Checked = False

        If q3ans2.Checked = True Then
            q3ans1.Enabled = False
            q3ans3.Enabled = False
        Else
            q3ans1.Enabled = True
            q3ans3.Enabled = True
        End If

    End Sub

    Private Sub q3ans3_CheckedChanged(sender As Object, e As EventArgs) Handles q3ans3.CheckedChanged

        q3ans2.Checked = False
        q3ans1.Checked = False

        If q3ans3.Checked = True Then
            q3ans2.Enabled = False
            q3ans1.Enabled = False
        Else
            q3ans2.Enabled = True
            q3ans1.Enabled = True
        End If

    End Sub

    Private Sub q4ans1_CheckedChanged(sender As Object, e As EventArgs) Handles q4ans1.CheckedChanged

        q4ans2.Checked = False
        q4ans3.Checked = False

        If q4ans1.Checked = True Then
            q4ans2.Enabled = False
            q4ans3.Enabled = False
        Else
            q4ans2.Enabled = True
            q4ans3.Enabled = True
        End If

    End Sub

    Private Sub q4ans2_CheckedChanged(sender As Object, e As EventArgs) Handles q4ans2.CheckedChanged

        q4ans1.Checked = False
        q4ans3.Checked = False

        If q4ans2.Checked = True Then
            q4ans1.Enabled = False
            q4ans3.Enabled = False
        Else
            q4ans1.Enabled = True
            q4ans3.Enabled = True
        End If

    End Sub

    Private Sub q4ans3_CheckedChanged(sender As Object, e As EventArgs) Handles q4ans3.CheckedChanged

        q4ans2.Checked = False
        q4ans1.Checked = False

        If q4ans3.Checked = True Then
            q4ans2.Enabled = False
            q4ans1.Enabled = False
        Else
            q4ans2.Enabled = True
            q4ans1.Enabled = True
        End If

    End Sub

    Private Sub q5ans1_CheckedChanged(sender As Object, e As EventArgs) Handles q5ans1.CheckedChanged

        q5ans2.Checked = False
        q5ans3.Checked = False

        If q5ans1.Checked = True Then
            q5ans2.Enabled = False
            q5ans3.Enabled = False
        Else
            q5ans2.Enabled = True
            q5ans3.Enabled = True
        End If

    End Sub

    Private Sub q5ans2_CheckedChanged(sender As Object, e As EventArgs) Handles q5ans2.CheckedChanged

        q5ans1.Checked = False
        q5ans3.Checked = False

        If q5ans2.Checked = True Then
            q5ans1.Enabled = False
            q5ans3.Enabled = False
        Else
            q5ans1.Enabled = True
            q5ans3.Enabled = True
        End If

    End Sub

    Private Sub q5ans3_CheckedChanged(sender As Object, e As EventArgs) Handles q5ans3.CheckedChanged

        q5ans2.Checked = False
        q5ans1.Checked = False

        If q5ans3.Checked = True Then
            q5ans2.Enabled = False
            q5ans1.Enabled = False
        Else
            q5ans2.Enabled = True
            q5ans1.Enabled = True
        End If

    End Sub
End Class
