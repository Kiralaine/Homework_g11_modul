using Microsoft.AspNetCore.Mvc;
using KnowledgeSystem.Bll.Dtos.EmployeeDto;
using KnowledgeSystem.Bll.Services;

namespace KnowledgeSystem.Api.Controllers;

[Route("api/employee")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService EmployeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        EmployeeService = employeeService;
    }

    [HttpPost("add")]
    public async Task<long> PostEmployee(EmployeeCreateDto employeeCreateDto)
    {
        return await EmployeeService.PostAsync(employeeCreateDto);
    }

    [HttpGet("get-all")]
    public async Task<ICollection<EmployeeGetDto>> GetAll()
    {
        return await EmployeeService.GetAllAsync();
    }

}
