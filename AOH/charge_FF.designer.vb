<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class charge_FF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(charge_FF))
        Me.Defender = New System.Windows.Forms.Label()
        Me.attacker = New System.Windows.Forms.Label()
        Me.a_leaders = New System.Windows.Forms.CheckBox()
        Me.d_leaders = New System.Windows.Forms.CheckBox()
        Me.a_fresh = New System.Windows.Forms.CheckBox()
        Me.d_fresh = New System.Windows.Forms.CheckBox()
        Me.a_spent = New System.Windows.Forms.CheckBox()
        Me.d_spent = New System.Windows.Forms.CheckBox()
        Me.a_confed = New System.Windows.Forms.CheckBox()
        Me.a_break = New System.Windows.Forms.CheckBox()
        Me.a_mounted = New System.Windows.Forms.CheckBox()
        Me.a_supported = New System.Windows.Forms.CheckBox()
        Me.d_supported = New System.Windows.Forms.CheckBox()
        Me.d_mounted = New System.Windows.Forms.CheckBox()
        Me.d_ground = New System.Windows.Forms.Button()
        Me.def1 = New System.Windows.Forms.Label()
        Me.d_linear = New System.Windows.Forms.Button()
        Me.def2 = New System.Windows.Forms.Label()
        Me.a_mod = New System.Windows.Forms.Label()
        Me.d_mod = New System.Windows.Forms.Label()
        Me.a_odds = New System.Windows.Forms.Button()
        Me.a_ratio = New System.Windows.Forms.Label()
        Me.a_disorder = New System.Windows.Forms.CheckBox()
        Me.a_lowammo = New System.Windows.Forms.CheckBox()
        Me.a_Firefight = New System.Windows.Forms.Button()
        Me.a_cas = New System.Windows.Forms.Label()
        Me.d_disorder = New System.Windows.Forms.CheckBox()
        Me.d_odds = New System.Windows.Forms.Button()
        Me.d_firefight = New System.Windows.Forms.Button()
        Me.d_ratio = New System.Windows.Forms.Label()
        Me.d_cas = New System.Windows.Forms.Label()
        Me.d_lowammo = New System.Windows.Forms.CheckBox()
        Me.d_flanked = New System.Windows.Forms.CheckBox()
        Me.Fight = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.adjust = New System.Windows.Forms.Button()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Defender
        '
        Me.Defender.AutoSize = True
        Me.Defender.BackColor = System.Drawing.Color.Transparent
        Me.Defender.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Defender.Location = New System.Drawing.Point(321, 57)
        Me.Defender.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Defender.Name = "Defender"
        Me.Defender.Size = New System.Drawing.Size(300, 27)
        Me.Defender.TabIndex = 11
        Me.Defender.Text = "Label1"
        Me.Defender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attacker
        '
        Me.attacker.AutoSize = True
        Me.attacker.BackColor = System.Drawing.Color.Transparent
        Me.attacker.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attacker.Location = New System.Drawing.Point(28, 57)
        Me.attacker.MinimumSize = New System.Drawing.Size(300, 0)
        Me.attacker.Name = "attacker"
        Me.attacker.Size = New System.Drawing.Size(300, 27)
        Me.attacker.TabIndex = 11
        Me.attacker.Text = "Label1"
        Me.attacker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_leaders
        '
        Me.a_leaders.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_leaders.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_leaders.Location = New System.Drawing.Point(50, 87)
        Me.a_leaders.Name = "a_leaders"
        Me.a_leaders.Size = New System.Drawing.Size(250, 36)
        Me.a_leaders.TabIndex = 13
        Me.a_leaders.Tag = "1"
        Me.a_leaders.Text = "Att Ldr or Excp Bde Comd"
        Me.a_leaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_leaders.UseVisualStyleBackColor = True
        '
        'd_leaders
        '
        Me.d_leaders.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_leaders.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_leaders.Location = New System.Drawing.Point(340, 87)
        Me.d_leaders.Name = "d_leaders"
        Me.d_leaders.Size = New System.Drawing.Size(250, 36)
        Me.d_leaders.TabIndex = 13
        Me.d_leaders.Tag = "1"
        Me.d_leaders.Text = "Att Ldr or Excp Bde Comd"
        Me.d_leaders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_leaders.UseVisualStyleBackColor = True
        '
        'a_fresh
        '
        Me.a_fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_fresh.Location = New System.Drawing.Point(50, 129)
        Me.a_fresh.Name = "a_fresh"
        Me.a_fresh.Size = New System.Drawing.Size(110, 36)
        Me.a_fresh.TabIndex = 13
        Me.a_fresh.Tag = "2"
        Me.a_fresh.Text = "Fresh"
        Me.a_fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_fresh.UseVisualStyleBackColor = True
        '
        'd_fresh
        '
        Me.d_fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_fresh.Location = New System.Drawing.Point(340, 129)
        Me.d_fresh.Name = "d_fresh"
        Me.d_fresh.Size = New System.Drawing.Size(110, 36)
        Me.d_fresh.TabIndex = 13
        Me.d_fresh.Tag = "2"
        Me.d_fresh.Text = "Fresh"
        Me.d_fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_fresh.UseVisualStyleBackColor = True
        '
        'a_spent
        '
        Me.a_spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_spent.Location = New System.Drawing.Point(190, 129)
        Me.a_spent.Name = "a_spent"
        Me.a_spent.Size = New System.Drawing.Size(110, 36)
        Me.a_spent.TabIndex = 13
        Me.a_spent.Tag = "-2"
        Me.a_spent.Text = "Spent"
        Me.a_spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_spent.UseVisualStyleBackColor = True
        '
        'd_spent
        '
        Me.d_spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_spent.Location = New System.Drawing.Point(480, 129)
        Me.d_spent.Name = "d_spent"
        Me.d_spent.Size = New System.Drawing.Size(110, 36)
        Me.d_spent.TabIndex = 13
        Me.d_spent.Tag = "-2"
        Me.d_spent.Text = "Spent"
        Me.d_spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_spent.UseVisualStyleBackColor = True
        '
        'a_confed
        '
        Me.a_confed.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_confed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_confed.Location = New System.Drawing.Point(50, 171)
        Me.a_confed.Name = "a_confed"
        Me.a_confed.Size = New System.Drawing.Size(250, 36)
        Me.a_confed.TabIndex = 14
        Me.a_confed.Tag = "1"
        Me.a_confed.Text = "Confederates Charging"
        Me.a_confed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_confed.UseVisualStyleBackColor = True
        '
        'a_break
        '
        Me.a_break.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_break.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_break.Location = New System.Drawing.Point(50, 213)
        Me.a_break.Name = "a_break"
        Me.a_break.Size = New System.Drawing.Size(250, 36)
        Me.a_break.TabIndex = 15
        Me.a_break.Tag = "1"
        Me.a_break.Text = "Breakthrough Charge"
        Me.a_break.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_break.UseVisualStyleBackColor = True
        '
        'a_mounted
        '
        Me.a_mounted.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_mounted.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_mounted.Location = New System.Drawing.Point(50, 255)
        Me.a_mounted.Name = "a_mounted"
        Me.a_mounted.Size = New System.Drawing.Size(250, 36)
        Me.a_mounted.TabIndex = 16
        Me.a_mounted.Tag = "1"
        Me.a_mounted.Text = "Mounted"
        Me.a_mounted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_mounted.UseVisualStyleBackColor = True
        '
        'a_supported
        '
        Me.a_supported.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_supported.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_supported.Location = New System.Drawing.Point(50, 297)
        Me.a_supported.Name = "a_supported"
        Me.a_supported.Size = New System.Drawing.Size(250, 36)
        Me.a_supported.TabIndex = 17
        Me.a_supported.Tag = "1"
        Me.a_supported.Text = "Supported"
        Me.a_supported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_supported.UseVisualStyleBackColor = True
        '
        'd_supported
        '
        Me.d_supported.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_supported.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_supported.Location = New System.Drawing.Point(340, 297)
        Me.d_supported.Name = "d_supported"
        Me.d_supported.Size = New System.Drawing.Size(250, 36)
        Me.d_supported.TabIndex = 19
        Me.d_supported.Tag = "1"
        Me.d_supported.Text = "Supported"
        Me.d_supported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_supported.UseVisualStyleBackColor = True
        '
        'd_mounted
        '
        Me.d_mounted.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_mounted.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_mounted.Location = New System.Drawing.Point(340, 255)
        Me.d_mounted.Name = "d_mounted"
        Me.d_mounted.Size = New System.Drawing.Size(250, 36)
        Me.d_mounted.TabIndex = 18
        Me.d_mounted.Tag = "1"
        Me.d_mounted.Text = "Mounted"
        Me.d_mounted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_mounted.UseVisualStyleBackColor = True
        '
        'd_ground
        '
        Me.d_ground.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_ground.Location = New System.Drawing.Point(340, 171)
        Me.d_ground.Name = "d_ground"
        Me.d_ground.Size = New System.Drawing.Size(170, 36)
        Me.d_ground.TabIndex = 20
        Me.d_ground.Text = "Favourable Ground"
        Me.d_ground.UseVisualStyleBackColor = True
        '
        'def1
        '
        Me.def1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.def1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def1.Location = New System.Drawing.Point(510, 171)
        Me.def1.Name = "def1"
        Me.def1.Size = New System.Drawing.Size(80, 36)
        Me.def1.TabIndex = 21
        Me.def1.Text = "0"
        Me.def1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_linear
        '
        Me.d_linear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_linear.Location = New System.Drawing.Point(340, 213)
        Me.d_linear.Name = "d_linear"
        Me.d_linear.Size = New System.Drawing.Size(170, 36)
        Me.d_linear.TabIndex = 20
        Me.d_linear.Text = "Linear defences"
        Me.d_linear.UseVisualStyleBackColor = True
        '
        'def2
        '
        Me.def2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.def2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def2.Location = New System.Drawing.Point(510, 213)
        Me.def2.Name = "def2"
        Me.def2.Size = New System.Drawing.Size(80, 36)
        Me.def2.TabIndex = 21
        Me.def2.Text = "0"
        Me.def2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_mod
        '
        Me.a_mod.BackColor = System.Drawing.Color.White
        Me.a_mod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_mod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_mod.Location = New System.Drawing.Point(116, 556)
        Me.a_mod.Name = "a_mod"
        Me.a_mod.Size = New System.Drawing.Size(80, 36)
        Me.a_mod.TabIndex = 22
        Me.a_mod.Text = "0"
        Me.a_mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_mod
        '
        Me.d_mod.BackColor = System.Drawing.Color.White
        Me.d_mod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_mod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_mod.Location = New System.Drawing.Point(430, 556)
        Me.d_mod.Name = "d_mod"
        Me.d_mod.Size = New System.Drawing.Size(80, 36)
        Me.d_mod.TabIndex = 22
        Me.d_mod.Text = "0"
        Me.d_mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_odds
        '
        Me.a_odds.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_odds.Location = New System.Drawing.Point(50, 339)
        Me.a_odds.Name = "a_odds"
        Me.a_odds.Size = New System.Drawing.Size(170, 36)
        Me.a_odds.TabIndex = 20
        Me.a_odds.Text = "Outnumbered"
        Me.a_odds.UseVisualStyleBackColor = True
        '
        'a_ratio
        '
        Me.a_ratio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_ratio.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_ratio.Location = New System.Drawing.Point(220, 339)
        Me.a_ratio.Name = "a_ratio"
        Me.a_ratio.Size = New System.Drawing.Size(80, 36)
        Me.a_ratio.TabIndex = 21
        Me.a_ratio.Text = "1:1"
        Me.a_ratio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_disorder
        '
        Me.a_disorder.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_disorder.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_disorder.Location = New System.Drawing.Point(50, 381)
        Me.a_disorder.Name = "a_disorder"
        Me.a_disorder.Size = New System.Drawing.Size(250, 36)
        Me.a_disorder.TabIndex = 16
        Me.a_disorder.Tag = "-1"
        Me.a_disorder.Text = "Disordered"
        Me.a_disorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_disorder.UseVisualStyleBackColor = True
        '
        'a_lowammo
        '
        Me.a_lowammo.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_lowammo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_lowammo.Location = New System.Drawing.Point(50, 423)
        Me.a_lowammo.Name = "a_lowammo"
        Me.a_lowammo.Size = New System.Drawing.Size(250, 36)
        Me.a_lowammo.TabIndex = 23
        Me.a_lowammo.Tag = "-1"
        Me.a_lowammo.Text = "Low on Ammunition"
        Me.a_lowammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_lowammo.UseVisualStyleBackColor = True
        '
        'a_Firefight
        '
        Me.a_Firefight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_Firefight.Location = New System.Drawing.Point(50, 465)
        Me.a_Firefight.Name = "a_Firefight"
        Me.a_Firefight.Size = New System.Drawing.Size(170, 36)
        Me.a_Firefight.TabIndex = 20
        Me.a_Firefight.Text = "Firefight Cas"
        Me.a_Firefight.UseVisualStyleBackColor = True
        '
        'a_cas
        '
        Me.a_cas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_cas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_cas.Location = New System.Drawing.Point(220, 465)
        Me.a_cas.Name = "a_cas"
        Me.a_cas.Size = New System.Drawing.Size(80, 36)
        Me.a_cas.TabIndex = 21
        Me.a_cas.Text = "0"
        Me.a_cas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_disorder
        '
        Me.d_disorder.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_disorder.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_disorder.Location = New System.Drawing.Point(340, 381)
        Me.d_disorder.Name = "d_disorder"
        Me.d_disorder.Size = New System.Drawing.Size(250, 36)
        Me.d_disorder.TabIndex = 16
        Me.d_disorder.Tag = "-1"
        Me.d_disorder.Text = "Disordered"
        Me.d_disorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_disorder.UseVisualStyleBackColor = True
        '
        'd_odds
        '
        Me.d_odds.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_odds.Location = New System.Drawing.Point(340, 339)
        Me.d_odds.Name = "d_odds"
        Me.d_odds.Size = New System.Drawing.Size(170, 36)
        Me.d_odds.TabIndex = 20
        Me.d_odds.Text = "Outnumbered"
        Me.d_odds.UseVisualStyleBackColor = True
        '
        'd_firefight
        '
        Me.d_firefight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_firefight.Location = New System.Drawing.Point(340, 465)
        Me.d_firefight.Name = "d_firefight"
        Me.d_firefight.Size = New System.Drawing.Size(170, 36)
        Me.d_firefight.TabIndex = 20
        Me.d_firefight.Text = "Firefight Cas"
        Me.d_firefight.UseVisualStyleBackColor = True
        '
        'd_ratio
        '
        Me.d_ratio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_ratio.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_ratio.Location = New System.Drawing.Point(510, 339)
        Me.d_ratio.Name = "d_ratio"
        Me.d_ratio.Size = New System.Drawing.Size(80, 36)
        Me.d_ratio.TabIndex = 21
        Me.d_ratio.Text = "1:1"
        Me.d_ratio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_cas
        '
        Me.d_cas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_cas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_cas.Location = New System.Drawing.Point(510, 465)
        Me.d_cas.Name = "d_cas"
        Me.d_cas.Size = New System.Drawing.Size(80, 36)
        Me.d_cas.TabIndex = 21
        Me.d_cas.Text = "0"
        Me.d_cas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_lowammo
        '
        Me.d_lowammo.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_lowammo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_lowammo.Location = New System.Drawing.Point(340, 423)
        Me.d_lowammo.Name = "d_lowammo"
        Me.d_lowammo.Size = New System.Drawing.Size(250, 36)
        Me.d_lowammo.TabIndex = 23
        Me.d_lowammo.Tag = "-1"
        Me.d_lowammo.Text = "Low on Ammunition"
        Me.d_lowammo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_lowammo.UseVisualStyleBackColor = True
        '
        'd_flanked
        '
        Me.d_flanked.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_flanked.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_flanked.Location = New System.Drawing.Point(340, 507)
        Me.d_flanked.Name = "d_flanked"
        Me.d_flanked.Size = New System.Drawing.Size(250, 36)
        Me.d_flanked.TabIndex = 16
        Me.d_flanked.Tag = "-3"
        Me.d_flanked.Text = "Outflanked"
        Me.d_flanked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_flanked.UseVisualStyleBackColor = True
        '
        'Fight
        '
        Me.Fight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fight.Location = New System.Drawing.Point(230, 556)
        Me.Fight.Name = "Fight"
        Me.Fight.Size = New System.Drawing.Size(169, 36)
        Me.Fight.TabIndex = 24
        Me.Fight.Text = "Fight the Melee"
        Me.Fight.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(352, 600)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(116, 49)
        Me.Reset.TabIndex = 34
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(145, 600)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(121, 49)
        Me.adjust.TabIndex = 35
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(554, 600)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(116, 49)
        Me.nextphase.TabIndex = 36
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 602)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 47)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.AutoSize = True
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(184, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(300, 33)
        Me.Player.TabIndex = 38
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'charge_FF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AOH.My.Resources.Resources.flags01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Fight)
        Me.Controls.Add(Me.d_lowammo)
        Me.Controls.Add(Me.a_lowammo)
        Me.Controls.Add(Me.d_mod)
        Me.Controls.Add(Me.a_mod)
        Me.Controls.Add(Me.def2)
        Me.Controls.Add(Me.d_cas)
        Me.Controls.Add(Me.a_cas)
        Me.Controls.Add(Me.d_ratio)
        Me.Controls.Add(Me.a_ratio)
        Me.Controls.Add(Me.def1)
        Me.Controls.Add(Me.d_linear)
        Me.Controls.Add(Me.d_firefight)
        Me.Controls.Add(Me.d_odds)
        Me.Controls.Add(Me.a_Firefight)
        Me.Controls.Add(Me.a_odds)
        Me.Controls.Add(Me.d_ground)
        Me.Controls.Add(Me.d_supported)
        Me.Controls.Add(Me.d_mounted)
        Me.Controls.Add(Me.d_flanked)
        Me.Controls.Add(Me.d_disorder)
        Me.Controls.Add(Me.a_supported)
        Me.Controls.Add(Me.a_disorder)
        Me.Controls.Add(Me.a_mounted)
        Me.Controls.Add(Me.a_break)
        Me.Controls.Add(Me.a_confed)
        Me.Controls.Add(Me.d_leaders)
        Me.Controls.Add(Me.d_fresh)
        Me.Controls.Add(Me.d_spent)
        Me.Controls.Add(Me.a_spent)
        Me.Controls.Add(Me.a_fresh)
        Me.Controls.Add(Me.a_leaders)
        Me.Controls.Add(Me.attacker)
        Me.Controls.Add(Me.Defender)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "charge_FF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge Combat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Defender As System.Windows.Forms.Label
    Friend WithEvents attacker As System.Windows.Forms.Label
    Friend WithEvents a_leaders As System.Windows.Forms.CheckBox
    Friend WithEvents d_leaders As System.Windows.Forms.CheckBox
    Friend WithEvents a_fresh As System.Windows.Forms.CheckBox
    Friend WithEvents d_fresh As System.Windows.Forms.CheckBox
    Friend WithEvents a_spent As System.Windows.Forms.CheckBox
    Friend WithEvents d_spent As System.Windows.Forms.CheckBox
    Friend WithEvents a_confed As System.Windows.Forms.CheckBox
    Friend WithEvents a_break As System.Windows.Forms.CheckBox
    Friend WithEvents a_mounted As System.Windows.Forms.CheckBox
    Friend WithEvents a_supported As System.Windows.Forms.CheckBox
    Friend WithEvents d_supported As System.Windows.Forms.CheckBox
    Friend WithEvents d_mounted As System.Windows.Forms.CheckBox
    Friend WithEvents d_ground As System.Windows.Forms.Button
    Friend WithEvents def1 As System.Windows.Forms.Label
    Friend WithEvents d_linear As System.Windows.Forms.Button
    Friend WithEvents def2 As System.Windows.Forms.Label
    Friend WithEvents a_mod As System.Windows.Forms.Label
    Friend WithEvents d_mod As System.Windows.Forms.Label
    Friend WithEvents a_odds As System.Windows.Forms.Button
    Friend WithEvents a_ratio As System.Windows.Forms.Label
    Friend WithEvents a_disorder As System.Windows.Forms.CheckBox
    Friend WithEvents a_lowammo As System.Windows.Forms.CheckBox
    Friend WithEvents a_Firefight As System.Windows.Forms.Button
    Friend WithEvents a_cas As System.Windows.Forms.Label
    Friend WithEvents d_disorder As System.Windows.Forms.CheckBox
    Friend WithEvents d_odds As System.Windows.Forms.Button
    Friend WithEvents d_firefight As System.Windows.Forms.Button
    Friend WithEvents d_ratio As System.Windows.Forms.Label
    Friend WithEvents d_cas As System.Windows.Forms.Label
    Friend WithEvents d_lowammo As System.Windows.Forms.CheckBox
    Friend WithEvents d_flanked As System.Windows.Forms.CheckBox
    Friend WithEvents Fight As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Player As Label
End Class
