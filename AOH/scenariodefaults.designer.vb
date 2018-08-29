<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scenariodefaults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scenariodefaults))
        Me.start_time_inc = New System.Windows.Forms.TrackBar()
        Me.start_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dusk = New System.Windows.Forms.Label()
        Me.dusk_inc = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Current_time = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gameturn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.nextturn = New System.Windows.Forms.Button()
        Me.loadscenario = New System.Windows.Forms.Button()
        Me.savescenario = New System.Windows.Forms.Button()
        Me.newscenario = New System.Windows.Forms.Button()
        Me.adjust = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.manage_events = New System.Windows.Forms.Button()
        Me.dicerolls = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.player1_init = New System.Windows.Forms.TextBox()
        Me.player2_init = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.player1_stands = New System.Windows.Forms.TextBox()
        Me.player2_stands = New System.Windows.Forms.TextBox()
        Me.player1 = New System.Windows.Forms.ComboBox()
        Me.player2 = New System.Windows.Forms.ComboBox()
        Me.solo_setup = New System.Windows.Forms.Button()
        Me.solo = New System.Windows.Forms.CheckBox()
        CType(Me.start_time_inc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dusk_inc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'start_time_inc
        '
        Me.start_time_inc.BackColor = System.Drawing.Color.White
        Me.start_time_inc.Location = New System.Drawing.Point(448, 72)
        Me.start_time_inc.Maximum = 32
        Me.start_time_inc.Name = "start_time_inc"
        Me.start_time_inc.Size = New System.Drawing.Size(224, 45)
        Me.start_time_inc.TabIndex = 0
        Me.start_time_inc.TabStop = False
        Me.start_time_inc.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'start_time
        '
        Me.start_time.AutoSize = True
        Me.start_time.BackColor = System.Drawing.Color.White
        Me.start_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.start_time.Enabled = False
        Me.start_time.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_time.Location = New System.Drawing.Point(317, 79)
        Me.start_time.MaximumSize = New System.Drawing.Size(125, 30)
        Me.start_time.MinimumSize = New System.Drawing.Size(125, 30)
        Me.start_time.Name = "start_time"
        Me.start_time.Size = New System.Drawing.Size(125, 30)
        Me.start_time.TabIndex = 1
        Me.start_time.Text = "0"
        Me.start_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(219, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(262, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dusk"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dusk
        '
        Me.Dusk.AutoSize = True
        Me.Dusk.BackColor = System.Drawing.Color.White
        Me.Dusk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dusk.Enabled = False
        Me.Dusk.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dusk.Location = New System.Drawing.Point(317, 127)
        Me.Dusk.MaximumSize = New System.Drawing.Size(125, 30)
        Me.Dusk.MinimumSize = New System.Drawing.Size(125, 30)
        Me.Dusk.Name = "Dusk"
        Me.Dusk.Size = New System.Drawing.Size(125, 30)
        Me.Dusk.TabIndex = 2
        Me.Dusk.Text = "0"
        Me.Dusk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dusk_inc
        '
        Me.dusk_inc.BackColor = System.Drawing.Color.White
        Me.dusk_inc.Location = New System.Drawing.Point(448, 120)
        Me.dusk_inc.Name = "dusk_inc"
        Me.dusk_inc.Size = New System.Drawing.Size(224, 45)
        Me.dusk_inc.TabIndex = 3
        Me.dusk_inc.TabStop = False
        Me.dusk_inc.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(197, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Current Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Current_time
        '
        Me.Current_time.AutoSize = True
        Me.Current_time.BackColor = System.Drawing.Color.White
        Me.Current_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Current_time.Enabled = False
        Me.Current_time.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_time.Location = New System.Drawing.Point(317, 179)
        Me.Current_time.MaximumSize = New System.Drawing.Size(125, 30)
        Me.Current_time.MinimumSize = New System.Drawing.Size(125, 30)
        Me.Current_time.Name = "Current_time"
        Me.Current_time.Size = New System.Drawing.Size(125, 30)
        Me.Current_time.TabIndex = 3
        Me.Current_time.Text = "0"
        Me.Current_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(249, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Player 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(394, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Player 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gameturn
        '
        Me.gameturn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameturn.Location = New System.Drawing.Point(317, 223)
        Me.gameturn.Name = "gameturn"
        Me.gameturn.Size = New System.Drawing.Size(125, 31)
        Me.gameturn.TabIndex = 13
        Me.gameturn.TabStop = False
        Me.gameturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Location = New System.Drawing.Point(216, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Game Turn"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'nextturn
        '
        Me.nextturn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextturn.Location = New System.Drawing.Point(476, 605)
        Me.nextturn.Name = "nextturn"
        Me.nextturn.Size = New System.Drawing.Size(195, 39)
        Me.nextturn.TabIndex = 15
        Me.nextturn.TabStop = False
        Me.nextturn.Text = "Continue to Next Turn"
        Me.nextturn.UseVisualStyleBackColor = True
        '
        'loadscenario
        '
        Me.loadscenario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadscenario.Location = New System.Drawing.Point(29, 509)
        Me.loadscenario.Name = "loadscenario"
        Me.loadscenario.Size = New System.Drawing.Size(139, 40)
        Me.loadscenario.TabIndex = 16
        Me.loadscenario.TabStop = False
        Me.loadscenario.Text = "Load Scenario"
        Me.loadscenario.UseVisualStyleBackColor = True
        '
        'savescenario
        '
        Me.savescenario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savescenario.Location = New System.Drawing.Point(28, 557)
        Me.savescenario.Name = "savescenario"
        Me.savescenario.Size = New System.Drawing.Size(140, 40)
        Me.savescenario.TabIndex = 17
        Me.savescenario.TabStop = False
        Me.savescenario.Text = "Save Scenario"
        Me.savescenario.UseVisualStyleBackColor = True
        '
        'newscenario
        '
        Me.newscenario.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newscenario.Location = New System.Drawing.Point(28, 461)
        Me.newscenario.Name = "newscenario"
        Me.newscenario.Size = New System.Drawing.Size(140, 40)
        Me.newscenario.TabIndex = 18
        Me.newscenario.TabStop = False
        Me.newscenario.Text = "New Scenario"
        Me.newscenario.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(201, 462)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(260, 40)
        Me.adjust.TabIndex = 19
        Me.adjust.TabStop = False
        Me.adjust.Text = "Adjust Casualties"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'manage_events
        '
        Me.manage_events.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manage_events.Location = New System.Drawing.Point(201, 510)
        Me.manage_events.Name = "manage_events"
        Me.manage_events.Size = New System.Drawing.Size(260, 39)
        Me.manage_events.TabIndex = 23
        Me.manage_events.TabStop = False
        Me.manage_events.Text = "Manage Game Events"
        Me.manage_events.UseVisualStyleBackColor = True
        '
        'dicerolls
        '
        Me.dicerolls.Appearance = System.Windows.Forms.Appearance.Button
        Me.dicerolls.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dicerolls.Location = New System.Drawing.Point(201, 558)
        Me.dicerolls.Name = "dicerolls"
        Me.dicerolls.Size = New System.Drawing.Size(260, 39)
        Me.dicerolls.TabIndex = 24
        Me.dicerolls.TabStop = False
        Me.dicerolls.Text = "Display Dice Rolls"
        Me.dicerolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dicerolls.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label7.Location = New System.Drawing.Point(155, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label8.Location = New System.Drawing.Point(138, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Initiative"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'player1_init
        '
        Me.player1_init.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1_init.Location = New System.Drawing.Point(224, 359)
        Me.player1_init.Name = "player1_init"
        Me.player1_init.Size = New System.Drawing.Size(125, 31)
        Me.player1_init.TabIndex = 2
        Me.player1_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'player2_init
        '
        Me.player2_init.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2_init.Location = New System.Drawing.Point(369, 359)
        Me.player2_init.Name = "player2_init"
        Me.player2_init.Size = New System.Drawing.Size(125, 31)
        Me.player2_init.TabIndex = 5
        Me.player2_init.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label9.Location = New System.Drawing.Point(134, 410)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Elements"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'player1_stands
        '
        Me.player1_stands.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1_stands.Location = New System.Drawing.Point(224, 407)
        Me.player1_stands.Name = "player1_stands"
        Me.player1_stands.Size = New System.Drawing.Size(125, 31)
        Me.player1_stands.TabIndex = 3
        Me.player1_stands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'player2_stands
        '
        Me.player2_stands.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2_stands.Location = New System.Drawing.Point(369, 407)
        Me.player2_stands.Name = "player2_stands"
        Me.player2_stands.Size = New System.Drawing.Size(125, 31)
        Me.player2_stands.TabIndex = 6
        Me.player2_stands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'player1
        '
        Me.player1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player1.FormattingEnabled = True
        Me.player1.Location = New System.Drawing.Point(224, 315)
        Me.player1.Name = "player1"
        Me.player1.Size = New System.Drawing.Size(125, 31)
        Me.player1.TabIndex = 1
        '
        'player2
        '
        Me.player2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player2.FormattingEnabled = True
        Me.player2.Location = New System.Drawing.Point(369, 315)
        Me.player2.Name = "player2"
        Me.player2.Size = New System.Drawing.Size(125, 31)
        Me.player2.TabIndex = 4
        '
        'solo_setup
        '
        Me.solo_setup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solo_setup.Location = New System.Drawing.Point(201, 605)
        Me.solo_setup.Name = "solo_setup"
        Me.solo_setup.Size = New System.Drawing.Size(260, 40)
        Me.solo_setup.TabIndex = 30
        Me.solo_setup.TabStop = False
        Me.solo_setup.Text = "Solo Setup"
        Me.solo_setup.UseVisualStyleBackColor = True
        '
        'solo
        '
        Me.solo.Appearance = System.Windows.Forms.Appearance.Button
        Me.solo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solo.Location = New System.Drawing.Point(28, 605)
        Me.solo.Name = "solo"
        Me.solo.Size = New System.Drawing.Size(140, 39)
        Me.solo.TabIndex = 31
        Me.solo.TabStop = False
        Me.solo.Text = "Solo Game"
        Me.solo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.solo.UseVisualStyleBackColor = True
        '
        'scenariodefaults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.kitch1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.solo)
        Me.Controls.Add(Me.solo_setup)
        Me.Controls.Add(Me.player2)
        Me.Controls.Add(Me.player1)
        Me.Controls.Add(Me.dicerolls)
        Me.Controls.Add(Me.manage_events)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.newscenario)
        Me.Controls.Add(Me.savescenario)
        Me.Controls.Add(Me.loadscenario)
        Me.Controls.Add(Me.nextturn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gameturn)
        Me.Controls.Add(Me.player2_stands)
        Me.Controls.Add(Me.player2_init)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.player1_stands)
        Me.Controls.Add(Me.player1_init)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Current_time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dusk)
        Me.Controls.Add(Me.dusk_inc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.start_time)
        Me.Controls.Add(Me.start_time_inc)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "scenariodefaults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Control and Defaults"
        CType(Me.start_time_inc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dusk_inc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start_time_inc As System.Windows.Forms.TrackBar
    Friend WithEvents start_time As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dusk As System.Windows.Forms.Label
    Friend WithEvents dusk_inc As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Current_time As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gameturn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents nextturn As System.Windows.Forms.Button
    Friend WithEvents loadscenario As System.Windows.Forms.Button
    Friend WithEvents savescenario As System.Windows.Forms.Button
    Friend WithEvents newscenario As System.Windows.Forms.Button
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents manage_events As System.Windows.Forms.Button
    Friend WithEvents dicerolls As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents player1_init As TextBox
    Friend WithEvents player2_init As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents player1_stands As TextBox
    Friend WithEvents player2_stands As TextBox
    Friend WithEvents player1 As ComboBox
    Friend WithEvents player2 As ComboBox
    Friend WithEvents solo_setup As Button
    Friend WithEvents solo As CheckBox
End Class
