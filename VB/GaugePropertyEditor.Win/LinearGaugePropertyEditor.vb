Imports System
Imports DevExpress.XtraGauges.Win
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Gauges.Linear

Namespace GaugePropertyEditor.Win
	<PropertyEditor(GetType(Integer), "LinearGaugePropertyEditor", False)>
	Public Class LinearGaugePropertyEditor
		Inherits WinGaugePropertyEditorBase

		Public Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.Model.IModelMemberViewItem)
			MyBase.New(objectType, info)
		End Sub
		Public Overrides Sub SetupGaugeCore(ByVal gaugeContainer As GaugeControl)
			Dim linearGauge As LinearGauge = gaugeContainer.AddLinearGauge()
			' Add the default elements (a scale, background layer and level bar).
			linearGauge.AddDefaultElements()
			' Change the background layer's paint style.
			Dim backgroundLinear As LinearScaleBackgroundLayer = linearGauge.BackgroundLayers(0)
			backgroundLinear.ShapeType = BackgroundLayerShapeType.Linear_Style3
			' Customize the scale's settings.
			Dim scaleLinear As LinearScaleComponent = linearGauge.Scales(0)
			BindableComponent = scaleLinear
			scaleLinear.MinValue = 0
			scaleLinear.MaxValue = 100
			scaleLinear.Value = 0
			scaleLinear.MajorTickCount = 6
			scaleLinear.MajorTickmark.FormatString = "{0:F0}"
			scaleLinear.MajorTickmark.ShapeType = TickmarkShapeType.Linear_Style6_3
			scaleLinear.MinorTickCount = 3
			scaleLinear.MinorTickmark.ShapeType = TickmarkShapeType.Linear_Style5_2
			' Shift tick marks to the right.
			scaleLinear.MajorTickmark.ShapeOffset = 5F
			scaleLinear.MinorTickmark.ShapeOffset = 5F
			' Change the levelBar's paint style.
			Dim levelBar As LinearScaleLevelComponent = linearGauge.Levels(0)
			levelBar.ShapeType = LevelShapeSetType.Style3
			' Shift the background layer up and to the left.
			backgroundLinear.ScaleStartPos = New PointF2D(backgroundLinear.ScaleStartPos.X - 0.005F, backgroundLinear.ScaleStartPos.Y - 0.015F)
			backgroundLinear.ScaleEndPos = New PointF2D(backgroundLinear.ScaleEndPos.X - 0.005F, backgroundLinear.ScaleEndPos.Y)
		End Sub
		Protected Overrides Function GetControlValueCore() As Object
			Return DirectCast(BindableComponent, LinearScaleComponent).Value
		End Function
		Protected Overrides Sub ReadValueCore()
			DirectCast(BindableComponent, LinearScaleComponent).Value = Convert.ToSingle(PropertyValue)
		End Sub
	End Class
End Namespace
