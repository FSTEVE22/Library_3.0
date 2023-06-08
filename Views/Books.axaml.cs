using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Library_3._0.Views.Forms;

namespace Library_3._0.Views
{
    public partial class Books : Window
{
    public Books()
    {
            InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            var window = new AddBookForm();
            window.Show();
        }

        private void EditBook(object sender, RoutedEventArgs e)
        {
            var window = new EditBookForm();
            window.Show();
        }
    }
}
