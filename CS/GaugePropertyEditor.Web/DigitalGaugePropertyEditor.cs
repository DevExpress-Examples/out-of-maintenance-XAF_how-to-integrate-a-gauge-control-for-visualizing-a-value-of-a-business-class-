using System;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.ExpressApp;
using System.Drawing;
using DevExpress.ExpressApp.Editors;
using DevExpress.Web.ASPxGauges;
using DevExpress.Web.ASPxGauges.Gauges.Digital;
using DevExpress.XtraGauges.Base;

namespace GaugePropertyEditor.Web {
    [PropertyEditor(typeof(string))]
    public class DigitalGaugePropertyEditor: WebGaugePropertyEditorBase {
        public DigitalGaugePropertyEditor(Type objectType, DictionaryNode info)
            : base(objectType, info) {
        }
        public override void SetupGaugeCore(ASPxGaugeControl gaugeContainer) {
            DigitalGauge digitalGauge = (DigitalGauge)gaugeContainer.AddGauge(GaugeType.Digital);
            // The number of digits.
            digitalGauge.DigitCount = 14;
            // Use 14 segment display mode.
            digitalGauge.DisplayMode = DigitalGaugeDisplayMode.FourteenSegment;
            // Add a background layer and set its painting style.
            DigitalBackgroundLayerComponent backgroundDigital = digitalGauge.AddBackgroundLayer();
            BindableComponent = digitalGauge;
            backgroundDigital.ShapeType = DigitalBackgroundShapeSetType.Style2;
            // Set the color of digits.
            digitalGauge.AppearanceOn.ContentBrush = new SolidBrushObject(Color.Red);
        }
        protected override object GetControlValueCore() {
            return ((DigitalGauge)BindableComponent).Text;
        }
        protected override void ReadValueCore() {
            ((DigitalGauge)BindableComponent).Text = (string)PropertyValue;
        }
    }
}
