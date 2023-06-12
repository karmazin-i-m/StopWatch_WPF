using StopWatch_WPF.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_WPF.Services
{
    public class TimerService : ITimerService
    {
        private readonly List<StopWatchModel> _models;
        private int _currentItemCount = 0;

        public TimerService()
        {
            _models = new List<StopWatchModel>();
        }

        public void AddStopWatch(StopWatchModel swm)
        {
            _models.Add(swm);
        }

        public void DeleteStopWatch(Guid swmId)
        {
            StopWatchModel element = _models.First(m => m.Id == swmId);
            _models.Remove(element);
        }

        public List<StopWatchModel> GetStopWatchModels()
        {
            return _models;
        }
    }

    public interface ITimerService
    {
        void AddStopWatch(StopWatchModel swm);
        void DeleteStopWatch(Guid swmId);
        List<StopWatchModel> GetStopWatchModels();
    }
}
