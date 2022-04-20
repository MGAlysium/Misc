Public Class frmManBearGun
    Dim wins As Integer = 0
    Dim ties As Integer = 0
    Dim loss As Integer = 0

    Dim winner As String = ""
    Dim comPlay As String = ""

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnMan_Click(sender As Object, e As EventArgs) Handles btnMan.Click
        Dim rndNum As New Random
        Dim comOut As Integer = rndNum.Next(3) + 1

        picPlayer.Image = Global.ManBearGunApp.My.Resources.Resources.Man_Image

        If comOut = 1 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Man_Image
            winner = "It's A Tie!"
            comPlay = "Man"
            ties += 1
        ElseIf comOut = 2 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Bear_Image
            winner = "Computer Wins!"
            comPlay = "Bear"
            loss += 1
        Else
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Gun_Image
            winner = "Player Wins!"
            comPlay = "Gun"
            wins += 1
        End If

        UpdateText()
    End Sub
    
    Private Sub btnBear_Click(sender As Object, e As EventArgs) Handles btnBear.Click
        Dim rndNum As New Random
        Dim comOut As Integer = rndNum.Next(3) + 1

        picPlayer.Image = Global.ManBearGunApp.My.Resources.Resources.Bear_Image

        If comOut = 2 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Bear_Image
            winner = "It's A Tie!"
            comPlay = "Bear"
            ties += 1
        ElseIf comOut = 3 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Gun_Image
            winner = "Computer Wins!"
            comPlay = "Gun"
            loss += 1
        Else
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Man_Image
            winner = "Player Wins!"
            comPlay = "Man"
            wins += 1
        End If

        UpdateText()
    End Sub

    Private Sub btnGun_Click(sender As Object, e As EventArgs) Handles btnGun.Click
        Dim rndNum As New Random
        Dim comOut As Integer = rndNum.Next(3) + 1

        picPlayer.Image = Global.ManBearGunApp.My.Resources.Resources.Gun_Image

        If comOut = 3 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Gun_Image
            winner = "It's A Tie!"
            comPlay = "Gun"
            ties += 1
        ElseIf comOut = 1 Then
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Man_Image
            winner = "Computer Wins!"
            comPlay = "Man"
            loss += 1
        Else
            picCom.Image = Global.ManBearGunApp.My.Resources.Resources.Bear_Image
            winner = "Player Wins!"
            comPlay = "Bear"
            wins += 1
        End If

        UpdateText()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        winner = ""
        wins = 0
        ties = 0
        loss = 0
        comPlay = ""

        picCom.Image = Nothing
        picPlayer.Image = Nothing

        UpdateText()
    End Sub

    Private Sub UpdateText()
        lblWinner.Text = winner
        lblWins.Text = "Wins: " & wins
        lblTies.Text = "Ties: " & ties
        lblLosses.Text = "Losses: " & loss
        TestingLabel.Text = "Generated: " & comPlay
    End Sub
End Class
