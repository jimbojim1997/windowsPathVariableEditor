<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(options))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblVarName = New System.Windows.Forms.Label()
        Me.tbVar = New System.Windows.Forms.TextBox()
        Me.gbTgt = New System.Windows.Forms.GroupBox()
        Me.rbMachine = New System.Windows.Forms.RadioButton()
        Me.rbProcess = New System.Windows.Forms.RadioButton()
        Me.rbUser = New System.Windows.Forms.RadioButton()
        Me.gbTgt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(106, 127)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(25, 127)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblVarName
        '
        Me.lblVarName.AutoSize = True
        Me.lblVarName.Location = New System.Drawing.Point(12, 9)
        Me.lblVarName.Name = "lblVarName"
        Me.lblVarName.Size = New System.Drawing.Size(45, 13)
        Me.lblVarName.TabIndex = 2
        Me.lblVarName.Text = "Variable"
        '
        'tbVar
        '
        Me.tbVar.Location = New System.Drawing.Point(63, 6)
        Me.tbVar.Name = "tbVar"
        Me.tbVar.Size = New System.Drawing.Size(107, 20)
        Me.tbVar.TabIndex = 3
        '
        'gbTgt
        '
        Me.gbTgt.Controls.Add(Me.rbMachine)
        Me.gbTgt.Controls.Add(Me.rbProcess)
        Me.gbTgt.Controls.Add(Me.rbUser)
        Me.gbTgt.Location = New System.Drawing.Point(15, 32)
        Me.gbTgt.Name = "gbTgt"
        Me.gbTgt.Size = New System.Drawing.Size(155, 90)
        Me.gbTgt.TabIndex = 4
        Me.gbTgt.TabStop = False
        Me.gbTgt.Text = "Target"
        '
        'rbMachine
        '
        Me.rbMachine.AutoSize = True
        Me.rbMachine.Location = New System.Drawing.Point(6, 65)
        Me.rbMachine.Name = "rbMachine"
        Me.rbMachine.Size = New System.Drawing.Size(149, 17)
        Me.rbMachine.TabIndex = 7
        Me.rbMachine.TabStop = True
        Me.rbMachine.Text = "Machine (Requires Admin)"
        Me.rbMachine.UseVisualStyleBackColor = True
        '
        'rbProcess
        '
        Me.rbProcess.AutoSize = True
        Me.rbProcess.Location = New System.Drawing.Point(6, 42)
        Me.rbProcess.Name = "rbProcess"
        Me.rbProcess.Size = New System.Drawing.Size(63, 17)
        Me.rbProcess.TabIndex = 6
        Me.rbProcess.TabStop = True
        Me.rbProcess.Text = "Process"
        Me.rbProcess.UseVisualStyleBackColor = True
        '
        'rbUser
        '
        Me.rbUser.AutoSize = True
        Me.rbUser.Location = New System.Drawing.Point(6, 19)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(47, 17)
        Me.rbUser.TabIndex = 5
        Me.rbUser.TabStop = True
        Me.rbUser.Text = "User"
        Me.rbUser.UseVisualStyleBackColor = True
        '
        'options
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(181, 150)
        Me.Controls.Add(Me.gbTgt)
        Me.Controls.Add(Me.tbVar)
        Me.Controls.Add(Me.lblVarName)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(197, 188)
        Me.MinimumSize = New System.Drawing.Size(197, 188)
        Me.Name = "options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Variable Editor Options"
        Me.gbTgt.ResumeLayout(False)
        Me.gbTgt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lblVarName As Label
    Friend WithEvents tbVar As TextBox
    Friend WithEvents gbTgt As GroupBox
    Friend WithEvents rbUser As RadioButton
    Friend WithEvents rbMachine As RadioButton
    Friend WithEvents rbProcess As RadioButton
End Class
