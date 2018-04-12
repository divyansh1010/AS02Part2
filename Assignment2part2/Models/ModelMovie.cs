using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Assignment2part2.Models
{
    
    public class ModelMovie : DbContext
    {


        public ModelMovie(DbContextOptions<ModelMovie> options) : base(options)
        {

        }




        public DbSet<Movie> Movie { get; set; }
        public DbSet<Popular> Popular { get; set; }
    }
}