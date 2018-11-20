' 项目->添加引用→COM→Microsoft Excel *.* Object Library
Imports Microsoft.Office.Interop

Public Class clsStlModel
    Public Tris As List(Of clsTriangle)

    Public Sub New(XlsName As String, SheetName As String)
        Dim xlApp As Excel.Application
        xlApp = New Excel.Application ' 执行Excel
        xlApp.Visible = False
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Open(Environment.CurrentDirectory & "\" & XlsName) '打开文件
        Dim xlSheet As Excel.Worksheet = xlBook.Sheets(SheetName)
        CreateModel(xlSheet)
        xlSheet = Nothing
        xlBook.Close() : xlBook = Nothing
        xlApp.Quit() : xlApp = Nothing   ' 退出Excel
    End Sub

    Private Sub CreateModel(xlSheet As Excel.Worksheet)
        Tris = New List(Of clsTriangle)
        Dim p(2) As clsPoint3
        Dim RowNum As Integer = xlSheet.UsedRange.Rows.Count
        Dim x, y, z As String
        With xlSheet
            For I = 1 To RowNum Step 3
                x = .Cells(I + 0, 1).text : y = .Cells(I + 0, 2).text : z = .Cells(I + 0, 3).text : p(0) = New clsPoint3(x, y, z)
                x = .Cells(I + 1, 1).text : y = .Cells(I + 1, 2).text : z = .Cells(I + 1, 3).text : p(1) = New clsPoint3(x, y, z)
                x = .Cells(I + 2, 1).text : y = .Cells(I + 2, 2).text : z = .Cells(I + 2, 3).text : p(2) = New clsPoint3(x, y, z)
                Tris.Add(New clsTriangle(p))
            Next
        End With
        
    End Sub

    Sub Display(lstTri As ListBox)
        With lstTri.Items
            .Clear()
            For i = 0 To Tris.Count - 1
                .Add(Tris(i).ToString)
            Next
        End With


    End Sub

End Class
