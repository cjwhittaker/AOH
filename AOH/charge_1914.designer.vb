<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class charge_1914
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(charge_1914))
        Me.Defender = New System.Windows.Forms.Label()
        Me.attacker = New System.Windows.Forms.Label()
        Me.a_fresh = New System.Windows.Forms.CheckBox()
        Me.a_spent = New System.Windows.Forms.CheckBox()
        Me.a_break = New System.Windows.Forms.CheckBox()
        Me.a_supported = New System.Windows.Forms.CheckBox()
        Me.d_supported = New System.Windows.Forms.CheckBox()
        Me.d_select_ground = New System.Windows.Forms.Button()
        Me.d_ground = New System.Windows.Forms.Label()
        Me.a_mod = New System.Windows.Forms.Label()
        Me.d_mod = New System.Windows.Forms.Label()
        Me.a_odds = New System.Windows.Forms.Button()
        Me.a_ratio = New System.Windows.Forms.Label()
        Me.a_disorder = New System.Windows.Forms.CheckBox()
        Me.a_Firefight = New System.Windows.Forms.Button()
        Me.a_cas = New System.Windows.Forms.Label()
        Me.d_disorder = New System.Windows.Forms.CheckBox()
        Me.d_odds = New System.Windows.Forms.Button()
        Me.d_firefight = New System.Windows.Forms.Button()
        Me.d_ratio = New System.Windows.Forms.Label()
        Me.d_cas = New System.Windows.Forms.Label()
        Me.d_flanked = New System.Windows.Forms.CheckBox()
        Me.Fight = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.adjust = New System.Windows.Forms.Button()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.d_fresh = New System.Windows.Forms.CheckBox()
        Me.d_spent = New System.Windows.Forms.CheckBox()
        Me.a_leader = New System.Windows.Forms.Label()
        Me.a_select_leader = New System.Windows.Forms.Button()
        Me.d_select_leader = New System.Windows.Forms.Button()
        Me.d_leader = New System.Windows.Forms.Label()
        Me.a_rating = New System.Windows.Forms.Label()
        Me.a_select_rating = New System.Windows.Forms.Button()
        Me.d_select_rating = New System.Windows.Forms.Button()
        Me.d_rating = New System.Windows.Forms.Label()
        Me.a_heavy = New System.Windows.Forms.CheckBox()
        Me.a_armd = New System.Windows.Forms.CheckBox()
        Me.a_lancers = New System.Windows.Forms.CheckBox()
        Me.d_heavy = New System.Windows.Forms.CheckBox()
        Me.d_armd = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Label()
        Me.d_lancers = New System.Windows.Forms.CheckBox()
        Me.d_suppressed = New System.Windows.Forms.CheckBox()
        Me.d_french = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Defender
        '
        Me.Defender.AutoSize = True
        Me.Defender.BackColor = System.Drawing.Color.Transparent
        Me.Defender.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Defender.Location = New System.Drawing.Point(364, 35)
        Me.Defender.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Defender.Name = "Defender"
        Me.Defender.Size = New System.Drawing.Size(300, 33)
        Me.Defender.TabIndex = 11
        Me.Defender.Text = "Label1"
        Me.Defender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attacker
        '
        Me.attacker.AutoSize = True
        Me.attacker.BackColor = System.Drawing.Color.Transparent
        Me.attacker.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attacker.Location = New System.Drawing.Point(23, 35)
        Me.attacker.MinimumSize = New System.Drawing.Size(300, 0)
        Me.attacker.Name = "attacker"
        Me.attacker.Size = New System.Drawing.Size(300, 33)
        Me.attacker.TabIndex = 11
        Me.attacker.Text = "Label1"
        Me.attacker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_fresh
        '
        Me.a_fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_fresh.Location = New System.Drawing.Point(25, 114)
        Me.a_fresh.Name = "a_fresh"
        Me.a_fresh.Size = New System.Drawing.Size(137, 36)
        Me.a_fresh.TabIndex = 13
        Me.a_fresh.Tag = "+2"
        Me.a_fresh.Text = "Fresh"
        Me.a_fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_fresh.UseVisualStyleBackColor = True
        '
        'a_spent
        '
        Me.a_spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_spent.Location = New System.Drawing.Point(184, 113)
        Me.a_spent.Name = "a_spent"
        Me.a_spent.Size = New System.Drawing.Size(137, 36)
        Me.a_spent.TabIndex = 13
        Me.a_spent.Tag = "-2"
        Me.a_spent.Text = "Spent"
        Me.a_spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_spent.UseVisualStyleBackColor = True
        '
        'a_break
        '
        Me.a_break.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_break.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_break.Location = New System.Drawing.Point(25, 368)
        Me.a_break.Name = "a_break"
        Me.a_break.Size = New System.Drawing.Size(296, 36)
        Me.a_break.TabIndex = 15
        Me.a_break.Text = "Breakthrough Charge"
        Me.a_break.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_break.UseVisualStyleBackColor = True
        '
        'a_supported
        '
        Me.a_supported.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_supported.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_supported.Location = New System.Drawing.Point(25, 242)
        Me.a_supported.Name = "a_supported"
        Me.a_supported.Size = New System.Drawing.Size(296, 36)
        Me.a_supported.TabIndex = 17
        Me.a_supported.Text = "Supported"
        Me.a_supported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_supported.UseVisualStyleBackColor = True
        '
        'd_supported
        '
        Me.d_supported.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_supported.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_supported.Location = New System.Drawing.Point(366, 242)
        Me.d_supported.Name = "d_supported"
        Me.d_supported.Size = New System.Drawing.Size(296, 36)
        Me.d_supported.TabIndex = 19
        Me.d_supported.Text = "Supported"
        Me.d_supported.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_supported.UseVisualStyleBackColor = True
        '
        'd_select_ground
        '
        Me.d_select_ground.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_select_ground.Location = New System.Drawing.Point(366, 495)
        Me.d_select_ground.Margin = New System.Windows.Forms.Padding(1, 3, 1, 3)
        Me.d_select_ground.Name = "d_select_ground"
        Me.d_select_ground.Size = New System.Drawing.Size(208, 36)
        Me.d_select_ground.TabIndex = 20
        Me.d_select_ground.Text = "Favourable Ground"
        Me.d_select_ground.UseVisualStyleBackColor = True
        '
        'd_ground
        '
        Me.d_ground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_ground.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_ground.Location = New System.Drawing.Point(582, 495)
        Me.d_ground.Name = "d_ground"
        Me.d_ground.Size = New System.Drawing.Size(80, 36)
        Me.d_ground.TabIndex = 21
        Me.d_ground.Text = "0"
        Me.d_ground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_mod
        '
        Me.a_mod.BackColor = System.Drawing.Color.White
        Me.a_mod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_mod.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_mod.Location = New System.Drawing.Point(133, 547)
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
        Me.d_mod.Location = New System.Drawing.Point(474, 547)
        Me.d_mod.Name = "d_mod"
        Me.d_mod.Size = New System.Drawing.Size(80, 36)
        Me.d_mod.TabIndex = 22
        Me.d_mod.Text = "0"
        Me.d_mod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_odds
        '
        Me.a_odds.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_odds.Location = New System.Drawing.Point(25, 284)
        Me.a_odds.Name = "a_odds"
        Me.a_odds.Size = New System.Drawing.Size(211, 36)
        Me.a_odds.TabIndex = 20
        Me.a_odds.Text = "Outnumbered"
        Me.a_odds.UseVisualStyleBackColor = True
        '
        'a_ratio
        '
        Me.a_ratio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_ratio.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_ratio.Location = New System.Drawing.Point(242, 284)
        Me.a_ratio.Name = "a_ratio"
        Me.a_ratio.Size = New System.Drawing.Size(79, 36)
        Me.a_ratio.TabIndex = 21
        Me.a_ratio.Text = "1:1"
        Me.a_ratio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_disorder
        '
        Me.a_disorder.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_disorder.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_disorder.Location = New System.Drawing.Point(25, 326)
        Me.a_disorder.Name = "a_disorder"
        Me.a_disorder.Size = New System.Drawing.Size(296, 36)
        Me.a_disorder.TabIndex = 16
        Me.a_disorder.Text = "Disordered, Silenced, Lt Inf, Arty"
        Me.a_disorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_disorder.UseVisualStyleBackColor = True
        '
        'a_Firefight
        '
        Me.a_Firefight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_Firefight.Location = New System.Drawing.Point(25, 454)
        Me.a_Firefight.Name = "a_Firefight"
        Me.a_Firefight.Size = New System.Drawing.Size(211, 36)
        Me.a_Firefight.TabIndex = 20
        Me.a_Firefight.Text = "Firefight Hits"
        Me.a_Firefight.UseVisualStyleBackColor = True
        '
        'a_cas
        '
        Me.a_cas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_cas.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_cas.Location = New System.Drawing.Point(242, 454)
        Me.a_cas.Name = "a_cas"
        Me.a_cas.Size = New System.Drawing.Size(79, 36)
        Me.a_cas.TabIndex = 21
        Me.a_cas.Text = "0"
        Me.a_cas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_disorder
        '
        Me.d_disorder.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_disorder.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_disorder.Location = New System.Drawing.Point(366, 326)
        Me.d_disorder.Name = "d_disorder"
        Me.d_disorder.Size = New System.Drawing.Size(296, 36)
        Me.d_disorder.TabIndex = 16
        Me.d_disorder.Text = "Disordered, Silenced, Lt Inf, Arty"
        Me.d_disorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_disorder.UseVisualStyleBackColor = True
        '
        'd_odds
        '
        Me.d_odds.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_odds.Location = New System.Drawing.Point(366, 284)
        Me.d_odds.Name = "d_odds"
        Me.d_odds.Size = New System.Drawing.Size(210, 36)
        Me.d_odds.TabIndex = 20
        Me.d_odds.Text = "Outnumbered"
        Me.d_odds.UseVisualStyleBackColor = True
        '
        'd_firefight
        '
        Me.d_firefight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_firefight.Location = New System.Drawing.Point(366, 454)
        Me.d_firefight.Name = "d_firefight"
        Me.d_firefight.Size = New System.Drawing.Size(208, 36)
        Me.d_firefight.TabIndex = 20
        Me.d_firefight.Text = "Firefight Hits"
        Me.d_firefight.UseVisualStyleBackColor = True
        '
        'd_ratio
        '
        Me.d_ratio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_ratio.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_ratio.Location = New System.Drawing.Point(582, 284)
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
        Me.d_cas.Location = New System.Drawing.Point(582, 454)
        Me.d_cas.Name = "d_cas"
        Me.d_cas.Size = New System.Drawing.Size(80, 36)
        Me.d_cas.TabIndex = 21
        Me.d_cas.Text = "0"
        Me.d_cas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_flanked
        '
        Me.d_flanked.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_flanked.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_flanked.Location = New System.Drawing.Point(366, 412)
        Me.d_flanked.Name = "d_flanked"
        Me.d_flanked.Size = New System.Drawing.Size(296, 36)
        Me.d_flanked.TabIndex = 16
        Me.d_flanked.Text = "Outflanked"
        Me.d_flanked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_flanked.UseVisualStyleBackColor = True
        '
        'Fight
        '
        Me.Fight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fight.Location = New System.Drawing.Point(259, 547)
        Me.Fight.Name = "Fight"
        Me.Fight.Size = New System.Drawing.Size(169, 36)
        Me.Fight.TabIndex = 24
        Me.Fight.Text = "Fight the Melee"
        Me.Fight.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(425, 600)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(120, 49)
        Me.Reset.TabIndex = 34
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(89, 600)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(125, 49)
        Me.adjust.TabIndex = 35
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(556, 600)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(116, 49)
        Me.nextphase.TabIndex = 36
        Me.nextphase.Text = "Next Phase"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'd_fresh
        '
        Me.d_fresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_fresh.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_fresh.Location = New System.Drawing.Point(366, 113)
        Me.d_fresh.Name = "d_fresh"
        Me.d_fresh.Size = New System.Drawing.Size(137, 36)
        Me.d_fresh.TabIndex = 13
        Me.d_fresh.Tag = "2"
        Me.d_fresh.Text = "Fresh"
        Me.d_fresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_fresh.UseVisualStyleBackColor = True
        '
        'd_spent
        '
        Me.d_spent.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_spent.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_spent.Location = New System.Drawing.Point(525, 113)
        Me.d_spent.Name = "d_spent"
        Me.d_spent.Size = New System.Drawing.Size(137, 36)
        Me.d_spent.TabIndex = 13
        Me.d_spent.Tag = "-2"
        Me.d_spent.Text = "Spent"
        Me.d_spent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_spent.UseVisualStyleBackColor = True
        '
        'a_leader
        '
        Me.a_leader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_leader.Location = New System.Drawing.Point(132, 72)
        Me.a_leader.Name = "a_leader"
        Me.a_leader.Size = New System.Drawing.Size(189, 36)
        Me.a_leader.TabIndex = 41
        Me.a_leader.Text = "None"
        Me.a_leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_select_leader
        '
        Me.a_select_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_select_leader.Location = New System.Drawing.Point(25, 71)
        Me.a_select_leader.Name = "a_select_leader"
        Me.a_select_leader.Size = New System.Drawing.Size(102, 36)
        Me.a_select_leader.TabIndex = 40
        Me.a_select_leader.Text = "Attached"
        Me.a_select_leader.UseVisualStyleBackColor = True
        '
        'd_select_leader
        '
        Me.d_select_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_select_leader.Location = New System.Drawing.Point(366, 71)
        Me.d_select_leader.Name = "d_select_leader"
        Me.d_select_leader.Size = New System.Drawing.Size(102, 36)
        Me.d_select_leader.TabIndex = 40
        Me.d_select_leader.Text = "Attached"
        Me.d_select_leader.UseVisualStyleBackColor = True
        '
        'd_leader
        '
        Me.d_leader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_leader.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_leader.Location = New System.Drawing.Point(474, 71)
        Me.d_leader.Name = "d_leader"
        Me.d_leader.Size = New System.Drawing.Size(188, 36)
        Me.d_leader.TabIndex = 41
        Me.d_leader.Text = "None"
        Me.d_leader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_rating
        '
        Me.a_rating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.a_rating.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_rating.Location = New System.Drawing.Point(241, 156)
        Me.a_rating.Name = "a_rating"
        Me.a_rating.Size = New System.Drawing.Size(80, 36)
        Me.a_rating.TabIndex = 43
        Me.a_rating.Text = "N/A"
        Me.a_rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_select_rating
        '
        Me.a_select_rating.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_select_rating.Location = New System.Drawing.Point(25, 156)
        Me.a_select_rating.Name = "a_select_rating"
        Me.a_select_rating.Size = New System.Drawing.Size(211, 36)
        Me.a_select_rating.TabIndex = 42
        Me.a_select_rating.Text = "Troop Rating"
        Me.a_select_rating.UseVisualStyleBackColor = True
        '
        'd_select_rating
        '
        Me.d_select_rating.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_select_rating.Location = New System.Drawing.Point(366, 156)
        Me.d_select_rating.Name = "d_select_rating"
        Me.d_select_rating.Size = New System.Drawing.Size(210, 36)
        Me.d_select_rating.TabIndex = 42
        Me.d_select_rating.Text = "Troop Rating"
        Me.d_select_rating.UseVisualStyleBackColor = True
        '
        'd_rating
        '
        Me.d_rating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.d_rating.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_rating.Location = New System.Drawing.Point(582, 156)
        Me.d_rating.Name = "d_rating"
        Me.d_rating.Size = New System.Drawing.Size(80, 36)
        Me.d_rating.TabIndex = 43
        Me.d_rating.Text = "N/A"
        Me.d_rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'a_heavy
        '
        Me.a_heavy.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_heavy.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_heavy.Location = New System.Drawing.Point(133, 200)
        Me.a_heavy.Name = "a_heavy"
        Me.a_heavy.Size = New System.Drawing.Size(81, 36)
        Me.a_heavy.TabIndex = 50
        Me.a_heavy.Text = "Hvy Cav"
        Me.a_heavy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_heavy.UseVisualStyleBackColor = True
        '
        'a_armd
        '
        Me.a_armd.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_armd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_armd.Location = New System.Drawing.Point(241, 200)
        Me.a_armd.Name = "a_armd"
        Me.a_armd.Size = New System.Drawing.Size(80, 36)
        Me.a_armd.TabIndex = 49
        Me.a_armd.Text = "Cuirass"
        Me.a_armd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_armd.UseVisualStyleBackColor = True
        '
        'a_lancers
        '
        Me.a_lancers.Appearance = System.Windows.Forms.Appearance.Button
        Me.a_lancers.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a_lancers.Location = New System.Drawing.Point(25, 200)
        Me.a_lancers.Name = "a_lancers"
        Me.a_lancers.Size = New System.Drawing.Size(81, 36)
        Me.a_lancers.TabIndex = 48
        Me.a_lancers.Text = "Lancers"
        Me.a_lancers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.a_lancers.UseVisualStyleBackColor = True
        '
        'd_heavy
        '
        Me.d_heavy.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_heavy.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_heavy.Location = New System.Drawing.Point(472, 200)
        Me.d_heavy.Name = "d_heavy"
        Me.d_heavy.Size = New System.Drawing.Size(81, 36)
        Me.d_heavy.TabIndex = 53
        Me.d_heavy.Text = "Hvy Cav"
        Me.d_heavy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_heavy.UseVisualStyleBackColor = True
        '
        'd_armd
        '
        Me.d_armd.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_armd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_armd.Location = New System.Drawing.Point(578, 200)
        Me.d_armd.Name = "d_armd"
        Me.d_armd.Size = New System.Drawing.Size(83, 36)
        Me.d_armd.TabIndex = 52
        Me.d_armd.Text = "Cuirass"
        Me.d_armd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_armd.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 600)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 49)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(12, 6)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(660, 31)
        Me.Player.TabIndex = 55
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_lancers
        '
        Me.d_lancers.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_lancers.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_lancers.Location = New System.Drawing.Point(366, 200)
        Me.d_lancers.Name = "d_lancers"
        Me.d_lancers.Size = New System.Drawing.Size(81, 36)
        Me.d_lancers.TabIndex = 56
        Me.d_lancers.Text = "Lancers"
        Me.d_lancers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_lancers.UseVisualStyleBackColor = True
        '
        'd_suppressed
        '
        Me.d_suppressed.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_suppressed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_suppressed.Location = New System.Drawing.Point(366, 368)
        Me.d_suppressed.Name = "d_suppressed"
        Me.d_suppressed.Size = New System.Drawing.Size(296, 36)
        Me.d_suppressed.TabIndex = 57
        Me.d_suppressed.Text = "Suppressed"
        Me.d_suppressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_suppressed.UseVisualStyleBackColor = True
        '
        'd_french
        '
        Me.d_french.Appearance = System.Windows.Forms.Appearance.Button
        Me.d_french.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_french.Location = New System.Drawing.Point(25, 410)
        Me.d_french.Name = "d_french"
        Me.d_french.Size = New System.Drawing.Size(296, 36)
        Me.d_french.TabIndex = 58
        Me.d_french.Text = "Attacking Regular French Inf"
        Me.d_french.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.d_french.UseVisualStyleBackColor = True
        '
        'charge_1914
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.d_french)
        Me.Controls.Add(Me.d_suppressed)
        Me.Controls.Add(Me.d_lancers)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.d_heavy)
        Me.Controls.Add(Me.d_armd)
        Me.Controls.Add(Me.a_heavy)
        Me.Controls.Add(Me.a_armd)
        Me.Controls.Add(Me.a_lancers)
        Me.Controls.Add(Me.d_rating)
        Me.Controls.Add(Me.a_rating)
        Me.Controls.Add(Me.d_select_rating)
        Me.Controls.Add(Me.a_select_rating)
        Me.Controls.Add(Me.d_leader)
        Me.Controls.Add(Me.a_leader)
        Me.Controls.Add(Me.d_select_leader)
        Me.Controls.Add(Me.a_select_leader)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Fight)
        Me.Controls.Add(Me.d_mod)
        Me.Controls.Add(Me.a_mod)
        Me.Controls.Add(Me.d_cas)
        Me.Controls.Add(Me.a_cas)
        Me.Controls.Add(Me.d_ratio)
        Me.Controls.Add(Me.a_ratio)
        Me.Controls.Add(Me.d_ground)
        Me.Controls.Add(Me.d_firefight)
        Me.Controls.Add(Me.d_odds)
        Me.Controls.Add(Me.a_Firefight)
        Me.Controls.Add(Me.a_odds)
        Me.Controls.Add(Me.d_select_ground)
        Me.Controls.Add(Me.d_supported)
        Me.Controls.Add(Me.d_flanked)
        Me.Controls.Add(Me.d_disorder)
        Me.Controls.Add(Me.a_supported)
        Me.Controls.Add(Me.a_disorder)
        Me.Controls.Add(Me.a_break)
        Me.Controls.Add(Me.d_spent)
        Me.Controls.Add(Me.a_spent)
        Me.Controls.Add(Me.d_fresh)
        Me.Controls.Add(Me.a_fresh)
        Me.Controls.Add(Me.attacker)
        Me.Controls.Add(Me.Defender)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "charge_1914"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charge Combat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Defender As System.Windows.Forms.Label
    Friend WithEvents attacker As System.Windows.Forms.Label
    Friend WithEvents a_fresh As System.Windows.Forms.CheckBox
    Friend WithEvents a_spent As System.Windows.Forms.CheckBox
    Friend WithEvents a_break As System.Windows.Forms.CheckBox
    Friend WithEvents a_supported As System.Windows.Forms.CheckBox
    Friend WithEvents d_supported As System.Windows.Forms.CheckBox
    Friend WithEvents d_select_ground As System.Windows.Forms.Button
    Friend WithEvents d_ground As System.Windows.Forms.Label
    Friend WithEvents a_mod As System.Windows.Forms.Label
    Friend WithEvents d_mod As System.Windows.Forms.Label
    Friend WithEvents a_odds As System.Windows.Forms.Button
    Friend WithEvents a_ratio As System.Windows.Forms.Label
    Friend WithEvents a_disorder As System.Windows.Forms.CheckBox
    Friend WithEvents a_Firefight As System.Windows.Forms.Button
    Friend WithEvents a_cas As System.Windows.Forms.Label
    Friend WithEvents d_disorder As System.Windows.Forms.CheckBox
    Friend WithEvents d_odds As System.Windows.Forms.Button
    Friend WithEvents d_firefight As System.Windows.Forms.Button
    Friend WithEvents d_ratio As System.Windows.Forms.Label
    Friend WithEvents d_cas As System.Windows.Forms.Label
    Friend WithEvents d_flanked As System.Windows.Forms.CheckBox
    Friend WithEvents Fight As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents adjust As System.Windows.Forms.Button
    Friend WithEvents nextphase As System.Windows.Forms.Button
    Friend WithEvents d_fresh As System.Windows.Forms.CheckBox
    Friend WithEvents d_spent As System.Windows.Forms.CheckBox
    Friend WithEvents a_leader As System.Windows.Forms.Label
    Friend WithEvents a_select_leader As System.Windows.Forms.Button
    Friend WithEvents d_select_leader As System.Windows.Forms.Button
    Friend WithEvents d_leader As System.Windows.Forms.Label
    Friend WithEvents a_rating As System.Windows.Forms.Label
    Friend WithEvents a_select_rating As System.Windows.Forms.Button
    Friend WithEvents d_select_rating As System.Windows.Forms.Button
    Friend WithEvents d_rating As System.Windows.Forms.Label
    Friend WithEvents a_heavy As System.Windows.Forms.CheckBox
    Friend WithEvents a_armd As System.Windows.Forms.CheckBox
    Friend WithEvents a_lancers As System.Windows.Forms.CheckBox
    Friend WithEvents d_heavy As System.Windows.Forms.CheckBox
    Friend WithEvents d_armd As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Player As System.Windows.Forms.Label
    Friend WithEvents d_lancers As CheckBox
    Friend WithEvents d_suppressed As CheckBox
    Friend WithEvents d_french As CheckBox
End Class
