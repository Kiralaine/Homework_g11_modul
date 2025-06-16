using KnowledgeSystem.Bll.Converter;
using KnowledgeSystem.Bll.Dtos.EmployeeDto;
using KnowledgeSystem.Repository.Repositories;

namespace KnowledgeSystem.Bll.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository EmployeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        EmployeeRepository = employeeRepository;
    }

    public async Task<ICollection<EmployeeGetDto>> GetAllAsync()
    {
        var employees = await EmployeeRepository.SelectAllAsync();
        var employeesDto = employees.Select(u => Mappings.ConvertToEmployeeGetDto(u)).ToList();
        return employeesDto;
    }

    public async Task<long> PostAsync(EmployeeCreateDto employeeCreateDto)
    {
        var employee = Mappings.ConvertToEmployee(employeeCreateDto);
        var employeeId = await EmployeeRepository.InsertAsync(employee);
        return employeeId;
    }
}
