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
        Me.BrushHeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlColors = New System.Windows.Forms.Panel()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnBrown = New System.Windows.Forms.Button()
        Me.btnBlack = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlColors.SuspendLayout()
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
        Me.EraserToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.EraserToolStripMenuItem.Text = "E&raser"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem.Text = "&Clear All"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ColorsToolStripMenuItem
        '
        Me.ColorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.BrownToolStripMenuItem, Me.BlackToolStripMenuItem, Me.ColorPanelToolStripMenuItem})
        Me.ColorsToolStripMenuItem.Name = "ColorsToolStripMenuItem"
        Me.ColorsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ColorsToolStripMenuItem.Text = "&Colors"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'BrownToolStripMenuItem
        '
        Me.BrownToolStripMenuItem.Name = "BrownToolStripMenuItem"
        Me.BrownToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BrownToolStripMenuItem.Text = "Brown"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlackToolStripMenuItem.Text = "Black"
        '
        'ColorPanelToolStripMenuItem
        '
        Me.ColorPanelToolStripMenuItem.Name = "ColorPanelToolStripMenuItem"
        Me.ColorPanelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.BrushSizesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BrushSizesToolStripMenuItem.Text = "&Brush Sizes"
        '
        'BrushWidthToolStripMenuItem
        '
        Me.BrushWidthToolStripMenuItem.Name = "BrushWidthToolStripMenuItem"
        Me.BrushWidthToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BrushWidthToolStripMenuItem.Text = "Brush Width"
        '
        'BrushHeightToolStripMenuItem
        '
        Me.BrushHeightToolStripMenuItem.Name = "BrushHeightToolStripMenuItem"
        Me.BrushHeightToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BrushHeightToolStripMenuItem.Text = "Brush Height"
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
        Me.pnlColors.Size = New System.Drawing.Size(95, 66)
        Me.pnlColors.TabIndex = 1
        Me.pnlColors.Visible = False
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
        'frmPainting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 462)
        Me.Controls.Add(Me.pnlColors)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPainting"
        Me.Text = "Master Painter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlColors.ResumeLayout(False)
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

End Class
