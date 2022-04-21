<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManBearGun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManBearGun))
        Me.lblCom = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.btnMan = New System.Windows.Forms.Button()
        Me.btnBear = New System.Windows.Forms.Button()
        Me.btnGun = New System.Windows.Forms.Button()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblTies = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TestingLabel = New System.Windows.Forms.Label()
        Me.picInfoBG = New System.Windows.Forms.PictureBox()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picCom = New System.Windows.Forms.PictureBox()
        CType(Me.picInfoBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCom
        '
        Me.lblCom.AutoSize = True
        Me.lblCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCom.ForeColor = System.Drawing.Color.Teal
        Me.lblCom.Location = New System.Drawing.Point(59, 72)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(89, 19)
        Me.lblCom.TabIndex = 0
        Me.lblCom.Text = "Computer"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlayer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.Teal
        Me.lblPlayer.Location = New System.Drawing.Point(351, 72)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(61, 19)
        Me.lblPlayer.TabIndex = 1
        Me.lblPlayer.Text = "Player"
        '
        'btnMan
        '
        Me.btnMan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMan.ForeColor = System.Drawing.Color.Teal
        Me.btnMan.Location = New System.Drawing.Point(53, 331)
        Me.btnMan.Name = "btnMan"
        Me.btnMan.Size = New System.Drawing.Size(101, 23)
        Me.btnMan.TabIndex = 4
        Me.btnMan.Text = "Man"
        Me.btnMan.UseVisualStyleBackColor = False
        '
        'btnBear
        '
        Me.btnBear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBear.ForeColor = System.Drawing.Color.Teal
        Me.btnBear.Location = New System.Drawing.Point(192, 331)
        Me.btnBear.Name = "btnBear"
        Me.btnBear.Size = New System.Drawing.Size(101, 23)
        Me.btnBear.TabIndex = 5
        Me.btnBear.Text = "Bear"
        Me.btnBear.UseVisualStyleBackColor = False
        '
        'btnGun
        '
        Me.btnGun.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGun.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGun.ForeColor = System.Drawing.Color.Teal
        Me.btnGun.Location = New System.Drawing.Point(331, 331)
        Me.btnGun.Name = "btnGun"
        Me.btnGun.Size = New System.Drawing.Size(101, 23)
        Me.btnGun.TabIndex = 6
        Me.btnGun.Text = "(Nerf) Gun"
        Me.btnGun.UseVisualStyleBackColor = False
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblWins.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWins.Location = New System.Drawing.Point(69, 385)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(69, 19)
        Me.lblWins.TabIndex = 9
        Me.lblWins.Text = "Wins: 0"
        '
        'lblTies
        '
        Me.lblTies.AutoSize = True
        Me.lblTies.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTies.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTies.Location = New System.Drawing.Point(210, 385)
        Me.lblTies.Name = "lblTies"
        Me.lblTies.Size = New System.Drawing.Size(64, 19)
        Me.lblTies.TabIndex = 10
        Me.lblTies.Text = "Ties: 0"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLosses.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLosses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLosses.Location = New System.Drawing.Point(340, 385)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(83, 19)
        Me.lblLosses.TabIndex = 11
        Me.lblLosses.Text = "Losses: 0"
        '
        'lblWinner
        '
        Me.lblWinner.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblWinner.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.Teal
        Me.lblWinner.Location = New System.Drawing.Point(187, 291)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(111, 23)
        Me.lblWinner.TabIndex = 12
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Teal
        Me.btnExit.Location = New System.Drawing.Point(331, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Teal
        Me.btnClear.Location = New System.Drawing.Point(53, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'TestingLabel
        '
        Me.TestingLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TestingLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestingLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TestingLabel.Location = New System.Drawing.Point(188, 426)
        Me.TestingLabel.Name = "TestingLabel"
        Me.TestingLabel.Size = New System.Drawing.Size(108, 13)
        Me.TestingLabel.TabIndex = 15
        Me.TestingLabel.Text = "Generated: "
        Me.TestingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picInfoBG
        '
        Me.picInfoBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picInfoBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picInfoBG.Location = New System.Drawing.Point(-7, 360)
        Me.picInfoBG.Name = "picInfoBG"
        Me.picInfoBG.Size = New System.Drawing.Size(498, 106)
        Me.picInfoBG.TabIndex = 8
        Me.picInfoBG.TabStop = False
        '
        'picTitle
        '
        Me.picTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picTitle.Image = Global.ManBearGunApp.My.Resources.Resources.Man_Bear_Gun_Logo
        Me.picTitle.Location = New System.Drawing.Point(-52, -8)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(588, 378)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 7
        Me.picTitle.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Silver
        Me.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPlayer.Location = New System.Drawing.Point(299, 94)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(164, 122)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 3
        Me.picPlayer.TabStop = False
        '
        'picCom
        '
        Me.picCom.BackColor = System.Drawing.Color.Silver
        Me.picCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCom.Location = New System.Drawing.Point(21, 94)
        Me.picCom.Name = "picCom"
        Me.picCom.Size = New System.Drawing.Size(164, 122)
        Me.picCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCom.TabIndex = 2
        Me.picCom.TabStop = False
        '
        'frmManBearGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.TestingLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblTies)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.picInfoBG)
        Me.Controls.Add(Me.btnGun)
        Me.Controls.Add(Me.btnBear)
        Me.Controls.Add(Me.btnMan)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picCom)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblCom)
        Me.Controls.Add(Me.picTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManBearGun"
        Me.Text = "Man Bear Gun"
        CType(Me.picInfoBG,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picTitle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picPlayer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picCom,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblCom As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents picCom As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents btnMan As System.Windows.Forms.Button
    Friend WithEvents btnBear As System.Windows.Forms.Button
    Friend WithEvents btnGun As System.Windows.Forms.Button
    Friend WithEvents picTitle As System.Windows.Forms.PictureBox
    Friend WithEvents picInfoBG As System.Windows.Forms.PictureBox
    Friend WithEvents lblWins As System.Windows.Forms.Label
    Friend WithEvents lblTies As System.Windows.Forms.Label
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TestingLabel As System.Windows.Forms.Label

End Class
