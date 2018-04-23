Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.XtraGauges.Base
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.Web.ASPxGauges.Gauges.Digital

Namespace GaugePropertyEditor.Web
	<PropertyEditor(GetType(String), False)> _
	Public Class DigitalGaugePropertyEditor
		Inherits WebGaugePropertyEditorBase
		Public Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.Model.IModelMemberViewItem)
			MyBase.New(objectType, info)
		End Sub
		Public Overrides Sub SetupGaugeCore(ByVal gaugeContainer As ASPxGaugeControl)
			Dim digitalGauge As DigitalGauge = CType(gaugeContainer.AddGauge(GaugeType.Digital), DigitalGauge)
			' The number of digits.
			digitalGauge.DigitCount = 14
			' Use 14 segment display mode.
			digitalGauge.DisplayMode = DigitalGaugeDisplayMode.FourteenSegment
			' Add a background layer and set its painting style.
			Dim backgroundDigital As DigitalBackgroundLayerComponent = digitalGauge.AddBackgroundLayer()
			BindableComponent = digitalGauge
			backgroundDigital.ShapeType = DigitalBackgroundShapeSetType.Style2
			' Set the color of digits.
			digitalGauge.AppearanceOn.ContentBrush = New SolidBrushObject(Color.Red)
		End Sub
		Protected Overrides Function GetControlValueCore() As Object
			Return (CType(BindableComponent, DigitalGauge)).Text
		End Function
		Protected Overrides Sub ReadValueCore()
			CType(BindableComponent, DigitalGauge).Text = Convert.ToString(PropertyValue)
		End Sub
	End Class
End Namespace
