Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_PolarAreaChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim polarAreaChart As New ChartControl()

            ' Add a polar series to it.
            Dim series1 As New Series("Series 1", ViewType.PolarArea)

            ' Populate the series with points.
            series1.Points.Add(New SeriesPoint(0, 90))
            series1.Points.Add(New SeriesPoint(90, 70))
            series1.Points.Add(New SeriesPoint(180, 50))
            series1.Points.Add(New SeriesPoint(270, 100))

            ' Add the series to the chart.
            polarAreaChart.Series.Add(series1)

            ' Flip the diagram (if necessary).
            CType(polarAreaChart.Diagram, PolarDiagram).StartAngleInDegrees = 180
            CType(polarAreaChart.Diagram, PolarDiagram).RotationDirection = _
                RadarDiagramRotationDirection.Counterclockwise

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Polar Area Chart"
            polarAreaChart.Titles.Add(chartTitle1)
            polarAreaChart.Legend.Visible = False

            ' Add the chart to the form.
            polarAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(polarAreaChart)
        End Sub

    End Class
End Namespace