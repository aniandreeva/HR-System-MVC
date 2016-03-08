using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSummary.ViewModels.CitiesVM
{
    public class CitiesListVM:ListVM
    {
        public List<City> Cities { get; set; }
    }
}