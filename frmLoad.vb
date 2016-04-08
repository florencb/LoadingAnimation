Public Class frmMain

    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick

        'The Increment method advances the position of the progress bar by the specified amount
        prgLoading.Increment(3)
        'If the position of the progress bar reaches the upper limit of the range of the progress bar,
        'the timer stops working
        'the form closes
        If prgLoading.Value >= prgLoading.Maximum Then
            tmrLoading.Stop()
            Me.Close()
        End If

    End Sub
End Class
