Imports OpenTK

Public Structure Arrangement
    Public Flag As Boolean
    Public Location As Vector3  '基点位置（左下角：xmin,ymin,zmin)
End Structure

Public Class Remainment  '若干可选的空间集合，在某次分配过程中的剩余量
    Public index As Integer   ' 原空间的序号
    Public delta As Vector3   ' 原空间xyz-需求空间的xyz

    Public Sub New(index As Integer, delta As Vector3)
        Me.index = index : Me.delta = delta
    End Sub
End Class

Enum ArrangeMethod       '空间分配策略
    ' 将Remainment.delta作为剩余空间体积（其实是右上前角的体积）
    RemainVolumeLess     ' 剩余空间体积最小
    RemainVolumeMax      ' 剩余空间体积最大
End Enum

Public Class clsSpaces
    Private Spaces As List(Of clsBox)
    Shared Method As ArrangeMethod = ArrangeMethod.RemainVolumeLess

    Public Sub New(box As clsBox)
        Spaces = New List(Of clsBox)
        Spaces.Add(box)
    End Sub

    Public Function Arrange(demand As clsBox) As Arrangement
        Dim result As Arrangement
        '在Boxes中寻找与demand最合适的Boxes(index)
        Dim index As Integer = FindSuitableSpace(demand)
        If index = -1 Then
            result.Flag = False
            Return result   'Spaces中所有的空间，都没有合适demand的位置
        End If
        ' 调整Spaces: 添加3个新的子空间
        '1 将Spaces(index)分解3个新的子空间，添加之
        Dim box0 As clsBox = Spaces(index)
        Spaces.Add(New clsBox(box0.BaseX, box0.Wx - demand.Wx, box0.Wy, box0.Wz))
        Spaces.Add(New clsBox(box0.BaseY, box0.Wx, box0.Wy - demand.Wy, box0.Wz))
        Spaces.Add(New clsBox(box0.BaseZ, box0.Wx, box0.Wy, box0.Wz - demand.Wz))
        '2 分配Spaces(index)给demand
        result.Flag = True : result.Location = Spaces(index).Base
        '3 调整Spaces: 删除Spaces(index)
        Spaces.RemoveAt(index)
        Return result
    End Function

    ' 为demand找一个最合适的Spaces(index)。返回值为-1表示无法放置demand
    Private Function FindSuitableSpace(demand As clsBox) As Integer
        ' 尝试在各个空间中摆放demand，得到的剩余空间特征表
        Dim Remainments As New List(Of Remainment)
        For i = 0 To Spaces.Count - 1
            Dim delta As Vector3 = Spaces(i).Subtract(demand)
            If delta.X < 0 Or delta.Y < 0 Or delta.Y < 0 Then Continue For
            Remainments.Add(New Remainment(i, delta))
        Next
        If Remainments.Count = 0 Then Return -1 '无法放置demand
        ' 在剩余空间特征表Remainments中，寻找最合适的空间
        ' 最优化指标： 剩余空间体积最小
        Dim ibest As Integer = 0
        For i = 1 To Remainments.Count - 1
            If Better(Remainments(i).delta, Remainments(ibest).delta) = True Then
                ibest = Remainments(i).index
            End If
        Next
        Return ibest      '最佳放置位置
    End Function

    Private Function Better(delta1 As Vector3, delta2 As Vector3) As Boolean
        Dim v1 As Single = delta1.X * delta1.Y * delta1.Z
        Dim v2 As Single = delta2.X * delta2.Y * delta2.Z
        If Method = ArrangeMethod.RemainVolumeLess Then
            Return v1 < v2
        End If
        If Method = ArrangeMethod.RemainVolumeMax Then
            Return v1 > v2
        End If
        Return False  '代码至此，已经出错
    End Function

End Class
