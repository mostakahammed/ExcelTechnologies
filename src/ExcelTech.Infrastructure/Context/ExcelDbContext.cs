using ExcelTech.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Infrastructure.Context
{
    public class ExcelDbContext: DbContext
    {
        public ExcelDbContext(DbContextOptions<ExcelDbContext> options):base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Disease> Disease { get; set; }
        public DbSet<NCDDto> NCD { get; set; }
        public DbSet<NCD_DetailsDto> NCD_Details { get; set; }
        public DbSet<Allergy> Allergy  { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }
    }
}
