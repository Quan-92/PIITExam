using PIITExam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIITExam.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("ConnectionString") { }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}