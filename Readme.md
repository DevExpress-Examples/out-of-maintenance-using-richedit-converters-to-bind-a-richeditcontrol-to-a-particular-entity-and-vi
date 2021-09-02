<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607907/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3490)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# Using RichEdit converters to bind a RichEditControl to a particular entity and vice versa


<p>This example illustrates how to use <strong>SpecificFormatToContentConverter</strong> and <strong>ContentToSpecificFormatConverter</strong> to setup binding between RichEditControl content and other DependencyProperty of a specific DependencyObject (TextBox in this example). The main window UI is composed in a special manner to clearly illustrate that you should utilize SpecificFormatToContentConverter if you wish to bind RichEditControl.Content property to a specific entity property. Otherwise, if you wish to bind a specific entity property to a RichEditControl.Content property, utilize ContentToSpecificFormatConverter. Here is the corresponding screenshot:</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/using-richedit-converters-to-bind-a-richeditcontrol-to-a-particular-entity-and-vice-versa-e3490/11.1.7+/media/15b9fd50-076c-4216-adf2-ea8b45f86178.png"></p><p>We have used <strong>OneWay</strong> binding mode (data is transfered from <strong>source</strong> to <strong>target</strong>) in this example for clarity sake. Please review the following web pages to learn more about other available binding modes and general WPF data binding concept:</p><p><a href="http://msdn.microsoft.com/en-us/magazine/cc163299.aspx"><u>Data Binding in WPF</u></a><br />
<a href="http://msdn.microsoft.com/en-us/library/ms752347.aspx"><u>Data Binding Overview</u></a></p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2794">DXRichEdit for WPF: How to establish data binding for the RichEditControl to bind text in different formats</a></p>

<br/>


