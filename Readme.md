<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to bind to the SelectedItem property of the NavBarControl


<p>This example demonstrates how to obtain a NavBarControl's selected item in a ViewModel.</p><p>For this, it's necessary to bind the NavBarControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfNavBarNavBarControl_SelectedItemtopic"><u>SelectedItem</u></a> property to a property in your View Model. For example:<br />


```xaml
<dxn:NavBarControl SelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../>
```

 </p>

<br/>


