using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.Helpers;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MarvelUniverseDbContext : DbContext
    {
        // public DbSet<Movie> Movie { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionStringHelper.GetConnectionString());
        }

       

    }
}
