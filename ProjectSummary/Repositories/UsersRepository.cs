﻿using ProjectSummary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSummary.Repositories
{
    public class UsersRepository:BaseRepository<User>
    {
        public UsersRepository(): base(){}
    }
}