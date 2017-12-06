<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.numSteps = New System.Windows.Forms.NumericUpDown()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.btnStopTimer = New System.Windows.Forms.Button()
        Me.timerStep = New System.Windows.Forms.Timer(Me.components)
        Me.GameField1 = New Langtons_Ant.gameField()
        CType(Me.numSteps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(290, 339)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 1
        Me.btnRestart.Text = "restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(371, 339)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(75, 23)
        Me.btnStep.TabIndex = 2
        Me.btnStep.Text = "step once"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'numSteps
        '
        Me.numSteps.Location = New System.Drawing.Point(452, 342)
        Me.numSteps.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numSteps.Name = "numSteps"
        Me.numSteps.Size = New System.Drawing.Size(120, 20)
        Me.numSteps.TabIndex = 3
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(578, 339)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "play steps"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStartTimer
        '
        Me.btnStartTimer.Location = New System.Drawing.Point(12, 339)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(75, 23)
        Me.btnStartTimer.TabIndex = 5
        Me.btnStartTimer.Text = "start timer"
        Me.btnStartTimer.UseVisualStyleBackColor = True
        '
        'btnStopTimer
        '
        Me.btnStopTimer.Location = New System.Drawing.Point(93, 339)
        Me.btnStopTimer.Name = "btnStopTimer"
        Me.btnStopTimer.Size = New System.Drawing.Size(75, 23)
        Me.btnStopTimer.TabIndex = 6
        Me.btnStopTimer.Text = "stop timer"
        Me.btnStopTimer.UseVisualStyleBackColor = True
        '
        'timerStep
        '
        Me.timerStep.Interval = 200
        '
        'GameField1
        '
        Me.GameField1.Location = New System.Drawing.Point(12, 12)
        Me.GameField1.Name = "GameField1"
        Me.GameField1.Size = New System.Drawing.Size(641, 321)
        Me.GameField1.TabIndex = 0
        Me.GameField1.Text = "GameField1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 368)
        Me.Controls.Add(Me.btnStopTimer)
        Me.Controls.Add(Me.btnStartTimer)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.numSteps)
        Me.Controls.Add(Me.btnStep)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.GameField1)
        Me.Name = "Form1"
        Me.Text = "Langton's Ant"
        CType(Me.numSteps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameField1 As Langtons_Ant.gameField
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnStep As System.Windows.Forms.Button
    Friend WithEvents numSteps As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnStartTimer As System.Windows.Forms.Button
    Friend WithEvents btnStopTimer As System.Windows.Forms.Button
    Friend WithEvents timerStep As System.Windows.Forms.Timer

End Class
