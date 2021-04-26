using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ExchangeRateViewModel ExchangeRateViewModel { get; set; }

        public HomeViewModel(ExchangeRateViewModel exchangeRateViewModel)
        {
            ExchangeRateViewModel = exchangeRateViewModel;
        }
    }
}
