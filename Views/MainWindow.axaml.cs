using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Library_3._0.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contentArea.Content = new Home().Content;
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            contentArea.Content = new Home().Content;
        }

        private void Books(object sender, RoutedEventArgs e)
        {
            contentArea.Content = new Books().Content;
        }

        private void Borrowers(object sender, RoutedEventArgs e)
        {
            contentArea.Content = new Borrowers().Content;
        }

        private void Loans(object sender, RoutedEventArgs e)
        {
            contentArea.Content = new Loans().Content;
        }

        private void Returns(object sender, RoutedEventArgs e)
        {
            contentArea.Content = new Returns().Content;
        }
    }
}
