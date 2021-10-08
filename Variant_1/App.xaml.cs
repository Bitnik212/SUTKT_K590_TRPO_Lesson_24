using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Egor92.MvvmNavigation;
using Egor92.MvvmNavigation.Abstractions;
using Variant_1.View;
using Variant_1.ViewModel;

namespace Variant_1
{
    enum PagesEnum
    {
        main_page,
        mean_arephmetic,
        quadratic_equation, 
        work_with_lists,
        work_with_files
    }

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new MainWindow();
            window.Title = "Вариант 1";
            window.Height = 500;
            window.Width = 820;
            //1. Create navigation manager
            var navigationManager = new NavigationManager(window);

            //2. Define navigation rules: register key and corresponding view and viewmodel for it
            navigationManager.Register<MainPage>(PagesEnum.main_page.ToString(), () => new MainViewModel(navigationManager));
            navigationManager.Register<MeanArephmeticPage>(PagesEnum.mean_arephmetic.ToString(), () => new MeanArephmeticViewModel());
            navigationManager.Register<QuadraticEquationPage>(PagesEnum.quadratic_equation.ToString(), () => new QuadraticEquationViewModel());
            navigationManager.Register<WorkWithFilesPage>(PagesEnum.work_with_files.ToString(), () => new WorkWithFilesViewModel());
            navigationManager.Register<WorkWithListsPage>(PagesEnum.work_with_lists.ToString(), () => new WorkWithListsViewModel());

            //3. Display start UI
            navigationManager.Navigate(PagesEnum.main_page.ToString());

            window.Show();
        }
    }
}