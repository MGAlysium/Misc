<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblBall = New System.Windows.Forms.Label()
        Me.lblPaddleLeft = New System.Windows.Forms.Label()
        Me.lblPaddleRight = New System.Windows.Forms.Label()
        Me.lblLeftScore = New System.Windows.Forms.Label()
        Me.lblRightScore = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrBall = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPaddle = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBreak = New System.Windows.Forms.Timer(Me.components)
        Me.lblControls = New System.Windows.Forms.Label()
        Me.picPongTable = New System.Windows.Forms.PictureBox()
        CType(Me.picPongTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBall
        '
        Me.lblBall.BackColor = System.Drawing.Color.Teal
        Me.lblBall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBall.Location = New System.Drawing.Point(324, 244)
        Me.lblBall.Name = "lblBall"
        Me.lblBall.Size = New System.Drawing.Size(16, 16)
        Me.lblBall.TabIndex = 1
        Me.lblBall.Visible = False
        '
        'lblPaddleLeft
        '
        Me.lblPaddleLeft.BackColor = System.Drawing.Color.Teal
        Me.lblPaddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaddleLeft.Location = New System.Drawing.Point(23, 212)
        Me.lblPaddleLeft.Name = "lblPaddleLeft"
        Me.lblPaddleLeft.Size = New System.Drawing.Size(16, 80)
        Me.lblPaddleLeft.TabIndex = 2
        '
        'lblPaddleRight
        '
        Me.lblPaddleRight.BackColor = System.Drawing.Color.Teal
        Me.lblPaddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaddleRight.Location = New System.Drawing.Point(625, 212)
        Me.lblPaddleRight.Name = "lblPaddleRight"
        Me.lblPaddleRight.Size = New System.Drawing.Size(16, 80)
        Me.lblPaddleRight.TabIndex = 3
        '
        'lblLeftScore
        '
        Me.lblLeftScore.AutoSize = True
        Me.lblLeftScore.BackColor = System.Drawing.Color.Silver
        Me.lblLeftScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblLeftScore.ForeColor = System.Drawing.Color.Teal
        Me.lblLeftScore.Location = New System.Drawing.Point(210, 40)
        Me.lblLeftScore.Name = "lblLeftScore"
        Me.lblLeftScore.Size = New System.Drawing.Size(35, 37)
        Me.lblLeftScore.TabIndex = 4
        Me.lblLeftScore.Text = "0"
        '
        'lblRightScore
        '
        Me.lblRightScore.AutoSize = True
        Me.lblRightScore.BackColor = System.Drawing.Color.Silver
        Me.lblRightScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lblRightScore.ForeColor = System.Drawing.Color.Teal
        Me.lblRightScore.Location = New System.Drawing.Point(420, 40)
        Me.lblRightScore.Name = "lblRightScore"
        Me.lblRightScore.Size = New System.Drawing.Size(35, 37)
        Me.lblRightScore.TabIndex = 5
        Me.lblRightScore.Text = "0"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPlay.Location = New System.Drawing.Point(334, 507)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPause.Location = New System.Drawing.Point(415, 507)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 7
        Me.btnPause.Text = "PAUSE"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(496, 507)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(577, 507)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tmrBall
        '
        Me.tmrBall.Interval = 10
        '
        'tmrPaddle
        '
        Me.tmrPaddle.Interval = 10
        '
        'tmrBreak
        '
        Me.tmrBreak.Interval = 1000
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.BackColor = System.Drawing.Color.Silver
        Me.lblControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls.ForeColor = System.Drawing.Color.Teal
        Me.lblControls.Location = New System.Drawing.Point(355, 77)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(286, 100)
        Me.lblControls.TabIndex = 10
        Me.lblControls.Text = "You Are The Right Paddle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Left Click = Up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right Click = Down"
        Me.lblControls.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picPongTable
        '
        Me.picPongTable.Image = Global.Pong.My.Resources.Resources.pong_table_1_png
        Me.picPongTable.Location = New System.Drawing.Point(12, 12)
        Me.picPongTable.Name = "picPongTable"
        Me.picPongTable.Size = New System.Drawing.Size(640, 480)
        Me.picPongTable.TabIndex = 0
        Me.picPongTable.TabStop = False
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(664, 541)
        Me.Controls.Add(Me.lblControls)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblPaddleRight)
        Me.Controls.Add(Me.lblPaddleLeft)
        Me.Controls.Add(Me.lblBall)
        Me.Controls.Add(Me.lblLeftScore)
        Me.Controls.Add(Me.lblRightScore)
        Me.Controls.Add(Me.picPongTable)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.Name = "frmPong"
        Me.Text = "Pong"
        CType(Me.picPongTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPongTable As System.Windows.Forms.PictureBox
    Friend WithEvents lblBall As System.Windows.Forms.Label
    Friend WithEvents lblPaddleLeft As System.Windows.Forms.Label
    Friend WithEvents lblPaddleRight As System.Windows.Forms.Label
    Friend WithEvents lblLeftScore As System.Windows.Forms.Label
    Friend WithEvents lblRightScore As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tmrBall As System.Windows.Forms.Timer
    Friend WithEvents tmrPaddle As System.Windows.Forms.Timer
    Friend WithEvents tmrBreak As System.Windows.Forms.Timer
    Friend WithEvents lblControls As System.Windows.Forms.Label

End Class
