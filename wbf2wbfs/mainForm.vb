Public Class frmMain

    Private i As Integer
    Private fill(498) As Byte

    Private Sub wbf2wbfs(ByVal strfn As String, ByVal fn As Integer)
        Dim filehead(0 To 3) As Byte
        Dim fLen(0 To 3) As Byte
        Dim dLen As Double
        Dim FSO As Object

        If Dir(strfn) = "" Then
            lstvConv.Items(fn).SubItems(1).Text = "File not exists"
            Exit Sub
        End If

        Try
            FileSystem.FileOpen(1, strfn, OpenMode.Binary)
            FileSystem.FileGet(1, filehead)
            FileSystem.FileClose(1)

            If filehead(0) <> 87 Or filehead(1) <> 66 Or filehead(2) <> 70 Or filehead(3) <> 83 Then
                lstvConv.Items(fn).SubItems(1).Text = "Not WBFS file"
                Exit Sub
            End If

            FSO = CreateObject("Scripting.FileSystemObject")
            dLen = FSO.GetFile(strfn).Size
            FSO = Nothing

            dLen = dLen / 512
            fLen(3) = dLen Mod 256
            fLen(2) = (dLen \ 256) Mod 256
            fLen(1) = (dLen \ 65536) Mod 256
            fLen(0) = dLen \ 16777216

            FileSystem.FileOpen(1, strfn, OpenMode.Binary)
            FileSystem.Seek(1, 5)
            FileSystem.FilePut(1, fLen)
            FileSystem.Seek(1, 14)
            FileSystem.FilePut(1, fill)
            FileSystem.FileClose(1)

            FileSystem.Rename(strfn, strfn & "s")
            lstvConv.Items(fn).SubItems(1).Text = "Success"
        Catch IOExcep As IO.IOException
            lstvConv.Items(fn).SubItems(1).Text = IOExcep.Message
            FileSystem.FileClose(1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim j As Integer

        For j = 0 To 498
            fill(j) = 0
        Next

        lstvConv.Top = 5

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim j As Integer

        On Error GoTo Err

        cdlOpen.Multiselect = True
        cdlOpen.Filter = "wbf file(*.wbf)|*.wbf"
        cdlOpen.ShowDialog()

        If cdlOpen.FileName <> "" Then
            For j = 0 To UBound(cdlOpen.FileNames)
                lstvConv.Items.Add(cdlOpen.SafeFileNames(j))
                lstvConv.Items(i).SubItems.Add("Waiting for converting")
                lstvConv.Items(i).Tag = cdlOpen.FileNames(j)
                i = i + 1
            Next

            cdlOpen.FileName = ""

        End If
Err:
        Exit Sub

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim j As Integer

        If lstvConv.Items.Count <> 0 Then
            Do While j <= lstvConv.Items.Count - 1
                If lstvConv.Items(j).Selected Then
                    lstvConv.Items.Remove(lstvConv.Items(j))
                    i = i - 1
                Else
                    j = j + 1
                End If
            Loop
        End If

    End Sub

    Private Sub cmdClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClr.Click
        lstvConv.Items.Clear()
        i = 0
    End Sub

    Private Sub cmdConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConv.Click
        Dim j As Integer

        For j = 0 To lstvConv.Items.Count - 1
            wbf2wbfs(lstvConv.Items(j).Tag, j)
        Next

        MsgBox("All files converted", MsgBoxStyle.Information, "wbf to wbfs")

    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Width >= 25 Then
            lstvConv.Width = Me.Width - 25
        End If
        If Me.Width >= 200 Then
            cmdConv.Width = Me.Width - 200
        End If
        If Me.Height >= 75 Then
            lstvConv.Top = 5
            lstvConv.Height = Me.Height - 75
        Else
            lstvConv.Top = Me.Height - 75
        End If
        cmdAdd.Top = Me.Height - 64
        cmdDel.Top = Me.Height - 64
        cmdClr.Top = Me.Height - 64
        cmdConv.Top = Me.Height - 64
    End Sub

End Class
