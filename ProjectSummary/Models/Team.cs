using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSummary.Models
{
    public class Team: BaseModel
    {
        public string Name { get; set; }
        public virtual List<User> Users { get; set; }
    }
}