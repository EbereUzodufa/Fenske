<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backroomNHC
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
        Me.ListBoxmolwtnhc = New System.Windows.Forms.ListBox()
        Me.ListBoxfornhc = New System.Windows.Forms.ListBox()
        Me.ListBoxnanhc = New System.Windows.Forms.ListBox()
        Me.ListBoxmolwtHC = New System.Windows.Forms.ListBox()
        Me.ListBoxforHC = New System.Windows.Forms.ListBox()
        Me.ListBoxnahc = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxmolwtnhc
        '
        Me.ListBoxmolwtnhc.FormattingEnabled = True
        Me.ListBoxmolwtnhc.Location = New System.Drawing.Point(672, 44)
        Me.ListBoxmolwtnhc.Name = "ListBoxmolwtnhc"
        Me.ListBoxmolwtnhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxmolwtnhc.TabIndex = 11
        '
        'ListBoxfornhc
        '
        Me.ListBoxfornhc.FormattingEnabled = True
        Me.ListBoxfornhc.Location = New System.Drawing.Point(546, 44)
        Me.ListBoxfornhc.Name = "ListBoxfornhc"
        Me.ListBoxfornhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxfornhc.TabIndex = 10
        '
        'ListBoxnanhc
        '
        Me.ListBoxnanhc.FormattingEnabled = True
        Me.ListBoxnanhc.Location = New System.Drawing.Point(411, 44)
        Me.ListBoxnanhc.Name = "ListBoxnanhc"
        Me.ListBoxnanhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxnanhc.TabIndex = 9
        '
        'ListBoxmolwtHC
        '
        Me.ListBoxmolwtHC.FormattingEnabled = True
        Me.ListBoxmolwtHC.Location = New System.Drawing.Point(264, 44)
        Me.ListBoxmolwtHC.Name = "ListBoxmolwtHC"
        Me.ListBoxmolwtHC.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxmolwtHC.TabIndex = 8
        '
        'ListBoxforHC
        '
        Me.ListBoxforHC.FormattingEnabled = True
        Me.ListBoxforHC.Location = New System.Drawing.Point(138, 44)
        Me.ListBoxforHC.Name = "ListBoxforHC"
        Me.ListBoxforHC.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxforHC.TabIndex = 7
        '
        'ListBoxnahc
        '
        Me.ListBoxnahc.FormattingEnabled = True
        Me.ListBoxnahc.Items.AddRange(New Object() {"Oxygen", "Nitrogen", "Sulphur", "Carbon", "Hydrogen"})
        Me.ListBoxnahc.Location = New System.Drawing.Point(12, 44)
        Me.ListBoxnahc.Name = "ListBoxnahc"
        Me.ListBoxnahc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxnahc.TabIndex = 6
        '
        'backroomNHC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 520)
        Me.Controls.Add(Me.ListBoxmolwtnhc)
        Me.Controls.Add(Me.ListBoxfornhc)
        Me.Controls.Add(Me.ListBoxnanhc)
        Me.Controls.Add(Me.ListBoxmolwtHC)
        Me.Controls.Add(Me.ListBoxforHC)
        Me.Controls.Add(Me.ListBoxnahc)
        Me.Name = "backroomNHC"
        Me.Text = "backroomNHC"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxmolwtnhc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxfornhc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnanhc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxmolwtHC As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxforHC As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnahc As System.Windows.Forms.ListBox
End Class
