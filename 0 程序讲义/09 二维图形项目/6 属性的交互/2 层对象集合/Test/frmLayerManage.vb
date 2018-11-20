Public Class frmLayerManage
    Public layers As clsLayers

    Private Sub frmLayerManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With lstLayer.Items
            .Clear()
            For i = 0 To layers.Count - 1
                .Add(layers.Item(i).ToString)
            Next
        End With
        For i = 0 To layers.Count - 1
            If layers.Item(i) Is layers.Active Then
                lstLayer.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub btnSetActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetActive.Click
        If lstLayer.SelectedIndex = -1 Then Exit Sub
        layers.Active = layers.Item(lstLayer.SelectedIndex)
    End Sub

    Private Sub btnAppend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppend.Click
        Dim layer As clsLayer = New clsLayer(txtLayerName.Text, New Pen(btnColor.BackColor))
        layers.Append(layer)
        lstLayer.Items.Add(layer.ToString)
    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        Dim dlg As New ColorDialog
        If dlg.ShowDialog = vbOK Then
            btnColor.BackColor = dlg.Color
        End If
    End Sub
End Class