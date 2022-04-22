Public Class frmSmile
    Dim pupilLX As Integer = 215
    Dim pupilLY As Integer = 84
    Dim pupilRX As Integer = 254
    Dim pupilRY As Integer = 84

    Dim pen As New Pen(Brushes.Black, 2)
    Dim pnt As Graphics

    Private Sub DrawFace()
        pnt = Me.CreateGraphics
        pnt.Clear(Color.Silver)
        pnt.FillEllipse(Brushes.Yellow, 165, 50, 150, 150)
        pnt.DrawEllipse(pen, 165, 50, 150, 150)
        pnt.FillEllipse(Brushes.White, 200, 70, 30, 50)
        pnt.DrawEllipse(pen, 200, 70, 30, 50)
        pnt.FillEllipse(Brushes.White, 255, 70, 30, 50)
        pnt.DrawEllipse(pen, 255, 70, 30, 50)
        pnt.FillEllipse(Brushes.Purple, pupilLX, pupilLY, 15, 25)
        pnt.DrawEllipse(pen, pupilLX, pupilLY, 15, 25)
        pnt.FillEllipse(Brushes.Purple, pupilRX, pupilRY, 15, 25)
        pnt.DrawEllipse(pen, pupilRX, pupilRY, 15, 25)
        pnt.DrawArc(pen, 200, 115, 85, 50, 0, 180)
    End Sub

    Private Sub btnLL_Click(sender As Object, e As EventArgs) Handles btnLL.Click
        pupilLX -= 2
        DrawFace()
    End Sub

    Private Sub btnLU_Click(sender As Object, e As EventArgs) Handles btnLU.Click
        pupilLY -= 2
        DrawFace()
    End Sub

    Private Sub btnLR_Click(sender As Object, e As EventArgs) Handles btnLR.Click
        pupilLX += 2
        DrawFace()
    End Sub

    Private Sub btnLD_Click(sender As Object, e As EventArgs) Handles btnLD.Click
        pupilLY += 2
        DrawFace()
    End Sub

    Private Sub btnRL_Click(sender As Object, e As EventArgs) Handles btnRL.Click
        pupilRX -= 2
        DrawFace()
    End Sub

    Private Sub btnRU_Click(sender As Object, e As EventArgs) Handles btnRU.Click
        pupilRY -= 2
        DrawFace()
    End Sub

    Private Sub btnRR_Click(sender As Object, e As EventArgs) Handles btnRR.Click
        pupilRX += 2
        DrawFace()
    End Sub

    Private Sub btnRD_Click(sender As Object, e As EventArgs) Handles btnRD.Click
        pupilRY += 2
        DrawFace()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        DrawFace()
        btnStart.Visible = False
        btnLD.Enabled = True
        btnRD.Enabled = True
        btnLL.Enabled = True
        btnRL.Enabled = True
        btnLU.Enabled = True
        btnRU.Enabled = True
        btnLR.Enabled = True
        btnRR.Enabled = True
    End Sub
End Class
