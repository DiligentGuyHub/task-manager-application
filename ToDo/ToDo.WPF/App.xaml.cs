using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
using ToDo.EntityFramework.Services.Common;
using ToDo.WPF.State.Accounts;
using ToDo.WPF.State.Authenticators;
using ToDo.WPF.State.Navigators;
using ToDo.WPF.State.Settings;
using ToDo.WPF.State.Tasks;
using ToDo.WPF.ViewModels;
using ToDo.WPF.ViewModels.Factories;

namespace ToDo.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            // for config + sql connection string + migration
            _host = CreateHostBuilder().Build();
        }
        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            // singleton - one instance per application
            // transient - different instance everytime
            // scoped - one instance per scope
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c=>
                {
                    c.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((context, services) =>
                {
                    // to not depend on implementations -> only interfaces matter
                    string connectionString = context.Configuration.GetConnectionString("default");
                    services.AddDbContext<ToDoDbContext>(o => o.UseSqlServer(connectionString));
                    services.AddSingleton<ToDoDbContextFactory>(new ToDoDbContextFactory(connectionString));
                    services.AddSingleton<IAuthenticationService, AuthenticationService>();
                    services.AddSingleton<IDataService<User>, AccountDataService>();
                    services.AddSingleton<IAccountService, AccountDataService>();
                    services.AddSingleton<IExchangeRateService, ExchangeRateService>();
                    services.AddSingleton<ITaskService, TaskDataService>();

                    services.AddSingleton<IPasswordHasher, PasswordHasher>();

                    services.AddSingleton<IToDoViewModelFactory, ToDoViewModelFactory>();
                    services.AddSingleton<HomeViewModel>(services => new HomeViewModel(
                        ExchangeRateListingViewModel.LoadExchangeIndexViewModel(
                            services.GetRequiredService<IExchangeRateService>()),
                            services.GetRequiredService<IAuthenticator>(),
                            services.GetRequiredService<TaskSummaryViewModel>()
                        ));
                    services.AddSingleton<TaskSummaryViewModel>();
                    services.AddSingleton<TodayViewModel>(services => new TodayViewModel(
                        services.GetRequiredService<ITaskService>(),
                        services.GetRequiredService<IAccountStore>(),
                        services.GetRequiredService<TaskSummaryViewModel>(),
                        services.GetRequiredService<MessageViewModel>()
                        ));
                    services.AddSingleton<SettingsViewModel>();
                    services.AddSingleton<MessageViewModel>();

                    services.AddSingleton<CreateViewModel<HomeViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<HomeViewModel>();
                    });
                    services.AddSingleton<CreateViewModel<TodayViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<TodayViewModel>();
                    });
                    services.AddSingleton<CreateViewModel<SettingsViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<SettingsViewModel>();
                    });
                    services.AddSingleton<CreateViewModel<RegisterViewModel>>(services =>
                    {
                        return () => new RegisterViewModel();
                    });
                    services.AddSingleton<ViewModelDelegateRenavigator<HomeViewModel>>();
                    services.AddSingleton<ViewModelDelegateRenavigator<RegisterViewModel>>();
                    services.AddSingleton<CreateViewModel<LoginViewModel>>(services =>
                    {
                        return () => new LoginViewModel(
                            services.GetRequiredService<IAuthenticator>(),
                            services.GetRequiredService<ViewModelDelegateRenavigator<HomeViewModel>>(),
                            services.GetRequiredService<ViewModelDelegateRenavigator<RegisterViewModel>>(),
                            services.GetRequiredService<MessageViewModel>());
                    });

                    services.AddSingleton<INavigator, Navigator>();
                    services.AddSingleton<IAuthenticator, Authenticator>();
                    services.AddSingleton<IAccountStore, AccountStore>();
                    services.AddSingleton<TaskStore>();
                    services.AddSingleton<ISettings, Settings>();
                    services.AddSingleton<MainViewModel>();

                    services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
                });
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            _host.Start();
            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }
    }
}
