using System;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            GaugeDemoObject obj = new GaugeDemoObject(Session);
            obj.IntProperty = 50;
            obj.FloatProperty = 75.0f;
            obj.EnumProperty = Light.Green;
            obj.StringProperty = "Gauge Test1";
            obj.Save();
            GaugeDemoObject obj2 = new GaugeDemoObject(Session);
            obj2.IntProperty = 75;
            obj2.FloatProperty = 25.0f;
            obj2.EnumProperty = Light.Yellow;
            obj2.StringProperty = "Gauge Test2";
            obj2.Save();
        }
    }
}
