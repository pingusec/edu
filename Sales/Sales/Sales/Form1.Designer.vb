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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Customer = New System.Windows.Forms.Button()
        Me.B_Sales = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales opening form"
        '
        'B_Customer
        '
        Me.B_Customer.Location = New System.Drawing.Point(12, 218)
        Me.B_Customer.Name = "B_Customer"
        Me.B_Customer.Size = New System.Drawing.Size(81, 31)
        Me.B_Customer.TabIndex = 1
        Me.B_Customer.Text = "Customer"
        Me.B_Customer.UseVisualStyleBackColor = True
        '
        'B_Sales
        '
        Me.B_Sales.Location = New System.Drawing.Point(191, 218)
        Me.B_Sales.Name = "B_Sales"
        Me.B_Sales.Size = New System.Drawing.Size(81, 31)
        Me.B_Sales.TabIndex = 2
        Me.B_Sales.Text = "Sales"
        Me.B_Sales.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.B_Sales)
        Me.Controls.Add(Me.B_Customer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_Customer As System.Windows.Forms.Button
    Friend WithEvents B_Sales As System.Windows.Forms.Button

End Class
