using StopWatch_WPF.Models;
using StopWatch_WPF.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace StopWatch_WPF.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ITimerService _timerService;
        private readonly StopWatchModel _stopwatchModel;
        private readonly DispatcherTimer _dispatcherTimer;
        private string _currentTime;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string CurrentTime 
        {
            get => _currentTime;
            set 
            {
                _currentTime = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));
            }
        }

        public MainViewModel(ITimerService timerService) 
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Tick += new EventHandler(DispatcherTimer_Tick);
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            _dispatcherTimer.Start();

            _stopwatchModel = new StopWatchModel(new Guid("a70cd601-8543-4f5b-a6d9-2d9816a1dc59"));
            
            //_timerService = timerService;
            //_timerService.AddStopWatch(new StopWatchModel(new Guid("a70cd601-8543-4f5b-a6d9-2d9816a1dc59")));
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            DateTime currentDate = DateTime.UtcNow;
            CurrentTime = _stopwatchModel.Time = currentDate.ToString("HH:mm:ss");
        }
    }
}
