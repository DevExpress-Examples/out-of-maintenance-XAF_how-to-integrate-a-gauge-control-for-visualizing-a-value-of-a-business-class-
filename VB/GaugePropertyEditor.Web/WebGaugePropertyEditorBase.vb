Imports Microsoft.VisualBasic
Imports DevExpress.ExpressApp.Editors
Imports System
Imports DevExpress.ExpressApp
Imports System.Drawing
Imports DevExpress.Web.ASPxGauges

Public MustInherit Class WebGaugePropertyEditorBase
    Inherits PropertyEditor
    Private bindableComponentCore As Object
    Protected Sub New(ByVal objectType As Type, ByVal info As DictionaryNode)
        MyBase.New(objectType, info)
    End Sub
    Protected Overrides Function CreateControlCore() As Object
        Dim gaugeControl As New ASPxGaugeControl()
        gaugeControl.BackColor = Color.Transparent
        SetupGaugeCore(gaugeControl)
        Return gaugeControl
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
End Class