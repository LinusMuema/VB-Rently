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
        Me.Edit_User = New System.Windows.Forms.Button()
        Me.Edit_Space = New System.Windows.Forms.Button()
        Me.Add_Transaction = New System.Windows.Forms.Button()
        Me.Edit_Transaction = New System.Windows.Forms.Button()
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
        Me.Add_Space.Location = New System.Drawing.Point(234, 39)
        Me.Add_Space.Name = "Add_Space"
        Me.Add_Space.Size = New System.Drawing.Size(156, 52)
        Me.Add_Space.TabIndex = 1
        Me.Add_Space.Text = "Add Space"
        Me.Add_Space.UseVisualStyleBackColor = True
        '
        'Edit_User
        '
        Me.Edit_User.Location = New System.Drawing.Point(40, 145)
        Me.Edit_User.Name = "Edit_User"
        Me.Edit_User.Size = New System.Drawing.Size(141, 51)
        Me.Edit_User.TabIndex = 2
        Me.Edit_User.Text = "Edit User"
        Me.Edit_User.UseVisualStyleBackColor = True
        '
        'Edit_Space
        '
        Me.Edit_Space.Location = New System.Drawing.Point(234, 146)
        Me.Edit_Space.Name = "Edit_Space"
        Me.Edit_Space.Size = New System.Drawing.Size(156, 50)
        Me.Edit_Space.TabIndex = 3
        Me.Edit_Space.Text = "Edit Space"
        Me.Edit_Space.UseVisualStyleBackColor = True
        '
        'Add_Transaction
        '
        Me.Add_Transaction.Location = New System.Drawing.Point(495, 39)
        Me.Add_Transaction.Name = "Add_Transaction"
        Me.Add_Transaction.Size = New System.Drawing.Size(134, 51)
        Me.Add_Transaction.TabIndex = 4
        Me.Add_Transaction.Text = "Add Transaction"
        Me.Add_Transaction.UseVisualStyleBackColor = True
        '
        'Edit_Transaction
        '
        Me.Edit_Transaction.Location = New System.Drawing.Point(495, 146)
        Me.Edit_Transaction.Name = "Edit_Transaction"
        Me.Edit_Transaction.Size = New System.Drawing.Size(134, 50)
        Me.Edit_Transaction.TabIndex = 5
        Me.Edit_Transaction.Text = "Edit Transaction"
        Me.Edit_Transaction.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Edit_Transaction)
        Me.Controls.Add(Me.Add_Transaction)
        Me.Controls.Add(Me.Edit_Space)
        Me.Controls.Add(Me.Edit_User)
        Me.Controls.Add(Me.Add_Space)
        Me.Controls.Add(Me.Add_User)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Add_User As Button
    Friend WithEvents Add_Space As Button
    Friend WithEvents Edit_User As Button
    Friend WithEvents Edit_Space As Button
    Friend WithEvents Add_Transaction As Button
    Friend WithEvents Edit_Transaction As Button
End Class
