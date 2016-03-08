﻿using ProjectSummary.Models;
using ProjectSummary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectSummary.Service.EntityService
{
    public class CitiesService: BaseService<City>
    {
        public CitiesService() : base() { }

        public IEnumerable<SelectListItem> GetSelectedCountries()
        {
            return new CountriesRepository().GetAll().Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.ID.ToString()
            });
        }
    }
}