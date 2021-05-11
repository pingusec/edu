<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.B_Inspect = New System.Windows.Forms.Button()
        CType(Me.LengthTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeightTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MakeBoxButton
        '
        Me.MakeBoxButton.Location = New System.Drawing.Point(952, 16)
        Me.MakeBoxButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MakeBoxButton.Name = "MakeBoxButton"
        Me.MakeBoxButton.Size = New System.Drawing.Size(100, 28)
        Me.MakeBoxButton.TabIndex = 0
        Me.MakeBoxButton.Text = "Make a box"
        Me.MakeBoxButton.UseVisualStyleBackColor = True
        '
        'LengthTB
        '
        Me.LengthTB.Location = New System.Drawing.Point(748, 442)
        Me.LengthTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LengthTB.Maximum = 1000
        Me.LengthTB.Name = "LengthTB"
        Me.LengthTB.Size = New System.Drawing.Size(252, 56)
        Me.LengthTB.TabIndex = 1
        '
        'HeightTB
        '
        Me.HeightTB.Location = New System.Drawing.Point(748, 537)
        Me.HeightTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HeightTB.Maximum = 1000
        Me.HeightTB.Name = "HeightTB"
        Me.HeightTB.Size = New System.Drawing.Size(252, 56)
        Me.HeightTB.TabIndex = 2
        '
        'WidthTB
        '
        Me.WidthTB.Location = New System.Drawing.Point(748, 487)
        Me.WidthTB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WidthTB.Maximum = 1000
        Me.WidthTB.Name = "WidthTB"
        Me.WidthTB.Size = New System.Drawing.Size(252, 56)
        Me.WidthTB.TabIndex = 3
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Location = New System.Drawing.Point(687, 442)
        Me.LengthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(52, 17)
        Me.LengthLabel.TabIndex = 4
        Me.LengthLabel.Text = "Length"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(687, 537)
        Me.HeightLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(49, 17)
        Me.HeightLabel.TabIndex = 5
        Me.HeightLabel.Text = "Height"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(693, 487)
        Me.WidthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(44, 17)
        Me.WidthLabel.TabIndex = 6
        Me.WidthLabel.Text = "Width"
        '
        'LengthValueLabel
        '
        Me.LengthValueLabel.AutoSize = True
        Me.LengthValueLabel.Location = New System.Drawing.Point(999, 442)
        Me.LengthValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LengthValueLabel.Name = "LengthValueLabel"
        Me.LengthValueLabel.Size = New System.Drawing.Size(0, 17)
        Me.LengthValueLabel.TabIndex = 7
        '
        'WidthValueLabel
        '
        Me.WidthValueLabel.AutoSize = True
        Me.WidthValueLabel.Location = New System.Drawing.Point(999, 487)
        Me.WidthValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WidthValueLabel.Name = "WidthValueLabel"
        Me.WidthValueLabel.Size = New System.Drawing.Size(0, 17)
        Me.WidthValueLabel.TabIndex = 8
        '
        'HeightValueLabel
        '
        Me.HeightValueLabel.AutoSize = True
        Me.HeightValueLabel.Location = New System.Drawing.Point(999, 537)
        Me.HeightValueLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeightValueLabel.Name = "HeightValueLabel"
        Me.HeightValueLabel.Size = New System.Drawing.Size(0, 17)
        Me.HeightValueLabel.TabIndex = 9
        '
        'B_Inspect
        '
        Me.B_Inspect.Location = New System.Drawing.Point(952, 52)
        Me.B_Inspect.Name = "B_Inspect"
        Me.B_Inspect.Size = New System.Drawing.Size(100, 30)
        Me.B_Inspect.TabIndex = 10
        Me.B_Inspect.Text = "Inspect"
        Me.B_Inspect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 607)
        Me.Controls.Add(Me.B_Inspect)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents B_Inspect As Button
End Class
