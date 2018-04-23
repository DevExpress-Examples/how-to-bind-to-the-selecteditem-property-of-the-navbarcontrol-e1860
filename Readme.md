# How to bind to the SelectedItem property of the NavBarControl


<p>This example demonstrates how to obtain a NavBarControl's selected item in a ViewModel.</p><p>For this, it's necessary to bind the NavBarControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfNavBarNavBarControl_SelectedItemtopic"><u>SelectedItem</u></a> property to a property in your View Model. For example:<br />


```xaml
<dxn:NavBarControl SelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../>
```

 </p>


<h3>Description</h3>

<p>To accomplish this task, it is necessary to create a descendant from the NavBarControl class and introduce the bindable property, which will provide getting and setting of the SelectedItem property value.</p><p>This property can be bound to a property in your ViewModel in the following manner:</p><code lang='xaml'>&lt;local:MyNavBarControl BindableSelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../&gt;  
</code><p> </p><p>Note that starting with version 13.2, you can directly bind the NavBarControl&#39;s SelectedItem property to a property in your View Model - see <a data-ticket="S33903">Data Binding - Add a set method to the NavBarControl.SelectedItem property</a> for more information. For example:</p><code lang='xaml'>&lt;dxn:NavBarControl SelectedItem="{Binding Path=SelectedItem, Mode=TwoWay}" .../&gt; </code><p> </p>

<br/>


