﻿using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using NbrbAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToDo.API.Services;
using ToDo.Domain.Models;
using ToDo.Domain.Services;
using ToDo.Domain.Services.AuthenticationServices;
using ToDo.EntityFramework;
using ToDo.EntityFramework.Services;
using ToDo.WPF.State.Authenticators;
using ToDo.WPF.State.Navigators;
using ToDo.WPF.ViewModels;
using ToDo.WPF.ViewModels.Factories;

namespace ToDo.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            IAuthenticationService authentication = serviceProvider.GetRequiredService<IAuthenticationService>();
            
            //await authentication.Login("test", "test");
            
            //IExchangeRateService exchangeRateService = serviceProvider.GetRequiredService<IExchangeRateService>();

            //new ExchangeRateService().GetExchangeRate(RateType.USD).ContinueWith((task) =>
            //{ 
            //    var rate = task.Result; 
            //});
            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();

            //using (IServiceScope scope = serviceProvider.CreateScope())
            //{
            //    var differentViewModel = scope.ServiceProvider.GetRequiredService<MainViewModel>();
            //    var equal = differentViewModel == window.DataContext;
            //}

            base.OnStartup(e);
        }

        private IServiceProvider CreateServiceProvider()
        {
            // singleton - one instance per application
            // transient - different instance everytime
            // scoped - one instance per scope
            IServiceCollection services = new ServiceCollection();

            // to not depend on implementations -> only interfaces matter
            services.AddSingleton<ToDoDbContextFactory>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IDataService<User>, AccountDataService>();
            services.AddSingleton<IAccountService, AccountDataService>(); 
            services.AddSingleton<IExchangeRateService, ExchangeRateService>();
            services.AddSingleton<IExchangeRateService, ExchangeRateService>();

            services.AddSingleton<IPasswordHasher, PasswordHasher>();

            services.AddSingleton<IToDoViewModelAbstractFactory, ToDoViewModelAbstractFactory>();
            services.AddSingleton<IToDoViewModelFactory<HomeViewModel>, HomeViewModelFactory>();
            services.AddSingleton<IToDoViewModelFactory<InboxViewModel>, InboxViewModelFactory>();
            services.AddSingleton<IToDoViewModelFactory<ExchangeRateListingViewModel>, ExchangeRateServiceViewModelFactory>();
            services.AddSingleton<IToDoViewModelFactory<LoginViewModel>, LoginViewModelFactory>();
            services.AddSingleton<IToDoViewModelFactory<SettingsViewModel>, SettingsViewModelFactory>();
            //...

            services.AddScoped<INavigator, Navigator>();
            services.AddScoped<IAuthenticator, Authenticator>();
            services.AddScoped<MainViewModel>();

            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();
        }
    }
}
