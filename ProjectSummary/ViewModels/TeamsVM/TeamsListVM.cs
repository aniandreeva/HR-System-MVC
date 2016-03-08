using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSummary.ViewModels.TeamsVM
{
    public class TeamsListVM: ListVM
    {
        public List<Team> Teams { get; set; }
    }
}