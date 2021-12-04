using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Zaits.WPF.Controls
{
    public partial class LetterKeyboard : UserControl
    {
        public LetterKeyboard()
        {
            InitializeComponent();
        }

        public ICommand CharButtonCommand
        {
            get =>
                (ICommand)GetValue(CharButtonCommandProperty);

            set =>
                SetValue(CharButtonCommandProperty, value);
        }
        
        public ICommand BackspaceButtonCommand
        {
            get =>
                (ICommand)GetValue(BackspaceButtonCommandProperty);

            set =>
                SetValue(BackspaceButtonCommandProperty, value);
        }
        
        public ICommand CapsLockButtonCommand
        {
            get =>
                (ICommand)GetValue(CapsLockButtonCommandProperty);

            set =>
                SetValue(CapsLockButtonCommandProperty, value);
        }

        public static readonly DependencyProperty CharButtonCommandProperty = DependencyProperty.Register(
            nameof(CharButtonCommand), typeof(ICommand), typeof(LetterKeyboard));
        
        public static readonly DependencyProperty BackspaceButtonCommandProperty = DependencyProperty.Register(
            nameof(BackspaceButtonCommand), typeof(ICommand), typeof(LetterKeyboard));
        
        public static readonly DependencyProperty CapsLockButtonCommandProperty = DependencyProperty.Register(
            nameof(CapsLockButtonCommand), typeof(ICommand), typeof(LetterKeyboard));

        private void ChangeLanguageButtonClick(object sender, RoutedEventArgs e)
        {
            (RussianGrid.Visibility, EnglishGrid.Visibility) = (EnglishGrid.Visibility, RussianGrid.Visibility);
        }
    }
}