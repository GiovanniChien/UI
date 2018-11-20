Public Class frmParent

    Dim Count As Integer = 0

    Private Sub frmParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
        CreateChild()
    End Sub
    Sub CreateChild()
        Count += 1
        Dim NewChild As Form = New frmChild
        NewChild.MdiParent = Me
        NewChild.Text = "子窗体" & Count
        NewChild.Show()
    End Sub

    Private Sub Arrange_Click(sender As Object, e As EventArgs) Handles m_ArrangeIcons.Click, m_Cascade.Click, m_TileHorizontal.Click, m_TileVertical.Click
        If sender Is m_ArrangeIcons Then Me.LayoutMdi(MdiLayout.ArrangeIcons)
        If sender Is m_Cascade Then Me.LayoutMdi(MdiLayout.Cascade)
        If sender Is m_TileHorizontal Then Me.LayoutMdi(MdiLayout.TileHorizontal)
        If sender Is m_TileVertical Then Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CloseAll_Click(sender As Object, e As EventArgs) Handles m_CloseAll.Click
        For i = Me.MdiChildren.Length - 1 To 0 Step -1
            Me.MdiChildren(i).Close()
        Next
        Count = 0
    End Sub

End Class
