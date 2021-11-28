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
        Me.Add_User = New System.Windows.Forms.Button()
        Me.Add_Space = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Add_User
        '
        Me.Add_User.Location = New System.Drawing.Point(40, 39)
        Me.Add_User.Name = "Add_User"
        Me.Add_User.Size = New System.Drawing.Size(141, 52)
        Me.Add_User.TabIndex = 0
        Me.Add_User.Text = "Add User"
        Me.Add_User.UseVisualStyleBackColor = True
        '
        'Add_Space
        '
        Me.Add_Space.Location = New System.Drawing.Point(352, 39)
        Me.Add_Space.Name = "Add_Space"
        Me.Add_Space.Size = New System.Drawing.Size(156, 52)
        Me.Add_Space.TabIndex = 1
        Me.Add_Space.Text = "Add Space"
        Me.Add_Space.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Add_Space)
        Me.Controls.Add(Me.Add_User)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Add_User As Button
    Friend WithEvents Add_Space As Button
End Class
