#region #CustomAnimation
using DevExpress.XtraCharts;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AnimationExample {
    class FanFunnelAnimation : FunnelAnimationBase {
        const float AnimationStartAngle = 270;
        const float MaxSweepAngle = 180;
        const float HalfMaxSweepAngle = 90;

        public override void ApplyState(
                SceneModifier modifier, 
                RectangleF diagramBounds, 
                FunnelSeriesPointLayoutParameters funnelParameters, 
                float progress
        ) {
            RectangleF funnelBounds = funnelParameters.Bounds;
            float fanCenterX = funnelBounds.Left + funnelBounds.Width / 2;
            float fanCenterY = funnelBounds.Bottom;
            float fanRadius = (float)Math.Sqrt(
                    (funnelBounds.Left - fanCenterX) * (funnelBounds.Left - fanCenterX)
                    + (funnelBounds.Height) * (funnelBounds.Height)
            );

            float startAngle = AnimationStartAngle - HalfMaxSweepAngle * progress;
            float sweepAngle = MaxSweepAngle * progress;
            float endAngle = startAngle + sweepAngle;

            float fanLeftBoundEndX =
                fanCenterX + (float)Math.Cos(startAngle / 180 * Math.PI) * fanRadius;
            float fanLeftBoundEndY =
                fanCenterY + (float)Math.Sin(startAngle / 180 * Math.PI) * fanRadius;

            float fanRightBoundEndX =
                fanCenterX + (float)Math.Cos(endAngle / 180 * Math.PI) * fanRadius;
            float fanRightBoundEndY =
                fanCenterY + (float)Math.Sin(endAngle / 180 * Math.PI) * fanRadius;

            RectangleF fanBounds = new RectangleF(
                    fanCenterX - fanRadius,
                    fanCenterY - fanRadius,
                    2 * fanRadius,
                    2 * fanRadius
            );

            GraphicsPath path = new GraphicsPath();
            path.AddLine(fanCenterX, fanCenterY, fanLeftBoundEndX, fanLeftBoundEndY);
            path.AddArc(fanBounds, startAngle, sweepAngle);
            path.AddLine(fanRightBoundEndX, fanRightBoundEndY, fanCenterX, fanCenterY);
            modifier.Clip(path);

        }

        protected override ChartElement CreateObjectForClone() {
            return new FanFunnelAnimation();
        }
    }
}
#endregion #CustomAnimation