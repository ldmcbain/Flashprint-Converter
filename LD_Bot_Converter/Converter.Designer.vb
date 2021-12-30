<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Converter
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_InFile = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.btn_Fix2 = New System.Windows.Forms.Button()
        Me.btn_Fix1 = New System.Windows.Forms.Button()
        Me.cbo_Printer = New System.Windows.Forms.ComboBox()
        Me.cbo_Mat_1 = New System.Windows.Forms.ComboBox()
        Me.lbl_Mat_1 = New System.Windows.Forms.Label()
        Me.txt_Noz_1 = New System.Windows.Forms.TextBox()
        Me.txt_Bed = New System.Windows.Forms.TextBox()
        Me.lbl_Noz_1 = New System.Windows.Forms.Label()
        Me.lbl_Bed = New System.Windows.Forms.Label()
        Me.cbx_Dual = New System.Windows.Forms.CheckBox()
        Me.lbl_Mat_2 = New System.Windows.Forms.Label()
        Me.cbo_Mat_2 = New System.Windows.Forms.ComboBox()
        Me.lbl_Noz_2 = New System.Windows.Forms.Label()
        Me.txt_Noz_2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_OutFile = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Analyze = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Offset = New System.Windows.Forms.Label()
        Me.txt_Offset = New System.Windows.Forms.TextBox()
        Me.cbx_Fan = New System.Windows.Forms.CheckBox()
        Me.cbx_SkipLyr1 = New System.Windows.Forms.CheckBox()
        Me.cbo_Speed = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num_Layer = New System.Windows.Forms.NumericUpDown()
        CType(Me.num_Layer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_InFile
        '
        Me.txt_InFile.Location = New System.Drawing.Point(49, 33)
        Me.txt_InFile.Name = "txt_InFile"
        Me.txt_InFile.Size = New System.Drawing.Size(610, 20)
        Me.txt_InFile.TabIndex = 0
        '
        'btn_Browse
        '
        Me.btn_Browse.Location = New System.Drawing.Point(679, 30)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(75, 23)
        Me.btn_Browse.TabIndex = 1
        Me.btn_Browse.Text = "Browse"
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'btn_Fix2
        '
        Me.btn_Fix2.Enabled = False
        Me.btn_Fix2.Location = New System.Drawing.Point(198, 294)
        Me.btn_Fix2.Name = "btn_Fix2"
        Me.btn_Fix2.Size = New System.Drawing.Size(115, 23)
        Me.btn_Fix2.TabIndex = 2
        Me.btn_Fix2.Text = "Fix Tool Changes"
        Me.btn_Fix2.UseVisualStyleBackColor = True
        '
        'btn_Fix1
        '
        Me.btn_Fix1.Enabled = False
        Me.btn_Fix1.Location = New System.Drawing.Point(49, 294)
        Me.btn_Fix1.Name = "btn_Fix1"
        Me.btn_Fix1.Size = New System.Drawing.Size(113, 23)
        Me.btn_Fix1.TabIndex = 3
        Me.btn_Fix1.Text = "Fix Start/Stop Code"
        Me.btn_Fix1.UseVisualStyleBackColor = True
        '
        'cbo_Printer
        '
        Me.cbo_Printer.Items.AddRange(New Object() {"Monster"})
        Me.cbo_Printer.Location = New System.Drawing.Point(121, 153)
        Me.cbo_Printer.Name = "cbo_Printer"
        Me.cbo_Printer.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Printer.TabIndex = 26
        Me.cbo_Printer.Text = "Monster"
        '
        'cbo_Mat_1
        '
        Me.cbo_Mat_1.FormattingEnabled = True
        Me.cbo_Mat_1.Items.AddRange(New Object() {"PLA", "PETG", "ABS"})
        Me.cbo_Mat_1.Location = New System.Drawing.Point(121, 220)
        Me.cbo_Mat_1.Name = "cbo_Mat_1"
        Me.cbo_Mat_1.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Mat_1.TabIndex = 4
        '
        'lbl_Mat_1
        '
        Me.lbl_Mat_1.AutoSize = True
        Me.lbl_Mat_1.Location = New System.Drawing.Point(46, 223)
        Me.lbl_Mat_1.Name = "lbl_Mat_1"
        Me.lbl_Mat_1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Mat_1.TabIndex = 5
        Me.lbl_Mat_1.Text = "Material 1"
        '
        'txt_Noz_1
        '
        Me.txt_Noz_1.Location = New System.Drawing.Point(360, 221)
        Me.txt_Noz_1.Name = "txt_Noz_1"
        Me.txt_Noz_1.Size = New System.Drawing.Size(81, 20)
        Me.txt_Noz_1.TabIndex = 6
        '
        'txt_Bed
        '
        Me.txt_Bed.Location = New System.Drawing.Point(543, 220)
        Me.txt_Bed.Name = "txt_Bed"
        Me.txt_Bed.Size = New System.Drawing.Size(63, 20)
        Me.txt_Bed.TabIndex = 7
        '
        'lbl_Noz_1
        '
        Me.lbl_Noz_1.AutoSize = True
        Me.lbl_Noz_1.Location = New System.Drawing.Point(275, 223)
        Me.lbl_Noz_1.Name = "lbl_Noz_1"
        Me.lbl_Noz_1.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Noz_1.TabIndex = 8
        Me.lbl_Noz_1.Text = "Nozzle Temp"
        '
        'lbl_Bed
        '
        Me.lbl_Bed.AutoSize = True
        Me.lbl_Bed.Location = New System.Drawing.Point(481, 223)
        Me.lbl_Bed.Name = "lbl_Bed"
        Me.lbl_Bed.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Bed.TabIndex = 9
        Me.lbl_Bed.Text = "Bed Temp"
        '
        'cbx_Dual
        '
        Me.cbx_Dual.AutoSize = True
        Me.cbx_Dual.Enabled = False
        Me.cbx_Dual.Location = New System.Drawing.Point(49, 186)
        Me.cbx_Dual.Name = "cbx_Dual"
        Me.cbx_Dual.Size = New System.Drawing.Size(94, 17)
        Me.cbx_Dual.TabIndex = 11
        Me.cbx_Dual.Text = "Dual Extrusion"
        Me.cbx_Dual.UseVisualStyleBackColor = True
        '
        'lbl_Mat_2
        '
        Me.lbl_Mat_2.AutoSize = True
        Me.lbl_Mat_2.Enabled = False
        Me.lbl_Mat_2.Location = New System.Drawing.Point(46, 256)
        Me.lbl_Mat_2.Name = "lbl_Mat_2"
        Me.lbl_Mat_2.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Mat_2.TabIndex = 13
        Me.lbl_Mat_2.Text = "Material 2"
        '
        'cbo_Mat_2
        '
        Me.cbo_Mat_2.Enabled = False
        Me.cbo_Mat_2.FormattingEnabled = True
        Me.cbo_Mat_2.Items.AddRange(New Object() {"PLA", "PETG", "ABS"})
        Me.cbo_Mat_2.Location = New System.Drawing.Point(121, 253)
        Me.cbo_Mat_2.Name = "cbo_Mat_2"
        Me.cbo_Mat_2.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Mat_2.TabIndex = 12
        '
        'lbl_Noz_2
        '
        Me.lbl_Noz_2.AutoSize = True
        Me.lbl_Noz_2.Enabled = False
        Me.lbl_Noz_2.Location = New System.Drawing.Point(275, 256)
        Me.lbl_Noz_2.Name = "lbl_Noz_2"
        Me.lbl_Noz_2.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Noz_2.TabIndex = 16
        Me.lbl_Noz_2.Text = "Nozzle Temp"
        '
        'txt_Noz_2
        '
        Me.txt_Noz_2.Enabled = False
        Me.txt_Noz_2.Location = New System.Drawing.Point(360, 253)
        Me.txt_Noz_2.Name = "txt_Noz_2"
        Me.txt_Noz_2.Size = New System.Drawing.Size(81, 20)
        Me.txt_Noz_2.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "G Input File"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "GCode Outpt File"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(679, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_OutFile
        '
        Me.txt_OutFile.Location = New System.Drawing.Point(49, 82)
        Me.txt_OutFile.Name = "txt_OutFile"
        Me.txt_OutFile.Size = New System.Drawing.Size(610, 20)
        Me.txt_OutFile.TabIndex = 19
        '
        'btn_Save
        '
        Me.btn_Save.Enabled = False
        Me.btn_Save.Location = New System.Drawing.Point(299, 333)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 22
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(419, 333)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 23
        Me.btn_Exit.Text = "&Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Analyze
        '
        Me.btn_Analyze.Location = New System.Drawing.Point(49, 119)
        Me.btn_Analyze.Name = "btn_Analyze"
        Me.btn_Analyze.Size = New System.Drawing.Size(75, 23)
        Me.btn_Analyze.TabIndex = 24
        Me.btn_Analyze.Text = "Analyze"
        Me.btn_Analyze.UseVisualStyleBackColor = True
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(319, 294)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_status.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Printer"
        '
        'lbl_Offset
        '
        Me.lbl_Offset.AutoSize = True
        Me.lbl_Offset.Location = New System.Drawing.Point(299, 156)
        Me.lbl_Offset.Name = "lbl_Offset"
        Me.lbl_Offset.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Offset.TabIndex = 28
        Me.lbl_Offset.Text = "Z Offset"
        '
        'txt_Offset
        '
        Me.txt_Offset.Location = New System.Drawing.Point(360, 153)
        Me.txt_Offset.Name = "txt_Offset"
        Me.txt_Offset.Size = New System.Drawing.Size(81, 20)
        Me.txt_Offset.TabIndex = 29
        Me.txt_Offset.Text = "1.18"
        '
        'cbx_Fan
        '
        Me.cbx_Fan.AutoSize = True
        Me.cbx_Fan.Checked = True
        Me.cbx_Fan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_Fan.Location = New System.Drawing.Point(484, 155)
        Me.cbx_Fan.Name = "cbx_Fan"
        Me.cbx_Fan.Size = New System.Drawing.Size(44, 17)
        Me.cbx_Fan.TabIndex = 31
        Me.cbx_Fan.Text = "Fan"
        Me.cbx_Fan.UseVisualStyleBackColor = True
        '
        'cbx_SkipLyr1
        '
        Me.cbx_SkipLyr1.AutoSize = True
        Me.cbx_SkipLyr1.Checked = True
        Me.cbx_SkipLyr1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbx_SkipLyr1.Location = New System.Drawing.Point(534, 155)
        Me.cbx_SkipLyr1.Name = "cbx_SkipLyr1"
        Me.cbx_SkipLyr1.Size = New System.Drawing.Size(200, 17)
        Me.cbx_SkipLyr1.TabIndex = 32
        Me.cbx_SkipLyr1.Text = "Leave fan off until beginning of layer:"
        Me.cbx_SkipLyr1.UseVisualStyleBackColor = True
        '
        'cbo_Speed
        '
        Me.cbo_Speed.Items.AddRange(New Object() {"50", "60", "70", "80", "90", "100"})
        Me.cbo_Speed.Location = New System.Drawing.Point(360, 184)
        Me.cbo_Speed.Name = "cbo_Speed"
        Me.cbo_Speed.Size = New System.Drawing.Size(41, 21)
        Me.cbo_Speed.TabIndex = 33
        Me.cbo_Speed.Text = "70"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Speed"
        '
        'num_Layer
        '
        Me.num_Layer.Location = New System.Drawing.Point(734, 152)
        Me.num_Layer.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.num_Layer.Name = "num_Layer"
        Me.num_Layer.Size = New System.Drawing.Size(39, 20)
        Me.num_Layer.TabIndex = 35
        Me.num_Layer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_Layer.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 380)
        Me.Controls.Add(Me.num_Layer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_Speed)
        Me.Controls.Add(Me.cbx_SkipLyr1)
        Me.Controls.Add(Me.cbx_Fan)
        Me.Controls.Add(Me.txt_Offset)
        Me.Controls.Add(Me.lbl_Offset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.btn_Analyze)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt_OutFile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_Noz_2)
        Me.Controls.Add(Me.txt_Noz_2)
        Me.Controls.Add(Me.lbl_Mat_2)
        Me.Controls.Add(Me.cbo_Mat_2)
        Me.Controls.Add(Me.cbx_Dual)
        Me.Controls.Add(Me.lbl_Bed)
        Me.Controls.Add(Me.lbl_Noz_1)
        Me.Controls.Add(Me.txt_Bed)
        Me.Controls.Add(Me.txt_Noz_1)
        Me.Controls.Add(Me.lbl_Mat_1)
        Me.Controls.Add(Me.cbo_Mat_1)
        Me.Controls.Add(Me.btn_Fix1)
        Me.Controls.Add(Me.btn_Fix2)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.txt_InFile)
        Me.Controls.Add(Me.cbo_Printer)
        Me.Name = "Converter"
        Me.Text = "FlashPrint Converter Tool"
        CType(Me.num_Layer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_InFile As System.Windows.Forms.TextBox
    Friend WithEvents btn_Browse As System.Windows.Forms.Button
    Friend WithEvents btn_Fix2 As System.Windows.Forms.Button
    Friend WithEvents btn_Fix1 As System.Windows.Forms.Button
    Friend WithEvents cbo_Mat_1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Mat_1 As System.Windows.Forms.Label
    Friend WithEvents txt_Noz_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Bed As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Noz_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Bed As System.Windows.Forms.Label
    Friend WithEvents cbx_Dual As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Mat_2 As System.Windows.Forms.Label
    Friend WithEvents cbo_Mat_2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Noz_2 As System.Windows.Forms.Label
    Friend WithEvents txt_Noz_2 As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Printer As System.Windows.Forms.ComboBox

    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_OutFile As System.Windows.Forms.TextBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Exit As System.Windows.Forms.Button

    Dim str_Infile As String
    Dim str_LD_SingleStart As String = ";start gcode" & vbLf &
                                    "M140 SBEDTEMP" & vbLf &
                                    "M190 SBEDTEMP" & vbLf &
                                    "M104 SNOZ1TEMP" & vbLf &
                                    "G1 Z5 F50" & vbLf &
                                    "G28" & vbLf &
                                    "M206 Z-ZOFFSET; Set Z offset" & vbLf &
                                    "M109 SNOZ1TEMP" & vbLf &
                                    "M220 SPRINTSPEED ; Set Print speed" & vbLf &
                                    vbLf &
                                    "G90;set print to absolute mode" & vbLf &
                                    "M82;set extruder to absolute mode" & vbLf &
                                    "G92 E0.0;zero extruder" & vbLf &
                                    vbLf &
                                    ";prime extruder" & vbLf &
                                    "G1 Y5.0 Z0.3 F1000.0 ; go outside pritn area" & vbLf &
                                    "G1 X60.0 E9.0  F1000.0 ; intro line" & vbLf &
                                    "G1 X100.0 E12.5  F1000.0 ; intro line" & vbLf &
                                    vbLf &
                                    "G92 X-43 Y-62 E0.0" & vbLf &
                                    "G21" & vbLf & vbLf

    Dim str_LD_SingleStop As String = ";end gcode" & vbLf &
                                 "M104 S0" & vbLf &
                                 "M140 S0" & vbLf &
                                 "G28 X Y" & vbLf &
                                 "M84" & vbLf &
                                 "M107 ; turn off fan" & vbLf &
                                 "M220 S100" & vbLf &
                                 "M206 Z0; Clear Z offset" & vbLf

    Dim str_LD_DualStart As String = ";start gcode" & vbLf &
                                  ";set bed temp and wait for it" & vbLf &
                                  "M140 SBEDTEMP" & vbLf &
                                  "M190 SBEDTEMP" & vbLf &
                                  vbLf &
                                  ";set Extruder Temps" & vbLf &
                                  "M104 SNOZ1TEMP T0" & vbLf &
                                  "M104 SNOZ2TEMP T1" & vbLf &
                                  "G90;set print to absolute mode" & vbLf &
                                  "M82;set extruder to absolute mode" & vbLf &
                                  "G92 E0.0;zero extruder" & vbLf &
                                  vbLf &
                                  "G1 Z5 F50;raise bed 5mm" & vbLf &
                                  "G28;home printer" & vbLf &
                                  "M206 Z-ZOFFSET; Set Z offset" & vbLf &
                                  vbLf &
                                  "M109 SNOZ1TEMP;wait for E1 to reach temp" & vbLf &
                                  "M220 SPRINTSPEED ; Set Print speed" & vbLf &
                                  vbLf &
                                  "G92 X-143 Y-67;set current location in corner" & vbLf &
                                  "G21;set units to mm" & vbLf & vbLf

    Dim str_LD_DualStop As String = ";end gcode" & vbLf &
                                 "M104 S0 T0" & vbLf &
                                 "M104 S0 T1" & vbLf &
                                 "M140 S0" & vbLf &
                                 "G28 X Y" & vbLf &
                                 "M84" & vbLf &
                                 "M107 ; turn off fan" & vbLf &
                                 "M220 S100" & vbLf &
                                 "M206 Z0; Clear Z offset" & vbLf

    Dim str_OF_Start As String = ";start gcode" & vbLf &
                                 ";validate running on correct Printer!" & vbLf &
                                 "M16 Old Faithful" & vbLf &
                                 "M140 SBEDTEMP" & vbLf &
                                 "M190 SBEDTEMP" & vbLf &
                                 "M107 ; turn off fan if on" & vbLf &
                                 "M104 SNOZ1TEMP" & vbLf &
                                 "G1 Z5 F50" & vbLf &
                                 "G28" & vbLf &
                                 "M206 Z-ZOFFSET; Set Z offset" & vbLf &
                                 "M109 SNOZ1TEMP" & vbLf &
                                 "M220 SPRINTSPEED ; Set print speed" & vbLf &
                                 vbLf &
                                 "G90;set print to absolute mode" & vbLf &
                                 "M82;set extruder to absolute mode" & vbLf &
                                 "G92 E0.0;zero extruder" & vbLf &
                                 vbLf &
                                 "G92 X-110 Y-117.5 E0.0" & vbLf &
                                 "G21" & vbLf & vbLf

    Dim str_OF_Stop As String = ";end gcode" & vbLf &
                                "M104 S0" & vbLf &
                                "M140 S0" & vbLf &
                                "G28 X Y" & vbLf &
                                "M84 ; disable motors" & vbLf &
                                "M107 ; turn off fan" & vbLf &
                                "M220 S100" & vbLf &
                                "M206 Z0; Clear Z offset" & vbLf

    Dim str_MNSTR_Start As String = ";start gcode" & vbLf &
                                    ";validate running on correct Printer!" & vbLf &
                                    "M16 Endeavor_Monster_12-2021" & vbLf &
                                    "M140 SBEDTEMP ; set bed temp" & vbLf &
                                    "M104 S160 ; Start warming up Nozzle but dont dribble" & vbLf &
                                    "M107 ; turn off fan if on" & vbLf &
                                    "M190 SBEDTEMP ; wait for bed temp" & vbLf &
                                    vbLf &
                                    "G28 ; home printer" & vbLf &
                                    "G29 ; Level Bed - will leave nozzle at x0y0z10" & vbLf &
                                    "G91 ; relative positioning" & vbLf &
                                    "G1 ZZOFFSET ; Move by Zoffset default 1.2" & vbLf &
                                    "G90 ; absolute positioning" & vbLf &
                                    "M82  ; extruder absolute mode" & vbLf &
                                    "G92 Z10 ; cancel out Zoffset" & vbLf &
                                    vbLf &
                                    "G1 Z50 F1500 ; Move to 50mm" & vbLf &
                                    vbLf &
                                    "M104 SNOZ1TEMP ; set extruder temp" & vbLf &
                                    "M109 SNOZ1TEMP ; wait for extruder temp" & vbLf &
                                    "M220 SPRINTSPEED ; Set Print speed" & vbLf &
                                    vbLf &
                                    "G92 E0.0;zero extruder" & vbLf &
                                    vbLf &
                                    ";prime extruder" & vbLf &
                                    "G1 X51.51 Y141.13 F4800" & vbLf &
                                    "G1 Z.18 F1400" & vbLf &
                                    "G1 X51.51 Y141.13 F4200" & vbLf &
                                    "G1 X52.40 Y140.67 E.1472 F1200" & vbLf &
                                    "G1 X53.29 Y140.22 E.2936" & vbLf &
                                    "G1 X54.18 Y139.76 E.4408" & vbLf &
                                    "G1 X55.08 Y139.31 E.5884" & vbLf &
                                    "G1 X55.97 Y138.86 E.7348" & vbLf &
                                    "G1 X83.99 Y124.58 E5.3524" & vbLf &
                                    "G1 X84.04 Y124.54 E5.3616" & vbLf &
                                    "G1 X111.63 Y100.56 E10.7288" & vbLf &
                                    "G1 X111.67 Y100.51 E10.7384" & vbLf &
                                    "G1 X132.65 Y70.56 E16.1076" & vbLf &
                                    "G1 X132.68 Y70.50 E16.1172" & vbLf &
                                    "G1 X145.77 Y36.38 E20.9432" & vbLf &
                                    "G1 X145.79 Y36.32 E21.4924" & vbLf &
                                    "G1 X150.23 Y.14 E26.8444" & vbLf & vbLf &
                                    "G92 E0;zero extruder" & vbLf &
                                    "G1 E-1.25 F1800" & vbLf & vbLf

    Dim str_MNSTR_Stop As String = ";end gcode" & vbLf &
                                    "G92 E0" & vbLf &
                                    "M104 S0 ; turn off temperature" & vbLf &
                                    "M140 S0 ; turn off heatbed" & vbLf &
                                    "G28 ; home axis" & vbLf &
                                    "M84 ; disable motors" & vbLf &
                                    "M107 ; turn off fan" & vbLf &
                                    "M220 S100" & vbLf

    Dim str_MagicD_Start As String = ";start gcode" & vbLf &
                                 "M140 SBEDTEMP" & vbLf &
                                 "M190 SBEDTEMP" & vbLf &
                                 "M107 ; turn off fan if on" & vbLf &
                                 "M104 SNOZ1TEMP" & vbLf &
                                 "G1 Z5 F50" & vbLf &
                                 "G28" & vbLf &
                                 "M206 Z-ZOFFSET; Set Z offset" & vbLf &
                                 "M109 SNOZ1TEMP" & vbLf &
                                 vbLf &
                                 "G90;set print to absolute mode" & vbLf &
                                 "M82;set extruder to absolute mode" & vbLf &
                                 "G92 E0.0;zero extruder" & vbLf &
                                 vbLf &
                                 "G92 X-110 Y-110 E0.0" & vbLf &
                                 "G21" & vbLf & vbLf

    Dim str_MagicD_Stop As String = ";end gcode" & vbLf &
                                "M104 S0" & vbLf &
                                "M140 S0" & vbLf &
                                "G28 X Y" & vbLf &
                                "M84 ; disable motors" & vbLf &
                                "M107 ; turn off fan" & vbLf &
                                "M220 S100" & vbLf &
                                "M206 Z0; Clear Z offset" & vbLf
    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Select Input File"
        'fd.InitialDirectory = "C:\"
        fd.Filter = "g Files (*.g)|*.g" '|All files (*.*)|*.*"
        fd.FilterIndex = 1
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txt_InFile.Text = fd.FileName
            txt_OutFile.Text = fd.FileName & "code"
            btn_Fix1.Enabled = False
            btn_Fix2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "GCode files (*.gcode)|*.gcode"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'myStream = saveFileDialog1.OpenFile()
            txt_OutFile.Text = saveFileDialog1.FileName
            'If (myStream IsNot Nothing) Then
            ' Code to write the stream goes here.
            'myStream.Close()
        End If
    End Sub
    Friend WithEvents btn_Analyze As System.Windows.Forms.Button

    Private Sub btn_Analyze_Click(sender As Object, e As EventArgs) Handles btn_Analyze.Click
        Dim textReader As New System.IO.StreamReader(txt_InFile.Text)
        str_Infile = textReader.ReadToEnd
        textReader.Close()
        Dim index As Integer = str_Infile.IndexOf("M108 T1")

        btn_Fix1.Enabled = False
        btn_Fix2.Enabled = False
        btn_Fix1.Enabled = True
        btn_Save.Enabled = False

        If index >= 0 Then
            cbx_Dual.Checked = True
            cbx_Dual.Enabled = True
            lbl_Mat_2.Enabled = True
            cbo_Mat_2.Enabled = True
            lbl_Noz_2.Enabled = True
            txt_Noz_2.Enabled = True
            cbo_Printer.Text = "LD Bot"
            cbo_Mat_1.Text = "PLA"
            cbo_Mat_2.Text = "PLA"
        Else
            cbx_Dual.Checked = False
            cbx_Dual.Enabled = False
            lbl_Mat_2.Enabled = False
            cbo_Mat_2.Enabled = False
            lbl_Noz_2.Enabled = False
            txt_Noz_2.Enabled = False
            cbo_Mat_1.Text = "PLA"
            cbo_Mat_2.Text = ""
            txt_Noz_2.Text = ""
        End If
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub cbo_Mat_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Mat_1.SelectedIndexChanged

        Select Case cbo_Mat_1.Text
            Case "PLA"
                txt_Noz_1.Text = "220"
                txt_Bed.Text = "75"
                cbx_Fan.Checked = True
            Case "ABS"
                txt_Noz_1.Text = "235"
                txt_Bed.Text = "110"
                cbx_Fan.Checked = False
            Case "PETG"
                txt_Noz_1.Text = "240"
                txt_Bed.Text = "78"
                cbx_Fan.Checked = True
        End Select
        Select Case cbo_Printer.Text
            Case "Monster"
                Select Case cbo_Mat_1.Text
                    Case "PETG"
                        txt_Offset.Text = "1.18"
                        txt_Bed.Text = "78"
                    Case Else
                        txt_Offset.Text = "1.18"
                End Select
            Case Else
                Select Case cbo_Mat_1.Text
                    Case "PETG"
                        txt_Offset.Text = "0.15"
                    Case Else
                        txt_Offset.Text = "0"
                End Select
        End Select

    End Sub

    Private Sub cbo_Mat_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Mat_2.SelectedIndexChanged
        btn_Fix2.Enabled = True
        Select Case cbo_Mat_2.Text
            Case "PLA"
                txt_Noz_2.Text = "230"
                cbx_Fan.Checked = True
            Case "ABS"
                cbx_Fan.Checked = False
                txt_Noz_2.Text = "235"
            Case "PETG"
                cbx_Fan.Checked = True
                txt_Noz_2.Text = "240"
            Case Else
                btn_Fix2.Enabled = False
                txt_Noz_2.Text = ""
        End Select
    End Sub

    Private Sub cbo_Printer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Printer.SelectedIndexChanged
        Select Case cbo_Printer.Text
            Case "Monster"
                txt_Offset.Enabled = True
                lbl_Offset.Enabled = True

                Select Case cbo_Mat_1.Text
                    Case "PETG"
                        txt_Offset.Text = "1.18"
                    Case Else
                        txt_Offset.Text = "1.18"
                End Select
                'always leave fan enabled
                'cbx_Fan.Enabled = True
            Case Else
                'always leave fan enabled
                'cbx_Fan.Enabled = False
                'txt_Offset.Enabled = False
                'lbl_Offset.Enabled = False
                Select Case cbo_Mat_1.Text
                    Case "PETG"
                        txt_Offset.Text = "0.2"
                    Case Else
                        txt_Offset.Text = "0"
                End Select
        End Select
    End Sub



    Private Sub btn_Fix1_Click(sender As Object, e As EventArgs) Handles btn_Fix1.Click
        Dim str_Start As String = ""
        'Dim str_Stop As String
        'Replace Start Code
        Dim index As Integer = str_Infile.IndexOf("M108 T0") + 7
        str_Infile = str_Infile.Remove(0, index)

        Select Case cbo_Printer.Text
            Case "LD Bot"
                If cbx_Dual.Checked Then
                    str_Start = str_LD_DualStart
                Else
                    str_Start = str_LD_SingleStart
                End If
            Case "Old Faithful"
                str_Start = str_OF_Start
            Case "Monster"
                str_Start = str_MNSTR_Start
            Case "MagicD"
                str_Start = str_MagicD_Start
        End Select

        str_Start = str_Start.Replace("NOZ1TEMP", txt_Noz_1.Text)
        str_Start = str_Start.Replace("NOZ2TEMP", txt_Noz_2.Text)
        str_Start = str_Start.Replace("BEDTEMP", txt_Bed.Text)
        str_Start = str_Start.Replace("ZOFFSET", txt_Offset.Text)

        str_Infile = str_Infile.Insert(0, str_Start)

        'speed up 1st move from F400 to F1400
        index = str_Infile.IndexOf("F400")
        str_Infile = str_Infile.Insert(index + 1, "1")

        'remove M104 S0 T1 M106 extra junk
        str_Infile = str_Infile.Replace("M104 S0 T1" & vbLf & "M106", vbLf)

        'fan control code
        'first, remove any current reference to fan ctl
        str_Infile = str_Infile.Replace("M106", vbLf)

        If (cbx_Fan.Checked) Then
            'find beginning of first layer.  Thankfully flashprint labels each layer.
            index = str_Infile.IndexOf(";layer")
            'if skip first layer, then find second layer
            If cbx_SkipLyr1.Checked Then
                Dim i As Integer

                'skip to next layer until particular layer found
                For i = 2 To num_Layer.Value
                    index = str_Infile.IndexOf(";layer", index + 1)
                Next i
            End If
            index = str_Infile.IndexOf(Chr(10), index + 1)
            str_Infile = str_Infile.Insert(index + 1, vbLf & "M106" & vbLf)
        End If

        'Set PrintSpeed
        str_Infile = str_Infile.Replace("PRINTSPEED", cbo_Speed.Text)

        'Replace End Code
        index = str_Infile.IndexOf(";end gcode")
        str_Infile = str_Infile.Remove(index)

        Select Case cbo_Printer.Text
            Case "LD Bot"
                If cbx_Dual.Checked Then
                    str_Infile = str_Infile & str_LD_DualStop
                    btn_Fix2.Enabled = True
                Else
                    str_Infile = str_Infile & str_LD_SingleStop
                    btn_Save.Enabled = True
                End If
            Case "Old Faithful"
                str_Infile = str_Infile & str_OF_Stop
                btn_Save.Enabled = True
            Case "Monster"
                str_Infile = str_Infile & str_MNSTR_Stop
                btn_Save.Enabled = True
            Case "MagicD"
                str_Infile = str_Infile & str_MagicD_Stop
                btn_Save.Enabled = True
        End Select

        btn_Fix1.Enabled = False

    End Sub

    Private Sub cbx_Dual_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_Dual.CheckedChanged

        If cbx_Dual.Checked Then
            cbx_Dual.Checked = True
            cbx_Dual.Enabled = True
            lbl_Mat_2.Enabled = True
            cbo_Mat_2.Enabled = True
            lbl_Noz_2.Enabled = True
            txt_Noz_2.Enabled = True
            cbo_Mat_2.Text = "PLA"
        Else
            cbx_Dual.Checked = False
            cbx_Dual.Enabled = False
            lbl_Mat_2.Enabled = False
            cbo_Mat_2.Enabled = False
            lbl_Noz_2.Enabled = False
            txt_Noz_2.Enabled = False
            cbo_Mat_2.Text = ""
            txt_Noz_2.Text = ""
            btn_Fix2.Enabled = False
        End If
    End Sub

    Private Sub btn_Fix2_Click(sender As Object, e As EventArgs) Handles btn_Fix2.Click
        Dim index As Integer = 0
        Dim index_end As Integer
        Dim index_end_line As Integer
        Dim str_E As String
        Dim EVal_Last As Double = 0.0 'E value from last line
        Dim EVal As Double = 0.0 'current E value
        'Dim EVal_New As Double
        Dim EVal_Last_Tool As Double = 0.0 'E value from previous Tool
        Dim Tstart As Integer
        Dim Tchange As Integer = 0 'index of next tool change
        Dim ToolChanged As Boolean = False

        lbl_status.Text = "Working..."
        lbl_status.Update()

        'replace all M108 codes
        str_Infile = str_Infile.Replace("M108 T", "T")

        'Start after startcode
        index = str_Infile.IndexOf(";preExtrude")
        Tchange = index

        Do Until Tchange <= 0
            'Determine next position of Tool Change
            Tstart = str_Infile.IndexOf(vbLf & "T0", index) + 1
            Tchange = str_Infile.IndexOf(vbLf & "T1", index) + 1
            If (Tchange <= 0) Then
                Tchange = Tstart
            End If

            If (Tstart < Tchange) And (Tstart > 0) Then
                Tchange = Tstart
            End If

            If Tchange <= 0 Then Continue Do

            index = str_Infile.LastIndexOf(" E", Tchange, 200) + 2

            index_end = str_Infile.IndexOf(" ", index)
            index_end_line = str_Infile.IndexOf(vbLf, index)
            If index_end_line < index_end Then
                index_end = index_end_line
            End If
            str_E = str_Infile.Substring(index, index_end - index)
            'check if it is numeric
            If IsNumeric(str_E) Then
                EVal = Convert.ToDouble(str_E)
            Else 'goto next value
                Continue Do
            End If


            index = str_Infile.IndexOf(vbLf, Tchange) + 1
            str_Infile = str_Infile.Insert(index, "G92 E" & Convert.ToString(EVal_Last) & vbLf)


            EVal_Last = EVal



        Loop

        lbl_status.Text = "DONE"
        btn_Fix2.Enabled = False
        btn_Save.Enabled = True

        'Do While index <> -1
        '    'Determine position of next tool change
        '    Tstart = str_Infile.IndexOf("T0", index) + 1
        '    Tchange = str_Infile.IndexOf("T1", index) + 1
        '    If (Tchange = -1) Then
        '        Tchange = Tstart
        '    End If

        '    If (Tstart < Tchange) And (Tstart <> -1) Then
        '        Tchange = Tstart
        '    End If

        '    'find next E code
        '    index = str_Infile.IndexOf(" E", index) + 2
        '    lbl_status.Text = Convert.ToString(((index / str_Infile.Length) * 100) \ 1) & "%"
        '    lbl_status.Update()

        '    If Tchange > index Then 'If in the middle of an existing tool
        '        'Get Next E Value
        '        index_end = str_Infile.IndexOf(" ", index)
        '        index_end_line = str_Infile.IndexOf(vbLf, index)
        '        If index_end_line < index_end Then
        '            index_end = index_end_line
        '        End If
        '        str_E = str_Infile.Substring(index, index_end - index)
        '        'check if it is numeric
        '        If IsNumeric(str_E) Then
        '            EVal = Convert.ToDouble(str_E)
        '        Else 'goto next E value
        '            Continue Do
        '        End If

        '        If ToolChanged Then
        '            EVal_New = EVal - EVal_Last_Tool
        '            ToolChanged = False
        '        Else
        '            EVal_New = EVal - EVal_Last
        '        End If
        '        EVal_Last = EVal

        '        str_Infile = str_Infile.Remove(index, index_end - index)
        '        str_Infile = str_Infile.Insert(index, Convert.ToString(EVal_New))
        '    Else ' Tool Change
        '        ToolChanged = True
        '        EVal_Last_Tool = EVal_Last
        '    End If
        'Loop

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(txt_OutFile.Text, False)
        file.Write(str_Infile)
        file.Close()
        btn_Save.Enabled = False
    End Sub

    Private Sub cbx_Fan_CheckStateChanged(sender As Object, e As EventArgs) Handles cbx_Fan.CheckStateChanged
        If (cbx_Fan.Checked) Then
            cbx_SkipLyr1.Enabled = True
            num_Layer.Enabled = True
        Else
            cbx_SkipLyr1.Enabled = False
            num_Layer.Enabled = False
        End If
    End Sub

    Private Sub Converter_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim LDBot_En As Boolean = False
        Dim OF_En As Boolean = True
        Dim MagicD_En As Boolean = True

        cbo_Printer.Text = "Monster"

        If LDBot_En Then Me.cbo_Printer.Items.AddRange(New Object() {"LD Bot"})
        If OF_En Then Me.cbo_Printer.Items.AddRange(New Object() {"Old Faithful"})
        If MagicD_En Then Me.cbo_Printer.Items.AddRange(New Object() {"MagicD"})

    End Sub

    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Offset As Label
    Friend WithEvents txt_Offset As TextBox
    Friend WithEvents cbx_Fan As CheckBox
    Friend WithEvents cbx_SkipLyr1 As CheckBox
    Friend WithEvents cbo_Speed As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents num_Layer As NumericUpDown

End Class
