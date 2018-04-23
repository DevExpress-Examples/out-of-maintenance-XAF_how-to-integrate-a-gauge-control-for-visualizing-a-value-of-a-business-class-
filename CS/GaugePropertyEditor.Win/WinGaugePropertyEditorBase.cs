using System;
using System.Drawing;
using DevExpress.XtraGauges.Win;
using DevExpress.ExpressApp.Win.Editors;

namespace GaugePropertyEditor.Win {
    public abstract class WinGaugePropertyEditorBase : WinPropertyEditor {
        private object bindableComponentCore;
        protected WinGaugePropertyEditorBase(Type objectType, DevExpress.ExpressApp.Model.IModelMemberViewItem info)
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