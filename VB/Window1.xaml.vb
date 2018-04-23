Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.NavBar

Namespace MVVM_SelectedItem

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()

			DataContext = New ViewModel()
		End Sub
	End Class

	Public Class ViewModel
		Inherits DependencyObject
		Public Shared ReadOnly SelectedItemProperty As DependencyProperty = DependencyProperty.Register("SelectedItem", GetType(Object), GetType(ViewModel), New PropertyMetadata(Nothing))

		Private products_Renamed As List(Of Product)

		Public ReadOnly Property Products() As List(Of Product)
			Get
				Return products_Renamed
			End Get
		End Property

		Public Sub New()
			products_Renamed = New List(Of Product)()
			For i As Integer = 0 To 8
				products_Renamed.Add(New Product() With {.Category = "Category" & i Mod 3, .Name = "Item" & i})
			Next i
		End Sub
	End Class

	Public Class Product
		Private privateCategory As String
		Public Property Category() As String
			Get
				Return privateCategory
			End Get
			Set(ByVal value As String)
				privateCategory = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class
End Namespace
