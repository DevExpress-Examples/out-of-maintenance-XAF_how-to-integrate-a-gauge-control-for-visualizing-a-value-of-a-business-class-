using System;
using System.Drawing;
using DevExpress.XtraGauges.Win;
using DevExpress.ExpressApp.Editors;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Gauges.State;

namespace GaugePropertyEditor.Win {
    [PropertyEditor(typeof(Enum), false)]
    public class StateIndicatorGaugePropertyEditor : WinGaugePropertyEditorBase {
        public StateIndicatorGaugePropertyEditor(Type objectType, DevExpress.ExpressApp.Model.IModelMemberViewItem info)
            : base(objectType, info) {
        }
        public override void SetupGaugeCore(GaugeControl gaugeContainer) {
            StateIndicatorGauge siGauge = gaugeContainer.AddStateIndicatorGauge();
            StateIndicatorComponent stateIndicator = siGauge.AddIndicator();
            BindableComponent = stateIndicator;
            StateIndicatorShapeType[] shapes = new StateIndicatorShapeType[] {
                        StateIndicatorShapeType.TrafficLight2,
                        StateIndicatorShapeType.TrafficLight3,
                        StateIndicatorShapeType.TrafficLight4,
                    };
            stateIndicator.States.Clear();
            foreach (StateIndicatorShapeType shape in shapes) {
                IndicatorState state = new IndicatorState();
                state.ShapeType = shape;
                stateIndicator.States.Add(state);
            }
            stateIndicator.Size = new SizeF(100, 200);
        }
        protected override object GetControlValueCore() {
            return ((StateIndicatorComponent)BindableComponent).StateIndex;
        }
        protected override void ReadValueCore() {
            ((StateIndicatorComponent)BindableComponent).StateIndex = Convert.ToInt32(PropertyValue);
        }
    }
}
