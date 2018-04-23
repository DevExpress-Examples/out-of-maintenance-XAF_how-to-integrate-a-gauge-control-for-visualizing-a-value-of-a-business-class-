using DevExpress.ExpressApp.Editors;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Base;
using System;
using DevExpress.ExpressApp;
using System.Drawing;

namespace GaugePropertyEditor.Win {
    public abstract class WinGaugePropertyEditorBase : PropertyEditor {
        private object bindableComponentCore;
        protected WinGaugePropertyEditorBase(Type objectType, DictionaryNode info)
            : base(objectType, info) {
        }
        protected override object CreateControlCore() {
            GaugeControl gaugeControl = new GaugeControl();
            gaugeControl.BackColor = Color.Transparent;
            SetupGaugeCore(gaugeControl);
            return gaugeControl;
        }
        protected override void OnControlCreated() {
            base.OnControlCreated();
            UpdateEditorState();
        }
        public object BindableComponent {
            get { return bindableComponentCore; }
            set { bindableComponentCore = value; }
        }
        public abstract void SetupGaugeCore(GaugeControl gaugeContainer);
    }
}