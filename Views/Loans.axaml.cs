using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Library_3._0.Views.Forms;

namespace Library_3._0.Views
{
    public partial class Loans : Window
{
    public Loans()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CreateLoan(object sender, RoutedEventArgs e)
        {
            var window = new CreateLoanForm();
            window.Show();
        }

        private void EditLoan(object sender, RoutedEventArgs e)
        {
            var window = new EditLoanForm();
            window.Show();
        }
    }
}
