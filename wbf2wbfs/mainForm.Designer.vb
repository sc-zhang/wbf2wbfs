<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstvConv = New System.Windows.Forms.ListView()
        Me.cohFilename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cohStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdClr = New System.Windows.Forms.Button()
        Me.cmdConv = New System.Windows.Forms.Button()
        Me.cdlOpen = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lstvConv
        '
        Me.lstvConv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cohFilename, Me.cohStatus})
        Me.lstvConv.FullRowSelect = True
        Me.lstvConv.GridLines = True
        Me.lstvConv.Location = New System.Drawing.Point(4, 3)
        Me.lstvConv.Name = "lstvConv"
        Me.lstvConv.Size = New System.Drawing.Size(332, 257)
        Me.lstvConv.TabIndex = 0
        Me.lstvConv.UseCompatibleStateImageBehavior = False
        Me.lstvConv.View = System.Windows.Forms.View.Details
        '
        'cohFilename
        '
        Me.cohFilename.Text = "File"
        Me.cohFilename.Width = 117
        '
        'cohStatus
        '
        Me.cohStatus.Text = "Status"
        Me.cohStatus.Width = 203
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(4, 266)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(53, 23)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        Me.cmdDel.Location = New System.Drawing.Point(63, 266)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(53, 23)
        Me.cmdDel.TabIndex = 2
        Me.cmdDel.Text = "Delete"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdClr
        '
        Me.cmdClr.Location = New System.Drawing.Point(122, 266)
        Me.cmdClr.Name = "cmdClr"
        Me.cmdClr.Size = New System.Drawing.Size(53, 23)
        Me.cmdClr.TabIndex = 3
        Me.cmdClr.Text = "Clear"
        Me.cmdClr.UseVisualStyleBackColor = True
        '
        'cmdConv
        '
        Me.cmdConv.Location = New System.Drawing.Point(180, 266)
        Me.cmdConv.Name = "cmdConv"
        Me.cmdConv.Size = New System.Drawing.Size(156, 23)
        Me.cmdConv.TabIndex = 4
        Me.cmdConv.Text = "*.wbf -> *.wbfs"
        Me.cmdConv.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 294)
        Me.Controls.Add(Me.cmdConv)
        Me.Controls.Add(Me.cmdClr)
        Me.Controls.Add(Me.cmdDel)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstvConv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wbf to wbfs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstvConv As System.Windows.Forms.ListView
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdClr As System.Windows.Forms.Button
    Friend WithEvents cmdConv As System.Windows.Forms.Button
    Friend WithEvents cdlOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cohFilename As System.Windows.Forms.ColumnHeader
    Friend WithEvents cohStatus As System.Windows.Forms.ColumnHeader

End Class
