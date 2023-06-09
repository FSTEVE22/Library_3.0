using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Library_3._0.Views.Forms
{
    public partial class EditLoanForm : Window
{
    public EditLoanForm()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CancelEditLoan(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
