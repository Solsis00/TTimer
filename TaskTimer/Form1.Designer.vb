Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTaskTimer
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
        Me.components = New System.ComponentModel.Container()
        Me.bEntry1Start = New System.Windows.Forms.Button()
        Me.bEntry1Stop = New System.Windows.Forms.Button()
        Me.bEntry1Reset = New System.Windows.Forms.Button()
        Me.txtEntry1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEntry1Counter = New System.Windows.Forms.Label()
        Me.rEntry1opt10 = New System.Windows.Forms.RadioButton()
        Me.rEntry1opt15 = New System.Windows.Forms.RadioButton()
        Me.rEntry1opt30 = New System.Windows.Forms.RadioButton()
        Me.rEntry1opt90 = New System.Windows.Forms.RadioButton()
        Me.rEntry1opt60 = New System.Windows.Forms.RadioButton()
        Me.rEntry1opt180 = New System.Windows.Forms.RadioButton()
        Me.Entry1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bEntry2Start = New System.Windows.Forms.Button()
        Me.bEntry2Stop = New System.Windows.Forms.Button()
        Me.bEntry2Reset = New System.Windows.Forms.Button()
        Me.txtEntry2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEntry2Counter = New System.Windows.Forms.Label()
        Me.rEntry2opt10 = New System.Windows.Forms.RadioButton()
        Me.rEntry2opt15 = New System.Windows.Forms.RadioButton()
        Me.rEntry2opt30 = New System.Windows.Forms.RadioButton()
        Me.rEntry2opt90 = New System.Windows.Forms.RadioButton()
        Me.rEntry2opt60 = New System.Windows.Forms.RadioButton()
        Me.rEntry2opt180 = New System.Windows.Forms.RadioButton()
        Me.bEntry3Start = New System.Windows.Forms.Button()
        Me.bEntry3Stop = New System.Windows.Forms.Button()
        Me.bEntry3Reset = New System.Windows.Forms.Button()
        Me.txtEntry3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEntry3Counter = New System.Windows.Forms.Label()
        Me.rEntry3opt10 = New System.Windows.Forms.RadioButton()
        Me.rEntry3opt15 = New System.Windows.Forms.RadioButton()
        Me.rEntry3opt30 = New System.Windows.Forms.RadioButton()
        Me.rEntry3opt90 = New System.Windows.Forms.RadioButton()
        Me.rEntry3opt60 = New System.Windows.Forms.RadioButton()
        Me.rEntry3opt180 = New System.Windows.Forms.RadioButton()
        Me.bEntry4Start = New System.Windows.Forms.Button()
        Me.bEntry4Stop = New System.Windows.Forms.Button()
        Me.bEntry4Reset = New System.Windows.Forms.Button()
        Me.txtEntry4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEntry4Counter = New System.Windows.Forms.Label()
        Me.rEntry4opt10 = New System.Windows.Forms.RadioButton()
        Me.rEntry4opt15 = New System.Windows.Forms.RadioButton()
        Me.rEntry4opt30 = New System.Windows.Forms.RadioButton()
        Me.rEntry4opt90 = New System.Windows.Forms.RadioButton()
        Me.rEntry4opt60 = New System.Windows.Forms.RadioButton()
        Me.rEntry4opt180 = New System.Windows.Forms.RadioButton()
        Me.bEntry5Start = New System.Windows.Forms.Button()
        Me.bEntry5Stop = New System.Windows.Forms.Button()
        Me.bEntry5Reset = New System.Windows.Forms.Button()
        Me.txtEntry5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEntry5Counter = New System.Windows.Forms.Label()
        Me.rEntry5opt10 = New System.Windows.Forms.RadioButton()
        Me.rEntry5opt15 = New System.Windows.Forms.RadioButton()
        Me.rEntry5opt30 = New System.Windows.Forms.RadioButton()
        Me.rEntry5opt90 = New System.Windows.Forms.RadioButton()
        Me.rEntry5opt60 = New System.Windows.Forms.RadioButton()
        Me.rEntry5opt180 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'bEntry1Start
        '
        Me.bEntry1Start.Location = New System.Drawing.Point(170, 55)
        Me.bEntry1Start.Name = "bEntry1Start"
        Me.bEntry1Start.Size = New System.Drawing.Size(50, 23)
        Me.bEntry1Start.TabIndex = 0
        Me.bEntry1Start.Text = "Start"
        Me.bEntry1Start.UseVisualStyleBackColor = True
        '
        'bEntry1Stop
        '
        Me.bEntry1Stop.Location = New System.Drawing.Point(226, 55)
        Me.bEntry1Stop.Name = "bEntry1Stop"
        Me.bEntry1Stop.Size = New System.Drawing.Size(50, 23)
        Me.bEntry1Stop.TabIndex = 1
        Me.bEntry1Stop.Text = "Stop"
        Me.bEntry1Stop.UseVisualStyleBackColor = True
        '
        'bEntry1Reset
        '
        Me.bEntry1Reset.Location = New System.Drawing.Point(282, 55)
        Me.bEntry1Reset.Name = "bEntry1Reset"
        Me.bEntry1Reset.Size = New System.Drawing.Size(75, 23)
        Me.bEntry1Reset.TabIndex = 2
        Me.bEntry1Reset.Text = "Reset"
        Me.bEntry1Reset.UseVisualStyleBackColor = True
        '
        'txtEntry1
        '
        Me.txtEntry1.Location = New System.Drawing.Point(12, 32)
        Me.txtEntry1.Name = "txtEntry1"
        Me.txtEntry1.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry1.TabIndex = 3
        Me.txtEntry1.Text = "Task Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter a task:"
        '
        'lblEntry1Counter
        '
        Me.lblEntry1Counter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEntry1Counter.AutoSize = True
        Me.lblEntry1Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry1Counter.Location = New System.Drawing.Point(118, 28)
        Me.lblEntry1Counter.Name = "lblEntry1Counter"
        Me.lblEntry1Counter.Size = New System.Drawing.Size(20, 24)
        Me.lblEntry1Counter.TabIndex = 5
        Me.lblEntry1Counter.Text = "0"
        '
        'rEntry1opt10
        '
        Me.rEntry1opt10.AutoSize = True
        Me.rEntry1opt10.Location = New System.Drawing.Point(170, 32)
        Me.rEntry1opt10.Name = "rEntry1opt10"
        Me.rEntry1opt10.Size = New System.Drawing.Size(37, 17)
        Me.rEntry1opt10.TabIndex = 6
        Me.rEntry1opt10.TabStop = True
        Me.rEntry1opt10.Tag = "grp1"
        Me.rEntry1opt10.Text = "10"
        Me.rEntry1opt10.UseVisualStyleBackColor = True
        '
        'rEntry1opt15
        '
        Me.rEntry1opt15.AutoSize = True
        Me.rEntry1opt15.Location = New System.Drawing.Point(213, 32)
        Me.rEntry1opt15.Name = "rEntry1opt15"
        Me.rEntry1opt15.Size = New System.Drawing.Size(37, 17)
        Me.rEntry1opt15.TabIndex = 7
        Me.rEntry1opt15.TabStop = True
        Me.rEntry1opt15.Tag = "grp1"
        Me.rEntry1opt15.Text = "15"
        Me.rEntry1opt15.UseVisualStyleBackColor = True
        '
        'rEntry1opt30
        '
        Me.rEntry1opt30.AutoSize = True
        Me.rEntry1opt30.Location = New System.Drawing.Point(256, 32)
        Me.rEntry1opt30.Name = "rEntry1opt30"
        Me.rEntry1opt30.Size = New System.Drawing.Size(37, 17)
        Me.rEntry1opt30.TabIndex = 8
        Me.rEntry1opt30.TabStop = True
        Me.rEntry1opt30.Tag = "grp1"
        Me.rEntry1opt30.Text = "30"
        Me.rEntry1opt30.UseVisualStyleBackColor = True
        '
        'rEntry1opt90
        '
        Me.rEntry1opt90.AutoSize = True
        Me.rEntry1opt90.Location = New System.Drawing.Point(342, 32)
        Me.rEntry1opt90.Name = "rEntry1opt90"
        Me.rEntry1opt90.Size = New System.Drawing.Size(37, 17)
        Me.rEntry1opt90.TabIndex = 9
        Me.rEntry1opt90.TabStop = True
        Me.rEntry1opt90.Tag = "grp1"
        Me.rEntry1opt90.Text = "90"
        Me.rEntry1opt90.UseVisualStyleBackColor = True
        '
        'rEntry1opt60
        '
        Me.rEntry1opt60.AutoSize = True
        Me.rEntry1opt60.Location = New System.Drawing.Point(299, 32)
        Me.rEntry1opt60.Name = "rEntry1opt60"
        Me.rEntry1opt60.Size = New System.Drawing.Size(37, 17)
        Me.rEntry1opt60.TabIndex = 10
        Me.rEntry1opt60.TabStop = True
        Me.rEntry1opt60.Tag = "grp1"
        Me.rEntry1opt60.Text = "60"
        Me.rEntry1opt60.UseVisualStyleBackColor = True
        '
        'rEntry1opt180
        '
        Me.rEntry1opt180.AutoSize = True
        Me.rEntry1opt180.Location = New System.Drawing.Point(385, 32)
        Me.rEntry1opt180.Name = "rEntry1opt180"
        Me.rEntry1opt180.Size = New System.Drawing.Size(43, 17)
        Me.rEntry1opt180.TabIndex = 11
        Me.rEntry1opt180.TabStop = True
        Me.rEntry1opt180.Tag = "grp1"
        Me.rEntry1opt180.Text = "180"
        Me.rEntry1opt180.UseVisualStyleBackColor = True
        '
        'Entry1Timer
        '
        Me.Entry1Timer.Interval = 1000
        '
        'bEntry2Start
        '
        Me.bEntry2Start.Location = New System.Drawing.Point(170, 147)
        Me.bEntry2Start.Name = "bEntry2Start"
        Me.bEntry2Start.Size = New System.Drawing.Size(50, 23)
        Me.bEntry2Start.TabIndex = 0
        Me.bEntry2Start.Text = "Start"
        Me.bEntry2Start.UseVisualStyleBackColor = True
        '
        'bEntry2Stop
        '
        Me.bEntry2Stop.Location = New System.Drawing.Point(226, 147)
        Me.bEntry2Stop.Name = "bEntry2Stop"
        Me.bEntry2Stop.Size = New System.Drawing.Size(50, 23)
        Me.bEntry2Stop.TabIndex = 1
        Me.bEntry2Stop.Text = "Stop"
        Me.bEntry2Stop.UseVisualStyleBackColor = True
        '
        'bEntry2Reset
        '
        Me.bEntry2Reset.Location = New System.Drawing.Point(282, 147)
        Me.bEntry2Reset.Name = "bEntry2Reset"
        Me.bEntry2Reset.Size = New System.Drawing.Size(75, 23)
        Me.bEntry2Reset.TabIndex = 2
        Me.bEntry2Reset.Text = "Reset"
        Me.bEntry2Reset.UseVisualStyleBackColor = True
        '
        'txtEntry2
        '
        Me.txtEntry2.Location = New System.Drawing.Point(12, 124)
        Me.txtEntry2.Name = "txtEntry2"
        Me.txtEntry2.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry2.TabIndex = 3
        Me.txtEntry2.Text = "Task Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter a task:"
        '
        'lblEntry2Counter
        '
        Me.lblEntry2Counter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEntry2Counter.AutoSize = True
        Me.lblEntry2Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry2Counter.Location = New System.Drawing.Point(118, 120)
        Me.lblEntry2Counter.Name = "lblEntry2Counter"
        Me.lblEntry2Counter.Size = New System.Drawing.Size(20, 24)
        Me.lblEntry2Counter.TabIndex = 5
        Me.lblEntry2Counter.Text = "0"
        '
        'rEntry2opt10
        '
        Me.rEntry2opt10.AutoSize = True
        Me.rEntry2opt10.Location = New System.Drawing.Point(170, 124)
        Me.rEntry2opt10.Name = "rEntry2opt10"
        Me.rEntry2opt10.Size = New System.Drawing.Size(37, 17)
        Me.rEntry2opt10.TabIndex = 6
        Me.rEntry2opt10.TabStop = True
        Me.rEntry2opt10.Tag = "grp2"
        Me.rEntry2opt10.Text = "10"
        Me.rEntry2opt10.UseVisualStyleBackColor = True
        '
        'rEntry2opt15
        '
        Me.rEntry2opt15.AutoSize = True
        Me.rEntry2opt15.Location = New System.Drawing.Point(213, 124)
        Me.rEntry2opt15.Name = "rEntry2opt15"
        Me.rEntry2opt15.Size = New System.Drawing.Size(37, 17)
        Me.rEntry2opt15.TabIndex = 7
        Me.rEntry2opt15.TabStop = True
        Me.rEntry2opt15.Tag = "grp2"
        Me.rEntry2opt15.Text = "15"
        Me.rEntry2opt15.UseVisualStyleBackColor = True
        '
        'rEntry2opt30
        '
        Me.rEntry2opt30.AutoSize = True
        Me.rEntry2opt30.Location = New System.Drawing.Point(256, 124)
        Me.rEntry2opt30.Name = "rEntry2opt30"
        Me.rEntry2opt30.Size = New System.Drawing.Size(37, 17)
        Me.rEntry2opt30.TabIndex = 8
        Me.rEntry2opt30.TabStop = True
        Me.rEntry2opt30.Tag = "grp2"
        Me.rEntry2opt30.Text = "30"
        Me.rEntry2opt30.UseVisualStyleBackColor = True
        '
        'rEntry2opt90
        '
        Me.rEntry2opt90.AutoSize = True
        Me.rEntry2opt90.Location = New System.Drawing.Point(342, 124)
        Me.rEntry2opt90.Name = "rEntry2opt90"
        Me.rEntry2opt90.Size = New System.Drawing.Size(37, 17)
        Me.rEntry2opt90.TabIndex = 9
        Me.rEntry2opt90.TabStop = True
        Me.rEntry2opt90.Tag = "grp2"
        Me.rEntry2opt90.Text = "90"
        Me.rEntry2opt90.UseVisualStyleBackColor = True
        '
        'rEntry2opt60
        '
        Me.rEntry2opt60.AutoSize = True
        Me.rEntry2opt60.Location = New System.Drawing.Point(299, 124)
        Me.rEntry2opt60.Name = "rEntry2opt60"
        Me.rEntry2opt60.Size = New System.Drawing.Size(37, 17)
        Me.rEntry2opt60.TabIndex = 10
        Me.rEntry2opt60.TabStop = True
        Me.rEntry2opt60.Tag = "grp2"
        Me.rEntry2opt60.Text = "60"
        Me.rEntry2opt60.UseVisualStyleBackColor = True
        '
        'rEntry2opt180
        '
        Me.rEntry2opt180.AutoSize = True
        Me.rEntry2opt180.Location = New System.Drawing.Point(385, 124)
        Me.rEntry2opt180.Name = "rEntry2opt180"
        Me.rEntry2opt180.Size = New System.Drawing.Size(43, 17)
        Me.rEntry2opt180.TabIndex = 11
        Me.rEntry2opt180.TabStop = True
        Me.rEntry2opt180.Tag = "grp2"
        Me.rEntry2opt180.Text = "180"
        Me.rEntry2opt180.UseVisualStyleBackColor = True
        '
        'bEntry3Start
        '
        Me.bEntry3Start.Location = New System.Drawing.Point(170, 240)
        Me.bEntry3Start.Name = "bEntry3Start"
        Me.bEntry3Start.Size = New System.Drawing.Size(50, 23)
        Me.bEntry3Start.TabIndex = 0
        Me.bEntry3Start.Text = "Start"
        Me.bEntry3Start.UseVisualStyleBackColor = True
        '
        'bEntry3Stop
        '
        Me.bEntry3Stop.Location = New System.Drawing.Point(226, 240)
        Me.bEntry3Stop.Name = "bEntry3Stop"
        Me.bEntry3Stop.Size = New System.Drawing.Size(50, 23)
        Me.bEntry3Stop.TabIndex = 1
        Me.bEntry3Stop.Text = "Stop"
        Me.bEntry3Stop.UseVisualStyleBackColor = True
        '
        'bEntry3Reset
        '
        Me.bEntry3Reset.Location = New System.Drawing.Point(282, 240)
        Me.bEntry3Reset.Name = "bEntry3Reset"
        Me.bEntry3Reset.Size = New System.Drawing.Size(75, 23)
        Me.bEntry3Reset.TabIndex = 2
        Me.bEntry3Reset.Text = "Reset"
        Me.bEntry3Reset.UseVisualStyleBackColor = True
        '
        'txtEntry3
        '
        Me.txtEntry3.Location = New System.Drawing.Point(12, 217)
        Me.txtEntry3.Name = "txtEntry3"
        Me.txtEntry3.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry3.TabIndex = 3
        Me.txtEntry3.Text = "Task Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Enter a task:"
        '
        'lblEntry3Counter
        '
        Me.lblEntry3Counter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEntry3Counter.AutoSize = True
        Me.lblEntry3Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry3Counter.Location = New System.Drawing.Point(118, 213)
        Me.lblEntry3Counter.Name = "lblEntry3Counter"
        Me.lblEntry3Counter.Size = New System.Drawing.Size(20, 24)
        Me.lblEntry3Counter.TabIndex = 5
        Me.lblEntry3Counter.Text = "0"
        '
        'rEntry3opt10
        '
        Me.rEntry3opt10.AutoSize = True
        Me.rEntry3opt10.Location = New System.Drawing.Point(170, 217)
        Me.rEntry3opt10.Name = "rEntry3opt10"
        Me.rEntry3opt10.Size = New System.Drawing.Size(37, 17)
        Me.rEntry3opt10.TabIndex = 6
        Me.rEntry3opt10.TabStop = True
        Me.rEntry3opt10.Text = "10"
        Me.rEntry3opt10.UseVisualStyleBackColor = True
        '
        'rEntry3opt15
        '
        Me.rEntry3opt15.AutoSize = True
        Me.rEntry3opt15.Location = New System.Drawing.Point(213, 217)
        Me.rEntry3opt15.Name = "rEntry3opt15"
        Me.rEntry3opt15.Size = New System.Drawing.Size(37, 17)
        Me.rEntry3opt15.TabIndex = 7
        Me.rEntry3opt15.TabStop = True
        Me.rEntry3opt15.Text = "15"
        Me.rEntry3opt15.UseVisualStyleBackColor = True
        '
        'rEntry3opt30
        '
        Me.rEntry3opt30.AutoSize = True
        Me.rEntry3opt30.Location = New System.Drawing.Point(256, 217)
        Me.rEntry3opt30.Name = "rEntry3opt30"
        Me.rEntry3opt30.Size = New System.Drawing.Size(37, 17)
        Me.rEntry3opt30.TabIndex = 8
        Me.rEntry3opt30.TabStop = True
        Me.rEntry3opt30.Text = "30"
        Me.rEntry3opt30.UseVisualStyleBackColor = True
        '
        'rEntry3opt90
        '
        Me.rEntry3opt90.AutoSize = True
        Me.rEntry3opt90.Location = New System.Drawing.Point(342, 217)
        Me.rEntry3opt90.Name = "rEntry3opt90"
        Me.rEntry3opt90.Size = New System.Drawing.Size(37, 17)
        Me.rEntry3opt90.TabIndex = 9
        Me.rEntry3opt90.TabStop = True
        Me.rEntry3opt90.Text = "90"
        Me.rEntry3opt90.UseVisualStyleBackColor = True
        '
        'rEntry3opt60
        '
        Me.rEntry3opt60.AutoSize = True
        Me.rEntry3opt60.Location = New System.Drawing.Point(299, 217)
        Me.rEntry3opt60.Name = "rEntry3opt60"
        Me.rEntry3opt60.Size = New System.Drawing.Size(37, 17)
        Me.rEntry3opt60.TabIndex = 10
        Me.rEntry3opt60.TabStop = True
        Me.rEntry3opt60.Text = "60"
        Me.rEntry3opt60.UseVisualStyleBackColor = True
        '
        'rEntry3opt180
        '
        Me.rEntry3opt180.AutoSize = True
        Me.rEntry3opt180.Location = New System.Drawing.Point(385, 217)
        Me.rEntry3opt180.Name = "rEntry3opt180"
        Me.rEntry3opt180.Size = New System.Drawing.Size(43, 17)
        Me.rEntry3opt180.TabIndex = 11
        Me.rEntry3opt180.TabStop = True
        Me.rEntry3opt180.Text = "180"
        Me.rEntry3opt180.UseVisualStyleBackColor = True
        '
        'bEntry4Start
        '
        Me.bEntry4Start.Location = New System.Drawing.Point(170, 339)
        Me.bEntry4Start.Name = "bEntry4Start"
        Me.bEntry4Start.Size = New System.Drawing.Size(50, 23)
        Me.bEntry4Start.TabIndex = 0
        Me.bEntry4Start.Text = "Start"
        Me.bEntry4Start.UseVisualStyleBackColor = True
        '
        'bEntry4Stop
        '
        Me.bEntry4Stop.Location = New System.Drawing.Point(226, 339)
        Me.bEntry4Stop.Name = "bEntry4Stop"
        Me.bEntry4Stop.Size = New System.Drawing.Size(50, 23)
        Me.bEntry4Stop.TabIndex = 1
        Me.bEntry4Stop.Text = "Stop"
        Me.bEntry4Stop.UseVisualStyleBackColor = True
        '
        'bEntry4Reset
        '
        Me.bEntry4Reset.Location = New System.Drawing.Point(282, 339)
        Me.bEntry4Reset.Name = "bEntry4Reset"
        Me.bEntry4Reset.Size = New System.Drawing.Size(75, 23)
        Me.bEntry4Reset.TabIndex = 2
        Me.bEntry4Reset.Text = "Reset"
        Me.bEntry4Reset.UseVisualStyleBackColor = True
        '
        'txtEntry4
        '
        Me.txtEntry4.Location = New System.Drawing.Point(12, 316)
        Me.txtEntry4.Name = "txtEntry4"
        Me.txtEntry4.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry4.TabIndex = 3
        Me.txtEntry4.Text = "Task Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Enter a task:"
        '
        'lblEntry4Counter
        '
        Me.lblEntry4Counter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEntry4Counter.AutoSize = True
        Me.lblEntry4Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry4Counter.Location = New System.Drawing.Point(118, 312)
        Me.lblEntry4Counter.Name = "lblEntry4Counter"
        Me.lblEntry4Counter.Size = New System.Drawing.Size(20, 24)
        Me.lblEntry4Counter.TabIndex = 5
        Me.lblEntry4Counter.Text = "0"
        '
        'rEntry4opt10
        '
        Me.rEntry4opt10.AutoSize = True
        Me.rEntry4opt10.Location = New System.Drawing.Point(170, 316)
        Me.rEntry4opt10.Name = "rEntry4opt10"
        Me.rEntry4opt10.Size = New System.Drawing.Size(37, 17)
        Me.rEntry4opt10.TabIndex = 6
        Me.rEntry4opt10.TabStop = True
        Me.rEntry4opt10.Text = "10"
        Me.rEntry4opt10.UseVisualStyleBackColor = True
        '
        'rEntry4opt15
        '
        Me.rEntry4opt15.AutoSize = True
        Me.rEntry4opt15.Location = New System.Drawing.Point(213, 316)
        Me.rEntry4opt15.Name = "rEntry4opt15"
        Me.rEntry4opt15.Size = New System.Drawing.Size(37, 17)
        Me.rEntry4opt15.TabIndex = 7
        Me.rEntry4opt15.TabStop = True
        Me.rEntry4opt15.Text = "15"
        Me.rEntry4opt15.UseVisualStyleBackColor = True
        '
        'rEntry4opt30
        '
        Me.rEntry4opt30.AutoSize = True
        Me.rEntry4opt30.Location = New System.Drawing.Point(256, 316)
        Me.rEntry4opt30.Name = "rEntry4opt30"
        Me.rEntry4opt30.Size = New System.Drawing.Size(37, 17)
        Me.rEntry4opt30.TabIndex = 8
        Me.rEntry4opt30.TabStop = True
        Me.rEntry4opt30.Text = "30"
        Me.rEntry4opt30.UseVisualStyleBackColor = True
        '
        'rEntry4opt90
        '
        Me.rEntry4opt90.AutoSize = True
        Me.rEntry4opt90.Location = New System.Drawing.Point(342, 316)
        Me.rEntry4opt90.Name = "rEntry4opt90"
        Me.rEntry4opt90.Size = New System.Drawing.Size(37, 17)
        Me.rEntry4opt90.TabIndex = 9
        Me.rEntry4opt90.TabStop = True
        Me.rEntry4opt90.Text = "90"
        Me.rEntry4opt90.UseVisualStyleBackColor = True
        '
        'rEntry4opt60
        '
        Me.rEntry4opt60.AutoSize = True
        Me.rEntry4opt60.Location = New System.Drawing.Point(299, 316)
        Me.rEntry4opt60.Name = "rEntry4opt60"
        Me.rEntry4opt60.Size = New System.Drawing.Size(37, 17)
        Me.rEntry4opt60.TabIndex = 10
        Me.rEntry4opt60.TabStop = True
        Me.rEntry4opt60.Text = "60"
        Me.rEntry4opt60.UseVisualStyleBackColor = True
        '
        'rEntry4opt180
        '
        Me.rEntry4opt180.AutoSize = True
        Me.rEntry4opt180.Location = New System.Drawing.Point(385, 316)
        Me.rEntry4opt180.Name = "rEntry4opt180"
        Me.rEntry4opt180.Size = New System.Drawing.Size(43, 17)
        Me.rEntry4opt180.TabIndex = 11
        Me.rEntry4opt180.TabStop = True
        Me.rEntry4opt180.Text = "180"
        Me.rEntry4opt180.UseVisualStyleBackColor = True
        '
        'bEntry5Start
        '
        Me.bEntry5Start.Location = New System.Drawing.Point(170, 440)
        Me.bEntry5Start.Name = "bEntry5Start"
        Me.bEntry5Start.Size = New System.Drawing.Size(50, 23)
        Me.bEntry5Start.TabIndex = 0
        Me.bEntry5Start.Text = "Start"
        Me.bEntry5Start.UseVisualStyleBackColor = True
        '
        'bEntry5Stop
        '
        Me.bEntry5Stop.Location = New System.Drawing.Point(226, 440)
        Me.bEntry5Stop.Name = "bEntry5Stop"
        Me.bEntry5Stop.Size = New System.Drawing.Size(50, 23)
        Me.bEntry5Stop.TabIndex = 1
        Me.bEntry5Stop.Text = "Stop"
        Me.bEntry5Stop.UseVisualStyleBackColor = True
        '
        'bEntry5Reset
        '
        Me.bEntry5Reset.Location = New System.Drawing.Point(282, 440)
        Me.bEntry5Reset.Name = "bEntry5Reset"
        Me.bEntry5Reset.Size = New System.Drawing.Size(75, 23)
        Me.bEntry5Reset.TabIndex = 2
        Me.bEntry5Reset.Text = "Reset"
        Me.bEntry5Reset.UseVisualStyleBackColor = True
        '
        'txtEntry5
        '
        Me.txtEntry5.Location = New System.Drawing.Point(12, 417)
        Me.txtEntry5.Name = "txtEntry5"
        Me.txtEntry5.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry5.TabIndex = 3
        Me.txtEntry5.Text = "Task Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Enter a task:"
        '
        'lblEntry5Counter
        '
        Me.lblEntry5Counter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEntry5Counter.AutoSize = True
        Me.lblEntry5Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry5Counter.Location = New System.Drawing.Point(118, 413)
        Me.lblEntry5Counter.Name = "lblEntry5Counter"
        Me.lblEntry5Counter.Size = New System.Drawing.Size(20, 24)
        Me.lblEntry5Counter.TabIndex = 5
        Me.lblEntry5Counter.Text = "0"
        '
        'rEntry5opt10
        '
        Me.rEntry5opt10.AutoSize = True
        Me.rEntry5opt10.Location = New System.Drawing.Point(170, 417)
        Me.rEntry5opt10.Name = "rEntry5opt10"
        Me.rEntry5opt10.Size = New System.Drawing.Size(37, 17)
        Me.rEntry5opt10.TabIndex = 6
        Me.rEntry5opt10.TabStop = True
        Me.rEntry5opt10.Text = "10"
        Me.rEntry5opt10.UseVisualStyleBackColor = True
        '
        'rEntry5opt15
        '
        Me.rEntry5opt15.AutoSize = True
        Me.rEntry5opt15.Location = New System.Drawing.Point(213, 417)
        Me.rEntry5opt15.Name = "rEntry5opt15"
        Me.rEntry5opt15.Size = New System.Drawing.Size(37, 17)
        Me.rEntry5opt15.TabIndex = 7
        Me.rEntry5opt15.TabStop = True
        Me.rEntry5opt15.Text = "15"
        Me.rEntry5opt15.UseVisualStyleBackColor = True
        '
        'rEntry5opt30
        '
        Me.rEntry5opt30.AutoSize = True
        Me.rEntry5opt30.Location = New System.Drawing.Point(256, 417)
        Me.rEntry5opt30.Name = "rEntry5opt30"
        Me.rEntry5opt30.Size = New System.Drawing.Size(37, 17)
        Me.rEntry5opt30.TabIndex = 8
        Me.rEntry5opt30.TabStop = True
        Me.rEntry5opt30.Text = "30"
        Me.rEntry5opt30.UseVisualStyleBackColor = True
        '
        'rEntry5opt90
        '
        Me.rEntry5opt90.AutoSize = True
        Me.rEntry5opt90.Location = New System.Drawing.Point(342, 417)
        Me.rEntry5opt90.Name = "rEntry5opt90"
        Me.rEntry5opt90.Size = New System.Drawing.Size(37, 17)
        Me.rEntry5opt90.TabIndex = 9
        Me.rEntry5opt90.TabStop = True
        Me.rEntry5opt90.Text = "90"
        Me.rEntry5opt90.UseVisualStyleBackColor = True
        '
        'rEntry5opt60
        '
        Me.rEntry5opt60.AutoSize = True
        Me.rEntry5opt60.Location = New System.Drawing.Point(299, 417)
        Me.rEntry5opt60.Name = "rEntry5opt60"
        Me.rEntry5opt60.Size = New System.Drawing.Size(37, 17)
        Me.rEntry5opt60.TabIndex = 10
        Me.rEntry5opt60.TabStop = True
        Me.rEntry5opt60.Text = "60"
        Me.rEntry5opt60.UseVisualStyleBackColor = True
        '
        'rEntry5opt180
        '
        Me.rEntry5opt180.AutoSize = True
        Me.rEntry5opt180.Location = New System.Drawing.Point(385, 417)
        Me.rEntry5opt180.Name = "rEntry5opt180"
        Me.rEntry5opt180.Size = New System.Drawing.Size(43, 17)
        Me.rEntry5opt180.TabIndex = 11
        Me.rEntry5opt180.TabStop = True
        Me.rEntry5opt180.Text = "180"
        Me.rEntry5opt180.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(163, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 34)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(163, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 34)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'fTaskTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 477)
        Me.Controls.Add(Me.rEntry5opt180)
        Me.Controls.Add(Me.rEntry4opt180)
        Me.Controls.Add(Me.rEntry3opt180)
        Me.Controls.Add(Me.rEntry2opt180)
        Me.Controls.Add(Me.rEntry1opt180)
        Me.Controls.Add(Me.rEntry5opt60)
        Me.Controls.Add(Me.rEntry4opt60)
        Me.Controls.Add(Me.rEntry3opt60)
        Me.Controls.Add(Me.rEntry2opt60)
        Me.Controls.Add(Me.rEntry1opt60)
        Me.Controls.Add(Me.rEntry5opt90)
        Me.Controls.Add(Me.rEntry4opt90)
        Me.Controls.Add(Me.rEntry3opt90)
        Me.Controls.Add(Me.rEntry2opt90)
        Me.Controls.Add(Me.rEntry1opt90)
        Me.Controls.Add(Me.rEntry5opt30)
        Me.Controls.Add(Me.rEntry4opt30)
        Me.Controls.Add(Me.rEntry3opt30)
        Me.Controls.Add(Me.rEntry2opt30)
        Me.Controls.Add(Me.rEntry1opt30)
        Me.Controls.Add(Me.rEntry5opt15)
        Me.Controls.Add(Me.rEntry4opt15)
        Me.Controls.Add(Me.rEntry3opt15)
        Me.Controls.Add(Me.rEntry2opt15)
        Me.Controls.Add(Me.rEntry1opt15)
        Me.Controls.Add(Me.rEntry5opt10)
        Me.Controls.Add(Me.rEntry4opt10)
        Me.Controls.Add(Me.rEntry3opt10)
        Me.Controls.Add(Me.rEntry2opt10)
        Me.Controls.Add(Me.rEntry1opt10)
        Me.Controls.Add(Me.lblEntry5Counter)
        Me.Controls.Add(Me.lblEntry4Counter)
        Me.Controls.Add(Me.lblEntry3Counter)
        Me.Controls.Add(Me.lblEntry2Counter)
        Me.Controls.Add(Me.lblEntry1Counter)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEntry5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEntry4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bEntry5Reset)
        Me.Controls.Add(Me.txtEntry3)
        Me.Controls.Add(Me.bEntry4Reset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bEntry3Reset)
        Me.Controls.Add(Me.bEntry5Stop)
        Me.Controls.Add(Me.txtEntry2)
        Me.Controls.Add(Me.bEntry4Stop)
        Me.Controls.Add(Me.bEntry2Reset)
        Me.Controls.Add(Me.bEntry3Stop)
        Me.Controls.Add(Me.bEntry5Start)
        Me.Controls.Add(Me.txtEntry1)
        Me.Controls.Add(Me.bEntry4Start)
        Me.Controls.Add(Me.bEntry2Stop)
        Me.Controls.Add(Me.bEntry3Start)
        Me.Controls.Add(Me.bEntry1Reset)
        Me.Controls.Add(Me.bEntry2Start)
        Me.Controls.Add(Me.bEntry1Stop)
        Me.Controls.Add(Me.bEntry1Start)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "fTaskTimer"
        Me.Text = "Task Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bEntry1Start As System.Windows.Forms.Button
    Friend WithEvents bEntry1Stop As System.Windows.Forms.Button
    Friend WithEvents bEntry1Reset As System.Windows.Forms.Button
    Friend WithEvents txtEntry1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEntry1Counter As System.Windows.Forms.Label
    Friend WithEvents rEntry1opt10 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry1opt15 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry1opt30 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry1opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry1opt60 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry1opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents Entry1Timer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer








    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Copyright ©1996-2011 VBnet/Randy Birch, All Rights Reserved.
    ' Some pages may also contain other copyrights by the author.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ' Distribution: You can freely use this code in your own
    '               applications, but you may not reproduce 
    '               or publish this code on any web site,
    '               online service, or distribute as source 
    '               on any media without express permission.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Declare Function FlashWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal bInvert As Integer) As Integer

    Public Entry1Time As Integer
    Public Entry1Counter As Integer

    Private Sub fTaskTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Entry1Time = 0
    End Sub

    Private Sub txtEntry1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEntry1.MouseClick, txtEntry2.MouseClick, txtEntry3.MouseClick, txtEntry4.MouseClick, txtEntry5.MouseClick
        If txtEntry1.Text = "Task Name" Then
            txtEntry1.Text = ""
        End If
    End Sub

    Private Sub rEntry1opt10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt10.CheckedChanged, rEntry2opt10.CheckedChanged, rEntry4opt10.CheckedChanged, rEntry5opt10.CheckedChanged, rEntry3opt10.CheckedChanged
        Entry1Time = 10
    End Sub

    Private Sub rEntry1opt15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt15.CheckedChanged, rEntry4opt15.CheckedChanged, rEntry2opt15.CheckedChanged, rEntry5opt15.CheckedChanged, rEntry3opt15.CheckedChanged
        Entry1Time = 15
    End Sub

    Private Sub rEntry1opt30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt30.CheckedChanged, rEntry4opt30.CheckedChanged, rEntry5opt30.CheckedChanged, rEntry2opt30.CheckedChanged, rEntry3opt30.CheckedChanged
        Entry1Time = 30
    End Sub

    Private Sub rEntry1opt60_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt60.CheckedChanged, rEntry3opt60.CheckedChanged, rEntry4opt60.CheckedChanged, rEntry5opt60.CheckedChanged, rEntry2opt60.CheckedChanged
        Entry1Time = 60
    End Sub

    Private Sub rEntry1opt90_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt90.CheckedChanged, rEntry3opt90.CheckedChanged, rEntry4opt90.CheckedChanged, rEntry5opt90.CheckedChanged, rEntry2opt90.CheckedChanged
        Entry1Time = 90
    End Sub

    Private Sub rEntry1opt180_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rEntry1opt180.CheckedChanged, rEntry3opt180.CheckedChanged, rEntry4opt180.CheckedChanged, rEntry5opt180.CheckedChanged, rEntry2opt180.CheckedChanged
        Entry1Time = 180
    End Sub

    Private Sub bEntry1Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEntry1Start.Click, bEntry2Start.Click, bEntry5Start.Click, bEntry3Start.Click, bEntry4Start.Click
        If Entry1Time <> 0 Then
            Entry1Timer.Enabled = True
        Else
            'Entry1Timer.Enabled = True
            MsgBox("Please select the length of the timer.")
        End If
    End Sub

    Private Sub bEntry1Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEntry1Stop.Click, bEntry5Stop.Click, bEntry2Stop.Click, bEntry3Stop.Click, bEntry4Stop.Click
        Entry1Timer.Enabled = False
    End Sub

    Private Sub bEntry1Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEntry1Reset.Click, bEntry5Reset.Click, bEntry2Reset.Click, bEntry3Reset.Click, bEntry4Reset.Click
        Entry1Timer.Enabled = False
        lblEntry1Counter.Text = 0
    End Sub

    Private Sub Entry1Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entry1Timer.Tick
        lblEntry1Counter.Text = lblEntry1Counter.Text + 1
        If lblEntry1Counter.Text = Entry1Time * 60 Then
            'If lblEntry1Count.Text = 5 Then 'Old code used to test the highlight when the timer expires
            FlashWindow(Me.Handle, 1)   'Calls the current form (Me = parent form) to flash when minimized

            'Create a new window and flash
            MsgBox("TIMER UP!")
        End If
    End Sub
    Friend WithEvents bEntry2Start As System.Windows.Forms.Button
    Friend WithEvents bEntry2Stop As System.Windows.Forms.Button
    Friend WithEvents bEntry2Reset As System.Windows.Forms.Button
    Friend WithEvents txtEntry2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEntry2Counter As System.Windows.Forms.Label
    Friend WithEvents rEntry2opt10 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry2opt15 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry2opt30 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry2opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry2opt60 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry2opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents bEntry3Start As System.Windows.Forms.Button
    Friend WithEvents bEntry3Stop As System.Windows.Forms.Button
    Friend WithEvents bEntry3Reset As System.Windows.Forms.Button
    Friend WithEvents txtEntry3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblEntry3Counter As System.Windows.Forms.Label
    Friend WithEvents rEntry3opt10 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry3opt15 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry3opt30 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry3opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry3opt60 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry3opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents bEntry4Start As System.Windows.Forms.Button
    Friend WithEvents bEntry4Stop As System.Windows.Forms.Button
    Friend WithEvents bEntry4Reset As System.Windows.Forms.Button
    Friend WithEvents txtEntry4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblEntry4Counter As System.Windows.Forms.Label
    Friend WithEvents rEntry4opt10 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry4opt15 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry4opt30 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry4opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry4opt60 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry4opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents bEntry5Start As System.Windows.Forms.Button
    Friend WithEvents bEntry5Stop As System.Windows.Forms.Button
    Friend WithEvents bEntry5Reset As System.Windows.Forms.Button
    Friend WithEvents txtEntry5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblEntry5Counter As System.Windows.Forms.Label
    Friend WithEvents rEntry5opt10 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry5opt15 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry5opt30 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry5opt90 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry5opt60 As System.Windows.Forms.RadioButton
    Friend WithEvents rEntry5opt180 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class