<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserve_AOE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reserve_AOE))
        Me.getresult = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Label()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.elsewhere = New System.Windows.Forms.CheckBox()
        Me.disordered = New System.Windows.Forms.CheckBox()
        Me.attached = New System.Windows.Forms.CheckBox()
        Me.adjust = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.last_turn = New System.Windows.Forms.CheckBox()
        Me.turns_failed = New System.Windows.Forms.Button()
        Me.Failures = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'getresult
        '
        Me.getresult.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getresult.Location = New System.Drawing.Point(245, 387)
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
        Me.Player.Location = New System.Drawing.Point(142, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(400, 70)
        Me.Player.TabIndex = 9
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(581, 602)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(90, 56)
        Me.nextphase.TabIndex = 10
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(435, 602)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(90, 56)
        Me.Reset.TabIndex = 11
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'elsewhere
        '
        Me.elsewhere.Appearance = System.Windows.Forms.Appearance.Button
        Me.elsewhere.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elsewhere.Location = New System.Drawing.Point(142, 100)
        Me.elsewhere.Name = "elsewhere"
        Me.elsewhere.Size = New System.Drawing.Size(400, 40)
        Me.elsewhere.TabIndex = 12
        Me.elsewhere.Text = "CinC incapacitated, or committed elsewhere"
        Me.elsewhere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.elsewhere.UseVisualStyleBackColor = True
        '
        'disordered
        '
        Me.disordered.Appearance = System.Windows.Forms.Appearance.Button
        Me.disordered.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disordered.Location = New System.Drawing.Point(141, 311)
        Me.disordered.Name = "disordered"
        Me.disordered.Size = New System.Drawing.Size(400, 40)
        Me.disordered.TabIndex = 13
        Me.disordered.Text = "Disordered"
        Me.disordered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.disordered.UseVisualStyleBackColor = True
        '
        'attached
        '
        Me.attached.Appearance = System.Windows.Forms.Appearance.Button
        Me.attached.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attached.Location = New System.Drawing.Point(142, 150)
        Me.attached.Name = "attached"
        Me.attached.Size = New System.Drawing.Size(400, 40)
        Me.attached.TabIndex = 19
        Me.attached.Text = "Attached ADC, Army Comd, or superceding Command"
        Me.attached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.attached.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(124, 602)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(90, 56)
        Me.adjust.TabIndex = 20
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(270, 602)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 56)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Movement Rates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'last_turn
        '
        Me.last_turn.Appearance = System.Windows.Forms.Appearance.Button
        Me.last_turn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_turn.Location = New System.Drawing.Point(142, 200)
        Me.last_turn.Name = "last_turn"
        Me.last_turn.Size = New System.Drawing.Size(400, 40)
        Me.last_turn.TabIndex = 18
        Me.last_turn.Text = "Reserve Movement Last Turn"
        Me.last_turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.last_turn.UseVisualStyleBackColor = True
        '
        'turns_failed
        '
        Me.turns_failed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turns_failed.Location = New System.Drawing.Point(142, 255)
        Me.turns_failed.Name = "turns_failed"
        Me.turns_failed.Size = New System.Drawing.Size(286, 39)
        Me.turns_failed.TabIndex = 22
        Me.turns_failed.Text = "Failed for the last x turns"
        Me.turns_failed.UseVisualStyleBackColor = True
        '
        'Failures
        '
        Me.Failures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Failures.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Failures.Location = New System.Drawing.Point(434, 256)
        Me.Failures.Name = "Failures"
        Me.Failures.Size = New System.Drawing.Size(107, 38)
        Me.Failures.TabIndex = 23
        Me.Failures.Text = "0"
        Me.Failures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 602)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 56)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Reserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.napoleon_Logo2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Failures)
        Me.Controls.Add(Me.turns_failed)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.attached)
        Me.Controls.Add(Me.last_turn)
        Me.Controls.Add(Me.disordered)
        Me.Controls.Add(Me.elsewhere)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.getresult)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "Reserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserve Movement"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents getresult As System.Windows.Forms.Button
    Friend WithEvents Player As System.Windows.Forms.Label
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents elsewhere As System.Windows.Forms.CheckBox
    Friend WithEvents disordered As System.Windows.Forms.CheckBox
    Friend WithEvents attached As System.Windows.Forms.CheckBox
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents last_turn As System.Windows.Forms.CheckBox
    Friend WithEvents turns_failed As System.Windows.Forms.Button
    Friend WithEvents Failures As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
