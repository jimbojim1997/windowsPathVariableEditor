Public Class options
    Private p As window

    Public Sub New(p As window)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.p = p
    End Sub

    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbVar.Text = p.envVar

        Select Case p.envTgt
            Case EnvironmentVariableTarget.User
                rbUser.Checked = True
            Case EnvironmentVariableTarget.Process
                rbProcess.Checked = True
            Case EnvironmentVariableTarget.Machine
                rbMachine.Checked = True
        End Select

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        p.envVar = tbVar.Text

        If rbUser.Checked Then
            p.envTgt = EnvironmentVariableTarget.User
        ElseIf rbProcess.Checked Then
            p.envTgt = EnvironmentVariableTarget.Process
        ElseIf rbMachine.Checked Then
            p.envTgt = EnvironmentVariableTarget.Machine
        End If

        p.loadVariables()
        Me.Close()
    End Sub
End Class