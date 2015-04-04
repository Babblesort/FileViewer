Imports System.IO

Public Class frmViewer

    Const DEFAULT_COLS = 30
    Const DEFAULT_ROWS = 20
    Dim bSizing As Boolean = False

    Const FIELD_DEF_FILE As String = "TeleTagFieldDef.txt"
    Const FIELD_NAME_COL = 0
    Const FIELD_START_COL = 1
    Const FIELD_END_COL = 2

    Dim nHighlightStart As Integer = -1
    Dim nHighlightEnd As Integer = -1

    Dim streamIn As StreamReader
    Dim recs As New ArrayList
    Dim nRecordCurr As Integer

    Dim gridBackgroundColor As Color = SystemColors.Control
    Dim gridLineColor As Color = Color.DarkGray
    Dim gridCountColor As Color = Color.DarkGray
    Dim recordTextColor As Color = Color.DarkBlue
    Dim highlightColor As Color = Color.Red

    Dim countFont As New Font("Calibri", 8, FontStyle.Regular)
    Dim charFont As New Font("Verdana", 14, FontStyle.Regular)

    Private Sub pnlGrid_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlGrid.MouseClick

        Dim nRowHit As Integer
        Dim nColHit As Integer
        Dim nHitCell As Integer

        nRowHit = Math.Ceiling(e.Y / CellHeightCurr())
        nColHit = Math.Ceiling(e.X / CellWidthCurr())

        nHitCell = ((nRowHit - 1) * numCols.Value) + nColHit
        FindFieldWithCell(nHitCell)

    End Sub

    Private Sub FindFieldWithCell(ByVal nCell As Integer)

        Dim i As Integer
        Dim bFound As Boolean = False

        bSizing = True
        For i = 0 To dgvFieldDefs.RowCount - 1

            If nCell >= dgvFieldDefs.Item(FIELD_START_COL, i).Value And nCell <= dgvFieldDefs.Item(FIELD_END_COL, i).Value Then
                dgvFieldDefs.CurrentCell = dgvFieldDefs.Rows(i).Cells(FIELD_NAME_COL)
                HighlightCells(dgvFieldDefs.CurrentRow.Cells(FIELD_START_COL).Value, dgvFieldDefs.CurrentRow.Cells(FIELD_END_COL).Value)
                bFound = True
                Exit For
            End If
        Next
        bSizing = False
        If bFound Then
            RefreshGrid()
        End If

    End Sub

    Private Function CellWidthCurr() As Integer
        Return Math.Floor((pnlGrid.Width - 3) / numCols.Value)
    End Function

    Private Function CellHeightCurr() As Integer
        Return Math.Floor((pnlGrid.Height - 3) / numRows.Value)
    End Function

    Private Sub pnlGrid_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlGrid.Paint

        Dim i As Integer
        Dim j As Integer
        Dim count As Integer

        Dim bShowIndexes As Boolean = True

        Dim highlightPen As Pen = New Pen(highlightColor)
        Dim highlightBrush As Brush = New SolidBrush(Color.FromArgb(15, highlightColor))
        Dim gridPen As Pen = New Pen(gridLineColor)
        Dim gridCountBrush As SolidBrush = New SolidBrush(gridCountColor)
        Dim recordTextBrush As SolidBrush = New SolidBrush(recordTextColor)

        Dim graphicsHandle As Graphics
        graphicsHandle = e.Graphics

        Dim nColWidth As Integer
        Dim nRowHeight As Integer

        Dim nColsCurr As Integer = numCols.Value
        Dim nRowsCurr As Integer = numRows.Value

        Dim nCellIndexHeight As Integer
        Dim nCellIndexOffset As Integer
        Dim cellIndexRectangle As System.Drawing.RectangleF

        pnlGrid.BackColor = gridBackgroundColor

        If Not bSizing Then

            ' Determine current dimensions for a cell
            nColWidth = CellWidthCurr()
            nRowHeight = CellHeightCurr()

            ' Draw vertical grid lines
            For i = 0 To nColsCurr
                graphicsHandle.DrawLine(gridPen, i * nColWidth, 0, i * nColWidth, nRowsCurr * nRowHeight)
            Next

            ' Draw horizontal grid lines
            For i = 0 To nRowsCurr
                graphicsHandle.DrawLine(gridPen, 0, i * nRowHeight, nColsCurr * nColWidth, i * nRowHeight)
            Next

            ' Adjust the record character font to best fit the current size of a grid cell
            charFont = New Font("Verdana", FittedFontSize(graphicsHandle, charFont, nRowHeight), FontStyle.Regular)

            ' At very small grid sizes drop the cell indexes from display
            bShowIndexes = charFont.SizeInPoints >= 8 And chkShowIndex.Checked

            count = 1
            For j = 0 To nRowsCurr - 1
                For i = 0 To nColsCurr - 1

                    ' Add highlight box around cell if current cell is within highlight cell numbers range
                    If count >= nHighlightStart And count <= nHighlightEnd Then
                        graphicsHandle.FillRectangle(highlightBrush, New Rectangle(i * nColWidth, j * nRowHeight, nColWidth, nRowHeight))
                        graphicsHandle.DrawRectangle(highlightPen, New Rectangle(i * nColWidth, j * nRowHeight, nColWidth, nRowHeight))
                    End If

                    ' Add cell index number to bottom left corner
                    If bShowIndexes Then

                        nCellIndexHeight = graphicsHandle.MeasureString(count, countFont).Height
                        If nRowHeight - nCellIndexHeight > 0 Then
                            nCellIndexOffset = nRowHeight - nCellIndexHeight
                        Else
                            nCellIndexOffset = 0
                        End If

                        ' Index digits will be chopped off if they don't fit within bounds of the rectangle to prevent index text from spilling over into
                        ' adjacent cells at very small grid sizes
                        cellIndexRectangle = New RectangleF(i * nColWidth, ((j * nRowHeight) + nCellIndexOffset), nColWidth, nCellIndexHeight)
                        graphicsHandle.DrawString(count, countFont, gridCountBrush, cellIndexRectangle)
                    End If

                    ' Add record text for this cell if a record is currently loaded
                    If nRecordCurr >= 0 Then
                        graphicsHandle.DrawString(Mid(recs.Item(nRecordCurr), count, 1), charFont, recordTextBrush, (i * nColWidth), (j * nRowHeight))
                    End If
                    count = count + 1
                Next
            Next

        End If

    End Sub

    Private Function FittedFontSize(ByRef gCurrent As Graphics, ByRef fontCurrent As Font, ByVal nAvailableHeight As Integer) As Integer

        Dim nCharacterHeight As Integer
        Dim dSpaceRatio As Double

        nCharacterHeight = gCurrent.MeasureString("A", fontCurrent).Height
        dSpaceRatio = nAvailableHeight / nCharacterHeight

        Return (fontCurrent.Size * dSpaceRatio)

    End Function

    Private Sub frmViewer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        SaveUserSettings()
    End Sub

    Private Sub frmViewer_ResizeBegin(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeBegin
        bSizing = True
    End Sub

    Private Sub frmViewer_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        bSizing = False
        pnlGrid.Refresh()
    End Sub

    Private Sub frmViewer_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        pnlGrid.Refresh()
    End Sub

    Private Sub SaveUserSettings()
        Try
            My.Settings.UserGridBackColor = gridBackgroundColor
            My.Settings.UserGridHighlightColor = highlightColor
            My.Settings.UserGridLineColor = gridLineColor
            My.Settings.UserGridNumberColor = gridCountColor
            My.Settings.UserRecordTextColor = recordTextColor
            My.Settings.UserRowCount = numRows.Value
            My.Settings.UserColCount = numCols.Value
            My.Settings.UserShowCellNumbers = chkShowIndex.Checked
            My.Settings.Save()
        Catch ex As Exception
            MsgBox("Errors prevent save of user preferences: " & ex.Message, MsgBoxStyle.Exclamation, "User Prefs Error")
        End Try
    End Sub

    Private Sub LoadUserSettings()

        Try
            gridBackgroundColor = My.Settings.UserGridBackColor()
            gridLineColor = My.Settings.UserGridLineColor()
            gridCountColor = My.Settings.UserGridNumberColor()
            highlightColor = My.Settings.UserGridHighlightColor()
            recordTextColor = My.Settings.UserRecordTextColor()
            numRows.Value = My.Settings.UserRowCount()
            numCols.Value = My.Settings.UserColCount()
            chkShowIndex.Checked = My.Settings.UserShowCellNumbers()
        Catch ex As Exception
            SetDefaultColors()
            numCols.Value = DEFAULT_COLS
            numRows.Value = DEFAULT_ROWS
            chkShowIndex.Checked = True
        End Try

    End Sub

    Private Sub frmViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblRecordCurr.Text = ""
        lblRecordTotal.Text = ""
        nRecordCurr = -1
        numRecordChoice.Minimum = -1
        numRecordChoice.Maximum = -1

        LoadUserSettings()

        ' Load default field def file
        LoadFieldDefs(FIELD_DEF_FILE)

    End Sub

    Private Sub numCols_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles numCols.GotFocus
        numCols.Select(0, Len(numCols.Value))
    End Sub

    Private Sub numRows_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles numRows.GotFocus
        numRows.Select(0, Len(numRows.Value))
    End Sub

    Private Sub numericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCols.ValueChanged, numRows.ValueChanged
        pnlGrid.Refresh()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click

        If recs.Count > 0 Then
            nRecordCurr = 0
            RefreshGrid()
        End If

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        If recs.Count > 0 Then
            nRecordCurr = recs.Count - 1
            RefreshGrid()
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        If nRecordCurr + 1 < recs.Count Then
            nRecordCurr = nRecordCurr + 1
            RefreshGrid()
        End If

    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        If (recs.Count > 0) And (nRecordCurr - 1 >= 0) Then
            nRecordCurr = nRecordCurr - 1
            RefreshGrid()
        End If

    End Sub

    Private Sub RefreshGrid()
        If nRecordCurr >= 0 Then
            lblRecordCurr.Text = Format(nRecordCurr + 1, "###,###,###")
            numRecordChoice.Value = nRecordCurr + 1
        Else
            lblRecordCurr.Text = "n/a"
        End If

        If recs.Count > 0 Then
            lblRecordTotal.Text = Format(recs.Count, "###,###,###")
        Else
            lblRecordTotal.Text = "n/a"
        End If

        pnlGrid.Refresh()


    End Sub

    Private Sub LoadVestcomFile(ByVal sFile As String)

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim sLineCurr As String
            Dim reader As New System.IO.StreamReader(sFile)

            While reader.Peek() >= 0
                sLineCurr = reader.ReadLine()
                If Not String.IsNullOrEmpty(sLineCurr) Then
                    recs.Add(sLineCurr)
                End If
            End While

            reader.Close()
            reader.Dispose()

            If recs.Count > 0 Then
                numRecordChoice.Enabled = True
                btnJumpTo.Enabled = True
                nRecordCurr = 0
                numRecordChoice.Minimum = 1
                numRecordChoice.Maximum = recs.Count
            Else
                numRecordChoice.Enabled = False
                btnJumpTo.Enabled = False
                nRecordCurr = -1
            End If

            RefreshGrid()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error while loading Vestcom tag file: " & ex.Message)

        End Try

    End Sub

    Private Sub LoadFieldDefs(ByVal sDefFile As String)

        ' Field definition file formatted as follows
        ' Field Name <tab> Start Col # <tab> End Col #

        Dim sFieldDefCurr As String
        Try
            Me.Cursor = Cursors.WaitCursor
            streamIn = New StreamReader(sDefFile)

            dgvFieldDefs.Rows.Clear()
            While Not streamIn.EndOfStream()
                sFieldDefCurr = streamIn.ReadLine()
                ' Line read from file needs three items split by tabs
                dgvFieldDefs.Rows.Add(sFieldDefCurr.Split(Chr(Keys.Tab)))
            End While
            streamIn.Close()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Unable to read field defintion file [ " & sDefFile & "].    " & ex.Message)
        End Try

    End Sub

    Private Sub HighlightCells(ByVal nCell1 As Integer, ByVal nCell2 As Integer)

        nHighlightStart = nCell1
        nHighlightEnd = nCell2
        RefreshGrid()

    End Sub

    Private Sub dgvFieldDefs_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFieldDefs.SelectionChanged
        HighlightCells(dgvFieldDefs.CurrentRow.Cells(1).Value, dgvFieldDefs.CurrentRow.Cells(2).Value)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ExitApplication()
    End Sub

    Private Sub btnJumpTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJumpTo.Click
        JumpToRecord()
    End Sub

    Private Sub numRecordChoice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numRecordChoice.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            JumpToRecord()
        End If
    End Sub

    Private Sub JumpToRecord()
        nRecordCurr = numRecordChoice.Value - 1
        RefreshGrid()
    End Sub

    Private Sub GridLineColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLineColorToolStripMenuItem.Click

        Dim result As DialogResult
        result = colDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            gridLineColor = colDialog.Color
            RefreshGrid()
        End If

    End Sub

    Private Sub GridNumberColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridNumberColorToolStripMenuItem.Click

        Dim result As DialogResult
        result = colDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            gridCountColor = colDialog.Color
            RefreshGrid()
        End If

    End Sub

    Private Sub RecordTextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordTextColorToolStripMenuItem.Click

        Dim result As DialogResult
        result = colDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            recordTextColor = colDialog.Color
            RefreshGrid()
        End If

    End Sub

    Private Sub HighlightColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HighlightColorToolStripMenuItem.Click

        Dim result As DialogResult
        result = colDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            highlightColor = colDialog.Color
            RefreshGrid()
        End If

    End Sub

    Private Sub LoadDefinitionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadDefinitionsToolStripMenuItem.Click

        filDialog.FileName = ""
        filDialog.Filter = "All Files (*.*)|*.*"
        filDialog.ShowDialog()

        If Not String.IsNullOrEmpty(filDialog.FileName) Then
            LoadFieldDefs(filDialog.FileName)
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        filDialog.FileName = ""
        filDialog.Filter = "Schnuck Vestcom Files (*.sch)|*.sch|Text Files (*.txt)|*.txt"
        filDialog.ShowDialog()

        If Not String.IsNullOrEmpty(filDialog.FileName) Then
            LoadVestcomFile(filDialog.FileName)
        End If

    End Sub

    Private Sub chkShowIndex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowIndex.CheckedChanged
        RefreshGrid()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim result As DialogResult
        result = colDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            gridBackgroundColor = colDialog.Color
            RefreshGrid()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitApplication()
    End Sub

    Private Sub ExitApplication()
        Application.Exit()
    End Sub

    Private Sub ResetToDefaultColorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToDefaultColorsToolStripMenuItem.Click
        SetDefaultColors()
    End Sub

    Private Sub SetDefaultColors()
        gridBackgroundColor = SystemColors.Control
        gridLineColor = Color.DarkGray
        gridCountColor = Color.DarkGray
        recordTextColor = Color.DarkBlue
        highlightColor = Color.Red
        RefreshGrid()
    End Sub

End Class
