Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	<DefaultClassOptions>
	Public Class GaugeDemoObject
		Inherits BaseObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _stringProperty As String
		<EditorAlias("DigitalGaugePropertyEditor")>
		Public Property StringProperty() As String
			Get
				Return _stringProperty
			End Get
			Set(ByVal value As String)
				SetPropertyValue("StringProperty", _stringProperty, value)
			End Set
		End Property
		Private _intProperty As Integer
		<EditorAlias("LinearGaugePropertyEditor")>
		Public Property IntProperty() As Integer
			Get
				Return _intProperty
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue("IntProperty", _intProperty, value)
			End Set
		End Property
		Private _floatProperty As Single
		<EditorAlias("CircularGaugePropertyEditor")>
		Public Property FloatProperty() As Single
			Get
				Return _floatProperty
			End Get
			Set(ByVal value As Single)
				SetPropertyValue("FloatProperty", _floatProperty, value)
			End Set
		End Property
		Private _enumProperty As Light
		<EditorAlias("StateIndicatorGaugePropertyEditor")>
		Public Property EnumProperty() As Light
			Get
				Return _enumProperty
			End Get
			Set(ByVal value As Light)
				SetPropertyValue("EnumProperty", _enumProperty, value)
			End Set
		End Property
	End Class
	Public Enum Light
		Red
		Yellow
		Green
	End Enum
End Namespace