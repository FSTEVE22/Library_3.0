using Avalonia.Controls;
using Avalonia.Markup.Xaml;

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
    }
}
