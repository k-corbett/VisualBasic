Public Class Form1
    'Declare a variable to hold the favorite color + the person's name
    Dim favColor As String = "Purple"
    Dim personName As String = "Katie"

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radKatie_CheckedChanged(sender As Object, e As EventArgs) Handles radKatie.CheckedChanged
        If Not personName = "Katie" Then
            personName = "Katie"
        End If
        If Not favColor = "Purple" Then
            favColor = "Purple"
        End If
    End Sub

    Private Sub radJohn_CheckedChanged(sender As Object, e As EventArgs) Handles radJohn.CheckedChanged
        If Not personName = "John" Then
            personName = "John"
        End If
        If Not favColor = "Blue" Then
            favColor = "Blue"
        End If
    End Sub

    Private Sub radMark_CheckedChanged(sender As Object, e As EventArgs) Handles radMark.CheckedChanged
        If Not personName = "Mark" Then
            personName = "Mark"
        End If
        If Not favColor = "Green" Then
            favColor = "Green"
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lblColor.Text = favColor
        lblName.Text = personName
    End Sub
End Class
