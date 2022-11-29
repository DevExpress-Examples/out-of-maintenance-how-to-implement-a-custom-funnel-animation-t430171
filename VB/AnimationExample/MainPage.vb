Imports DevExpress.XtraCharts
Imports System

Namespace AnimationExample

    Public Partial Class MainPage
        Inherits DevExpress.XtraEditors.XtraForm

        Private ReadOnly Property series As Series
            Get
                Return chartControl.Series(0)
            End Get
        End Property

        Private ReadOnly Property view As FunnelSeriesView
            Get
                Return TryCast(series.View, FunnelSeriesView)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#AnimationConfig"
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            view.Animation = New FanFunnelAnimation With {.BeginTime = New TimeSpan(0, 0, 0), .Duration = New TimeSpan(0, 0, 0, 1, 500), .PointDelay = New TimeSpan(0, 0, 0, 0, 500), .PointOrder = PointAnimationOrder.Straight, .EasingFunction = New LinearEasingFunction With {.EasingMode = EasingMode.Out}}
            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad
        End Sub

        Private Sub OnAnimateClick(ByVal sender As Object, ByVal e As EventArgs)
            chartControl.Animate()
        End Sub
#End Region  ' #AnimationConfig
    End Class
End Namespace
