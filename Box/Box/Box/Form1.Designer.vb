<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MakeBoxButton = New System.Windows.Forms.Button()
        Me.LengthTB = New System.Windows.Forms.TrackBar()
        Me.HeightTB = New System.Windows.Forms.TrackBar()
        Me.WidthTB = New System.Windows.Forms.TrackBar()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.LengthValueLabel = New System.Windows.Forms.Label()
        Me.WidthValueLabel = New System.Windows.Forms.Label()
        Me.HeightValueLabel = New System.Windows.Forms.Label()
        CType(Me.LengthTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MakeBoxButton
        '
        Me.MakeBoxButton.Location = New System.Drawing.Point(714, 13)
        Me.MakeBoxButton.Name = "MakeBoxButton"
        Me.MakeBoxButton.Size = New System.Drawing.Size(75, 23)
        Me.MakeBoxButton.TabIndex = 0
        Me.MakeBoxButton.Text = "Make a box"
        Me.MakeBoxButton.UseVisualStyleBackColor = True
        '
        'LengthTB
        '
        Me.LengthTB.Location = New System.Drawing.Point(561, 359)
        Me.LengthTB.Maximum = 100
        Me.LengthTB.Name = "LengthTB"
        Me.LengthTB.Size = New System.Drawing.Size(189, 45)
        Me.LengthTB.TabIndex = 1
        '
        'HeightTB
        '
        Me.HeightTB.Location = New System.Drawing.Point(561, 436)
        Me.HeightTB.Maximum = 100
        Me.HeightTB.Name = "HeightTB"
        Me.HeightTB.Size = New System.Drawing.Size(189, 45)
        Me.HeightTB.TabIndex = 2
        '
        'WidthTB
        '
        Me.WidthTB.Location = New System.Drawing.Point(561, 396)
        Me.WidthTB.Maximum = 100
        Me.WidthTB.Name = "WidthTB"
        Me.WidthTB.Size = New System.Drawing.Size(189, 45)
        Me.WidthTB.TabIndex = 3
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Location = New System.Drawing.Point(515, 359)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(40, 13)
        Me.LengthLabel.TabIndex = 4
        Me.LengthLabel.Text = "Length"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(515, 436)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(38, 13)
        Me.HeightLabel.TabIndex = 5
        Me.HeightLabel.Text = "Height"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(520, 396)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(35, 13)
        Me.WidthLabel.TabIndex = 6
        Me.WidthLabel.Text = "Width"
        '
        'LengthValueLabel
        '
        Me.LengthValueLabel.AutoSize = True
        Me.LengthValueLabel.Location = New System.Drawing.Point(749, 359)
        Me.LengthValueLabel.Name = "LengthValueLabel"
        Me.LengthValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.LengthValueLabel.TabIndex = 7
        '
        'WidthValueLabel
        '
        Me.WidthValueLabel.AutoSize = True
        Me.WidthValueLabel.Location = New System.Drawing.Point(749, 396)
        Me.WidthValueLabel.Name = "WidthValueLabel"
        Me.WidthValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.WidthValueLabel.TabIndex = 8
        '
        'HeightValueLabel
        '
        Me.HeightValueLabel.AutoSize = True
        Me.HeightValueLabel.Location = New System.Drawing.Point(749, 436)
        Me.HeightValueLabel.Name = "HeightValueLabel"
        Me.HeightValueLabel.Size = New System.Drawing.Size(0, 13)
        Me.HeightValueLabel.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 493)
        Me.Controls.Add(Me.HeightValueLabel)
        Me.Controls.Add(Me.WidthValueLabel)
        Me.Controls.Add(Me.LengthValueLabel)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.LengthLabel)
        Me.Controls.Add(Me.WidthTB)
        Me.Controls.Add(Me.HeightTB)
        Me.Controls.Add(Me.LengthTB)
        Me.Controls.Add(Me.MakeBoxButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LengthTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeightTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MakeBoxButton As System.Windows.Forms.Button
    Friend WithEvents LengthTB As System.Windows.Forms.TrackBar
    Friend WithEvents HeightTB As System.Windows.Forms.TrackBar
    Friend WithEvents WidthTB As System.Windows.Forms.TrackBar
    Friend WithEvents LengthLabel As System.Windows.Forms.Label
    Friend WithEvents HeightLabel As System.Windows.Forms.Label
    Friend WithEvents WidthLabel As System.Windows.Forms.Label
    Friend WithEvents LengthValueLabel As System.Windows.Forms.Label
    Friend WithEvents WidthValueLabel As System.Windows.Forms.Label
    Friend WithEvents HeightValueLabel As System.Windows.Forms.Label

End Class
