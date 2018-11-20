' 项目->添加引用→COM→Microsoft Word *.* Object Library
Imports Microsoft.Office.Interop

Public Class clsDocument
    Public Paragraphs As List(Of String)  '段落的集合

    Public Sub New(DocFname As String)
        Dim docApp As Word.Application
        docApp = New Word.Application
        docApp.Visible = False
        Dim docDocument As Word.Document = docApp.Documents.Open(Environment.CurrentDirectory & "\" & DocFname)
        Paragraphs = New List(Of String)
        For i = 1 To docDocument.Paragraphs.Count - 1
            Paragraphs.Add(docDocument.Paragraphs(i).Range.Text)
        Next
        docDocument.Close()
        docApp.Quit()
    End Sub

    Sub Display(lstTri As ListBox)
        With lstTri.Items
            .Clear()
            For i = 0 To Paragraphs.Count - 1
                .Add(Paragraphs(i))
            Next
        End With


    End Sub

End Class
