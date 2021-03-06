﻿using Domain.Core.Model.Enums;

namespace smart_home_web.Models.ReportElements
{
	public class EditReportElementViewModel
    {
        public int Id { get; set; }
        public int DashboardId { get; set; }
        public string DashboardName { get; set; }
        public int SensorId { get; set; }
        public string SensorName { get; set; }
        public ReportElementHours Hours { get; set; }

        public ReportElementType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
