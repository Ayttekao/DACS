using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Zaits.WPF.Controls
{
    public partial class NumericKeyboard : UserControl
    {
        public NumericKeyboard()
        {
            InitializeComponent();
        }
        
        public ICommand EnterButtonCommand
        {
            get =>
                (ICommand)GetValue(EnterButtonCommandProperty);

            set =>
                SetValue(EnterButtonCommandProperty, value);
        }

        public ICommand BackspaceButtonCommand
        {
            get =>
                (ICommand)GetValue(BackspaceButtonCommandProperty);

            set =>
                SetValue(BackspaceButtonCommandProperty, value);
        }

        public static readonly DependencyProperty EnterButtonCommandProperty = DependencyProperty.Register(
            nameof(EnterButtonCommand), typeof(ICommand), typeof(NumericKeyboard));
        
        public static readonly DependencyProperty BackspaceButtonCommandProperty = DependencyProperty.Register(
            nameof(BackspaceButtonCommand), typeof(ICommand), typeof(NumericKeyboard));
        
        // analog for this command
        //private ICommand _backspaceButtonCommand;
    }
}