using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    public class GaugeDemoObject : BaseObject {
        public GaugeDemoObject(Session session) : base(session) { }
        private string _stringProperty;
        public string StringProperty {
            get { return _stringProperty; }
            set { SetPropertyValue("StringProperty", ref _stringProperty, value); }
        }
        private int _intProperty;
        public int IntProperty {
            get { return _intProperty; }
            set { SetPropertyValue("IntProperty", ref _intProperty, value); }
        }
        private float _floatProperty;
        public float FloatProperty {
            get { return _floatProperty; }
            set { SetPropertyValue("FloatProperty", ref _floatProperty, value); }
        }
        private Light _enumProperty;
        public Light EnumProperty {
            get { return _enumProperty; }
            set { SetPropertyValue("EnumProperty", ref _enumProperty, value); }
        }
    }
    public enum Light {
        Red,
        Yellow,
        Green
    }
}