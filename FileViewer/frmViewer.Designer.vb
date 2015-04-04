<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewer))
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.tblCore = New System.Windows.Forms.TableLayoutPanel
        Me.pnlGridControls = New System.Windows.Forms.Panel
        Me.dgvFieldDefs = New System.Windows.Forms.DataGridView
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStart = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEnd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlFormControls = New System.Windows.Forms.Panel
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.chkShowIndex = New System.Windows.Forms.CheckBox
        Me.numRows = New System.Windows.Forms.NumericUpDown
        Me.numCols = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlInstruments = New System.Windows.Forms.Panel
        Me.lblRecordTotal = New System.Windows.Forms.Label
        Me.lblRecordCurr = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnJumpTo = New System.Windows.Forms.Button
        Me.numRecordChoice = New System.Windows.Forms.NumericUpDown
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FieldDefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadDefinitionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GridLineColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GridNumberColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HighlightColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RecordTextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.filDialog = New System.Windows.Forms.OpenFileDialog
        Me.colDialog = New System.Windows.Forms.ColorDialog
        Me.ResetToDefaultColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tblCore.SuspendLayout()
        Me.pnlGridControls.SuspendLayout()
        CType(Me.dgvFieldDefs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFormControls.SuspendLayout()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInstruments.SuspendLayout()
        CType(Me.numRecordChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.SystemColors.Control
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(3, 63)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(669, 432)
        Me.pnlGrid.TabIndex = 0
        '
        'tblCore
        '
        Me.tblCore.ColumnCount = 2
        Me.tblCore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tblCore.Controls.Add(Me.pnlGrid, 0, 2)
        Me.tblCore.Controls.Add(Me.pnlGridControls, 1, 2)
        Me.tblCore.Controls.Add(Me.pnlFormControls, 0, 3)
        Me.tblCore.Controls.Add(Me.Label3, 1, 1)
        Me.tblCore.Controls.Add(Me.pnlInstruments, 0, 1)
        Me.tblCore.Controls.Add(Me.Panel1, 0, 0)
        Me.tblCore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblCore.Location = New System.Drawing.Point(0, 0)
        Me.tblCore.Name = "tblCore"
        Me.tblCore.RowCount = 4
        Me.tblCore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblCore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblCore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tblCore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblCore.Size = New System.Drawing.Size(875, 558)
        Me.tblCore.TabIndex = 1
        '
        'pnlGridControls
        '
        Me.pnlGridControls.Controls.Add(Me.dgvFieldDefs)
        Me.pnlGridControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridControls.Location = New System.Drawing.Point(678, 63)
        Me.pnlGridControls.Name = "pnlGridControls"
        Me.pnlGridControls.Size = New System.Drawing.Size(194, 432)
        Me.pnlGridControls.TabIndex = 1
        '
        'dgvFieldDefs
        '
        Me.dgvFieldDefs.AllowUserToAddRows = False
        Me.dgvFieldDefs.AllowUserToDeleteRows = False
        Me.dgvFieldDefs.AllowUserToResizeColumns = False
        Me.dgvFieldDefs.AllowUserToResizeRows = False
        Me.dgvFieldDefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFieldDefs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colStart, Me.colEnd})
        Me.dgvFieldDefs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFieldDefs.Location = New System.Drawing.Point(0, 0)
        Me.dgvFieldDefs.MultiSelect = False
        Me.dgvFieldDefs.Name = "dgvFieldDefs"
        Me.dgvFieldDefs.ReadOnly = True
        Me.dgvFieldDefs.RowHeadersVisible = False
        Me.dgvFieldDefs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.dgvFieldDefs.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFieldDefs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvFieldDefs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gold
        Me.dgvFieldDefs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFieldDefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFieldDefs.Size = New System.Drawing.Size(194, 432)
        Me.dgvFieldDefs.TabIndex = 9
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "Field"
        Me.colName.MinimumWidth = 40
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colStart
        '
        Me.colStart.HeaderText = "Start"
        Me.colStart.Name = "colStart"
        Me.colStart.ReadOnly = True
        Me.colStart.Width = 40
        '
        'colEnd
        '
        Me.colEnd.HeaderText = "End"
        Me.colEnd.MinimumWidth = 35
        Me.colEnd.Name = "colEnd"
        Me.colEnd.ReadOnly = True
        Me.colEnd.Width = 40
        '
        'pnlFormControls
        '
        Me.tblCore.SetColumnSpan(Me.pnlFormControls, 2)
        Me.pnlFormControls.Controls.Add(Me.btnNext)
        Me.pnlFormControls.Controls.Add(Me.btnLast)
        Me.pnlFormControls.Controls.Add(Me.btnPrev)
        Me.pnlFormControls.Controls.Add(Me.btnFirst)
        Me.pnlFormControls.Controls.Add(Me.btnExit)
        Me.pnlFormControls.Controls.Add(Me.chkShowIndex)
        Me.pnlFormControls.Controls.Add(Me.numRows)
        Me.pnlFormControls.Controls.Add(Me.numCols)
        Me.pnlFormControls.Controls.Add(Me.Label2)
        Me.pnlFormControls.Controls.Add(Me.Label1)
        Me.pnlFormControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormControls.Location = New System.Drawing.Point(3, 501)
        Me.pnlFormControls.Name = "pnlFormControls"
        Me.pnlFormControls.Size = New System.Drawing.Size(869, 54)
        Me.pnlFormControls.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(524, 7)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 40)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLast.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(609, 7)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(60, 40)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrev.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(458, 7)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(60, 40)
        Me.btnPrev.TabIndex = 18
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFirst.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(375, 7)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(60, 40)
        Me.btnFirst.TabIndex = 17
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(750, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 40)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkShowIndex
        '
        Me.chkShowIndex.AutoSize = True
        Me.chkShowIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowIndex.Location = New System.Drawing.Point(122, 7)
        Me.chkShowIndex.Name = "chkShowIndex"
        Me.chkShowIndex.Size = New System.Drawing.Size(100, 17)
        Me.chkShowIndex.TabIndex = 22
        Me.chkShowIndex.Text = "Cell Numbers"
        Me.chkShowIndex.UseVisualStyleBackColor = True
        '
        'numRows
        '
        Me.numRows.Location = New System.Drawing.Point(44, 29)
        Me.numRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRows.Name = "numRows"
        Me.numRows.Size = New System.Drawing.Size(63, 22)
        Me.numRows.TabIndex = 1
        Me.numRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numCols
        '
        Me.numCols.Location = New System.Drawing.Point(44, 4)
        Me.numCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCols.Name = "numCols"
        Me.numCols.Size = New System.Drawing.Size(63, 22)
        Me.numCols.TabIndex = 0
        Me.numCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ROWS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COLS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(678, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Field Definitions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlInstruments
        '
        Me.pnlInstruments.Controls.Add(Me.lblRecordTotal)
        Me.pnlInstruments.Controls.Add(Me.lblRecordCurr)
        Me.pnlInstruments.Controls.Add(Me.Label4)
        Me.pnlInstruments.Controls.Add(Me.Label5)
        Me.pnlInstruments.Controls.Add(Me.btnJumpTo)
        Me.pnlInstruments.Controls.Add(Me.numRecordChoice)
        Me.pnlInstruments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstruments.Location = New System.Drawing.Point(0, 30)
        Me.pnlInstruments.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlInstruments.Name = "pnlInstruments"
        Me.pnlInstruments.Size = New System.Drawing.Size(675, 30)
        Me.pnlInstruments.TabIndex = 5
        '
        'lblRecordTotal
        '
        Me.lblRecordTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecordTotal.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblRecordTotal.Location = New System.Drawing.Point(569, 4)
        Me.lblRecordTotal.Name = "lblRecordTotal"
        Me.lblRecordTotal.Size = New System.Drawing.Size(103, 22)
        Me.lblRecordTotal.TabIndex = 8
        Me.lblRecordTotal.Text = "999,999,999"
        Me.lblRecordTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecordCurr
        '
        Me.lblRecordCurr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCurr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecordCurr.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblRecordCurr.Location = New System.Drawing.Point(434, 4)
        Me.lblRecordCurr.Name = "lblRecordCurr"
        Me.lblRecordCurr.Size = New System.Drawing.Size(103, 22)
        Me.lblRecordCurr.TabIndex = 6
        Me.lblRecordCurr.Text = "999,999,999"
        Me.lblRecordCurr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(535, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Of"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Record"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnJumpTo
        '
        Me.btnJumpTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnJumpTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJumpTo.Location = New System.Drawing.Point(257, 2)
        Me.btnJumpTo.Name = "btnJumpTo"
        Me.btnJumpTo.Size = New System.Drawing.Size(90, 27)
        Me.btnJumpTo.TabIndex = 16
        Me.btnJumpTo.Text = "Jump To"
        Me.btnJumpTo.UseVisualStyleBackColor = True
        '
        'numRecordChoice
        '
        Me.numRecordChoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numRecordChoice.Location = New System.Drawing.Point(151, 4)
        Me.numRecordChoice.Name = "numRecordChoice"
        Me.numRecordChoice.Size = New System.Drawing.Size(100, 22)
        Me.numRecordChoice.TabIndex = 15
        Me.numRecordChoice.ThousandsSeparator = True
        '
        'Panel1
        '
        Me.tblCore.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(869, 24)
        Me.Panel1.TabIndex = 6
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FieldDefToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(875, 24)
        Me.mnuMain.TabIndex = 7
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open Tag File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FieldDefToolStripMenuItem
        '
        Me.FieldDefToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDefinitionsToolStripMenuItem})
        Me.FieldDefToolStripMenuItem.Name = "FieldDefToolStripMenuItem"
        Me.FieldDefToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FieldDefToolStripMenuItem.Text = "Field Def"
        '
        'LoadDefinitionsToolStripMenuItem
        '
        Me.LoadDefinitionsToolStripMenuItem.Name = "LoadDefinitionsToolStripMenuItem"
        Me.LoadDefinitionsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LoadDefinitionsToolStripMenuItem.Text = "Load Definitions"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GridLineColorToolStripMenuItem, Me.GridNumberColorToolStripMenuItem, Me.HighlightColorToolStripMenuItem, Me.RecordTextColorToolStripMenuItem, Me.ToolStripSeparator1, Me.ResetToDefaultColorsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ViewToolStripMenuItem.Text = "Preferences"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
        Me.ToolStripMenuItem1.Text = "Grid Background Color"
        '
        'GridLineColorToolStripMenuItem
        '
        Me.GridLineColorToolStripMenuItem.Name = "GridLineColorToolStripMenuItem"
        Me.GridLineColorToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.GridLineColorToolStripMenuItem.Text = "Grid Line Color"
        '
        'GridNumberColorToolStripMenuItem
        '
        Me.GridNumberColorToolStripMenuItem.Name = "GridNumberColorToolStripMenuItem"
        Me.GridNumberColorToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.GridNumberColorToolStripMenuItem.Text = "Grid Number Color"
        '
        'HighlightColorToolStripMenuItem
        '
        Me.HighlightColorToolStripMenuItem.Name = "HighlightColorToolStripMenuItem"
        Me.HighlightColorToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.HighlightColorToolStripMenuItem.Text = "Grid Highlight Color"
        '
        'RecordTextColorToolStripMenuItem
        '
        Me.RecordTextColorToolStripMenuItem.Name = "RecordTextColorToolStripMenuItem"
        Me.RecordTextColorToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.RecordTextColorToolStripMenuItem.Text = "Record Text Color"
        '
        'filDialog
        '
        Me.filDialog.FileName = "OpenFileDialog1"
        '
        'colDialog
        '
        Me.colDialog.AnyColor = True
        Me.colDialog.FullOpen = True
        '
        'ResetToDefaultColorsToolStripMenuItem
        '
        Me.ResetToDefaultColorsToolStripMenuItem.Name = "ResetToDefaultColorsToolStripMenuItem"
        Me.ResetToDefaultColorsToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.ResetToDefaultColorsToolStripMenuItem.Text = "Reset to Default Colors"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(239, 6)
        '
        'frmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 558)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.tblCore)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmViewer"
        Me.Text = "File Viewer"
        Me.tblCore.ResumeLayout(False)
        Me.tblCore.PerformLayout()
        Me.pnlGridControls.ResumeLayout(False)
        CType(Me.dgvFieldDefs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFormControls.ResumeLayout(False)
        Me.pnlFormControls.PerformLayout()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInstruments.ResumeLayout(False)
        CType(Me.numRecordChoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents tblCore As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlGridControls As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numRows As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCols As System.Windows.Forms.NumericUpDown
    Friend WithEvents dgvFieldDefs As System.Windows.Forms.DataGridView
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlFormControls As System.Windows.Forms.Panel
    Friend WithEvents btnJumpTo As System.Windows.Forms.Button
    Friend WithEvents numRecordChoice As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlInstruments As System.Windows.Forms.Panel
    Friend WithEvents lblRecordTotal As System.Windows.Forms.Label
    Friend WithEvents lblRecordCurr As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FieldDefToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDefinitionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridLineColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridNumberColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighlightColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordTextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents filDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents chkShowIndex As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetToDefaultColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
