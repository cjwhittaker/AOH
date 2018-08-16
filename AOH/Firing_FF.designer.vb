<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Firing_FF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Firing_FF))
        Me.Player = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.f8 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.f1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Targetmode = New System.Windows.Forms.CheckBox()
        Me.lightcover = New System.Windows.Forms.CheckBox()
        Me.heavycover = New System.Windows.Forms.CheckBox()
        Me.Artillery = New System.Windows.Forms.CheckBox()
        Me.fire = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.adjust = New System.Windows.Forms.Button()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.firepoints = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.inc_fire_points = New System.Windows.Forms.Button()
        Me.dec_fire_points = New System.Windows.Forms.Button()
        Me.adjustfirepoints = New System.Windows.Forms.HScrollBar()
        Me.f2 = New System.Windows.Forms.Label()
        Me.f3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.f4 = New System.Windows.Forms.Label()
        Me.f5 = New System.Windows.Forms.Label()
        Me.f6 = New System.Windows.Forms.Label()
        Me.f7 = New System.Windows.Forms.Label()
        Me.f9 = New System.Windows.Forms.Label()
        Me.f10 = New System.Windows.Forms.Label()
        Me.f11 = New System.Windows.Forms.Label()
        Me.f12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(175, 0)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(300, 45)
        Me.Player.TabIndex = 10
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Range and Fire Points"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 27)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "16"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "24"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(543, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "32"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 27)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "4"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f8
        '
        Me.f8.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f8.Location = New System.Drawing.Point(183, 137)
        Me.f8.Name = "f8"
        Me.f8.Size = New System.Drawing.Size(120, 27)
        Me.f8.TabIndex = 17
        Me.f8.Text = "1"
        Me.f8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 27)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Inf"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(117, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 27)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cav"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(117, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 27)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Arty"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f1
        '
        Me.f1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1.Location = New System.Drawing.Point(183, 83)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(60, 27)
        Me.f1.TabIndex = 22
        Me.f1.Text = "10"
        Me.f1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(135, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(236, 38)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Total Fire Points"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Targetmode
        '
        Me.Targetmode.Appearance = System.Windows.Forms.Appearance.Button
        Me.Targetmode.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Targetmode.Location = New System.Drawing.Point(91, 315)
        Me.Targetmode.Name = "Targetmode"
        Me.Targetmode.Size = New System.Drawing.Size(500, 40)
        Me.Targetmode.TabIndex = 28
        Me.Targetmode.Text = "Tgt is Col or Limbered; Mounted Cav; Changing form, mode or facing"
        Me.Targetmode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Targetmode.UseVisualStyleBackColor = True
        '
        'lightcover
        '
        Me.lightcover.Appearance = System.Windows.Forms.Appearance.Button
        Me.lightcover.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lightcover.Location = New System.Drawing.Point(91, 361)
        Me.lightcover.Name = "lightcover"
        Me.lightcover.Size = New System.Drawing.Size(500, 40)
        Me.lightcover.TabIndex = 29
        Me.lightcover.Text = "Target is in Light cover"
        Me.lightcover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lightcover.UseVisualStyleBackColor = True
        '
        'heavycover
        '
        Me.heavycover.Appearance = System.Windows.Forms.Appearance.Button
        Me.heavycover.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heavycover.Location = New System.Drawing.Point(91, 407)
        Me.heavycover.Name = "heavycover"
        Me.heavycover.Size = New System.Drawing.Size(500, 40)
        Me.heavycover.TabIndex = 30
        Me.heavycover.Text = "Target is in Heavy cover"
        Me.heavycover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.heavycover.UseVisualStyleBackColor = True
        '
        'Artillery
        '
        Me.Artillery.Appearance = System.Windows.Forms.Appearance.Button
        Me.Artillery.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Artillery.Location = New System.Drawing.Point(91, 453)
        Me.Artillery.Name = "Artillery"
        Me.Artillery.Size = New System.Drawing.Size(500, 40)
        Me.Artillery.TabIndex = 31
        Me.Artillery.Text = "Artillery target"
        Me.Artillery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Artillery.UseVisualStyleBackColor = True
        '
        'fire
        '
        Me.fire.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fire.Location = New System.Drawing.Point(243, 515)
        Me.fire.Name = "fire"
        Me.fire.Size = New System.Drawing.Size(220, 40)
        Me.fire.TabIndex = 32
        Me.fire.Text = "Fire"
        Me.fire.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(335, 600)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(146, 49)
        Me.Reset.TabIndex = 33
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(120, 601)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(154, 49)
        Me.adjust.TabIndex = 34
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(542, 600)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(120, 49)
        Me.nextphase.TabIndex = 35
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'firepoints
        '
        Me.firepoints.BackColor = System.Drawing.Color.White
        Me.firepoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.firepoints.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firepoints.Location = New System.Drawing.Point(377, 208)
        Me.firepoints.Name = "firepoints"
        Me.firepoints.Size = New System.Drawing.Size(87, 38)
        Me.firepoints.TabIndex = 37
        Me.firepoints.Text = "0"
        Me.firepoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 603)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 47)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'inc_fire_points
        '
        Me.inc_fire_points.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inc_fire_points.Location = New System.Drawing.Point(599, 258)
        Me.inc_fire_points.Name = "inc_fire_points"
        Me.inc_fire_points.Size = New System.Drawing.Size(45, 45)
        Me.inc_fire_points.TabIndex = 39
        Me.inc_fire_points.Text = ">"
        Me.inc_fire_points.UseVisualStyleBackColor = True
        '
        'dec_fire_points
        '
        Me.dec_fire_points.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dec_fire_points.Location = New System.Drawing.Point(40, 258)
        Me.dec_fire_points.Name = "dec_fire_points"
        Me.dec_fire_points.Size = New System.Drawing.Size(45, 45)
        Me.dec_fire_points.TabIndex = 40
        Me.dec_fire_points.Text = "<"
        Me.dec_fire_points.UseVisualStyleBackColor = True
        '
        'adjustfirepoints
        '
        Me.adjustfirepoints.LargeChange = 1
        Me.adjustfirepoints.Location = New System.Drawing.Point(91, 258)
        Me.adjustfirepoints.Name = "adjustfirepoints"
        Me.adjustfirepoints.Size = New System.Drawing.Size(500, 45)
        Me.adjustfirepoints.TabIndex = 49
        '
        'f2
        '
        Me.f2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2.ForeColor = System.Drawing.Color.Blue
        Me.f2.Location = New System.Drawing.Point(243, 83)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(90, 27)
        Me.f2.TabIndex = 24
        Me.f2.Text = "4"
        Me.f2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f3
        '
        Me.f3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3.ForeColor = System.Drawing.Color.LightSlateGray
        Me.f3.Location = New System.Drawing.Point(333, 83)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(90, 27)
        Me.f3.TabIndex = 50
        Me.f3.Text = "3"
        Me.f3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Gold
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(243, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 27)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "8"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Yellow
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(183, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 27)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "4"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'f4
        '
        Me.f4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f4.ForeColor = System.Drawing.Color.Blue
        Me.f4.Location = New System.Drawing.Point(423, 83)
        Me.f4.Name = "f4"
        Me.f4.Size = New System.Drawing.Size(60, 27)
        Me.f4.TabIndex = 51
        Me.f4.Text = "3"
        Me.f4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f5
        '
        Me.f5.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f5.ForeColor = System.Drawing.Color.LightSlateGray
        Me.f5.Location = New System.Drawing.Point(483, 83)
        Me.f5.Name = "f5"
        Me.f5.Size = New System.Drawing.Size(60, 27)
        Me.f5.TabIndex = 52
        Me.f5.Text = "2"
        Me.f5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f6
        '
        Me.f6.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f6.ForeColor = System.Drawing.Color.Blue
        Me.f6.Location = New System.Drawing.Point(543, 83)
        Me.f6.Name = "f6"
        Me.f6.Size = New System.Drawing.Size(60, 27)
        Me.f6.TabIndex = 51
        Me.f6.Text = "2"
        Me.f6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f7
        '
        Me.f7.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f7.ForeColor = System.Drawing.Color.LightSlateGray
        Me.f7.Location = New System.Drawing.Point(603, 83)
        Me.f7.Name = "f7"
        Me.f7.Size = New System.Drawing.Size(60, 27)
        Me.f7.TabIndex = 52
        Me.f7.Text = "1"
        Me.f7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f9
        '
        Me.f9.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f9.ForeColor = System.Drawing.Color.Blue
        Me.f9.Location = New System.Drawing.Point(183, 164)
        Me.f9.Name = "f9"
        Me.f9.Size = New System.Drawing.Size(30, 27)
        Me.f9.TabIndex = 53
        Me.f9.Text = "2"
        Me.f9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f10
        '
        Me.f10.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f10.ForeColor = System.Drawing.Color.LightSlateGray
        Me.f10.Location = New System.Drawing.Point(213, 164)
        Me.f10.Name = "f10"
        Me.f10.Size = New System.Drawing.Size(30, 27)
        Me.f10.TabIndex = 54
        Me.f10.Text = "1"
        Me.f10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f11
        '
        Me.f11.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f11.ForeColor = System.Drawing.Color.Blue
        Me.f11.Location = New System.Drawing.Point(243, 164)
        Me.f11.Name = "f11"
        Me.f11.Size = New System.Drawing.Size(30, 27)
        Me.f11.TabIndex = 53
        Me.f11.Text = "1"
        Me.f11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'f12
        '
        Me.f12.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.f12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.f12.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f12.ForeColor = System.Drawing.Color.LightSlateGray
        Me.f12.Location = New System.Drawing.Point(273, 164)
        Me.f12.Name = "f12"
        Me.f12.Size = New System.Drawing.Size(30, 27)
        Me.f12.TabIndex = 54
        Me.f12.Text = ".5"
        Me.f12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Firing_FF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.flags01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.f12)
        Me.Controls.Add(Me.f10)
        Me.Controls.Add(Me.f11)
        Me.Controls.Add(Me.f9)
        Me.Controls.Add(Me.f7)
        Me.Controls.Add(Me.f5)
        Me.Controls.Add(Me.f6)
        Me.Controls.Add(Me.f4)
        Me.Controls.Add(Me.f3)
        Me.Controls.Add(Me.adjustfirepoints)
        Me.Controls.Add(Me.dec_fire_points)
        Me.Controls.Add(Me.inc_fire_points)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.firepoints)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.fire)
        Me.Controls.Add(Me.Artillery)
        Me.Controls.Add(Me.heavycover)
        Me.Controls.Add(Me.lightcover)
        Me.Controls.Add(Me.Targetmode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.f2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.f1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.f8)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "Firing_FF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Firing Phase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents f8 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents f1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Targetmode As System.Windows.Forms.CheckBox
    Friend WithEvents lightcover As System.Windows.Forms.CheckBox
    Friend WithEvents heavycover As System.Windows.Forms.CheckBox
    Friend WithEvents Artillery As System.Windows.Forms.CheckBox
    Friend WithEvents fire As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents firepoints As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents inc_fire_points As System.Windows.Forms.Button
    Friend WithEvents dec_fire_points As System.Windows.Forms.Button
    Friend WithEvents adjustfirepoints As HScrollBar
    Friend WithEvents f2 As Label
    Friend WithEvents f3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents f4 As Label
    Friend WithEvents f5 As Label
    Friend WithEvents f6 As Label
    Friend WithEvents f7 As Label
    Friend WithEvents f9 As Label
    Friend WithEvents f10 As Label
    Friend WithEvents f11 As Label
    Friend WithEvents f12 As Label
End Class
