using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public class DataContextC : DbContext
    {
        public DataContextC() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCTarea.Models.Client> Clients { get; set; }
    }
}