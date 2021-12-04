using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Controls
{
    public partial class DialogHost : UserControl
    {
        public DialogHost()
        {
            InitializeComponent();

            DialogHostOpacity = 0.4d;
            DialogHostCornerRadius = new CornerRadius(10, 10, 10, 10);
        }

        public object DialogHostContent
        {
            get =>
                (object)GetValue(DialogHostContentProperty);

            set =>
                SetValue(DialogHostContentProperty, value);
        }
        public static readonly DependencyProperty DialogHostContentProperty = DependencyProperty.Register(
            nameof(DialogHostContent), typeof(object), typeof(DialogHost));

        public double DialogHostOpacity
        {
            get =>
                (double)GetValue(DialogHostOpacityProperty);

            set =>
                SetValue(DialogHostOpacityProperty, value);
        }
        public static readonly DependencyProperty DialogHostOpacityProperty = DependencyProperty.Register(
            nameof(DialogHostOpacity), typeof(double), typeof(DialogHost), new PropertyMetadata(0.4d));

        public CornerRadius DialogHostCornerRadius
        {
            get =>
                (CornerRadius)GetValue(DialogHostCornerRadiusProperty);

            set =>
                SetValue(DialogHostCornerRadiusProperty, value);
        }
        public static readonly DependencyProperty DialogHostCornerRadiusProperty = DependencyProperty.Register(
            nameof(DialogHostCornerRadius), typeof(CornerRadius), typeof(DialogHost));

        public ICommand BackgroundCommand
        {
            get =>
                (ICommand)GetValue(BackgroundCommandProperty);

            set =>
                SetValue(BackgroundCommandProperty, value);
        }
        public static readonly DependencyProperty BackgroundCommandProperty = DependencyProperty.Register(
            nameof(BackgroundCommand), typeof(ICommand), typeof(DialogHost));

    }
}