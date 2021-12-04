using System.Globalization;
using System.Windows;
using System.Windows.Input;
using Zaits.WPF.MVVM.Core.Command;
using Zaits.WPF.MVVM.Core.ViewModel;

namespace MessageDialogExample
{
    internal sealed class MainWindowViewModel : ViewModelBase
    {
        private ICommand _okMessageDialog;
        
        public ICommand OkButtonCommand =>
            _okMessageDialog ??= new RelayCommand(_ => OkButtonPressed());
        private void OkButtonPressed()
        {
            MessageBox.Show("Nope");
        }
    }
}