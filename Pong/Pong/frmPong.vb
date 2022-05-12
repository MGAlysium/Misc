Public Class frmPong
    Dim vx, vy As Single

    Dim paddleZone As Integer
    Dim winScore As Integer = 5
    Dim scoreLeft, scoreRight, lastPoint As Integer
    Dim breakCount As Integer = 0
    Dim intLCourt, intRcourt, intTCourt, intBCourt, intCCourt As Integer
    Dim intBallW, intBallH As Integer
    Dim intPadLH, intPadRH As Integer
    Dim intPadLTop, intPadRTop As Integer

    Dim upFlag As Boolean = False
    Dim dnFlag As Boolean = False

    Dim intPadFaceL, intPadFaceR

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
                    lblPaddleLeft.Top += 4
                End If
            ElseIf (lblBall.Top + intBallH / 2) < (lblPaddleLeft.Top + intPadLH / 2) Then
                If lblPaddleLeft.Top > intTCourt Then
                    lblPaddleLeft.Top -= 4
                End If
            End If
        Else
            If lblPaddleLeft.Top < intPadLTop Then
                lblPaddleLeft.Top += 1
            ElseIf lblPaddleLeft.Top > intPadLTop Then
                lblPaddleLeft.Top -= 1
            End If
        End If

        If lblPaddleLeft.Top < intTCourt Then
            lblPaddleLeft.Top = intTCourt
        ElseIf lblPaddleLeft.Top > (intBCourt - intPadLH) Then
            lblPaddleLeft.Top = (intBCourt - intPadLH)
        End If

        If upFlag = True And lblPaddleRight.Top > intTCourt Then
            lblPaddleRight.Top -= 4
        ElseIf dnFlag = True And lblPaddleRight.Top < (intBCourt - intPadRH) Then
            lblPaddleRight.Top += 4
        End If

        If lblPaddleRight.Top < intTCourt Then
            lblPaddleRight.Top = intTCourt
        ElseIf lblPaddleRight.Top > (intBCourt - intPadRH) Then
            lblPaddleRight.Top = (intBCourt - intPadRH)
        End If
    End Sub

    Private Sub tmrBall_Tick(sender As Object, ByVal e As EventArgs) Handles tmrBall.Tick
        lblBall.Top = lblBall.Top + vy
        lblBall.Left = lblBall.Left + vx

        If lblBall.Top < intTCourt Then lblBall.Top = intTCourt

        If lblBall.Top > (intBCourt - intBallH) Then lblBall.Top = (intBCourt - intBallH)

        If lblBall.Top <= intTCourt Or lblBall.Top >= (intBCourt - intBallH) Then vy = -vy

        If vx < 0 Then
            If lblBall.Top > (lblPaddleLeft.Top - intBallH) And lblBall.Top < (lblPaddleLeft.Top + intPadLH) Then
                If lblBall.Left <= intPadFaceL Then
                    Randomize()
                    paddleZone = CInt((Rnd() * 6) - 3)
                    Select Case paddleZone
                        Case 3
                            vy = -5
                            vx = 5
                        Case 2
                            vy = -4
                            vx = 6
                        Case 1
                            vy = -3
                            vx = 7
                        Case 0
                            vy = 0
                            vx = 8
                        Case -1
                            vy = 3
                            vx = 7
                        Case -2
                            vy = 4
                            vx = 6
                        Case -3
                            vy = 5
                            vx = 5
                    End Select
                End If
            Else
                If lblBall.Left <= intLCourt Then
                    pointScored()
                End If
            End If
        ElseIf vx > 0 Then
            If lblBall.Top > (lblPaddleRight.Top - intBallH) And lblBall.Top < (lblPaddleRight.Top + intPadRH) Then
                If (lblBall.Left + intBallW) > lblPaddleRight.Left Then
                    getZoneR()
                    Select Case paddleZone
                        Case 3
                            vy = -5
                            vx = -5
                        Case 2
                            vy = -4
                            vx = -6
                        Case 1
                            vy = -3
                            vx = -7
                        Case 0
                            vy = 0
                            vx = -8
                        Case -1
                            vy = 3
                            vx = -7
                        Case -2
                            vy = 4
                            vx = -6
                        Case -3
                            vy = 5
                            vx = -5
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
        breakCount += 1

        If breakCount = 1 Then
            lblPaddleLeft.Top = intPadLTop
            lblPaddleRight.Top = intPadRTop
            If lastPoint = 1 Then
                lblBall.Top = lblPaddleLeft.Top + intPadLH / 2 - intBallH / 2
                lblBall.Left = intPadFaceL
                vx = 8
            ElseIf lastPoint = 2 Then
                lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
                lblBall.Left = intPadFaceR - lblBall.Width
                vx = -8
            End If
            Randomize()
            vy = (Rnd() * 10) - 5
        ElseIf breakCount = 2 Then
            breakCount = 0
            lblBall.Visible = True
            tmrBall.Start()
            tmrPaddle.Start()
            tmrBreak.Stop()
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, ByVal e As EventArgs) Handles btnPlay.Click
        lblControls.Visible = False
        lblBall.Top = lblPaddleRight.Top + intPadRH / 2 - intBallH / 2
        lblBall.Left = intPadFaceR - lblBall.Width
        lblBall.Visible = True
        vx = -8
        Randomize()
        vy = (Rnd() * 10) - 5
        tmrPaddle.Start()
        tmrBall.Start()
        btnPlay.Enabled = False
    End Sub

    Private Sub btnPause_Click(sender As Object, ByVal e As EventArgs) Handles btnPause.Click
        If btnPause.Text = "PAUSE" Then
            lblControls.Visible = True
            tmrPaddle.Stop()
            tmrBall.Stop()
            btnPause.Text = "RESUME"
        ElseIf btnPause.Text = "RESUME" Then
            lblControls.Visible = False
            tmrPaddle.Start()
            tmrBall.Start()
            btnPause.Text = "PAUSE"
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
        tmrPaddle.Stop()
        If lblBall.Left < intPadFaceL Then
            scoreRight = scoreRight + 1
            lastPoint = 2
            lblRightScore.Text = scoreRight
        ElseIf (lblBall.Left + intBallW) > intPadFaceR Then
            scoreLeft = scoreLeft + 1
            lastPoint = 1
            lblLeftScore.Text = scoreLeft
        End If

        lblBall.Visible = False

        If scoreLeft = winScore Then
            reset()
            MsgBox("Sorry, better luck next time!")
            resetScores()
        ElseIf scoreRight = winScore Then
            reset()
            MsgBox("Congratulations!")
            resetScores()
        Else
            tmrBreak.Start()
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
        If e.Button = MouseButtons.Right Then
            dnFlag = True
        ElseIf e.Button = MouseButtons.Left Then
            upFlag = True
        End If
    End Sub

    Private Sub frmPong_MouseUp(sender As Object, ByVal e As Windows.Forms.MouseEventArgs) Handles Me.MouseUp, picPongTable.MouseUp
        If e.Button = MouseButtons.Right Then
            dnFlag = False
        ElseIf e.Button = MouseButtons.Left Then
            upFlag = False
        End If
    End Sub

End Class