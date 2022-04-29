Public Class frmPainting
    Dim color As Color = Color.Black
    Private doPaint As Boolean = False
    Dim penWidth As Integer = 10
    Dim penHeight As Integer = 10

    Dim pen = New Pen(Brushes.Black, 2)

    Private Sub MouseDown1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        doPaint = True
    End Sub

    Private Sub MouseUp1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        doPaint = False
    End Sub

    Private Sub MouseMove1(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If doPaint Then
            pnlBrushSize.Visible = False
            pnlColors.Visible = False
            Dim g As Graphics = CreateGraphics()
            g.FillEllipse(New SolidBrush(color), e.X, e.Y, penWidth, penHeight)
            g.Dispose()
        End If
    End Sub

    Private Sub ColorPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorPanelToolStripMenuItem.Click
        pnlColors.Visible = True
        Dim pnlG As Graphics = pnlColors.CreateGraphics()
        pnlG.FillEllipse(New SolidBrush(color), 33, 62, 23, 23)
        pnlG.DrawEllipse(pen, 33, 62, 23, 23)
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

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        color = Drawing.Color.Red
        pnlColors.Visible = False
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        color = Drawing.Color.Blue
        pnlColors.Visible = False
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        color = Drawing.Color.Green
        pnlColors.Visible = False
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        color = Drawing.Color.Orange
        pnlColors.Visible = False
    End Sub

    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click
        color = Drawing.Color.SaddleBrown
        pnlColors.Visible = False
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        color = Drawing.Color.Black
        pnlColors.Visible = False
    End Sub

    Private Sub EraserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EraserToolStripMenuItem.Click
        color = Me.BackColor
        pnlColors.Visible = False
    End Sub

    Private Sub BW5_Click(sender As Object, e As EventArgs) Handles BW5.Click
        penWidth = 5
    End Sub

    Private Sub BW10_Click(sender As Object, e As EventArgs) Handles BW10.Click
        penWidth = 10
    End Sub

    Private Sub BW15_Click(sender As Object, e As EventArgs) Handles BW15.Click
        penWidth = 15
    End Sub

    Private Sub BW20_Click(sender As Object, e As EventArgs) Handles BW20.Click
        penWidth = 20
    End Sub

    Private Sub BW25_Click(sender As Object, e As EventArgs) Handles BW25.Click
        penWidth = 25
    End Sub

    Private Sub BW30_Click(sender As Object, e As EventArgs) Handles BW30.Click
        penWidth = 30
    End Sub

    Private Sub BH5_Click(sender As Object, e As EventArgs) Handles BH5.Click
        penHeight = 5
    End Sub

    Private Sub BH10_Click(sender As Object, e As EventArgs) Handles BH10.Click
        penHeight = 10
    End Sub

    Private Sub BH15_Click(sender As Object, e As EventArgs) Handles BH15.Click
        penHeight = 15
    End Sub

    Private Sub BH20_Click(sender As Object, e As EventArgs) Handles BH20.Click
        penHeight = 20
    End Sub

    Private Sub BH25_Click(sender As Object, e As EventArgs) Handles BH25.Click
        penHeight = 25
    End Sub

    Private Sub BH30_Click(sender As Object, e As EventArgs) Handles BH30.Click
        penHeight = 30
    End Sub

    Private Sub BS5_Click(sender As Object, e As EventArgs) Handles BS5.Click
        penWidth = 5
        penHeight = 5
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BS10_Click(sender As Object, e As EventArgs) Handles BS10.Click
        penWidth = 10
        penHeight = 10
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BS15_Click(sender As Object, e As EventArgs) Handles BS15.Click
        penWidth = 15
        penHeight = 15
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BS20_Click(sender As Object, e As EventArgs) Handles BS20.Click
        penWidth = 20
        penHeight = 20
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BS25_Click(sender As Object, e As EventArgs) Handles BS25.Click
        penWidth = 25
        penHeight = 25
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BS30_Click(sender As Object, e As EventArgs) Handles BS30.Click
        penWidth = 30
        penHeight = 30
        pnlBrushSize.Visible = False
    End Sub

    Private Sub BrushSizesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrushSizesToolStripMenuItem.Click
        pnlBrushSize.Visible = True
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Call Me.Invalidate()
    End Sub

    Private Sub ColorDialogueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorDialogueToolStripMenuItem.Click
        If Colors.ShowDialog() = DialogResult.OK Then
            color = Colors.Color
        End If
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If Colors.ShowDialog() = DialogResult.OK Then
            BackColor = Colors.Color
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
