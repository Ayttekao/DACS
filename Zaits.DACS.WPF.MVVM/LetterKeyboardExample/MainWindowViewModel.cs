using System.Globalization;
using System.Windows.Input;
using Zaits.WPF.MVVM.Core.Command;
using Zaits.WPF.MVVM.Core.ViewModel;

namespace LetterKeyboardExample
{
    internal sealed class MainWindowViewModel : ViewModelBase
    {
        private string _target;
        private bool _capsLockActive = false;
        private ICommand _backspaceCommand;
        private ICommand _charCommand;
        public ICommand _capsLockCommand;

        public MainWindowViewModel()
        {
            Target = string.Empty;
        }

        public string Target
        {
            get =>
                _target;
            private set
            {
                _target = value;
                RaisePropertyChanged(nameof(Target));
            }
        }

        public ICommand BackspaceCommand =>
            _backspaceCommand ??= new RelayCommand(_ => Backspace(), _ => CanBackspace());

        public ICommand CharCommand =>
            _charCommand ??= new RelayCommand(symbol => Char((string)symbol));
        
        public ICommand CapsLockCommand =>
            _capsLockCommand ??= new RelayCommand(_ => CapsLock());

        private void CapsLock()
        {
            _capsLockActive = !_capsLockActive;
        }
        
        private void Backspace()
        {
            Target = Target.Remove(Target.Length - 1, 1);
        }
        
        private bool CanBackspace()
        { 
            return Target != string.Empty;
        }

        private void Char(string symbol)
        {
            // TODO: тут лучше проверить что приехало что-то валидное (ну на всякий случай -_-)
            Target += _capsLockActive ? 
                CultureInfo.CurrentCulture.TextInfo.ToUpper(symbol) : 
                CultureInfo.CurrentCulture.TextInfo.ToLower(symbol);
        }
    }
}