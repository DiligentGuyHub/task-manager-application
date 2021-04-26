using NbrbAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToDo.API.Services;
using ToDo.WPF.ViewModels;

namespace ToDo.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //new ExchangeRateService().GetExchangeRate(RateType.USD).ContinueWith((task) =>
            //{ 
            //    var rate = task.Result; 
            //});
            Window window = new MainWindow();
            window.DataContext = new MainViewModel();
            window.Show();

            base.OnStartup(e);
        }
    }
}
