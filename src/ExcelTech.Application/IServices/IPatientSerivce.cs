using ExcelTech.Domain.DTOs;
using System.Linq.Expressions;


namespace ExcelTech.Application.IServices
{
    public interface IPatientSerivce
    {
        Task<PatientDto> GetByIdAsync(int id);
        Task<IEnumerable<PatientDto>> GetAllAsync();
        Task<IEnumerable<PatientDto>> FindAsync(Expression<Func<PatientDto, bool>> condition);
        Task AddAsync(PatientDto entity);
        void Update(PatientDto entity);
        void Remove(PatientDto entity);
    }
}
