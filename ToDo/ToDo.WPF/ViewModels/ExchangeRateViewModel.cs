using NbrbAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Services;

namespace ToDo.WPF.ViewModels
{
    public class ExchangeRateViewModel
    {
        private readonly IExchangeRateService _exchangeRateService;
        public Rate USD { get; set; }
        public Rate EUR { get; set; }

        public ExchangeRateViewModel(IExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        public static ExchangeRateViewModel LoadExchangeIndexViewModel(IExchangeRateService exchangeRateService)
        {
            ExchangeRateViewModel exchangeRateViewModel = new ExchangeRateViewModel(exchangeRateService);
            // everything is fine :D
            exchangeRateViewModel.LoadExchangeIndexes();
            return exchangeRateViewModel;
        }

        private void LoadExchangeIndexes()
        {
            _exchangeRateService.GetExchangeRate(RateType.USD).ContinueWith(task =>
            {
                if(task.Exception == null)
                {
                    USD = task.Result;
                }
            });
            _exchangeRateService.GetExchangeRate(RateType.EUR).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    EUR = task.Result;
                }
            });
        }

    }
}
