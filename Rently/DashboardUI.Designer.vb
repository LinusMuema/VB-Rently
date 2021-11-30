<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardUI
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
        Me.TenantsPreview = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewMoreTenantsButton = New System.Windows.Forms.Button()
        Me.SpacesPreview = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewMoreSpacesButton = New System.Windows.Forms.Button()
        CType(Me.TenantsPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpacesPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TenantsPreview
        '
        Me.TenantsPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TenantsPreview.Location = New System.Drawing.Point(51, 109)
        Me.TenantsPreview.Name = "TenantsPreview"
        Me.TenantsPreview.Size = New System.Drawing.Size(659, 200)
        Me.TenantsPreview.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(47, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tenants"
        '
        'ViewMoreTenantsButton
        '
        Me.ViewMoreTenantsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ViewMoreTenantsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMoreTenantsButton.ForeColor = System.Drawing.SystemColors.Info
        Me.ViewMoreTenantsButton.Location = New System.Drawing.Point(576, 64)
        Me.ViewMoreTenantsButton.Name = "ViewMoreTenantsButton"
        Me.ViewMoreTenantsButton.Size = New System.Drawing.Size(134, 32)
        Me.ViewMoreTenantsButton.TabIndex = 2
        Me.ViewMoreTenantsButton.Text = "View More"
        Me.ViewMoreTenantsButton.UseVisualStyleBackColor = False
        '
        'SpacesPreview
        '
        Me.SpacesPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SpacesPreview.Location = New System.Drawing.Point(51, 382)
        Me.SpacesPreview.Name = "SpacesPreview"
        Me.SpacesPreview.Size = New System.Drawing.Size(659, 186)
        Me.SpacesPreview.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(225, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mutinda Apartments"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(47, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Spaces"
        '
        'ViewMoreSpacesButton
        '
        Me.ViewMoreSpacesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ViewMoreSpacesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewMoreSpacesButton.ForeColor = System.Drawing.SystemColors.Info
        Me.ViewMoreSpacesButton.Location = New System.Drawing.Point(576, 331)
        Me.ViewMoreSpacesButton.Name = "ViewMoreSpacesButton"
        Me.ViewMoreSpacesButton.Size = New System.Drawing.Size(134, 32)
        Me.ViewMoreSpacesButton.TabIndex = 6
        Me.ViewMoreSpacesButton.Text = "View More"
        Me.ViewMoreSpacesButton.UseVisualStyleBackColor = False
        '
        'DashboardUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 593)
        Me.Controls.Add(Me.ViewMoreSpacesButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SpacesPreview)
        Me.Controls.Add(Me.ViewMoreTenantsButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TenantsPreview)
        Me.Name = "DashboardUI"
        Me.Text = "DashboardUI"
        CType(Me.TenantsPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpacesPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TenantsPreview As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ViewMoreTenantsButton As Button
    Friend WithEvents SpacesPreview As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ViewMoreSpacesButton As Button
End Class
