using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandoAPI.Models
{
    public class Job
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ActiveJobs { get; set; }
        public int JobViews { get; set; }
        public int PredictedViews { get; set; }
    }
}
