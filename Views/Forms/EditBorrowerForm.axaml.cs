using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Library_3._0.Views.Forms
{
    public partial class EditBorrowerForm : Window
{
    public EditBorrowerForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelEditBorrower(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
