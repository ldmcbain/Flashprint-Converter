<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.txt_InFile = New System.Windows.Forms.TextBox()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.btn_Fix2 = New System.Windows.Forms.Button()
        Me.btn_Fix1 = New System.Windows.Forms.Button()
        Me.lbl_Printer = New System.Windows.Forms.Label()
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
        Me.btn_Fix2.Location = New System.Drawing.Point(198, 282)
        Me.btn_Fix2.Name = "btn_Fix2"
        Me.btn_Fix2.Size = New System.Drawing.Size(115, 23)
        Me.btn_Fix2.TabIndex = 2
        Me.btn_Fix2.Text = "Fix Tool Changes"
        Me.btn_Fix2.UseVisualStyleBackColor = True
        '
        'btn_Fix1
        '
        Me.btn_Fix1.Enabled = False
        Me.btn_Fix1.Location = New System.Drawing.Point(49, 282)
        Me.btn_Fix1.Name = "btn_Fix1"
        Me.btn_Fix1.Size = New System.Drawing.Size(113, 23)
        Me.btn_Fix1.TabIndex = 3
        Me.btn_Fix1.Text = "Fix Start/Stop Code"
        Me.btn_Fix1.UseVisualStyleBackColor = True
        '
        'cbo_Mat_1
        '
        Me.cbo_Mat_1.FormattingEnabled = True
        Me.cbo_Mat_1.Items.AddRange(New Object() {"PLA", "PETG", "ABS"})
        Me.cbo_Mat_1.Location = New System.Drawing.Point(121, 193)
        Me.cbo_Mat_1.Name = "cbo_Mat_1"
        Me.cbo_Mat_1.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Mat_1.TabIndex = 4
        '
        'lbl_Mat_1
        '
        Me.lbl_Mat_1.AutoSize = True
        Me.lbl_Mat_1.Location = New System.Drawing.Point(46, 196)
        Me.lbl_Mat_1.Name = "lbl_Mat_1"
        Me.lbl_Mat_1.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Mat_1.TabIndex = 5
        Me.lbl_Mat_1.Text = "Material 1"
        '
        'txt_Noz_1
        '
        Me.txt_Noz_1.Location = New System.Drawing.Point(360, 194)
        Me.txt_Noz_1.Name = "txt_Noz_1"
        Me.txt_Noz_1.Size = New System.Drawing.Size(81, 20)
        Me.txt_Noz_1.TabIndex = 6
        '
        'txt_Bed
        '
        Me.txt_Bed.Location = New System.Drawing.Point(543, 193)
        Me.txt_Bed.Name = "txt_Bed"
        Me.txt_Bed.Size = New System.Drawing.Size(63, 20)
        Me.txt_Bed.TabIndex = 7
        '
        'lbl_Noz_1
        '
        Me.lbl_Noz_1.AutoSize = True
        Me.lbl_Noz_1.Location = New System.Drawing.Point(285, 196)
        Me.lbl_Noz_1.Name = "lbl_Noz_1"
        Me.lbl_Noz_1.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Noz_1.TabIndex = 8
        Me.lbl_Noz_1.Text = "Nozzle Temp"
        '
        'lbl_Bed
        '
        Me.lbl_Bed.AutoSize = True
        Me.lbl_Bed.Location = New System.Drawing.Point(481, 196)
        Me.lbl_Bed.Name = "lbl_Bed"
        Me.lbl_Bed.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Bed.TabIndex = 9
        Me.lbl_Bed.Text = "Bed Temp"
        '
        'cbx_Dual
        '
        Me.cbx_Dual.AutoSize = True
        Me.cbx_Dual.Location = New System.Drawing.Point(49, 159)
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
        Me.lbl_Mat_2.Location = New System.Drawing.Point(46, 229)
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
        Me.cbo_Mat_2.Location = New System.Drawing.Point(121, 226)
        Me.cbo_Mat_2.Name = "cbo_Mat_2"
        Me.cbo_Mat_2.Size = New System.Drawing.Size(121, 21)
        Me.cbo_Mat_2.TabIndex = 12
        '
        'lbl_Noz_2
        '
        Me.lbl_Noz_2.AutoSize = True
        Me.lbl_Noz_2.Enabled = False
        Me.lbl_Noz_2.Location = New System.Drawing.Point(285, 229)
        Me.lbl_Noz_2.Name = "lbl_Noz_2"
        Me.lbl_Noz_2.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Noz_2.TabIndex = 16
        Me.lbl_Noz_2.Text = "Nozzle Temp"
        '
        'txt_Noz_2
        '
        Me.txt_Noz_2.Enabled = False
        Me.txt_Noz_2.Location = New System.Drawing.Point(360, 226)
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
        Me.btn_Save.Location = New System.Drawing.Point(299, 323)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 22
        Me.btn_Save.Text = "&Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(419, 323)
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
        Me.lbl_status.Location = New System.Drawing.Point(319, 287)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_status.TabIndex = 25
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 375)
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
        Me.Controls.Add(Me.lbl_Printer)
        Me.Name = "frm_Main"
        Me.Text = "FlashPrint Fix Tool for LD Bot"
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
    Friend WithEvents lbl_Printer As System.Windows.Forms.Label

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
                                    "M109 SNOZ1TEMP" & vbLf &
                                    "M220 S70 ; Set Speed to 70%" & vbLf &
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
                                 "M84" & vbLf

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
                                  vbLf &
                                  "M109 SNOZ1TEMP;wait for E1 to reach temp" & vbLf &
                                  "M220 S70 ; Set Speed to 70%" & vbLf &
                                  vbLf &
                                  "G92 X-143 Y-67;set current location in corner" & vbLf &
                                  "G21;set units to mm" & vbLf & vbLf

    Dim str_LD_DualStop As String = ";end gcode" & vbLf &
                                 "M104 S0 T0" & vbLf &
                                 "M104 S0 T1" & vbLf &
                                 "M140 S0" & vbLf &
                                 "G28 X Y" & vbLf &
                                 "M84" & vbLf

    Dim str_OF_Start As String = ";start gcode" & vbLf &
                                 "M140 SBEDTEMP" & vbLf &
                                 "M190 SBEDTEMP" & vbLf &
                                 "M104 SNOZ1TEMP" & vbLf &
                                 "G1 Z5 F50" & vbLf &
                                 "G28" & vbLf &
                                 "M109 SNOZ1TEMP" & vbLf &
                                 "M220 S70 ; Set Speed to 70%" & vbLf &
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
                                "M84" & vbLf

    Dim str_MNSTR_Start As String = ";start gcode" & vbLf &
                                    "G90" & vbLf &
                                    "M82  ; extruder absolute mode" & vbLf &
                                    "M140 SBEDTEMP ; set bed temp" & vbLf &
                                    "M190 SBEDTEMP ; wait for bed temp" & vbLf &
                                    "M106 S255" & vbLf &
                                    vbLf &
                                    "M280 S10.6 ; Set servo value for homing" & vbLf &
                                    "G28 ; home printer" & vbLf &
                                    "M280 S3; Set servo" & vbLf &
                                    "G1 Z50 F15000 ; Move to 50mm" & vbLf &
                                    "G30 Z1.2 ; Height Adjustment" & vbLf &
                                    "M280 S7 ; reset servo value" & vbLf &
                                    "G1 X0 Y0 Z100 ; lift nozzle" & vbLf &
                                    "M42" & vbLf &
                                    vbLf &
                                    "M104 SNOZ1TEMP ; set extruder temp" & vbLf &
                                    "M109 SNOZ1TEMP ; wait for extruder temp" & vbLf &
                                    vbLf &
                                    "G92 E0" & vbLf & vbLf

    Dim str_MNSTR_Stop As String = ";end gcode" & vbLf &
                                    "G92 E0" & vbLf &
                                    "M104 S0 ; turn off temperature" & vbLf &
                                    "M140 S0 ; turn off heatbed" & vbLf &
                                    "G28 ; home axis" & vbLf &
                                    "M84 ; disable motors" & vbLf &
                                    "M107" & vbLf

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Select Input File"
        'fd.InitialDirectory = "C:\"
        fd.Filter = "g Files (*.g)|*.g" '|All files (*.*)|*.*"
        fd.FilterIndex = 1
        'fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txt_InFile.Text = fd.FileName
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

        If index >= 0 Then
            cbx_Dual.Checked = True
            cbx_Dual.Enabled = True
            lbl_Mat_2.Enabled = True
            cbo_Mat_2.Enabled = True
            lbl_Noz_2.Enabled = True
            txt_Noz_2.Enabled = True
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
                txt_Noz_1.Text = "215"
                txt_Bed.Text = "78"
            Case "ABS"
                txt_Noz_1.Text = "235"
                txt_Bed.Text = "110"
            Case "PETG"
                txt_Noz_1.Text = "240"
                txt_Bed.Text = "78"
        End Select

    End Sub

    Private Sub cbo_Mat_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Mat_2.SelectedIndexChanged
        btn_Fix2.Enabled = True
        Select Case cbo_Mat_2.Text
            Case "PLA"
                txt_Noz_2.Text = "215"
            Case "ABS"
                txt_Noz_2.Text = "235"
            Case "PETG"
                txt_Noz_2.Text = "240"
            Case Else
                btn_Fix2.Enabled = False
                txt_Noz_2.Text = ""
        End Select
    End Sub

    Private Sub btn_Fix1_Click(sender As Object, e As EventArgs) Handles btn_Fix1.Click
        Dim str_Start As String
        'Dim str_Stop As String
        'Replace Start Code
        Dim index As Integer = str_Infile.IndexOf("M108 T0")
        str_Infile = str_Infile.Remove(0, index)
        If cbx_Dual.Checked Then
            str_Start = str_LD_DualStart.Replace("BEDTEMP", txt_Bed.Text)
        Else
        End If
        str_Start = str_Start.Replace("NOZ1TEMP", txt_Noz_1.Text)
        str_Start = str_Start.Replace("NOZ2TEMP", txt_Noz_2.Text)

        str_Infile = str_Infile.Insert(0, str_Start)

        'Replace End Code
        index = str_Infile.IndexOf(";end gcode")
        str_Infile = str_Infile.Remove(index)
        str_Infile = str_Infile & str_LD_DualStop

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
        Dim EVal_New As Double
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
    End Sub
    Friend WithEvents lbl_status As System.Windows.Forms.Label
End Class
