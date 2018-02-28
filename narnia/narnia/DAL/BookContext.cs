using narnia.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace narnia.DAL
{
    public class BookContext: DbContext
    {
        public BookContext() : base("BookContext")
        {


        }

        public DbSet<book> Books { get; set; }

        public DbSet<author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}