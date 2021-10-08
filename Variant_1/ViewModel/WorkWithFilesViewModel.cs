using System.Windows.Input;
using Variant_1.Model;

namespace Variant_1.ViewModel
{
    public class WorkWithFilesViewModel: ViewModelBase
    {
        private FileDialog _fileDialog = new FileDialog();
        private string _inputValue;
        public string inputValue
        {
            get => _inputValue;
            set
            {
                _inputValue = value;
                OnPropertyChanged(nameof(inputValue));
            }
        }
        public ICommand readFile
        {
            get => new DelegateCommand(o =>
                {
                    inputValue = _fileDialog.selectAndReadTextFile();
                }, o => string.IsNullOrEmpty(inputValue)
            );
        }

        public ICommand saveFile
        {
            get => new DelegateCommand(o =>
            {
                _fileDialog.saveTextFile(inputValue);
                inputValue = "";
            },o => !string.IsNullOrEmpty(inputValue));
        }
    }
}