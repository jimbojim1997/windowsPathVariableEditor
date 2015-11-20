Public Class window
    Private Sub window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paths As String = Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.User)
        For Each path As String In paths.Split(";")
            If Not String.IsNullOrWhiteSpace(path) Then
                lbVariables.Items.Add(path)
            End If
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim paths As String = ""
        For Each path As String In lbVariables.Items
            paths += path & ";"
        Next
        Environment.SetEnvironmentVariable("path", paths, EnvironmentVariableTarget.User)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim value As String = InputBox("Enter value", "Enter Value")
        If Not String.IsNullOrWhiteSpace(value) Then
            lbVariables.Items.Add(value)
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim index As Integer = lbVariables.SelectedIndex
        If Not IsNothing(index) Then
            Dim value As String = InputBox("Enter value", "Enter Value", lbVariables.Items.Item(index))
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
End Class
