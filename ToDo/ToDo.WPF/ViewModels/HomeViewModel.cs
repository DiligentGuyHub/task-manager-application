using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ExchangeRateListingViewModel ExchangeRateListingViewModel { get; set; }

        public HomeViewModel(ExchangeRateListingViewModel exchangeRateViewModel)
        {
            ExchangeRateListingViewModel = exchangeRateViewModel;
        }
    }
}
