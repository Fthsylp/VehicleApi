using HyperCaseProject.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HyperCaseProject.DataAccessLayer.ApiContext
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        public DbSet<Car>? Cars { get; set; }
        public DbSet<Bus>? Buses { get; set; }
        public DbSet<Boat>? Boats { get; set; }
    }
}