<!-- default file list -->
*Files to look at*:

* [CircularGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Web/CircularGaugePropertyEditor.cs)
* [DigitalGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Web/DigitalGaugePropertyEditor.cs)
* [LinearGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Web/LinearGaugePropertyEditor.cs)
* [StateIndicatorGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Web/StateIndicatorGaugePropertyEditor.cs)
* [WebGaugePropertyEditorBase.cs](./CS/GaugePropertyEditor.Web/WebGaugePropertyEditorBase.cs)
* [CircularGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Win/CircularGaugePropertyEditor.cs)
* [DigitalGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Win/DigitalGaugePropertyEditor.cs)
* [LinearGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Win/LinearGaugePropertyEditor.cs)
* [StateIndicatorGaugePropertyEditor.cs](./CS/GaugePropertyEditor.Win/StateIndicatorGaugePropertyEditor.cs)
* [WinGaugePropertyEditorBase.cs](./CS/GaugePropertyEditor.Win/WinGaugePropertyEditorBase.cs)
<!-- default file list end -->
# How to integrate a gauge control for visualizing a value of a business class property


<p><strong>Scenario</strong><br />This example demonstrates a possible integration of the DevExpress gauge controls in XAF for representing various types of business class properties. For this, custom WinForms and ASP.NET PropertyEditor classes were implemented:<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-integrate-a-gauge-control-for-visualizing-a-value-of-a-business-class-property-e395/9.3.3+/media/434a2921-9fdd-11e4-80ba-00155d624807.png"><br /><br /></p>
<p><strong>Steps to implement</strong></p>
<p><strong>1.</strong> Copy and include the GaugePropertyEditor.Win and GaugePropertyEditor.Web projects into your solution and make sure it is built successfully.</p>
<p><strong>2.</strong> Invoke the Application Designer for the <em>YourSolutionName/WinApplication.xx</em> file by double-clicking it in the Solution Explorer. Invoke the Toolbox (Alt+X+T) and then drag & drop the <em>GaugePropertyEditorWindowsFormsModule</em> component into the modules list on the left.<br /><strong>3.</strong> Invoke the Application Designer for the <em>YourSolutionName/WebApplication.xx</em> file by double-clicking it in the Solution Explorer. Invoke the Toolbox (Alt+X+T) and then drag & drop the GaugePropertyEditorAspNetModule component into the modules list on the left.<br /><strong>4.</strong> Define a string persistent property within your business class and decorate it with the <em>DevExpress.Persistent.Base.EditorAliasAttribute </em>passing the corresponding PropertyEditor alias string as a parameter. See the <em>WinWebSolution.Module\GaugeDemoObject.cs .xx</em> file for an example.</p>
<p><br /><br /></p>
<p> </p>
<p><strong>See Also:</strong><br /> <a href="http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppEditorsPropertyEditortopic"><u>PropertyEditor Class</u></a><br /> <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxGaugesASPxGaugeControltopic"><u>Class ASPxGaugeControl</u></a><br /> <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGaugesWinGaugeControltopic"><u>Class GaugeControl</u></a><br /> <a href="https://www.devexpress.com/Support/Center/p/S30412">PropertyEditors - Integrate gauge controls</a><br /><a href="https://documentation.devexpress.com/#Xaf/CustomDocument3610">eXpressApp Framework > Concepts > UI Construction > Using a Custom Control that is not Integrated by Default</a></p>

<br/>


