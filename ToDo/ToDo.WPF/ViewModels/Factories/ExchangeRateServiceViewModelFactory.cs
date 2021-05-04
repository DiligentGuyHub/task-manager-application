using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Services;

namespace ToDo.WPF.ViewModels.Factories
{
    public class ExchangeRateServiceViewModelFactory : IToDoViewModelFactory<ExchangeRateListingViewModel>
    {
        private readonly IExchangeRateService _exchangeRateService;

        public ExchangeRateServiceViewModelFactory(IExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        public ExchangeRateListingViewModel CreateViewModel()
        {
            return ExchangeRateListingViewModel.LoadExchangeIndexViewModel(_exchangeRateService);
        }
    }
}
