Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.NavBar

Namespace MVVM_SelectedItem
	Public Class MyNavBarControl
		Inherits NavBarControl
		Public Shared ReadOnly BindableSelectedItemProperty As DependencyProperty

		Shared Sub New()
			BindableSelectedItemProperty = DependencyProperty.Register("BindableSelectedItem", GetType(Object), GetType(MyNavBarControl), New PropertyMetadata(Nothing, AddressOf OnBindableSelectedItemChanged))
		End Sub

		Private Shared Sub OnBindableSelectedItemChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			Dim navBar As NavBarControl = TryCast(d, NavBarControl)
			For Each group As NavBarGroup In navBar.Groups
				For Each item As NavBarItem In group.Items
					If item.DataContext Is e.NewValue Then
						group.SelectedItemIndex = group.Items.IndexOf(item)
						Return
					End If
				Next item
			Next group
		End Sub

		Public Property BindableSelectedItem() As Object
			Get
				Return CObj(GetValue(BindableSelectedItemProperty))
			End Get
			Set(ByVal value As Object)
				SetValue(BindableSelectedItemProperty, value)
			End Set
		End Property

		Protected Overrides Sub OnPropertyChanged(ByVal e As DependencyPropertyChangedEventArgs)
			MyBase.OnPropertyChanged(e)
			If e.Property Is NavBarControl.SelectedItemProperty Then
				BindableSelectedItem = (CType(e.NewValue, NavBarItem)).DataContext
			End If
		End Sub
	End Class
End Namespace