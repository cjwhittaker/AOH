<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tactical_AOE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tactical_AOE))
        Me.getresult = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Label()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.disengage = New System.Windows.Forms.CheckBox()
        Me.Column = New System.Windows.Forms.CheckBox()
        Me.Fresh = New System.Windows.Forms.CheckBox()
        Me.spent = New System.Windows.Forms.CheckBox()
        Me.disordered = New System.Windows.Forms.CheckBox()
        Me.Impulse = New System.Windows.Forms.CheckBox()
        Me.adjust = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.detached = New System.Windows.Forms.Label()
        Me.b1 = New System.Windows.Forms.Button()
        Me.attached = New System.Windows.Forms.Label()
        Me.b2 = New System.Windows.Forms.Button()
        Me.Unsecure = New System.Windows.Forms.CheckBox()
        Me.Cavalry = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.doctrine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'getresult
        '
        Me.getresult.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getresult.Location = New System.Drawing.Point(237, 529)
        Me.getresult.Name = "getresult"
        Me.getresult.Size = New System.Drawing.Size(210, 47)
        Me.getresult.TabIndex = 8
        Me.getresult.Text = "Check "
        Me.getresult.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(12, 0)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(660, 103)
        Me.Player.TabIndex = 9
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(574, 593)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(92, 56)
        Me.nextphase.TabIndex = 10
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(447, 593)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(107, 56)
        Me.Reset.TabIndex = 11
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'disengage
        '
        Me.disengage.Appearance = System.Windows.Forms.Appearance.Button
        Me.disengage.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disengage.Location = New System.Drawing.Point(141, 391)
        Me.disengage.Name = "disengage"
        Me.disengage.Size = New System.Drawing.Size(400, 40)
        Me.disengage.TabIndex = 12
        Me.disengage.Text = "Disengaging"
        Me.disengage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.disengage.UseVisualStyleBackColor = True
        '
        'Column
        '
        Me.Column.Appearance = System.Windows.Forms.Appearance.Button
        Me.Column.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column.Location = New System.Drawing.Point(140, 207)
        Me.Column.Name = "Column"
        Me.Column.Size = New System.Drawing.Size(400, 40)
        Me.Column.TabIndex = 13
        Me.Column.Text = "March Column or Square Formation"
        Me.Column.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Column.UseVisualStyleBackColor = True
        '
        'Fresh
        '
        Me.Fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.Fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fresh.Location = New System.Drawing.Point(141, 299)
        Me.Fresh.Name = "Fresh"
        Me.Fresh.Size = New System.Drawing.Size(180, 40)
        Me.Fresh.TabIndex = 14
        Me.Fresh.Text = "Fresh"
        Me.Fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Fresh.UseVisualStyleBackColor = True
        '
        'spent
        '
        Me.spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spent.Location = New System.Drawing.Point(360, 299)
        Me.spent.Name = "spent"
        Me.spent.Size = New System.Drawing.Size(180, 40)
        Me.spent.TabIndex = 15
        Me.spent.Text = "Spent"
        Me.spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.spent.UseVisualStyleBackColor = True
        '
        'disordered
        '
        Me.disordered.Appearance = System.Windows.Forms.Appearance.Button
        Me.disordered.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disordered.Location = New System.Drawing.Point(141, 483)
        Me.disordered.Name = "disordered"
        Me.disordered.Size = New System.Drawing.Size(400, 40)
        Me.disordered.TabIndex = 16
        Me.disordered.Text = "Disordered"
        Me.disordered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.disordered.UseVisualStyleBackColor = True
        '
        'Impulse
        '
        Me.Impulse.Appearance = System.Windows.Forms.Appearance.Button
        Me.Impulse.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impulse.Location = New System.Drawing.Point(140, 253)
        Me.Impulse.Name = "Impulse"
        Me.Impulse.Size = New System.Drawing.Size(400, 40)
        Me.Impulse.TabIndex = 17
        Me.Impulse.Text = "Columnar or Impulse Infantry"
        Me.Impulse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Impulse.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(78, 593)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(90, 56)
        Me.adjust.TabIndex = 20
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(296, 593)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 56)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Movement Rates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'detached
        '
        Me.detached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.detached.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detached.Location = New System.Drawing.Point(432, 117)
        Me.detached.Name = "detached"
        Me.detached.Size = New System.Drawing.Size(107, 38)
        Me.detached.TabIndex = 25
        Me.detached.Text = "0"
        Me.detached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b1
        '
        Me.b1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(140, 117)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(286, 39)
        Me.b1.TabIndex = 24
        Me.b1.Text = "Detached Leader (+1/+2)"
        Me.b1.UseVisualStyleBackColor = True
        '
        'attached
        '
        Me.attached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attached.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attached.Location = New System.Drawing.Point(432, 163)
        Me.attached.Name = "attached"
        Me.attached.Size = New System.Drawing.Size(107, 38)
        Me.attached.TabIndex = 27
        Me.attached.Text = "0"
        Me.attached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(140, 162)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(286, 39)
        Me.b2.TabIndex = 26
        Me.b2.Text = "Attached Leader (+2/+4)"
        Me.b2.UseVisualStyleBackColor = True
        '
        'Unsecure
        '
        Me.Unsecure.Appearance = System.Windows.Forms.Appearance.Button
        Me.Unsecure.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unsecure.Location = New System.Drawing.Point(140, 345)
        Me.Unsecure.Name = "Unsecure"
        Me.Unsecure.Size = New System.Drawing.Size(400, 40)
        Me.Unsecure.TabIndex = 12
        Me.Unsecure.Text = "Unsecure Flanks"
        Me.Unsecure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Unsecure.UseVisualStyleBackColor = True
        '
        'Cavalry
        '
        Me.Cavalry.Appearance = System.Windows.Forms.Appearance.Button
        Me.Cavalry.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cavalry.Location = New System.Drawing.Point(141, 437)
        Me.Cavalry.Name = "Cavalry"
        Me.Cavalry.Size = New System.Drawing.Size(400, 40)
        Me.Cavalry.TabIndex = 28
        Me.Cavalry.Text = "Cavalry Moving into Combat"
        Me.Cavalry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Cavalry.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(11, 593)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 56)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'doctrine
        '
        Me.doctrine.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doctrine.Location = New System.Drawing.Point(188, 593)
        Me.doctrine.Name = "doctrine"
        Me.doctrine.Size = New System.Drawing.Size(88, 56)
        Me.doctrine.TabIndex = 30
        Me.doctrine.Text = "Doctrine"
        Me.doctrine.UseVisualStyleBackColor = True
        Me.doctrine.Visible = False
        '
        'tactical_AOE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.doctrine)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cavalry)
        Me.Controls.Add(Me.attached)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.detached)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.Impulse)
        Me.Controls.Add(Me.disordered)
        Me.Controls.Add(Me.spent)
        Me.Controls.Add(Me.Fresh)
        Me.Controls.Add(Me.Column)
        Me.Controls.Add(Me.Unsecure)
        Me.Controls.Add(Me.disengage)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.getresult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "tactical_AOE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tactical March Phase"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents getresult As System.Windows.Forms.Button
    Friend WithEvents Player As System.Windows.Forms.Label
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents disengage As System.Windows.Forms.CheckBox
    Friend WithEvents Column As System.Windows.Forms.CheckBox
    Friend WithEvents Fresh As System.Windows.Forms.CheckBox
    Friend WithEvents spent As System.Windows.Forms.CheckBox
    Friend WithEvents disordered As System.Windows.Forms.CheckBox
    Friend WithEvents Impulse As System.Windows.Forms.CheckBox
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents detached As System.Windows.Forms.Label
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents attached As System.Windows.Forms.Label
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents Unsecure As System.Windows.Forms.CheckBox
    Friend WithEvents Cavalry As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents doctrine As Button
End Class
