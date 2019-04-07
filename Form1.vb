
Public Class Form1
    'tic-tac-toe game
    Dim tl As Integer = 3
    Dim tc As Integer = 3
    Dim tr As Integer = 3
    Dim ml As Integer = 3
    Dim mc As Integer = 3
    Dim mr As Integer = 3
    Dim bl As Integer = 3
    Dim bc As Integer = 3
    Dim br As Integer = 3
    Dim turn As Single
    Dim letter As String
    Dim turncount As Integer = 0
    Dim currentgame As Integer = 0
    Dim cg As Integer = 0
    Dim buttonclicked1, buttonclicked2, buttonclicked3, buttonclicked4, buttonclicked5, buttonclicked6, buttonclicked7, buttonclicked8, buttonclicked9, who As Boolean

    'Here we create the necessary variable for running the first section of the code

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        letter = "X"
        'When the form loads we have it set X as the first player
    End Sub
    'Private Sub BackgroundProcess()

    '    ' Do a long process here, not just an infinite loop

    '    Do While True
    '        If tl = 3 And tc = 3 And tr = 3 And ml = 3 And mc = 3 And mr = 3 And bl = 3 And bc = 3 And br = 3 Then
    '            cleartheboard()
    '        End If
    '    Loop

    'End Sub
    'Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    '    t.Abort()

    'End Sub
    Public Function rand(ByVal low As Long, ByVal high As Long) As Long
        rand = Int((high - low + 1) * Rnd()) + low
        Return rand
    End Function
    Private Sub AIstorage()
        If currentgame < 8 And turncount = 0 Then
            store_move(currentgame, turncount) 'stores data for AI
            turncount += 1
        ElseIf currentgame < 8 And turncount = 8 Then
            changed_move(currentgame, turncount)
        ElseIf currentgame < 8 And turncount > 0 And turncount < 8 Then
            changed_move(currentgame, turncount) 'stores data for AI
            turncount += 1 'keeps track of what turn the game is on
            store_move(currentgame, turncount) 'stores data for AI
        End If
    End Sub
    Private Sub turns()

        storeboard() 'stores data for game
        AIstorage()
        If letter = "X" Then
            letter = "O"
        Else : letter = "X" ' Changes to the next person's turn
        End If
        If ending = True Then
            ending = False  'checks if the end of the game has been reached and if it hasn't, allows the computer to make its move
        Else
            remember()
            If compmove = True Then
                MessageBox.Show("AI", ":D")
                Aiturn()
            Else
                MessageBox.Show("No AI", ":(")
                random_move()
            End If
        End If
    End Sub
    Private Sub turnsai() ' same as above, but without AI section

        storeboard()
        AIstorage()
        If letter = "X" Then
            letter = "O"
        Else : letter = "X"
        End If
    End Sub

    'the following code notes which buttons have been pressed on earlier turns, and run procedures if a button has not been clicked yet.
    Private Sub bkgd1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If buttonclicked1 = False Then
            Button1.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If buttonclicked2 = False Then
            Button2.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If buttonclicked3 = False Then
            Button3.Text = letter
            turns()
            fix_error()
        End If

    End Sub

    Private Sub bkgd4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If buttonclicked4 = False Then
            Button4.Text = letter
            turns()
            fix_error()
        End If

    End Sub

    Private Sub bkgd5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If buttonclicked5 = False Then
            Button5.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd6(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If buttonclicked6 = False Then
            Button6.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd7(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If buttonclicked7 = False Then
            Button7.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd8(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If buttonclicked8 = False Then
            Button8.Text = letter
            turns()
            fix_error()
        End If
    End Sub

    Private Sub bkgd9(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If buttonclicked9 = False Then
            Button9.Text = letter
            turns()
            fix_error()
        End If
    End Sub
    Private Sub storeboard() 'stores the current board for use by other procedures
        'O = 1
        'X = 2
        'Empty = 3

        If Button1.Text = "O" Then
            tl = 1
        ElseIf Button1.Text = "X" Then
            tl = 2
        Else : tl = 3
        End If
        If Button2.Text = "O" Then
            tc = 1
        ElseIf Button2.Text = "X" Then
            tc = 2
        Else : tc = 3
        End If
        If Button3.Text = "O" Then
            tr = 1
        ElseIf Button3.Text = "X" Then
            tr = 2
        Else : tr = 3
        End If
        If Button4.Text = "O" Then
            ml = 1
        ElseIf Button4.Text = "X" Then
            ml = 2
        Else : ml = 3
        End If
        If Button5.Text = "O" Then
            mc = 1
        ElseIf Button5.Text = "X" Then
            mc = 2
        Else : mc = 3
        End If
        If Button6.Text = "O" Then
            mr = 1
        ElseIf Button6.Text = "X" Then
            mr = 2
        Else : mr = 3
        End If
        If Button7.Text = "O" Then
            bl = 1
        ElseIf Button7.Text = "X" Then
            bl = 2
        Else : bl = 3
        End If
        If Button8.Text = "O" Then
            bc = 1
        ElseIf Button8.Text = "X" Then
            bc = 2
        Else : bc = 3
        End If
        If Button9.Text = "O" Then
            br = 1
        ElseIf Button9.Text = "X" Then
            br = 2
        Else : br = 3
        End If
        checktheboard(tl, tc, tr, ml, mc, mr, bl, bc, br)
    End Sub
    Dim ending As Boolean = False
    Private Sub checktheboard(ByVal tl As Integer, ByVal tc As Integer, ByVal tr As Integer, ByVal ml As Integer, ByVal mc As Integer, ByVal mr As Integer, ByVal bl As Integer, ByVal bc As Integer, ByVal br As Integer)
        'checks to see if one of the players has won
        Dim go As Boolean = False
        If tl = tc And tc = tr And tr < 3 Then
            go = True
        ElseIf ml = mc And mc = mr And mr < 3 Then
            go = True
        ElseIf bl = bc And bc = br And br < 3 Then
            go = True
        ElseIf tl = ml And ml = bl And bl < 3 Then
            go = True
        ElseIf tc = mc And mc = bc And bc < 3 Then
            go = True
        ElseIf tr = mr And mr = br And br < 3 Then
            go = True
        ElseIf tl = mc And mc = br And br < 3 Then
            go = True
        ElseIf tr = mc And mc = bl And bl < 3 Then
            go = True
        End If
        'If someone has won or the there is no winner, a message is shown to conclude the game
        If go = True Then
            MessageBox.Show("Good Job " & letter & ", You Won!", "Victory!!!")
            changed_move(currentgame, turncount)
            ending = True
            turncount = 0
            score()
        ElseIf tl < 3 And tc < 3 And tr < 3 And ml < 3 And mc < 3 And mr < 3 And bl < 3 And bc < 3 And br < 3 Then
            MessageBox.Show("Cats game, no winner", ":/")
            changed_move(currentgame, turncount)
            ending = True
            turncount = 0
        End If
    End Sub
    Private Sub score()
        If letter = "X" Then
            TextBox1.Text += 1
        Else
            TextBox2.Text += 1
        End If
    End Sub
    Private Sub cleartheboard() 'resets the board for the next game
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        buttonclicked1 = False
        buttonclicked2 = False
        buttonclicked3 = False
        buttonclicked4 = False
        buttonclicked5 = False
        buttonclicked6 = False
        buttonclicked7 = False
        buttonclicked8 = False
        buttonclicked9 = False

        Dim tl As Integer = 3
        Dim tc As Integer = 3
        Dim tr As Integer = 3
        Dim ml As Integer = 3
        Dim mc As Integer = 3
        Dim mr As Integer = 3
        Dim bl As Integer = 3
        Dim bc As Integer = 3
        Dim br As Integer = 3
    End Sub

    Private Sub random_move() 'allows the computer to do a random move

        Dim count As Integer = 0
        If tl = 3 Then count += 1
        If tc = 3 Then count += 1
        If tr = 3 Then count += 1
        If ml = 3 Then count += 1 'creates variable "count" that increases for every free space available
        If mc = 3 Then count += 1
        If mr = 3 Then count += 1
        If bl = 3 Then count += 1
        If bc = 3 Then count += 1
        If br = 3 Then count += 1

        Dim cd As Integer = rand(1, count) 'selects a number between 1 and the number of free spaces
        'for every free space, count is decrease by 1 from top-left to bottom-right. When count reaches 0, the current free space is filled
        If tl = 3 Then
            cd -= 1
            If cd = 0 Then
                Button1.Text = letter 'fills in the text for the current turn
                turnsai()
                fix_error()
            End If
        End If

        If tc = 3 Then
            cd -= 1
            If cd = 0 Then
                Button2.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If tr = 3 Then
            cd -= 1
            If cd = 0 Then
                Button3.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If ml = 3 Then
            cd -= 1
            If cd = 0 Then
                Button4.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If mc = 3 Then
            cd -= 1
            If cd = 0 Then
                Button5.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If mr = 3 Then
            cd -= 1
            If cd = 0 Then
                Button6.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If bl = 3 Then
            cd -= 1
            If cd = 0 Then
                Button7.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If bc = 3 Then
            cd -= 1
            If cd = 0 Then
                Button8.Text = letter
                turnsai()
                fix_error()
            End If
        End If

        If br = 3 Then
            cd -= 1
            If cd = 0 Then
                Button9.Text = letter
                turnsai()
                fix_error()
            End If
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'When the button is clicked, the board is cleared for the next round
        cleartheboard()
        If currentgame < 8 Then currentgame += 1
        cg += 1
        ending = False
        If cg Mod 2 = 0 Then
            If letter = "X" Then : letter = "O"
            Else : letter = "X"
            End If
        End If
        If letter = "O" Then
            remember()
            If compmove = True Then
                MessageBox.Show("AI", ":D")
                Aiturn()
            Else
                MessageBox.Show("no AI", ":D")
                random_move()
            End If
        End If
    End Sub
    Private Sub fix_error()
        'safety for correcting glitches. Makes sure unclicked buttons can be clicked, and those that are clicked cannot be cicked again.
        If tl <> 3 Then buttonclicked1 = True
        If tc <> 3 Then buttonclicked2 = True
        If tr <> 3 Then buttonclicked3 = True
        If ml <> 3 Then buttonclicked4 = True
        If mc <> 3 Then buttonclicked5 = True
        If mr <> 3 Then buttonclicked6 = True
        If bl <> 3 Then buttonclicked7 = True
        If bc <> 3 Then buttonclicked8 = True
        If br <> 3 Then buttonclicked9 = True

        If tl = 3 Then buttonclicked1 = False
        If tc = 3 Then buttonclicked2 = False
        If tr = 3 Then buttonclicked3 = False
        If ml = 3 Then buttonclicked4 = False
        If mc = 3 Then buttonclicked5 = False
        If mr = 3 Then buttonclicked6 = False
        If bl = 3 Then buttonclicked7 = False
        If bc = 3 Then buttonclicked8 = False
        If br = 3 Then buttonclicked9 = False

    End Sub
    'memory system for the AI
    Dim movetl(9, 8), movetc(9, 8), movetr(9, 8), moveml(9, 8), movemc(9, 8), movemr(9, 8), movebl(9, 8), movebc(9, 8), movebr(9, 8) As Integer
    'creates variables for the AI memory (current game, current turn)
    Private Sub store_move(ByVal currentgame As Integer, ByVal count As Integer) 'transfers information from storeboard to its respective place. Counts allows the program to be used for evey turn of the game
        reverse()
        movetl(currentgame, count) = tl2
        movetc(currentgame, count) = tc2
        movetr(currentgame, count) = tr2
        moveml(currentgame, count) = ml2
        movemc(currentgame, count) = mc2
        movemr(currentgame, count) = mr2
        movebl(currentgame, count) = bl2
        movebc(currentgame, count) = bc2
        movebr(currentgame, count) = br2

    End Sub
    Dim move_newmove(9, 8) As String
    Private Sub changed_move(ByVal currentgame As Integer, ByVal count As Integer) 'checks to see which space changed

        If tl <> movetl(currentgame, count) Then 'If the section of the board is not the same as it was earlier
            move_newmove(currentgame, count) = "tl" 'store the change in move_newmove(currentturn)
        End If
        If tc <> movetc(currentgame, count) Then
            move_newmove(currentgame, count) = "tc"
        End If
        If tr <> movetr(currentgame, count) Then
            move_newmove(currentgame, count) = "tr"
        End If
        If ml <> moveml(currentgame, count) Then
            move_newmove(currentgame, count) = "ml"
        End If
        If mc <> movemc(currentgame, count) Then
            move_newmove(currentgame, count) = "mc"
        End If
        If mr <> movemr(currentgame, count) Then
            move_newmove(currentgame, count) = "mr"
        End If
        If bl <> movebl(currentgame, count) Then
            move_newmove(currentgame, count) = "bl"
        End If
        If bc <> movebc(currentgame, count) Then
            move_newmove(currentgame, count) = "bc"
        End If
        If br <> movebr(currentgame, count) Then
            move_newmove(currentgame, count) = "br"
        End If
    End Sub
    'allows the computer to remember earlier board layouts
    Dim Aimove As String 'create a variable to store the result of remember
    Dim compmove As Boolean 'stores whether or not a result was given
    Private Sub remember()
        reverse()
        remembering()
        If compmove = False Then
            rotatate()
            remembering()
            If compmove = False Then
                rotatate()
                remembering()
                If compmove = False Then
                    rotatate()
                    remembering()
                End If
            End If
        End If
    End Sub
    Private Sub remembering()

        Dim AImovecount As Integer
        For g As Integer = 0 To currentgame
            'for every game played
            For t As Integer = 0 To 8
                ' and every turn within that game
                compthought(g, t)
                If tl2 = movetl(g, t) And tc2 = movetc(g, t) And tr2 = movetr(g, t) And ml2 = moveml(g, t) And mc2 = movemc(g, t) And mr2 = movemc(g, t) And bl2 = movebl(g, t) And bc2 = movebc(g, t) And br2 = movebr(g, t) Then
                    'if the board is what it in an earlier match
                    AImovecount += 1 'increase AImovecount by 1
                End If
            Next
        Next
        If AImovecount = 0 Then 'if no previous boards were identical, exit sub
            ' MessageBox.Show("Y no AI", ":D")
            compmove = False
            Exit Sub
        Else ' if there were previous boards that were identical...
            Dim cd As Integer = rand(1, AImovecount) 'make cd an random number between 1 and AImovecount
            For g As Integer = 0 To currentgame
                'for every game played
                For t As Integer = 0 To 8
                    ' and every turn within that game
                    compthought(g, t)
                    If tl2 = movetl(g, t) And tc2 = movetc(g, t) And tr2 = movetr(g, t) And ml2 = moveml(g, t) And mc2 = movemc(g, t) And mr2 = movemc(g, t) And bl2 = movebl(g, t) And bc2 = movebc(g, t) And br2 = movebr(g, t) Then
                        cd -= 1 ' decrease cd by 1
                        If cd = 0 Then ' if it is 0 make the current result, the computer's move
                            Aimove = move_newmove(g, t) ' see if the move has already been done, and if so send the information to the next step
                            compmove = True
                            Exit For ' and exit the For Loop
                        End If
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub Aiturn()
        If Aimove = "tl" Then
            Button1.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "tc" Then
            Button2.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "tr" Then
            Button3.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "ml" Then
            Button4.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "mc" Then
            Button5.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "mr" Then
            Button6.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "bl" Then
            Button7.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "bc" Then
            Button8.Text = letter
            turnsai()
            fix_error()
        End If
        If Aimove = "br" Then
            Button9.Text = letter
            turnsai()
            fix_error()
        End If

    End Sub
    Dim tl2, tc2, tr2, ml2, mc2, mr2, bl2, bc2, br2 As Integer
    Private Sub reverse() 'reverses board for the computer
        If tl = 2 Then : tl2 = 1
        ElseIf tl = 1 Then : tl2 = 2
        End If
        If tc = 2 Then : tc2 = 1
        ElseIf tc = 1 Then : tc2 = 2
        End If
        If tr = 2 Then : tr2 = 1
        ElseIf tr = 1 Then : tr2 = 2
        End If
        If ml = 2 Then : ml2 = 1
        ElseIf ml = 1 Then : ml2 = 2
        End If
        If mc = 2 Then : mc2 = 1
        ElseIf mc = 1 Then : mc2 = 2
        End If
        If mr = 2 Then : mr2 = 1
        ElseIf mr = 1 Then : mr2 = 2
        End If
        If bl = 2 Then : bl2 = 1
        ElseIf bl = 1 Then : bl2 = 2
        End If
        If bc = 2 Then : bc2 = 1
        ElseIf bc = 1 Then : bc2 = 2
        End If
        If br = 2 Then : br2 = 1
        ElseIf br = 1 Then : br2 = 2
        End If
    End Sub
    Private Sub rotatate()
        'allows the computer to look at the board from the remaining 3 angles
        Dim tl3, tc3, tr3, ml3, mc3, mr3, bl3, bc3, br3 As Integer
        tl3 = tl2
        tc3 = tc2
        tr3 = tr2
        ml3 = ml2
        mc3 = mc2
        mr3 = mr2
        bl3 = br2
        bc3 = bc2
        br3 = br2

        tl2 = tr3
        tc2 = mr3
        tr2 = br3
        ml2 = tc3
        mc2 = mc3
        mr2 = bc3
        bl2 = tl3
        bc2 = ml3
        br2 = bl3
    End Sub

    Private Sub compthought(ByVal g As Integer, ByVal t As Integer)
        Label3.Text = movetl(g, t)
        Label4.Text = movetc(g, t)
        Label5.Text = movetr(g, t)
        Label6.Text = moveml(g, t)
        Label7.Text = movemc(g, t)
        Label8.Text = movemr(g, t)
        Label9.Text = movebl(g, t)
        Label10.Text = movebc(g, t)
        Label11.Text = movebr(g, t)
        Label12.Text = move_newmove(g, t)
        Timer1.Enabled = True
    End Sub

  
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

End Class
