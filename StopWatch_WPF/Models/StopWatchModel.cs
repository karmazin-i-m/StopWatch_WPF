using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch_WPF.Models
{
    public class StopWatchModel
    {
        public Guid Id { get; set; }
        public string Time { get; set; } = "00:00:00";

        public StopWatchModel(Guid id)
        {
            Id = id;
        }
    }
}
