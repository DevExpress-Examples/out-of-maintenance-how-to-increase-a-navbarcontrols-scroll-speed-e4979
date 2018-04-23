Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.XtraNavBar
Imports System.Reflection
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication44
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub
	End Class

	Public Class MyNavBarControl
		Inherits NavBarControl
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Function CreateViewInfo() As NavBarViewInfo
			Return New MyExplorerBarNavBarViewInfo(Me)
		End Function
	End Class


	Public Class MyExplorerBarNavBarViewInfo
		Inherits ExplorerBarNavBarViewInfo
		Private Const currentNavBarScrollSpeed As Integer = 20

		Public Sub New(ByVal navBarControl As NavBarControl)
			MyBase.New(navBarControl)
		End Sub

		Public Overrides Property TopY() As Integer
			Get
				Return MyBase.TopY
			End Get
			Set(ByVal value As Integer)
				Dim isUp As Boolean = MyBase.TopY < value
				MyBase.TopY = If(isUp, value + currentNavBarScrollSpeed, value - currentNavBarScrollSpeed)
			End Set
		End Property
	End Class
End Namespace
