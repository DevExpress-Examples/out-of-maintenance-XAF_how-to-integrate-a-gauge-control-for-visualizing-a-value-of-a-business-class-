using System;
using DevExpress.XtraGauges.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Gauges.Circular;

namespace GaugePropertyEditor.Win {
    [PropertyEditor(typeof(float), "CircularGaugePropertyEditor", false)]
    public class CircularGaugePropertyEditor: WinGaugePropertyEditorBase {
        public CircularGaugePropertyEditor(Type objectType, DevExpress.ExpressApp.Model.IModelMemberViewItem info)
            : base(objectType, info) {
        }
        public override void SetupGaugeCore(GaugeControl gaugeContainer) {
            CircularGauge circularGauge = gaugeContainer.AddCircularGauge();
            // Add the default elements (a scale, background layer, needle and spindle cap).
            circularGauge.AddDefaultElements();
            // Change the background layer's paint style.
            ArcScaleBackgroundLayer backgroundCircular = circularGauge.BackgroundLayers[0];
            backgroundCircular.ShapeType = BackgroundLayerShapeType.CircularFull_Style3;
            // Customize the scale's settings.
            ArcScaleComponent scaleCircular = circularGauge.Scales[0];
            BindableComponent = scaleCircular;
            scaleCircular.MinValue = 0;
            scaleCircular.MaxValue = 100;
            scaleCircular.Value = 0;
            scaleCircular.MajorTickCount = 6;
            scaleCircular.MajorTickmark.FormatString = "{0:F0}";
            scaleCircular.MajorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_2;
            scaleCircular.MajorTickmark.ShapeOffset = -9;
            scaleCircular.MajorTickmark.AllowTickOverlap = true;
            scaleCircular.MinorTickCount = 3;
            scaleCircular.MinorTickmark.ShapeType = TickmarkShapeType.Circular_Style2_1;
            // Change the needle's paint style.
            ArcScaleNeedleComponent needle = circularGauge.Needles[0];
            needle.ShapeType = NeedleShapeType.CircularFull_Style3;
        }
        protected override object GetControlValueCore() {
            return ((ArcScaleComponent)BindableComponent).Value;        
        }
        protected override void ReadValueCore() {
            ((ArcScaleComponent)BindableComponent).Value = Convert.ToSingle(PropertyValue);    
        }
    }
}
