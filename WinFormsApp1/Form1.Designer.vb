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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.radKatie = New System.Windows.Forms.RadioButton()
        Me.radJohn = New System.Windows.Forms.RadioButton()
        Me.radMark = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(495, 117)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(495, 149)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(41, 15)
        Me.lblColor.TabIndex = 1
        Me.lblColor.Text = "Label2"
        '
        'radKatie
        '
        Me.radKatie.AutoSize = True
        Me.radKatie.Location = New System.Drawing.Point(125, 117)
        Me.radKatie.Name = "radKatie"
        Me.radKatie.Size = New System.Drawing.Size(51, 19)
        Me.radKatie.TabIndex = 2
        Me.radKatie.TabStop = True
        Me.radKatie.Text = "Katie"
        Me.radKatie.UseVisualStyleBackColor = True
        '
        'radJohn
        '
        Me.radJohn.AutoSize = True
        Me.radJohn.Location = New System.Drawing.Point(125, 149)
        Me.radJohn.Name = "radJohn"
        Me.radJohn.Size = New System.Drawing.Size(50, 19)
        Me.radJohn.TabIndex = 3
        Me.radJohn.TabStop = True
        Me.radJohn.Text = "John"
        Me.radJohn.UseVisualStyleBackColor = True
        '
        'radMark
        '
        Me.radMark.AutoSize = True
        Me.radMark.Location = New System.Drawing.Point(125, 182)
        Me.radMark.Name = "radMark"
        Me.radMark.Size = New System.Drawing.Size(52, 19)
        Me.radMark.TabIndex = 4
        Me.radMark.TabStop = True
        Me.radMark.Text = "Mark"
        Me.radMark.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(214, 276)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.radMark)
        Me.Controls.Add(Me.radJohn)
        Me.Controls.Add(Me.radKatie)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents radKatie As RadioButton
    Friend WithEvents radJohn As RadioButton
    Friend WithEvents radMark As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
