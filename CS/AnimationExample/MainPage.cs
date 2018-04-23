using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace AnimationExample {
    public partial class MainPage : DevExpress.XtraEditors.XtraForm {
        Series series { get { return chartControl.Series[0]; } }
        FunnelSeriesView view { get { return series.View as FunnelSeriesView; } }

        public MainPage() {
            InitializeComponent();
        }

        #region #AnimationConfig
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            view.Animation = new FanFunnelAnimation {
                BeginTime = new TimeSpan(0, 0, 0),
                Duration = new TimeSpan(0, 0, 0, 1, 500),
                PointDelay = new TimeSpan(0, 0, 0, 0, 500),
                PointOrder = PointAnimationOrder.Straight,
                EasingFunction = new LinearEasingFunction {
                    EasingMode = EasingMode.Out
                }
            };

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
        }

        private void OnAnimateClick(object sender, EventArgs e) {
            chartControl.Animate();
        }
        #endregion #AnimationConfig
    }
}

