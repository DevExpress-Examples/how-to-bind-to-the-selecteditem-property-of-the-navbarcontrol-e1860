# How to bind to the SelectedItem property of the NavBarControl


<p>This example demonstrates how to obtain a NavBarControl's selected item in a ViewModel.</p><p>For this, it's necessary to bind the NavBarControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfNavBarNavBarControl_SelectedItemtopic"><u>SelectedItem</u></a> property to a property in your View Model. For example:<br />


```xaml
<dxn:NavBarControl SelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../>
```

 </p>


<h3>Description</h3>

<p>To accomplish this task, it is necessary to create a descendant from the <strong>NavBarControl</strong> class and introduce the bindable property, which will provide getting and setting of the <strong>SelectedItem</strong> property value.</p><p>Note that we&#39;re planning to improve this approach in the future. If you want to be notified on our progress, please track the corresponding suggestion in our Support Center: <a data-ticket="S33903">Data Binding - Add a set method to the NavBarControl.SelectedItem property</a>.</p>

<br/>


