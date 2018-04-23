Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim obj As New GaugeDemoObject(Session)
			obj.IntProperty = 50
			obj.FloatProperty = 75.0f
			obj.EnumProperty = Light.Green
			obj.StringProperty = "Gauge Test1"
			obj.Save()
			Dim obj2 As New GaugeDemoObject(Session)
			obj2.IntProperty = 75
			obj2.FloatProperty = 25.0f
			obj2.EnumProperty = Light.Yellow
			obj2.StringProperty = "Gauge Test2"
			obj2.Save()
		End Sub
	End Class
End Namespace
