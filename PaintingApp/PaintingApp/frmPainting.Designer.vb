<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPainting
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EraserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushSizesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushWidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BW30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushHeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BH30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlColors = New System.Windows.Forms.Panel()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.btnBrown = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.pnlBrushSize = New System.Windows.Forms.Panel()
        Me.BS30 = New System.Windows.Forms.Button()
        Me.BS25 = New System.Windows.Forms.Button()
        Me.BS20 = New System.Windows.Forms.Button()
        Me.BS15 = New System.Windows.Forms.Button()
        Me.BS10 = New System.Windows.Forms.Button()
        Me.BS5 = New System.Windows.Forms.Button()
        Me.Colors = New System.Windows.Forms.ColorDialog()
        Me.ColorDialogueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlColors.SuspendLayout()
        Me.pnlBrushSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ColorsToolStripMenuItem, Me.BrushesToolStripMenuItem, Me.BackgroundToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(546, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EraserToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EraserToolStripMenuItem
        '
        Me.EraserToolStripMenuItem.Name = "EraserToolStripMenuItem"
        Me.EraserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EraserToolStripMenuItem.Text = "E&raser"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearAllToolStripMenuItem.Text = "&Clear All"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorPanelToolStripMenuItem, Me.ColorDialogueToolStripMenuItem, Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.BrownToolStripMenuItem, Me.BlackToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ColorsToolStripMenuItem.Text = "&Colors"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'BrownToolStripMenuItem
        '
        Me.BrownToolStripMenuItem.Name = "BrownToolStripMenuItem"
        Me.BrownToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BrownToolStripMenuItem.Text = "Brown"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'ColorPanelToolStripMenuItem
        '
        Me.ColorPanelToolStripMenuItem.Name = "ColorPanelToolStripMenuItem"
        Me.ColorPanelToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ColorPanelToolStripMenuItem.Text = "Color Panel"
        '
        'BrushesToolStripMenuItem
        '
        Me.BrushesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrushSizesToolStripMenuItem, Me.BrushWidthToolStripMenuItem, Me.BrushHeightToolStripMenuItem})
        Me.BrushesToolStripMenuItem.Name = "BrushesToolStripMenuItem"
        Me.BrushesToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.BrushesToolStripMenuItem.Text = "&Brushes"
        '
        'BrushSizesToolStripMenuItem
        '
        Me.BrushSizesToolStripMenuItem.Name = "BrushSizesToolStripMenuItem"
        Me.BrushSizesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrushSizesToolStripMenuItem.Text = "&Brush Sizes"
        '
        'BrushWidthToolStripMenuItem
        '
        Me.BrushWidthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BW5, Me.BW10, Me.BW15, Me.BW20, Me.BW25, Me.BW30})
        Me.BrushWidthToolStripMenuItem.Name = "BrushWidthToolStripMenuItem"
        Me.BrushWidthToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrushWidthToolStripMenuItem.Text = "Brush Width"
        '
        'BW5
        '
        Me.BW5.Name = "BW5"
        Me.BW5.Size = New System.Drawing.Size(152, 22)
        Me.BW5.Text = "5"
        '
        'BW10
        '
        Me.BW10.Name = "BW10"
        Me.BW10.Size = New System.Drawing.Size(152, 22)
        Me.BW10.Text = "10"
        '
        'BW15
        '
        Me.BW15.Name = "BW15"
        Me.BW15.Size = New System.Drawing.Size(152, 22)
        Me.BW15.Text = "15"
        '
        'BW20
        '
        Me.BW20.Name = "BW20"
        Me.BW20.Size = New System.Drawing.Size(152, 22)
        Me.BW20.Text = "20"
        '
        'BW25
        '
        Me.BW25.Name = "BW25"
        Me.BW25.Size = New System.Drawing.Size(152, 22)
        Me.BW25.Text = "25"
        '
        'BW30
        '
        Me.BW30.Name = "BW30"
        Me.BW30.Size = New System.Drawing.Size(152, 22)
        Me.BW30.Text = "30"
        '
        'BrushHeightToolStripMenuItem
        '
        Me.BrushHeightToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BH5, Me.BH10, Me.BH15, Me.BH20, Me.BH25, Me.BH30})
        Me.BrushHeightToolStripMenuItem.Name = "BrushHeightToolStripMenuItem"
        Me.BrushHeightToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrushHeightToolStripMenuItem.Text = "Brush Height"
        '
        'BH5
        '
        Me.BH5.Name = "BH5"
        Me.BH5.Size = New System.Drawing.Size(152, 22)
        Me.BH5.Text = "5"
        '
        'BH10
        '
        Me.BH10.Name = "BH10"
        Me.BH10.Size = New System.Drawing.Size(152, 22)
        Me.BH10.Text = "10"
        '
        'BH15
        '
        Me.BH15.Name = "BH15"
        Me.BH15.Size = New System.Drawing.Size(152, 22)
        Me.BH15.Text = "15"
        '
        'BH20
        '
        Me.BH20.Name = "BH20"
        Me.BH20.Size = New System.Drawing.Size(152, 22)
        Me.BH20.Text = "20"
        '
        'BH25
        '
        Me.BH25.Name = "BH25"
        Me.BH25.Size = New System.Drawing.Size(152, 22)
        Me.BH25.Text = "25"
        '
        'BH30
        '
        Me.BH30.Name = "BH30"
        Me.BH30.Size = New System.Drawing.Size(152, 22)
        Me.BH30.Text = "30"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem})
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.BackgroundToolStripMenuItem.Text = "Back&ground"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Back&ground Color"
        '
        'pnlColors
        '
        Me.pnlColors.BackColor = System.Drawing.Color.Silver
        Me.pnlColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlColors.Controls.Add(Me.btnBlack)
        Me.pnlColors.Controls.Add(Me.btnBrown)
        Me.pnlColors.Controls.Add(Me.btnOrange)
        Me.pnlColors.Controls.Add(Me.btnGreen)
        Me.pnlColors.Controls.Add(Me.btnBlue)
        Me.pnlColors.Controls.Add(Me.btnRed)
        Me.pnlColors.Location = New System.Drawing.Point(439, 28)
        Me.pnlColors.Name = "pnlColors"
        Me.pnlColors.Size = New System.Drawing.Size(95, 95)
        Me.pnlColors.TabIndex = 1
        Me.pnlColors.Visible = False
        '
        'btnBlack
        '
        Me.btnBlack.BackColor = System.Drawing.Color.Black
        Me.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlack.Location = New System.Drawing.Point(62, 33)
        Me.btnBlack.Name = "btnBlack"
        Me.btnBlack.Size = New System.Drawing.Size(23, 23)
        Me.btnBlack.TabIndex = 2
        Me.btnBlack.UseVisualStyleBackColor = False
        '
        'btnBrown
        '
        Me.btnBrown.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrown.Location = New System.Drawing.Point(33, 33)
        Me.btnBrown.Name = "btnBrown"
        Me.btnBrown.Size = New System.Drawing.Size(23, 23)
        Me.btnBrown.TabIndex = 2
        Me.btnBrown.UseVisualStyleBackColor = False
        '
        'btnOrange
        '
        Me.btnOrange.BackColor = System.Drawing.Color.Orange
        Me.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrange.Location = New System.Drawing.Point(4, 33)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(23, 23)
        Me.btnOrange.TabIndex = 2
        Me.btnOrange.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.BackColor = System.Drawing.Color.Green
        Me.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGreen.Location = New System.Drawing.Point(62, 4)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(23, 23)
        Me.btnGreen.TabIndex = 2
        Me.btnGreen.UseVisualStyleBackColor = False
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.Color.Blue
        Me.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlue.Location = New System.Drawing.Point(33, 4)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(23, 23)
        Me.btnBlue.TabIndex = 2
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnRed
        '
        Me.btnRed.BackColor = System.Drawing.Color.Red
        Me.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRed.Location = New System.Drawing.Point(4, 4)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(23, 23)
        Me.btnRed.TabIndex = 0
        Me.btnRed.UseVisualStyleBackColor = False
        '
        'pnlBrushSize
        '
        Me.pnlBrushSize.BackColor = System.Drawing.Color.Silver
        Me.pnlBrushSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBrushSize.Controls.Add(Me.BS30)
        Me.pnlBrushSize.Controls.Add(Me.BS25)
        Me.pnlBrushSize.Controls.Add(Me.BS20)
        Me.pnlBrushSize.Controls.Add(Me.BS15)
        Me.pnlBrushSize.Controls.Add(Me.BS10)
        Me.pnlBrushSize.Controls.Add(Me.BS5)
        Me.pnlBrushSize.Location = New System.Drawing.Point(491, 129)
        Me.pnlBrushSize.Name = "pnlBrushSize"
        Me.pnlBrushSize.Size = New System.Drawing.Size(43, 147)
        Me.pnlBrushSize.TabIndex = 2
        Me.pnlBrushSize.Visible = False
        '
        'BS30
        '
        Me.BS30.BackColor = System.Drawing.Color.Black
        Me.BS30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS30.Location = New System.Drawing.Point(4, 108)
        Me.BS30.Name = "BS30"
        Me.BS30.Size = New System.Drawing.Size(30, 30)
        Me.BS30.TabIndex = 2
        Me.BS30.UseVisualStyleBackColor = False
        '
        'BS25
        '
        Me.BS25.BackColor = System.Drawing.Color.Black
        Me.BS25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS25.Location = New System.Drawing.Point(4, 77)
        Me.BS25.Name = "BS25"
        Me.BS25.Size = New System.Drawing.Size(25, 25)
        Me.BS25.TabIndex = 2
        Me.BS25.UseVisualStyleBackColor = False
        '
        'BS20
        '
        Me.BS20.BackColor = System.Drawing.Color.Black
        Me.BS20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS20.Location = New System.Drawing.Point(4, 51)
        Me.BS20.Name = "BS20"
        Me.BS20.Size = New System.Drawing.Size(20, 20)
        Me.BS20.TabIndex = 2
        Me.BS20.UseVisualStyleBackColor = False
        '
        'BS15
        '
        Me.BS15.BackColor = System.Drawing.Color.Black
        Me.BS15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS15.Location = New System.Drawing.Point(4, 30)
        Me.BS15.Name = "BS15"
        Me.BS15.Size = New System.Drawing.Size(15, 15)
        Me.BS15.TabIndex = 2
        Me.BS15.UseVisualStyleBackColor = False
        '
        'BS10
        '
        Me.BS10.BackColor = System.Drawing.Color.Black
        Me.BS10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS10.Location = New System.Drawing.Point(4, 14)
        Me.BS10.Name = "BS10"
        Me.BS10.Size = New System.Drawing.Size(10, 10)
        Me.BS10.TabIndex = 2
        Me.BS10.UseVisualStyleBackColor = False
        '
        'BS5
        '
        Me.BS5.BackColor = System.Drawing.Color.Black
        Me.BS5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BS5.Location = New System.Drawing.Point(4, 3)
        Me.BS5.Name = "BS5"
        Me.BS5.Size = New System.Drawing.Size(5, 5)
        Me.BS5.TabIndex = 0
        Me.BS5.UseVisualStyleBackColor = False
        '
        'ColorDialogueToolStripMenuItem
        '
        Me.ColorDialogueToolStripMenuItem.Name = "ColorDialogueToolStripMenuItem"
        Me.ColorDialogueToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ColorDialogueToolStripMenuItem.Text = "Color Dialogue"
        '
        'frmPainting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 462)
        Me.Controls.Add(Me.pnlBrushSize)
        Me.Controls.Add(Me.pnlColors)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPainting"
        Me.Text = "Master Painter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlColors.ResumeLayout(False)
        Me.pnlBrushSize.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EraserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushSizesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushWidthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushHeightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlColors As System.Windows.Forms.Panel
    Friend WithEvents btnBlack As System.Windows.Forms.Button
    Friend WithEvents btnBrown As System.Windows.Forms.Button
    Friend WithEvents btnOrange As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents BW5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BW10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BW15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BW20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BW25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BW30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BH30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlBrushSize As System.Windows.Forms.Panel
    Friend WithEvents BS30 As System.Windows.Forms.Button
    Friend WithEvents BS25 As System.Windows.Forms.Button
    Friend WithEvents BS20 As System.Windows.Forms.Button
    Friend WithEvents BS15 As System.Windows.Forms.Button
    Friend WithEvents BS10 As System.Windows.Forms.Button
    Friend WithEvents BS5 As System.Windows.Forms.Button
    Friend WithEvents ColorDialogueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Colors As System.Windows.Forms.ColorDialog

End Class
