using KnowledgeSystem.Bll.Dtos.KnowledgeDto;
using KnowledgeSystem.Bll.Dtos.EmployeeDto;
using KnowledgeSystem.DataAccess.Entities;

namespace KnowledgeSystem.Bll.Converter;

public static class Mappings
{
    public static EmployeeGetDto ConvertToEmployeeGetDto(Employee employee)
    {
        return new EmployeeGetDto()
        {
            EmployeeId = employee.EmployeeId,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            KnowledgeDtos = employee.Knowledge == null ? new List<KnowledgeGetDto>() : employee.Knowledge.Select(s => ConvertToKnowledgeGetDto(s)).ToList(),
        };
    }

    {
        return new KnowledgeGetDto()
        {
        };
    }

    public static Employee ConvertToEmployee(EmployeeCreateDto employeeCreateDto)
    {
        return new Employee()
        {
            FirstName = employeeCreateDto.FirstName,
            LastName = employeeCreateDto.LastName,
        };
    }


}

