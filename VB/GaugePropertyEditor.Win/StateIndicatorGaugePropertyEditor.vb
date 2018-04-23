Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraGauges.Win
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Gauges.State

Namespace GaugePropertyEditor.Win
    <PropertyEditor(GetType(System.Enum), False)> _
     Public Class StateIndicatorGaugePropertyEditor
        Inherits WinGaugePropertyEditorBase
        Public Sub New(ByVal objectType As Type, ByVal info As DevExpress.ExpressApp.Model.IModelMemberViewItem)
            MyBase.New(objectType, info)
        End Sub
        Public Overrides Sub SetupGaugeCore(ByVal gaugeContainer As GaugeControl)
            Dim siGauge As StateIndicatorGauge = gaugeContainer.AddStateIndicatorGauge()
            Dim stateIndicator As StateIndicatorComponent = siGauge.AddIndicator()
            BindableComponent = stateIndicator
            Dim shapes() As StateIndicatorShapeType = {StateIndicatorShapeType.TrafficLight2, StateIndicatorShapeType.TrafficLight3, StateIndicatorShapeType.TrafficLight4}
            stateIndicator.States.Clear()
            For Each shape As StateIndicatorShapeType In shapes
                Dim state As New IndicatorState()
                state.ShapeType = shape
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
End Namespace