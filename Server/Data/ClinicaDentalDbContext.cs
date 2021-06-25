using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaDental.Shared.Models;

namespace ClinicaDental.Server.Data
{
    public class ClinicaDentalDbContext : DbContext
    {
        public ClinicaDentalDbContext (DbContextOptions<ClinicaDentalDbContext> options) : base(options)
        {

        }

        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Dentistas> Dentistas { get; set; }
    }
}
