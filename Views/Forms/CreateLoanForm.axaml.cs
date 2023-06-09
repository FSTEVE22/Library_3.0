using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Library_3._0.Views.Forms
{
    public partial class CreateLoanForm : Window
{
    public CreateLoanForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelCreateLoan(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
