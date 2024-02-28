using ExcelTech.Domain.Entities;
using ExcelTech.Domain.IRepositories;
using ExcelTech.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Infrastructure.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(ExcelDbContext context, DbSet<Patient> entities) : base(context, entities)
        {
        }
    }
}
