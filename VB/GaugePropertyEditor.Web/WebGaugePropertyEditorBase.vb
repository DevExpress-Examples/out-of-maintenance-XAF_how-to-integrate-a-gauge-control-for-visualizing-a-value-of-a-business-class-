Imports System
Imports System.Drawing
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.ExpressApp.Web.Editors
Imports System.Web.UI.WebControls

Namespace GaugePropertyEditor.Web
	Public MustInherit Class WebGaugePropertyEditorBase
		Inherits WebPropertyEditor

		Private bindableComponentCore As Object
		Protected Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.Model.IModelMemberViewItem)
			MyBase.New(objectType, info)
		End Sub
		Private Function CreateGaugeControl() As WebControl
			Dim gaugeControl As New ASPxGaugeControl()
			gaugeControl.BackColor = Color.Transparent
			SetupGaugeCore(gaugeControl)
			Return gaugeControl
		End Function
		Protected Overrides Function CreateViewModeControlCore() As WebControl
			Return CreateGaugeControl()
		End Function
		Protected Overrides Function CreateEditModeControlCore() As WebControl
			Return CreateGaugeControl()
		End Function
		Protected Overrides Sub OnControlCreated()
			MyBase.OnControlCreated()
			UpdateEditorState()
		End Sub
		Public Property BindableComponent() As Object
			Get
				Return bindableComponentCore
			End Get
			Set(ByVal value As Object)
				bindableComponentCore = value
			End Set
		End Property
		Public MustOverride Sub SetupGaugeCore(ByVal gaugeContainer As ASPxGaugeControl)
		Protected Overrides Sub ReadEditModeValueCore()
		End Sub
	End Class
End Namespace