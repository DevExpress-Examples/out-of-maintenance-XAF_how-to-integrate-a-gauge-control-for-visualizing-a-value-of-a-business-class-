using DevExpress.ExpressApp.Editors;
using System;
using DevExpress.ExpressApp;
using System.Drawing;
using DevExpress.Web.ASPxGauges;

namespace GaugePropertyEditor.Web {
    public abstract class WebGaugePropertyEditorBase : PropertyEditor {
        private object bindableComponentCore;
        protected WebGaugePropertyEditorBase(Type objectType, DictionaryNode info)
            : base(objectType, info) {
        }
        protected override object CreateControlCore() {
            ASPxGaugeControl gaugeControl = new ASPxGaugeControl();
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
        public abstract void SetupGaugeCore(ASPxGaugeControl gaugeContainer);
    }
}