
Public Class frmTest

    Dim Lights As clsLights

    Private Sub btnXML_Click(sender As System.Object, e As System.EventArgs) Handles btnLights.Click
        Lights = New clsLights(My.Resources.ConfigLight)
        lstLight.Items.Clear()
        For i = 0 To Lights.Lights.Count - 1
            lstLight.Items.Add(Lights.Lights(i).Name)
        Next
    End Sub

    Private Sub lstLight_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstLight.SelectedIndexChanged
        If lstLight.SelectedIndex = -1 Then Exit Sub
        Dim Light As clsLight = Lights.Lights(lstLight.SelectedIndex)
        With lstLightPara.Items
            .Clear()
            .Add("Name" & vbTab & Light.Name)
            .Add("Position" & vbTab & Light.Position)
            .Add("Ambient" & vbTab & Light.Ambient)
            .Add("Diffuse" & vbTab & Light.Diffuse)
            .Add("Specular" & vbTab & Light.Specular)
        End With


    End Sub
End Class
