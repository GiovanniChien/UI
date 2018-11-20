Imports System.Xml

Class clsVertex
    Public x, y, z As Single

    ' XNode: <coordinates> <x>0</x><y>1</y><z>0</z> </coordinates>
    Public Sub New(ByVal XNode As XmlNode)
        Dim xyz As XmlNodeList = XNode.ChildNodes(0).ChildNodes
        ' xyz: <x>0</x> <y>1</y> <z>0</z>
        For i = 0 To xyz.Count - 1
            If xyz(i).Name = "x" Then x = xyz(i).ChildNodes(0).Value
            If xyz(i).Name = "y" Then y = xyz(i).ChildNodes(0).Value
            If xyz(i).Name = "z" Then z = xyz(i).ChildNodes(0).Value
        Next
    End Sub
End Class
