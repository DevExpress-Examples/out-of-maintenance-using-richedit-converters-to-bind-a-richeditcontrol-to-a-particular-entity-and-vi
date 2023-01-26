Imports System.IO
Imports System.Windows

Namespace RichEditBindingConvertersWpf

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub reBindingSource_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.reBindingSource.LoadDocument("test.html")
        End Sub

        Private Sub tbBindingSource_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.tbBindingSource.Text = File.ReadAllText("test.html")
        End Sub
    End Class
End Namespace
