<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tactical_AOV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tactical_AOV))
        Me.getresult = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Label()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Column = New System.Windows.Forms.CheckBox()
        Me.Fresh = New System.Windows.Forms.CheckBox()
        Me.spent = New System.Windows.Forms.CheckBox()
        Me.disordered = New System.Windows.Forms.CheckBox()
        Me.adjust = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.detached = New System.Windows.Forms.Label()
        Me.detached_leader = New System.Windows.Forms.Button()
        Me.attached = New System.Windows.Forms.Label()
        Me.attached_leader = New System.Windows.Forms.Button()
        Me.suppressed = New System.Windows.Forms.CheckBox()
        Me.Cavalry = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.doctrine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'getresult
        '
        Me.getresult.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getresult.Location = New System.Drawing.Point(240, 545)
        Me.getresult.Name = "getresult"
        Me.getresult.Size = New System.Drawing.Size(210, 47)
        Me.getresult.TabIndex = 8
        Me.getresult.Text = "Check "
        Me.getresult.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(12, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(660, 119)
        Me.Player.TabIndex = 9
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(557, 608)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(112, 45)
        Me.nextphase.TabIndex = 10
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(434, 608)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(117, 45)
        Me.Reset.TabIndex = 11
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Column
        '
        Me.Column.Appearance = System.Windows.Forms.Appearance.Button
        Me.Column.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column.Location = New System.Drawing.Point(151, 256)
        Me.Column.Name = "Column"
        Me.Column.Size = New System.Drawing.Size(400, 40)
        Me.Column.TabIndex = 13
        Me.Column.Text = "March Column or Road Column"
        Me.Column.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Column.UseVisualStyleBackColor = True
        '
        'Fresh
        '
        Me.Fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.Fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fresh.Location = New System.Drawing.Point(151, 302)
        Me.Fresh.Name = "Fresh"
        Me.Fresh.Size = New System.Drawing.Size(400, 40)
        Me.Fresh.TabIndex = 14
        Me.Fresh.Text = "Fresh"
        Me.Fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Fresh.UseVisualStyleBackColor = True
        '
        'spent
        '
        Me.spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spent.Location = New System.Drawing.Point(151, 348)
        Me.spent.Name = "spent"
        Me.spent.Size = New System.Drawing.Size(400, 40)
        Me.spent.TabIndex = 15
        Me.spent.Text = "Spent"
        Me.spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.spent.UseVisualStyleBackColor = True
        '
        'disordered
        '
        Me.disordered.Appearance = System.Windows.Forms.Appearance.Button
        Me.disordered.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disordered.Location = New System.Drawing.Point(151, 394)
        Me.disordered.Name = "disordered"
        Me.disordered.Size = New System.Drawing.Size(400, 40)
        Me.disordered.TabIndex = 16
        Me.disordered.Text = "Disordered"
        Me.disordered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.disordered.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(65, 608)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(104, 45)
        Me.adjust.TabIndex = 20
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(269, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 45)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Movement Rates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'detached
        '
        Me.detached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.detached.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detached.Location = New System.Drawing.Point(443, 166)
        Me.detached.Name = "detached"
        Me.detached.Size = New System.Drawing.Size(107, 38)
        Me.detached.TabIndex = 25
        Me.detached.Text = "0"
        Me.detached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'detached_leader
        '
        Me.detached_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detached_leader.Location = New System.Drawing.Point(151, 166)
        Me.detached_leader.Name = "detached_leader"
        Me.detached_leader.Size = New System.Drawing.Size(286, 39)
        Me.detached_leader.TabIndex = 24
        Me.detached_leader.Text = "Detached Leader (+1/+2)"
        Me.detached_leader.UseVisualStyleBackColor = True
        '
        'attached
        '
        Me.attached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attached.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attached.Location = New System.Drawing.Point(443, 212)
        Me.attached.Name = "attached"
        Me.attached.Size = New System.Drawing.Size(107, 38)
        Me.attached.TabIndex = 27
        Me.attached.Text = "0"
        Me.attached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attached_leader
        '
        Me.attached_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attached_leader.Location = New System.Drawing.Point(151, 211)
        Me.attached_leader.Name = "attached_leader"
        Me.attached_leader.Size = New System.Drawing.Size(286, 39)
        Me.attached_leader.TabIndex = 26
        Me.attached_leader.Text = "Attached Leader (+2/+4)"
        Me.attached_leader.UseVisualStyleBackColor = True
        '
        'suppressed
        '
        Me.suppressed.Appearance = System.Windows.Forms.Appearance.Button
        Me.suppressed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suppressed.Location = New System.Drawing.Point(151, 440)
        Me.suppressed.Name = "suppressed"
        Me.suppressed.Size = New System.Drawing.Size(400, 40)
        Me.suppressed.TabIndex = 12
        Me.suppressed.Text = "Suppressed"
        Me.suppressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.suppressed.UseVisualStyleBackColor = True
        '
        'Cavalry
        '
        Me.Cavalry.Appearance = System.Windows.Forms.Appearance.Button
        Me.Cavalry.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cavalry.Location = New System.Drawing.Point(151, 486)
        Me.Cavalry.Name = "Cavalry"
        Me.Cavalry.Size = New System.Drawing.Size(400, 40)
        Me.Cavalry.TabIndex = 28
        Me.Cavalry.Text = "Disordered Cavalry Moving into Combat"
        Me.Cavalry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Cavalry.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 607)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 47)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'doctrine
        '
        Me.doctrine.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctrine.Location = New System.Drawing.Point(175, 608)
        Me.doctrine.Name = "doctrine"
        Me.doctrine.Size = New System.Drawing.Size(88, 45)
        Me.doctrine.TabIndex = 32
        Me.doctrine.Text = "Doctrine"
        Me.doctrine.UseVisualStyleBackColor = True
        '
        'tactical_AOV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.cluster1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.doctrine)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cavalry)
        Me.Controls.Add(Me.attached)
        Me.Controls.Add(Me.attached_leader)
        Me.Controls.Add(Me.detached)
        Me.Controls.Add(Me.detached_leader)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.disordered)
        Me.Controls.Add(Me.spent)
        Me.Controls.Add(Me.Fresh)
        Me.Controls.Add(Me.Column)
        Me.Controls.Add(Me.suppressed)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.getresult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "tactical_AOV"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tactical March Phase"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents getresult As System.Windows.Forms.Button
    Friend WithEvents Player As System.Windows.Forms.Label
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Column As System.Windows.Forms.CheckBox
    Friend WithEvents Fresh As System.Windows.Forms.CheckBox
    Friend WithEvents spent As System.Windows.Forms.CheckBox
    Friend WithEvents disordered As System.Windows.Forms.CheckBox
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents detached As System.Windows.Forms.Label
    Friend WithEvents detached_leader As System.Windows.Forms.Button
    Friend WithEvents attached As System.Windows.Forms.Label
    Friend WithEvents attached_leader As System.Windows.Forms.Button
    Friend WithEvents suppressed As System.Windows.Forms.CheckBox
    Friend WithEvents Cavalry As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents doctrine As Button
End Class
