using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalog.Views
{
    public class TestControl : UserControl
    {
        public TestControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
