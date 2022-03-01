<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HeartMonitoringForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HeartMonitoringForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonRecord = New System.Windows.Forms.Button()
        Me.ButtonConnection = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelThreshold = New System.Windows.Forms.Label()
        Me.TextBoxThreshold = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelConnection = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChartHeartBeatRealTime = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ButtonClearRecording = New System.Windows.Forms.Button()
        Me.ButtonExportToExcel = New System.Windows.Forms.Button()
        Me.DataGridViewHRBPM = New System.Windows.Forms.DataGridView()
        Me.Timer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeartRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ProgressBarSave = New System.Windows.Forms.ProgressBar()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ChartHeartRateBPM = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerialPort = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ChartHeartBeatRealTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewHRBPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.ChartHeartRateBPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonRecord)
        Me.Panel1.Controls.Add(Me.ButtonConnection)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LabelThreshold)
        Me.Panel1.Controls.Add(Me.TextBoxThreshold)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBoxBaudRate)
        Me.Panel1.Controls.Add(Me.ComboBoxPort)
        Me.Panel1.Controls.Add(Me.ButtonScanPort)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 152)
        Me.Panel1.TabIndex = 0
        '
        'ButtonRecord
        '
        Me.ButtonRecord.Enabled = False
        Me.ButtonRecord.Location = New System.Drawing.Point(283, 124)
        Me.ButtonRecord.Name = "ButtonRecord"
        Me.ButtonRecord.Size = New System.Drawing.Size(123, 23)
        Me.ButtonRecord.TabIndex = 9
        Me.ButtonRecord.Text = "Start Recording"
        Me.ButtonRecord.UseVisualStyleBackColor = True
        '
        'ButtonConnection
        '
        Me.ButtonConnection.Enabled = False
        Me.ButtonConnection.Location = New System.Drawing.Point(10, 124)
        Me.ButtonConnection.Name = "ButtonConnection"
        Me.ButtonConnection.Size = New System.Drawing.Size(123, 23)
        Me.ButtonConnection.TabIndex = 8
        Me.ButtonConnection.Text = "Connect"
        Me.ButtonConnection.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Optimal threshold for detecting heartbeat"
        '
        'LabelThreshold
        '
        Me.LabelThreshold.AutoSize = True
        Me.LabelThreshold.Location = New System.Drawing.Point(7, 98)
        Me.LabelThreshold.Name = "LabelThreshold"
        Me.LabelThreshold.Size = New System.Drawing.Size(68, 16)
        Me.LabelThreshold.TabIndex = 6
        Me.LabelThreshold.Text = "Threshold"
        '
        'TextBoxThreshold
        '
        Me.TextBoxThreshold.Location = New System.Drawing.Point(84, 95)
        Me.TextBoxThreshold.Name = "TextBoxThreshold"
        Me.TextBoxThreshold.Size = New System.Drawing.Size(49, 22)
        Me.TextBoxThreshold.TabIndex = 5
        Me.TextBoxThreshold.Text = "600"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Baud Rate"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(83, 64)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(323, 24)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(84, 34)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(323, 24)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(3, 34)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 1
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelConnection)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 28)
        Me.Panel2.TabIndex = 0
        '
        'LabelConnection
        '
        Me.LabelConnection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelConnection.ForeColor = System.Drawing.Color.White
        Me.LabelConnection.Location = New System.Drawing.Point(238, 2)
        Me.LabelConnection.Name = "LabelConnection"
        Me.LabelConnection.Size = New System.Drawing.Size(168, 23)
        Me.LabelConnection.TabIndex = 1
        Me.LabelConnection.Text = "Status : Disconnected"
        Me.LabelConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Connection"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.ChartHeartBeatRealTime)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 170)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(413, 450)
        Me.Panel3.TabIndex = 1
        '
        'ChartHeartBeatRealTime
        '
        Me.ChartHeartBeatRealTime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartHeartBeatRealTime.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text
        Me.ChartHeartBeatRealTime.BorderlineColor = System.Drawing.Color.RoyalBlue
        Me.ChartHeartBeatRealTime.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.AxisX.Interval = 5.0R
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisX.Maximum = 101.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.AxisY.Maximum = 1100.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.Name = "ChartArea1"
        Me.ChartHeartBeatRealTime.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Legend1.TextWrapThreshold = 40
        Me.ChartHeartBeatRealTime.Legends.Add(Legend1)
        Me.ChartHeartBeatRealTime.Location = New System.Drawing.Point(10, 34)
        Me.ChartHeartBeatRealTime.Name = "ChartHeartBeatRealTime"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.LegendText = "Heart Beat Signal (000)"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.Purple
        Series2.Legend = "Legend1"
        Series2.LegendText = "Threshold"
        Series2.Name = "Series2"
        Me.ChartHeartBeatRealTime.Series.Add(Series1)
        Me.ChartHeartBeatRealTime.Series.Add(Series2)
        Me.ChartHeartBeatRealTime.Size = New System.Drawing.Size(396, 401)
        Me.ChartHeartBeatRealTime.TabIndex = 2
        Me.ChartHeartBeatRealTime.Text = "Chart1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(413, 28)
        Me.Panel4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Graph (Real Time Heart Beat)"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.ButtonClearRecording)
        Me.Panel5.Controls.Add(Me.ButtonExportToExcel)
        Me.Panel5.Controls.Add(Me.DataGridViewHRBPM)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(431, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 324)
        Me.Panel5.TabIndex = 2
        '
        'ButtonClearRecording
        '
        Me.ButtonClearRecording.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearRecording.Location = New System.Drawing.Point(319, 35)
        Me.ButtonClearRecording.Name = "ButtonClearRecording"
        Me.ButtonClearRecording.Size = New System.Drawing.Size(113, 23)
        Me.ButtonClearRecording.TabIndex = 4
        Me.ButtonClearRecording.Text = "Clear Recording"
        Me.ButtonClearRecording.UseVisualStyleBackColor = True
        '
        'ButtonExportToExcel
        '
        Me.ButtonExportToExcel.AutoSize = True
        Me.ButtonExportToExcel.Location = New System.Drawing.Point(10, 35)
        Me.ButtonExportToExcel.Name = "ButtonExportToExcel"
        Me.ButtonExportToExcel.Size = New System.Drawing.Size(113, 26)
        Me.ButtonExportToExcel.TabIndex = 3
        Me.ButtonExportToExcel.Text = "Export To Excel"
        Me.ButtonExportToExcel.UseVisualStyleBackColor = True
        '
        'DataGridViewHRBPM
        '
        Me.DataGridViewHRBPM.AllowUserToAddRows = False
        Me.DataGridViewHRBPM.AllowUserToDeleteRows = False
        Me.DataGridViewHRBPM.AllowUserToResizeRows = False
        Me.DataGridViewHRBPM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewHRBPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewHRBPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewHRBPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Timer, Me.HeartRate})
        Me.DataGridViewHRBPM.Location = New System.Drawing.Point(10, 67)
        Me.DataGridViewHRBPM.Name = "DataGridViewHRBPM"
        Me.DataGridViewHRBPM.RowHeadersVisible = False
        Me.DataGridViewHRBPM.RowHeadersWidth = 51
        Me.DataGridViewHRBPM.RowTemplate.Height = 24
        Me.DataGridViewHRBPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewHRBPM.Size = New System.Drawing.Size(422, 244)
        Me.DataGridViewHRBPM.TabIndex = 2
        '
        'Timer
        '
        Me.Timer.HeaderText = "Timer"
        Me.Timer.MinimumWidth = 6
        Me.Timer.Name = "Timer"
        '
        'HeartRate
        '
        Me.HeartRate.HeaderText = "HeartRate (BPM)"
        Me.HeartRate.MinimumWidth = 6
        Me.HeartRate.Name = "HeartRate"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel6.Controls.Add(Me.ProgressBarSave)
        Me.Panel6.Controls.Add(Me.LabelTime)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(439, 28)
        Me.Panel6.TabIndex = 1
        '
        'ProgressBarSave
        '
        Me.ProgressBarSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarSave.Location = New System.Drawing.Point(119, 8)
        Me.ProgressBarSave.Maximum = 10
        Me.ProgressBarSave.Name = "ProgressBarSave"
        Me.ProgressBarSave.Size = New System.Drawing.Size(223, 13)
        Me.ProgressBarSave.TabIndex = 2
        Me.ProgressBarSave.Visible = False
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelTime.ForeColor = System.Drawing.Color.White
        Me.LabelTime.Location = New System.Drawing.Point(348, 4)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(84, 17)
        Me.LabelTime.TabIndex = 1
        Me.LabelTime.Text = "Timer 00:00"
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Record Table"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.ChartHeartRateBPM)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(431, 342)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(439, 278)
        Me.Panel7.TabIndex = 3
        '
        'ChartHeartRateBPM
        '
        Me.ChartHeartRateBPM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChartHeartRateBPM.BorderlineColor = System.Drawing.Color.RoyalBlue
        Me.ChartHeartRateBPM.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -45
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.AxisX.Maximum = 13.0R
        ChartArea2.AxisX.Minimum = 0R
        ChartArea2.AxisY.Interval = 50.0R
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.AxisY.Maximum = 300.0R
        ChartArea2.AxisY.Minimum = 0R
        ChartArea2.Name = "ChartArea1"
        Me.ChartHeartRateBPM.ChartAreas.Add(ChartArea2)
        Legend2.Alignment = System.Drawing.StringAlignment.Center
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.ChartHeartRateBPM.Legends.Add(Legend2)
        Me.ChartHeartRateBPM.Location = New System.Drawing.Point(10, 34)
        Me.ChartHeartRateBPM.Name = "ChartHeartRateBPM"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Green
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.Green
        Series3.Legend = "Legend1"
        Series3.LegendText = "HeartRate (BPM)"
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "Series1"
        Me.ChartHeartRateBPM.Series.Add(Series3)
        Me.ChartHeartRateBPM.Size = New System.Drawing.Size(422, 229)
        Me.ChartHeartRateBPM.TabIndex = 3
        Me.ChartHeartRateBPM.Text = "Chart1"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(439, 28)
        Me.Panel8.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Record Graph (Heart Rate)"
        '
        'SerialPortArduino
        '
        '
        'TimerSerialPort
        '
        Me.TimerSerialPort.Interval = 1
        '
        'HeartMonitoringForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 632)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HeartMonitoringForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monitoring Heart Rate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ChartHeartBeatRealTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridViewHRBPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.ChartHeartRateBPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelConnection As Label
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents TextBoxThreshold As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelThreshold As Label
    Friend WithEvents ButtonRecord As Button
    Friend WithEvents ButtonConnection As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ChartHeartBeatRealTime As DataVisualization.Charting.Chart
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LabelTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressBarSave As ProgressBar
    Friend WithEvents ButtonClearRecording As Button
    Friend WithEvents ButtonExportToExcel As Button
    Friend WithEvents DataGridViewHRBPM As DataGridView
    Friend WithEvents Timer As DataGridViewTextBoxColumn
    Friend WithEvents HeartRate As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ChartHeartRateBPM As DataVisualization.Charting.Chart
    Friend WithEvents SerialPortArduino As IO.Ports.SerialPort
    Friend WithEvents TimerSerialPort As Timer
End Class
