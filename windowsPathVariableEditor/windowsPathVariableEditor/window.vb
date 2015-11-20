Public Class window
    Public envVar As String = "path"
    Public envTgt As EnvironmentVariableTarget = EnvironmentVariableTarget.User

    Public Sub loadVariables()
        Dim paths As String = Environment.GetEnvironmentVariable(envVar, envTgt)
        lbVariables.Items.Clear()
        If Not String.IsNullOrWhiteSpace(paths) Then

            For Each path As String In paths.Split(";")
                If Not String.IsNullOrWhiteSpace(path) Then
                    lbVariables.Items.Add(path)
                End If
            Next
        Else
            MessageBox.Show("Invalid variable name.")
        End If
    End Sub

    Private Sub saveVariables()
        Dim paths As String = ""
        For Each path As String In lbVariables.Items
            paths += path & ";"
        Next
        Environment.SetEnvironmentVariable(envVar, paths, envTgt)
    End Sub

    Private Sub window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadVariables()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Cursor = Cursors.WaitCursor
        saveVariables()
        Cursor = Cursors.Default
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim value As String = InputBox("Enter value", "Variable Editor")
        If Not String.IsNullOrWhiteSpace(value) Then
            lbVariables.Items.Add(value)
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim index As Integer = lbVariables.SelectedIndex
        If Not IsNothing(index) Then
            Dim value As String = InputBox("Enter value", "Variable Editor", lbVariables.Items.Item(index))
            If Not String.IsNullOrWhiteSpace(value) Then
                lbVariables.Items.Item(index) = value
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim index As Integer = lbVariables.SelectedIndex
        If Not IsNothing(index) Then
            lbVariables.Items.RemoveAt(index)
        End If
    End Sub

    Private Sub lbVariables_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbVariables.DoubleClick
        If Not IsNothing(lbVariables.SelectedItem) Then
            MessageBox.Show(lbVariables.SelectedItem, "Path")
        End If
    End Sub

    Private Sub btnMvUp_Click(sender As Object, e As EventArgs) Handles btnMvUp.Click
        If Not IsNothing(lbVariables.SelectedItem) Then

            If lbVariables.SelectedIndex <> 0 Then
                Dim cur As Integer = lbVariables.SelectedIndex
                Dim nxt As Integer = cur - 1

                Dim temp As String = lbVariables.Items.Item(nxt)
                lbVariables.Items.Item(nxt) = lbVariables.Items.Item(cur)
                lbVariables.Items.Item(cur) = temp

                lbVariables.SelectedIndex = nxt
            End If
        End If
    End Sub

    Private Sub btnMvDown_Click(sender As Object, e As EventArgs) Handles btnMvDown.Click
        If Not IsNothing(lbVariables.SelectedItem) Then

            If lbVariables.SelectedIndex < lbVariables.Items.Count - 1 Then
                Dim cur As Integer = lbVariables.SelectedIndex
                Dim nxt As Integer = cur + 1

                Dim temp As String = lbVariables.Items.Item(nxt)
                lbVariables.Items.Item(nxt) = lbVariables.Items.Item(cur)
                lbVariables.Items.Item(cur) = temp

                lbVariables.SelectedIndex = nxt
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If Not IsNothing(lbVariables.SelectedItem) Then
            Process.Start(lbVariables.SelectedItem)
        End If
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Dim op As New options(Me)
        op.Show()
        op.Focus()
    End Sub
End Class
