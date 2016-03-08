using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSummary.ViewModels.UsersVM
{
    public class UsersListVM:ListVM
    {
        public List<User> Users { get; set; }
    }
}