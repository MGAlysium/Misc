Public Class frmPong
    Dim vx, vy As Single 'x and y vectors for ball

    Dim paddleZone As Integer 'section of paddle making contact with ball
    Dim winScore As Integer = 11 'score that must be attained to win game
    Dim scoreLeft, scoreRight, lastPoint As Integer 'game scores and last player to score
    Dim breakCount As Integer = 0 'counter for tmrBreak clock ticks
    Dim intLCourt, intRcourt, intTCourt, intBCourt, intCCourt As Integer
    Dim intBallW, intBallH As Integer 'ball width and height
    Dim intPadLH, intPadRH As Integer 'left and right paddle heights
    Dim intPadLTop, intPadRTop As Integer 'initial y coordinate for top of paddles

    Dim upFlag As Boolean = False 'True when left mouse button held down
    Dim dnFlag As Boolean = False 'True when right mouse button held down

    Dim intPadFaceL, intPadFaceR 'x coordinates for contact surfaces of left and right paddles

    Private Sub frmPong_Load(sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        intLCourt = picPongTable.Left + 5
        intRcourt = picPongTable.Left + picPongTable.Width - 5
        intTCourt = picPongTable.Top + 5
        intBCourt = picPongTable.Top + picPongTable.Height - 5
        intCCourt = picPongTable.Left + picPongTable.Width / 2
        intBallW = lblBall.Width
        intBallH = lblBall.Height
        intPadLH = lblPaddleLeft.Height
        intPadRH = lblPaddleRight.Height
        intPadLTop = picPongTable.Top + picPongTable.Height / 2 - lblPaddleLeft.Height / 2
        intPadRTop = picPongTable.Top + picPongTable.Height / 2 - lblPaddleRight.Height / 2
        intPadFaceL = lblPaddleLeft.Left + lblPaddleLeft.Width
        intPadFaceR = lblPaddleRight.Left
    End Sub

    Private Sub tmrPaddle_Tick(sender As Object, ByVal e As EventArgs) Handles tmrPaddle.Tick
        If lblBall.Left < (intCCourt - intBallW / 2) And vx < 0 Then
            If (lblBall.Top + intBallH / 2) > (lblPaddleLeft.Top + intPadLH / 2) Then
                If (lblPaddleLeft.Top + intPadLH) < intBCourt Then
                    lblPaddleLeft.Top += 4 'move left paddle down 4 pixels
                End If
            ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleLeft.Top + intPadLH / 2) Then
                If lblPaddleLeft.Top > intTCourt Then 'paddle is not yet at top of court
                    lblPaddleLeft.Top -= 4 'move left paddle up 4 pixels
                End If
            End If
        Else 'ball is not in left court or is moving away from left paddle
            If lblPaddleLeft.Top < intPadLTop Then
                lblPaddleLeft.Top += 1 'move paddle down by 1 pixel
            ElseIf lblPaddleLeft.Top > intPadLTop Then
                lblPaddleLeft.Top -= 1 'move paddle up by 1 pixel
            End If
        End If

        If lblPaddleLeft.Top < intTCourt Then
            lblPaddleLeft.Top = intTCourt
        ElseIf lblPaddleLeft.Top > (intBCourt - intPadLH) Then
            lblPaddleLeft.Top = (intBCourt - intPadLH)
        End If

        If upFlag = True And lblPaddleRight.Top > intTCourt Then
            lblPaddleRight.Top -= 4 'move right paddle up 4 pixels
        ElseIf dnFlag = True And lblPaddleRight.Top < (intBCourt - intPadRH) Then
            lblPaddleRight.Top += 4 'move right paddle down 4 pixels
        End If

        If lblPaddleRight.Top < intTCourt Then
            lblPaddleRight.Top = intTCourt
        ElseIf lblPaddleRight.Top > (intBCourt - intPadRH) Then
            lblPaddleRight.Top = (intBCourt - intPadRH)
        End If
    End Sub

    Private Sub tmrBall_Tick(sender As Object, ByVal e As EventArgs) Handles tmrBall.Tick
        lblBall.Top = lblBall.Top + vy 'move ball up or down by vy pixels
        lblBall.Left = lblBall.Left + vx 'move ball left or right by vx pixels

        If lblBall.Top < intTCourt Then lblBall.Top = intTCourt

        If lblBall.Top > (intBCourt - intBallH) Then lblBall.Top = (intBCourt - intBallH)

        If lblBall.Top <= intTCourt Or lblBall.Top >= (intBCourt - intBallH) Then vy = -vy

        If vx < 0 Then 'ball is moving from right to left
            If lblBall.Top > (lblPaddleLeft.Top - intBallH) And lblBall.Top < (lblPaddleLeft.Top + intPadLH) Then
                If lblBall.Left <= intPadFaceL Then
                    Randomize()
                    paddleZone = CInt((Rnd() * 6) - 3)
                    Select Case paddleZone
                        Case 3
                            vy = -5
                            vx = 2
                        Case 2
                            vy = -4
                            vx = 3
                        Case 1
                            vy = -3
                            vx = 4
                        Case 0
                            vy = 0
                            vx = 5
                        Case -1
                            vy = 3
                            vx = 4
                        Case -2
                            vy = 4
                            vx = 3
                        Case -3
                            vy = 5
                            vx = 2
                    End Select
                End If
            Else
                If lblBall.Left <= intLCourt Then
                    pointScored()
                End If
            End If
        ElseIf vx > 0 Then 'ball is moving from left to right
            If lblBall.Top > (lblPaddleRight.Top - intBallH) And lblBall.Top < (lblPaddleRight.Top + intPadRH) Then
                If (lblBall.Left + intBallW) > lblPaddleRight.Left Then
                    getZoneR()
                    Select Case paddleZone
                        Case 3
                            vy = -5
                            vx = -2
                        Case 2
                            vy = -4
                            vx = -3
                        Case 1
                            vy = -3
                            vx = -4
                        Case 0
                            vy = 0
                            vx = -5
                        Case -1
                            vy = 3
                            vx = -4
                        Case -2
                            vy = 4
                            vx = -3
                        Case -3
                            vy = 5
                            vx = -2
                    End Select
                End If
            Else
                If lblBall.Left > (intRcourt - intBallW) Then
                    pointScored()
                End If
            End If
        End If
    End Sub

    Private Sub tmrBreak_Tick(sender As Object, ByVal e As EventArgs) Handles tmrBreak.Tick
        breakCount += 1 'record number of times timer has ticked

        If breakCount = 1 Then 'this is first timer tick
            lblPaddleLeft.Top = intPadLTop 'reset left paddle position
            lblPaddleRight.Top = intPadRTop 'reset right paddle position
            If lastPoint = 1 Then 'computer won last point
                lblBall.Top = lblPaddleLeft.Top + intPadLH / 2 - intBallH / 2
                lblBall.Left = intPadFaceL 'place ball immediately to right of left paddle
                vx = 5 'set ball's x vector value to 5
            ElseIf lastPoint = 2 Then 'player won last point
                lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
                lblBall.Left = intPadFaceR - lblBall.Width
                vx = -5 'set ball's x vector value to -5
            End If
            Randomize()
            vy = (Rnd() * 10) - 5
        ElseIf breakCount = 2 Then 'this is second timer tick
            breakCount = 0 'reset timer counter
            lblBall.Visible = True 'restore visibility of ball
            tmrBall.Start() 'restart tmrBall
            tmrPaddle.Start() 'restart tmrPaddle
            tmrBreak.Stop() 'stop tmrBreak
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, ByVal e As EventArgs) Handles btnPlay.Click
        lblControls.Visible = False
        lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
        lblBall.Left = intPadFaceR - lblBall.Width
        lblBall.Visible = True 'make ball visible
        vx = -5 'set ball's x vector to -5
        Randomize()
        vy = (Rnd() * 10) - 5
        tmrPaddle.Start() 'start tmrPaddle
        tmrBall.Start() 'start tmrBall
        btnPlay.Enabled = False 'disable Start button
    End Sub

    Private Sub btnPause_Click(sender As Object, ByVal e As EventArgs) Handles btnPause.Click
        If btnPause.Text = "PAUSE" Then 'game is in progress
            lblControls.Visible = True
            tmrPaddle.Stop() 'stop tmrPaddle
            tmrBall.Stop() 'stop tmrBall
            btnPause.Text = "RESUME" 'change button caption to "Resume"
        ElseIf btnPause.Text = "RESUME" Then 'game is paused
            lblControls.Visible = False
            tmrPaddle.Start() 'start tmrPaddle
            tmrBall.Start() 'start tmrBall
            btnPause.Text = "PAUSE" 'change button caption to "Pause"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        reset()
        resetScores()
    End Sub

    Private Sub btnExit_Click(sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Sub getZoneR()
        If (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 10) Then
            paddleZone = 3
        ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 20) Then
            paddleZone = 2
        ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 30) Then
            paddleZone = 1
        ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 50) Then
            paddleZone = 0
        ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 60) Then
            paddleZone = -1
        ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleRight.Top + 70) Then
            paddleZone = -2
        Else
            paddleZone = -3
        End If
    End Sub

    Sub pointScored()
        tmrBall.Stop()
        tmrPaddle.Stop() 'stop tmrPaddle
        If lblBall.Left < intPadFaceL Then 'ball has bypassed the left paddle
            scoreRight = scoreRight + 1 'add 1 to player's score
            lastPoint = 2 'player won last point
            lblRightScore.Text = scoreRight 'display new player score
        ElseIf (lblBall.Left + intBallW) > intPadFaceR Then
            scoreLeft = scoreLeft + 1 'add 1 to computer's score
            lastPoint = 1 'computer won last point
            lblLeftScore.Text = scoreLeft 'display new computer score
        End If

        lblBall.Visible = False 'hide ball

        If scoreLeft = winScore Then 'computer has won game
            reset() 'call reset game variables and game display
            MsgBox("Sorry, better luck next time!") 'display consolatory message
            resetScores() 'reset scores and score display
        ElseIf scoreRight = winScore Then 'player has won game
            reset() 'call reset game variables and game display
            MsgBox("Congratulations!") 'display congratulatory message
            resetScores() 'reset scores and score display
        Else
            tmrBreak.Start() 'game still in progress, start tmrBreak
        End If
    End Sub

    Sub reset()
        tmrBall.Stop()
        tmrBreak.Stop()
        tmrPaddle.Stop()
        lblBall.Visible = False
        lblPaddleLeft.Top = intPadLTop
        lblPaddleRight.Top = intPadRTop
        btnPlay.Enabled = True
    End Sub

    Sub resetScores()
        scoreLeft = 0
        scoreRight = 0
        lblLeftScore.Text = "0"
        lblRightScore.Text = "0"
    End Sub

    Private Sub frmPong_MouseDown(sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles Me.MouseDown, picPongTable.MouseDown
        If e.Button = MouseButtons.Right Then 'right mouse button is down
            dnFlag = True 'set dnFlag
        ElseIf e.Button = MouseButtons.Left Then 'left mouse button is down
            upFlag = True 'set upFlag
        End If
    End Sub

    Private Sub frmPong_MouseUp(sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles Me.MouseUp, picPongTable.MouseUp
        If e.Button = MouseButtons.Right Then 'right mouse button has been released
            dnFlag = False 'unset dnFlag
        ElseIf e.Button = MouseButtons.Left Then 'left mouse button has been released
            upFlag = False 'unset upFlag
        End If
    End Sub

End Class