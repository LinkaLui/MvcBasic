using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class HRContext : DbContext
    {
        public HRContext() : base("name=HrDatabase")
        {

        }

        public DbSet<Friend> Friends { get; set; }

        public DbSet<Employee> Employees { get; set; }

    }
}