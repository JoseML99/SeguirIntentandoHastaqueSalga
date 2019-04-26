using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public class DataContextC : DbContext
    {
        public DataContextC() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APITarea.Models.Client> Clients { get; set; }
    }
}