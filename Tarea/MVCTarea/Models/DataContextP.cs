using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTarea.Models
{
    public class DataContextP:DbContext
    {
        public DataContextP():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCTarea.Models.Product> Products { get; set; }
    }
}