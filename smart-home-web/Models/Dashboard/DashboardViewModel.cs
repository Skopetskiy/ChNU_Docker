﻿
using Domain.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Business.DTOs.ReportElements;

namespace smart_home_web.Models.Dashboard
{
    public class DashboardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsPublic { get; set; }
        public string DashCreatorUserName { get; set; }
        public string IconPath { get; set; }

        public ICollection<ReportElementDto> ReportElements { get; set; }
    }
}
