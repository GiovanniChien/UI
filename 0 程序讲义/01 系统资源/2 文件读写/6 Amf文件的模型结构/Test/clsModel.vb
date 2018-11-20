Imports System.Xml

Public Class clsModel
    Private doc As XmlDocument, amf As XmlElement

    Private Objects As clsObjects
    Private Constellations As clsConstellations
    Private Materials As clsMaterials

    Public Sub New(ByVal fname As String)
        doc = New XmlDocument : doc.Load(fname)
        amf = doc.SelectSingleNode("amf")
        '创建模型对象的层次结构时，约定：
        '  创建集合对象时，参数是XmlNodeList
        '  创建单个对象时，参数是XmlNode
        Objects = New clsObjects(amf.GetElementsByTagName("object"))
        Constellations = New clsConstellations(amf.GetElementsByTagName("constellation"))
        Materials = New clsMaterials(amf.GetElementsByTagName("material"))
    End Sub

    Public Sub Save(ByVal fname As String)
        doc.Save(fname)
    End Sub


End Class
