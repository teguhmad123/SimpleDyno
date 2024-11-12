<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnalysisForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnalysisForm))
        Me.btnAddOverlayFile = New System.Windows.Forms.Button()
        Me.btnClearOverlay = New System.Windows.Forms.Button()
        Me.btnSaveOverlay = New System.Windows.Forms.Button()
        Me.cmbOverlayC1UnitsY2 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC1UnitsY1 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC1UnitsX = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmbOverlayC1DataY2 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC1DataY1 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC1DataX = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cmbOverlayCorrectedSpeedUnits = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC2UnitsY2 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC2UnitsY1 = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.cmbOverlayC2DataY2 = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC2DataY1 = New System.Windows.Forms.ComboBox()
        Me.lblCurrentXValue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlDataC2Overlay = New SimpleDyno.DoubleBufferPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlDataC1Overlay = New SimpleDyno.DoubleBufferPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.clbFiles = New System.Windows.Forms.CheckedListBox()
        Me.cmbOverlayC2DataX = New System.Windows.Forms.ComboBox()
        Me.cmbOverlayC2UnitsX = New System.Windows.Forms.ComboBox()
        Me.PlotView1 = New OxyPlot.WindowsForms.PlotView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PlotView2 = New OxyPlot.WindowsForms.PlotView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblC1XTitle = New System.Windows.Forms.Label()
        Me.lblC1Y1Title = New System.Windows.Forms.Label()
        Me.lblC1Y2Title = New System.Windows.Forms.Label()
        Me.lblC2Y1Title = New System.Windows.Forms.Label()
        Me.lblC1Y1Unit = New System.Windows.Forms.Label()
        Me.lblC1XUnit = New System.Windows.Forms.Label()
        Me.lblC1Y2Unit = New System.Windows.Forms.Label()
        Me.lblC2Y1Unit = New System.Windows.Forms.Label()
        Me.lblC1File1 = New System.Windows.Forms.Label()
        Me.lblC1XMax1 = New System.Windows.Forms.Label()
        Me.lblC1Y1Max1 = New System.Windows.Forms.Label()
        Me.lblC1Y2Max1 = New System.Windows.Forms.Label()
        Me.lblC2Y1Max1 = New System.Windows.Forms.Label()
        Me.lblC1File2 = New System.Windows.Forms.Label()
        Me.lblC1XMax2 = New System.Windows.Forms.Label()
        Me.lblC1Y1Max2 = New System.Windows.Forms.Label()
        Me.lblC1Y2Max2 = New System.Windows.Forms.Label()
        Me.lblC2Y1Max2 = New System.Windows.Forms.Label()
        Me.lblC1File3 = New System.Windows.Forms.Label()
        Me.lblC1XMax3 = New System.Windows.Forms.Label()
        Me.lblC1Y1Max3 = New System.Windows.Forms.Label()
        Me.lblC1Y2Max3 = New System.Windows.Forms.Label()
        Me.lblC2Y1Max3 = New System.Windows.Forms.Label()
        Me.lblC1File4 = New System.Windows.Forms.Label()
        Me.lblC1XMax4 = New System.Windows.Forms.Label()
        Me.lblC1Y1Max4 = New System.Windows.Forms.Label()
        Me.lblC1Y2Max4 = New System.Windows.Forms.Label()
        Me.lblC2Y1Max4 = New System.Windows.Forms.Label()
        Me.lblC1File5 = New System.Windows.Forms.Label()
        Me.lblC1XMax5 = New System.Windows.Forms.Label()
        Me.lblC1Y1Max5 = New System.Windows.Forms.Label()
        Me.lblC1Y2Max5 = New System.Windows.Forms.Label()
        Me.lblC2Y1Max5 = New System.Windows.Forms.Label()
        Me.lblC2Y2Title = New System.Windows.Forms.Label()
        Me.lblC2Y2Unit = New System.Windows.Forms.Label()
        Me.lblC2Y2Max1 = New System.Windows.Forms.Label()
        Me.lblC2Y2Max2 = New System.Windows.Forms.Label()
        Me.lblC2Y2Max3 = New System.Windows.Forms.Label()
        Me.lblC2Y2Max4 = New System.Windows.Forms.Label()
        Me.lblC2Y2Max5 = New System.Windows.Forms.Label()
        Me.lblC2XTitle = New System.Windows.Forms.Label()
        Me.lblC2XUnit = New System.Windows.Forms.Label()
        Me.lblC2XMax1 = New System.Windows.Forms.Label()
        Me.lblC2XMax2 = New System.Windows.Forms.Label()
        Me.lblC2XMax3 = New System.Windows.Forms.Label()
        Me.lblC2XMax4 = New System.Windows.Forms.Label()
        Me.lblC2XMax5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddOverlayFile
        '
        Me.btnAddOverlayFile.BackColor = Main.ColorTheme(Main.COLOR_TEXT)
        'Me.btnAddOverlayFile.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.btnAddOverlayFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddOverlayFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOverlayFile.Location = New System.Drawing.Point(12, 12)
        Me.btnAddOverlayFile.Name = "btnAddOverlayFile"
        Me.btnAddOverlayFile.Size = New System.Drawing.Size(154, 29)
        Me.btnAddOverlayFile.TabIndex = 65
        Me.btnAddOverlayFile.Text = "Load"
        '
        'btnClearOverlay
        '
        Me.btnClearOverlay.BackColor = Main.ColorTheme(Main.COLOR_TEXT)
        'Me.btnClearOverlay.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.btnClearOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearOverlay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearOverlay.Location = New System.Drawing.Point(12, 47)
        Me.btnClearOverlay.Name = "btnClearOverlay"
        Me.btnClearOverlay.Size = New System.Drawing.Size(154, 29)
        Me.btnClearOverlay.TabIndex = 66
        Me.btnClearOverlay.Text = "Clear"
        '
        'btnSaveOverlay
        '
        Me.btnSaveOverlay.BackColor = Main.ColorTheme(Main.COLOR_TEXT)
        'Me.btnSaveOverlay.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.btnSaveOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveOverlay.Enabled = False
        Me.btnSaveOverlay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOverlay.Location = New System.Drawing.Point(12, 82)
        Me.btnSaveOverlay.Name = "btnSaveOverlay"
        Me.btnSaveOverlay.Size = New System.Drawing.Size(154, 29)
        Me.btnSaveOverlay.TabIndex = 67
        Me.btnSaveOverlay.Text = "Save"
        '
        'cmbOverlayC1UnitsY2
        '
        Me.cmbOverlayC1UnitsY2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1UnitsY2.FormattingEnabled = True
        Me.cmbOverlayC1UnitsY2.Location = New System.Drawing.Point(120, 511)
        Me.cmbOverlayC1UnitsY2.Name = "cmbOverlayC1UnitsY2"
        Me.cmbOverlayC1UnitsY2.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC1UnitsY2.TabIndex = 5
        '
        'cmbOverlayC1UnitsY1
        '
        Me.cmbOverlayC1UnitsY1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1UnitsY1.FormattingEnabled = True
        Me.cmbOverlayC1UnitsY1.Location = New System.Drawing.Point(120, 444)
        Me.cmbOverlayC1UnitsY1.Name = "cmbOverlayC1UnitsY1"
        Me.cmbOverlayC1UnitsY1.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC1UnitsY1.TabIndex = 3
        '
        'cmbOverlayC1UnitsX
        '
        Me.cmbOverlayC1UnitsX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1UnitsX.FormattingEnabled = True
        Me.cmbOverlayC1UnitsX.Location = New System.Drawing.Point(120, 377)
        Me.cmbOverlayC1UnitsX.Name = "cmbOverlayC1UnitsX"
        Me.cmbOverlayC1UnitsX.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC1UnitsX.TabIndex = 1
        '
        'Label48
        '
        Me.Label48.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(11, 468)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(46, 13)
        Me.Label48.TabIndex = 89
        Me.Label48.Text = "Y2 Axis:"
        '
        'Label47
        '
        Me.Label47.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(11, 401)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(46, 13)
        Me.Label47.TabIndex = 88
        Me.Label47.Text = "Y1 Axis:"
        '
        'Label46
        '
        Me.Label46.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(11, 334)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(40, 13)
        Me.Label46.TabIndex = 87
        Me.Label46.Text = "X Axis:"
        '
        'cmbOverlayC1DataY2
        '
        Me.cmbOverlayC1DataY2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1DataY2.DropDownWidth = 150
        Me.cmbOverlayC1DataY2.FormattingEnabled = True
        Me.cmbOverlayC1DataY2.Location = New System.Drawing.Point(14, 484)
        Me.cmbOverlayC1DataY2.Name = "cmbOverlayC1DataY2"
        Me.cmbOverlayC1DataY2.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC1DataY2.TabIndex = 4
        '
        'cmbOverlayC1DataY1
        '
        Me.cmbOverlayC1DataY1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1DataY1.DropDownWidth = 150
        Me.cmbOverlayC1DataY1.FormattingEnabled = True
        Me.cmbOverlayC1DataY1.Location = New System.Drawing.Point(14, 417)
        Me.cmbOverlayC1DataY1.Name = "cmbOverlayC1DataY1"
        Me.cmbOverlayC1DataY1.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC1DataY1.TabIndex = 2
        '
        'cmbOverlayC1DataX
        '
        Me.cmbOverlayC1DataX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC1DataX.DropDownWidth = 150
        Me.cmbOverlayC1DataX.FormattingEnabled = True
        Me.cmbOverlayC1DataX.Location = New System.Drawing.Point(14, 350)
        Me.cmbOverlayC1DataX.Name = "cmbOverlayC1DataX"
        Me.cmbOverlayC1DataX.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC1DataX.TabIndex = 0
        '
        'Label51
        '
        Me.Label51.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(76, 775)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(96, 13)
        Me.Label51.TabIndex = 100
        Me.Label51.Text = "Corr. Speed Units:"
        '
        'cmbOverlayCorrectedSpeedUnits
        '
        Me.cmbOverlayCorrectedSpeedUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayCorrectedSpeedUnits.FormattingEnabled = True
        Me.cmbOverlayCorrectedSpeedUnits.Location = New System.Drawing.Point(120, 791)
        Me.cmbOverlayCorrectedSpeedUnits.Name = "cmbOverlayCorrectedSpeedUnits"
        Me.cmbOverlayCorrectedSpeedUnits.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayCorrectedSpeedUnits.TabIndex = 10
        '
        'cmbOverlayC2UnitsY2
        '
        Me.cmbOverlayC2UnitsY2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2UnitsY2.FormattingEnabled = True
        Me.cmbOverlayC2UnitsY2.Location = New System.Drawing.Point(120, 742)
        Me.cmbOverlayC2UnitsY2.Name = "cmbOverlayC2UnitsY2"
        Me.cmbOverlayC2UnitsY2.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC2UnitsY2.TabIndex = 9
        '
        'cmbOverlayC2UnitsY1
        '
        Me.cmbOverlayC2UnitsY1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2UnitsY1.FormattingEnabled = True
        Me.cmbOverlayC2UnitsY1.Location = New System.Drawing.Point(120, 675)
        Me.cmbOverlayC2UnitsY1.Name = "cmbOverlayC2UnitsY1"
        Me.cmbOverlayC2UnitsY1.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC2UnitsY1.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(11, 699)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(46, 13)
        Me.Label50.TabIndex = 96
        Me.Label50.Text = "Y2 Axis:"
        '
        'Label49
        '
        Me.Label49.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(11, 632)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(46, 13)
        Me.Label49.TabIndex = 95
        Me.Label49.Text = "Y1 Axis:"
        '
        'cmbOverlayC2DataY2
        '
        Me.cmbOverlayC2DataY2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2DataY2.DropDownWidth = 150
        Me.cmbOverlayC2DataY2.FormattingEnabled = True
        Me.cmbOverlayC2DataY2.Location = New System.Drawing.Point(14, 715)
        Me.cmbOverlayC2DataY2.Name = "cmbOverlayC2DataY2"
        Me.cmbOverlayC2DataY2.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC2DataY2.TabIndex = 8
        '
        'cmbOverlayC2DataY1
        '
        Me.cmbOverlayC2DataY1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2DataY1.DropDownWidth = 150
        Me.cmbOverlayC2DataY1.FormattingEnabled = True
        Me.cmbOverlayC2DataY1.Location = New System.Drawing.Point(14, 648)
        Me.cmbOverlayC2DataY1.Name = "cmbOverlayC2DataY1"
        Me.cmbOverlayC2DataY1.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC2DataY1.TabIndex = 6
        '
        'lblCurrentXValue
        '
        Me.lblCurrentXValue.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblCurrentXValue.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentXValue.Location = New System.Drawing.Point(96, 833)
        Me.lblCurrentXValue.Name = "lblCurrentXValue"
        Me.lblCurrentXValue.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentXValue.TabIndex = 102
        Me.lblCurrentXValue.Text = "0"
        '
        'Label9
        '
        Me.Label9.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 833)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Current X value:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Label1
        '
        Me.Label1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Units:"
        '
        'Label2
        '
        Me.Label2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Units:"
        '
        'Label3
        '
        Me.Label3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Units:"
        '
        'Label4
        '
        Me.Label4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 678)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Units:"
        '
        'Label5
        '
        Me.Label5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 745)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Units:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = Main.ColorTheme(Main.COLOR_DARK)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlDataC2Overlay)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.pnlDataC1Overlay)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.clbFiles)
        Me.Panel1.Controls.Add(Me.btnAddOverlayFile)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSaveOverlay)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnClearOverlay)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1DataX)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2DataX)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1DataY1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1DataY2)
        Me.Panel1.Controls.Add(Me.lblCurrentXValue)
        Me.Panel1.Controls.Add(Me.Label46)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.Label48)
        Me.Panel1.Controls.Add(Me.cmbOverlayCorrectedSpeedUnits)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1UnitsX)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2UnitsX)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2UnitsY2)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1UnitsY1)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2UnitsY1)
        Me.Panel1.Controls.Add(Me.cmbOverlayC1UnitsY2)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2DataY1)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.cmbOverlayC2DataY2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 883)
        Me.Panel1.TabIndex = 110
        '
        'pnlDataC2Overlay
        '
        Me.pnlDataC2Overlay.BackColor = Main.ColorTheme(Main.COLOR_LIGHT)
        Me.pnlDataC2Overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlDataC2Overlay.Location = New System.Drawing.Point(122, 70)
        Me.pnlDataC2Overlay.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlDataC2Overlay.Name = "pnlDataC2Overlay"
        Me.pnlDataC2Overlay.Size = New System.Drawing.Size(767, 136)
        Me.pnlDataC2Overlay.TabIndex = 1
        Me.pnlDataC2Overlay.TabStop = True
        Me.pnlDataC2Overlay.Visible = False
        '
        'Label10
        '
        Me.Label10.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 611)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Units:"
        '
        'Label11
        '
        Me.Label11.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 565)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "X Axis:"
        '
        'Label8
        '
        Me.Label8.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 545)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Chart 2"
        '
        'Label7
        '
        Me.Label7.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Chart 1"
        '
        'pnlDataC1Overlay
        '
        Me.pnlDataC1Overlay.BackColor = System.Drawing.Color.White
        Me.pnlDataC1Overlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlDataC1Overlay.Location = New System.Drawing.Point(141, 6)
        Me.pnlDataC1Overlay.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlDataC1Overlay.Name = "pnlDataC1Overlay"
        Me.pnlDataC1Overlay.Size = New System.Drawing.Size(767, 136)
        Me.pnlDataC1Overlay.TabIndex = 0
        Me.pnlDataC1Overlay.TabStop = True
        Me.pnlDataC1Overlay.Visible = False
        '
        'Label6
        '
        Me.Label6.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Select files to display:"
        '
        'clbFiles
        '
        Me.clbFiles.FormattingEnabled = True
        Me.clbFiles.Location = New System.Drawing.Point(12, 152)
        Me.clbFiles.Name = "clbFiles"
        Me.clbFiles.Size = New System.Drawing.Size(154, 154)
        Me.clbFiles.TabIndex = 109
        '
        'cmbOverlayC2DataX
        '
        Me.cmbOverlayC2DataX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2DataX.DropDownWidth = 150
        Me.cmbOverlayC2DataX.FormattingEnabled = True
        Me.cmbOverlayC2DataX.Location = New System.Drawing.Point(14, 581)
        Me.cmbOverlayC2DataX.Name = "cmbOverlayC2DataX"
        Me.cmbOverlayC2DataX.Size = New System.Drawing.Size(154, 21)
        Me.cmbOverlayC2DataX.TabIndex = 113
        '
        'cmbOverlayC2UnitsX
        '
        Me.cmbOverlayC2UnitsX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOverlayC2UnitsX.FormattingEnabled = True
        Me.cmbOverlayC2UnitsX.Location = New System.Drawing.Point(120, 608)
        Me.cmbOverlayC2UnitsX.Name = "cmbOverlayC2UnitsX"
        Me.cmbOverlayC2UnitsX.Size = New System.Drawing.Size(48, 21)
        Me.cmbOverlayC2UnitsX.TabIndex = 114
        '
        'PlotView1
        '
        Me.PlotView1.BackColor = Main.ColorTheme(Main.COLOR_BASE)
        Me.PlotView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotView1.Location = New System.Drawing.Point(3, 183)
        Me.PlotView1.Name = "PlotView1"
        Me.PlotView1.PanCursor = System.Windows.Forms.Cursors.Hand
        Me.PlotView1.Size = New System.Drawing.Size(761, 414)
        Me.PlotView1.TabIndex = 110
        Me.PlotView1.Text = "PlotView1"
        Me.PlotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE
        Me.PlotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PlotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = Main.ColorTheme(Main.COLOR_BASE)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PlotView2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlotView1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(181, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.41908!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.67837!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.93658!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 883)
        Me.TableLayoutPanel1.TabIndex = 109
        '
        'PlotView2
        '
        Me.PlotView2.BackColor = Main.ColorTheme(Main.COLOR_BASE)
        Me.PlotView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotView2.Location = New System.Drawing.Point(3, 603)
        Me.PlotView2.Name = "PlotView2"
        Me.PlotView2.PanCursor = System.Windows.Forms.Cursors.Hand
        Me.PlotView2.Size = New System.Drawing.Size(761, 277)
        Me.PlotView2.TabIndex = 112
        Me.PlotView2.Text = "PlotView2"
        Me.PlotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE
        Me.PlotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.PlotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = Main.ColorTheme(Main.COLOR_BASE)
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XTitle, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Title, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Title, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Title, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Unit, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XUnit, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Unit, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Unit, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1File1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XMax1, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Max1, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Max1, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Max1, 6, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1File2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XMax2, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Max2, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Max2, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Max2, 6, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1File3, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XMax3, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Max3, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Max3, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Max3, 6, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1File4, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XMax4, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Max4, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Max4, 3, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Max4, 6, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1File5, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1XMax5, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y1Max5, 2, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC1Y2Max5, 3, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y1Max5, 6, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Title, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Unit, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Max1, 7, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Max2, 7, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Max3, 7, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Max4, 7, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2Y2Max5, 7, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XTitle, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XUnit, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XMax1, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XMax2, 5, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XMax3, 5, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XMax4, 5, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblC2XMax5, 5, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(761, 174)
        Me.TableLayoutPanel2.TabIndex = 111
        '
        'lblC1XTitle
        '
        Me.lblC1XTitle.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XTitle.AutoSize = True
        Me.lblC1XTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XTitle.Location = New System.Drawing.Point(98, 0)
        Me.lblC1XTitle.Name = "lblC1XTitle"
        Me.lblC1XTitle.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XTitle.TabIndex = 0
        Me.lblC1XTitle.Text = "Label7"
        Me.lblC1XTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Title
        '
        Me.lblC1Y1Title.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Title.AutoSize = True
        Me.lblC1Y1Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Title.Location = New System.Drawing.Point(193, 0)
        Me.lblC1Y1Title.Name = "lblC1Y1Title"
        Me.lblC1Y1Title.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Title.TabIndex = 1
        Me.lblC1Y1Title.Text = "Label8"
        Me.lblC1Y1Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Title
        '
        Me.lblC1Y2Title.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Title.AutoSize = True
        Me.lblC1Y2Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Title.Location = New System.Drawing.Point(288, 0)
        Me.lblC1Y2Title.Name = "lblC1Y2Title"
        Me.lblC1Y2Title.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Title.TabIndex = 2
        Me.lblC1Y2Title.Text = "Label10"
        Me.lblC1Y2Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Title
        '
        Me.lblC2Y1Title.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Title.AutoSize = True
        Me.lblC2Y1Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Title.Location = New System.Drawing.Point(573, 0)
        Me.lblC2Y1Title.Name = "lblC2Y1Title"
        Me.lblC2Y1Title.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Title.TabIndex = 3
        Me.lblC2Y1Title.Text = "Label11"
        Me.lblC2Y1Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Unit
        '
        Me.lblC1Y1Unit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Unit.AutoSize = True
        Me.lblC1Y1Unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Unit.Location = New System.Drawing.Point(193, 24)
        Me.lblC1Y1Unit.Name = "lblC1Y1Unit"
        Me.lblC1Y1Unit.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Unit.TabIndex = 5
        Me.lblC1Y1Unit.Text = "Label13"
        Me.lblC1Y1Unit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1XUnit
        '
        Me.lblC1XUnit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XUnit.AutoSize = True
        Me.lblC1XUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XUnit.Location = New System.Drawing.Point(98, 24)
        Me.lblC1XUnit.Name = "lblC1XUnit"
        Me.lblC1XUnit.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XUnit.TabIndex = 4
        Me.lblC1XUnit.Text = "Label12"
        Me.lblC1XUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Unit
        '
        Me.lblC1Y2Unit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Unit.AutoSize = True
        Me.lblC1Y2Unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Unit.Location = New System.Drawing.Point(288, 24)
        Me.lblC1Y2Unit.Name = "lblC1Y2Unit"
        Me.lblC1Y2Unit.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Unit.TabIndex = 6
        Me.lblC1Y2Unit.Text = "Label14"
        Me.lblC1Y2Unit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Unit
        '
        Me.lblC2Y1Unit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Unit.AutoSize = True
        Me.lblC2Y1Unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Unit.Location = New System.Drawing.Point(573, 24)
        Me.lblC2Y1Unit.Name = "lblC2Y1Unit"
        Me.lblC2Y1Unit.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Unit.TabIndex = 7
        Me.lblC2Y1Unit.Text = "Label15"
        Me.lblC2Y1Unit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1File1
        '
        Me.lblC1File1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1File1.AutoSize = True
        Me.lblC1File1.Location = New System.Drawing.Point(3, 48)
        Me.lblC1File1.Name = "lblC1File1"
        Me.lblC1File1.Size = New System.Drawing.Size(66, 20)
        Me.lblC1File1.TabIndex = 8
        Me.lblC1File1.Text = "Label16"
        '
        'lblC1XMax1
        '
        Me.lblC1XMax1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XMax1.AutoSize = True
        Me.lblC1XMax1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XMax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XMax1.Location = New System.Drawing.Point(98, 48)
        Me.lblC1XMax1.Name = "lblC1XMax1"
        Me.lblC1XMax1.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XMax1.TabIndex = 9
        Me.lblC1XMax1.Text = "lblX1Max"
        Me.lblC1XMax1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Max1
        '
        Me.lblC1Y1Max1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Max1.AutoSize = True
        Me.lblC1Y1Max1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Max1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Max1.Location = New System.Drawing.Point(193, 48)
        Me.lblC1Y1Max1.Name = "lblC1Y1Max1"
        Me.lblC1Y1Max1.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Max1.TabIndex = 10
        Me.lblC1Y1Max1.Text = "Label18"
        Me.lblC1Y1Max1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Max1
        '
        Me.lblC1Y2Max1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Max1.AutoSize = True
        Me.lblC1Y2Max1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Max1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Max1.Location = New System.Drawing.Point(288, 48)
        Me.lblC1Y2Max1.Name = "lblC1Y2Max1"
        Me.lblC1Y2Max1.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Max1.TabIndex = 11
        Me.lblC1Y2Max1.Text = "Label19"
        Me.lblC1Y2Max1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Max1
        '
        Me.lblC2Y1Max1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Max1.AutoSize = True
        Me.lblC2Y1Max1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Max1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Max1.Location = New System.Drawing.Point(573, 48)
        Me.lblC2Y1Max1.Name = "lblC2Y1Max1"
        Me.lblC2Y1Max1.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Max1.TabIndex = 12
        Me.lblC2Y1Max1.Text = "Label20"
        Me.lblC2Y1Max1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1File2
        '
        Me.lblC1File2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1File2.AutoSize = True
        Me.lblC1File2.ForeColor = System.Drawing.Color.Blue
        Me.lblC1File2.Location = New System.Drawing.Point(3, 72)
        Me.lblC1File2.Name = "lblC1File2"
        Me.lblC1File2.Size = New System.Drawing.Size(66, 20)
        Me.lblC1File2.TabIndex = 13
        Me.lblC1File2.Text = "Label21"
        '
        'lblC1XMax2
        '
        Me.lblC1XMax2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XMax2.AutoSize = True
        Me.lblC1XMax2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XMax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XMax2.Location = New System.Drawing.Point(98, 72)
        Me.lblC1XMax2.Name = "lblC1XMax2"
        Me.lblC1XMax2.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XMax2.TabIndex = 14
        Me.lblC1XMax2.Text = "Label22"
        Me.lblC1XMax2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Max2
        '
        Me.lblC1Y1Max2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Max2.AutoSize = True
        Me.lblC1Y1Max2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Max2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Max2.Location = New System.Drawing.Point(193, 72)
        Me.lblC1Y1Max2.Name = "lblC1Y1Max2"
        Me.lblC1Y1Max2.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Max2.TabIndex = 15
        Me.lblC1Y1Max2.Text = "Label23"
        Me.lblC1Y1Max2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Max2
        '
        Me.lblC1Y2Max2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Max2.AutoSize = True
        Me.lblC1Y2Max2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Max2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Max2.Location = New System.Drawing.Point(288, 72)
        Me.lblC1Y2Max2.Name = "lblC1Y2Max2"
        Me.lblC1Y2Max2.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Max2.TabIndex = 16
        Me.lblC1Y2Max2.Text = "Label24"
        Me.lblC1Y2Max2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Max2
        '
        Me.lblC2Y1Max2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Max2.AutoSize = True
        Me.lblC2Y1Max2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Max2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Max2.Location = New System.Drawing.Point(573, 72)
        Me.lblC2Y1Max2.Name = "lblC2Y1Max2"
        Me.lblC2Y1Max2.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Max2.TabIndex = 17
        Me.lblC2Y1Max2.Text = "Label25"
        Me.lblC2Y1Max2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1File3
        '
        Me.lblC1File3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1File3.AutoSize = True
        Me.lblC1File3.ForeColor = System.Drawing.Color.Red
        Me.lblC1File3.Location = New System.Drawing.Point(3, 96)
        Me.lblC1File3.Name = "lblC1File3"
        Me.lblC1File3.Size = New System.Drawing.Size(66, 20)
        Me.lblC1File3.TabIndex = 18
        Me.lblC1File3.Text = "Label26"
        '
        'lblC1XMax3
        '
        Me.lblC1XMax3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XMax3.AutoSize = True
        Me.lblC1XMax3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XMax3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XMax3.Location = New System.Drawing.Point(98, 96)
        Me.lblC1XMax3.Name = "lblC1XMax3"
        Me.lblC1XMax3.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XMax3.TabIndex = 19
        Me.lblC1XMax3.Text = "Label27"
        Me.lblC1XMax3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Max3
        '
        Me.lblC1Y1Max3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Max3.AutoSize = True
        Me.lblC1Y1Max3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Max3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Max3.Location = New System.Drawing.Point(193, 96)
        Me.lblC1Y1Max3.Name = "lblC1Y1Max3"
        Me.lblC1Y1Max3.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Max3.TabIndex = 20
        Me.lblC1Y1Max3.Text = "Label28"
        Me.lblC1Y1Max3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Max3
        '
        Me.lblC1Y2Max3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Max3.AutoSize = True
        Me.lblC1Y2Max3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Max3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Max3.Location = New System.Drawing.Point(288, 96)
        Me.lblC1Y2Max3.Name = "lblC1Y2Max3"
        Me.lblC1Y2Max3.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Max3.TabIndex = 21
        Me.lblC1Y2Max3.Text = "Label29"
        Me.lblC1Y2Max3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Max3
        '
        Me.lblC2Y1Max3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Max3.AutoSize = True
        Me.lblC2Y1Max3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Max3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Max3.Location = New System.Drawing.Point(573, 96)
        Me.lblC2Y1Max3.Name = "lblC2Y1Max3"
        Me.lblC2Y1Max3.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Max3.TabIndex = 22
        Me.lblC2Y1Max3.Text = "Label30"
        Me.lblC2Y1Max3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1File4
        '
        Me.lblC1File4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1File4.AutoSize = True
        Me.lblC1File4.ForeColor = System.Drawing.Color.Green
        Me.lblC1File4.Location = New System.Drawing.Point(3, 120)
        Me.lblC1File4.Name = "lblC1File4"
        Me.lblC1File4.Size = New System.Drawing.Size(66, 20)
        Me.lblC1File4.TabIndex = 23
        Me.lblC1File4.Text = "Label31"
        '
        'lblC1XMax4
        '
        Me.lblC1XMax4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XMax4.AutoSize = True
        Me.lblC1XMax4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XMax4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XMax4.Location = New System.Drawing.Point(98, 120)
        Me.lblC1XMax4.Name = "lblC1XMax4"
        Me.lblC1XMax4.Size = New System.Drawing.Size(89, 24)
        Me.lblC1XMax4.TabIndex = 24
        Me.lblC1XMax4.Text = "Label32"
        Me.lblC1XMax4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Max4
        '
        Me.lblC1Y1Max4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Max4.AutoSize = True
        Me.lblC1Y1Max4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Max4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Max4.Location = New System.Drawing.Point(193, 120)
        Me.lblC1Y1Max4.Name = "lblC1Y1Max4"
        Me.lblC1Y1Max4.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y1Max4.TabIndex = 25
        Me.lblC1Y1Max4.Text = "Label33"
        Me.lblC1Y1Max4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Max4
        '
        Me.lblC1Y2Max4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Max4.AutoSize = True
        Me.lblC1Y2Max4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Max4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Max4.Location = New System.Drawing.Point(288, 120)
        Me.lblC1Y2Max4.Name = "lblC1Y2Max4"
        Me.lblC1Y2Max4.Size = New System.Drawing.Size(89, 24)
        Me.lblC1Y2Max4.TabIndex = 26
        Me.lblC1Y2Max4.Text = "Label34"
        Me.lblC1Y2Max4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Max4
        '
        Me.lblC2Y1Max4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Max4.AutoSize = True
        Me.lblC2Y1Max4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Max4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Max4.Location = New System.Drawing.Point(573, 120)
        Me.lblC2Y1Max4.Name = "lblC2Y1Max4"
        Me.lblC2Y1Max4.Size = New System.Drawing.Size(89, 24)
        Me.lblC2Y1Max4.TabIndex = 27
        Me.lblC2Y1Max4.Text = "Label35"
        Me.lblC2Y1Max4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1File5
        '
        Me.lblC1File5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1File5.AutoSize = True
        Me.lblC1File5.ForeColor = System.Drawing.Color.Purple
        Me.lblC1File5.Location = New System.Drawing.Point(3, 144)
        Me.lblC1File5.Name = "lblC1File5"
        Me.lblC1File5.Size = New System.Drawing.Size(66, 20)
        Me.lblC1File5.TabIndex = 28
        Me.lblC1File5.Text = "Label36"
        '
        'lblC1XMax5
        '
        Me.lblC1XMax5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1XMax5.AutoSize = True
        Me.lblC1XMax5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1XMax5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1XMax5.Location = New System.Drawing.Point(98, 144)
        Me.lblC1XMax5.Name = "lblC1XMax5"
        Me.lblC1XMax5.Size = New System.Drawing.Size(89, 30)
        Me.lblC1XMax5.TabIndex = 29
        Me.lblC1XMax5.Text = "Label37"
        Me.lblC1XMax5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y1Max5
        '
        Me.lblC1Y1Max5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y1Max5.AutoSize = True
        Me.lblC1Y1Max5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y1Max5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y1Max5.Location = New System.Drawing.Point(193, 144)
        Me.lblC1Y1Max5.Name = "lblC1Y1Max5"
        Me.lblC1Y1Max5.Size = New System.Drawing.Size(89, 30)
        Me.lblC1Y1Max5.TabIndex = 30
        Me.lblC1Y1Max5.Text = "Label38"
        Me.lblC1Y1Max5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC1Y2Max5
        '
        Me.lblC1Y2Max5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC1Y2Max5.AutoSize = True
        Me.lblC1Y2Max5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC1Y2Max5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1Y2Max5.Location = New System.Drawing.Point(288, 144)
        Me.lblC1Y2Max5.Name = "lblC1Y2Max5"
        Me.lblC1Y2Max5.Size = New System.Drawing.Size(89, 30)
        Me.lblC1Y2Max5.TabIndex = 31
        Me.lblC1Y2Max5.Text = "Label39"
        Me.lblC1Y2Max5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y1Max5
        '
        Me.lblC2Y1Max5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y1Max5.AutoSize = True
        Me.lblC2Y1Max5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y1Max5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y1Max5.Location = New System.Drawing.Point(573, 144)
        Me.lblC2Y1Max5.Name = "lblC2Y1Max5"
        Me.lblC2Y1Max5.Size = New System.Drawing.Size(89, 30)
        Me.lblC2Y1Max5.TabIndex = 32
        Me.lblC2Y1Max5.Text = "Label40"
        Me.lblC2Y1Max5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Title
        '
        Me.lblC2Y2Title.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Title.AutoSize = True
        Me.lblC2Y2Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y2Title.Location = New System.Drawing.Point(668, 0)
        Me.lblC2Y2Title.Name = "lblC2Y2Title"
        Me.lblC2Y2Title.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Title.TabIndex = 33
        Me.lblC2Y2Title.Text = "Label7"
        Me.lblC2Y2Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Unit
        '
        Me.lblC2Y2Unit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Unit.AutoSize = True
        Me.lblC2Y2Unit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2Y2Unit.Location = New System.Drawing.Point(668, 24)
        Me.lblC2Y2Unit.Name = "lblC2Y2Unit"
        Me.lblC2Y2Unit.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Unit.TabIndex = 34
        Me.lblC2Y2Unit.Text = "Label8"
        Me.lblC2Y2Unit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Max1
        '
        Me.lblC2Y2Max1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Max1.AutoSize = True
        Me.lblC2Y2Max1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Max1.Location = New System.Drawing.Point(668, 48)
        Me.lblC2Y2Max1.Name = "lblC2Y2Max1"
        Me.lblC2Y2Max1.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Max1.TabIndex = 35
        Me.lblC2Y2Max1.Text = "Label10"
        Me.lblC2Y2Max1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Max2
        '
        Me.lblC2Y2Max2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Max2.AutoSize = True
        Me.lblC2Y2Max2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Max2.Location = New System.Drawing.Point(668, 72)
        Me.lblC2Y2Max2.Name = "lblC2Y2Max2"
        Me.lblC2Y2Max2.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Max2.TabIndex = 36
        Me.lblC2Y2Max2.Text = "Label11"
        Me.lblC2Y2Max2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Max3
        '
        Me.lblC2Y2Max3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Max3.AutoSize = True
        Me.lblC2Y2Max3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Max3.Location = New System.Drawing.Point(668, 96)
        Me.lblC2Y2Max3.Name = "lblC2Y2Max3"
        Me.lblC2Y2Max3.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Max3.TabIndex = 37
        Me.lblC2Y2Max3.Text = "Label12"
        Me.lblC2Y2Max3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Max4
        '
        Me.lblC2Y2Max4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Max4.AutoSize = True
        Me.lblC2Y2Max4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Max4.Location = New System.Drawing.Point(668, 120)
        Me.lblC2Y2Max4.Name = "lblC2Y2Max4"
        Me.lblC2Y2Max4.Size = New System.Drawing.Size(90, 24)
        Me.lblC2Y2Max4.TabIndex = 38
        Me.lblC2Y2Max4.Text = "Label13"
        Me.lblC2Y2Max4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2Y2Max5
        '
        Me.lblC2Y2Max5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2Y2Max5.AutoSize = True
        Me.lblC2Y2Max5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2Y2Max5.Location = New System.Drawing.Point(668, 144)
        Me.lblC2Y2Max5.Name = "lblC2Y2Max5"
        Me.lblC2Y2Max5.Size = New System.Drawing.Size(90, 30)
        Me.lblC2Y2Max5.TabIndex = 39
        Me.lblC2Y2Max5.Text = "Label14"
        Me.lblC2Y2Max5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XTitle
        '
        Me.lblC2XTitle.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XTitle.AutoSize = True
        Me.lblC2XTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2XTitle.Location = New System.Drawing.Point(478, 0)
        Me.lblC2XTitle.Name = "lblC2XTitle"
        Me.lblC2XTitle.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XTitle.TabIndex = 43
        Me.lblC2XTitle.Text = "Label11"
        Me.lblC2XTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XUnit
        '
        Me.lblC2XUnit.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XUnit.AutoSize = True
        Me.lblC2XUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2XUnit.Location = New System.Drawing.Point(478, 24)
        Me.lblC2XUnit.Name = "lblC2XUnit"
        Me.lblC2XUnit.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XUnit.TabIndex = 44
        Me.lblC2XUnit.Text = "Label12"
        Me.lblC2XUnit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XMax1
        '
        Me.lblC2XMax1.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XMax1.AutoSize = True
        Me.lblC2XMax1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XMax1.Location = New System.Drawing.Point(478, 48)
        Me.lblC2XMax1.Name = "lblC2XMax1"
        Me.lblC2XMax1.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XMax1.TabIndex = 50
        Me.lblC2XMax1.Text = "Label18"
        Me.lblC2XMax1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XMax2
        '
        Me.lblC2XMax2.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XMax2.AutoSize = True
        Me.lblC2XMax2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XMax2.Location = New System.Drawing.Point(478, 72)
        Me.lblC2XMax2.Name = "lblC2XMax2"
        Me.lblC2XMax2.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XMax2.TabIndex = 51
        Me.lblC2XMax2.Text = "Label19"
        Me.lblC2XMax2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XMax3
        '
        Me.lblC2XMax3.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XMax3.AutoSize = True
        Me.lblC2XMax3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XMax3.Location = New System.Drawing.Point(478, 96)
        Me.lblC2XMax3.Name = "lblC2XMax3"
        Me.lblC2XMax3.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XMax3.TabIndex = 52
        Me.lblC2XMax3.Text = "Label20"
        Me.lblC2XMax3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XMax4
        '
        Me.lblC2XMax4.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XMax4.AutoSize = True
        Me.lblC2XMax4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XMax4.Location = New System.Drawing.Point(478, 120)
        Me.lblC2XMax4.Name = "lblC2XMax4"
        Me.lblC2XMax4.Size = New System.Drawing.Size(89, 24)
        Me.lblC2XMax4.TabIndex = 53
        Me.lblC2XMax4.Text = "Label21"
        Me.lblC2XMax4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblC2XMax5
        '
        Me.lblC2XMax5.ForeColor = Main.ColorTheme(Main.COLOR_TEXT)
        Me.lblC2XMax5.AutoSize = True
        Me.lblC2XMax5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblC2XMax5.Location = New System.Drawing.Point(478, 144)
        Me.lblC2XMax5.Name = "lblC2XMax5"
        Me.lblC2XMax5.Size = New System.Drawing.Size(89, 30)
        Me.lblC2XMax5.TabIndex = 54
        Me.lblC2XMax5.Text = "Label22"
        Me.lblC2XMax5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AnalysisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 883)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AnalysisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Analysis"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddOverlayFile As System.Windows.Forms.Button
    Friend WithEvents btnClearOverlay As System.Windows.Forms.Button
    Friend WithEvents btnSaveOverlay As System.Windows.Forms.Button
    Friend WithEvents cmbOverlayC1UnitsY2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC1UnitsY1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC1UnitsX As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmbOverlayC1DataY2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC1DataY1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC1DataX As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents cmbOverlayCorrectedSpeedUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC2UnitsY2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC2UnitsY1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents cmbOverlayC2DataY2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOverlayC2DataY1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblCurrentXValue As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlDataC1Overlay As DoubleBufferPanel
    Friend WithEvents PlotView1 As OxyPlot.WindowsForms.PlotView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents clbFiles As CheckedListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblC2Y1Title As Label
    Friend WithEvents lblC1Y1Unit As Label
    Friend WithEvents lblC1XUnit As Label
    Friend WithEvents lblC1Y2Unit As Label
    Friend WithEvents lblC2Y1Unit As Label
    Friend WithEvents lblC1File1 As Label
    Friend WithEvents lblC1XMax1 As Label
    Friend WithEvents lblC1Y1Max1 As Label
    Friend WithEvents lblC1Y2Max1 As Label
    Friend WithEvents lblC2Y1Max1 As Label
    Friend WithEvents lblC1File2 As Label
    Friend WithEvents lblC1XMax2 As Label
    Friend WithEvents lblC1Y1Max2 As Label
    Friend WithEvents lblC1Y2Max2 As Label
    Friend WithEvents lblC2Y1Max2 As Label
    Friend WithEvents lblC1File3 As Label
    Friend WithEvents lblC1XMax3 As Label
    Friend WithEvents lblC1Y1Max3 As Label
    Friend WithEvents lblC1Y2Max3 As Label
    Friend WithEvents lblC2Y1Max3 As Label
    Friend WithEvents lblC1File4 As Label
    Friend WithEvents lblC1XMax4 As Label
    Friend WithEvents lblC1Y1Max4 As Label
    Friend WithEvents lblC1Y2Max4 As Label
    Friend WithEvents lblC2Y1Max4 As Label
    Friend WithEvents lblC1File5 As Label
    Friend WithEvents lblC1XMax5 As Label
    Friend WithEvents lblC1Y1Max5 As Label
    Friend WithEvents lblC1Y2Max5 As Label
    Friend WithEvents lblC2Y1Max5 As Label
    Friend WithEvents lblC2Y2Title As Label
    Friend WithEvents lblC2Y2Unit As Label
    Friend WithEvents lblC2Y2Max1 As Label
    Friend WithEvents lblC2Y2Max2 As Label
    Friend WithEvents lblC2Y2Max3 As Label
    Friend WithEvents lblC2Y2Max4 As Label
    Friend WithEvents lblC2Y2Max5 As Label
    Friend WithEvents lblC2XTitle As Label
    Friend WithEvents lblC2XUnit As Label
    Friend WithEvents lblC2XMax1 As Label
    Friend WithEvents lblC2XMax2 As Label
    Friend WithEvents lblC2XMax3 As Label
    Friend WithEvents lblC2XMax4 As Label
    Friend WithEvents lblC2XMax5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbOverlayC2UnitsX As ComboBox
    Friend WithEvents cmbOverlayC2DataX As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PlotView2 As OxyPlot.WindowsForms.PlotView
    Friend WithEvents pnlDataC2Overlay As DoubleBufferPanel
    Friend WithEvents lblC1XTitle As Label
    Friend WithEvents lblC1Y1Title As Label
    Friend WithEvents lblC1Y2Title As Label
End Class
