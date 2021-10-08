using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace Variant_1.ViewModel
{
    public class WorkWithListsViewModel: ViewModelBase
    {
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

        private List<string> _comboBoxItems = new List<string> {"Здесь будут все новые записи"};

        public List<string> comboBoxItems
        {
            get => _comboBoxItems;
            set
            {
                _comboBoxItems = value;
                OnPropertyChanged(nameof(comboBoxItems));
            }
        }

        private void addComboBoxItem(string item)
        {
            var items = comboBoxItems;
            items.Add(item);
        }
 
        public ICommand AddItem
        {
            get => new DelegateCommand(o =>
            {
                addComboBoxItem(inputValue);
                inputValue = "";
            }, o => !string.IsNullOrEmpty(inputValue) 
                    && !comboBoxItems.Contains(inputValue)
                    );
        }
    }
}