Namespace AnimationExample

    Partial Class MainPage

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim funnelSeriesLabel1 As DevExpress.XtraCharts.FunnelSeriesLabel = New DevExpress.XtraCharts.FunnelSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Visited a web site", New Object() {(CObj((9152R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Downloaded a trial", New Object() {(CObj((6870R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Contacted to support", New Object() {(CObj((5121R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Subscribed", New Object() {(CObj((2224R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Renewed", New Object() {(CObj((1670R)))})
            Dim funnelSeriesView1 As DevExpress.XtraCharts.FunnelSeriesView = New DevExpress.XtraCharts.FunnelSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.pnlChart = New DevExpress.XtraEditors.PanelControl()
            Me.pnlButtons = New DevExpress.XtraEditors.PanelControl()
            Me.btnAnumate = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnelSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnelSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pnlChart), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlChart.SuspendLayout()
            CType((Me.pnlButtons), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlButtons.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.Location = New System.Drawing.Point(4, 4)
            Me.chartControl.Name = "chartControl"
            funnelSeriesLabel1.Position = DevExpress.XtraCharts.FunnelSeriesLabelPosition.RightColumn
            funnelSeriesLabel1.TextPattern = "{A}: {VP:P1}"
            series1.Label = funnelSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Name = "Series"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            funnelSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            series1.View = funnelSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl.Size = New System.Drawing.Size(790, 383)
            Me.chartControl.TabIndex = 2
            chartTitle1.Text = "Web site visitor trend"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' pnlChart
            ' 
            Me.pnlChart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlChart.Controls.Add(Me.chartControl)
            Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlChart.Location = New System.Drawing.Point(0, 0)
            Me.pnlChart.Name = "pnlChart"
            Me.pnlChart.Padding = New System.Windows.Forms.Padding(4, 4, 4, 2)
            Me.pnlChart.Size = New System.Drawing.Size(798, 389)
            Me.pnlChart.TabIndex = 3
            ' 
            ' pnlButtons
            ' 
            Me.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlButtons.Controls.Add(Me.btnAnumate)
            Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlButtons.Location = New System.Drawing.Point(0, 389)
            Me.pnlButtons.Name = "pnlButtons"
            Me.pnlButtons.Padding = New System.Windows.Forms.Padding(4, 2, 4, 4)
            Me.pnlButtons.Size = New System.Drawing.Size(798, 29)
            Me.pnlButtons.TabIndex = 4
            ' 
            ' btnAnumate
            ' 
            Me.btnAnumate.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAnumate.Location = New System.Drawing.Point(694, 2)
            Me.btnAnumate.Name = "btnAnumate"
            Me.btnAnumate.Size = New System.Drawing.Size(100, 23)
            Me.btnAnumate.TabIndex = 0
            Me.btnAnumate.Text = "Animate"
            AddHandler Me.btnAnumate.Click, New System.EventHandler(AddressOf Me.OnAnimateClick)
            ' 
            ' MainPage
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(798, 418)
            Me.Controls.Add(Me.pnlChart)
            Me.Controls.Add(Me.pnlButtons)
            Me.Name = "MainPage"
            Me.Text = "Custom Funnel Animation Example"
            CType((funnelSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnelSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pnlChart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlChart.ResumeLayout(False)
            CType((Me.pnlButtons), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlButtons.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private chartControl As DevExpress.XtraCharts.ChartControl

        Private pnlChart As DevExpress.XtraEditors.PanelControl

        Private pnlButtons As DevExpress.XtraEditors.PanelControl

        Private btnAnumate As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
