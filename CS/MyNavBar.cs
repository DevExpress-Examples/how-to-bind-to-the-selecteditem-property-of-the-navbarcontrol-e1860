using System.Windows;
using DevExpress.Wpf.NavBar;

namespace MVVM_SelectedItem {
    public class MyNavBarControl : NavBarControl {
        public static readonly DependencyProperty BindableSelectedItemProperty;

        static MyNavBarControl() {
            BindableSelectedItemProperty = DependencyProperty.Register("BindableSelectedItem", typeof(object),
                typeof(MyNavBarControl), new PropertyMetadata(null, OnBindableSelectedItemChanged));
        }

        static void OnBindableSelectedItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            NavBarControl navBar = d as NavBarControl;
            foreach (NavBarGroup group in navBar.Groups)
                foreach (object item in group.Items) {
                    if (item == e.NewValue) {
                        group.SelectedItemIndex = group.Items.IndexOf(item);
                        return;
                    }
                }
        }

        public object BindableSelectedItem {
            get { return (object)GetValue(BindableSelectedItemProperty); }
            set { SetValue(BindableSelectedItemProperty, value); }
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e) {
            base.OnPropertyChanged(e);
            if (e.Property == NavBarControl.SelectedItemProperty) {
                BindableSelectedItem = ((NavBarItem)e.NewValue).Content;
            }
        }
    }
}