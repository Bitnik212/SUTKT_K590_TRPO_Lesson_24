using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Egor92.MvvmNavigation;
using Egor92.MvvmNavigation.Abstractions;
using Variant_1.View;

namespace Variant_1.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        
        private INavigationManager _navigationService;
        
        public MainViewModel(INavigationManager navigationManager)
        {
            _navigationService = navigationManager;
        }

        private Pages pages = new Pages();
        private string _statusValue = "Статус";

        private string statusValue
        {
            get
            {
                return _statusValue;
            }
            set
            {
                _statusValue = value;
                OnPropertyChanged();
            }
        }

        public ICommand GoTo
        {
            get
            {
                return new DelegateCommand((o) =>
                {
                    Page selected = new Pages().select(o as string);
                    if (_navigationService == null)
                    {
                        statusValue = "Can't resolve NavigationService";
                        
                        // throw new ArgumentException("Can't resolve NavigationService");
                    }
                    else
                    {
                        _navigationService.Navigate(o as string);
                    }

                }, (o) => { 
                    Page selected = new Pages().select(o as string);
                    if (selected == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                } );
            }
        }
    }
    
    
}