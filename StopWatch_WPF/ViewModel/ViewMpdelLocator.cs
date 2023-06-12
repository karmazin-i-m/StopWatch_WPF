using StopWatch_WPF.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_WPF.ViewModel
{
    public class ViewModelLocator
    {
        private readonly MainViewModel _mainViewModel;
        private readonly ITimerService _timerService;
        public MainViewModel MainViewModel => _mainViewModel;
        public ViewModelLocator()
        {
            //_timerService = new TimerService();
            _mainViewModel = new MainViewModel(_timerService);
        }
    }
}
