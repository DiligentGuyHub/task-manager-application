using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.WPF.ViewModels.Factories
{
    public class HomeViewModelFactory : IToDoViewModelFactory<HomeViewModel>
    {
        private IToDoViewModelFactory<ExchangeRateListingViewModel> _exchangeRateViewModelFactory;

        public HomeViewModelFactory(IToDoViewModelFactory<ExchangeRateListingViewModel> exchangeRateViewModelFactory)
        {
            _exchangeRateViewModelFactory = exchangeRateViewModelFactory;
        }

        public HomeViewModel CreateViewModel()
        {
            return new HomeViewModel(_exchangeRateViewModelFactory.CreateViewModel());
        }
    }
}
