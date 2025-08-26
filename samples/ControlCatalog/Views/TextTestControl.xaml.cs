using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlCatalog.Views
{
    public class TextTestControl : UserControl
    {
        public TextTestControl()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
