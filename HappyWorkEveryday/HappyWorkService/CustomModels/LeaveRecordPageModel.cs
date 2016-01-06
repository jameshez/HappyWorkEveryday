using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyWorkService.CustomModels
{
    public class LeaveRecordPageModel
    {
        public string Alias { get; set; }
        public string EnglishName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double TotalTime { get; set; }
        public string LeaveType { get; set; }

    }
}