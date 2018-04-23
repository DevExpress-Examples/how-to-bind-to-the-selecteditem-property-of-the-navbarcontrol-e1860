# How to bind to the SelectedItem property of the NavBarControl


<p>This example demonstrates how to obtain a NavBarControl's selected item in a ViewModel.</p><p>For this, it's necessary to bind the NavBarControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfNavBarNavBarControl_SelectedItemtopic"><u>SelectedItem</u></a> property to a property in your View Model. For example:<br />


```xaml
<dxn:NavBarControl SelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../>
```

 </p>

<br/>


