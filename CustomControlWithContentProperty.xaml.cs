using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace XamlPreviewBugContentProperty
{
    [ContentProperty(nameof(MyCustomContent))]
    public partial class CustomControlWithContentProperty : UserControl
    {
        public CustomControlWithContentProperty()
        {
            InitializeComponent();
        }

        public static DependencyProperty CustomContentProperty = DependencyProperty.Register("MyCustomContent",
            typeof(FrameworkElement), typeof(CustomControlWithContentProperty));

        public FrameworkElement MyCustomContent
        {
            get => (FrameworkElement)GetValue(CustomContentProperty);
            set => SetValue(CustomContentProperty, value);
        }
    }
}