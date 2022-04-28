Public Class frmPainting
    Dim color As Color = Color.Black
    Private doPaint As Boolean = False
    Dim penWidth As Integer = 10
    Dim penHeight As Integer = 10

    Private Sub MouseDown1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        doPaint = True
    End Sub

    Private Sub MouseUp1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        doPaint = False
    End Sub

    Private Sub MouseMove1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If doPaint Then
            Dim g As Graphics = CreateGraphics()
            g.FillEllipse(New SolidBrush(color), e.X, e.Y, penWidth, penHeight)
            g.Dispose()
        End If
    End Sub

    Private Sub ColorPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorPanelToolStripMenuItem.Click
        pnlColors.Visible = True
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        color = Drawing.Color.Red
        pnlColors.Visible = False
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        color = Drawing.Color.Blue
        pnlColors.Visible = False
    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        color = Drawing.Color.Green
        pnlColors.Visible = False
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        color = Drawing.Color.Orange
        pnlColors.Visible = False
    End Sub

    Private Sub btnBrown_Click(sender As Object, e As EventArgs) Handles btnBrown.Click
        color = Drawing.Color.SaddleBrown
        pnlColors.Visible = False
    End Sub

    Private Sub btnBlack_Click(sender As Object, e As EventArgs) Handles btnBlack.Click
        color = Drawing.Color.Black
        pnlColors.Visible = False
    End Sub
End Class
