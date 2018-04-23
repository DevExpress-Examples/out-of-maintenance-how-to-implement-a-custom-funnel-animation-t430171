#Region "#CustomAnimation"
Imports DevExpress.XtraCharts
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace AnimationExample
    Friend Class FanFunnelAnimation
        Inherits FunnelAnimationBase

        Private Const AnimationStartAngle As Single = 270
        Private Const MaxSweepAngle As Single = 180
        Private Const HalfMaxSweepAngle As Single = 90

        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As RectangleF, ByVal funnelParameters As FunnelSeriesPointLayoutParameters, ByVal progress As Single)
            Dim funnelBounds As RectangleF = funnelParameters.Bounds
            Dim fanCenterX As Single = funnelBounds.Left + funnelBounds.Width / 2
            Dim fanCenterY As Single = funnelBounds.Bottom
            Dim fanRadius As Single = CSng(Math.Sqrt((funnelBounds.Left - fanCenterX) * (funnelBounds.Left - fanCenterX) + (funnelBounds.Height) * (funnelBounds.Height)))

            Dim startAngle As Single = AnimationStartAngle - HalfMaxSweepAngle * progress
            Dim sweepAngle As Single = MaxSweepAngle * progress
            Dim endAngle As Single = startAngle + sweepAngle

            Dim fanLeftBoundEndX As Single = fanCenterX + CSng(Math.Cos(startAngle / 180 * Math.PI)) * fanRadius
            Dim fanLeftBoundEndY As Single = fanCenterY + CSng(Math.Sin(startAngle / 180 * Math.PI)) * fanRadius

            Dim fanRightBoundEndX As Single = fanCenterX + CSng(Math.Cos(endAngle / 180 * Math.PI)) * fanRadius
            Dim fanRightBoundEndY As Single = fanCenterY + CSng(Math.Sin(endAngle / 180 * Math.PI)) * fanRadius

            Dim fanBounds As New RectangleF(fanCenterX - fanRadius, fanCenterY - fanRadius, 2 * fanRadius, 2 * fanRadius)

            Dim path As New GraphicsPath()
            path.AddLine(fanCenterX, fanCenterY, fanLeftBoundEndX, fanLeftBoundEndY)
            path.AddArc(fanBounds, startAngle, sweepAngle)
            path.AddLine(fanRightBoundEndX, fanRightBoundEndY, fanCenterX, fanCenterY)
            modifier.Clip(path)

        End Sub

        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New FanFunnelAnimation()
        End Function
    End Class
End Namespace
#End Region ' #CustomAnimation