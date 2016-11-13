using Sondage.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Sondage
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var navigation = NavigationViewModel.Instance;
            navigation.NavigateTo(new QuestionsViewModel());
            MainWindow = new MainWindow() { DataContext = navigation };           
           
            MainWindow.Show();
        }
    }
}
