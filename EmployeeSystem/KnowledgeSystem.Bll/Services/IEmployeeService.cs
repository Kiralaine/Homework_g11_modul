using KnowledgeSystem.Bll.Dtos.EmployeeDto;

namespace KnowledgeSystem.Bll.Services;

public interface IEmployeeService
{
    Task<long> PostAsync(EmployeeCreateDto employeeCreateDto);
    Task<ICollection<EmployeeGetDto>> GetAllAsync();
}