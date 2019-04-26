using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public class DataContextS : DbContext
    {
        public DataContextS() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APITarea.Models.Sale> Sales { get; set; }
    }
}