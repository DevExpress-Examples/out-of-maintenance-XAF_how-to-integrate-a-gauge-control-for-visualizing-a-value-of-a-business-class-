Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.ExpressApp
Imports System.Drawing
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win
Imports DevExpress.ExpressApp.Editors

<PropertyEditor(GetType(System.String))> _
 Public Class DigitalGaugePropertyEditor
    Inherits WinGaugePropertyEditorBase
    Public Sub New(ByVal objectType As Type, ByVal info As DictionaryNode)
        MyBase.New(objectType, info)
    End Sub
    Public Overrides Sub SetupGaugeCore(ByVal gaugeContainer As GaugeControl)
        Dim digitalGauge As DigitalGauge = gaugeContainer.AddDigitalGauge()
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
        CType(BindableComponent, DigitalGauge).Text = CStr(PropertyValue)
    End Sub
End Class
