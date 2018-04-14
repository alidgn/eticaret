using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Ticaret.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
    }
}