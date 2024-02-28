using ExcelTech.Application.IServices;
using ExcelTech.Domain.DTOs;
using ExcelTech.Domain.Entities;
using ExcelTech.Domain.IRepositories;
using ExcelTech.Domain.IUnitOfWork;
using ExcelTech.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExcelTech.Infrastructure.Services
{
    public class PatientSerivce : IPatientSerivce
    {
        private readonly IPatientRepository _patient;
        private readonly IUnitOfWork _unitOfWork;

        public PatientSerivce(IUnitOfWork unitOfWork, IPatientRepository patient)
        {
            _unitOfWork = unitOfWork;
            _patient = patient;
        }

        public async Task AddAsync(PatientDto dtoObj)
        {
            try
            {


                Patient patient = new Patient
                {
                    PatientName = dtoObj.PatientName,
                    Epilepsy = dtoObj.Epilepsy
                };
                await _patient.AddAsync(patient);
            }
            catch (Exception ex)
            {

            }
        }

        public Task<IEnumerable<PatientDto>> FindAsync(Expression<Func<PatientDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(PatientDto entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PatientDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
