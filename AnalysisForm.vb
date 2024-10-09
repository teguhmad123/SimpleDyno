Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic
Imports LiveCharts
Imports LiveCharts.Wpf
Imports OxyPlot.Axes
Imports OxyPlot

Public Class AnalysisForm
    'Overlay Specific
    Private OverlayBMP As Graphics
    Private OverlayBitMap As Bitmap
    Private PicOverlayHeight As Integer
    Private PicOverlayWidth As Integer
    Private OverlayFileCount As Integer = 0

    Private dataFileReader As StreamReader
    Private OverlayFiles() As String
    'CHECK - THIS IS A LOCAL VALUE OF TICKLENGTH - MAY NEED TO RESCALE WITH RESIZE
    Private TickLength As Integer = 10
    Private PlotDrag As Boolean
    Private XOverlayStartFraction As Double
    Private XOverlayEndFraction As Double
    Private YOverlayStartFraction As Double
    Private YOverlayEndFraction As Double
    Dim xAxis As Double
    Private Const MAXDATAFILES As Integer = 5
    Private AnalyzedData(MAXDATAFILES, Main.LAST, Main.MAXDATAPOINTS) As Double
    Private chartControl As ChartControl
    Private OverlayXSelected As Double
    Private OverlayPlotMax As Boolean = True
    Private plotModel1 As OxyPlot.PlotModel
    Private plotModel2 As OxyPlot.PlotModel
    Private dataRecordsList As List(Of List(Of DataRecord)) = New List(Of List(Of DataRecord))()

    Friend Sub Analysis_Setup()
        ReDim OverlayFiles(MAXDATAFILES)

        chartControl = New ChartControl()

        Me.Size = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size

        With pnlDataC1Overlay
            .Width = Me.ClientSize.Width - 165
            .Height = Me.ClientSize.Height - 5
            PicOverlayWidth = .Width
            PicOverlayHeight = .Height
        End With

        OverlayBitMap = New Bitmap(PicOverlayWidth, PicOverlayHeight)
        OverlayBMP = Graphics.FromImage(OverlayBitMap)

        Dim tempstring As String = ""
        Dim tempsplit2 As String()
        Dim paramcount As Integer
        For paramcount = 0 To Main.LAST - 1
            tempstring = tempstring & Main.DataTags(paramcount) & "_"
            'tempstring = tempstring & Main.DataTags(paramcount).Replace(" ", "_") & " "
        Next
        tempsplit2 = Split(tempstring, "_")

        ReDim Preserve tempsplit2(UBound(tempsplit2) - 1)
        'For paramcount = 0 To UBound(tempsplit2)
        ' tempsplit2(paramcount) = tempsplit2(paramcount).Replace("_", " ")
        ' Next
        cmbOverlayC1DataX.Items.AddRange(tempsplit2)
        cmbOverlayC2DataX.Items.AddRange(tempsplit2)
        tempsplit2 = Split(tempstring, "_")
        cmbOverlayC1DataY1.Items.AddRange(tempsplit2)
        cmbOverlayC1DataY2.Items.AddRange(tempsplit2)
        cmbOverlayC2DataY1.Items.AddRange(tempsplit2)
        cmbOverlayC2DataY2.Items.AddRange(tempsplit2)
        tempstring = ""
        tempsplit2 = Split(Main.DataUnitTags(Main.SPEED), " ")
        cmbOverlayCorrectedSpeedUnits.Items.AddRange(tempsplit2)
        cmbOverlayC1DataX.SelectedIndex = 3
        cmbOverlayC1DataY1.SelectedIndex = 21
        cmbOverlayC1DataY2.SelectedIndex = 16
        cmbOverlayC2DataX.SelectedIndex = 0
        cmbOverlayC2DataY1.SelectedIndex = 34
        cmbOverlayC2DataY2.SelectedIndex = 27
        cmbOverlayCorrectedSpeedUnits.SelectedIndex = 0

        'pnlOverlaySetup()

        With chartControl
            .PicOverlayHeight = PicOverlayHeight
            .PicOverlayWidth = PicOverlayWidth
            .XOverlayStartFraction = XOverlayStartFraction
            .XOverlayEndFraction = XOverlayEndFraction
            .YOverlayStartFraction = YOverlayStartFraction
            .YOverlayEndFraction = YOverlayEndFraction
            .OverlayPlotMax = OverlayPlotMax
            .OverlayFileCount = OverlayFileCount
            .AnalyzedData = AnalyzedData
            .xAxis = xAxis
        End With


    End Sub
    Private Sub Analysis_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason <> CloseReason.FormOwnerClosing Then
            Me.Hide()
            e.Cancel = True
            'Main.btnShow_Click(Me, System.EventArgs.Empty)
        End If
    End Sub

    Friend Sub btnAddOverlayFile_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOverlayFile.Click

        ' Dirty trick here to open file from the Fit form
        If Not e.Equals(System.EventArgs.Empty) Then
            With OpenFileDialog1
                .Reset()
                .Filter = "Power Run files v6.3+ (*.sdp)|*.sdp|Power Run Files v5.5+ (*.txt)|*.txt"
                .Multiselect = True
                If .ShowDialog() <> DialogResult.OK Then
                    Return
                End If
            End With
        End If

        Dim dataInputFileReader As DataInputFileReader = New DataInputFileReader()

        Dim index As Integer
        For index = 0 To OpenFileDialog1.FileNames.Length - 1

            Dim fileName As String = OpenFileDialog1.FileNames.GetValue(index).ToString()

            Main.SetMouseBusy_ThreadSafe(Me)

            Dim dataRecords As List(Of DataRecord)

            Try
                With dataInputFileReader
                    '.ReadDataFile(fileName)
                    dataRecords = .ReadDataFile2(fileName)
                    OverlayFileCount = .OverlayFileCount
                    OverlayFiles = .OverlayFiles
                    AnalyzedData = .AnalyzedData
                End With
            Catch ex As FileNotFoundException
                MessageBox.Show("Could not find the The file '" & ex.FileName & "'!. Please try another file!", "File error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Main.SetMouseNormal_ThreadSafe(Me)
                Return
            Catch ex As FileFormatException
                MessageBox.Show("The file '" & fileName & "' has an invalid file format. Please try another file!", "File error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Main.SetMouseNormal_ThreadSafe(Me)
                Return
            Catch
                MessageBox.Show("Could not open the file '" & fileName & "'!", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Main.SetMouseNormal_ThreadSafe(Me)
                Return
            End Try

            clbFiles.Items.Add(Path.GetFileNameWithoutExtension(fileName), clbFiles.CheckedItems.Count < 5)
            Me.dataRecordsList.Add(dataRecords)
        Next

        SetupDiagram()

        'btnAddOverlayFile.Enabled = dataRecordsList.Count < 5

        Main.SetMouseNormal_ThreadSafe(Me)

        'pnlOverlaySetup()
    End Sub

    Private Sub SetupDiagram()

        Me.plotModel1 = New OxyPlot.PlotModel() With {
            .Background = OxyColors.White,
            .AxisTierDistance = 0,
            .PlotMargins = New OxyThickness(100, 50, 100, 50),
            .IsLegendVisible = True
        }

        Me.PlotView1.Model = Me.plotModel1

        Me.plotModel2 = New OxyPlot.PlotModel() With {
            .Background = OxyColors.White,
            .AxisTierDistance = 0,
            .PlotMargins = New OxyThickness(100, 50, 100, 50),
            .IsLegendVisible = True
        }

        Me.PlotView2.Model = Me.plotModel2

        Dim i As Integer
        Dim C1XIndex As Integer = cmbOverlayC1DataX.SelectedIndex
        Dim C1XUnitsIndex As Integer = cmbOverlayC1UnitsX.SelectedIndex

        Dim C1XAxisUnit As String = Main.DataUnitTags(C1XIndex).Split(CType(" ", Char()))(C1XUnitsIndex)
        Dim C1XAxisTitle As String = Main.DataTags(C1XIndex)
        lblC1XTitle.Text = C1XAxisTitle
        lblC1XUnit.Text = "Max (" & C1XAxisUnit & ")"

        Dim C1Y1Index As Integer
        Dim C1Y1UnitsIndex As Integer
        Dim C1Y1AxisUnit As String
        Dim C1Y1AxisTitle As String

        Dim C1Y2Index As Integer
        Dim C1Y2UnitsIndex As Integer
        Dim C1Y2AxisUnit As String
        Dim C1Y2AxisTitle As String

        Dim C2XIndex As Integer = If(cmbOverlayC2DataX.SelectedIndex < 0, 0, cmbOverlayC2DataX.SelectedIndex)
        Dim C2XUnitsIndex As Integer = If(cmbOverlayC2UnitsX.SelectedIndex < 0, 0, cmbOverlayC2UnitsX.SelectedIndex)

        Dim C2XAxisUnit As String = Main.DataUnitTags(C2XIndex).Split(CType(" ", Char()))(C2XUnitsIndex)
        Dim C2XAxisTitle As String = Main.DataTags(C2XIndex)
        lblC2XTitle.Text = C2XAxisTitle
        lblC2XUnit.Text = "Max (" & C2XAxisUnit & ")"

        Dim C2Y1Index As Integer
        Dim C2Y1UnitsIndex As Integer
        Dim C2Y1AxisUnit As String
        Dim C2Y1AxisTitle As String

        Dim C2Y2Index As Integer
        Dim C2Y2UnitsIndex As Integer
        Dim C2Y2AxisUnit As String
        Dim C2Y2AxisTitle As String

        Me.SuspendLayout()

        C1Y1Index = Math.Max(cmbOverlayC1DataY1.SelectedIndex, 0)
        C1Y2Index = Math.Max(cmbOverlayC1DataY2.SelectedIndex, 0)
        C2Y1Index = Math.Max(cmbOverlayC2DataY1.SelectedIndex, 0)
        C2Y2Index = Math.Max(cmbOverlayC2DataY2.SelectedIndex, 0)

        lblC1File1.Visible = clbFiles.CheckedItems.Count > 0
        lblC1File2.Visible = clbFiles.CheckedItems.Count > 1
        lblC1File3.Visible = clbFiles.CheckedItems.Count > 2
        lblC1File4.Visible = clbFiles.CheckedItems.Count > 3
        lblC1File5.Visible = clbFiles.CheckedItems.Count > 4
        'lblC2File1.Visible = clbFiles.CheckedItems.Count > 0
        'lblC2File2.Visible = clbFiles.CheckedItems.Count > 1
        'lblC2File3.Visible = clbFiles.CheckedItems.Count > 2
        'lblC2File4.Visible = clbFiles.CheckedItems.Count > 3
        'lblC2File5.Visible = clbFiles.CheckedItems.Count > 4

        lblC1XMax1.Visible = clbFiles.CheckedItems.Count > 0
        lblC1XMax2.Visible = clbFiles.CheckedItems.Count > 1
        lblC1XMax3.Visible = clbFiles.CheckedItems.Count > 2
        lblC1XMax4.Visible = clbFiles.CheckedItems.Count > 3
        lblC1XMax5.Visible = clbFiles.CheckedItems.Count > 4
        lblC2XMax1.Visible = clbFiles.CheckedItems.Count > 0
        lblC2XMax2.Visible = clbFiles.CheckedItems.Count > 1
        lblC2XMax3.Visible = clbFiles.CheckedItems.Count > 2
        lblC2XMax4.Visible = clbFiles.CheckedItems.Count > 3
        lblC2XMax5.Visible = clbFiles.CheckedItems.Count > 4

        lblC1Y1Title.Visible = C1Y1Index < Main.LAST
        lblC1Y1Unit.Visible = C1Y1Index < Main.LAST
        lblC1Y1Max1.Visible = clbFiles.CheckedItems.Count > 0 And C1Y1Index < Main.LAST
        lblC1Y1Max2.Visible = clbFiles.CheckedItems.Count > 1 And C1Y1Index < Main.LAST
        lblC1Y1Max3.Visible = clbFiles.CheckedItems.Count > 2 And C1Y1Index < Main.LAST
        lblC1Y1Max4.Visible = clbFiles.CheckedItems.Count > 3 And C1Y1Index < Main.LAST
        lblC1Y1Max5.Visible = clbFiles.CheckedItems.Count > 4 And C1Y1Index < Main.LAST

        lblC1Y2Title.Visible = C1Y2Index < Main.LAST
        lblC1Y2Unit.Visible = C1Y2Index < Main.LAST
        lblC1Y2Max1.Visible = clbFiles.CheckedItems.Count > 0 And C1Y2Index < Main.LAST
        lblC1Y2Max2.Visible = clbFiles.CheckedItems.Count > 1 And C1Y2Index < Main.LAST
        lblC1Y2Max3.Visible = clbFiles.CheckedItems.Count > 2 And C1Y2Index < Main.LAST
        lblC1Y2Max4.Visible = clbFiles.CheckedItems.Count > 3 And C1Y2Index < Main.LAST
        lblC1Y2Max5.Visible = clbFiles.CheckedItems.Count > 4 And C1Y2Index < Main.LAST

        lblC2Y1Title.Visible = C2Y1Index < Main.LAST
        lblC2Y1Unit.Visible = C2Y1Index < Main.LAST
        lblC2Y1Max1.Visible = clbFiles.CheckedItems.Count > 0 And C2Y1Index < Main.LAST
        lblC2Y1Max2.Visible = clbFiles.CheckedItems.Count > 1 And C2Y1Index < Main.LAST
        lblC2Y1Max3.Visible = clbFiles.CheckedItems.Count > 2 And C2Y1Index < Main.LAST
        lblC2Y1Max4.Visible = clbFiles.CheckedItems.Count > 3 And C2Y1Index < Main.LAST
        lblC2Y1Max5.Visible = clbFiles.CheckedItems.Count > 4 And C2Y1Index < Main.LAST

        lblC2Y2Title.Visible = C2Y2Index < Main.LAST
        lblC2Y2Unit.Visible = C2Y2Index < Main.LAST
        lblC2Y2Max1.Visible = clbFiles.CheckedItems.Count > 0 And C2Y2Index < Main.LAST
        lblC2Y2Max2.Visible = clbFiles.CheckedItems.Count > 1 And C2Y2Index < Main.LAST
        lblC2Y2Max3.Visible = clbFiles.CheckedItems.Count > 2 And C2Y2Index < Main.LAST
        lblC2Y2Max4.Visible = clbFiles.CheckedItems.Count > 3 And C2Y2Index < Main.LAST
        lblC2Y2Max5.Visible = clbFiles.CheckedItems.Count > 4 And C2Y2Index < Main.LAST

        C1Y1UnitsIndex = Math.Max(cmbOverlayC1UnitsY1.SelectedIndex, 0)
        If (C1Y1Index < Main.LAST) Then
            C1Y1AxisUnit = Main.DataUnitTags(C1Y1Index).Split(CType(" ", Char()))(C1Y1UnitsIndex)
            C1Y1AxisTitle = Main.DataTags(C1Y1Index)
            lblC1Y1Title.Text = C1Y1AxisTitle
            lblC1Y1Unit.Text = "Max (" & C1Y1AxisUnit & ")"
        End If

        C1Y2UnitsIndex = Math.Max(cmbOverlayC1UnitsY2.SelectedIndex, 0)
        If (C1Y2Index < Main.LAST) Then
            C1Y2AxisUnit = Main.DataUnitTags(C1Y2Index).Split(CType(" ", Char()))(C1Y2UnitsIndex)
            C1Y2AxisTitle = Main.DataTags(C1Y2Index)
            lblC1Y2Title.Text = C1Y2AxisTitle
            lblC1Y2Unit.Text = "Max (" & C1Y2AxisUnit & ")"
        End If

        C2Y1UnitsIndex = Math.Max(cmbOverlayC2UnitsY1.SelectedIndex, 0)
        If (C2Y1Index < Main.LAST) Then
            C2Y1AxisUnit = Main.DataUnitTags(C2Y1Index).Split(CType(" ", Char()))(C2Y1UnitsIndex)
            C2Y1AxisTitle = Main.DataTags(C2Y1Index)
            lblC2Y1Title.Text = C2Y1AxisTitle
            lblC2Y1Unit.Text = "Max (" & C2Y1AxisUnit & ")"
        End If

        C2Y2UnitsIndex = Math.Max(cmbOverlayC2UnitsY2.SelectedIndex, 0)
        If (C2Y2Index < Main.LAST) Then
            C2Y2AxisUnit = Main.DataUnitTags(C2Y2Index).Split(CType(" ", Char()))(C2Y2UnitsIndex)
            C2Y2AxisTitle = Main.DataTags(C2Y2Index)
            lblC2Y2Title.Text = C2Y2AxisTitle
            lblC2Y2Unit.Text = "Max (" & C2Y2AxisUnit & ")"
        End If

        plotModel1.Axes.Add(New LinearAxis() With {
                           .Key = "x",
                           .Position = OxyPlot.Axes.AxisPosition.Bottom,
                           .Title = C1XAxisTitle,
                           .MajorGridlineStyle = LineStyle.Solid,
                           .Unit = C1XAxisUnit,
                           .IsZoomEnabled = False
                           })

        If (C1Y1Index < Main.LAST) Then
            plotModel1.Axes.Add(New LinearAxis() With {
                                .Key = "y1",
                                .Position = OxyPlot.Axes.AxisPosition.Left,
                                .Title = C1Y1AxisTitle,
                                .MajorGridlineStyle = LineStyle.Solid,
                                .MajorStep = 1, .Unit = C1Y1AxisUnit,
                                .IsZoomEnabled = False
                                })
        End If

        If (C1Y2Index < Main.LAST) Then
            plotModel1.Axes.Add(New LinearAxis() With {
                               .Key = "y2",
                               .Position = OxyPlot.Axes.AxisPosition.Right,
                               .Title = C1Y2AxisTitle,
                               .MajorGridlineStyle = LineStyle.Dash,
                               .MajorStep = 1, .Unit = C1Y2AxisUnit,
                               .IsZoomEnabled = False
                               })
        End If

        plotModel2.Axes.Add(New LinearAxis() With {
                       .Key = "x",
                       .Position = OxyPlot.Axes.AxisPosition.Bottom,
                       .Title = C2XAxisTitle,
                       .MajorGridlineStyle = LineStyle.Solid,
                       .Unit = C2XAxisUnit,
                       .IsZoomEnabled = False
                       })

        If (C2Y1Index < Main.LAST) Then
            plotModel2.Axes.Add(New LinearAxis() With {
                           .Key = "y1",
                           .Position = OxyPlot.Axes.AxisPosition.Left,
                           .Title = C2Y1AxisTitle,
                           .MajorGridlineStyle = LineStyle.Solid,
                           .MajorStep = 1, .Unit = C2Y1AxisUnit,
                           .IsZoomEnabled = False
                           })
        End If

        If (C2Y2Index < Main.LAST) Then
            plotModel2.Axes.Add(New LinearAxis() With {
                           .Key = "y2",
                           .Position = OxyPlot.Axes.AxisPosition.Right,
                           .Title = C2Y2AxisTitle,
                           .MajorGridlineStyle = LineStyle.Dash,
                           .MajorStep = 1, .Unit = C2Y2AxisUnit,
                           .IsZoomEnabled = False
                           })
        End If

        Dim lineStyles As LineStyle() = {LineStyle.Solid, LineStyle.Dash, LineStyle.LongDash, LineStyle.DashDot, LineStyle.LongDashDot}
        Dim colors As OxyColor() = {OxyColors.Black, OxyColors.Blue, OxyColors.Red, OxyColors.Green, OxyColors.Purple}

        Dim row As Integer = 0
        For i = 0 To dataRecordsList.Count - 1

            If (clbFiles.CheckedIndices.Contains(i) = False) Then
                Continue For
            End If

            Dim lineSeries1 As OxyPlot.Series.LineSeries
            If (C1Y1Index < Main.LAST) Then

                lineSeries1 = New OxyPlot.Series.LineSeries With {
                    .YAxisKey = "y1",
                    .LineStyle = LineStyle.Solid,
                    .Color = colors(row),
                    .Title = C1Y1AxisTitle
                }
                plotModel1.Series.Add(lineSeries1)
            End If

            Dim lineSeries2 As OxyPlot.Series.LineSeries
            If (C1Y2Index < Main.LAST) Then
                lineSeries2 = New OxyPlot.Series.LineSeries With {
                    .YAxisKey = "y2",
                    .LineStyle = LineStyle.Dash,
                    .Color = OxyColor.FromArgb(200, colors(row).R, colors(row).G, colors(row).B),
                    .Title = C1Y2AxisTitle
                }
                plotModel1.Series.Add(lineSeries2)
            End If

            Dim lineSeries3 As OxyPlot.Series.LineSeries
            If (C2Y1Index < Main.LAST) Then

                lineSeries3 = New OxyPlot.Series.LineSeries With {
                    .YAxisKey = "y1",
                    .LineStyle = LineStyle.Solid,
                    .Color = colors(row),
                    .Title = C2Y1AxisTitle
                }

                plotModel2.Series.Add(lineSeries3)
            End If

            Dim lineSeries4 As OxyPlot.Series.LineSeries
            If (C2Y2Index < Main.LAST) Then
                lineSeries4 = New OxyPlot.Series.LineSeries With {
                    .YAxisKey = "y2",
                    .LineStyle = LineStyle.Dash,
                    .Color = OxyColor.FromArgb(200, colors(row).R, colors(row).G, colors(row).B),
                    .Title = C2Y2AxisTitle
                }

                plotModel2.Series.Add(lineSeries4)
            End If

            Dim rpmIndex As Integer = 3
            Dim rpmUnitIndex As Integer = 1
            Dim rpmUnit As String = Main.DataUnitTags(rpmIndex).Split(CType(" ", Char()))(rpmUnitIndex)

            Dim c1X1Max As Double = 0
            Dim c1Y1Max As Double = 0
            Dim c1Y1MaxX As Double = 0
            Dim c1Rpm1Max As Double = 0
            Dim c1Y2Max As Double = 0
            Dim c1Y2MaxX As Double = 0
            Dim c1Rpm2Max As Double = 0


            Dim c2X1Max As Double = 0
            Dim c2Y1Max As Double = 0
            Dim c2Y1MaxX As Double = 0
            Dim c2Y3Max As Double = 0
            Dim c2Y3MaxX As Double = 0
            Dim c2Rpm1Max As Double = 0
            Dim c2Y2Max As Double = 0
            Dim c2Y2MaxX As Double = 0
            Dim c2Rpm2Max As Double = 0

            For Each dataRecord As DataRecord In dataRecordsList(i)
                Dim x1Value As Double = Main.DataActions(C1XIndex)(dataRecord) * Main.DataUnits(C1XIndex, C1XUnitsIndex)
                Dim x2Value As Double = Main.DataActions(C2XIndex)(dataRecord) * Main.DataUnits(C2XIndex, C2XUnitsIndex)
                Dim rpmValue As Double = Main.DataActions(rpmIndex)(dataRecord) * Main.DataUnits(rpmIndex, rpmUnitIndex)
                Dim y1Value As Double = 0
                Dim y2Value As Double = 0
                Dim y3Value As Double = 0
                Dim y4Value As Double = 0


                c1X1Max = Math.Max(c1X1Max, x1Value)
                c2X1Max = Math.Max(c2X1Max, x2Value)

                If (C1Y1Index < Main.LAST) Then
                    y1Value = Main.DataActions(C1Y1Index)(dataRecord) * Main.DataUnits(C1Y1Index, C1Y1UnitsIndex)
                    lineSeries1.Points.Add(New OxyPlot.DataPoint(x1Value, y1Value))
                    If (y1Value > c1Y1Max) Then
                        c1Y1Max = y1Value
                        c1Y1MaxX = x1Value
                        c1Rpm1Max = rpmValue
                    End If
                End If

                If (C1Y2Index < Main.LAST) Then
                    y2Value = Main.DataActions(C1Y2Index)(dataRecord) * Main.DataUnits(C1Y2Index, C1Y2UnitsIndex)
                    lineSeries2.Points.Add(New OxyPlot.DataPoint(x1Value, y2Value))
                    If (y2Value > c1Y2Max) Then
                        c1Y2Max = y2Value
                        c1Y2MaxX = x1Value
                        c1Rpm2Max = rpmValue
                    End If
                End If

                If (C2Y1Index < Main.LAST) Then
                    y3Value = Main.DataActions(C2Y1Index)(dataRecord) * Main.DataUnits(C2Y1Index, C2Y1UnitsIndex)
                    lineSeries3.Points.Add(New OxyPlot.DataPoint(x2Value, y3Value))
                    If (y3Value > c2Y3Max) Then
                        c2Y3Max = y3Value
                        c2Y3MaxX = x2Value
                        c2Rpm1Max = rpmValue
                    End If
                End If

                If (C2Y2Index < Main.LAST) Then
                    y4Value = Main.DataActions(C2Y2Index)(dataRecord) * Main.DataUnits(C2Y2Index, C2Y2UnitsIndex)
                    lineSeries4.Points.Add(New OxyPlot.DataPoint(x2Value, y4Value))
                    If (y4Value > c2Y2Max) Then
                        c2Y2Max = y4Value
                        c2Y2MaxX = x2Value
                        c2Rpm2Max = rpmValue
                    End If
                End If

            Next

            Select Case row
                Case 0
                    lblC1File1.Text = clbFiles.Items.Item(i).ToString()
                    lblC1XMax1.Text = Main.NewCustomFormat(c1X1Max)
                    'lblC1Y1Max1.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm1Max) & " " & rpmUnit
                    'lblC1Y2Max1.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm2Max) & " " & rpmUnit
                    lblC1Y1Max1.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit
                    lblC1Y2Max1.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit
                    'lblC2File1.Text = clbFiles.Items.Item(i).ToString()
                    lblC2XMax1.Text = Main.NewCustomFormat(c2X1Max)
                    'lblC2Y1Max1.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm1Max) & " " & rpmUnit
                    'lblC2Y2Max1.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm2Max) & " " & rpmUnit
                    lblC2Y1Max1.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit
                    lblC2Y2Max1.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit
                Case 1
                    lblC1File2.Text = clbFiles.Items.Item(i).ToString()
                    lblC1XMax2.Text = Main.NewCustomFormat(c1X1Max)
                    'lblC1Y1Max2.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm1Max) & " " & rpmUnit
                    'lblC1Y2Max2.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm2Max) & " " & rpmUnit
                    lblC1Y1Max2.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit
                    lblC1Y2Max2.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit
                    'lblC2File2.Text = clbFiles.Items.Item(i).ToString()
                    lblC2XMax2.Text = Main.NewCustomFormat(c2X1Max)
                    'lblC2Y1Max2.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm1Max) & " " & rpmUnit
                    'lblC2Y2Max2.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm2Max) & " " & rpmUnit
                    lblC2Y1Max2.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit
                    lblC2Y2Max2.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit
                Case 2
                    lblC1File3.Text = clbFiles.Items.Item(i).ToString()
                    lblC1XMax3.Text = Main.NewCustomFormat(c1X1Max)
                    'lblC1Y1Max3.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm1Max) & " " & rpmUnit
                    'lblC1Y2Max3.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm2Max) & " " & rpmUnit
                    lblC1Y1Max3.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit
                    lblC1Y2Max3.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit
                    'lblC2File3.Text = clbFiles.Items.Item(i).ToString()
                    lblC2XMax3.Text = Main.NewCustomFormat(c2X1Max)
                    'lblC2Y1Max3.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm1Max) & " " & rpmUnit
                    'lblC2Y2Max3.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm2Max) & " " & rpmUnit
                    lblC2Y1Max3.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit
                    lblC2Y2Max3.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit
                Case 3
                    lblC1File4.Text = clbFiles.Items.Item(i).ToString()
                    lblC1XMax4.Text = Main.NewCustomFormat(c1X1Max)
                    'lblC1Y1Max4.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm1Max) & " " & rpmUnit
                    'lblC1Y2Max4.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm2Max) & " " & rpmUnit
                    lblC1Y1Max4.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit
                    lblC1Y2Max4.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit
                    'lblC2File4.Text = clbFiles.Items.Item(i).ToString()
                    lblC2XMax4.Text = Main.NewCustomFormat(c2X1Max)
                    'lblC2Y1Max4.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm1Max) & " " & rpmUnit
                    'lblC2Y2Max4.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm2Max) & " " & rpmUnit
                    lblC2Y1Max4.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit
                    lblC2Y2Max4.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit
                Case 4
                    lblC1File5.Text = clbFiles.Items.Item(i).ToString()
                    lblC1XMax5.Text = Main.NewCustomFormat(c1X1Max)
                    'lblC1Y1Max5.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm1Max) & " " & rpmUnit
                    'lblC1Y2Max5.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit & " @ " & Main.NewCustomFormat(c1Rpm2Max) & " " & rpmUnit
                    lblC1Y1Max5.Text = Main.NewCustomFormat(c1Y1Max) & " @ " & Main.NewCustomFormat(c1Y1MaxX) & " " & C1XAxisUnit
                    lblC1Y2Max5.Text = Main.NewCustomFormat(c1Y2Max) & " @ " & Main.NewCustomFormat(c1Y2MaxX) & " " & C1XAxisUnit
                    'lblC2File5.Text = clbFiles.Items.Item(i).ToString()
                    lblC2XMax5.Text = Main.NewCustomFormat(c2X1Max)
                    'lblC2Y1Max5.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm1Max) & " " & rpmUnit
                    'lblC2Y2Max5.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit & " @ " & Main.NewCustomFormat(c2Rpm2Max) & " " & rpmUnit
                    lblC2Y1Max5.Text = Main.NewCustomFormat(c2Y3Max) & " @ " & Main.NewCustomFormat(c2Y3MaxX) & " " & C2XAxisUnit
                    lblC2Y2Max5.Text = Main.NewCustomFormat(c2Y2Max) & " @ " & Main.NewCustomFormat(c2Y2MaxX) & " " & C2XAxisUnit
            End Select

            row = row + 1
        Next

        Me.ResumeLayout()
    End Sub

    Friend Sub btnClearOverlay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOverlay.Click
        ReDim AnalyzedData(MAXDATAFILES, Main.LAST, Main.MAXDATAPOINTS)
        OverlayFileCount = 0
        btnAddOverlayFile.Enabled = True
        Main.frmFit.chkAddOrNew.Enabled = True

        dataRecordsList.Clear()
        clbFiles.Items.Clear()
        SetupDiagram()
        'pnlOverlaySetup()
        btnAddOverlayFile.Enabled = True
    End Sub
    Private Sub btnSaveOverlay_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOverlay.Click
        With SaveFileDialog1
            .Reset()
            .Filter = "Bitmap files (*.bmp)|*.bmp"
            .ShowDialog()
        End With
        If SaveFileDialog1.FileName <> "" Then
            OverlayBitMap.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Bmp)
        End If
    End Sub
    Private Sub cmbOverlayC1X_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1DataX.SelectedIndexChanged
        cmbOverlayC1UnitsX.Items.Clear()
        If cmbOverlayC1DataX.SelectedIndex <> Main.LAST Then
            cmbOverlayC1UnitsX.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC1DataX.SelectedIndex)))
            If cmbOverlayC1UnitsX.Items.Contains("RPM") Then
                cmbOverlayC1UnitsX.SelectedItem = "RPM"
            ElseIf cmbOverlayC1UnitsX.Items.Contains("HP") Then
                cmbOverlayC1UnitsX.SelectedItem = "HP"
            Else
                cmbOverlayC1UnitsX.SelectedIndex = 0
            End If
        Else
            cmbOverlayC1UnitsX.Items.Add("--")
            cmbOverlayC1UnitsX.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC1Y1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1DataY1.SelectedIndexChanged
        cmbOverlayC1UnitsY1.Items.Clear()
        If cmbOverlayC1DataY1.SelectedIndex <> Main.LAST Then
            cmbOverlayC1UnitsY1.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC1DataY1.SelectedIndex)))
            If cmbOverlayC1UnitsY1.Items.Contains("RPM") Then
                cmbOverlayC1UnitsY1.SelectedItem = "RPM"
            ElseIf cmbOverlayC1UnitsY1.Items.Contains("HP") Then
                cmbOverlayC1UnitsY1.SelectedItem = "HP"
            Else
                cmbOverlayC1UnitsY1.SelectedIndex = 0
            End If
        Else
            cmbOverlayC1UnitsY1.Items.Add("--")
            cmbOverlayC1UnitsY1.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC1Y2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1DataY2.SelectedIndexChanged
        cmbOverlayC1UnitsY2.Items.Clear()
        If cmbOverlayC1DataY2.SelectedIndex <> Main.LAST Then
            cmbOverlayC1UnitsY2.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC1DataY2.SelectedIndex)))
            If cmbOverlayC1UnitsY2.Items.Contains("RPM") Then
                cmbOverlayC1UnitsY2.SelectedItem = "RPM"
            ElseIf cmbOverlayC1UnitsY2.Items.Contains("HP") Then
                cmbOverlayC1UnitsY2.SelectedItem = "HP"
            Else
                cmbOverlayC1UnitsY2.SelectedIndex = 0
            End If
        Else
            cmbOverlayC1UnitsY2.Items.Add("--")
            cmbOverlayC1UnitsY2.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC2X_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2DataX.SelectedIndexChanged
        cmbOverlayC2UnitsX.Items.Clear()
        If cmbOverlayC2DataX.SelectedIndex <> Main.LAST Then
            cmbOverlayC2UnitsX.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC2DataX.SelectedIndex)))
            If cmbOverlayC2UnitsX.Items.Contains("RPM") Then
                cmbOverlayC2UnitsX.SelectedItem = "RPM"
            ElseIf cmbOverlayC2UnitsX.Items.Contains("HP") Then
                cmbOverlayC2UnitsX.SelectedItem = "HP"
            Else
                cmbOverlayC2UnitsX.SelectedIndex = 0
            End If
        Else
            cmbOverlayC2UnitsX.Items.Add("--")
            cmbOverlayC2UnitsX.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC2Y1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2DataY1.SelectedIndexChanged
        cmbOverlayC2UnitsY1.Items.Clear()
        If cmbOverlayC2DataY1.SelectedIndex <> Main.LAST Then
            cmbOverlayC2UnitsY1.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC2DataY1.SelectedIndex)))
            If cmbOverlayC2UnitsY1.Items.Contains("RPM") Then
                cmbOverlayC2UnitsY1.SelectedItem = "RPM"
            ElseIf cmbOverlayC2UnitsY1.Items.Contains("HP") Then
                cmbOverlayC2UnitsY1.SelectedItem = "HP"
            Else
                cmbOverlayC2UnitsY1.SelectedIndex = 0
            End If
        Else
            cmbOverlayC2UnitsY1.Items.Add("--")
            cmbOverlayC2UnitsY1.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC2Y2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2DataY2.SelectedIndexChanged
        cmbOverlayC2UnitsY2.Items.Clear()
        If cmbOverlayC2DataY2.SelectedIndex <> Main.LAST Then
            cmbOverlayC2UnitsY2.Items.AddRange(Split(Main.DataUnitTags(cmbOverlayC2DataY2.SelectedIndex)))
            If cmbOverlayC2UnitsY2.Items.Contains("RPM") Then
                cmbOverlayC2UnitsY2.SelectedItem = "RPM"
            ElseIf cmbOverlayC2UnitsY2.Items.Contains("HP") Then
                cmbOverlayC2UnitsY2.SelectedItem = "HP"
            Else
                cmbOverlayC2UnitsY2.SelectedIndex = 0
            End If
        Else
            cmbOverlayC2UnitsY2.Items.Add("--")
            cmbOverlayC2UnitsY2.SelectedIndex = 0
        End If

        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayC1XUnits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1UnitsX.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayC1Y1Units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1UnitsY1.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayC1Y2Units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC1UnitsY2.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub
    Private Sub cmbOverlayC2XUnits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2UnitsX.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayC2Y1Units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2UnitsY1.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayC2Y2Units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayC2UnitsY2.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub cmbOverlayCorrectedSpeedUnits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOverlayCorrectedSpeedUnits.SelectedIndexChanged
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub pnlDataOverlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDataC1Overlay.Click
        SetupDiagram()
        'pnlOverlaySetup()
    End Sub

    Private Sub clbFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbFiles.SelectedIndexChanged
    End Sub

    Private Sub clbFiles_SelectedValueChanged(sender As Object, e As EventArgs) Handles clbFiles.SelectedValueChanged
        If clbFiles.CheckedItems.Count > 5 Then
            MessageBox.Show("Only the first 5 selected files can be displayed. Please deselect one or more files!", "Too many files selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SetupDiagram()

    End Sub
End Class