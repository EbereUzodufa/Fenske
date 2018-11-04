<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backroomHC
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
        Me.ListBoxnahc = New System.Windows.Forms.ListBox()
        Me.ListBoxforHC = New System.Windows.Forms.ListBox()
        Me.ListBoxmolwtHC = New System.Windows.Forms.ListBox()
        Me.ListBoxnanhc = New System.Windows.Forms.ListBox()
        Me.ListBoxmolwtnhc = New System.Windows.Forms.ListBox()
        Me.ListBoxfornhc = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBoxnahc
        '
        Me.ListBoxnahc.FormattingEnabled = True
        Me.ListBoxnahc.Items.AddRange(New Object() {"Methane", "Ethane", "Propane", "Butane"})
        Me.ListBoxnahc.Location = New System.Drawing.Point(12, 33)
        Me.ListBoxnahc.Name = "ListBoxnahc"
        Me.ListBoxnahc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxnahc.TabIndex = 0
        '
        'ListBoxforHC
        '
        Me.ListBoxforHC.FormattingEnabled = True
        Me.ListBoxforHC.Location = New System.Drawing.Point(138, 33)
        Me.ListBoxforHC.Name = "ListBoxforHC"
        Me.ListBoxforHC.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxforHC.TabIndex = 1
        '
        'ListBoxmolwtHC
        '
        Me.ListBoxmolwtHC.FormattingEnabled = True
        Me.ListBoxmolwtHC.Location = New System.Drawing.Point(264, 33)
        Me.ListBoxmolwtHC.Name = "ListBoxmolwtHC"
        Me.ListBoxmolwtHC.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxmolwtHC.TabIndex = 2
        '
        'ListBoxnanhc
        '
        Me.ListBoxnanhc.FormattingEnabled = True
        Me.ListBoxnanhc.Location = New System.Drawing.Point(411, 33)
        Me.ListBoxnanhc.Name = "ListBoxnanhc"
        Me.ListBoxnanhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxnanhc.TabIndex = 3
        '
        'ListBoxmolwtnhc
        '
        Me.ListBoxmolwtnhc.FormattingEnabled = True
        Me.ListBoxmolwtnhc.Location = New System.Drawing.Point(672, 33)
        Me.ListBoxmolwtnhc.Name = "ListBoxmolwtnhc"
        Me.ListBoxmolwtnhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxmolwtnhc.TabIndex = 5
        '
        'ListBoxfornhc
        '
        Me.ListBoxfornhc.FormattingEnabled = True
        Me.ListBoxfornhc.Location = New System.Drawing.Point(546, 33)
        Me.ListBoxfornhc.Name = "ListBoxfornhc"
        Me.ListBoxfornhc.Size = New System.Drawing.Size(120, 251)
        Me.ListBoxfornhc.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(397, 376)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Am very Happy"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(588, 376)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'backroomHC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 520)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBoxmolwtnhc)
        Me.Controls.Add(Me.ListBoxfornhc)
        Me.Controls.Add(Me.ListBoxnanhc)
        Me.Controls.Add(Me.ListBoxmolwtHC)
        Me.Controls.Add(Me.ListBoxforHC)
        Me.Controls.Add(Me.ListBoxnahc)
        Me.Name = "backroomHC"
        Me.Text = "backroomHC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxnahc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxforHC As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxmolwtHC As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxnanhc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxmolwtnhc As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxfornhc As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
