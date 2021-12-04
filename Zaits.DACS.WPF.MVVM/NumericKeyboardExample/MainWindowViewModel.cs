using System.Windows.Input;
using Zaits.WPF.MVVM.Core.Command;
using Zaits.WPF.MVVM.Core.ViewModel;

namespace NumericKeyboardExample
{
    internal sealed class MainWindowViewModel : ViewModelBase
    {
        private string _target;
        private ICommand _backspaceCommand;
        private ICommand _digitCommand;

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

        public ICommand DigitCommand =>
            _digitCommand ??= new RelayCommand(digit => Digit(((string)digit)[0]));

        private void Backspace()
        {
            Target = Target.Remove(Target.Length - 1, 1);
        }
        
        private bool CanBackspace()
        { 
            return Target != string.Empty;
        }

        private void Digit(char digit)
        {
            // TODO: тут лучше проверить что приехало что-то валидное (ну на всякий случай -_-)
            Target += digit;
        }
    }
}