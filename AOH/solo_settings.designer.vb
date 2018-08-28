<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class solo_settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(solo_settings))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.player = New System.Windows.Forms.TextBox()
        Me.skilled = New System.Windows.Forms.Label()
        Me.average = New System.Windows.Forms.Label()
        Me.poor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cautious = New System.Windows.Forms.Label()
        Me.bold = New System.Windows.Forms.Label()
        Me.aggressive = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mission = New System.Windows.Forms.ComboBox()
        Me.generals_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.delete_comd = New System.Windows.Forms.Button()
        Me.edit_comd = New System.Windows.Forms.Button()
        Me.new_comd = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.TextBox()
        Me.comd_name = New System.Windows.Forms.Label()
        Me.strength = New System.Windows.Forms.TextBox()
        Me.comd_strength = New System.Windows.Forms.Label()
        Me.discard_comd = New System.Windows.Forms.Button()
        Me.save_comd = New System.Windows.Forms.Button()
        Me.command_decisions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'player
        '
        Me.player.Enabled = False
        Me.player.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player.Location = New System.Drawing.Point(100, 6)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(125, 31)
        Me.player.TabIndex = 11
        Me.player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skilled
        '
        Me.skilled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.skilled.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skilled.Location = New System.Drawing.Point(380, 85)
        Me.skilled.Name = "skilled"
        Me.skilled.Size = New System.Drawing.Size(120, 27)
        Me.skilled.TabIndex = 30
        Me.skilled.Text = "Skilled"
        Me.skilled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'average
        '
        Me.average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.average.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.average.Location = New System.Drawing.Point(220, 85)
        Me.average.Name = "average"
        Me.average.Size = New System.Drawing.Size(160, 27)
        Me.average.TabIndex = 29
        Me.average.Text = "Average"
        Me.average.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'poor
        '
        Me.poor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.poor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poor.Location = New System.Drawing.Point(100, 85)
        Me.poor.Name = "poor"
        Me.poor.Size = New System.Drawing.Size(120, 27)
        Me.poor.TabIndex = 28
        Me.poor.Text = "Poor"
        Me.poor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Attitude"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cautious
        '
        Me.cautious.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cautious.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cautious.Location = New System.Drawing.Point(100, 124)
        Me.cautious.Name = "cautious"
        Me.cautious.Size = New System.Drawing.Size(120, 27)
        Me.cautious.TabIndex = 28
        Me.cautious.Text = "Cautious"
        Me.cautious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bold
        '
        Me.bold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bold.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bold.Location = New System.Drawing.Point(220, 124)
        Me.bold.Name = "bold"
        Me.bold.Size = New System.Drawing.Size(160, 27)
        Me.bold.TabIndex = 29
        Me.bold.Text = "Bold"
        Me.bold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'aggressive
        '
        Me.aggressive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.aggressive.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aggressive.Location = New System.Drawing.Point(380, 124)
        Me.aggressive.Name = "aggressive"
        Me.aggressive.Size = New System.Drawing.Size(120, 27)
        Me.aggressive.TabIndex = 30
        Me.aggressive.Text = "Aggressive"
        Me.aggressive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mission"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mission
        '
        Me.mission.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mission.FormattingEnabled = True
        Me.mission.Items.AddRange(New Object() {"Advance", "Attack", "Defend", "Delay"})
        Me.mission.Location = New System.Drawing.Point(100, 45)
        Me.mission.Name = "mission"
        Me.mission.Size = New System.Drawing.Size(125, 31)
        Me.mission.TabIndex = 31
        '
        'generals_list
        '
        Me.generals_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.generals_list.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generals_list.FullRowSelect = True
        Me.generals_list.GridLines = True
        Me.generals_list.Location = New System.Drawing.Point(16, 178)
        Me.generals_list.MultiSelect = False
        Me.generals_list.Name = "generals_list"
        Me.generals_list.Size = New System.Drawing.Size(544, 180)
        Me.generals_list.TabIndex = 32
        Me.generals_list.UseCompatibleStateImageBehavior = False
        Me.generals_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Commander"
        Me.ColumnHeader1.Width = 112
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ability"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attitude"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Strength"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 113
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Casualties"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 131
        '
        'delete_comd
        '
        Me.delete_comd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_comd.Location = New System.Drawing.Point(395, 378)
        Me.delete_comd.Name = "delete_comd"
        Me.delete_comd.Size = New System.Drawing.Size(158, 40)
        Me.delete_comd.TabIndex = 35
        Me.delete_comd.Text = "Del Commander"
        Me.delete_comd.UseVisualStyleBackColor = True
        '
        'edit_comd
        '
        Me.edit_comd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_comd.Location = New System.Drawing.Point(211, 378)
        Me.edit_comd.Name = "edit_comd"
        Me.edit_comd.Size = New System.Drawing.Size(158, 40)
        Me.edit_comd.TabIndex = 33
        Me.edit_comd.Text = "Edit Commander"
        Me.edit_comd.UseVisualStyleBackColor = True
        '
        'new_comd
        '
        Me.new_comd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_comd.Location = New System.Drawing.Point(27, 378)
        Me.new_comd.Name = "new_comd"
        Me.new_comd.Size = New System.Drawing.Size(158, 40)
        Me.new_comd.TabIndex = 34
        Me.new_comd.Text = "Add Commander"
        Me.new_comd.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(310, 440)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(125, 31)
        Me.title.TabIndex = 37
        '
        'comd_name
        '
        Me.comd_name.BackColor = System.Drawing.Color.Transparent
        Me.comd_name.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comd_name.ForeColor = System.Drawing.Color.Black
        Me.comd_name.Location = New System.Drawing.Point(128, 444)
        Me.comd_name.Name = "comd_name"
        Me.comd_name.Size = New System.Drawing.Size(176, 21)
        Me.comd_name.TabIndex = 36
        Me.comd_name.Text = "Commander's Name"
        Me.comd_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'strength
        '
        Me.strength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strength.Location = New System.Drawing.Point(310, 481)
        Me.strength.Name = "strength"
        Me.strength.Size = New System.Drawing.Size(125, 31)
        Me.strength.TabIndex = 39
        '
        'comd_strength
        '
        Me.comd_strength.BackColor = System.Drawing.Color.Transparent
        Me.comd_strength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comd_strength.ForeColor = System.Drawing.Color.Black
        Me.comd_strength.Location = New System.Drawing.Point(100, 485)
        Me.comd_strength.Name = "comd_strength"
        Me.comd_strength.Size = New System.Drawing.Size(204, 21)
        Me.comd_strength.TabIndex = 38
        Me.comd_strength.Text = "Commander's Strength"
        Me.comd_strength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'discard_comd
        '
        Me.discard_comd.Enabled = False
        Me.discard_comd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discard_comd.Location = New System.Drawing.Point(300, 523)
        Me.discard_comd.Name = "discard_comd"
        Me.discard_comd.Size = New System.Drawing.Size(179, 40)
        Me.discard_comd.TabIndex = 41
        Me.discard_comd.Text = "Discard Commander"
        Me.discard_comd.UseVisualStyleBackColor = True
        '
        'save_comd
        '
        Me.save_comd.Enabled = False
        Me.save_comd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_comd.Location = New System.Drawing.Point(77, 523)
        Me.save_comd.Name = "save_comd"
        Me.save_comd.Size = New System.Drawing.Size(185, 40)
        Me.save_comd.TabIndex = 40
        Me.save_comd.Text = "Save Commander"
        Me.save_comd.UseVisualStyleBackColor = True
        '
        'command_decisions
        '
        Me.command_decisions.Enabled = False
        Me.command_decisions.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.command_decisions.Location = New System.Drawing.Point(195, 378)
        Me.command_decisions.Name = "command_decisions"
        Me.command_decisions.Size = New System.Drawing.Size(185, 40)
        Me.command_decisions.TabIndex = 42
        Me.command_decisions.Text = "Command Decisions"
        Me.command_decisions.UseVisualStyleBackColor = True
        Me.command_decisions.Visible = False
        '
        'solo_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.napoleon_Logo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 575)
        Me.Controls.Add(Me.command_decisions)
        Me.Controls.Add(Me.discard_comd)
        Me.Controls.Add(Me.save_comd)
        Me.Controls.Add(Me.strength)
        Me.Controls.Add(Me.comd_strength)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.comd_name)
        Me.Controls.Add(Me.delete_comd)
        Me.Controls.Add(Me.edit_comd)
        Me.Controls.Add(Me.new_comd)
        Me.Controls.Add(Me.generals_list)
        Me.Controls.Add(Me.mission)
        Me.Controls.Add(Me.aggressive)
        Me.Controls.Add(Me.skilled)
        Me.Controls.Add(Me.bold)
        Me.Controls.Add(Me.average)
        Me.Controls.Add(Me.cautious)
        Me.Controls.Add(Me.poor)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "solo_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solo Command Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents player As TextBox
    Friend WithEvents skilled As Label
    Friend WithEvents average As Label
    Friend WithEvents poor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cautious As Label
    Friend WithEvents bold As Label
    Friend WithEvents aggressive As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mission As ComboBox
    Friend WithEvents generals_list As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents delete_comd As Button
    Friend WithEvents edit_comd As Button
    Friend WithEvents new_comd As Button
    Friend WithEvents title As TextBox
    Friend WithEvents comd_name As Label
    Friend WithEvents strength As TextBox
    Friend WithEvents comd_strength As Label
    Friend WithEvents discard_comd As Button
    Friend WithEvents save_comd As Button
    Friend WithEvents command_decisions As Button
End Class
