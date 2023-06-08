using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;

namespace Library_3._0.Views
{
    public partial class AddBookForm : Window
{
    public AddBookForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelAddBook(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
