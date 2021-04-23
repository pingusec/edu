<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.B_SalesBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_SalesBack
        '
        Me.B_SalesBack.Location = New System.Drawing.Point(224, 219)
        Me.B_SalesBack.Name = "B_SalesBack"
        Me.B_SalesBack.Size = New System.Drawing.Size(48, 30)
        Me.B_SalesBack.TabIndex = 2
        Me.B_SalesBack.Text = "Back"
        Me.B_SalesBack.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.B_SalesBack)
        Me.Name = "ProductForm"
        Me.Text = "ProductForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B_SalesBack As System.Windows.Forms.Button
End Class
