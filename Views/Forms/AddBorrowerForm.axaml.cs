using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Library_3._0.Views.Forms
{
    public partial class AddBorrowerForm : Window
{
    public AddBorrowerForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelAddBorrower(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
