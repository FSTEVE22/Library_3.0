using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Library_3._0.Views.Forms
{
    public partial class EditBookForm : Window
{
    public EditBookForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelEditBook(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
