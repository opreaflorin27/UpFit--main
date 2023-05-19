using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UpFit__main.Models
{
    public class CodeFirstDb : DbContext
    {
        public DbSet<User> users { get; set; }
    }
}