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
        Me.btnNumbers = New System.Windows.Forms.Button()
        Me.lstNums = New System.Windows.Forms.ListBox()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.lblMaxMin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNumbers
        '
        Me.btnNumbers.Location = New System.Drawing.Point(106, 23)
        Me.btnNumbers.Name = "btnNumbers"
        Me.btnNumbers.Size = New System.Drawing.Size(75, 23)
        Me.btnNumbers.TabIndex = 0
        Me.btnNumbers.Text = "Numbers"
        Me.btnNumbers.UseVisualStyleBackColor = True
        '
        'lstNums
        '
        Me.lstNums.FormattingEnabled = True
        Me.lstNums.Location = New System.Drawing.Point(22, 23)
        Me.lstNums.Name = "lstNums"
        Me.lstNums.Size = New System.Drawing.Size(78, 147)
        Me.lstNums.TabIndex = 1
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(106, 52)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 23)
        Me.btnMax.TabIndex = 2
        Me.btnMax.Text = "Max"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnMin
        '
        Me.btnMin.Location = New System.Drawing.Point(106, 81)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(75, 23)
        Me.btnMin.TabIndex = 3
        Me.btnMin.Text = "Min"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'lblMaxMin
        '
        Me.lblMaxMin.AutoSize = True
        Me.lblMaxMin.Location = New System.Drawing.Point(145, 127)
        Me.lblMaxMin.Name = "lblMaxMin"
        Me.lblMaxMin.Size = New System.Drawing.Size(0, 13)
        Me.lblMaxMin.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 183)
        Me.Controls.Add(Me.lblMaxMin)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.lstNums)
        Me.Controls.Add(Me.btnNumbers)
        Me.Name = "Form1"
        Me.Text = "Max And Min Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNumbers As System.Windows.Forms.Button
    Friend WithEvents lstNums As System.Windows.Forms.ListBox
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents lblMaxMin As System.Windows.Forms.Label

End Class
