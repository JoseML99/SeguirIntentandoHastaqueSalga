using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APITarea.Models
{
    public class DataContextP:DbContext
    {
        public DataContextP():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APITarea.Models.Product> Products { get; set; }
    }
}