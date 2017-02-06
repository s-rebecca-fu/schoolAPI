using APILab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APILab.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("DefaultConnection") { }
        public DbSet<Student> Students { get; set; }
    }
}