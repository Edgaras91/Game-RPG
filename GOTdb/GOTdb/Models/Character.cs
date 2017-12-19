using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GOTdb.Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string House { get; set; }


    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Character> Movies { get; set; }
    }
}