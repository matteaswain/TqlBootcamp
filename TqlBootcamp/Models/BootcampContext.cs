using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TqlBootcamp.Models
{
// make public and inheriat DbContext 
    public class BootcampContext : DbContext 
    {
// property for table in db 
        public DbSet<Student> Students { get; set; } // 

 // going to set up sql server connection 
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress01;database=BootCampDb;trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }

        }
// used for fluid api 
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }






    }
}
