Public Class frmOption
    Private Sub frmOption_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oldHard = frmTest.hard
        If oldHard = 0 Then
            rdoEasy.Checked = True
        ElseIf oldHard = 1 Then
            rdoMedium.Checked = True
        ElseIf oldHard = 2 Then
            rdoHard.Checked = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If rdoEasy.Checked = True Then
            frmTest.hard = 0
        ElseIf rdoMedium.Checked Then
            frmTest.hard = 1
        ElseIf rdoHard.Checked Then
            frmTest.hard = 2
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class