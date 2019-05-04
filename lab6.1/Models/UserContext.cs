using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab6._1.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}