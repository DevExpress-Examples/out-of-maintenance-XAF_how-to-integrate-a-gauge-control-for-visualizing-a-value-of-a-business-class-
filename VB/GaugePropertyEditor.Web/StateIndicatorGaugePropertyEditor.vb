Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.XtraGauges.Base
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.Web.ASPxGauges.Gauges
Imports DevExpress.Web.ASPxGauges.Gauges.State

    <PropertyEditor(GetType(System.Enum), False)> _
     Public Class StateIndicatorGaugePropertyEditor
        Inherits WebGaugePropertyEditorBase
        Public Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.Model.IModelMemberViewItem)
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
            CType(BindableComponent, StateIndicatorComponent).StateIndex = Convert.ToInt32(PropertyValue)
        End Sub
    End Class
