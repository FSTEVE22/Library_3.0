using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Library_3._0.Views.Forms;

namespace Library_3._0.Views
{
    public partial class Borrowers : Window
    {
        public Borrowers()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void AddBorrower(object sender, RoutedEventArgs e)
        {
            var window = new AddBorrowerForm();
            window.Show();
        }

        private void EditBorrower(object sender, RoutedEventArgs e)
        {
            var window = new EditBorrowerForm();
            window.Show();
        }
    }
}