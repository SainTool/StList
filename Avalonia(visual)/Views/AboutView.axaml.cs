using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StList.Views
{
    public partial class AboutView : Window
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
