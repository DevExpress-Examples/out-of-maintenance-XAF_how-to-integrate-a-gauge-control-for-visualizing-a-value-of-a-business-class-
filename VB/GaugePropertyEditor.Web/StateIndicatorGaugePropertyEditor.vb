Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGauges.Core.Model
Imports System.Drawing
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.Web.ASPxGauges.Gauges.State
Imports DevExpress.XtraGauges.Base
Imports DevExpress.Web.ASPxGauges.Gauges

<PropertyEditor(GetType(System.Enum))> _
 Public Class StateIndicatorGaugePropertyEditor
    Inherits WebGaugePropertyEditorBase
    Public Sub New(ByVal objectType As Type, ByVal info As DictionaryNode)
        MyBase.New(objectType, info)
    End Sub
    Public Overrides Sub SetupGaugeCore(ByVal gaugeContainer As ASPxGaugeControl)
        Dim siGauge As StateIndicatorGauge = CType(gaugeContainer.AddGauge(GaugeType.StateIndicator), StateIndicatorGauge)
        Dim stateIndicator As StateIndicatorComponent = siGauge.AddIndicator()
        stateIndicator.BeginUpdate()
        BindableComponent = stateIndicator
        Dim shapes() As StateIndicatorShapeType = {StateIndicatorShapeType.TrafficLight2, StateIndicatorShapeType.TrafficLight3, StateIndicatorShapeType.TrafficLight4}
        stateIndicator.States.Clear()
        For Each shape As StateIndicatorShapeType In shapes
            Dim state As New IndicatorStateWeb(shape)
            stateIndicator.States.Add(state)
        Next shape
        stateIndicator.Size = New SizeF(100, 200)
    End Sub
    Protected Overrides Function GetControlValueCore() As Object
        Return (CType(BindableComponent, StateIndicatorComponent)).StateIndex
    End Function
    Protected Overrides Sub ReadValueCore()
        CType(BindableComponent, StateIndicatorComponent).StateIndex = CInt(Fix(PropertyValue))
    End Sub
End Class
